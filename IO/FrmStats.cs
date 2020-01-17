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
    public partial class FrmStats : Form
    {
        public FrmStats()
        {
            InitializeComponent();
        }
        decimal score;
        decimal count;
        decimal average;
        
        List<player> players = PlayerDB.GetPlayers(file.filename);
        

        private void FrmStats_Load(object sender, EventArgs e)
        {

           

            //in list check column 0 and column 1 for comparison. 
            foreach (player p in players)
            {

                if (p.PlayerName == GameDate.SelectedUser && p.GameDate == GameDate.Date)
                {
                    lblHoles.Text = p.Scores.Count.ToString();


                    for(int i = 0; i <p.Scores.Count; i++)
                    {
                        count = p.Scores.Count;
                        score = score + p.Scores[i];
                    }
                    average = score / count;
                    lblScoreAvg.Text = average.ToString();
                  
                    
                }
                else
                {
                    continue; 
                }

            }
            
          
        }


    }
    
}
