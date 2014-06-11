﻿using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class W22B : ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "W22B"; }
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
            cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
            cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
            cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
            cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
            cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
            cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
            cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);

        }
    }
}
