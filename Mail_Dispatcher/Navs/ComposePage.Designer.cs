﻿namespace Mail_Dispatcher.Navs
{
    partial class ComposePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComposePage));
            label1 = new Label();
            cross = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 196);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "new email write";
            // 
            // cross
            // 
            cross.Image = (Image)resources.GetObject("cross.Image");
            cross.Location = new Point(688, 12);
            cross.Name = "cross";
            cross.Size = new Size(100, 29);
            cross.TabIndex = 1;
            cross.UseVisualStyleBackColor = true;
            // 
            // ComposePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cross);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ComposePage";
            Text = "ComposePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button cross;
    }
}