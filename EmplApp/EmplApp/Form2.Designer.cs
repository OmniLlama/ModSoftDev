namespace EmplApp
{
    partial class Form2
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
            this.btnToForm1 = new System.Windows.Forms.Button();
            this.lstResult2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnToForm1
            // 
            this.btnToForm1.Location = new System.Drawing.Point(422, 220);
            this.btnToForm1.Name = "btnToForm1";
            this.btnToForm1.Size = new System.Drawing.Size(75, 23);
            this.btnToForm1.TabIndex = 0;
            this.btnToForm1.Text = "button1";
            this.btnToForm1.UseVisualStyleBackColor = true;
            // 
            // lstResult2
            // 
            this.lstResult2.FormattingEnabled = true;
            this.lstResult2.Location = new System.Drawing.Point(13, 13);
            this.lstResult2.Name = "lstResult2";
            this.lstResult2.Size = new System.Drawing.Size(484, 199);
            this.lstResult2.TabIndex = 1;
            this.lstResult2.SelectedIndexChanged += new System.EventHandler(this.lstResult_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 255);
            this.Controls.Add(this.lstResult2);
            this.Controls.Add(this.btnToForm1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToForm1;
        private System.Windows.Forms.ListBox lstResult2;
    }
}