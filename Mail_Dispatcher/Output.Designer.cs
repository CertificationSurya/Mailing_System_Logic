namespace Mail_Dispatcher
{
    partial class Output
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
            consoler = new TextBox();
            photoConsoler = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)photoConsoler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(200, 28);
            label1.Name = "label1";
            label1.Size = new Size(98, 19);
            label1.TabIndex = 0;
            label1.Text = "The Output is:";
            // 
            // consoler
            // 
            consoler.Location = new Point(23, 62);
            consoler.Multiline = true;
            consoler.Name = "consoler";
            consoler.ScrollBars = ScrollBars.Vertical;
            consoler.Size = new Size(531, 205);
            consoler.TabIndex = 1;
            // 
            // photoConsoler
            // 
            photoConsoler.Location = new Point(112, 293);
            photoConsoler.Name = "photoConsoler";
            photoConsoler.Size = new Size(331, 201);
            photoConsoler.TabIndex = 2;
            photoConsoler.TabStop = false;
            // 
            // Output
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 606);
            Controls.Add(photoConsoler);
            Controls.Add(consoler);
            Controls.Add(label1);
            Name = "Output";
            Text = "Output";
            ((System.ComponentModel.ISupportInitialize)photoConsoler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox consoler;
        private PictureBox photoConsoler;
    }
}