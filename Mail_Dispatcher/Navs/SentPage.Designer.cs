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
            mailBox1 = new Components.MailBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 225);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "SentPage";
            // 
            // mailBox1
            // 
            mailBox1.BackColor = SystemColors.ControlLightLight;
            mailBox1.BorderStyle = BorderStyle.FixedSingle;
            mailBox1.Location = new Point(0, 105);
            mailBox1.Margin = new Padding(3, 4, 3, 4);
            mailBox1.Name = "mailBox1";
            mailBox1.Size = new Size(385, 125);
            mailBox1.TabIndex = 2;
            // 
            // SentPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(308, 913);
            Controls.Add(mailBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SentPage";
            Text = "SentPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Components.MailBox mailBox1;
    }
}