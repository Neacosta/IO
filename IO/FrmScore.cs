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
    public partial class FrmScore : Form
    {
        int score;
        public FrmScore()
        {
            InitializeComponent();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //close add score form
            this.Close();

            //open game main screen
            FrmGame newgame = new FrmGame();
                newgame.Show();
        

        }

        private void btnScore_Click(object sender, EventArgs e)
        {


        List<player> players = PlayerDB.GetPlayers(file.filename);

            score = Convert.ToInt32(txtScore.Text);

            //clear old file
            File.Create(file.filename).Close();

          //in list check column 0 and column 1 for comparison. 
            foreach (player p in players)
            {
            
                if (p.PlayerName == GameDate.SelectedUser && p.GameDate == GameDate.Date)
                {
                    //if true then add sore to next available column for the person.
                    p.Scores.Add(score);
                    WriteLine(p);
                    continue;
                }
                else {
                    WriteLine(p);
                }

            }
            //clear input screen so multiple scores can be added.
            txtScore.Text = "";
      }
     
        public void WriteLine(player p)
        {
            //convert scores to a string
            string scores = string.Join("|", p.Scores.ToArray());
            //Write Entry
            File.AppendAllText((file.filename), p.PlayerName + "|" + p.GameDate.ToShortDateString().ToString() + "|" + scores + "|" + Environment.NewLine);

        }

        private void FrmScore_Load(object sender, EventArgs e)
        {

        }
    }
}
