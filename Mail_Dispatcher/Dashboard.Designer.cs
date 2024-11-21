namespace Mail_Dispatcher
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            navContainer = new Panel();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            userPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            navbar = new TableLayoutPanel();
            groupNav = new PictureBox();
            composeNav = new PictureBox();
            sentNav = new PictureBox();
            inboxNav = new PictureBox();
            imgContainer = new Guna.UI2.WinForms.Guna2CircleButton();
            mainpanel = new Panel();
            sidePanel = new Panel();
            navContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userPic).BeginInit();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupNav).BeginInit();
            ((System.ComponentModel.ISupportInitialize)composeNav).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sentNav).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inboxNav).BeginInit();
            SuspendLayout();
            // 
            // navContainer
            // 
            navContainer.BorderStyle = BorderStyle.Fixed3D;
            navContainer.Controls.Add(guna2CirclePictureBox1);
            navContainer.Controls.Add(userPic);
            navContainer.Controls.Add(navbar);
            navContainer.Controls.Add(imgContainer);
            navContainer.Dock = DockStyle.Left;
            navContainer.Location = new Point(0, 0);
            navContainer.Name = "navContainer";
            navContainer.Size = new Size(114, 577);
            navContainer.TabIndex = 0;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.ErrorImage = (Image)resources.GetObject("guna2CirclePictureBox1.ErrorImage");
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageLocation = "";
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(11, 6);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(90, 90);
            guna2CirclePictureBox1.TabIndex = 0;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // userPic
            // 
            userPic.BackColor = Color.Transparent;
            userPic.Cursor = Cursors.Hand;
            userPic.ImageRotate = 0F;
            userPic.Location = new Point(24, 479);
            userPic.Name = "userPic";
            userPic.ShadowDecoration.CustomizableEdges = customizableEdges2;
            userPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            userPic.Size = new Size(64, 64);
            userPic.TabIndex = 2;
            userPic.TabStop = false;
            // 
            // navbar
            // 
            navbar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            navbar.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            navbar.ColumnCount = 1;
            navbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            navbar.Controls.Add(groupNav, 0, 3);
            navbar.Controls.Add(composeNav, 0, 2);
            navbar.Controls.Add(sentNav, 0, 1);
            navbar.Controls.Add(inboxNav, 0, 0);
            navbar.Location = new Point(0, 104);
            navbar.Name = "navbar";
            navbar.RowCount = 4;
            navbar.RowStyles.Add(new RowStyle(SizeType.Percent, 26.2303066F));
            navbar.RowStyles.Add(new RowStyle(SizeType.Percent, 24.462616F));
            navbar.RowStyles.Add(new RowStyle(SizeType.Percent, 24.968174F));
            navbar.RowStyles.Add(new RowStyle(SizeType.Percent, 24.3389053F));
            navbar.Size = new Size(110, 329);
            navbar.TabIndex = 1;
            // 
            // groupNav
            // 
            groupNav.Anchor = AnchorStyles.None;
            groupNav.BackColor = Color.Transparent;
            groupNav.Cursor = Cursors.Hand;
            groupNav.Image = (Image)resources.GetObject("groupNav.Image");
            groupNav.Location = new Point(20, 251);
            groupNav.Name = "groupNav";
            groupNav.Size = new Size(69, 72);
            groupNav.TabIndex = 4;
            groupNav.TabStop = false;
            // 
            // composeNav
            // 
            composeNav.Anchor = AnchorStyles.None;
            composeNav.BackColor = Color.Transparent;
            composeNav.Cursor = Cursors.Hand;
            composeNav.Image = (Image)resources.GetObject("composeNav.Image");
            composeNav.Location = new Point(20, 170);
            composeNav.Name = "composeNav";
            composeNav.Size = new Size(69, 72);
            composeNav.TabIndex = 3;
            composeNav.TabStop = false;
            // 
            // sentNav
            // 
            sentNav.Anchor = AnchorStyles.None;
            sentNav.BackColor = Color.Transparent;
            sentNav.Cursor = Cursors.Hand;
            sentNav.Image = (Image)resources.GetObject("sentNav.Image");
            sentNav.Location = new Point(20, 91);
            sentNav.Margin = new Padding(0);
            sentNav.Name = "sentNav";
            sentNav.Size = new Size(69, 70);
            sentNav.TabIndex = 2;
            sentNav.TabStop = false;
            // 
            // inboxNav
            // 
            inboxNav.Anchor = AnchorStyles.None;
            inboxNav.BackColor = Color.Transparent;
            inboxNav.Cursor = Cursors.Hand;
            inboxNav.Image = (Image)resources.GetObject("inboxNav.Image");
            inboxNav.Location = new Point(20, 18);
            inboxNav.Name = "inboxNav";
            inboxNav.Size = new Size(69, 51);
            inboxNav.TabIndex = 1;
            inboxNav.TabStop = false;
            // 
            // imgContainer
            // 
            imgContainer.BackColor = SystemColors.Control;
            imgContainer.DisabledState.BorderColor = Color.DarkGray;
            imgContainer.DisabledState.CustomBorderColor = Color.DarkGray;
            imgContainer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            imgContainer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            imgContainer.FillColor = Color.FromArgb(217, 217, 217);
            imgContainer.FocusedColor = Color.Transparent;
            imgContainer.Font = new Font("Segoe UI", 9F);
            imgContainer.ForeColor = Color.White;
            imgContainer.Location = new Point(10, 464);
            imgContainer.Name = "imgContainer";
            imgContainer.PressedColor = Color.Transparent;
            imgContainer.ShadowDecoration.CustomizableEdges = customizableEdges3;
            imgContainer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            imgContainer.Size = new Size(90, 90);
            imgContainer.TabIndex = 1;
            // 
            // mainpanel
            // 
            mainpanel.BackColor = Color.FromArgb(248, 249, 251);
            mainpanel.BorderStyle = BorderStyle.Fixed3D;
            mainpanel.Dock = DockStyle.Left;
            mainpanel.Location = new Point(114, 0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(270, 577);
            mainpanel.TabIndex = 3;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(240, 244, 241);
            sidePanel.BorderStyle = BorderStyle.Fixed3D;
            sidePanel.Dock = DockStyle.Right;
            sidePanel.Location = new Point(386, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(414, 577);
            sidePanel.TabIndex = 0;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 577);
            Controls.Add(sidePanel);
            Controls.Add(mainpanel);
            Controls.Add(navContainer);
            Name = "Dashboard";
            Text = "Dashboard";
            navContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userPic).EndInit();
            navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupNav).EndInit();
            ((System.ComponentModel.ISupportInitialize)composeNav).EndInit();
            ((System.ComponentModel.ISupportInitialize)sentNav).EndInit();
            ((System.ComponentModel.ISupportInitialize)inboxNav).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel navContainer;
        private PictureBox inboxNav;
        private TableLayoutPanel navbar;
        private PictureBox sentNav;
        private PictureBox composeNav;
        private Guna.UI2.WinForms.Guna2CircleButton imgContainer;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userPic;
        private Panel mainpanel;
        private PictureBox groupNav;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Panel sidePanel;
    }
}