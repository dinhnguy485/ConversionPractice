namespace ConversionPractice
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
            this.titleConvert = new System.Windows.Forms.Label();
            this.convertChoice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.optionConvert = new System.Windows.Forms.TextBox();
            this.valueConvert = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.convertOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleConvert
            // 
            this.titleConvert.AutoSize = true;
            this.titleConvert.Location = new System.Drawing.Point(184, 28);
            this.titleConvert.Name = "titleConvert";
            this.titleConvert.Size = new System.Drawing.Size(92, 13);
            this.titleConvert.TabIndex = 0;
            this.titleConvert.Text = "Linear Conversion";
            // 
            // convertChoice
            // 
            this.convertChoice.AutoSize = true;
            this.convertChoice.Location = new System.Drawing.Point(71, 206);
            this.convertChoice.Name = "convertChoice";
            this.convertChoice.Size = new System.Drawing.Size(154, 13);
            this.convertChoice.TabIndex = 1;
            this.convertChoice.Text = "Enter Conversion Choice (1-4): ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Value To Be Convert: ";
            // 
            // optionConvert
            // 
            this.optionConvert.Location = new System.Drawing.Point(248, 203);
            this.optionConvert.Name = "optionConvert";
            this.optionConvert.Size = new System.Drawing.Size(100, 20);
            this.optionConvert.TabIndex = 3;
            // 
            // valueConvert
            // 
            this.valueConvert.Location = new System.Drawing.Point(248, 234);
            this.valueConvert.Name = "valueConvert";
            this.valueConvert.Size = new System.Drawing.Size(100, 20);
            this.valueConvert.TabIndex = 4;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(136, 300);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(212, 28);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // convertOutput
            // 
            this.convertOutput.AutoSize = true;
            this.convertOutput.Location = new System.Drawing.Point(221, 362);
            this.convertOutput.Name = "convertOutput";
            this.convertOutput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.convertOutput.Size = new System.Drawing.Size(19, 13);
            this.convertOutput.TabIndex = 6;
            this.convertOutput.Text = "....";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.convertOutput);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.valueConvert);
            this.Controls.Add(this.optionConvert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convertChoice);
            this.Controls.Add(this.titleConvert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleConvert;
        private System.Windows.Forms.Label convertChoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox optionConvert;
        private System.Windows.Forms.TextBox valueConvert;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label convertOutput;
    }
}

