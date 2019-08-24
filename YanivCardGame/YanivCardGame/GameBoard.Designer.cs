namespace YanivCardGame
{
    partial class GameBoard
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
            this.pictureDeck = new System.Windows.Forms.PictureBox();
            this.pictureDiscard = new System.Windows.Forms.PictureBox();
            this.playerCard1 = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.playerCard2 = new System.Windows.Forms.PictureBox();
            this.playerCard3 = new System.Windows.Forms.PictureBox();
            this.playerCard4 = new System.Windows.Forms.PictureBox();
            this.playerCard5 = new System.Windows.Forms.PictureBox();
            this.mainMessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDiscard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureDeck
            // 
            this.pictureDeck.Location = new System.Drawing.Point(287, 237);
            this.pictureDeck.Name = "pictureDeck";
            this.pictureDeck.Size = new System.Drawing.Size(190, 250);
            this.pictureDeck.TabIndex = 0;
            this.pictureDeck.TabStop = false;
            // 
            // pictureDiscard
            // 
            this.pictureDiscard.Location = new System.Drawing.Point(565, 237);
            this.pictureDiscard.Name = "pictureDiscard";
            this.pictureDiscard.Size = new System.Drawing.Size(190, 250);
            this.pictureDiscard.TabIndex = 1;
            this.pictureDiscard.TabStop = false;
            this.pictureDiscard.Click += new System.EventHandler(this.pictureDiscard_Click);
            // 
            // playerCard1
            // 
            this.playerCard1.Location = new System.Drawing.Point(26, 562);
            this.playerCard1.Name = "playerCard1";
            this.playerCard1.Size = new System.Drawing.Size(190, 250);
            this.playerCard1.TabIndex = 2;
            this.playerCard1.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(484, 317);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 57);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // playerCard2
            // 
            this.playerCard2.Location = new System.Drawing.Point(222, 562);
            this.playerCard2.Name = "playerCard2";
            this.playerCard2.Size = new System.Drawing.Size(190, 250);
            this.playerCard2.TabIndex = 4;
            this.playerCard2.TabStop = false;
            // 
            // playerCard3
            // 
            this.playerCard3.Location = new System.Drawing.Point(418, 562);
            this.playerCard3.Name = "playerCard3";
            this.playerCard3.Size = new System.Drawing.Size(190, 250);
            this.playerCard3.TabIndex = 5;
            this.playerCard3.TabStop = false;
            // 
            // playerCard4
            // 
            this.playerCard4.Location = new System.Drawing.Point(614, 562);
            this.playerCard4.Name = "playerCard4";
            this.playerCard4.Size = new System.Drawing.Size(190, 250);
            this.playerCard4.TabIndex = 6;
            this.playerCard4.TabStop = false;
            // 
            // playerCard5
            // 
            this.playerCard5.Location = new System.Drawing.Point(810, 562);
            this.playerCard5.Name = "playerCard5";
            this.playerCard5.Size = new System.Drawing.Size(190, 250);
            this.playerCard5.TabIndex = 7;
            this.playerCard5.TabStop = false;
            // 
            // mainMessageLabel
            // 
            this.mainMessageLabel.AutoSize = true;
            this.mainMessageLabel.Location = new System.Drawing.Point(415, 204);
            this.mainMessageLabel.Name = "mainMessageLabel";
            this.mainMessageLabel.Size = new System.Drawing.Size(210, 17);
            this.mainMessageLabel.TabIndex = 8;
            this.mainMessageLabel.Text = "Press start button to start game!";
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 898);
            this.Controls.Add(this.mainMessageLabel);
            this.Controls.Add(this.playerCard5);
            this.Controls.Add(this.playerCard4);
            this.Controls.Add(this.playerCard3);
            this.Controls.Add(this.playerCard2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.playerCard1);
            this.Controls.Add(this.pictureDiscard);
            this.Controls.Add(this.pictureDeck);
            this.Name = "GameBoard";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDiscard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureDeck;
        private System.Windows.Forms.PictureBox pictureDiscard;
        private System.Windows.Forms.PictureBox playerCard1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox playerCard2;
        private System.Windows.Forms.PictureBox playerCard3;
        private System.Windows.Forms.PictureBox playerCard4;
        private System.Windows.Forms.PictureBox playerCard5;
        private System.Windows.Forms.Label mainMessageLabel;
    }
}

