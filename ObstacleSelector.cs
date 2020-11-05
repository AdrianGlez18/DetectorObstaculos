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
    public partial class ObstacleSelector : Form
    {
        private int numberOfObstacles = 1;
        public String obs { get; set; }
        public string Value { get { return obs; } }
        //int[,] obs = new int[numberOfObstacles, 2];
        public ObstacleSelector(int _numberOfObstacles = 0)
        {
            //int[,] obs = new int[_numberOfObstacles, 2];
            numberOfObstacles = _numberOfObstacles;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int[,] obs = new int[numberOfObstacles, 2];
            obs = obstaclesList.Text;
            Console.WriteLine(obs);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
