using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IO
{
    public partial class FrmIO : Form
    {
        public FrmIO()
        {
            InitializeComponent();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            FrmNewGame newGame = new FrmNewGame();
            newGame.Show();


        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            FrmGame ContinueGame = new FrmGame();
            ContinueGame.Show();
        
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            FrmStats Stats = new FrmStats();
            Stats.Show(); 
        }
    }
}
