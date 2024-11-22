namespace Mail_Dispatcher.Components
{
    partial class GroupBox
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            createdAt = new Label();
            memberCount = new Label();
            ownerName = new Label();
            groupName = new Label();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // createdAt
            // 
            createdAt.AutoSize = true;
            createdAt.ForeColor = SystemColors.ControlDarkDark;
            createdAt.Location = new Point(228, 17);
            createdAt.Name = "createdAt";
            createdAt.Size = new Size(36, 15);
            createdAt.TabIndex = 3;
            createdAt.Text = "time/";
            // 
            // memberCount
            // 
            memberCount.AutoSize = true;
            memberCount.ForeColor = SystemColors.ControlDarkDark;
            memberCount.Location = new Point(17, 47);
            memberCount.Name = "memberCount";
            memberCount.Size = new Size(83, 15);
            memberCount.TabIndex = 4;
            memberCount.Text = "members: 40+";
            // 
            // ownerName
            // 
            ownerName.AutoSize = true;
            ownerName.ForeColor = SystemColors.ControlDarkDark;
            ownerName.Location = new Point(17, 32);
            ownerName.Name = "ownerName";
            ownerName.Size = new Size(60, 15);
            ownerName.TabIndex = 5;
            ownerName.Text = "the owner";
            // 
            // groupName
            // 
            groupName.AutoSize = true;
            groupName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupName.Location = new Point(17, 13);
            groupName.Name = "groupName";
            groupName.Size = new Size(74, 15);
            groupName.TabIndex = 6;
            groupName.Text = "group name";
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.FillColor = Color.RoyalBlue;
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(4, 17);
            guna2CirclePictureBox1.Margin = new Padding(3, 2, 3, 2);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(8, 7);
            guna2CirclePictureBox1.TabIndex = 2;
            guna2CirclePictureBox1.TabStop = false;
            guna2CirclePictureBox1.Click += guna2CirclePictureBox1_Click;
            // 
            // GroupBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(createdAt);
            Controls.Add(memberCount);
            Controls.Add(ownerName);
            Controls.Add(groupName);
            Controls.Add(guna2CirclePictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GroupBox";
            Size = new Size(268, 74);
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label createdAt;
        private Label memberCount;
        private Label ownerName;
        private Label groupName;
    }
}
