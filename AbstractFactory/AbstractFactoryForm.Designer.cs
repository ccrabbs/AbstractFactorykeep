namespace AbstractFactory
{
    partial class AbstractFactoryForm
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
            this.ButtonTestLoan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // btnTestLoan
            //
            this.ButtonTestLoan.Location = new System.Drawing.Point(130, 322);
            this.ButtonTestLoan.Name = "btnTestLoan";
            this.ButtonTestLoan.Size = new System.Drawing.Size(102, 23);
            this.ButtonTestLoan.TabIndex = 0;
            this.ButtonTestLoan.Text = "Test Loan";
            this.ButtonTestLoan.UseVisualStyleBackColor = true;
            this.ButtonTestLoan.Click += new System.EventHandler(this.ButtonTestLoan_Click);
            //
            // AbstractFactoryForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 348);
            this.Controls.Add(this.ButtonTestLoan);
            this.Name = "AbstractFactoryForm";
            this.Text = "AbstractFactoryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonTestLoan;
    }
}