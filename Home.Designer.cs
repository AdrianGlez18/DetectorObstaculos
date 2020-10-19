namespace P1_IA
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cellsHeigh = new System.Windows.Forms.NumericUpDown();
            this.cellsWidth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.Continue = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.RandomObs = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numberOfObstacles = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsHeigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfObstacles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::P1_IA.Properties.Resources._29454_3_tesla_transparent_picture;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cellsHeigh
            // 
            resources.ApplyResources(this.cellsHeigh, "cellsHeigh");
            this.cellsHeigh.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.cellsHeigh.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.cellsHeigh.Name = "cellsHeigh";
            this.cellsHeigh.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // cellsWidth
            // 
            resources.ApplyResources(this.cellsWidth, "cellsWidth");
            this.cellsWidth.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.cellsWidth.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.cellsWidth.Name = "cellsWidth";
            this.cellsWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Name = "numericUpDown1";
            // 
            // numericUpDown2
            // 
            resources.ApplyResources(this.numericUpDown2, "numericUpDown2");
            this.numericUpDown2.Name = "numericUpDown2";
            // 
            // Continue
            // 
            resources.ApplyResources(this.Continue, "Continue");
            this.Continue.Name = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            resources.ApplyResources(this.Exit, "Exit");
            this.Exit.Name = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // RandomObs
            // 
            resources.ApplyResources(this.RandomObs, "RandomObs");
            this.RandomObs.Name = "RandomObs";
            this.RandomObs.UseVisualStyleBackColor = true;
            this.RandomObs.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // numberOfObstacles
            // 
            resources.ApplyResources(this.numberOfObstacles, "numberOfObstacles");
            this.numberOfObstacles.Name = "numberOfObstacles";
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.numberOfObstacles);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RandomObs);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cellsWidth);
            this.Controls.Add(this.cellsHeigh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsHeigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfObstacles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown cellsHeigh;
        private System.Windows.Forms.NumericUpDown cellsWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.CheckBox RandomObs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numberOfObstacles;
    }
}

