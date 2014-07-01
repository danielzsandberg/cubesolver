using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class ZZAutomatic : ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "ZZAutomatic"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "Two Codes"; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {
            cube.Run("ZPhaseOne1");
            cube.Run("ZPhasePTwo2");

            if (cube.GC(3, 3) == cube.GC(4, 4) && cube.GC(3, 4) == cube.GC(4, 4) && cube.GC(3, 5) == cube.GC(4, 4) && cube.GC(4, 3) == cube.GC(4, 4))
            { goto endish; }
            else
            { cube.Run("ZZAutomatic2");}
            if (cube.GC(5, 3) == cube.GC(4, 4) && cube.GC(5, 4) == cube.GC(4, 4) && cube.GC(5, 5) == cube.GC(4, 4) && cube.GC(4, 5) == cube.GC(4, 4))
            { goto endish; }
            else
            { cube.Run("ZZAutomatic2");}

        endish:
            cube.Run("YAA");
        cube.Run("YAB");       
        }

    }
}
