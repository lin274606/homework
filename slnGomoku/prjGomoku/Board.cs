using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjGomoku
{
    public class Board
    {
        private static readonly int OFFSET = 75;
        private static readonly int NODE_RADIUS = 10;
        private static readonly int NODE_DISTANCE = 75;
        private static readonly Point NO_MATCH_NODE = new Point(-1,-1);

        public bool CanBePlaced(int x, int y)
        {
            //找出最近節點(node)
            Point nodeID = FindNearbyNode(x, y);
            //沒有節點回傳false
            if(nodeID == NO_MATCH_NODE) return false;
            //有節點則檢查有無棋子
            return true;
        }
        private Point FindNearbyNode(int x, int y)
        {
            int nodeIdX=FindNearbyNode(x);
            if (nodeIdX==-1)
            {
                return NO_MATCH_NODE;
            }
            int nodeIdY = FindNearbyNode(y);
            if (nodeIdY == -1)
            {
                return NO_MATCH_NODE;
            }
            return new Point(nodeIdX, nodeIdY);
        }
        private int FindNearbyNode(int pos)
        {
            if (pos < OFFSET - NODE_RADIUS) return -1;
            pos -= OFFSET;
            int quotient = pos / NODE_DISTANCE;
            int remainder = pos % NODE_DISTANCE;
            if (remainder <= NODE_RADIUS)
                return quotient;
            else if (remainder >= NODE_DISTANCE - NODE_RADIUS)
                return quotient + 1;
            else
                return -1;
        }
    }
}
