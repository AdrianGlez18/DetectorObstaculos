using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private int[,] _table = new int [500, 500];
        //private List<List<int>> _table;

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
            for (int i = 0; i < heightInCells; i++)
            {
                for (int j = 0; j < widthInCells + 2; j++)
                {
                    _table[i, j] = 0;
                }
            }
            int errorChecker = generateTable();
            //this.printResultLabel.ForeColor = Color.White;
            this.printResultLabel.Text = generateResult();
        }

        private String generateResult()
        {
            String finalString = "";
            for(int i = 0; i < heightInCells; i++)  //Se deja una casilla libre que no se imprime ni evalua para evitar problemas en las comparaciones
            {
                for(int j = 0; j < widthInCells; j++)
                {
                    switch(_table[i,j])
                    {
                        case 0: finalString += "▢";         break;
                        case 1: finalString += "▩";         break;
                        case 2: finalString += "▤";         break;
                        case 3: finalString += "▥";         break;
                        case 4: finalString += "▲";          break;
                        case 5: finalString += "▶";         break;
                        case 6: finalString += "▼";         break;
                        case 7: finalString += "◀";         break;
                        default: break;
                    }
                    /*if (i == initialY && j == initialX) finalString += "▤";
                    else if (i == finalY && j == finalX) finalString += "▥";
                    else finalString += "▢";
                    // ▼►▶◄◀▲https://en.wikipedia.org/wiki/Geometric_Shapes */
                }
                finalString += "\n";
            }
            return finalString;
        }

        private int generateTable()
        {

            _table[initialX, initialY] = 2;
            _table[finalX, finalY] = 3;
            _table[0, 1] = 5;
            _table[0, 2] = 6;
            _table[4, 0] = 1;
            _table[2, 2] = 1;
            return 0;
        }

    }

    //Enum utilizado para generar una simplificacion del procesamiento de la tabla, pudiendo tratar
    //el tablero como una matriz de numeros enteros.
    public enum Cell
    {
        free,           //[0]
        obstacle,       //[1]
        initial,        //[2]
        final,          //[3]
        up,             //[4]
        right,          //[5]
        down,           //[6]
        left            //[7]
    }
}
