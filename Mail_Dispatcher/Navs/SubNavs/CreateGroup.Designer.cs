namespace Mail_Dispatcher.Navs.SubNavs
{
    partial class CreateGroup
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateGroup));
            groupNameField = new TextBox();
            memberList = new Label();
            memberListField = new TextBox();
            createGroupBtn = new Guna.UI2.WinForms.Guna2GradientTileButton();
            pictureBox1 = new PictureBox();
            name1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupNameField
            // 
            groupNameField.BackColor = Color.FromArgb(221, 221, 221);
            groupNameField.Location = new Point(150, 97);
            groupNameField.MaxLength = 20;
            groupNameField.Name = "groupNameField";
            groupNameField.PlaceholderText = "Group name";
            groupNameField.Size = new Size(207, 23);
            groupNameField.TabIndex = 0;
            // 
            // memberList
            // 
            memberList.AutoSize = true;
            memberList.BackColor = Color.FromArgb(221, 221, 221);
            memberList.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            memberList.Location = new Point(32, 125);
            memberList.Name = "memberList";
            memberList.Size = new Size(88, 15);
            memberList.TabIndex = 3;
            memberList.Text = "Member gmail ";
            // 
            // memberListField
            // 
            memberListField.BackColor = Color.FromArgb(221, 221, 221);
            memberListField.ForeColor = Color.DodgerBlue;
            memberListField.Location = new Point(150, 123);
            memberListField.MaxLength = 300;
            memberListField.Multiline = true;
            memberListField.Name = "memberListField";
            memberListField.PlaceholderText = "Comma Separated";
            memberListField.Size = new Size(207, 279);
            memberListField.TabIndex = 2;
            // 
            // createGroupBtn
            // 
            createGroupBtn.BackColor = Color.FromArgb(199, 194, 220);
            createGroupBtn.Cursor = Cursors.Hand;
            createGroupBtn.CustomizableEdges = customizableEdges1;
            createGroupBtn.DisabledState.BorderColor = Color.DarkGray;
            createGroupBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            createGroupBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            createGroupBtn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            createGroupBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            createGroupBtn.FillColor = Color.FromArgb(199, 194, 220);
            createGroupBtn.FillColor2 = Color.FromArgb(224, 224, 224);
            createGroupBtn.FocusedColor = Color.Gray;
            createGroupBtn.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createGroupBtn.ForeColor = Color.Black;
            createGroupBtn.ImageSize = new Size(10, 10);
            createGroupBtn.Location = new Point(205, 407);
            createGroupBtn.Name = "createGroupBtn";
            createGroupBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            createGroupBtn.Size = new Size(94, 26);
            createGroupBtn.TabIndex = 5;
            createGroupBtn.Text = "Create";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-32, -4);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1179, 784);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // name1
            // 
            name1.AutoSize = true;
            name1.BackColor = Color.FromArgb(221, 221, 221);
            name1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name1.Location = new Point(32, 99);
            name1.Name = "name1";
            name1.Size = new Size(37, 15);
            name1.TabIndex = 7;
            name1.Text = "name";
            // 
            // CreateGroup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1050, 783);
            Controls.Add(name1);
            Controls.Add(createGroupBtn);
            Controls.Add(memberList);
            Controls.Add(memberListField);
            Controls.Add(groupNameField);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateGroup";
            Text = "CreateGroup";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox groupNameField;
        private Label memberList;
        private TextBox memberListField;
        private Guna.UI2.WinForms.Guna2GradientTileButton createGroupBtn;
        private PictureBox pictureBox1;
        private Label name1;
    }
}