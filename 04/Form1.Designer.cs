namespace _04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStart = new Button();
            label1 = new Label();
            txtGuess = new TextBox();
            btnCheck = new Button();
            lstHistory = new ListBox();
            label2 = new Label();
            btnShowAnswer = new Button();
            btnRestart = new Button();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(28, 47);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(115, 53);
            btnStart.TabIndex = 0;
            btnStart.Text = "開始遊戲";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 298);
            label1.Name = "label1";
            label1.Size = new Size(39, 19);
            label1.TabIndex = 2;
            label1.Text = "輸入";
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(28, 337);
            txtGuess.MaxLength = 4;
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(252, 27);
            txtGuess.TabIndex = 3;
            // 
            // btnCheck
            // 
            btnCheck.Enabled = false;
            btnCheck.Location = new Point(28, 393);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(115, 44);
            btnCheck.TabIndex = 4;
            btnCheck.Text = "檢查答案";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lstHistory
            // 
            lstHistory.FormattingEnabled = true;
            lstHistory.Location = new Point(337, 47);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(287, 479);
            lstHistory.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 12);
            label2.Name = "label2";
            label2.Size = new Size(69, 19);
            label2.TabIndex = 7;
            label2.Text = "遊戲歷程";
            // 
            // btnShowAnswer
            // 
            btnShowAnswer.Location = new Point(28, 132);
            btnShowAnswer.Name = "btnShowAnswer";
            btnShowAnswer.Size = new Size(115, 53);
            btnShowAnswer.TabIndex = 8;
            btnShowAnswer.Text = "看答案";
            btnShowAnswer.UseVisualStyleBackColor = true;
            btnShowAnswer.Click += btnShowAnswer_Click;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(165, 393);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(115, 44);
            btnRestart.TabIndex = 9;
            btnRestart.Text = "放棄重來";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 536);
            Controls.Add(btnRestart);
            Controls.Add(btnShowAnswer);
            Controls.Add(label2);
            Controls.Add(lstHistory);
            Controls.Add(btnCheck);
            Controls.Add(txtGuess);
            Controls.Add(label1);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "1A2B 猜數字遊戲";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Label label1;
        private TextBox txtGuess;
        private Button btnCheck;
        private ListBox lstHistory;
        private Label label2;
        private Button btnShowAnswer;
        private Button btnRestart;
    }
}
