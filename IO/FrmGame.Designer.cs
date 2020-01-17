namespace IO
{
    partial class FrmGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboGameDates = new System.Windows.Forms.ComboBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstGameStats = new System.Windows.Forms.ListView();
            this.lklblNewGame = new System.Windows.Forms.LinkLabel();
            this.btnStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Game to Work With:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboGameDates
            // 
            this.cboGameDates.FormattingEnabled = true;
            this.cboGameDates.Location = new System.Drawing.Point(176, 22);
            this.cboGameDates.Name = "cboGameDates";
            this.cboGameDates.Size = new System.Drawing.Size(121, 21);
            this.cboGameDates.TabIndex = 1;
            this.cboGameDates.SelectedIndexChanged += new System.EventHandler(this.cboGameDates_SelectedIndexChanged);
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(572, 16);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(129, 23);
            this.btnAddPlayer.TabIndex = 3;
            this.btnAddPlayer.Text = "Add New Player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(572, 67);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Add New Score";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.Location = new System.Drawing.Point(572, 122);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(129, 23);
            this.btnDeletePlayer.TabIndex = 5;
            this.btnDeletePlayer.Text = "DeletePlayer";
            this.btnDeletePlayer.UseVisualStyleBackColor = true;
            this.btnDeletePlayer.Click += new System.EventHandler(this.btnDeletePlayer_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(572, 229);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstGameStats
            // 
            this.lstGameStats.FullRowSelect = true;
            this.lstGameStats.Location = new System.Drawing.Point(15, 59);
            this.lstGameStats.Name = "lstGameStats";
            this.lstGameStats.Size = new System.Drawing.Size(465, 199);
            this.lstGameStats.TabIndex = 7;
            this.lstGameStats.UseCompatibleStateImageBehavior = false;
            this.lstGameStats.SelectedIndexChanged += new System.EventHandler(this.lstGameStats_SelectedIndexChanged);
            // 
            // lklblNewGame
            // 
            this.lklblNewGame.AutoSize = true;
            this.lklblNewGame.Location = new System.Drawing.Point(315, 26);
            this.lklblNewGame.Name = "lklblNewGame";
            this.lklblNewGame.Size = new System.Drawing.Size(57, 13);
            this.lklblNewGame.TabIndex = 8;
            this.lklblNewGame.TabStop = true;
            this.lklblNewGame.Text = "NewGame";
            this.lklblNewGame.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblNewGame_LinkClicked);
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(572, 170);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(129, 23);
            this.btnStats.TabIndex = 9;
            this.btnStats.Text = "Stats";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 277);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.lklblNewGame);
            this.Controls.Add(this.lstGameStats);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeletePlayer);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.cboGameDates);
            this.Controls.Add(this.label1);
            this.Name = "FrmGame";
            this.Text = "FrmGame";
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboGameDates;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeletePlayer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView lstGameStats;
        private System.Windows.Forms.LinkLabel lklblNewGame;
        private System.Windows.Forms.Button btnStats;
    }
}