using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class W40C //: ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "W40C"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "Eighteen Rotations"; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {
            cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
            cube.TurnFront(RubiksCore.TurningDirection.SixoClock);

            cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
            cube.TurnRight(RubiksCore.TurningDirection.SixoClock);

            cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
            cube.TurnDown(RubiksCore.TurningDirection.SixoClock);

            cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
            cube.TurnLeft(RubiksCore.TurningDirection.SixoClock);

            cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
            cube.TurnUp(RubiksCore.TurningDirection.SixoClock);
            
            cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
            cube.TurnBack(RubiksCore.TurningDirection.SixoClock);

        }
    }
}
