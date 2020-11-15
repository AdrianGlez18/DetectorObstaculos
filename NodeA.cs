using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_IA
{
    class NodeA
    {
        public NodeA parent;
        private int thisX = 0, thisY = 0;
        public int inx;
        public double current = 0.0, value;
        public bool isMnt = true;

         public NodeA(int _thisX = 0, int _thisY = 0, int index = 0, NodeA _parent = null, double _current = 0.0, double _value = 99999999.0)
         {
             thisX = _thisX;
             thisY = _thisY;
             parent = _parent;
             value = _value;
            current = _current;
             inx = index;
         }

         public int getX()
         {
             return thisX;
         }

         public int getY()
         {
             return thisY;
         }
     }
}
