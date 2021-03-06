﻿using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class YGBA //: ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "YGBA"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "Twelve Rotations"; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {
            cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
            cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
            cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnRight(RubiksCore.TurningDirection.SixoClock);
            cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
            cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
            cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
            cube.TurnRight(RubiksCore.TurningDirection.SixoClock);

        }
    }
}
