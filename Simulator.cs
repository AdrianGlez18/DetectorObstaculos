using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_IA
{
    public class Simulator
    {
        //Declaración de variables necesarias para la toma de datos del programa
        private int heightInCells = 2, widthInCells = 2, initialX = 0, initialY = 0, finalX = 0, finalY = 0, numberOfObstacles = 0;
        private bool isRandom = true;
        private String obs;
        private int[,] _table = new int[500, 500];
        //private int[,] _obstacles = new int[100, 2];

        public Simulator()
        {

        }
        
        public void initialize(int _heightInCells = 2, int _widthInCells = 2, int _initialX = 0, int _initialY = 0, int _finalX = 0, int _finalY = 0, int _numberOfObstacles = 0, bool _isRandom = true, String _obs = "")
        {
            heightInCells = _heightInCells;
            widthInCells = _widthInCells;
            initialX = _initialX;
            initialY = _initialY;
            finalX = _finalX;
            finalY = _finalY;
            numberOfObstacles = _numberOfObstacles;
            isRandom = _isRandom;
            obs = _obs;
        }

        public string startProcessing()
        {
            String result = "";
            int errorChecker = generateTable();
            result = generateResult();
            return result;
        }

        private String generateResult()
        {
            String finalString = "";
            for (int i = 0; i < heightInCells; i++)  //Se deja una casilla libre que no se imprime ni evalua para evitar problemas en las comparaciones
            {
                for (int j = 0; j < widthInCells; j++)
                {
                    switch (_table[i, j])
                    {
                        case 0: finalString += "▢"; break;
                        case 1: finalString += "▩"; break;
                        case 2: finalString += "▤"; break;
                        case 3: finalString += "▥"; break;
                        case 4: finalString += "▲"; break;
                        case 5: finalString += "▶"; break;
                        case 6: finalString += "▼"; break;
                        case 7: finalString += "◀"; break;
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
            int errCode = 0;
            _table[initialX, initialY] = 2;
            _table[finalX, finalY] = 3;
            errCode = processObstacles();
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
            else
            {
                obstacleStringToTable();
            }
            return 0;
        }

        private int obstacleStringToTable()
        {
            String[] obsPairs = obs.Split(';');
            String[] tmpObstacleSelector;
            int tmpx, tmpy;
            for (int i = 0; i < numberOfObstacles; i++)
            {
                tmpObstacleSelector = obsPairs[i].Split(',');
                tmpx = int.Parse(tmpObstacleSelector[0]);
                tmpy = int.Parse(tmpObstacleSelector[1]);
                _table[tmpx, tmpy] = 1;
            }
            return 0;
        }
    }
}
