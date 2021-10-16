
namespace Groupoid_analyzer
{
    partial class Cayley_table
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
            this.Back = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Cayley_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Back.Location = new System.Drawing.Point(12, 140);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 0;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Next
            // 
            this.Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Next.Location = new System.Drawing.Point(199, 140);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(148, 23);
            this.Next.TabIndex = 1;
            this.Next.Text = "Анализировать";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Cayley_tableLayoutPanel
            // 
            this.Cayley_tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cayley_tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cayley_tableLayoutPanel.ColumnCount = 2;
            this.Cayley_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Cayley_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Cayley_tableLayoutPanel.Location = new System.Drawing.Point(12, 67);
            this.Cayley_tableLayoutPanel.Name = "Cayley_tableLayoutPanel";
            this.Cayley_tableLayoutPanel.RowCount = 2;
            this.Cayley_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Cayley_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Cayley_tableLayoutPanel.Size = new System.Drawing.Size(335, 52);
            this.Cayley_tableLayoutPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Таблица Кэли";
            // 
            // Cayley_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(359, 175);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cayley_tableLayoutPanel);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Back);
            this.Name = "Cayley_table";
            this.Text = "Cayley_table";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cayley_table_FormClosing);
            this.Load += new System.EventHandler(this.Cayley_table_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.TableLayoutPanel Cayley_tableLayoutPanel;
        private System.Windows.Forms.Label label1;
    }
}