using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace P1_IA
{
    public class Simulator
    {
        //Declaración de variables necesarias para la toma de datos del programa
        private int heightInCells = 2, widthInCells = 2, initialX = 0, initialY = 0, finalX = 0, finalY = 0, numberOfObstacles = 0;
        private bool isRandom = true, isManhattan;
        private String obs;
        private int[,] _table;
        private int[,] _visited; 

        public Simulator()
        {

        }
        public void initialize(int _heightInCells = 2, int _widthInCells = 2, int _initialX = 0, int _initialY = 0, int _finalX = 0, int _finalY = 0, int _numberOfObstacles = 0, bool _isRandom = true, String _obs = "", bool heur = false)
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
            isManhattan = heur;
            _table = new int[widthInCells +3, heightInCells +3];
            _visited = new int[widthInCells +3, heightInCells +3];
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
            int tmperrcode = Ax2();
            int k = 0;
            String finalString = "";
            for (int i = 0; i < heightInCells; i++)
            {
                for (int j = 0; j < widthInCells; j++)
                {
                    switch (_table[i, j])
                    {
                        case 0: finalString += "▢"; break;
                        case 1: finalString += "▩"; break;
                        case 2: finalString += "⊕"; break;
                        case 3: finalString += "✹"; break;
                        case 4: finalString += "▣"; break;
                        case 5: finalString += "▢"; break;
                        case 6: finalString += "▢"; break;
                        default: break;
                    }
                }
                finalString += "\n";
            }
            return finalString;
        }

        public int Ax2()
        {
            /////////////////// UTILIZADOS UNICAMENTE PARA LA EVALUACION EXPERIMENTAL/////////////
            Stopwatch timeMeasure = new Stopwatch();
            timeMeasure.Start();
            int nodosExpandidos = 0, longitudMinima = 0;
            //////////////////////////////////////////////////////////////////////////////////////
            NodeA head = new NodeA(initialX, initialY, 0, null, 0.0);
            int posX = initialX, posY = initialY, nodeIndex = 0, deLoop = 0;
            double[] heuristica = new double[4];
            double min = 9999999999.9, currentDistance = 1.0;
            for (int i = 0; i < 4; i++)
            {
                heuristica[i] = 9999999999.9;
            }
            List<NodeA> nodeList = new List<NodeA>();
            List<NodeA> fullList = new List<NodeA>();
            NodeA tmpNode = head;
            NodeA tmpParent = head;
            while (true)
            {
                posX = tmpNode.getX();
                posY = tmpNode.getY();
                _visited[posX, posY]++;
                if (posY > 0)
                {
                    if (_table[posX, posY - 1] != 1 && _table[posX, posY - 1] != 6)
                    {
                        if(posX != tmpParent.getX() || posY -1 != tmpParent.getY())
                        {
                            nodeList.Add(new NodeA(posX, posY - 1, nodeIndex, tmpNode, currentDistance));
                            heuristica[nodeIndex] = h(posX, posY - 1) + nodeList.ElementAt(nodeIndex).current;
                            nodeIndex++;
                            nodosExpandidos++;
                        }
                        else { deLoop = 1; }
                    }
                }

                if (posX < widthInCells)
                {
                    if (_table[posX + 1, posY] != 1 && _table[posX + 1, posY] != 6)
                    {
                        if (posX + 1 != tmpParent.getX() || posY != tmpParent.getY())
                        {
                            nodeList.Add(new NodeA(posX + 1, posY, nodeIndex, tmpNode, currentDistance));
                            heuristica[nodeIndex] = h(posX + 1, posY) + nodeList.ElementAt(nodeIndex).current;
                            nodeIndex++;
                            nodosExpandidos++;
                        }
                        else { deLoop = 2; }
                    }
                }
                if (posY < heightInCells)
                {
                    if (_table[posX, posY + 1] != 1 && _table[posX, posY + 1] != 6)
                    {
                        if (posX != tmpParent.getX() || posY + 1 != tmpParent.getY())
                        {
                            nodeList.Add(new NodeA(posX, posY + 1, nodeIndex, tmpNode, currentDistance));
                            heuristica[nodeIndex] = h(posX, posY + 1) + nodeList.ElementAt(nodeIndex).current;
                            nodeIndex++;
                            nodosExpandidos++;
                        }
                        else { deLoop = 3; }
                    }
                }
                if (posX > 0)
                {
                    if (_table[posX - 1, posY] != 1 && _table[posX - 1, posY] != 6)
                    {
                        if (posX - 1 != tmpParent.getX() || posY != tmpParent.getY())
                        {
                            nodeList.Add(new NodeA(posX - 1, posY, nodeIndex, tmpNode, currentDistance));
                            heuristica[nodeIndex] = h(posX - 1, posY) + nodeList.ElementAt(nodeIndex).current;
                            nodeIndex++;
                            nodosExpandidos++;
                        }
                        else { deLoop = 4; }
                    }
                }
                currentDistance += 1;
                if (nodeIndex == 0)
                {
                    if (deLoop != 0)
                    {
                        tmpNode = tmpNode.parent;
                        _table[tmpNode.getX(), tmpNode.getY()] = 6;
                    }
                    else { return 1; }
                }

                deLoop = 0;
                for (int i = 0; i < nodeIndex; i++)
                {
                    if (min > heuristica[i])
                    {
                        min = heuristica[i];
                        tmpParent = tmpNode;
                        tmpNode = nodeList.ElementAt(i);
                    }
                }
                nodeIndex = 0;
                nodeList.Clear();

                if (_table[tmpNode.getX(), tmpNode.getY()] == 3)
                {
                    tmpNode = tmpNode.parent;
                    while (tmpNode != head)
                    {
                        _table[tmpNode.getX(), tmpNode.getY()] = 4;
                        tmpNode = tmpNode.parent;
                    }
                    Console.WriteLine("Resuelto");
                    ///////////////////////EXPERIMENTAL//////////////////////////////////////
                    timeMeasure.Stop();
                    Console.WriteLine($"Tiempo: {timeMeasure.Elapsed.TotalMilliseconds} ms");
                    Console.WriteLine("Se han expandido un total de {0} nodos.", nodosExpandidos);
                    Console.WriteLine("El camino mínimo tiene {0} pasos.", longitudMinima);
                    /////////////////////////////////////////////////////////////////////////
                    return 0;
                }
                _table[tmpNode.getX(), tmpNode.getY()] = 5;
                longitudMinima++;
                min = 99999999.0;
            }

        }

#region Heurísticas y resultados parciales
        
        public double h (double x, double y)
        {
            if (isManhattan) return Manhattan(x, y);
            return Euclides(x, y);
        }

        private double Manhattan(double x, double y)
        {
            return Math.Abs(x - finalX) + Math.Abs(y - finalY);
        }

        private double Euclides(double x, double y)
        {
            return Math.Sqrt(Math.Pow((x - finalX), 2) + Math.Pow((y - finalY), 2));
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
                    randX = rnd.Next(widthInCells);
                    randY = rnd.Next(heightInCells);
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
    #endregion
}
