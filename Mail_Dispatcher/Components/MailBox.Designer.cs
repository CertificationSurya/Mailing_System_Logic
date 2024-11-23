namespace Mail_Dispatcher.Components
{
    partial class MailBox
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            groupLabel = new Label();
            senderLabel = new Label();
            createdAtLabel = new Label();
            subjectLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.FillColor = Color.RoyalBlue;
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(3, 12);
            guna2CirclePictureBox1.Margin = new Padding(3, 2, 3, 2);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(8, 7);
            guna2CirclePictureBox1.TabIndex = 0;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // groupLabel
            // 
            groupLabel.AutoSize = true;
            groupLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupLabel.Location = new Point(16, 8);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new Size(74, 15);
            groupLabel.TabIndex = 1;
            groupLabel.Text = "group name";
            // 
            // senderLabel
            // 
            senderLabel.AutoSize = true;
            senderLabel.ForeColor = SystemColors.ControlDarkDark;
            senderLabel.Location = new Point(16, 27);
            senderLabel.Name = "senderLabel";
            senderLabel.Size = new Size(54, 15);
            senderLabel.TabIndex = 1;
            senderLabel.Text = "john doe";
            // 
            // createdAtLabel
            // 
            createdAtLabel.AutoSize = true;
            createdAtLabel.ForeColor = SystemColors.ControlDarkDark;
            createdAtLabel.Location = new Point(125, 10);
            createdAtLabel.Name = "createdAtLabel";
            createdAtLabel.Size = new Size(34, 15);
            createdAtLabel.TabIndex = 1;
            createdAtLabel.Text = "10:20";
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.ForeColor = SystemColors.ControlDarkDark;
            subjectLabel.Location = new Point(16, 42);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new Size(45, 15);
            subjectLabel.TabIndex = 1;
            subjectLabel.Text = "subject";
            // 
            // MailBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(createdAtLabel);
            Controls.Add(subjectLabel);
            Controls.Add(senderLabel);
            Controls.Add(groupLabel);
            Controls.Add(guna2CirclePictureBox1);
            Name = "MailBox";
            Size = new Size(270, 75);
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label groupLabel;
        private Label senderLabel;
        private Label createdAtLabel;
        private Label subjectLabel;
    }
}
