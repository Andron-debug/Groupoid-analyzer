
namespace Groupoid_analyzer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Universum_textBox = new System.Windows.Forms.TextBox();
            this.Next = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Множество";
            // 
            // Universum_textBox
            // 
            this.Universum_textBox.Location = new System.Drawing.Point(45, 72);
            this.Universum_textBox.Multiline = true;
            this.Universum_textBox.Name = "Universum_textBox";
            this.Universum_textBox.Size = new System.Drawing.Size(246, 331);
            this.Universum_textBox.TabIndex = 1;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(216, 421);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 2;
            this.Next.Text = "Далее";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(12, 421);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(116, 23);
            this.About.TabIndex = 3;
            this.About.Text = "О программе";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 456);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Universum_textBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Universum_textBox;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button About;
    }
}

