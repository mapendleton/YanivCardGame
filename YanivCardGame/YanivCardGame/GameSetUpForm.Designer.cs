namespace YanivCardGame
{
    partial class GameSetUpForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numComBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.difficultyBox = new System.Windows.Forms.ListBox();
            this.playButton = new System.Windows.Forms.Button();
            this.displayRulesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numComBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(592, 142);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(131, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "What is your name?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "How many computer players?";
            // 
            // numComBox
            // 
            this.numComBox.Location = new System.Drawing.Point(592, 187);
            this.numComBox.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numComBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numComBox.Name = "numComBox";
            this.numComBox.Size = new System.Drawing.Size(131, 22);
            this.numComBox.TabIndex = 4;
            this.numComBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Computer Difficulty";
            // 
            // difficultyBox
            // 
            this.difficultyBox.FormattingEnabled = true;
            this.difficultyBox.HorizontalScrollbar = true;
            this.difficultyBox.ItemHeight = 16;
            this.difficultyBox.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Difficult"});
            this.difficultyBox.Location = new System.Drawing.Point(592, 232);
            this.difficultyBox.Name = "difficultyBox";
            this.difficultyBox.Size = new System.Drawing.Size(131, 52);
            this.difficultyBox.TabIndex = 6;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(592, 375);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(131, 46);
            this.playButton.TabIndex = 7;
            this.playButton.Text = "Play!";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // displayRulesButton
            // 
            this.displayRulesButton.Location = new System.Drawing.Point(245, 122);
            this.displayRulesButton.Name = "displayRulesButton";
            this.displayRulesButton.Size = new System.Drawing.Size(91, 40);
            this.displayRulesButton.TabIndex = 8;
            this.displayRulesButton.Text = "Rules";
            this.displayRulesButton.UseVisualStyleBackColor = true;
            // 
            // GameSetUpForm
            // 
            this.AcceptButton = this.playButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 898);
            this.Controls.Add(this.displayRulesButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.difficultyBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numComBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Name = "GameSetUpForm";
            this.Text = "Yaniv Card Game";
            ((System.ComponentModel.ISupportInitialize)(this.numComBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numComBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox difficultyBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button displayRulesButton;
    }
}