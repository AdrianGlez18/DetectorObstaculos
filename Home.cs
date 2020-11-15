using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
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
            
            /*using (Result tmp = new Result())
                tmp.ShowDialog();*/

        }

        #region Inicializacion y cambios en la configuración de parámetros

        //Declaración de variables necesarias para la toma de datos del programa
        private int heightInCells = 2, widthInCells = 2, initialX = 0, initialY = 0, finalX = 0, finalY = 0, numberOfObstacles = 0;
        private bool isRandom = false;
        private string _obs = "Home.cs";
        private bool isManh = false;

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
            continueManager();
            Console.WriteLine("CellsHeigh cambió a " + heightInCells);
        }
        private void cellsWidth_ValueChanged(object sender, EventArgs e)
        {
            setWidthInCells((int)cellsWidth.Value);
            continueManager();
            Console.WriteLine("CellsWidth cambió a " + widthInCells);
        }

        private void Xini_ValueChanged(object sender, EventArgs e)
        {
            setInitialX((int)Xini.Value);
            continueManager();
        }
        private void Yini_ValueChanged(object sender, EventArgs e)
        {
            setInitialY((int)Yini.Value);
            continueManager();
        }

        private void RandomObs_CheckedChanged(object sender, EventArgs e)
        {
            isRandom = !isRandom;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isManh = !isManh;
        }

        private void Xfin_ValueChanged(object sender, EventArgs e)
        {
            setFinalX((int)Xfin.Value);
            continueManager();
        }
        private void Yfin_ValueChanged(object sender, EventArgs e)
        {
            setFinalY((int)Yfin.Value);
            continueManager();
        }
        private void numberOfObs_ValueChanged(object sender, EventArgs e)
        {
            setNumberOfObstacles((int)numberOfObs.Value);
            continueManager();
        }


        #endregion

        #region Funcionamiento de botones

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if(!isRandom && numberOfObstacles != 0)
            {
                ObstacleSelector tmpo = new ObstacleSelector(numberOfObstacles);
                    //tmpo.ShowDialog();
                //obs = tmpo.Value;
                if (tmpo.ShowDialog() == DialogResult.OK)
                {
                    _obs = tmpo.obs; //lee la propiedad
                    //Console.WriteLine("Sale correctamente");
                    //Console.WriteLine(_obs);
                }
            }
            using (Result tmp = new Result(heightInCells, widthInCells, initialX, initialY, finalX, finalY, numberOfObstacles, isRandom, _obs, isManh))
                tmp.ShowDialog();          
        }


        #endregion

        #region Control de errores

        private void continueManager()
        {
            continueButton.Enabled = true;
            if (initialX >= widthInCells)
            {
                errorProvider1.SetError(Xini, "La posición inicial en el eje X no puede ser mayor al ancho de la tabla");
                continueButton.Enabled = false;
            }
            if(initialY >= heightInCells)
            {
                errorProvider1.SetError(Yini, "La posición inicial en el eje y no puede ser mayor al alto de la tabla");
                continueButton.Enabled = false;
            }
            if (finalX >= heightInCells)
            {
                errorProvider1.SetError(Xfin, "La posición final en el eje x no puede ser mayor al ancho de la tabla");
                continueButton.Enabled = false;
            }
            if (finalY >= heightInCells)
            {
                errorProvider1.SetError(Yfin, "La posición final en el eje y no puede ser mayor al alto de la tabla");
                continueButton.Enabled = false;
            }
            if(numberOfObstacles >= heightInCells * widthInCells -2)
            {
                errorProvider1.SetError(numberOfObs, "El número de obstáculos no puede ser mayor al número total de celdas libres disponibles");
                continueButton.Enabled = false;
            }
            
 
        }

        #endregion

    }
}
