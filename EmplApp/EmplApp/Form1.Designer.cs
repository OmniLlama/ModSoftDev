namespace EmplApp
{
    partial class Form1
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
            this.btnToForm2 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblIndexOfSelected = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnToForm2
            // 
            this.btnToForm2.Location = new System.Drawing.Point(376, 230);
            this.btnToForm2.Name = "btnToForm2";
            this.btnToForm2.Size = new System.Drawing.Size(75, 23);
            this.btnToForm2.TabIndex = 0;
            this.btnToForm2.Text = "Show Form2";
            this.btnToForm2.UseVisualStyleBackColor = true;
            this.btnToForm2.Click += new System.EventHandler(this.btnToForm2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 43);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(90, 75);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(181, 20);
            this.txtSalary.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Salary";
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(91, 42);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(181, 20);
            this.txtLast.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Last Name";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(91, 9);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(181, 20);
            this.txtFirst.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name";
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Location = new System.Drawing.Point(13, 158);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(357, 95);
            this.lstResult.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 67);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblIndexOfSelected
            // 
            this.lblIndexOfSelected.AutoSize = true;
            this.lblIndexOfSelected.Location = new System.Drawing.Point(110, 260);
            this.lblIndexOfSelected.Name = "lblIndexOfSelected";
            this.lblIndexOfSelected.Size = new System.Drawing.Size(0, 13);
            this.lblIndexOfSelected.TabIndex = 18;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(279, 13);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(172, 138);
            this.txtResult.TabIndex = 19;
            this.txtResult.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 335);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblIndexOfSelected);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnToForm2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToForm2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblIndexOfSelected;
        private System.Windows.Forms.RichTextBox txtResult;
    }
}

