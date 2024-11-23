namespace Mail_Dispatcher.Navs
{
    partial class InboxPage
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
            inboxText = new Label();
            inboxPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // inboxText
            // 
            inboxText.AutoSize = true;
            inboxText.Font = new Font("Sans Serif Collection", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inboxText.Location = new Point(12, 9);
            inboxText.Name = "inboxText";
            inboxText.Size = new Size(80, 37);
            inboxText.TabIndex = 0;
            inboxText.Text = "Inbox";
            // 
            // inboxPanel
            // 
            inboxPanel.Dock = DockStyle.Bottom;
            inboxPanel.Location = new Point(0, 56);
            inboxPanel.Margin = new Padding(3, 3, 3, 10);
            inboxPanel.Name = "inboxPanel";
            inboxPanel.Size = new Size(279, 473);
            inboxPanel.TabIndex = 6;
            // 
            // InboxPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(279, 529);
            Controls.Add(inboxPanel);
            Controls.Add(inboxText);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InboxPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inbox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label inboxText;
        private FlowLayoutPanel inboxPanel;
    }
}