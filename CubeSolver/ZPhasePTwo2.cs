using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class ZPhasePTwo2 : ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "ZPhasePTwo2"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "Four cubies in the middle layer."; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {
            //System.Diagnostics.Debugger.Launch();
            int rpt = 0;

            var lfr = cube.GC(4, 4);
            var lle = cube.GC(1, 4);
            var lup = cube.GC(4, 1);
            var lri = cube.GC(7, 4);
            var ldo = cube.GC(4, 7);
            var lba = cube.GC(10, 4);

do
{
    {
        rpt = rpt + 1;
    }
        if (cube.GC(1, 3) != lba && cube.GC(3, 1) != lba)
        {
            if (cube.GC(0, 4) == lba || cube.GC(11, 4) == lba)
            {
                cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
            }
            if (cube.GC(4, 0) == lba || cube.GC(10, 3) == lba)
            {
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
            }
            if (cube.GC(8, 4) == lba || cube.GC(9, 4) == lba)
            {
                cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
            }
            if (cube.GC(4, 8) == lba || cube.GC(10, 5) == lba)
            {
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
            }
        }
        if (cube.GC(1, 5) != lba && cube.GC(3, 7) != lba)
        {
            if (cube.GC(0, 4) == lba || cube.GC(11, 4) == lba)
            {
                cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
            }
            if (cube.GC(4, 0) == lba || cube.GC(10, 3) == lba)
            {
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
            }
            if (cube.GC(8, 4) == lba || cube.GC(9, 4) == lba)
            {
                cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
            }
            if (cube.GC(4, 8) == lba || cube.GC(10, 5) == lba)
            {
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnLeft(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
            }
        }        
        if (cube.GC(7, 3) != lba && cube.GC(5, 1) != lba)
        {
            if (cube.GC(0, 4) == lba || cube.GC(11, 4) == lba)
            {
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
            }
            if (cube.GC(4, 0) == lba || cube.GC(10, 3) == lba)
            {
                cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
            }
            if (cube.GC(8, 4) == lba || cube.GC(9, 4) == lba)
            {
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
            }
            if (cube.GC(4, 8) == lba || cube.GC(10, 5) == lba)
            {
                cube.TurnUp(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
            }
        }
        if (cube.GC(7, 5) != lba && cube.GC(5, 7) != lba)
        {
            if (cube.GC(0, 4) == lba || cube.GC(11, 4) == lba)
            {
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
            }
            if (cube.GC(4, 0) == lba || cube.GC(10, 3) == lba)
            {
                cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
            }
            if (cube.GC(8, 4) == lba || cube.GC(9, 4) == lba)
            {
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
            }
            if (cube.GC(4, 8) == lba || cube.GC(10, 5) == lba)
            {
                cube.TurnBack(RubiksCore.TurningDirection.SixoClock);
                cube.TurnDown(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnDown(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
                cube.TurnRight(RubiksCore.TurningDirection.NineoClock);
                cube.TurnBack(RubiksCore.TurningDirection.ThreeoClock);
                cube.TurnRight(RubiksCore.TurningDirection.ThreeoClock);
            }
        }        
         
}
while (rpt < 5);

                cube.Run("ZPhasePTwo3");
                //cube.Run("YNA");
                //cube.Run("YNA");
        }
    }
}
