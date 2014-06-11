using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class ZPhaseOne1 : ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "ZPhaseOne1"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "First Section of the Cross."; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {
            
                var lfr = cube.GC(4, 4);
                var lle = cube.GC(1, 4);

                if (cube.GC(3, 4) == lfr && cube.GC(2, 4) == lle)
                {
                    cube.Run("ZPhaseOne2");
                }
                if (cube.GC(3, 4) == lle && cube.GC(2, 4) == lfr)
                {
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                    cube.Run("ZPhaseOne2");
                }
                if (cube.GC(4, 3) == lfr && cube.GC(4, 2) == lle)
                {
                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                    cube.Run("ZPhaseOne2");
                }
                if (cube.GC(4, 3) == lle && cube.GC(4, 2) == lfr)
                {
                    cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    cube.Run("ZPhaseOne2");
                }
                if (cube.GC(5, 4) == lfr && cube.GC(6, 4) == lle)
                {
                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnUp(RubiksCore.TurningDirection.SixoClock);
                    cube.Run("ZPhaseOne2");
                }
                if (cube.GC(5, 4) == lle && cube.GC(6, 4) == lfr)
                {
                    cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                    cube.Run("ZPhaseOne2");
                }
                if (cube.GC(4, 5) == lfr && cube.GC(4, 6) == lle)
                {
                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                    cube.Run("ZPhaseOne2");
                }
                if (cube.GC(4, 5) == lle && cube.GC(4, 6) == lfr)
                {
                    cube.TurnDown(RubiksCore.TurningDirection.NineoClock); 
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.Run("ZPhaseOne2");
                }
                if (cube.GC(1, 3) == lfr && cube.GC(3, 1) == lle)
                {
                    cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                    cube.Run("ZPhaseOne2");
                }
                if (cube.GC(1, 3) == lle && cube.GC(3, 1) == lfr)
                {
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    cube.Run("ZPhaseOne2");
                }
                if (cube.GC(5, 1) == lfr && cube.GC(7, 3) == lle)
                {
                    cube.TurnUp(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    cube.Run("ZPhaseOne2");
                }
                if (cube.GC(5, 1) == lle && cube.GC(7, 3) == lfr)
                {
                    cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                    cube.Run("ZPhaseOne2");
                }
                if (cube.GC(7, 5) == lfr && cube.GC(5, 7) == lle)
                {
                    cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                    cube.Run("ZPhaseOne2");
                }
                if (cube.GC(7, 5) == lle && cube.GC(5, 7) == lfr)
                {
                    cube.TurnDown(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.Run("ZPhaseOne2");
                }
                if (cube.GC(3, 7) == lfr && cube.GC(1, 5) == lle)
                {
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.Run("ZPhaseOne2");
                }
                if (cube.GC(3, 7) == lle && cube.GC(1, 5) == lfr)
                {
                    cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                    cube.Run("ZPhaseOne2");
                }
                if (cube.GC(0, 4) == lfr && cube.GC(11, 4) == lle)
                {
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                    cube.Run("ZPhaseOne2");
                }
                if (cube.GC(0, 4) == lle && cube.GC(11, 4) == lfr)
                {
                    cube.TurnLeft(RubiksCore.TurningDirection.SixoClock);
                    cube.Run("ZPhaseOne2");
                }
                if (cube.GC(4, 0) == lfr && cube.GC(10, 3) == lle)
                {
                    cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    cube.Run("ZPhaseOne2");
                }
                if (cube.GC(4, 0) == lle && cube.GC(10, 3) == lfr)
                {
                    cube.TurnUp(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                    cube.Run("ZPhaseOne2");
                }
                if (cube.GC(8, 4) == lfr && cube.GC(9, 4) == lle)
                {
                    cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                    cube.Run("ZPhaseOne2");
                }
                if (cube.GC(8, 4) == lle && cube.GC(9, 4) == lfr)
                {
                    cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnDown(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                    cube.Run("ZPhaseOne2");
                }
                if (cube.GC(4, 8) == lfr && cube.GC(10, 5) == lle)
                {
                    cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.Run("ZPhaseOne2");
                }
                if (cube.GC(4, 8) == lle && cube.GC(10, 5) == lfr)
                {
                    cube.TurnDown(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                    cube.Run("ZPhaseOne2");
                }

        }
    }
}
