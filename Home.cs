using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_IA
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            continueButton.Enabled = false;
            /*
             * continueManager();
             */

        }

        private void continueManager()
        {
            errorProvider1.SetError(cellsHeigh, "Tmp");
        }

        #region Inicializacion y cambios en la configuración de parámetros

        //Declaración de variables necesarias para la toma de datos del programa
        private int heightInCells = 2, widthInCells = 2, initialX = 0, initialY = 0, finalX = 0, finalY = 0, numberOfObstacles = 0;
        private bool isRandom = false;

        //Getters y Setters
        public void setHeightInCells(int newValue)
        {
            heightInCells = newValue;
        }
        public void setWidthInCells(int newValue)
        {
            widthInCells = newValue;
        }
        public void setInitialX(int newValue)
        {
            initialX = newValue;
        }
        public void setInitialY(int newValue)
        {
            initialY = newValue;
        }
        public void setFinalX(int newValue)
        {
            finalX = newValue;
        }
        public void setFinalY(int newValue)
        {
            finalY = newValue;
        }
        public void setNumberOfObstacles(int newValue)
        {
            numberOfObstacles = newValue;
        }
        public void setIsRandom(bool newValue)
        {
            isRandom = newValue;
        }

        //Modificadores de valores

        private void cellsHeigh_ValueChanged(object sender, EventArgs e)
        {
            setHeightInCells((int)cellsHeigh.Value);
            Console.WriteLine("CellsHeigh cambió a " + heightInCells);
        }
        private void cellsWidth_ValueChanged(object sender, EventArgs e)
        {
            setWidthInCells((int)cellsWidth.Value);
            Console.WriteLine("CellsWidth cambió a " + widthInCells);
        }
        private void Xini_ValueChanged(object sender, EventArgs e)
        {
            setInitialX((int)Xini.Value);
        }
        private void Yini_ValueChanged(object sender, EventArgs e)
        {
            setInitialY((int)Yini.Value);
        }
        private void Xfin_ValueChanged(object sender, EventArgs e)
        {
            setFinalX((int)Xfin.Value);
        }
        private void Yfin_ValueChanged(object sender, EventArgs e)
        {
            setFinalY((int)Yfin.Value);
        }
        private void numberOfObs_ValueChanged(object sender, EventArgs e)
        {
            setNumberOfObstacles((int)numberOfObs.Value);
        }


        #endregion

        #region Funcionamiento de botones

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
