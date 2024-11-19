namespace Mail_Dispatcher
{
    partial class authForm
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
            authBtn = new Button();
            SuspendLayout();
            // 
            // authBtn
            // 
            authBtn.Location = new Point(307, 187);
            authBtn.Name = "authBtn";
            authBtn.Size = new Size(154, 38);
            authBtn.TabIndex = 0;
            authBtn.Text = "Auth";
            authBtn.UseVisualStyleBackColor = true;
            // 
            // authForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(authBtn);
            Name = "authForm";
            Text = "Auth Window";
            ResumeLayout(false);
        }

        #endregion

        private Button authBtn;
    }
}
