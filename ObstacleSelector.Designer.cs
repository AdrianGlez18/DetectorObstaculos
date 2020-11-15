namespace P1_IA
{
    partial class ObstacleSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObstacleSelector));
            this.obstaclesList = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.continuar = new System.Windows.Forms.Button();
            this.fichero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.subtitle = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // obstaclesList
            // 
            this.obstaclesList.Location = new System.Drawing.Point(145, 161);
            this.obstaclesList.Multiline = true;
            this.obstaclesList.Name = "obstaclesList";
            this.obstaclesList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.obstaclesList.Size = new System.Drawing.Size(457, 178);
            this.obstaclesList.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.continuar);
            this.panel1.Controls.Add(this.fichero);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.subtitle);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.obstaclesList);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 1;
            // 
            // continuar
            // 
            this.continuar.Location = new System.Drawing.Point(452, 359);
            this.continuar.Name = "continuar";
            this.continuar.Size = new System.Drawing.Size(150, 33);
            this.continuar.TabIndex = 5;
            this.continuar.Text = "Continuar";
            this.continuar.UseVisualStyleBackColor = true;
            this.continuar.Click += new System.EventHandler(this.continuar_Click);
            // 
            // fichero
            // 
            this.fichero.Location = new System.Drawing.Point(288, 359);
            this.fichero.Name = "fichero";
            this.fichero.Size = new System.Drawing.Size(138, 33);
            this.fichero.TabIndex = 4;
            this.fichero.Text = "Cargar desde fichero";
            this.fichero.UseVisualStyleBackColor = true;
            this.fichero.Click += new System.EventHandler(this.fichero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 60);
            this.label1.TabIndex = 3;
            this.label1.Text = "Obstaculo1_X, Obstaculo1_Y\r\nObstaculo2_X, Obstaculo2_Y\r\nObstaculo3_X, Obstaculo3_" +
    "Y\r\n";
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.Location = new System.Drawing.Point(34, 58);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(503, 26);
            this.subtitle.TabIndex = 2;
            this.subtitle.Text = resources.GetString("subtitle.Text");
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(28, 4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(330, 31);
            this.title.TabIndex = 1;
            this.title.Text = "Selección de obstáculos";
            // 
            // ObstacleSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ObstacleSelector";
            this.Text = "ObstacleSelector";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox obstaclesList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button continuar;
        private System.Windows.Forms.Button fichero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label subtitle;
    }
}