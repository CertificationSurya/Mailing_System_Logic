namespace Mail_Dispatcher.Navs
{
    partial class UserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfo));
            cross = new Button();
            SuspendLayout();
            // 
            // cross
            // 
            cross.Image = (Image)resources.GetObject("cross.Image");
            cross.Location = new Point(689, 9);
            cross.Name = "cross";
            cross.Size = new Size(100, 29);
            cross.TabIndex = 2;
            cross.UseVisualStyleBackColor = true;
            // 
            // UserInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cross);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserInfo";
            Text = "UserInfo";
            ResumeLayout(false);
        }

        #endregion

        private Button cross;
    }
}