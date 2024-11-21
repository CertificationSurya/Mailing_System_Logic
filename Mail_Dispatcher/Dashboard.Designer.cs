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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            navContainer = new Panel();
            userPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            navbar = new TableLayoutPanel();
            composeNav = new PictureBox();
            sentNav = new PictureBox();
            inboxNav = new PictureBox();
            imgContainer = new Guna.UI2.WinForms.Guna2CircleButton();
            logo = new PictureBox();
            mainpanel = new FlowLayoutPanel();
            sidePanel = new FlowLayoutPanel();
            navContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userPic).BeginInit();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)composeNav).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sentNav).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inboxNav).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // navContainer
            // 
            navContainer.BorderStyle = BorderStyle.Fixed3D;
            navContainer.Controls.Add(userPic);
            navContainer.Controls.Add(navbar);
            navContainer.Controls.Add(imgContainer);
            navContainer.Controls.Add(logo);
            navContainer.Dock = DockStyle.Left;
            navContainer.Location = new Point(0, 0);
            navContainer.Name = "navContainer";
            navContainer.Size = new Size(114, 529);
            navContainer.TabIndex = 0;
            // 
            // userPic
            // 
            userPic.BackColor = Color.Transparent;
            userPic.Cursor = Cursors.Hand;
            userPic.ImageRotate = 0F;
            userPic.Location = new Point(24, 427);
            userPic.Name = "userPic";
            userPic.ShadowDecoration.CustomizableEdges = customizableEdges1;
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
            navbar.Controls.Add(composeNav, 0, 2);
            navbar.Controls.Add(sentNav, 0, 1);
            navbar.Controls.Add(inboxNav, 0, 0);
            navbar.Location = new Point(0, 135);
            navbar.Name = "navbar";
            navbar.RowCount = 3;
            navbar.RowStyles.Add(new RowStyle(SizeType.Percent, 21.55422F));
            navbar.RowStyles.Add(new RowStyle(SizeType.Percent, 20.1016579F));
            navbar.RowStyles.Add(new RowStyle(SizeType.Percent, 20.51709F));
            navbar.Size = new Size(110, 254);
            navbar.TabIndex = 1;
            // 
            // composeNav
            // 
            composeNav.Anchor = AnchorStyles.None;
            composeNav.BackColor = Color.Transparent;
            composeNav.Cursor = Cursors.Hand;
            composeNav.Image = (Image)resources.GetObject("composeNav.Image");
            composeNav.Location = new Point(20, 177);
            composeNav.Name = "composeNav";
            composeNav.Size = new Size(69, 67);
            composeNav.TabIndex = 3;
            composeNav.TabStop = false;
            // 
            // sentNav
            // 
            sentNav.Anchor = AnchorStyles.None;
            sentNav.BackColor = Color.Transparent;
            sentNav.Cursor = Cursors.Hand;
            sentNav.Image = (Image)resources.GetObject("sentNav.Image");
            sentNav.Location = new Point(20, 94);
            sentNav.Margin = new Padding(0);
            sentNav.Name = "sentNav";
            sentNav.Size = new Size(69, 68);
            sentNav.TabIndex = 2;
            sentNav.TabStop = false;
            // 
            // inboxNav
            // 
            inboxNav.Anchor = AnchorStyles.None;
            inboxNav.BackColor = Color.Transparent;
            inboxNav.Cursor = Cursors.Hand;
            inboxNav.Image = (Image)resources.GetObject("inboxNav.Image");
            inboxNav.Location = new Point(20, 19);
            inboxNav.Name = "inboxNav";
            inboxNav.Size = new Size(69, 51);
            inboxNav.TabIndex = 1;
            inboxNav.TabStop = false;
            inboxNav.Click += inboxNav_Click;
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
            imgContainer.Location = new Point(10, 412);
            imgContainer.Name = "imgContainer";
            imgContainer.PressedColor = Color.Transparent;
            imgContainer.ShadowDecoration.CustomizableEdges = customizableEdges2;
            imgContainer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            imgContainer.Size = new Size(90, 90);
            imgContainer.TabIndex = 1;
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Cursor = Cursors.Hand;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(0, 3);
            logo.Name = "logo";
            logo.Size = new Size(114, 77);
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // mainpanel
            // 
            mainpanel.BackColor = SystemColors.ControlDarkDark;
            mainpanel.Location = new Point(116, 0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(250, 529);
            mainpanel.TabIndex = 1;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = SystemColors.ControlDark;
            sidePanel.Location = new Point(367, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(432, 529);
            sidePanel.TabIndex = 2;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 529);
            Controls.Add(sidePanel);
            Controls.Add(mainpanel);
            Controls.Add(navContainer);
            Name = "Dashboard";
            Text = "Dashboard";
            navContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userPic).EndInit();
            navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)composeNav).EndInit();
            ((System.ComponentModel.ISupportInitialize)sentNav).EndInit();
            ((System.ComponentModel.ISupportInitialize)inboxNav).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel navContainer;
        private PictureBox logo;
        private PictureBox inboxNav;
        private TableLayoutPanel navbar;
        private PictureBox sentNav;
        private PictureBox composeNav;
        private Guna.UI2.WinForms.Guna2CircleButton imgContainer;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userPic;
        private FlowLayoutPanel mainpanel;
        private FlowLayoutPanel sidePanel;
    }
}