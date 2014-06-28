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
            //System.Diagnostics.Debugger.Launch();
            startingish:
            
            int rpt = 1;
do
{
                var lfr = cube.GC(4, 4);
                var lle = cube.GC(1, 4);
                var lup = cube.GC(4, 1);
                var lri = cube.GC(7, 4);
                var ldo = cube.GC(4, 7);
                var lba = cube.GC(10, 4);
            
            if (cube.GC(2, 3) != lle)
               {goto segue;}            
            if (cube.GC(2, 5) != lle)
                {goto segue;}            
            if (cube.GC(3, 2) != lup)
                {goto segue;}            
            if (cube.GC(5, 2) != lup)
                {goto segue;}            
            if (cube.GC(6, 3) != lri)
                {goto segue;}            
            if (cube.GC(6, 5) != lri)
                {goto segue;}            
            if (cube.GC(3, 6) != ldo)
                {goto segue;}            
            if (cube.GC(5, 6) != ldo)
                {goto segue;}            
            if (cube.GC(5, 6) == ldo)
                {goto endish;}            
segue:            
            {
                rpt++;
            } 
//Searching for standing up low corners (8 cases)
//First case
            if (cube.GC(3, 0) == lfr)
            {
                if (cube.GC(0, 3) == lle)
                    {
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    }
                if (cube.GC(0, 3) == lup)
                    {
                        cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                    }
                if (cube.GC(0, 3) == lri)
                    {
                        cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                    }
                if (cube.GC(0, 3) == ldo)
                    {
                        cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                        cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                    }
            }
//Second case
            if (cube.GC(8, 3) == lfr)
            {
                if (cube.GC(5, 0) == lle)
                    {
                        cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                        cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    }
                if (cube.GC(5, 0) == lup)
                    {
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                    }
                if (cube.GC(5, 0) == lri)
                    {
                        cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                    }
                if (cube.GC(5, 0) == ldo)
                    {
                        cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                    }
            }
//Third case
            if (cube.GC(5, 8) == lfr)
            {
                if (cube.GC(8, 5) == lle)
                    {
                        cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    }
                if (cube.GC(8, 5) == lup)
                    {
                        cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                        cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                    }
                if (cube.GC(8, 5) == lri)
                    {
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                    }
                if (cube.GC(8, 5) == ldo)
                    {
                        cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                    }
            }
//Fourth case
            if (cube.GC(0, 5) == lfr)
            {
                if (cube.GC(3, 8) == lle)
                    {
                        cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    }
                if (cube.GC(3, 8) == lup)
                    {
                        cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                    }
                if (cube.GC(3, 8) == lri)
                    {
                        cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                        cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                    }
                if (cube.GC(3, 8) == ldo)
                    {
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                    }
            }
//Fifth case
            if (cube.GC(0, 3) == lfr)
            {
                if (cube.GC(3, 0) == lle)
                    {
                        cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                        cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    }
                if (cube.GC(3, 0) == lup)
                    {
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                    }
                if (cube.GC(3, 0) == lri)
                    {
                        cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                    }
                if (cube.GC(3, 0) == ldo)
                    {
                        cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                    }
            }
//Sixth case
            if (cube.GC(5, 0) == lfr)
            {
                if (cube.GC(8, 3) == lle)
                    {
                        cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    }
                if (cube.GC(8, 3) == lup)
                    {
                        cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                        cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                    }
                if (cube.GC(8, 3) == lri)
                    {
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                    }
                if (cube.GC(8, 3) == ldo)
                    {
                        cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                    }
            }
//Seventh case
            if (cube.GC(8, 5) == lfr)
            {
                if (cube.GC(5, 8) == lle)
                    {
                        cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    }
                if (cube.GC(5, 8) == lup)
                    {
                        cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                    }
                if (cube.GC(5, 8) == lri)
                    {
                        cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                        cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                    }
                if (cube.GC(5, 8) == ldo)
                    {
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                    }
            }
//Eighth case
            if (cube.GC(3, 8) == lfr)
            {
                if (cube.GC(0, 5) == lle)
                    {
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    }
                if (cube.GC(0, 5) == lup)
                    {
                        cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                    }
                if (cube.GC(0, 5) == lri)
                    {
                        cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                    }
                if (cube.GC(0, 5) == ldo)
                    {
                        cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                        cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                    }
            }
}
while (rpt < 5);
                if (cube.GC(3, 3) == cube.GC(4, 4) && cube.GC(3, 2) != cube.GC(4, 1))
                {
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    goto startingish;
                }
                if (cube.GC(5, 3) == cube.GC(4, 4) && cube.GC(5, 2) != cube.GC(4, 1))
                {
                    cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                    goto startingish;
                }
                if (cube.GC(3, 5) == cube.GC(4, 4) && cube.GC(3, 6) != cube.GC(4, 7))
                {
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    goto startingish;
                }
                if (cube.GC(5, 5) == cube.GC(4, 4) && cube.GC(5, 6) != cube.GC(4, 7))
                {
                    cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                    goto startingish;
                }
                if (cube.GC(3, 2) == cube.GC(4, 4))
                {
                    cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                    goto startingish;
                }
                if (cube.GC(5, 6) == cube.GC(4, 4))
                {
                    cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                    goto startingish;
                }
                if (cube.GC(3, 6) == cube.GC(4, 4))
                {
                    cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                    goto startingish;
                }
                if (cube.GC(2, 3) == cube.GC(4, 4))
                {
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    goto startingish;
                }
                if (cube.GC(2, 5) == cube.GC(4, 4))
                {
                    cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                    goto startingish;
                }
                if (cube.GC(6, 3) == cube.GC(4, 4))
                {
                    cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                    goto startingish;
                }
                if (cube.GC(6, 5) == cube.GC(4, 4))
                {
                    cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                    goto startingish;  
                }
            int rpu = 0;
            do
            {
                rpu++;

                if (cube.GC(9, 3) == cube.GC(4, 4) && cube.GC(5,3) != cube.GC(4, 4))
                {
                    cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                    cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                    cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                    goto startingish;
                
                    if (cube.GC(11, 3) == cube.GC(4, 4) && cube.GC(3,3) != cube.GC(4, 4))
                    {
                        cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                        cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                        cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                        goto startingish;
                    
                        if (cube.GC(11, 5) == cube.GC(4, 4) && cube.GC(3, 5) != cube.GC(4, 4))
                        {
                            cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                            cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                            cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                            goto startingish;
                        
                            if (cube.GC(9, 5) == cube.GC(4, 4) && cube.GC(5, 5) != cube.GC(4, 4))
                            {
                                cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                                cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                                cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
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
            while (rpu < 5);
            goto startingish;
endish:
            //cube.Run("ZPhasePTwo2");
            cube.Run("YNA"); 
            cube.Run("YNA");       
        }
    }
}
