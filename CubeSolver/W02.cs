using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class W02 : ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "W02"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "Eleven Rotations"; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {
            cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
            cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
            cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
            cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
            cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
            cube.TurnRight(RubiksCore.TurningDirection.SixoClock);
            cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
            cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
            
        }
    }
}
