namespace Mail_Dispatcher.Navs.SubNavs
{
    partial class ViewGroupMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewGroupMembers));
            cross = new Button();
            SuspendLayout();
            // 
            // cross
            // 
            cross.BackColor = SystemColors.ControlLightLight;
            cross.Image = (Image)resources.GetObject("cross.Image");
            cross.Location = new Point(528, 12);
            cross.Name = "cross";
            cross.Size = new Size(38, 29);
            cross.TabIndex = 2;
            cross.UseVisualStyleBackColor = false;
            cross.Click += cross_Click;
            // 
            // ViewGroupMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 697);
            Controls.Add(cross);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewGroupMembers";
            Text = "ViewGroupMembers";
            ResumeLayout(false);
        }

        #endregion

        private Button cross;
    }
}