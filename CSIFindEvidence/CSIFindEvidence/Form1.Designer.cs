namespace CSIFindEvidenceGame
{
    partial class EvidenceGameForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtRows = new System.Windows.Forms.TextBox();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.txtGridDisplay = new System.Windows.Forms.RichTextBox();
            this.txtGuessRow = new System.Windows.Forms.TextBox();
            this.txtGuessCol = new System.Windows.Forms.TextBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblGuesses = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnSubmitGuess = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(12, 12);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(100, 20);
            this.txtRows.TabIndex = 0;
            this.txtRows.Text = "Enter Rows";
            // 
            // txtColumns
            // 
            this.txtColumns.Location = new System.Drawing.Point(118, 12);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(100, 20);
            this.txtColumns.TabIndex = 1;
            this.txtColumns.Text = "Enter Columns";
            // 
            // txtGridDisplay
            // 
            this.txtGridDisplay.Location = new System.Drawing.Point(12, 38);
            this.txtGridDisplay.Name = "txtGridDisplay";
            this.txtGridDisplay.ReadOnly = true;
            this.txtGridDisplay.Size = new System.Drawing.Size(206, 150);
            this.txtGridDisplay.TabIndex = 2;
            this.txtGridDisplay.Text = "";
            // 
            // txtGuessRow
            // 
            this.txtGuessRow.Location = new System.Drawing.Point(12, 194);
            this.txtGuessRow.Name = "txtGuessRow";
            this.txtGuessRow.Size = new System.Drawing.Size(100, 20);
            this.txtGuessRow.TabIndex = 3;
            this.txtGuessRow.Text = "Row Guess";
            // 
            // txtGuessCol
            // 
            this.txtGuessCol.Location = new System.Drawing.Point(118, 194);
            this.txtGuessCol.Name = "txtGuessCol";
            this.txtGuessCol.Size = new System.Drawing.Size(100, 20);
            this.txtGuessCol.TabIndex = 4;
            this.txtGuessCol.Text = "Column Guess";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(12, 217);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 13);
            this.lblFeedback.TabIndex = 5;
            // 
            // lblGuesses
            // 
            this.lblGuesses.AutoSize = true;
            this.lblGuesses.Location = new System.Drawing.Point(12, 230);
            this.lblGuesses.Name = "lblGuesses";
            this.lblGuesses.Size = new System.Drawing.Size(100, 13);
            this.lblGuesses.TabIndex = 6;
            this.lblGuesses.Text = "Number of guesses: 0";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(224, 10);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(75, 23);
            this.btnStartGame.TabIndex = 7;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnSubmitGuess
            // 
            this.btnSubmitGuess.Location = new System.Drawing.Point(224, 192);
            this.btnSubmitGuess.Name = "btnSubmitGuess";
            this.btnSubmitGuess.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitGuess.TabIndex = 8;
            this.btnSubmitGuess.Text = "Guess";
            this.btnSubmitGuess.UseVisualStyleBackColor = true;
            this.btnSubmitGuess.Click += new System.EventHandler(this.btnSubmitGuess_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Enabled = false;
            this.btnRestart.Location = new System.Drawing.Point(224, 221);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 9;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(224, 250);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // EvidenceGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 281);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnSubmitGuess);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblGuesses);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.txtGuessCol);
            this.Controls.Add(this.txtGuessRow);
            this.Controls.Add(this.txtGridDisplay);
            this.Controls.Add(this.txtColumns);
            this.Controls.Add(this.txtRows);
            this.Name = "EvidenceGameForm";
            this.Text = "CSI Find Evidence Game";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.RichTextBox txtGridDisplay;
        private System.Windows.Forms.TextBox txtGuessRow;
        private System.Windows.Forms.TextBox txtGuessCol;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblGuesses;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnSubmitGuess;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnQuit;
    }
}
