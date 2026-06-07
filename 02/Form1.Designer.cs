namespace _02
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
            lblResult = new Label();
            txtInput = new TextBox();
            rdoCtoF = new RadioButton();
            rdoFtoC = new RadioButton();
            btnConvert = new Button();
            btnClear = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            label2 = new Label();
            buttonDot = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(417, 172);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 19);
            lblResult.TabIndex = 0;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(417, 70);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(252, 27);
            txtInput.TabIndex = 1;
            // 
            // rdoCtoF
            // 
            rdoCtoF.AutoSize = true;
            rdoCtoF.Checked = true;
            rdoCtoF.Location = new Point(18, 43);
            rdoCtoF.Name = "rdoCtoF";
            rdoCtoF.Size = new Size(135, 23);
            rdoCtoF.TabIndex = 2;
            rdoCtoF.TabStop = true;
            rdoCtoF.Text = "攝氏轉換為華氏";
            rdoCtoF.UseVisualStyleBackColor = true;
            // 
            // rdoFtoC
            // 
            rdoFtoC.AutoSize = true;
            rdoFtoC.Location = new Point(18, 79);
            rdoFtoC.Name = "rdoFtoC";
            rdoFtoC.Size = new Size(135, 23);
            rdoFtoC.TabIndex = 3;
            rdoFtoC.Text = "華氏轉換為攝氏";
            rdoFtoC.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(417, 123);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(94, 29);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "轉換";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(550, 123);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 5;
            btnClear.Text = "清除";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoCtoF);
            groupBox1.Controls.Add(rdoFtoC);
            groupBox1.Location = new Point(23, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(196, 149);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Location = new Point(238, 38);
            button1.Name = "button1";
            button1.Size = new Size(44, 41);
            button1.TabIndex = 7;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Location = new Point(288, 38);
            button2.Name = "button2";
            button2.Size = new Size(44, 41);
            button2.TabIndex = 8;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += NumberButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(338, 38);
            button3.Name = "button3";
            button3.Size = new Size(44, 41);
            button3.TabIndex = 9;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += NumberButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(238, 88);
            button4.Name = "button4";
            button4.Size = new Size(44, 41);
            button4.TabIndex = 10;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += NumberButton_Click;
            // 
            // button5
            // 
            button5.Location = new Point(288, 88);
            button5.Name = "button5";
            button5.Size = new Size(44, 41);
            button5.TabIndex = 11;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += NumberButton_Click;
            // 
            // button6
            // 
            button6.Location = new Point(338, 88);
            button6.Name = "button6";
            button6.Size = new Size(44, 41);
            button6.TabIndex = 12;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += NumberButton_Click;
            // 
            // button7
            // 
            button7.Location = new Point(238, 135);
            button7.Name = "button7";
            button7.Size = new Size(44, 41);
            button7.TabIndex = 13;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += NumberButton_Click;
            // 
            // button8
            // 
            button8.Location = new Point(288, 135);
            button8.Name = "button8";
            button8.Size = new Size(44, 41);
            button8.TabIndex = 14;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += NumberButton_Click;
            // 
            // button9
            // 
            button9.Location = new Point(338, 135);
            button9.Name = "button9";
            button9.Size = new Size(44, 41);
            button9.TabIndex = 15;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += NumberButton_Click;
            // 
            // button0
            // 
            button0.Location = new Point(288, 182);
            button0.Name = "button0";
            button0.Size = new Size(44, 41);
            button0.TabIndex = 16;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += NumberButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(417, 38);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 17;
            label2.Text = "溫度轉換機";
            // 
            // buttonDot
            // 
            buttonDot.Location = new Point(338, 182);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(44, 41);
            buttonDot.TabIndex = 18;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = true;
            buttonDot.Click += buttonDot_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 262);
            Controls.Add(buttonDot);
            Controls.Add(label2);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(btnClear);
            Controls.Add(btnConvert);
            Controls.Add(txtInput);
            Controls.Add(lblResult);
            Name = "Form1";
            Text = "Form1";
            
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private TextBox txtInput;
        private RadioButton rdoCtoF;
        private RadioButton rdoFtoC;
        private Button btnConvert;
        private Button btnClear;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Label label2;
        private Button buttonDot;
    }
}
