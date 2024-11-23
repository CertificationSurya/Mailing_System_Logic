namespace Mail_Dispatcher.Navs
{
    partial class ComposePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComposePage));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            cross = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            userPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            label3 = new Label();
            fromEmail = new Label();
            subjectField = new Guna.UI2.WinForms.Guna2TextBox();
            bodyField = new Guna.UI2.WinForms.Guna2TextBox();
            label5 = new Label();
            sendBtn = new Guna.UI2.WinForms.Guna2Button();
            groupField = new ComboBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // cross
            // 
            cross.BackColor = SystemColors.ControlLightLight;
            cross.Location = new Point(772, 4);
            cross.Name = "cross";
            cross.Size = new Size(38, 29);
            cross.TabIndex = 1;
            cross.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(-2, -36);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(820, 76);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 7);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 3;
            label2.Text = "compose";
            // 
            // userPic
            // 
            userPic.Image = (Image)resources.GetObject("userPic.Image");
            userPic.ImageRotate = 0F;
            userPic.Location = new Point(46, 56);
            userPic.Margin = new Padding(3, 2, 3, 2);
            userPic.Name = "userPic";
            userPic.ShadowDecoration.CustomizableEdges = customizableEdges8;
            userPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            userPic.Size = new Size(38, 32);
            userPic.TabIndex = 4;
            userPic.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(10, 62);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "from";
            // 
            // fromEmail
            // 
            fromEmail.AutoSize = true;
            fromEmail.Location = new Point(86, 62);
            fromEmail.Name = "fromEmail";
            fromEmail.Size = new Size(120, 15);
            fromEmail.TabIndex = 6;
            fromEmail.Text = "usermail@gmial.com";
            // 
            // subjectField
            // 
            subjectField.CustomizableEdges = customizableEdges9;
            subjectField.DefaultText = "";
            subjectField.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            subjectField.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            subjectField.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            subjectField.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            subjectField.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            subjectField.Font = new Font("Segoe UI", 9F);
            subjectField.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            subjectField.Location = new Point(46, 94);
            subjectField.Name = "subjectField";
            subjectField.PasswordChar = '\0';
            subjectField.PlaceholderForeColor = Color.FromArgb(125, 137, 149);
            subjectField.PlaceholderText = "subject";
            subjectField.SelectedText = "";
            subjectField.ShadowDecoration.CustomizableEdges = customizableEdges10;
            subjectField.Size = new Size(744, 43);
            subjectField.TabIndex = 7;
            // 
            // bodyField
            // 
            bodyField.BorderColor = SystemColors.AppWorkspace;
            bodyField.CustomizableEdges = customizableEdges11;
            bodyField.DefaultText = "Your email....";
            bodyField.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            bodyField.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            bodyField.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            bodyField.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            bodyField.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            bodyField.Font = new Font("Segoe UI", 9F);
            bodyField.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            bodyField.Location = new Point(46, 143);
            bodyField.Name = "bodyField";
            bodyField.PasswordChar = '\0';
            bodyField.PlaceholderForeColor = Color.FromArgb(125, 137, 149);
            bodyField.PlaceholderText = "Your Mail Body.";
            bodyField.SelectedText = "";
            bodyField.ShadowDecoration.CustomizableEdges = customizableEdges12;
            bodyField.Size = new Size(744, 223);
            bodyField.TabIndex = 8;
            bodyField.TextOffset = new Point(0, -100);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(46, 378);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 9;
            label5.Text = "Send To :";
            // 
            // sendBtn
            // 
            sendBtn.CustomizableEdges = customizableEdges13;
            sendBtn.DisabledState.BorderColor = Color.DarkGray;
            sendBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            sendBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            sendBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            sendBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sendBtn.ForeColor = Color.White;
            sendBtn.Location = new Point(708, 373);
            sendBtn.Margin = new Padding(3, 2, 3, 2);
            sendBtn.Name = "sendBtn";
            sendBtn.ShadowDecoration.CustomizableEdges = customizableEdges14;
            sendBtn.Size = new Size(82, 24);
            sendBtn.TabIndex = 10;
            sendBtn.Text = "Send";
            // 
            // groupField
            // 
            groupField.ForeColor = Color.DimGray;
            groupField.FormattingEnabled = true;
            groupField.Items.AddRange(new object[] { "sellect group" });
            groupField.Location = new Point(103, 374);
            groupField.Margin = new Padding(3, 2, 3, 2);
            groupField.Name = "groupField";
            groupField.Size = new Size(133, 23);
            groupField.TabIndex = 11;
            groupField.Text = "Select Group";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(-11, 32);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(829, 409);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // ComposePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(811, 450);
            Controls.Add(groupField);
            Controls.Add(sendBtn);
            Controls.Add(label5);
            Controls.Add(bodyField);
            Controls.Add(subjectField);
            Controls.Add(fromEmail);
            Controls.Add(label3);
            Controls.Add(userPic);
            Controls.Add(label2);
            Controls.Add(cross);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ComposePage";
            Text = "ComposePage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button cross;
        private PictureBox pictureBox1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userPic;
        private Label label3;
        private Label fromEmail;
        private Guna.UI2.WinForms.Guna2TextBox subjectField;
        private Guna.UI2.WinForms.Guna2TextBox bodyField;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Button sendBtn;
        private ComboBox groupField;
        private PictureBox pictureBox2;
    }
}