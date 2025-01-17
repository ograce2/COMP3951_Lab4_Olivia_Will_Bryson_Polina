namespace COMP3951_Lab2_Olivia_Grace_Jason_Peacock
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
            this.textBoxCalculation = new System.Windows.Forms.TextBox();
            this.groupBoxMemory = new System.Windows.Forms.GroupBox();
            this.panelDigits = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelDigits.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCalculation
            // 
            this.textBoxCalculation.Enabled = false;
            this.textBoxCalculation.Location = new System.Drawing.Point(117, 37);
            this.textBoxCalculation.Name = "textBoxCalculation";
            this.textBoxCalculation.Size = new System.Drawing.Size(305, 22);
            this.textBoxCalculation.TabIndex = 1;
            // 
            // groupBoxMemory
            // 
            this.groupBoxMemory.Location = new System.Drawing.Point(233, 84);
            this.groupBoxMemory.Name = "groupBoxMemory";
            this.groupBoxMemory.Size = new System.Drawing.Size(268, 100);
            this.groupBoxMemory.TabIndex = 2;
            this.groupBoxMemory.TabStop = false;
            this.groupBoxMemory.Text = "Memory Buttons";
            // 
            // panelDigits
            // 
            this.panelDigits.Controls.Add(this.button2);
            this.panelDigits.Controls.Add(this.button1);
            this.panelDigits.Location = new System.Drawing.Point(39, 223);
            this.panelDigits.Name = "panelDigits";
            this.panelDigits.Size = new System.Drawing.Size(227, 264);
            this.panelDigits.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 686);
            this.Controls.Add(this.panelDigits);
            this.Controls.Add(this.groupBoxMemory);
            this.Controls.Add(this.textBoxCalculation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.panelDigits.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxCalculation;
        private System.Windows.Forms.GroupBox groupBoxMemory;
        private System.Windows.Forms.Panel panelDigits;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

