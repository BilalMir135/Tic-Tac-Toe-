namespace TicTacToe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startNewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTicTacToeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.but1 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.but4 = new System.Windows.Forms.Button();
            this.but5 = new System.Windows.Forms.Button();
            this.but6 = new System.Windows.Forms.Button();
            this.but7 = new System.Windows.Forms.Button();
            this.but8 = new System.Windows.Forms.Button();
            this.but9 = new System.Windows.Forms.Button();
            this.gbxPlayersName = new System.Windows.Forms.GroupBox();
            this.tbxPlayer2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPlayer1 = new System.Windows.Forms.TextBox();
            this.gbxXplayer = new System.Windows.Forms.GroupBox();
            this.radbutPlayer2X = new System.Windows.Forms.RadioButton();
            this.radbutPlayer1X = new System.Windows.Forms.RadioButton();
            this.gbxStartPlayer = new System.Windows.Forms.GroupBox();
            this.radbutPlayer2 = new System.Windows.Forms.RadioButton();
            this.radbutPlayer1 = new System.Windows.Forms.RadioButton();
            this.aboutDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.gbxPlayersName.SuspendLayout();
            this.gbxXplayer.SuspendLayout();
            this.gbxStartPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startNewGameToolStripMenuItem,
            this.resetGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // startNewGameToolStripMenuItem
            // 
            this.startNewGameToolStripMenuItem.Name = "startNewGameToolStripMenuItem";
            this.startNewGameToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.startNewGameToolStripMenuItem.Text = "&Start New Game";
            this.startNewGameToolStripMenuItem.Click += new System.EventHandler(this.startNewGameToolStripMenuItem_Click);
            // 
            // resetGameToolStripMenuItem
            // 
            this.resetGameToolStripMenuItem.Name = "resetGameToolStripMenuItem";
            this.resetGameToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.resetGameToolStripMenuItem.Text = "&Reset Game";
            this.resetGameToolStripMenuItem.Click += new System.EventHandler(this.resetGameToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTicTacToeToolStripMenuItem,
            this.aboutDeveloperToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutTicTacToeToolStripMenuItem
            // 
            this.aboutTicTacToeToolStripMenuItem.Name = "aboutTicTacToeToolStripMenuItem";
            this.aboutTicTacToeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.aboutTicTacToeToolStripMenuItem.Text = "&About Tic Tac Toe";
            this.aboutTicTacToeToolStripMenuItem.Click += new System.EventHandler(this.aboutTicTacToeToolStripMenuItem_Click);
            // 
            // but1
            // 
            this.but1.BackColor = System.Drawing.Color.White;
            this.but1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.but1.Location = new System.Drawing.Point(13, 39);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(79, 72);
            this.but1.TabIndex = 0;
            this.but1.UseVisualStyleBackColor = false;
            this.but1.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // but2
            // 
            this.but2.BackColor = System.Drawing.Color.White;
            this.but2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but2.Location = new System.Drawing.Point(103, 39);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(79, 72);
            this.but2.TabIndex = 1;
            this.but2.UseVisualStyleBackColor = false;
            this.but2.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // but3
            // 
            this.but3.BackColor = System.Drawing.Color.White;
            this.but3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but3.Location = new System.Drawing.Point(193, 39);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(79, 72);
            this.but3.TabIndex = 1;
            this.but3.UseVisualStyleBackColor = false;
            this.but3.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // but4
            // 
            this.but4.BackColor = System.Drawing.Color.White;
            this.but4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but4.Location = new System.Drawing.Point(13, 129);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(79, 72);
            this.but4.TabIndex = 1;
            this.but4.UseVisualStyleBackColor = false;
            this.but4.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // but5
            // 
            this.but5.BackColor = System.Drawing.Color.White;
            this.but5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but5.Location = new System.Drawing.Point(103, 129);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(79, 72);
            this.but5.TabIndex = 1;
            this.but5.UseVisualStyleBackColor = false;
            this.but5.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // but6
            // 
            this.but6.BackColor = System.Drawing.Color.White;
            this.but6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but6.Location = new System.Drawing.Point(193, 129);
            this.but6.Name = "but6";
            this.but6.Size = new System.Drawing.Size(79, 72);
            this.but6.TabIndex = 1;
            this.but6.UseVisualStyleBackColor = false;
            this.but6.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // but7
            // 
            this.but7.BackColor = System.Drawing.Color.White;
            this.but7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but7.Location = new System.Drawing.Point(13, 223);
            this.but7.Name = "but7";
            this.but7.Size = new System.Drawing.Size(79, 72);
            this.but7.TabIndex = 1;
            this.but7.UseVisualStyleBackColor = false;
            this.but7.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // but8
            // 
            this.but8.BackColor = System.Drawing.Color.White;
            this.but8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but8.Location = new System.Drawing.Point(103, 223);
            this.but8.Name = "but8";
            this.but8.Size = new System.Drawing.Size(79, 72);
            this.but8.TabIndex = 1;
            this.but8.UseVisualStyleBackColor = false;
            this.but8.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // but9
            // 
            this.but9.BackColor = System.Drawing.Color.White;
            this.but9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but9.Location = new System.Drawing.Point(193, 223);
            this.but9.Name = "but9";
            this.but9.Size = new System.Drawing.Size(79, 72);
            this.but9.TabIndex = 1;
            this.but9.UseVisualStyleBackColor = false;
            this.but9.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // gbxPlayersName
            // 
            this.gbxPlayersName.BackColor = System.Drawing.Color.Transparent;
            this.gbxPlayersName.Controls.Add(this.tbxPlayer2);
            this.gbxPlayersName.Controls.Add(this.label2);
            this.gbxPlayersName.Controls.Add(this.label1);
            this.gbxPlayersName.Controls.Add(this.tbxPlayer1);
            this.gbxPlayersName.Location = new System.Drawing.Point(290, 39);
            this.gbxPlayersName.Name = "gbxPlayersName";
            this.gbxPlayersName.Size = new System.Drawing.Size(298, 72);
            this.gbxPlayersName.TabIndex = 2;
            this.gbxPlayersName.TabStop = false;
            this.gbxPlayersName.Text = "Players Name";
            // 
            // tbxPlayer2
            // 
            this.tbxPlayer2.Location = new System.Drawing.Point(105, 43);
            this.tbxPlayer2.Name = "tbxPlayer2";
            this.tbxPlayer2.Size = new System.Drawing.Size(162, 20);
            this.tbxPlayer2.TabIndex = 4;
            this.tbxPlayer2.Text = "Player2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player Two Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player One Name:";
            // 
            // tbxPlayer1
            // 
            this.tbxPlayer1.Location = new System.Drawing.Point(105, 17);
            this.tbxPlayer1.Name = "tbxPlayer1";
            this.tbxPlayer1.Size = new System.Drawing.Size(162, 20);
            this.tbxPlayer1.TabIndex = 4;
            this.tbxPlayer1.Text = "Player1";
            // 
            // gbxXplayer
            // 
            this.gbxXplayer.BackColor = System.Drawing.Color.Transparent;
            this.gbxXplayer.Controls.Add(this.radbutPlayer2X);
            this.gbxXplayer.Controls.Add(this.radbutPlayer1X);
            this.gbxXplayer.Location = new System.Drawing.Point(290, 129);
            this.gbxXplayer.Name = "gbxXplayer";
            this.gbxXplayer.Size = new System.Drawing.Size(298, 72);
            this.gbxXplayer.TabIndex = 2;
            this.gbxXplayer.TabStop = false;
            this.gbxXplayer.Text = "X For Player";
            // 
            // radbutPlayer2X
            // 
            this.radbutPlayer2X.AutoSize = true;
            this.radbutPlayer2X.Location = new System.Drawing.Point(163, 30);
            this.radbutPlayer2X.Name = "radbutPlayer2X";
            this.radbutPlayer2X.Size = new System.Drawing.Size(78, 17);
            this.radbutPlayer2X.TabIndex = 0;
            this.radbutPlayer2X.Text = "Player Two";
            this.radbutPlayer2X.UseVisualStyleBackColor = true;
            // 
            // radbutPlayer1X
            // 
            this.radbutPlayer1X.AutoSize = true;
            this.radbutPlayer1X.Checked = true;
            this.radbutPlayer1X.Location = new System.Drawing.Point(16, 30);
            this.radbutPlayer1X.Name = "radbutPlayer1X";
            this.radbutPlayer1X.Size = new System.Drawing.Size(77, 17);
            this.radbutPlayer1X.TabIndex = 0;
            this.radbutPlayer1X.TabStop = true;
            this.radbutPlayer1X.Text = "Player One";
            this.radbutPlayer1X.UseVisualStyleBackColor = true;
            // 
            // gbxStartPlayer
            // 
            this.gbxStartPlayer.BackColor = System.Drawing.Color.Transparent;
            this.gbxStartPlayer.Controls.Add(this.radbutPlayer2);
            this.gbxStartPlayer.Controls.Add(this.radbutPlayer1);
            this.gbxStartPlayer.Location = new System.Drawing.Point(290, 223);
            this.gbxStartPlayer.Name = "gbxStartPlayer";
            this.gbxStartPlayer.Size = new System.Drawing.Size(298, 72);
            this.gbxStartPlayer.TabIndex = 2;
            this.gbxStartPlayer.TabStop = false;
            this.gbxStartPlayer.Text = "Start Player";
            // 
            // radbutPlayer2
            // 
            this.radbutPlayer2.AutoSize = true;
            this.radbutPlayer2.Location = new System.Drawing.Point(163, 30);
            this.radbutPlayer2.Name = "radbutPlayer2";
            this.radbutPlayer2.Size = new System.Drawing.Size(78, 17);
            this.radbutPlayer2.TabIndex = 0;
            this.radbutPlayer2.Text = "Player Two";
            this.radbutPlayer2.UseVisualStyleBackColor = true;
            // 
            // radbutPlayer1
            // 
            this.radbutPlayer1.AutoSize = true;
            this.radbutPlayer1.Checked = true;
            this.radbutPlayer1.Location = new System.Drawing.Point(16, 30);
            this.radbutPlayer1.Name = "radbutPlayer1";
            this.radbutPlayer1.Size = new System.Drawing.Size(77, 17);
            this.radbutPlayer1.TabIndex = 0;
            this.radbutPlayer1.TabStop = true;
            this.radbutPlayer1.Text = "Player One";
            this.radbutPlayer1.UseVisualStyleBackColor = true;
            // 
            // aboutDeveloperToolStripMenuItem
            // 
            this.aboutDeveloperToolStripMenuItem.Name = "aboutDeveloperToolStripMenuItem";
            this.aboutDeveloperToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.aboutDeveloperToolStripMenuItem.Text = "&About Developer";
            this.aboutDeveloperToolStripMenuItem.Click += new System.EventHandler(this.aboutDeveloperToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 319);
            this.Controls.Add(this.gbxStartPlayer);
            this.Controls.Add(this.gbxXplayer);
            this.Controls.Add(this.gbxPlayersName);
            this.Controls.Add(this.but9);
            this.Controls.Add(this.but6);
            this.Controls.Add(this.but3);
            this.Controls.Add(this.but8);
            this.Controls.Add(this.but7);
            this.Controls.Add(this.but5);
            this.Controls.Add(this.but4);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIC TAC TOE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxPlayersName.ResumeLayout(false);
            this.gbxPlayersName.PerformLayout();
            this.gbxXplayer.ResumeLayout(false);
            this.gbxXplayer.PerformLayout();
            this.gbxStartPlayer.ResumeLayout(false);
            this.gbxStartPlayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startNewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTicTacToeToolStripMenuItem;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button but5;
        private System.Windows.Forms.Button but6;
        private System.Windows.Forms.Button but7;
        private System.Windows.Forms.Button but8;
        private System.Windows.Forms.Button but9;
        private System.Windows.Forms.GroupBox gbxPlayersName;
        private System.Windows.Forms.TextBox tbxPlayer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPlayer1;
        private System.Windows.Forms.GroupBox gbxXplayer;
        private System.Windows.Forms.RadioButton radbutPlayer2X;
        private System.Windows.Forms.RadioButton radbutPlayer1X;
        private System.Windows.Forms.GroupBox gbxStartPlayer;
        private System.Windows.Forms.RadioButton radbutPlayer2;
        private System.Windows.Forms.RadioButton radbutPlayer1;
        private System.Windows.Forms.ToolStripMenuItem aboutDeveloperToolStripMenuItem;
    }
}

