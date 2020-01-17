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


    public partial class FrmNewGame : Form
    {
    

        public FrmNewGame()
        {
            InitializeComponent();
        }

        public void btnChoose_Click(object sender, EventArgs e)
        {
            //set file size
            int x = -1;

            //show dialog box to select file
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //get file name
                string filename = openFileDialog1.FileName;

                try
                {
                    
                   
                    //ensure file has contents
                    string text = File.ReadAllText(filename);

                    //get file lenth , could check for a valid number here.
                    x = text.Length;


                    //set object to file name to re-open game.
                    file.setFile(filename);
                   


                }
                catch (IOException)
                {
                    MessageBox.Show("Not a proper File");
                }
                catch(Exception ex)
                {
                    throw ex;
                }

                this.Close();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
        
            string dir = @"C:\C# 2015\Files\";
            string path = dir + "GolfScores.txt";

            Directory.CreateDirectory(dir);
            file.setFile(path);
        }

   

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
