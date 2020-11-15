

namespace P1_IA
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.legend = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printResultLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.printResultLabel2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.legend);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(39, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 429);
            this.panel1.TabIndex = 0;
            // 
            // legend
            // 
            this.legend.AutoSize = true;
            this.legend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.legend.Location = new System.Drawing.Point(697, 38);
            this.legend.Name = "legend";
            this.legend.Size = new System.Drawing.Size(253, 168);
            this.legend.TabIndex = 3;
            this.legend.Text = "Leyenda:\r\n\r\n ▢   Vacío\r\n ▩   Obstáculo\r\n ⊕   Posición inicial               \r\n ✹ " +
    "  Posición final                    \r\n ▣   Recorrido          ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(733, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // printResultLabel
            // 
            this.printResultLabel.AutoSize = true;
            this.printResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printResultLabel.Location = new System.Drawing.Point(709, 319);
            this.printResultLabel.Margin = new System.Windows.Forms.Padding(500);
            this.printResultLabel.Name = "printResultLabel";
            this.printResultLabel.Size = new System.Drawing.Size(62, 37);
            this.printResultLabel.TabIndex = 0;
            this.printResultLabel.Text = "     ";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoScrollMargin = new System.Drawing.Size(50, 50);
            this.panel2.Controls.Add(this.printResultLabel);
            this.panel2.Controls.Add(this.resultTextBox);
            this.panel2.Controls.Add(this.printResultLabel2);
            this.panel2.Location = new System.Drawing.Point(23, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 383);
            this.panel2.TabIndex = 1;
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.Location = new System.Drawing.Point(20, 45);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(50000, 50000);
            this.resultTextBox.TabIndex = 2;
            this.resultTextBox.Text = "";
            // 
            // printResultLabel2
            // 
            this.printResultLabel2.Location = new System.Drawing.Point(0, 0);
            this.printResultLabel2.Name = "printResultLabel2";
            this.printResultLabel2.Size = new System.Drawing.Size(100, 23);
            this.printResultLabel2.TabIndex = 3;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.panel1);
            this.Name = "Result";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox[,] cellMatrix;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label printResultLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label legend;
        private System.Windows.Forms.Label printResultLabel2;
        private System.Windows.Forms.RichTextBox resultTextBox;

    }
}