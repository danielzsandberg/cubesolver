﻿using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class W10B //: ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "W10B"; }
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
            cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
            cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
            cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
            cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
            cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
            cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);

        }
    }
}
