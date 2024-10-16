namespace Program4
{
    partial class Program4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Program4));
            titleBox = new Label();
            GuessButton = new Button();
            QuitButton = new Button();
            RestartButton = new Button();
            txtRows = new TextBox();
            txtCols = new TextBox();
            lblRows = new Label();
            lblCols = new Label();
            txtGrid = new TextBox();
            lblGuessCount = new Label();
            txtBoxHowTo = new TextBox();
            SuspendLayout();
            // 
            // titleBox
            // 
            titleBox.AutoSize = true;
            titleBox.Font = new Font("Lucida Sans Typewriter", 20F, FontStyle.Bold);
            titleBox.Location = new Point(131, 56);
            titleBox.Margin = new Padding(8, 0, 8, 0);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(1232, 76);
            titleBox.TabIndex = 0;
            titleBox.Text = "”CSI: Find the Evidence Sample";
            // 
            // GuessButton
            // 
            GuessButton.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Bold);
            GuessButton.Location = new Point(187, 405);
            GuessButton.Margin = new Padding(8, 9, 8, 9);
            GuessButton.Name = "GuessButton";
            GuessButton.Size = new Size(285, 90);
            GuessButton.TabIndex = 6;
            GuessButton.Text = "Guess";
            GuessButton.UseVisualStyleBackColor = true;
            GuessButton.Click += GuessButton_Click;
            // 
            // QuitButton
            // 
            QuitButton.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Bold);
            QuitButton.Location = new Point(1032, 405);
            QuitButton.Margin = new Padding(8, 9, 8, 9);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(285, 90);
            QuitButton.TabIndex = 8;
            QuitButton.Text = "Quit";
            QuitButton.UseVisualStyleBackColor = true;
            QuitButton.Click += QuitButton_Click;
            // 
            // RestartButton
            // 
            RestartButton.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Bold);
            RestartButton.Location = new Point(610, 405);
            RestartButton.Margin = new Padding(8, 9, 8, 9);
            RestartButton.Name = "RestartButton";
            RestartButton.Size = new Size(285, 90);
            RestartButton.TabIndex = 7;
            RestartButton.Text = "Restart";
            RestartButton.UseVisualStyleBackColor = true;
            RestartButton.Click += RestartButton_Click;
            // 
            // txtRows
            // 
            txtRows.Font = new Font("Lucida Sans Typewriter", 12F);
            txtRows.Location = new Point(225, 217);
            txtRows.Margin = new Padding(8, 9, 8, 9);
            txtRows.Name = "txtRows";
            txtRows.Size = new Size(276, 54);
            txtRows.TabIndex = 3;
            // 
            // txtCols
            // 
            txtCols.Font = new Font("Lucida Sans Typewriter", 12F);
            txtCols.Location = new Point(1077, 217);
            txtCols.Margin = new Padding(8, 9, 8, 9);
            txtCols.Name = "txtCols";
            txtCols.Size = new Size(276, 54);
            txtCols.TabIndex = 5;
            txtCols.TextChanged += txtCols_TextChanged;
            // 
            // lblRows
            // 
            lblRows.AutoSize = true;
            lblRows.Font = new Font("Lucida Sans Typewriter", 12F);
            lblRows.Location = new Point(83, 226);
            lblRows.Margin = new Padding(8, 0, 8, 0);
            lblRows.Name = "lblRows";
            lblRows.Size = new Size(140, 45);
            lblRows.TabIndex = 2;
            lblRows.Text = "Rows:";
            // 
            // lblCols
            // 
            lblCols.AutoSize = true;
            lblCols.Font = new Font("Lucida Sans Typewriter", 12F);
            lblCols.Location = new Point(816, 226);
            lblCols.Margin = new Padding(8, 0, 8, 0);
            lblCols.Name = "lblCols";
            lblCols.Size = new Size(212, 45);
            lblCols.TabIndex = 4;
            lblCols.Text = "Columns:";
            // 
            // txtGrid
            // 
            txtGrid.Font = new Font("Lucida Sans Typewriter", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrid.Location = new Point(324, 643);
            txtGrid.Multiline = true;
            txtGrid.Name = "txtGrid";
            txtGrid.ReadOnly = true;
            txtGrid.ScrollBars = ScrollBars.Vertical;
            txtGrid.Size = new Size(771, 590);
            txtGrid.TabIndex = 9;
            // 
            // lblGuessCount
            // 
            lblGuessCount.AutoSize = true;
            lblGuessCount.Font = new Font("Lucida Sans Typewriter", 12F);
            lblGuessCount.Location = new Point(50, 570);
            lblGuessCount.Name = "lblGuessCount";
            lblGuessCount.Size = new Size(260, 45);
            lblGuessCount.TabIndex = 10;
            lblGuessCount.Text = "Guesses: 0";
            // 
            // txtBoxHowTo
            // 
            txtBoxHowTo.BackColor = SystemColors.Info;
            txtBoxHowTo.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxHowTo.Location = new Point(1474, 41);
            txtBoxHowTo.Multiline = true;
            txtBoxHowTo.Name = "txtBoxHowTo";
            txtBoxHowTo.Size = new Size(836, 998);
            txtBoxHowTo.TabIndex = 14;
            txtBoxHowTo.Text = resources.GetString("txtBoxHowTo.Text");
            // 
            // Program4
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2322, 1302);
            Controls.Add(txtBoxHowTo);
            Controls.Add(lblGuessCount);
            Controls.Add(txtGrid);
            Controls.Add(QuitButton);
            Controls.Add(RestartButton);
            Controls.Add(GuessButton);
            Controls.Add(txtCols);
            Controls.Add(lblCols);
            Controls.Add(txtRows);
            Controls.Add(lblRows);
            Controls.Add(titleBox);
            Margin = new Padding(8, 9, 8, 9);
            Name = "Program4";
            Text = "”CSI: Find the Evidence Sample";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label titleBox;
        private System.Windows.Forms.Button GuessButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtCols;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblCols;
        private System.Windows.Forms.TextBox txtGrid; 
        private System.Windows.Forms.Label lblGuessCount;
        private TextBox txtBoxHowTo;
    }
}
