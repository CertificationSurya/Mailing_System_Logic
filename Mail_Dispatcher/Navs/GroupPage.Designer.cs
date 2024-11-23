namespace Mail_Dispatcher.Navs
{
    partial class GroupPage
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
            groupText = new Label();
            createGroupNav = new Guna.UI2.WinForms.Guna2GradientTileButton();
            groupsPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // groupText
            // 
            groupText.AutoSize = true;
            groupText.BackColor = SystemColors.ButtonFace;
            groupText.Font = new Font("Sans Serif Collection", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupText.Location = new Point(1, 2);
            groupText.Name = "groupText";
            groupText.Size = new Size(89, 37);
            groupText.TabIndex = 1;
            groupText.Text = "Group";
            // 
            // createGroupNav
            // 
            createGroupNav.BackColor = SystemColors.ControlDark;
            createGroupNav.Cursor = Cursors.Hand;
            createGroupNav.CustomizableEdges = customizableEdges1;
            createGroupNav.DisabledState.BorderColor = Color.DarkGray;
            createGroupNav.DisabledState.CustomBorderColor = Color.DarkGray;
            createGroupNav.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            createGroupNav.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            createGroupNav.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            createGroupNav.FillColor = SystemColors.ButtonFace;
            createGroupNav.FillColor2 = SystemColors.ButtonFace;
            createGroupNav.FocusedColor = SystemColors.ButtonFace;
            createGroupNav.Font = new Font("Sans Serif Collection", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createGroupNav.ForeColor = Color.Black;
            createGroupNav.ImageSize = new Size(30, 30);
            createGroupNav.Location = new Point(222, -6);
            createGroupNav.Name = "createGroupNav";
            createGroupNav.ShadowDecoration.CustomizableEdges = customizableEdges2;
            createGroupNav.Size = new Size(59, 30);
            createGroupNav.TabIndex = 4;
            createGroupNav.Text = " +";
            createGroupNav.TextAlign = HorizontalAlignment.Right;
            // 
            // groupsPanel
            // 
            groupsPanel.Location = new Point(0, 60);
            groupsPanel.Margin = new Padding(3, 3, 3, 10);
            groupsPanel.Name = "groupsPanel";
            groupsPanel.Size = new Size(279, 469);
            groupsPanel.TabIndex = 5;
            // 
            // GroupPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(279, 529);
            Controls.Add(groupsPanel);
            Controls.Add(createGroupNav);
            Controls.Add(groupText);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GroupPage";
            Text = "GroupPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label groupText;
        private Guna.UI2.WinForms.Guna2GradientTileButton createGroupNav;
        private FlowLayoutPanel groupsPanel;
    }
}