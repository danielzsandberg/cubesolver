using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class ZPhaseUFourNewVersion : ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "ZPhaseUFourNewVersion"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "Final phase."; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {
            if (cube.GC(2, 3) == cube.GC(4, 6) && cube.GC(2, 3) == cube.GC(5, 6))
            {
                if (cube.GC(3, 6) == cube.GC(6, 3) && cube.GC(3, 6) == cube.GC(4, 2))
                {
                    if (cube.GC(2, 4) == cube.GC(3, 2) && cube.GC(2, 4) == cube.GC(5, 2))
                    {
                        if (cube.GC(2, 5) == cube.GC(6, 4) && cube.GC(2, 5) == cube.GC(6, 5))
                       
                            if (cube.GC(4, 6) == cube.GC(4, 7))
                            {
                                cube.Run("YAA");
                                goto endish;
                            }
                            if (cube.GC(4, 6) == cube.GC(4, 1))
                            {
                                cube.Run("YAA");
                                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                                cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);
                                goto endish;
                            }
                            if (cube.GC(4, 6) == cube.GC(1, 4))
                            {
                                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                                cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 2);
                                cube.Run("YAA");
                                goto endish;
                            }
                            if (cube.GC(4, 6) == cube.GC(7, 4))
                            {
                                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 2);
                                cube.Run("YAA");
                                goto endish;
                            }

                    }
                }
            }

            endish:
            cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);
            cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);

        }
    }
}
