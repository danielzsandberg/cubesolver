using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class ZZZZTemporary : ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "ZZZZTemporary"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "Details"; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {
            if (cube.GC(4, 6) == cube.GC(4, 1))
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);
                cube.Run("YAA");
            }
        }
    }
}
