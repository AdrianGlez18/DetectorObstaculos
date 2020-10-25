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
    public partial class Result : Form
    {
        //Declaración de variables necesarias para la toma de datos del programa
        private int heightInCells = 2, widthInCells = 2, initialX = 0, initialY = 0, finalX = 0, finalY = 0, numberOfObstacles = 0;
        private bool isRandom = false;

        public Result(int _heightInCells = 2, int _widthInCells = 2, int _initialX = 0, int _initialY = 0, int _finalX = 0, int _finalY = 0, int _numberOfObstacles = 0)
        {
            heightInCells = _heightInCells;
            widthInCells = _widthInCells;
            initialX = _initialX;
            initialY = _initialY;
            finalX = _finalX;
            finalY = _finalY;
            numberOfObstacles = _numberOfObstacles;
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            //Al cargar la ventana de resultados, se llama a una función que retorna una string. Este método genera la interfaz
            //gráfica del recorrido óptimo del vehículo de forma dinámica en base a los parámetros ingresados por el usuario.
            this.printResultLabel.Text = generateResult();
        }

        private String generateResult()
        {
            String finalString = "";
            for(int i = 0; i < heightInCells; i++)
            {
                for(int j = 0; j < widthInCells; j++)
                {
                    if (i == initialY && j == initialX) finalString += "▤";
                    else if (i == finalY && j == finalX) finalString += "▥";
                    else finalString += "▢";
                    // ▼►▶◄◀▲https://en.wikipedia.org/wiki/Geometric_Shapes
                }
                finalString += "\n";
            }
            return finalString;
        }

    }
}
