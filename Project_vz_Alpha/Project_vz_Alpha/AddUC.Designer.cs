namespace Project_vz_Alpha
{
    partial class AddUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            to = new TextBox();
            kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            panel1 = new Panel();
            label3 = new Label();
            Send = new Button();
            Subject = new TextBox();
            addMoreRecipients = new Button();
            kryptonBorderEdge3 = new Krypton.Toolkit.KryptonBorderEdge();
            emailField4 = new TextBox();
            kryptonBorderEdge4 = new Krypton.Toolkit.KryptonBorderEdge();
            emailField3 = new TextBox();
            kryptonBorderEdge5 = new Krypton.Toolkit.KryptonBorderEdge();
            emailField2 = new TextBox();
            emailField5 = new TextBox();
            kryptonBorderEdge6 = new Krypton.Toolkit.KryptonBorderEdge();
            richTextBoxBody = new RichTextBox();
            BoldButton = new Button();
            ItalicButton = new Button();
            UnderlineButton = new Button();
            AttachFileButton = new Button();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(184, 35);
            label1.TabIndex = 0;
            label1.Text = "New Message";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 13.5F);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(26, 94);
            label2.Name = "label2";
            label2.Size = new Size(34, 28);
            label2.TabIndex = 1;
            label2.Text = "To";
            // 
            // to
            // 
            to.BackColor = Color.FromArgb(220, 240, 230);
            to.BorderStyle = BorderStyle.None;
            to.Font = new Font("Segoe UI", 11F);
            to.Location = new Point(64, 93);
            to.Multiline = true;
            to.Name = "to";
            to.PlaceholderText = "example11@gmail.com";
            to.Size = new Size(510, 30);
            to.TabIndex = 2;
            to.TextAlign = HorizontalAlignment.Center;
            // 
            // kryptonBorderEdge1
            // 
            kryptonBorderEdge1.Location = new Point(64, 128);
            kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            kryptonBorderEdge1.Size = new Size(510, 1);
            kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Location = new Point(25, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(1120, 3);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 13.5F);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(37, 318);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 6;
            label3.Text = "Subject";
            // 
            // Send
            // 
            Send.BackColor = Color.CornflowerBlue;
            Send.FlatStyle = FlatStyle.Flat;
            Send.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Send.ForeColor = Color.White;
            Send.Location = new Point(976, 880);
            Send.Name = "Send";
            Send.Size = new Size(154, 54);
            Send.TabIndex = 8;
            Send.Text = "Send";
            Send.UseVisualStyleBackColor = false;
            Send.Click += Send_Click;
            // 
            // Subject
            // 
            Subject.BackColor = Color.WhiteSmoke;
            Subject.BorderStyle = BorderStyle.FixedSingle;
            Subject.Font = new Font("Segoe UI", 11F);
            Subject.Location = new Point(132, 316);
            Subject.Multiline = true;
            Subject.Name = "Subject";
            Subject.Size = new Size(1000, 30);
            Subject.TabIndex = 10;
            Subject.TextAlign = HorizontalAlignment.Center;
            Subject.TextChanged += Subject_TextChanged;
            // 
            // addMoreRecipients
            // 
            addMoreRecipients.BackColor = Color.CornflowerBlue;
            addMoreRecipients.FlatStyle = FlatStyle.Flat;
            addMoreRecipients.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addMoreRecipients.ForeColor = Color.White;
            addMoreRecipients.Location = new Point(905, 257);
            addMoreRecipients.Name = "addMoreRecipients";
            addMoreRecipients.Size = new Size(225, 41);
            addMoreRecipients.TabIndex = 12;
            addMoreRecipients.Text = "Add more recipients";
            addMoreRecipients.UseVisualStyleBackColor = false;
            addMoreRecipients.Click += addMoreRecipientsButton_Click;
            // 
            // kryptonBorderEdge3
            // 
            kryptonBorderEdge3.Location = new Point(64, 210);
            kryptonBorderEdge3.Name = "kryptonBorderEdge3";
            kryptonBorderEdge3.Size = new Size(510, 1);
            kryptonBorderEdge3.Text = "kryptonBorderEdge3";
            // 
            // emailField4
            // 
            emailField4.BackColor = Color.FromArgb(220, 240, 230);
            emailField4.BorderStyle = BorderStyle.None;
            emailField4.Font = new Font("Segoe UI", 11F);
            emailField4.Location = new Point(64, 216);
            emailField4.Multiline = true;
            emailField4.Name = "emailField4";
            emailField4.PlaceholderText = "example11@gmail.com";
            emailField4.Size = new Size(510, 30);
            emailField4.TabIndex = 14;
            emailField4.TextAlign = HorizontalAlignment.Center;
            // 
            // kryptonBorderEdge4
            // 
            kryptonBorderEdge4.Location = new Point(64, 251);
            kryptonBorderEdge4.Name = "kryptonBorderEdge4";
            kryptonBorderEdge4.Size = new Size(510, 1);
            kryptonBorderEdge4.Text = "kryptonBorderEdge4";
            // 
            // emailField3
            // 
            emailField3.BackColor = Color.FromArgb(220, 240, 230);
            emailField3.BorderStyle = BorderStyle.None;
            emailField3.Font = new Font("Segoe UI", 11F);
            emailField3.Location = new Point(64, 175);
            emailField3.Multiline = true;
            emailField3.Name = "emailField3";
            emailField3.PlaceholderText = "example11@gmail.com";
            emailField3.Size = new Size(510, 30);
            emailField3.TabIndex = 17;
            emailField3.TextAlign = HorizontalAlignment.Center;
            // 
            // kryptonBorderEdge5
            // 
            kryptonBorderEdge5.Location = new Point(64, 169);
            kryptonBorderEdge5.Name = "kryptonBorderEdge5";
            kryptonBorderEdge5.Size = new Size(510, 1);
            kryptonBorderEdge5.Text = "kryptonBorderEdge5";
            // 
            // emailField2
            // 
            emailField2.BackColor = Color.FromArgb(220, 240, 230);
            emailField2.BorderStyle = BorderStyle.None;
            emailField2.Font = new Font("Segoe UI", 11F);
            emailField2.Location = new Point(64, 134);
            emailField2.Multiline = true;
            emailField2.Name = "emailField2";
            emailField2.PlaceholderText = "example11@gmail.com";
            emailField2.Size = new Size(510, 30);
            emailField2.TabIndex = 20;
            emailField2.TextAlign = HorizontalAlignment.Center;
            // 
            // emailField5
            // 
            emailField5.BackColor = Color.FromArgb(220, 240, 230);
            emailField5.BorderStyle = BorderStyle.None;
            emailField5.Font = new Font("Segoe UI", 11F);
            emailField5.Location = new Point(64, 257);
            emailField5.Multiline = true;
            emailField5.Name = "emailField5";
            emailField5.PlaceholderText = "example11@gmail.com";
            emailField5.Size = new Size(510, 30);
            emailField5.TabIndex = 22;
            emailField5.TextAlign = HorizontalAlignment.Center;
            // 
            // kryptonBorderEdge6
            // 
            kryptonBorderEdge6.Location = new Point(64, 292);
            kryptonBorderEdge6.Name = "kryptonBorderEdge6";
            kryptonBorderEdge6.Size = new Size(510, 1);
            kryptonBorderEdge6.Text = "kryptonBorderEdge6";
            // 
            // richTextBoxBody
            // 
            richTextBoxBody.BackColor = Color.FromArgb(220, 240, 230);
            richTextBoxBody.Location = new Point(37, 354);
            richTextBoxBody.Name = "richTextBoxBody";
            richTextBoxBody.Size = new Size(1095, 393);
            richTextBoxBody.TabIndex = 28;
            richTextBoxBody.Text = "";
            // 
            // BoldButton
            // 
            BoldButton.BackColor = Color.WhiteSmoke;
            BoldButton.FlatStyle = FlatStyle.Flat;
            BoldButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BoldButton.ForeColor = SystemColors.ControlText;
            BoldButton.Location = new Point(37, 753);
            BoldButton.Name = "BoldButton";
            BoldButton.Size = new Size(37, 37);
            BoldButton.TabIndex = 29;
            BoldButton.Text = "B";
            BoldButton.UseVisualStyleBackColor = false;
            // 
            // ItalicButton
            // 
            ItalicButton.BackColor = Color.WhiteSmoke;
            ItalicButton.FlatStyle = FlatStyle.Flat;
            ItalicButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItalicButton.ForeColor = SystemColors.ControlText;
            ItalicButton.Location = new Point(88, 753);
            ItalicButton.Name = "ItalicButton";
            ItalicButton.Size = new Size(37, 37);
            ItalicButton.TabIndex = 30;
            ItalicButton.Text = "𝐼";
            ItalicButton.UseVisualStyleBackColor = false;
            // 
            // UnderlineButton
            // 
            UnderlineButton.BackColor = Color.WhiteSmoke;
            UnderlineButton.FlatStyle = FlatStyle.Flat;
            UnderlineButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UnderlineButton.ForeColor = SystemColors.ControlText;
            UnderlineButton.Location = new Point(139, 753);
            UnderlineButton.Name = "UnderlineButton";
            UnderlineButton.Size = new Size(37, 37);
            UnderlineButton.TabIndex = 31;
            UnderlineButton.Text = "U̲";
            UnderlineButton.UseVisualStyleBackColor = false;
            // 
            // AttachFileButton
            // 
            AttachFileButton.BackColor = Color.CornflowerBlue;
            AttachFileButton.FlatStyle = FlatStyle.Flat;
            AttachFileButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AttachFileButton.ForeColor = Color.White;
            AttachFileButton.Location = new Point(37, 809);
            AttachFileButton.Name = "AttachFileButton";
            AttachFileButton.Size = new Size(186, 44);
            AttachFileButton.TabIndex = 38;
            AttachFileButton.Text = "Attach a File";
            AttachFileButton.UseVisualStyleBackColor = false;
            AttachFileButton.Click += AttachFileButton_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(66, 93);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "example11@gmail.com";
            textBox1.Size = new Size(510, 30);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.WhiteSmoke;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 11F);
            textBox3.Location = new Point(66, 216);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "example11@gmail.com";
            textBox3.Size = new Size(510, 30);
            textBox3.TabIndex = 14;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.WhiteSmoke;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 11F);
            textBox4.Location = new Point(66, 175);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "example11@gmail.com";
            textBox4.Size = new Size(510, 30);
            textBox4.TabIndex = 17;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.WhiteSmoke;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 11F);
            textBox5.Location = new Point(66, 134);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "example11@gmail.com";
            textBox5.Size = new Size(510, 30);
            textBox5.TabIndex = 20;
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.WhiteSmoke;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI", 11F);
            textBox6.Location = new Point(66, 257);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "example11@gmail.com";
            textBox6.Size = new Size(510, 30);
            textBox6.TabIndex = 22;
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.WhiteSmoke;
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Location = new Point(37, 355);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.RightMargin = 1;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(1095, 393);
            richTextBox1.TabIndex = 28;
            richTextBox1.Text = "";
            // 
            // AddUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(AttachFileButton);
            Controls.Add(UnderlineButton);
            Controls.Add(ItalicButton);
            Controls.Add(BoldButton);
            Controls.Add(richTextBox1);
            Controls.Add(richTextBoxBody);
            Controls.Add(kryptonBorderEdge6);
            Controls.Add(textBox6);
            Controls.Add(emailField5);
            Controls.Add(kryptonBorderEdge5);
            Controls.Add(textBox5);
            Controls.Add(emailField2);
            Controls.Add(kryptonBorderEdge4);
            Controls.Add(textBox4);
            Controls.Add(emailField3);
            Controls.Add(kryptonBorderEdge3);
            Controls.Add(textBox3);
            Controls.Add(emailField4);
            Controls.Add(addMoreRecipients);
            Controls.Add(Subject);
            Controls.Add(Send);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(kryptonBorderEdge1);
            Controls.Add(textBox1);
            Controls.Add(to);
            Controls.Add(label1);
            Name = "AddUC";
            Size = new Size(1177, 971);
            Load += AddUC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox to;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Panel panel1;
        private Label label3;
        private Button Send;
        private TextBox Subject;
        private Button addMoreRecipients;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge3;
        private TextBox emailField4;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge4;
        private TextBox emailField3;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge5;
        private TextBox emailField2;
        private TextBox emailField5;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge6;
        private RichTextBox richTextBoxBody;
        private Button BoldButton;
        private Button ItalicButton;
        private Button UnderlineButton;
        private Button AttachFileButton;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private RichTextBox richTextBox1;
    }
}
