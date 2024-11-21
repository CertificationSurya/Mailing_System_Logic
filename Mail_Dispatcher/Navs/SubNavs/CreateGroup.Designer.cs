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
            groupNameField = new TextBox();
            groupName = new Label();
            memberList = new Label();
            memberListField = new TextBox();
            createGroupBtn = new Guna.UI2.WinForms.Guna2GradientTileButton();
            SuspendLayout();
            // 
            // groupNameField
            // 
            groupNameField.Location = new Point(153, 93);
            groupNameField.MaxLength = 20;
            groupNameField.Name = "groupNameField";
            groupNameField.PlaceholderText = "Group name";
            groupNameField.Size = new Size(180, 23);
            groupNameField.TabIndex = 0;
            // 
            // groupName
            // 
            groupName.AutoSize = true;
            groupName.Location = new Point(57, 97);
            groupName.Name = "groupName";
            groupName.Size = new Size(81, 15);
            groupName.TabIndex = 1;
            groupName.Text = "Group Name :";
            // 
            // memberList
            // 
            memberList.AutoSize = true;
            memberList.Location = new Point(54, 136);
            memberList.Name = "memberList";
            memberList.Size = new Size(92, 15);
            memberList.TabIndex = 3;
            memberList.Text = "Member Gmail :";
            // 
            // memberListField
            // 
            memberListField.Location = new Point(153, 132);
            memberListField.MaxLength = 20;
            memberListField.Multiline = true;
            memberListField.Name = "memberListField";
            memberListField.PlaceholderText = "Comma Separated";
            memberListField.Size = new Size(180, 156);
            memberListField.TabIndex = 2;
            // 
            // createGroupBtn
            // 
            createGroupBtn.CustomizableEdges = customizableEdges1;
            createGroupBtn.DisabledState.BorderColor = Color.DarkGray;
            createGroupBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            createGroupBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            createGroupBtn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            createGroupBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            createGroupBtn.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createGroupBtn.ForeColor = Color.White;
            createGroupBtn.Location = new Point(105, 361);
            createGroupBtn.Name = "createGroupBtn";
            createGroupBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            createGroupBtn.Size = new Size(163, 36);
            createGroupBtn.TabIndex = 5;
            createGroupBtn.Text = "Create Group";
            // 
            // CreateGroup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 577);
            Controls.Add(createGroupBtn);
            Controls.Add(memberList);
            Controls.Add(memberListField);
            Controls.Add(groupName);
            Controls.Add(groupNameField);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateGroup";
            Text = "CreateGroup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox groupNameField;
        private Label groupName;
        private Label memberList;
        private TextBox memberListField;
        private Guna.UI2.WinForms.Guna2GradientTileButton createGroupBtn;
    }
}