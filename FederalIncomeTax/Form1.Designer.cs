
namespace FederalIncomeTax
{
    partial class FrmFedIncomeTax
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTextBox = new System.Windows.Forms.TextBox();
            this.lblIncomeTax = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(123, 114);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(149, 55);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtTextBox
            // 
            this.txtTextBox.Location = new System.Drawing.Point(123, 70);
            this.txtTextBox.Name = "txtTextBox";
            this.txtTextBox.Size = new System.Drawing.Size(151, 23);
            this.txtTextBox.TabIndex = 1;
            // 
            // lblIncomeTax
            // 
            this.lblIncomeTax.AutoSize = true;
            this.lblIncomeTax.Location = new System.Drawing.Point(121, 26);
            this.lblIncomeTax.Name = "lblIncomeTax";
            this.lblIncomeTax.Size = new System.Drawing.Size(165, 15);
            this.lblIncomeTax.TabIndex = 2;
            this.lblIncomeTax.Text = "Federal Income Tax Calculator";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(124, 185);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 3;
            this.lblResult.Visible = false;
            // 
            // FrmFedIncomeTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 287);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblIncomeTax);
            this.Controls.Add(this.txtTextBox);
            this.Controls.Add(this.btnCalculate);
            this.Name = "FrmFedIncomeTax";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Federal Income Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtTextBox;
        private System.Windows.Forms.Label lblIncomeTax;
        private System.Windows.Forms.Label lblResult;
    }
}

