using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class TotalMove : ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "Total Move Front Right"; }
        }

        public string Author
        {
            get { return "Daniel Sandberg"; }
        }

        public string Description
        {
            get { return "A total move"; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {
            cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock,2);
        }
    }
}
