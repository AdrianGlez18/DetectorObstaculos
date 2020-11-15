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
        private Simulator _simulator = new Simulator();
        private int fullSize = 0;

        public Result(int _heightInCells = 2, int _widthInCells = 2, int _initialX = 0, int _initialY = 0, int _finalX = 0, int _finalY = 0, int _numberOfObstacles = 0, bool _isRandom = true, String _obs = "", bool heur = false)
        {
            /*heightInCells = _heightInCells;
            widthInCells = _widthInCells;
            initialX = _initialX;
            initialY = _initialY;
            finalX = _finalX;
            finalY = _finalY;
            numberOfObstacles = _numberOfObstacles;
            isRandom = _isRandom;*/
            fullSize = _heightInCells * _widthInCells;
            _simulator.initialize(_heightInCells, _widthInCells, _initialX, _initialY, _finalX, _finalY, _numberOfObstacles,  _isRandom, _obs, heur);
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            //Al cargar la ventana de resultados, se llama a una función que retorna una string. Este método genera la interfaz
            //gráfica del recorrido óptimo del vehículo de forma dinámica en base a los parámetros ingresados por el usuario.
            /*for (int i = 0; i < heightInCells; i++)
            {
                for (int j = 0; j < widthInCells; j++)
                {
                    _table[i, j] = 0;
                }
            }*/
            /*for (int i = 0; i < numberOfObstacles; i++)
            {
                _obstacles[numberOfObstacles, 0] = 0;
                _obstacles[numberOfObstacles, 1] = 0;
            }*/
            //int errorChecker = generateTable();
           /* this.printResultLabel.Text = "Generando...";
            String tmpsrt = _simulator.startProcessing();
            this.printResultLabel.Text = tmpsrt;*/
            this.resultTextBox.Text = "Generando...";
            String tmpsrt = _simulator.startProcessing();
            this.resultTextBox.Text = tmpsrt; 
        }

        /*private String generateResult()
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
                    // ▼►▶◄◀▲https://en.wikipedia.org/wiki/Geometric_Shapes 
                }
                finalString += "\n";
            }
            return finalString;
        }

        private int generateTable()
        {
            int errCode = 0;
            _table[initialX, initialY] = 2;
            _table[finalX, finalY] = 3;
            errCode = processObstacles();
            /*_table[0, 1] = 5;
            _table[0, 2] = 6;
            _table[4, 0] = 1;
            _table[2, 2] = 1;/////
            return errCode;
        }

        private int processObstacles()
        {
            Random rnd = new Random();
            int randX, randY;
            if (isRandom)
            {
                for (int i = 0; i < numberOfObstacles; i++)
                {
                    randX = rnd.Next(heightInCells);
                    randY = rnd.Next(widthInCells);
                    if (_table[randX, randY] == 0)
                    {
                        _table[randX, randY] = 1;
                    }
                    else i--;
                }
            }
            return 0;
        }
*/
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
