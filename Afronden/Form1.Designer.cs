namespace Afronden
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
            Getal1TextBox = new TextBox();
            Getal2TextBox = new TextBox();
            label1 = new Label();
            BerekenButton = new Button();
            progressBar1 = new ProgressBar();
            label2 = new Label();
            label3 = new Label();
            NormalValueTextBox = new TextBox();
            AbsoluteValueTextBox = new TextBox();
            NormalValueRoundTextBox = new TextBox();
            NormalValueTruncateTextBox = new TextBox();
            NormalValueCeilingTextBox = new TextBox();
            NormalValueFloorTextBox = new TextBox();
            AbsoluteValueRoundTextBox = new TextBox();
            AbsoluteValueTruncateTextBox = new TextBox();
            AbsoluteValueCeilingTextBox = new TextBox();
            AbsoluteValueFloorTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // Getal1TextBox
            // 
            Getal1TextBox.Location = new Point(63, 37);
            Getal1TextBox.Name = "Getal1TextBox";
            Getal1TextBox.Size = new Size(98, 23);
            Getal1TextBox.TabIndex = 0;
            // 
            // Getal2TextBox
            // 
            Getal2TextBox.Location = new Point(185, 37);
            Getal2TextBox.Name = "Getal2TextBox";
            Getal2TextBox.Size = new Size(101, 23);
            Getal2TextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 40);
            label1.Name = "label1";
            label1.Size = new Size(12, 15);
            label1.TabIndex = 2;
            label1.Text = "x";
            // 
            // BerekenButton
            // 
            BerekenButton.Location = new Point(63, 66);
            BerekenButton.Name = "BerekenButton";
            BerekenButton.Size = new Size(223, 23);
            BerekenButton.TabIndex = 3;
            BerekenButton.Text = "=";
            BerekenButton.UseVisualStyleBackColor = true;
            BerekenButton.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = SystemColors.ActiveCaptionText;
            progressBar1.ForeColor = Color.Black;
            progressBar1.Location = new Point(12, 95);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(330, 23);
            progressBar1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 132);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 5;
            label2.Text = "Normal Value";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 132);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 6;
            label3.Text = "Absolute Value";
            // 
            // NormalValueTextBox
            // 
            NormalValueTextBox.Location = new Point(83, 150);
            NormalValueTextBox.Name = "NormalValueTextBox";
            NormalValueTextBox.Size = new Size(100, 23);
            NormalValueTextBox.TabIndex = 7;
            // 
            // AbsoluteValueTextBox
            // 
            AbsoluteValueTextBox.Location = new Point(201, 150);
            AbsoluteValueTextBox.Name = "AbsoluteValueTextBox";
            AbsoluteValueTextBox.Size = new Size(100, 23);
            AbsoluteValueTextBox.TabIndex = 8;
            // 
            // NormalValueRoundTextBox
            // 
            NormalValueRoundTextBox.Location = new Point(83, 179);
            NormalValueRoundTextBox.Name = "NormalValueRoundTextBox";
            NormalValueRoundTextBox.Size = new Size(100, 23);
            NormalValueRoundTextBox.TabIndex = 9;
            // 
            // NormalValueTruncateTextBox
            // 
            NormalValueTruncateTextBox.Location = new Point(83, 208);
            NormalValueTruncateTextBox.Name = "NormalValueTruncateTextBox";
            NormalValueTruncateTextBox.Size = new Size(100, 23);
            NormalValueTruncateTextBox.TabIndex = 10;
            // 
            // NormalValueCeilingTextBox
            // 
            NormalValueCeilingTextBox.Location = new Point(83, 237);
            NormalValueCeilingTextBox.Name = "NormalValueCeilingTextBox";
            NormalValueCeilingTextBox.Size = new Size(100, 23);
            NormalValueCeilingTextBox.TabIndex = 11;
            // 
            // NormalValueFloorTextBox
            // 
            NormalValueFloorTextBox.Location = new Point(83, 266);
            NormalValueFloorTextBox.Name = "NormalValueFloorTextBox";
            NormalValueFloorTextBox.Size = new Size(100, 23);
            NormalValueFloorTextBox.TabIndex = 12;
            // 
            // AbsoluteValueRoundTextBox
            // 
            AbsoluteValueRoundTextBox.Location = new Point(201, 179);
            AbsoluteValueRoundTextBox.Name = "AbsoluteValueRoundTextBox";
            AbsoluteValueRoundTextBox.Size = new Size(100, 23);
            AbsoluteValueRoundTextBox.TabIndex = 13;
            // 
            // AbsoluteValueTruncateTextBox
            // 
            AbsoluteValueTruncateTextBox.Location = new Point(201, 208);
            AbsoluteValueTruncateTextBox.Name = "AbsoluteValueTruncateTextBox";
            AbsoluteValueTruncateTextBox.Size = new Size(100, 23);
            AbsoluteValueTruncateTextBox.TabIndex = 14;
            // 
            // AbsoluteValueCeilingTextBox
            // 
            AbsoluteValueCeilingTextBox.Location = new Point(201, 237);
            AbsoluteValueCeilingTextBox.Name = "AbsoluteValueCeilingTextBox";
            AbsoluteValueCeilingTextBox.Size = new Size(100, 23);
            AbsoluteValueCeilingTextBox.TabIndex = 15;
            // 
            // AbsoluteValueFloorTextBox
            // 
            AbsoluteValueFloorTextBox.Location = new Point(201, 266);
            AbsoluteValueFloorTextBox.Name = "AbsoluteValueFloorTextBox";
            AbsoluteValueFloorTextBox.Size = new Size(100, 23);
            AbsoluteValueFloorTextBox.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 182);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 17;
            label4.Text = "Round:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 208);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 18;
            label5.Text = "Truncate:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 237);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 19;
            label6.Text = "Ceiling:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 269);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 20;
            label7.Text = "Floor:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 315);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(AbsoluteValueFloorTextBox);
            Controls.Add(AbsoluteValueCeilingTextBox);
            Controls.Add(AbsoluteValueTruncateTextBox);
            Controls.Add(AbsoluteValueRoundTextBox);
            Controls.Add(NormalValueFloorTextBox);
            Controls.Add(NormalValueCeilingTextBox);
            Controls.Add(NormalValueTruncateTextBox);
            Controls.Add(NormalValueRoundTextBox);
            Controls.Add(AbsoluteValueTextBox);
            Controls.Add(NormalValueTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(progressBar1);
            Controls.Add(BerekenButton);
            Controls.Add(label1);
            Controls.Add(Getal2TextBox);
            Controls.Add(Getal1TextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Getal1TextBox;
        private TextBox Getal2TextBox;
        private Label label1;
        private Button BerekenButton;
        private ProgressBar progressBar1;
        private Label label2;
        private Label label3;
        private TextBox NormalValueTextBox;
        private TextBox AbsoluteValueTextBox;
        private TextBox NormalValueRoundTextBox;
        private TextBox NormalValueTruncateTextBox;
        private TextBox NormalValueCeilingTextBox;
        private TextBox NormalValueFloorTextBox;
        private TextBox AbsoluteValueRoundTextBox;
        private TextBox AbsoluteValueTruncateTextBox;
        private TextBox AbsoluteValueCeilingTextBox;
        private TextBox AbsoluteValueFloorTextBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
