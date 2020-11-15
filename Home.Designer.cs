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
            this.components = new System.ComponentModel.Container();
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
            this.Xini = new System.Windows.Forms.NumericUpDown();
            this.continueButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.RandomObs = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numberOfObs = new System.Windows.Forms.NumericUpDown();
            this.Xfin = new System.Windows.Forms.NumericUpDown();
            this.Yfin = new System.Windows.Forms.NumericUpDown();
            this.Yini = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsHeigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfObs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xfin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yfin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
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
            // 
            // cellsHeigh
            // 
            resources.ApplyResources(this.cellsHeigh, "cellsHeigh");
            this.cellsHeigh.Maximum = new decimal(new int[] {
            100000,
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
            this.cellsHeigh.ValueChanged += new System.EventHandler(this.cellsHeigh_ValueChanged);
            // 
            // cellsWidth
            // 
            resources.ApplyResources(this.cellsWidth, "cellsWidth");
            this.cellsWidth.Maximum = new decimal(new int[] {
            100000,
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
            this.cellsWidth.ValueChanged += new System.EventHandler(this.cellsWidth_ValueChanged);
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
            // Xini
            // 
            resources.ApplyResources(this.Xini, "Xini");
            this.Xini.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Xini.Name = "Xini";
            this.Xini.ValueChanged += new System.EventHandler(this.Xini_ValueChanged);
            // 
            // continueButton
            // 
            resources.ApplyResources(this.continueButton, "continueButton");
            this.continueButton.Name = "continueButton";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // Exit
            // 
            resources.ApplyResources(this.Exit, "Exit");
            this.Exit.Name = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // RandomObs
            // 
            resources.ApplyResources(this.RandomObs, "RandomObs");
            this.RandomObs.Name = "RandomObs";
            this.RandomObs.UseVisualStyleBackColor = true;
            this.RandomObs.CheckedChanged += new System.EventHandler(this.RandomObs_CheckedChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // numberOfObs
            // 
            resources.ApplyResources(this.numberOfObs, "numberOfObs");
            this.numberOfObs.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numberOfObs.Name = "numberOfObs";
            this.numberOfObs.ValueChanged += new System.EventHandler(this.numberOfObs_ValueChanged);
            // 
            // Xfin
            // 
            resources.ApplyResources(this.Xfin, "Xfin");
            this.Xfin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Xfin.Name = "Xfin";
            this.Xfin.ValueChanged += new System.EventHandler(this.Xfin_ValueChanged);
            // 
            // Yfin
            // 
            resources.ApplyResources(this.Yfin, "Yfin");
            this.Yfin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Yfin.Name = "Yfin";
            this.Yfin.ValueChanged += new System.EventHandler(this.Yfin_ValueChanged);
            // 
            // Yini
            // 
            resources.ApplyResources(this.Yini, "Yini");
            this.Yini.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Yini.Name = "Yini";
            this.Yini.ValueChanged += new System.EventHandler(this.Yini_ValueChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Yini);
            this.Controls.Add(this.Yfin);
            this.Controls.Add(this.Xfin);
            this.Controls.Add(this.numberOfObs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RandomObs);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.Xini);
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
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsHeigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfObs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xfin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yfin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown Xini;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.CheckBox RandomObs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numberOfObs;
        private System.Windows.Forms.NumericUpDown Xfin;
        private System.Windows.Forms.NumericUpDown Yfin;
        private System.Windows.Forms.NumericUpDown Yini;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

