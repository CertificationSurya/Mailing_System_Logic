namespace Project_vz_Alpha
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            add = new Button();
            panel3 = new Panel();
            trash = new PictureBox();
            panel4 = new Panel();
            label2 = new Label();
            sent = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            box = new PictureBox();
            pictureBox2 = new PictureBox();
            panel6 = new Panel();
            adduc1 = new AddUC();
            panel7 = new Panel();
            pictureBox1 = new PictureBox();
            inboxuc1 = new InboxUC();
            sentuc1 = new SentUC();
            label4 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trash).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sent).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 49, 55);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 1022);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            panel1.MouseEnter += panel1_MouseEnter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(194, 231, 255);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(add);
            panel5.Location = new Point(17, 174);
            panel5.Name = "panel5";
            panel5.Size = new Size(211, 93);
            panel5.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(57, 31);
            label1.Name = "label1";
            label1.Size = new Size(132, 37);
            label1.TabIndex = 6;
            label1.Text = "Compose";
            // 
            // add
            // 
            add.BackColor = Color.FromArgb(194, 231, 255);
            add.BackgroundImage = Properties.Resources.icons8_plus_math_100;
            add.BackgroundImageLayout = ImageLayout.Zoom;
            add.FlatStyle = FlatStyle.Flat;
            add.ImageAlign = ContentAlignment.MiddleLeft;
            add.Location = new Point(0, 23);
            add.Margin = new Padding(0);
            add.Name = "add";
            add.Size = new Size(54, 49);
            add.TabIndex = 5;
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.CornflowerBlue;
            panel3.Controls.Add(trash);
            panel3.Location = new Point(12, 601);
            panel3.Name = "panel3";
            panel3.Size = new Size(222, 109);
            panel3.TabIndex = 14;
            // 
            // trash
            // 
            trash.BackColor = Color.CornflowerBlue;
            trash.Image = Properties.Resources.icons8_paper_airplane_50;
            trash.Location = new Point(2, 30);
            trash.Name = "trash";
            trash.Size = new Size(74, 63);
            trash.SizeMode = PictureBoxSizeMode.CenterImage;
            trash.TabIndex = 12;
            trash.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.CornflowerBlue;
            panel4.Controls.Add(label2);
            panel4.Controls.Add(sent);
            panel4.Location = new Point(12, 450);
            panel4.Name = "panel4";
            panel4.Size = new Size(222, 109);
            panel4.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(92, 37);
            label2.Name = "label2";
            label2.Size = new Size(72, 37);
            label2.TabIndex = 7;
            label2.Text = "Sent";
            // 
            // sent
            // 
            sent.BackColor = Color.CornflowerBlue;
            sent.Image = Properties.Resources.icons8_paper_airplane_50;
            sent.Location = new Point(2, 26);
            sent.Name = "sent";
            sent.Size = new Size(74, 63);
            sent.SizeMode = PictureBoxSizeMode.CenterImage;
            sent.TabIndex = 1;
            sent.TabStop = false;
            sent.Click += sent_Click;
            sent.MouseEnter += sent_MouseEnter;
            sent.MouseLeave += sent_MouseLeave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(box);
            panel2.Location = new Point(14, 299);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 109);
            panel2.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(94, 39);
            label3.Name = "label3";
            label3.Size = new Size(87, 37);
            label3.TabIndex = 8;
            label3.Text = "Inbox";
            // 
            // box
            // 
            box.BackColor = Color.Transparent;
            box.Image = (Image)resources.GetObject("box.Image");
            box.Location = new Point(3, 27);
            box.Name = "box";
            box.Size = new Size(69, 49);
            box.SizeMode = PictureBoxSizeMode.CenterImage;
            box.TabIndex = 3;
            box.TabStop = false;
            box.Click += box_Click;
            box.MouseEnter += box_MouseEnter;
            box.MouseLeave += box_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(17, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(96, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Location = new Point(518, 83);
            panel6.Name = "panel6";
            panel6.Size = new Size(796, 676);
            panel6.TabIndex = 3;
            panel6.Paint += panel6_Paint;
            // 
            // adduc1
            // 
            adduc1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            adduc1.BackColor = Color.Transparent;
            adduc1.Location = new Point(751, 37);
            adduc1.Name = "adduc1";
            adduc1.Size = new Size(1075, 981);
            adduc1.TabIndex = 0;
            adduc1.Visible = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.CornflowerBlue;
            panel7.Controls.Add(pictureBox1);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(231, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(1595, 42);
            panel7.TabIndex = 3;
            panel7.MouseDown += panel7_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.icons8_close_50;
            pictureBox1.Location = new Point(1543, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // inboxuc1
            // 
            inboxuc1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inboxuc1.Location = new Point(237, 45);
            inboxuc1.Name = "inboxuc1";
            inboxuc1.Size = new Size(1586, 971);
            inboxuc1.TabIndex = 4;
            // 
            // sentuc1
            // 
            sentuc1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            sentuc1.Location = new Point(280, 38);
            sentuc1.Name = "sentuc1";
            sentuc1.Size = new Size(242, 981);
            sentuc1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(108, 21);
            label4.Name = "label4";
            label4.Size = new Size(80, 68);
            label4.TabIndex = 9;
            label4.Text = "FLUX\r\nMAIL\r\n";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1826, 1022);
            Controls.Add(panel7);
            Controls.Add(inboxuc1);
            Controls.Add(adduc1);
            Controls.Add(panel1);
            Controls.Add(sentuc1);
            Controls.Add(panel6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trash).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sent).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)box).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel6;
        private Panel panel7;
        private PictureBox pictureBox1;
        private PictureBox box;
        private PictureBox sent;
        private Button add;
        private AddUC adduc1;
        private InboxUC inboxuc1;
        private SentUC sentuc1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private PictureBox trash;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label4;
    }
}
