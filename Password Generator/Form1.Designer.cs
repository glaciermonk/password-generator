namespace Password_Generator
{
    partial class PassGen_Main
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
            textBox_password = new TextBox();
            button_generatepass = new Button();
            label1 = new Label();
            textbox_PassLen = new TextBox();
            label2 = new Label();
            button_copy = new Button();
            checkBox_num = new CheckBox();
            checkBox_spechar = new CheckBox();
            label_message = new Label();
            trackBar_passlen = new TrackBar();
            checkBox_ambiguous = new CheckBox();
            button_esc = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar_passlen).BeginInit();
            SuspendLayout();
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(12, 329);
            textBox_password.Multiline = true;
            textBox_password.Name = "textBox_password";
            textBox_password.ReadOnly = true;
            textBox_password.Size = new Size(342, 107);
            textBox_password.TabIndex = 0;
            textBox_password.TextAlign = HorizontalAlignment.Center;
            // 
            // button_generatepass
            // 
            button_generatepass.Location = new Point(12, 231);
            button_generatepass.Name = "button_generatepass";
            button_generatepass.Size = new Size(94, 29);
            button_generatepass.TabIndex = 1;
            button_generatepass.Text = "Generate";
            button_generatepass.UseVisualStyleBackColor = true;
            button_generatepass.Click += button_generatepass_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 37);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 2;
            label1.Text = "Password Length:";
            // 
            // textbox_PassLen
            // 
            textbox_PassLen.Location = new Point(176, 34);
            textbox_PassLen.MaxLength = 3;
            textbox_PassLen.Name = "textbox_PassLen";
            textbox_PassLen.Size = new Size(119, 27);
            textbox_PassLen.TabIndex = 3;
            textbox_PassLen.TextChanged += textbox_PassLen_TextChanged;
            textbox_PassLen.KeyPress += textbox_PassLen_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 291);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // button_copy
            // 
            button_copy.Location = new Point(260, 231);
            button_copy.Name = "button_copy";
            button_copy.Size = new Size(94, 29);
            button_copy.TabIndex = 5;
            button_copy.Text = "Copy";
            button_copy.UseVisualStyleBackColor = true;
            button_copy.Click += button_copy_Click;
            // 
            // checkBox_num
            // 
            checkBox_num.AutoSize = true;
            checkBox_num.Location = new Point(67, 130);
            checkBox_num.Name = "checkBox_num";
            checkBox_num.Size = new Size(91, 24);
            checkBox_num.TabIndex = 6;
            checkBox_num.Text = "Numbers";
            checkBox_num.UseVisualStyleBackColor = true;
            // 
            // checkBox_spechar
            // 
            checkBox_spechar.AutoSize = true;
            checkBox_spechar.Location = new Point(67, 160);
            checkBox_spechar.Name = "checkBox_spechar";
            checkBox_spechar.Size = new Size(146, 24);
            checkBox_spechar.TabIndex = 7;
            checkBox_spechar.Text = "Special Character";
            checkBox_spechar.UseVisualStyleBackColor = true;
            // 
            // label_message
            // 
            label_message.AutoSize = true;
            label_message.Location = new Point(117, 7);
            label_message.Name = "label_message";
            label_message.Size = new Size(0, 20);
            label_message.TabIndex = 8;
            // 
            // trackBar_passlen
            // 
            trackBar_passlen.Location = new Point(12, 66);
            trackBar_passlen.Maximum = 128;
            trackBar_passlen.Minimum = 1;
            trackBar_passlen.Name = "trackBar_passlen";
            trackBar_passlen.Size = new Size(342, 56);
            trackBar_passlen.SmallChange = 5;
            trackBar_passlen.TabIndex = 9;
            trackBar_passlen.TickFrequency = 5;
            trackBar_passlen.Value = 25;
            trackBar_passlen.Scroll += trackBar1_Scroll;
            // 
            // checkBox_ambiguous
            // 
            checkBox_ambiguous.AutoSize = true;
            checkBox_ambiguous.Location = new Point(67, 190);
            checkBox_ambiguous.Name = "checkBox_ambiguous";
            checkBox_ambiguous.Size = new Size(223, 24);
            checkBox_ambiguous.TabIndex = 10;
            checkBox_ambiguous.Text = "Avoid Ambiguous Characters";
            checkBox_ambiguous.UseVisualStyleBackColor = true;
            // 
            // button_esc
            // 
            button_esc.BackColor = Color.Silver;
            button_esc.ForeColor = SystemColors.ActiveCaptionText;
            button_esc.Location = new Point(359, 445);
            button_esc.Name = "button_esc";
            button_esc.Size = new Size(10, 10);
            button_esc.TabIndex = 11;
            button_esc.UseVisualStyleBackColor = false;
            button_esc.Click += button_esc_Click;
            // 
            // PassGen_Main
            // 
            AcceptButton = button_generatepass;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            CancelButton = button_esc;
            ClientSize = new Size(366, 446);
            Controls.Add(button_esc);
            Controls.Add(textBox_password);
            Controls.Add(checkBox_ambiguous);
            Controls.Add(trackBar_passlen);
            Controls.Add(label_message);
            Controls.Add(checkBox_spechar);
            Controls.Add(checkBox_num);
            Controls.Add(button_copy);
            Controls.Add(label2);
            Controls.Add(textbox_PassLen);
            Controls.Add(label1);
            Controls.Add(button_generatepass);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PassGen_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Generator by Likhan";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar_passlen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_password;
        private Button button_generatepass;
        private Label label1;
        private TextBox textbox_PassLen;
        private Label label2;
        private Button button_copy;
        private CheckBox checkBox_num;
        private CheckBox checkBox_spechar;
        private Label label_message;
        private TrackBar trackBar_passlen;
        private CheckBox checkBox_ambiguous;
        private Button button_esc;
    }
}