using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class ZPhasePTwo1Check : ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "ZPhasePTwo1Check"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "Chek if PhaseTwo1 is complete"; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {
            if (cube.GC(5, 5) == cube.GC(4, 4) && cube.GC(6, 5) == cube.GC(7, 4))
            {
                if (cube.GC(5, 3) == cube.GC(4, 4) && cube.GC(5, 2) == cube.GC(4, 1)) 
                {
                    if (cube.GC(3, 3) == cube.GC(4, 4) && cube.GC(3, 2) == cube.GC(4, 1))
                    {
                        if (cube.GC(3, 5) == cube.GC(4, 4) && cube.GC(3, 6) == cube.GC(4, 7))
                        {
                            cube.Run("ZPhasePTwo2");
                        }
                    }
                }
            }
        }
    }
}
