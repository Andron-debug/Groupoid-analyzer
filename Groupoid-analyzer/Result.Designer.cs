
namespace Groupoid_analyzer
{
    partial class Result
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
            this.label1 = new System.Windows.Forms.Label();
            this.Characteristic_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Сlassification_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Свойства операций";
            // 
            // Characteristic_textBox
            // 
            this.Characteristic_textBox.Location = new System.Drawing.Point(21, 63);
            this.Characteristic_textBox.Multiline = true;
            this.Characteristic_textBox.Name = "Characteristic_textBox";
            this.Characteristic_textBox.ReadOnly = true;
            this.Characteristic_textBox.Size = new System.Drawing.Size(425, 151);
            this.Characteristic_textBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 51);
            this.label2.TabIndex = 6;
            this.label2.Text = "Классификация";
            // 
            // Сlassification_textBox
            // 
            this.Сlassification_textBox.Location = new System.Drawing.Point(21, 283);
            this.Сlassification_textBox.Multiline = true;
            this.Сlassification_textBox.Name = "Сlassification_textBox";
            this.Сlassification_textBox.ReadOnly = true;
            this.Сlassification_textBox.Size = new System.Drawing.Size(425, 151);
            this.Сlassification_textBox.TabIndex = 7;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 440);
            this.Controls.Add(this.Сlassification_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Characteristic_textBox);
            this.Controls.Add(this.label1);
            this.Name = "Result";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Characteristic_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Сlassification_textBox;
    }
}