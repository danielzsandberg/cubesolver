﻿using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class BUPhaseOne4 //: ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "BUPhaseOne4"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "Fourth Section of the Cross."; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {

            var lfr = cube.GC(4, 4);
            var ldo = cube.GC(4, 7);

            if (cube.GC(4, 5) == lfr && cube.GC(4, 6) == ldo)
            {
                goto endish;
            }
            if (cube.GC(4, 5) == ldo && cube.GC(4, 6) == lfr)
            {
                cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                goto endish;
            }
            if (cube.GC(1, 3) == lfr && cube.GC(3, 1) == ldo)
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                goto endish;
            }
            if (cube.GC(1, 3) == ldo && cube.GC(3, 1) == lfr)
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                goto endish;
            }
            if (cube.GC(5, 1) == lfr && cube.GC(7, 3) == ldo)
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                goto endish;
            }
            if (cube.GC(5, 1) == ldo && cube.GC(7, 3) == lfr)
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                goto endish;
            }
            if (cube.GC(7, 5) == lfr && cube.GC(5, 7) == ldo)
            {
                cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                goto endish;
            }
            if (cube.GC(7, 5) == ldo && cube.GC(5, 7) == lfr)
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                goto endish;
            }
            if (cube.GC(3, 7) == lfr && cube.GC(1, 5) == ldo)
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                goto endish;
            }
            if (cube.GC(3, 7) == ldo && cube.GC(1, 5) == lfr)
            {
                cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                goto endish;
            }
            if (cube.GC(0, 4) == lfr && cube.GC(11, 4) == ldo)
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                goto endish;
            }
            if (cube.GC(0, 4) == ldo && cube.GC(11, 4) == lfr)
            {
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnDown(RubiksCore.TurningDirection.SixoClock);
                goto endish;
            }
            if (cube.GC(4, 0) == lfr && cube.GC(10, 3) == ldo)
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                goto endish;
            }
            if (cube.GC(4, 0) == ldo && cube.GC(10, 3) == lfr)
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.TurnUp(RubiksCore.TurningDirection.SixoClock);
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                goto endish;
            }
            if (cube.GC(8, 4) == lfr && cube.GC(9, 4) == ldo)
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                goto endish;
            }
            if (cube.GC(8, 4) == ldo && cube.GC(9, 4) == lfr)
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.TurnRight(RubiksCore.TurningDirection.SixoClock);
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                goto endish;
            }
            if (cube.GC(4, 8) == lfr && cube.GC(10, 5) == ldo)
            {
                cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                goto endish;
            }
            if (cube.GC(4, 8) == ldo && cube.GC(10, 5) == lfr)
            {
                cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                goto endish;
            }

        endish:
            cube.Run("BUPhasePTwo1");
            //            cube.Run("YAA");
            //            cube.Run("YAB");

        }
    }
}
