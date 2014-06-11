using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class YH : ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "YH"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "Nine Rotations"; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {
            cube.TurnDown(RubiksCore.TurningDirection.SixoClock);
            cube.TurnRight(RubiksCore.TurningDirection.SixoClock);
            cube.TurnLeft(RubiksCore.TurningDirection.SixoClock);
            cube.TurnUp(RubiksCore.TurningDirection.SixoClock);
            cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnUp(RubiksCore.TurningDirection.SixoClock);
            cube.TurnLeft(RubiksCore.TurningDirection.SixoClock);
            cube.TurnRight(RubiksCore.TurningDirection.SixoClock);
            cube.TurnDown(RubiksCore.TurningDirection.SixoClock);
        
        }
    }
}
