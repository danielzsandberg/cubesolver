using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class ZPhasePTwo1 : ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "ZPhasePTwo1"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "Getting the first layer ready."; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {
            startingish:
            
            //System.Diagnostics.Debugger.Launch();
            int rpt = 1;
            do
            {
                if (cube.GC(5, 8) == cube.GC(4, 4) && cube.GC(8, 5) == cube.GC(7, 4))
                {
                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 1);
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 1);
                }
                if (cube.GC(5, 8) == cube.GC(4, 4) && cube.GC(8, 5) == cube.GC(4, 1))
                {
                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 1);
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 1);
                }
                if (cube.GC(5, 8) == cube.GC(4, 4) && cube.GC(8, 5) == cube.GC(1, 4))
                {
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                }
                if (cube.GC(5, 8) == cube.GC(4, 4) && cube.GC(8, 5) == cube.GC(4, 7))
                {
                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 1);
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 1);
                }
                if (cube.GC(8, 3) == cube.GC(4, 4))
                {
                    cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                }
                if (cube.GC(5, 8) == cube.GC(4, 4) && cube.GC(8, 5) == cube.GC(7, 4))
                {
                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 1);
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 1);
                }
                if (cube.GC(5, 8) == cube.GC(4, 4) && cube.GC(8, 5) == cube.GC(4, 1))
                {
                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 1);
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 1);
                }
                if (cube.GC(5, 8) == cube.GC(4, 4) && cube.GC(8, 5) == cube.GC(1, 4))
                {
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                }
                if (cube.GC(5, 8) == cube.GC(4, 4) && cube.GC(8, 5) == cube.GC(4, 7))
                {
                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 1);
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 1);
                }
                if (cube.GC(3, 0) == cube.GC(4, 4))
                {
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                }
                if (cube.GC(5, 8) == cube.GC(4, 4) && cube.GC(8, 5) == cube.GC(7, 4))
                {
                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 1);
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 1);
                }
                if (cube.GC(5, 8) == cube.GC(4, 4) && cube.GC(8, 5) == cube.GC(4, 1))
                {
                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 1);
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 1);
                }
                if (cube.GC(5, 8) == cube.GC(4, 4) && cube.GC(8, 5) == cube.GC(1, 4))
                {
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                }
                if (cube.GC(5, 8) == cube.GC(4, 4) && cube.GC(8, 5) == cube.GC(4, 7))
                {
                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 1);
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 1);
                }
                if (cube.GC(0, 5) == cube.GC(4, 4))
                {
                    cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                }
                if (cube.GC(5, 8) == cube.GC(4, 4) && cube.GC(8, 5) == cube.GC(7, 4))
                {
                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 1);
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 1);
                }
                if (cube.GC(5, 8) == cube.GC(4, 4) && cube.GC(8, 5) == cube.GC(4, 1))
                {
                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 1);
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 1);
                }
                if (cube.GC(5, 8) == cube.GC(4, 4) && cube.GC(8, 5) == cube.GC(1, 4))
                {
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                }
                if (cube.GC(5, 8) == cube.GC(4, 4) && cube.GC(8, 5) == cube.GC(4, 7))
                {
                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 1);
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 1);
                }
                rpt++;
            } 
            while (rpt < 5);
                if (cube.GC(3, 3) == cube.GC(4, 4) && cube.GC(3, 2) != cube.GC(4, 1))
                {
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    cube.Run("ZPhasePTwo1Check");
                    cube.Run("ZPhasePTwo1Aux");
                }
                if (cube.GC(5, 3) == cube.GC(4, 4) && cube.GC(5, 2) != cube.GC(4, 1))
                {
                    cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                    cube.Run("ZPhasePTwo1Check");
                    cube.Run("ZPhasePTwo1Aux");
                }
                if (cube.GC(3, 5) == cube.GC(4, 4) && cube.GC(3, 6) != cube.GC(4, 7))
                {
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.Run("ZPhasePTwo1Check");
                    cube.Run("ZPhasePTwo1Aux");
                }
                if (cube.GC(5, 5) == cube.GC(4, 4) && cube.GC(5, 6) != cube.GC(4, 7))
                {
                    cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                    cube.Run("ZPhasePTwo1Check");
                    cube.Run("ZPhasePTwo1Aux");
                }
                if (cube.GC(3, 2) == cube.GC(4, 4))
                {
                    cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                    cube.Run("ZPhasePTwo1Check");
                    cube.Run("ZPhasePTwo1Aux");
                }
                if (cube.GC(5, 6) == cube.GC(4, 4))
                {
                    cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                    cube.Run("ZPhasePTwo1Check");
                    goto startingish;
                }
                if (cube.GC(3, 6) == cube.GC(4, 4))
                {
                    cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                    cube.Run("ZPhasePTwo1Check");
                    goto startingish;
                }
                if (cube.GC(2, 3) == cube.GC(4, 4))
                {
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    cube.Run("ZPhasePTwo1Check");
                    goto startingish;
                }
                if (cube.GC(2, 5) == cube.GC(4, 4))
                {
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.Run("ZPhasePTwo1Check");
                    goto startingish;
                }
                if (cube.GC(6, 3) == cube.GC(4, 4))
                {
                    cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                    cube.Run("ZPhasePTwo1Check");
                    goto startingish;
                }
                if (cube.GC(6, 5) == cube.GC(4, 4))
                {
                    cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                    cube.Run("ZPhasePTwo1Check");
                    goto startingish;
                }
            rpt = 1;
            do
            {
                rpt++;

                if (cube.GC(9, 3) == cube.GC(4, 4) && cube.GC(5,3) != cube.GC(4, 4))
                {
                    cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                    cube.Run("ZPhasePTwo1Check");
                    goto startingish;
                
                    if (cube.GC(11, 3) == cube.GC(4, 4) && cube.GC(3,3) != cube.GC(4, 4))
                    {
                        cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                        cube.Run("ZPhasePTwo1Check");
                        goto startingish;
                    
                        if (cube.GC(11, 5) == cube.GC(4, 4) && cube.GC(3, 5) != cube.GC(4, 4))
                        {
                            cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                            cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                            cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                            cube.Run("ZPhasePTwo1Check");
                            goto startingish;
                        
                            if (cube.GC(9, 5) == cube.GC(4, 4) && cube.GC(5, 5) != cube.GC(4, 4))
                            {
                                cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                                cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                                cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                                cube.Run("ZPhasePTwo1Check");
                                goto startingish;
                            }
                        }
                        else
                        {
                            cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                        }
                    }
                    else
                    {
                        cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                    }
                }
                else
                {
                    cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                }
            }
            while (rpt < 5);
        }
    }
}
