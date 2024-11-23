namespace Mail_Dispatcher.Navs
{
    partial class SentPage
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
            label1 = new Label();
            inboxText = new Label();
            mailPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 169);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "SentPage";
            // 
            // inboxText
            // 
            inboxText.AutoSize = true;
            inboxText.Font = new Font("Sans Serif Collection", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inboxText.Location = new Point(11, 12);
            inboxText.Name = "inboxText";
            inboxText.Size = new Size(137, 37);
            inboxText.TabIndex = 3;
            inboxText.Text = "Sent Mails";
            // 
            // mailPanel
            // 
            mailPanel.Location = new Point(-4, 72);
            mailPanel.Margin = new Padding(3, 3, 3, 10);
            mailPanel.Name = "mailPanel";
            mailPanel.Size = new Size(279, 611);
            mailPanel.TabIndex = 6;
            // 
            // SentPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(270, 685);
            Controls.Add(mailPanel);
            Controls.Add(inboxText);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SentPage";
            Text = "SentPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label inboxText;
        private FlowLayoutPanel mailPanel;
    }
}