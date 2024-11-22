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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            navContainer = new Panel();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            userPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            navbar = new TableLayoutPanel();
            composeNav = new PictureBox();
            sentNav = new PictureBox();
            inboxNav = new PictureBox();
            groupNav = new PictureBox();
            imgContainer = new Guna.UI2.WinForms.Guna2CircleButton();
            mainpanel = new Panel();
            sidePanel = new Panel();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            navContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userPic).BeginInit();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)composeNav).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sentNav).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inboxNav).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupNav).BeginInit();
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
            navContainer.Margin = new Padding(3, 4, 3, 4);
            navContainer.Name = "navContainer";
            navContainer.Size = new Size(130, 913);
            navContainer.TabIndex = 0;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.ErrorImage = (Image)resources.GetObject("guna2CirclePictureBox1.ErrorImage");
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageLocation = "";
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(13, 8);
            guna2CirclePictureBox1.Margin = new Padding(3, 4, 3, 4);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(103, 120);
            guna2CirclePictureBox1.TabIndex = 0;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // userPic
            // 
            userPic.BackColor = Color.Transparent;
            userPic.Cursor = Cursors.Hand;
            userPic.ImageRotate = 0F;
            userPic.Location = new Point(27, 639);
            userPic.Margin = new Padding(3, 4, 3, 4);
            userPic.Name = "userPic";
            userPic.ShadowDecoration.CustomizableEdges = customizableEdges2;
            userPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            userPic.Size = new Size(73, 85);
            userPic.TabIndex = 2;
            userPic.TabStop = false;
            // 
            // navbar
            // 
            navbar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            navbar.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            navbar.ColumnCount = 1;
            navbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            navbar.Controls.Add(composeNav, 0, 3);
            navbar.Controls.Add(sentNav, 0, 1);
            navbar.Controls.Add(inboxNav, 0, 0);
            navbar.Controls.Add(groupNav, 0, 2);
            navbar.Location = new Point(0, 139);
            navbar.Margin = new Padding(3, 4, 3, 4);
            navbar.Name = "navbar";
            navbar.RowCount = 4;
            navbar.RowStyles.Add(new RowStyle(SizeType.Percent, 26.2303066F));
            navbar.RowStyles.Add(new RowStyle(SizeType.Percent, 24.462616F));
            navbar.RowStyles.Add(new RowStyle(SizeType.Percent, 24.968174F));
            navbar.RowStyles.Add(new RowStyle(SizeType.Percent, 24.3389053F));
            navbar.Size = new Size(126, 439);
            navbar.TabIndex = 1;
            // 
            // composeNav
            // 
            composeNav.Anchor = AnchorStyles.None;
            composeNav.BackColor = Color.Transparent;
            composeNav.Cursor = Cursors.Hand;
            composeNav.Image = (Image)resources.GetObject("composeNav.Image");
            composeNav.Location = new Point(23, 335);
            composeNav.Margin = new Padding(3, 4, 3, 4);
            composeNav.Name = "composeNav";
            composeNav.Size = new Size(79, 96);
            composeNav.TabIndex = 3;
            composeNav.TabStop = false;
            // 
            // sentNav
            // 
            sentNav.Anchor = AnchorStyles.None;
            sentNav.BackColor = Color.Transparent;
            sentNav.Cursor = Cursors.Hand;
            sentNav.Image = (Image)resources.GetObject("sentNav.Image");
            sentNav.Location = new Point(23, 122);
            sentNav.Margin = new Padding(0);
            sentNav.Name = "sentNav";
            sentNav.Size = new Size(79, 93);
            sentNav.TabIndex = 2;
            sentNav.TabStop = false;
            // 
            // inboxNav
            // 
            inboxNav.Anchor = AnchorStyles.None;
            inboxNav.BackColor = Color.Transparent;
            inboxNav.Cursor = Cursors.Hand;
            inboxNav.Image = (Image)resources.GetObject("inboxNav.Image");
            inboxNav.Location = new Point(23, 24);
            inboxNav.Margin = new Padding(3, 4, 3, 4);
            inboxNav.Name = "inboxNav";
            inboxNav.Size = new Size(79, 68);
            inboxNav.TabIndex = 1;
            inboxNav.TabStop = false;
            // 
            // groupNav
            // 
            groupNav.Anchor = AnchorStyles.None;
            groupNav.BackColor = Color.Transparent;
            groupNav.Cursor = Cursors.Hand;
            groupNav.Image = (Image)resources.GetObject("groupNav.Image");
            groupNav.Location = new Point(23, 227);
            groupNav.Margin = new Padding(3, 4, 3, 4);
            groupNav.Name = "groupNav";
            groupNav.Size = new Size(79, 96);
            groupNav.TabIndex = 4;
            groupNav.TabStop = false;
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
            imgContainer.Location = new Point(11, 619);
            imgContainer.Margin = new Padding(3, 4, 3, 4);
            imgContainer.Name = "imgContainer";
            imgContainer.PressedColor = Color.Transparent;
            imgContainer.ShadowDecoration.CustomizableEdges = customizableEdges3;
            imgContainer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            imgContainer.Size = new Size(103, 120);
            imgContainer.TabIndex = 1;
            // 
            // mainpanel
            // 
            mainpanel.BackColor = Color.FromArgb(248, 249, 251);
            mainpanel.BorderStyle = BorderStyle.Fixed3D;
            mainpanel.Dock = DockStyle.Left;
            mainpanel.Location = new Point(130, 0);
            mainpanel.Margin = new Padding(3, 4, 3, 4);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(308, 913);
            mainpanel.TabIndex = 3;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(240, 244, 241);
            sidePanel.BorderStyle = BorderStyle.Fixed3D;
            sidePanel.Dock = DockStyle.Fill;
            sidePanel.Location = new Point(438, 0);
            sidePanel.Margin = new Padding(3, 4, 3, 4);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(767, 913);
            sidePanel.TabIndex = 0;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 913);
            Controls.Add(sidePanel);
            Controls.Add(mainpanel);
            Controls.Add(navContainer);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Shown;
            navContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userPic).EndInit();
            navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)composeNav).EndInit();
            ((System.ComponentModel.ISupportInitialize)sentNav).EndInit();
            ((System.ComponentModel.ISupportInitialize)inboxNav).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupNav).EndInit();
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
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}