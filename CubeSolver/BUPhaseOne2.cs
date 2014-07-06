﻿using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class BUPhaseOne2 //: ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "BUPhaseOne2"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "Second Section of the Cross."; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {

            var lfr = cube.GC(4, 4);
            var lup = cube.GC(4, 1);

            if (cube.GC(4, 3) == lfr && cube.GC(4, 2) == lup)
            {
                goto endish;
            }
            if (cube.GC(4, 3) == lup && cube.GC(4, 2) == lfr)
            {
                cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.SixoClock);
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.SixoClock);
                goto endish;
            }
            if (cube.GC(5, 4) == lfr && cube.GC(6, 4) == lup)
            {
                cube.TurnLeft(RubiksCore.TurningDirection.SixoClock);
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.SixoClock);
                goto endish;
            }
            if (cube.GC(5, 4) == lup && cube.GC(6, 4) == lfr)
            {
                cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                goto endish;
            }
            if (cube.GC(4, 5) == lfr && cube.GC(4, 6) == lup)
            {
                cube.TurnLeft(RubiksCore.TurningDirection.SixoClock);
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.SixoClock);
                goto endish;
            }
            if (cube.GC(4, 5) == lup && cube.GC(4, 6) == lfr)
            {
                cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                goto endish;
            }
            if (cube.GC(1, 3) == lfr && cube.GC(3, 1) == lup)
            {
                cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                goto endish;
            }
            if (cube.GC(1, 3) == lup && cube.GC(3, 1) == lfr)
            {
                cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                goto endish;
            }
            if (cube.GC(5, 1) == lfr && cube.GC(7, 3) == lup)
            {
                cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                goto endish;
            }
            if (cube.GC(5, 1) == lup && cube.GC(7, 3) == lfr)
            {
                cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                goto endish;
            }
            if (cube.GC(7, 5) == lfr && cube.GC(5, 7) == lup)
            {
                cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                goto endish;
            }
            if (cube.GC(7, 5) == lup && cube.GC(5, 7) == lfr)
            {
                cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                goto endish;
            }
            if (cube.GC(3, 7) == lfr && cube.GC(1, 5) == lup)
            {
                cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                goto endish;
            }
            if (cube.GC(3, 7) == lup && cube.GC(1, 5) == lfr)
            {
                cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                goto endish;
            }
            if (cube.GC(0, 4) == lfr && cube.GC(11, 4) == lup)
            {
                cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                goto endish;
            }
            if (cube.GC(0, 4) == lup && cube.GC(11, 4) == lfr)
            {
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnUp(RubiksCore.TurningDirection.SixoClock);
                goto endish;
            }
            if (cube.GC(4, 0) == lfr && cube.GC(10, 3) == lup)
            {
                cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                goto endish;
            }
            if (cube.GC(4, 0) == lup && cube.GC(10, 3) == lfr)
            {
                cube.TurnUp(RubiksCore.TurningDirection.SixoClock);
                goto endish;
            }
            if (cube.GC(8, 4) == lfr && cube.GC(9, 4) == lup)
            {
                cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                goto endish;
            }
            if (cube.GC(8, 4) == lup && cube.GC(9, 4) == lfr)
            {
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnUp(RubiksCore.TurningDirection.SixoClock);
                goto endish;
            }
            if (cube.GC(4, 8) == lfr && cube.GC(10, 5) == lup)
            {
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                goto endish;
            }
            if (cube.GC(4, 8) == lup && cube.GC(10, 5) == lfr)
            {
                cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                cube.TurnUp(RubiksCore.TurningDirection.SixoClock);
                goto endish;
            }

        endish:
            cube.Run("BUPhaseOne3");
            //cube.Run("YAA");
            //cube.Run("YAB");
        }
    }
}
