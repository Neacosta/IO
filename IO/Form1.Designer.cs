namespace IO
{
    partial class FrmIO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGame = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGame
            // 
            this.btnGame.Location = new System.Drawing.Point(84, 50);
            this.btnGame.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(364, 44);
            this.btnGame.TabIndex = 0;
            this.btnGame.Text = "Open or Make New Game File";
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(200, 167);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(150, 44);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Text = "Continue Game";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // FrmIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 342);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnGame);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmIO";
            this.Text = "File Streaming Application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnContinue;
    }
}

