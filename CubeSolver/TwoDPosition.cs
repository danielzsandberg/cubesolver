using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public struct TwoDPosition
    {
        int _x;
        int _y;

        public int X
        {
            get
            {
                return _x;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
        }

        public TwoDPosition(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}
