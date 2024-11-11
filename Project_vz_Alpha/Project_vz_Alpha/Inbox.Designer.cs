namespace Project_vz_Alpha
{
    partial class InboxUC
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
            panel2 = new Panel();
            flowLayoutPanelLabels = new FlowLayoutPanel();
            Reload = new Button();
            richTextBoxEmails = new RichTextBox();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(flowLayoutPanelLabels);
            panel2.Controls.Add(Reload);
            panel2.Controls.Add(richTextBoxEmails);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1622, 1154);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // flowLayoutPanelLabels
            // 
            flowLayoutPanelLabels.AutoScroll = true;
            flowLayoutPanelLabels.BackColor = Color.AliceBlue;
            flowLayoutPanelLabels.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelLabels.Font = new Font("Segoe UI", 12F);
            flowLayoutPanelLabels.Location = new Point(13, 53);
            flowLayoutPanelLabels.Name = "flowLayoutPanelLabels";
            flowLayoutPanelLabels.Size = new Size(496, 1101);
            flowLayoutPanelLabels.TabIndex = 10;
            flowLayoutPanelLabels.Click += flowLayoutPanelLabels_Click;
            flowLayoutPanelLabels.Paint += flowLayoutPanelLabels_Paint;
            // 
            // Reload
            // 
            Reload.BackColor = Color.Transparent;
            Reload.BackgroundImage = Properties.Resources.icons8_reboot_100;
            Reload.BackgroundImageLayout = ImageLayout.Zoom;
            Reload.Location = new Point(474, 14);
            Reload.Margin = new Padding(1);
            Reload.Name = "Reload";
            Reload.Size = new Size(35, 35);
            Reload.TabIndex = 8;
            Reload.UseVisualStyleBackColor = false;
            Reload.Click += button1_Click;
            // 
            // richTextBoxEmails
            // 
            richTextBoxEmails.BackColor = Color.AliceBlue;
            richTextBoxEmails.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxEmails.Font = new Font("Segoe UI", 15F);
            richTextBoxEmails.Location = new Point(515, 52);
            richTextBoxEmails.Name = "richTextBoxEmails";
            richTextBoxEmails.Size = new Size(1091, 1066);
            richTextBoxEmails.TabIndex = 7;
            richTextBoxEmails.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(85, 35);
            label1.TabIndex = 1;
            label1.Text = "Inbox";
            // 
            // InboxUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "InboxUC";
            Size = new Size(1622, 1154);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Panel panel5;
        private Panel panel3;
        private RichTextBox richTextBoxEmails;
        private Button Reload;
        private FlowLayoutPanel flowLayoutPanelLabels;
    }
}
