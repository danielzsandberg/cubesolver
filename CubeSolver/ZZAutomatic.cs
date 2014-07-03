using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class ZZAutomatic : ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "ZZAutomatic"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "Two Codes"; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {

//            int rpt = 0;

//           do
//           {
//              rpt++;

                cube.Shuffle();

                cube.Run("ZPhaseOne1");
                cube.Run("ZPhasePTwo2");

//Checking if the cube is really solved.  If not, the program will start over.

//Front face
                if (cube.GC(3, 3) != cube.GC(4, 4))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(3, 4) != cube.GC(4, 4))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(3, 5) != cube.GC(4, 4))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(4, 3) != cube.GC(4, 4))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(5, 3) != cube.GC(4, 4))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(5, 4) != cube.GC(4, 4))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(5, 5) != cube.GC(4, 4))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(4, 5) != cube.GC(4, 4))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
//Up face
                if (cube.GC(3, 0) != cube.GC(4, 1))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(3, 1) != cube.GC(4, 1))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(3, 2) != cube.GC(4, 1))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(4, 0) != cube.GC(4, 1))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(5, 0) != cube.GC(4, 1))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(5, 1) != cube.GC(4, 1))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(5, 2) != cube.GC(4, 1))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(4, 2) != cube.GC(4, 1))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
//Down face
                if (cube.GC(3, 6) != cube.GC(4, 7))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(3, 7) != cube.GC(4, 7))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(3, 8) != cube.GC(4, 7))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(4, 6) != cube.GC(4, 7))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(5, 6) != cube.GC(4, 7))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(5, 7) != cube.GC(4, 7))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(5, 8) != cube.GC(4, 7))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(4, 8) != cube.GC(4, 7))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
//Left face            
                if (cube.GC(0, 3) != cube.GC(1, 4))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(0, 4) != cube.GC(1, 4))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(0, 5) != cube.GC(1, 4))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(1, 3) != cube.GC(1, 4))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(2, 3) != cube.GC(1, 4))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(2, 4) != cube.GC(1, 4))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(2, 5) != cube.GC(1, 4))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(1, 5) != cube.GC(1, 4))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
//Right face            
                if (cube.GC(6, 3) != cube.GC(7, 4))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(6, 4) != cube.GC(7, 4))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(6, 5) != cube.GC(7, 4))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(7, 3) != cube.GC(7, 4))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(8, 3) != cube.GC(7, 4))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(8, 4) != cube.GC(7, 4))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(8, 5) != cube.GC(7, 4))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
                if (cube.GC(7, 5) != cube.GC(7, 4))
                {
                    cube.Run("ZPhaseOne1");
                    cube.Run("ZPhasePTwo2");
                }
//            } while (rpt < 5);        
        }

    }
}










