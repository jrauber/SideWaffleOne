namespace Wizard
{
    partial class WizardForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblValue = new System.Windows.Forms.Label();
            this.dpToday = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(149, 38);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(46, 15);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(44, 13);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "TODAY";
            // 
            // dpToday
            // 
            this.dpToday.Location = new System.Drawing.Point(96, 12);
            this.dpToday.Name = "dpToday";
            this.dpToday.Size = new System.Drawing.Size(200, 20);
            this.dpToday.TabIndex = 2;
            // 
            // WizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 68);
            this.Controls.Add(this.dpToday);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.btnSubmit);
            this.Name = "WizardForm";
            this.Text = "TGIF Wizard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.DateTimePicker dpToday;
    }
}