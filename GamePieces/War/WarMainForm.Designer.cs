namespace War
{
    partial class WarMainForm
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
            this.playerNameTextBox1 = new System.Windows.Forms.TextBox();
            this.playerNameTextBox2 = new System.Windows.Forms.TextBox();
            this.player1HandTextBox = new System.Windows.Forms.TextBox();
            this.player1WinningsDeck = new System.Windows.Forms.TextBox();
            this.player1PlayedDeck = new System.Windows.Forms.TextBox();
            this.player2PlayedDeck = new System.Windows.Forms.TextBox();
            this.player2WinningsDeck = new System.Windows.Forms.TextBox();
            this.player2HandTextBox = new System.Windows.Forms.TextBox();
            this.summaryTextBox = new System.Windows.Forms.TextBox();
            this.actionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerNameTextBox1
            // 
            this.playerNameTextBox1.Enabled = false;
            this.playerNameTextBox1.Location = new System.Drawing.Point(12, 28);
            this.playerNameTextBox1.Name = "playerNameTextBox1";
            this.playerNameTextBox1.Size = new System.Drawing.Size(100, 20);
            this.playerNameTextBox1.TabIndex = 0;
            this.playerNameTextBox1.Text = "Player 1";
            // 
            // playerNameTextBox2
            // 
            this.playerNameTextBox2.Enabled = false;
            this.playerNameTextBox2.Location = new System.Drawing.Point(488, 28);
            this.playerNameTextBox2.Name = "playerNameTextBox2";
            this.playerNameTextBox2.Size = new System.Drawing.Size(100, 20);
            this.playerNameTextBox2.TabIndex = 1;
            this.playerNameTextBox2.Text = "Player 2";
            this.playerNameTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Player1Hand
            // 
            this.player1HandTextBox.Enabled = false;
            this.player1HandTextBox.Location = new System.Drawing.Point(112, 97);
            this.player1HandTextBox.Name = "Player1Hand";
            this.player1HandTextBox.Size = new System.Drawing.Size(104, 20);
            this.player1HandTextBox.TabIndex = 2;
            // 
            // player1WinningsDeck
            // 
            this.player1WinningsDeck.Enabled = false;
            this.player1WinningsDeck.Location = new System.Drawing.Point(112, 140);
            this.player1WinningsDeck.Name = "player1WinningsDeck";
            this.player1WinningsDeck.Size = new System.Drawing.Size(104, 20);
            this.player1WinningsDeck.TabIndex = 3;
            // 
            // player1PlayedDeck
            // 
            this.player1PlayedDeck.Enabled = false;
            this.player1PlayedDeck.Location = new System.Drawing.Point(190, 213);
            this.player1PlayedDeck.Name = "player1PlayedDeck";
            this.player1PlayedDeck.Size = new System.Drawing.Size(104, 20);
            this.player1PlayedDeck.TabIndex = 4;
            // 
            // player2PlayedDeck
            // 
            this.player2PlayedDeck.Enabled = false;
            this.player2PlayedDeck.Location = new System.Drawing.Point(355, 213);
            this.player2PlayedDeck.Name = "player2PlayedDeck";
            this.player2PlayedDeck.Size = new System.Drawing.Size(104, 20);
            this.player2PlayedDeck.TabIndex = 7;
            this.player2PlayedDeck.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // player2WinningsDeck
            // 
            this.player2WinningsDeck.Enabled = false;
            this.player2WinningsDeck.Location = new System.Drawing.Point(445, 140);
            this.player2WinningsDeck.Name = "player2WinningsDeck";
            this.player2WinningsDeck.Size = new System.Drawing.Size(104, 20);
            this.player2WinningsDeck.TabIndex = 6;
            this.player2WinningsDeck.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // player2Hand
            // 
            this.player2HandTextBox.Enabled = false;
            this.player2HandTextBox.Location = new System.Drawing.Point(445, 97);
            this.player2HandTextBox.Name = "player2Hand";
            this.player2HandTextBox.Size = new System.Drawing.Size(104, 20);
            this.player2HandTextBox.TabIndex = 5;
            this.player2HandTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // summaryTextBox
            // 
            this.summaryTextBox.Enabled = false;
            this.summaryTextBox.Location = new System.Drawing.Point(12, 359);
            this.summaryTextBox.Name = "summaryTextBox";
            this.summaryTextBox.Size = new System.Drawing.Size(576, 20);
            this.summaryTextBox.TabIndex = 8;
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(190, 288);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(269, 23);
            this.actionButton.TabIndex = 9;
            this.actionButton.Text = "Action";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.ActionClick);
            // 
            // WarMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 400);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.summaryTextBox);
            this.Controls.Add(this.player2PlayedDeck);
            this.Controls.Add(this.player2WinningsDeck);
            this.Controls.Add(this.player2HandTextBox);
            this.Controls.Add(this.player1PlayedDeck);
            this.Controls.Add(this.player1WinningsDeck);
            this.Controls.Add(this.player1HandTextBox);
            this.Controls.Add(this.playerNameTextBox2);
            this.Controls.Add(this.playerNameTextBox1);
            this.Name = "WarMainForm";
            this.Text = "War";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox playerNameTextBox1;
        private System.Windows.Forms.TextBox playerNameTextBox2;
        private System.Windows.Forms.TextBox player1HandTextBox;
        private System.Windows.Forms.TextBox player1WinningsDeck;
        private System.Windows.Forms.TextBox player1PlayedDeck;
        private System.Windows.Forms.TextBox player2PlayedDeck;
        private System.Windows.Forms.TextBox player2WinningsDeck;
        private System.Windows.Forms.TextBox player2HandTextBox;
        private System.Windows.Forms.TextBox summaryTextBox;
        private System.Windows.Forms.Button actionButton;
    }
}

