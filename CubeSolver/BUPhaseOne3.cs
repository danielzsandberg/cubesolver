using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class BUPhaseOne3 //: ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "BUPhaseOne3"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "Third Section of the Cross."; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {

            var lfr = cube.GC(4, 4);
            var lri = cube.GC(7, 4);

            if (cube.GC(5, 4) == lfr && cube.GC(6, 4) == lri)
            {
                goto endish;
            }
            if (cube.GC(5, 4) == lri && cube.GC(6, 4) == lfr)
            {
                cube.TurnLeft(RubiksCore.TurningDirection.SixoClock);
                cube.TurnUp(RubiksCore.TurningDirection.SixoClock);
                cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.TurnUp(RubiksCore.TurningDirection.SixoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.SixoClock);
                goto endish;
            }
            if (cube.GC(4, 5) == lfr && cube.GC(4, 6) == lri)
            {
                cube.TurnLeft(RubiksCore.TurningDirection.SixoClock);
                cube.TurnUp(RubiksCore.TurningDirection.SixoClock);
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.TurnUp(RubiksCore.TurningDirection.SixoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.SixoClock);
                goto endish;
            }
            if (cube.GC(4, 5) == lri && cube.GC(4, 6) == lfr)
            {
                cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                goto endish;
            }
            if (cube.GC(1, 3) == lfr && cube.GC(3, 1) == lri)
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                goto endish;
            }
            if (cube.GC(1, 3) == lri && cube.GC(3, 1) == lfr)
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                goto endish;
            }
            if (cube.GC(5, 1) == lfr && cube.GC(7, 3) == lri)
            {
                cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                goto endish;
            }
            if (cube.GC(5, 1) == lri && cube.GC(7, 3) == lfr)
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                goto endish;
            }
            if (cube.GC(7, 5) == lfr && cube.GC(5, 7) == lri)
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                goto endish;
            }
            if (cube.GC(7, 5) == lri && cube.GC(5, 7) == lfr)
            {
                cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                goto endish;
            }
            if (cube.GC(3, 7) == lfr && cube.GC(1, 5) == lri)
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                goto endish;
            }
            if (cube.GC(3, 7) == lri && cube.GC(1, 5) == lfr)
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                goto endish;
            }
            if (cube.GC(0, 4) == lfr && cube.GC(11, 4) == lri)
            {
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                goto endish;
            }
            if (cube.GC(0, 4) == lri && cube.GC(11, 4) == lfr)
            {
                cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                cube.TurnRight(RubiksCore.TurningDirection.SixoClock);
                goto endish;
            }
            if (cube.GC(4, 0) == lfr && cube.GC(10, 3) == lri)
            {
                cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                goto endish;
            }
            if (cube.GC(4, 0) == lri && cube.GC(10, 3) == lfr)
            {
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnRight(RubiksCore.TurningDirection.SixoClock);
                goto endish;
            }
            if (cube.GC(8, 4) == lfr && cube.GC(9, 4) == lri)
            {
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                goto endish;
            }
            if (cube.GC(8, 4) == lri && cube.GC(9, 4) == lfr)
            {
                cube.TurnRight(RubiksCore.TurningDirection.SixoClock);
                goto endish;
            }
            if (cube.GC(4, 8) == lfr && cube.GC(10, 5) == lri)
            {
                cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                goto endish;
            }
            if (cube.GC(4, 8) == lri && cube.GC(10, 5) == lfr)
            {
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnRight(RubiksCore.TurningDirection.SixoClock);
                goto endish;
            }
        endish:
            cube.Run("BUPhaseOne4");
            //cube.Run("YAA");
            //cube.Run("YAB");

        }
    }
}
