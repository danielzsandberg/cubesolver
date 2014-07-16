using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class ZPhasePTwo3 //: ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "ZPhasePTwo3"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "Two layers completed."; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {

            var lfr = cube.GC(4, 4);
            var lle = cube.GC(1, 4);
            var lup = cube.GC(4, 1);
            var lri = cube.GC(7, 4);
            var ldo = cube.GC(4, 7);
            var lba = cube.GC(10, 4);

           int rpt = 1;
           int rpu = 1;
 
startingish:
            if (cube.GC(1, 5) != lle || cube.GC(1, 3) != lle || cube.GC(7, 5) != lri || cube.GC(7, 3) != lri)
            { goto segue; }
            if (cube.GC(3, 1) != lup || cube.GC(5, 1) != lup || cube.GC(3, 7) != ldo || cube.GC(5, 7) != ldo)
            { goto segue; }
            else
            { goto endish; }

segue:                
            
            if (cube.GC(10, 3) == lba || cube.GC(4, 0) == lba)
            {
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                    if (rpt == 4)
                    {goto endish;}
                rpt = rpt+1;
                goto segue;
            }
            else
            {}

            if (cube.GC(10, 3) == lle)
            {
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                goto vai1;
            }
            if (cube.GC(10, 3) == lup)
            {
                cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                goto vai2;
            }
            if (cube.GC(10, 3) == lri)
            {
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                goto vai3;
            }
            if (cube.GC(10, 3) == ldo)
            {goto vai4;}
vai1:
            if (cube.GC(8, 4) == ldo)
            {
                cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                goto antesnext;
            }
            if (cube.GC(8, 4) == lup)
            {
                cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                goto antesnext;
            }
            
vai2:
            if (cube.GC(4, 8) == lle)
            {
                cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                goto antesnext;
            }
            if (cube.GC(4, 8) == lri)
            {
                cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                goto antesnext;
            }
vai3:
            if (cube.GC(0, 4) == lup)
            {
                cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                goto antesnext;
            }
            if (cube.GC(0, 4) == ldo)
            {
                cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                goto antesnext;
            }

vai4:
            if (cube.GC(4, 0) == lri)
            {
                cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                goto antesnext;
            }
            if (cube.GC(4, 0) == lle)
            {
                cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
            }
antesnext:
                if (rpu == 6)
                {goto endish;}

                rpu = rpu + 1;
                goto startingish;
endish:

                cube.Run("TotalMoveUpLeft");
                cube.Run("TotalMoveUpLeft");

                if (cube.GC(5, 1) != cube.GC(4, 1) || cube.GC(3, 1) != cube.GC(4, 1) || cube.GC(1, 3) != cube.GC(1, 4) || cube.GC(1, 5) != cube.GC(1, 4))
                {
                    cube.Shuffle();
                    cube.Run("ZPhaseOne1");
                }
                if (cube.GC(5, 7) != cube.GC(4, 7) || cube.GC(3, 7) != cube.GC(4, 7) || cube.GC(7, 3) != cube.GC(7, 4) || cube.GC(7, 5) != cube.GC(7, 4))
                {
                    cube.Shuffle();
                    cube.Run("ZPhaseOne1");
                }

                cube.Run("ZPhaseThree");
                //cube.Run("YAA");
                //cube.Run("YAB");

            }
        }
    }





