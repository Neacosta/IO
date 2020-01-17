using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IO
{
    public partial class FrmGame : Form
    {
        string Playername;

        public List<player> players = new List<player>();

        public FrmGame()
        {
            InitializeComponent();
        }

    

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmGame_Load(object sender, EventArgs e)
        {
            try
            {
                //set filename to the path. if there is a file than load the GetPlayers Method
                string filename = file.GetFilePath();
                players = PlayerDB.GetPlayers(filename);
            }
            catch (Exception)
            {
                //No Game File Chosen
                MessageBox.Show("Game File not Chosen", "Which Game?", MessageBoxButtons.OK);
                this.Close();
            }

            //Get the dates out of the list and populate the combo box.
            LoadDates();


        }
        public void LoadDates()
        {


            //  Get Dates only
            List<DateTime> dates = new List<DateTime>();
            foreach (player p in players)
            {
                dates.Add(p.GameDate);
                //cboGameDates.Items.Add(p.GameDate);
            }

            //get distinct dates and load into combo box
            List<DateTime> distinct = dates.Distinct().ToList();
            foreach (var d in distinct)
            {
                cboGameDates.Items.Add(d);
            }


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboGameDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get date from combo box and pass to load players method.
            DateTime Date = Convert.ToDateTime(cboGameDates.SelectedItem.ToString());
            LoadPlayers(Date);

            //Set date to be used if adding or updating score(s) and players
            GameDate.setDate(Date);
        }


        public void LoadPlayers(DateTime Date)
        {
            int i = 1;
            lstGameStats.Clear();

            //load header
            lstGameStats.View = View.Details;
            lstGameStats.Columns.Add("Row Number", 100, HorizontalAlignment.Left);
            lstGameStats.Columns.Add("Player Name", 100, HorizontalAlignment.Left);
            lstGameStats.Columns.Add("Scores", 250, HorizontalAlignment.Left);

            //get original list of all players.
           // List<player> filtered = new List<player>();

            //filter down to only the ones with the date chosen in the drop down box
            foreach (player p in players)
            {
                //display all players in list box
                if (p.GameDate == Date)
                {

                    string scores = string.Join(" ", p.Scores.ToArray());


                    ListViewItem row = new ListViewItem(i.ToString());
                    row.SubItems.Add(p.PlayerName);
                    row.SubItems.Add(scores.ToString());
                    
                    lstGameStats.Items.Add(row);
                    i++;

                }
                

            }


      

        }

     private void btnUpdate_Click(object sender, EventArgs e)
    {
            try
            {
                SetUserName();

                //close the game form.
                this.Close();

                //open the score form
                FrmScore newscore = new FrmScore();
                newscore.Show();
            }
            catch (Exception)
            {
                //user forgot to pick a player.
                MessageBox.Show("Choose a Player Entry", "Selection Error", MessageBoxButtons.OK);
            }
            
    }

        private void lstGameStats_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {

            //open add player form
            FrmAddPlayer addPlayer = new FrmAddPlayer();
            addPlayer.Show();

            //close game form
            this.Close();

           
      
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
          

            try
            {
                //store user name and date. 
                SetUserName();

                //get row number to remove from list
                int counter = 0;

                //fill list with players object
                List<player> players = PlayerDB.GetPlayers(file.filename);

                //clear old game file. 
                File.Create(file.filename).Close();

        

                //look at each object in the players list.
                foreach (player p in players.ToList())
                { 
                   
                    //if player is the one selected

                    if (p.PlayerName == GameDate.SelectedUser && p.GameDate == GameDate.Date)
                    {
                        //remove at the index of current position
                        players.RemoveAt(counter);
                        continue;
                    }
                    else
                    {
               

                        //convert scores to a string
                        string scores = string.Join("|", p.Scores.ToArray());
                        //Write Entry
                        File.AppendAllText((file.filename), p.PlayerName + "|" + p.GameDate.ToShortDateString().ToString() + "|" + scores + "|" + Environment.NewLine);

                    }
                    counter++;
                }
               
             
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Selection Error", MessageBoxButtons.OK);
            }

            resetForm();

            }

        public void SetUserName()
        {
            //Get Players Name
            Playername = lstGameStats.FocusedItem.SubItems[1].Text.ToString();

            //Set static property SelectedUser as playername so we can hold that value for later.
            GameDate.SelectedUser = Playername;

            //Set game date from drop down list. set to static property gamedate so we know what game were working on.
            DateTime d = Convert.ToDateTime(cboGameDates.SelectedItem.ToString());
            GameDate.setDate(Convert.ToDateTime(d.ToShortDateString()));

        }

        public void resetForm()
        {
            FrmGame objGame = new FrmGame();
            this.Dispose();
            objGame.Show();

        }

        private void lklblNewGame_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //for a new game set the date to today.
            GameDate.Date = Convert.ToDateTime(DateTime.Today.Date.ToShortDateString().ToString());
            MessageBox.Show("Game Created", "New Game", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //add a new player and close this screen.
            FrmAddPlayer objAdd = new FrmAddPlayer();
            objAdd.Show();
            this.Close();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            try
            {
                //Set the UserName to View
                SetUserName();

                //Open Stats Form
                FrmStats objStats = new FrmStats();
                objStats.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Select a User.");
            }
        }
    }
   

}
