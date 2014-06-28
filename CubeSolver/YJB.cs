using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class YJB : ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "YJB"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "Ten Rotations"; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {
            cube.TurnUp(RubiksCore.TurningDirection.SixoClock);
            cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
            cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
            cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnUp(RubiksCore.TurningDirection.SixoClock);
            cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
            cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
            cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
            cube.TurnLeft(RubiksCore.TurningDirection.SixoClock);

        }
    }
}
