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
    public partial class FrmAddPlayer : Form
    {
        public FrmAddPlayer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        
            String Strname = txtPlayerName.Text;
            PlayerDB.AddPlayers(file.filename, GameDate.Date, Strname);
            this.Close();

            //reopen game form. Doing this to get a refresh of the file.
            FrmGame newg = new FrmGame();
            newg.Show();
        }

        private void FrmAddPlayer_Load(object sender, EventArgs e)
        {

        }
    }
}
