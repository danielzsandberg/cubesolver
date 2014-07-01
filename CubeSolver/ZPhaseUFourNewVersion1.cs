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
// Cube already solved
            if (cube.GC(4, 6) == cube.GC(3, 6) && cube.GC(4, 6) == cube.GC(5, 6))
            {
                if (cube.GC(4, 2) == cube.GC(3, 2) && cube.GC(4, 2) == cube.GC(5, 2))
                {
                    if (cube.GC(2, 4) == cube.GC(2, 3) && cube.GC(2, 4) == cube.GC(2, 5))
                    {
                        if (cube.GC(6, 4) == cube.GC(6, 3) && cube.GC(6, 4) == cube.GC(6, 5))
                        {
                            if (cube.GC(4, 6) == cube.GC(4, 7))
                            {
                                goto endish;
                            }
                            if (cube.GC(4, 6) == cube.GC(4, 1))
                            {
                                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                                cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);
                                goto endish;
                            }
                            if (cube.GC(4, 6) == cube.GC(1, 4))
                            {
                                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                                cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 2);
                                goto endish;
                            }
                            if (cube.GC(4, 6) == cube.GC(7, 4))
                            {
                                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 2);
                                goto endish;
                            }
                        }
                    }
                }
            }
            // Solving end position AA
            int llr = 1;
            do
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                llr++;
                if (cube.GC(2, 3) == cube.GC(4, 6) && cube.GC(2, 3) == cube.GC(5, 6))
                {
                    if (cube.GC(3, 6) == cube.GC(6, 3) && cube.GC(3, 6) == cube.GC(4, 2))
                    {
                        if (cube.GC(2, 4) == cube.GC(3, 2) && cube.GC(2, 4) == cube.GC(5, 2))
                        {
                            if (cube.GC(2, 5) == cube.GC(6, 4) && cube.GC(2, 5) == cube.GC(6, 5))
                            {
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
                }
            } while (llr < 5);
            // Solving end position AB
            llr = 1;
            do
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                llr++;
                if (cube.GC(5, 2) == cube.GC(4, 6) && cube.GC(5, 2) == cube.GC(5, 6))
                {
                    if (cube.GC(4, 2) == cube.GC(2, 3) && cube.GC(4, 2) == cube.GC(2, 5))
                    {
                        if (cube.GC(3, 6) == cube.GC(2, 4) && cube.GC(3, 6) == cube.GC(6, 3))
                        {
                            if (cube.GC(3, 2) == cube.GC(6, 4) && cube.GC(3, 2) == cube.GC(6, 5))
                            {
                                if (cube.GC(4, 6) == cube.GC(4, 7))
                                {
                                    cube.Run("YAB");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 1))
                                {
                                    cube.Run("YAB");
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(1, 4))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 2);
                                    cube.Run("YAB");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(7, 4))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 2);
                                    cube.Run("YAB");
                                    goto endish;
                                }
                            }
                        }
                    }
                }
            } while (llr < 5);
// Solving end position DA
            llr = 1;
            do
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                llr++;
                if (cube.GC(6, 4) == cube.GC(3, 6) && cube.GC(6, 4) == cube.GC(5, 6))
                {
                    if (cube.GC(4, 2) == cube.GC(3, 2) && cube.GC(4, 2) == cube.GC(5, 2))
                    {
                        if (cube.GC(2, 4) == cube.GC(6, 3) && cube.GC(2, 4) == cube.GC(6, 5))
                        {
                            if (cube.GC(4, 6) == cube.GC(2, 3) && cube.GC(4, 6) == cube.GC(2, 5))
                            {
                                if (cube.GC(4, 6) == cube.GC(1, 4))
                                {
                                    cube.Run("YDA");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(7, 4))
                                {
                                    cube.Run("YDA");
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 1))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 2);
                                    cube.Run("YDA");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 7))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 2);
                                    cube.Run("YDA");
                                    goto endish;
                                }
                            }
                        }
                    }
                }
            } while (llr < 5);
// Solving end position DB
            llr = 1;
            do
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                llr++;
                if (cube.GC(2, 4) == cube.GC(3, 6) && cube.GC(2, 4) == cube.GC(5, 6))
                {
                    if (cube.GC(4, 2) == cube.GC(3, 2) && cube.GC(4, 2) == cube.GC(5, 2))
                    {
                        if (cube.GC(6, 4) == cube.GC(2, 3) && cube.GC(6, 4) == cube.GC(2, 5))
                        {
                            if (cube.GC(4, 6) == cube.GC(6, 3) && cube.GC(4, 6) == cube.GC(6, 5))
                            {
                                if (cube.GC(4, 6) == cube.GC(7, 4))
                                {
                                    cube.Run("YDB");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(1, 4))
                                {
                                    cube.Run("YDB");
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 7))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 2);
                                    cube.Run("YDB");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 1))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 2);
                                    cube.Run("YDB");
                                    goto endish;
                                }
                            }
                        }
                    }
                }
            } while (llr < 5);
// Solving end position E
            llr = 1;
            do
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                llr++;
                if (cube.GC(4, 6) == cube.GC(2, 5) && cube.GC(4, 6) == cube.GC(6, 5))
                {
                    if (cube.GC(4, 2) == cube.GC(2, 3) && cube.GC(4, 2) == cube.GC(6, 3))
                    {
                        if (cube.GC(2, 4) == cube.GC(5, 2) && cube.GC(2, 4) == cube.GC(5, 6))
                        {
                            if (cube.GC(6, 4) == cube.GC(3, 2) && cube.GC(6, 4) == cube.GC(3, 6))
                            {
                                if (cube.GC(4, 6) == cube.GC(4, 7))
                                {
                                    cube.Run("YE");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 1))
                                {
                                    cube.Run("YE");
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(1, 4))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 2);
                                    cube.Run("YE");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(7, 4))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 2);
                                    cube.Run("YE");
                                    goto endish;
                                }
                            }
                        }
                    }
                }
            } while (llr < 5);
// Solving end position F
            llr = 1;
            do
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                llr++;
                if (cube.GC(4, 2) == cube.GC(6, 3) && cube.GC(4, 2) == cube.GC(3, 6))
                {
                    if (cube.GC(4, 6) == cube.GC(3, 2) && cube.GC(4, 6) == cube.GC(6, 5))
                    {
                        if (cube.GC(2, 4) == cube.GC(2, 3) && cube.GC(2, 4) == cube.GC(2, 5))
                        {
                            if (cube.GC(6, 4) == cube.GC(5, 2) && cube.GC(6, 4) == cube.GC(5, 6))
                            {
                                if (cube.GC(4, 6) == cube.GC(4, 1))
                                {
                                    cube.Run("YF");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 7))
                                {
                                    cube.Run("YF");
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(7, 4))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 2);
                                    cube.Run("YF");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(1, 4))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 2);
                                    cube.Run("YF");
                                    goto endish;
                                }
                            }
                        }
                    }
                }
            } while (llr < 5);
// Solving end position GAA
            llr = 1;
            do
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                llr++;
                if (cube.GC(4, 6) == cube.GC(3, 6) && cube.GC(4, 6) == cube.GC(6, 3))
                {
                    if (cube.GC(6, 4) == cube.GC(5, 6) && cube.GC(6, 4) == cube.GC(2, 3))
                    {
                        if (cube.GC(4, 2) == cube.GC(2, 5) && cube.GC(4, 2) == cube.GC(6, 5))
                        {
                            if (cube.GC(2, 4) == cube.GC(3, 2) && cube.GC(2, 4) == cube.GC(5, 2))
                            {
                                if (cube.GC(4, 6) == cube.GC(4, 7))
                                {
                                    cube.Run("YGAA");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 1))
                                {
                                    cube.Run("YGAA");
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(1, 4))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 2);
                                    cube.Run("YGAA");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(7, 4))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 2);
                                    cube.Run("YGAA");
                                    goto endish;
                                }
                            }
                        }
                    }
                }
            } while (llr < 5);
// Solving end position GAB
            llr = 1;
            do
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                llr++;
                if (cube.GC(4, 6) == cube.GC(3, 6) && cube.GC(4, 6) == cube.GC(3, 2))
                {
                    if (cube.GC(2, 4) == cube.GC(6, 3) && cube.GC(2, 4) == cube.GC(6, 5))
                    {
                        if (cube.GC(6, 4) == cube.GC(5, 2) && cube.GC(6, 4) == cube.GC(2, 5))
                        {
                            if (cube.GC(4, 2) == cube.GC(2, 3) && cube.GC(4, 2) == cube.GC(5, 6))
                            {
                                if (cube.GC(4, 6) == cube.GC(4, 7))
                                {
                                    cube.Run("YGAB");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 1))
                                {
                                    cube.Run("YGAB");
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(1, 4))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 2);
                                    cube.Run("YGAB");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(7, 4))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 2);
                                    cube.Run("YGAB");
                                    goto endish;
                                }
                            }
                        }
                    }
                }
            } while (llr < 5);
// Solving end position GBA
            llr = 1;
            do
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                llr++;
                if (cube.GC(4, 6) == cube.GC(5, 6) && cube.GC(4, 6) == cube.GC(2, 3))
                {
                    if (cube.GC(2, 4) == cube.GC(6, 3) && cube.GC(2, 4) == cube.GC(3, 6))
                    {
                        if (cube.GC(6, 4) == cube.GC(3, 2) && cube.GC(6, 4) == cube.GC(5, 2))
                        {
                            if (cube.GC(4, 2) == cube.GC(2, 5) && cube.GC(4, 2) == cube.GC(6, 5))
                            {
                                if (cube.GC(4, 6) == cube.GC(4, 7))
                                {
                                    cube.Run("YGBA");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 1))
                                {
                                    cube.Run("YGBA");
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(1, 4))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 2);
                                    cube.Run("YGBA");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(7, 4))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 2);
                                    cube.Run("YGBA");
                                    goto endish;
                                }
                            }
                        }
                    }
                }
            } while (llr < 5);
// Solving end position GBB
            llr = 1;
            do
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                llr++;
                if (cube.GC(4, 6) == cube.GC(5, 6) && cube.GC(4, 6) == cube.GC(5, 2))
                {
                    if (cube.GC(6, 4) == cube.GC(2, 3) && cube.GC(6, 4) == cube.GC(2, 5))
                    {
                        if (cube.GC(4, 2) == cube.GC(6, 3) && cube.GC(4, 2) == cube.GC(3, 6))
                        {
                            if (cube.GC(2, 4) == cube.GC(3, 2) && cube.GC(2, 4) == cube.GC(6, 5))
                            {
                                if (cube.GC(4, 6) == cube.GC(4, 7))
                                {
                                    cube.Run("YGBB");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 1))
                                {
                                    cube.Run("YGBB");
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(1, 4))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 2);
                                    cube.Run("YGBB");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(7, 4))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 2);
                                    cube.Run("YGBB");
                                    goto endish;
                                }
                            }
                        }
                    }
                }
            } while (llr < 5);
// Solving end position H
            llr = 1;
            do
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                llr++;
                if (cube.GC(2, 4) == cube.GC(6, 3) && cube.GC(2, 4) == cube.GC(6, 5))
                {
                    if (cube.GC(6, 4) == cube.GC(2, 3) && cube.GC(6, 4) == cube.GC(2, 5))
                    {
                        if (cube.GC(4, 2) == cube.GC(3, 6) && cube.GC(4, 2) == cube.GC(5, 6))
                        {
                            if (cube.GC(4, 6) == cube.GC(3, 2) && cube.GC(4, 6) == cube.GC(5, 2))
                            {
                                if (cube.GC(4, 6) == cube.GC(7, 4))
                                {
                                    cube.Run("YH");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(1, 4))
                                {
                                    cube.Run("YH");
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 7))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 2);
                                    cube.Run("YH");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 1))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 2);
                                    cube.Run("YH");
                                    goto endish;
                                }
                            }
                        }
                    }
                }
            } while (llr < 5);
// Solving end position JA
            llr = 1;
            do
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                llr++;
                if (cube.GC(6, 4) == cube.GC(6, 3) && cube.GC(6, 4) == cube.GC(3, 6))
                {
                    if (cube.GC(4, 2) == cube.GC(3, 2) && cube.GC(4, 2) == cube.GC(6, 5))
                    {
                        if (cube.GC(2, 4) == cube.GC(2, 3) && cube.GC(2, 4) == cube.GC(2, 5))
                        {
                            if (cube.GC(4, 6) == cube.GC(5, 6) && cube.GC(4, 6) == cube.GC(5, 2))
                            {
                                if (cube.GC(4, 6) == cube.GC(7, 4))
                                {
                                    cube.Run("YJA");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(1, 4))
                                {
                                    cube.Run("YJA");
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 7))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 2);
                                    cube.Run("YJA");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 1))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 2);
                                    cube.Run("YJA");
                                    goto endish;
                                }
                            }
                        }
                    }
                }
            } while (llr < 5);
// Solving end position JB
            llr = 1;
            do
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                llr++;
                if (cube.GC(2, 4) == cube.GC(2, 3) && cube.GC(2, 4) == cube.GC(5, 6))
                {
                    if (cube.GC(4, 2) == cube.GC(5, 2) && cube.GC(4, 2) == cube.GC(2, 5))
                    {
                        if (cube.GC(4, 6) == cube.GC(3, 6) && cube.GC(4, 6) == cube.GC(3, 2))
                        {
                            if (cube.GC(6, 4) == cube.GC(6, 3) && cube.GC(6, 4) == cube.GC(6, 5))
                            {
                                if (cube.GC(4, 6) == cube.GC(1, 4))
                                {
                                    cube.Run("YJB");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(7, 4))
                                {
                                    cube.Run("YJB");
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 1))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 2);
                                    cube.Run("YJB");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 7))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 2);
                                    cube.Run("YJB");
                                    goto endish;
                                }
                            }
                        }
                    }
                }
            } while (llr < 5);
// Solving end position NA
            llr = 1;
            do
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                llr++;
                if (cube.GC(4, 6) == cube.GC(3, 6) && cube.GC(4, 6) == cube.GC(3, 2))
                {
                    if (cube.GC(4, 2) == cube.GC(5, 2) && cube.GC(4, 2) == cube.GC(5, 6))
                    {
                        if (cube.GC(6, 4) == cube.GC(6, 5) && cube.GC(6, 4) == cube.GC(2, 5))
                        {
                            if (cube.GC(2, 4) == cube.GC(2, 3) && cube.GC(2, 4) == cube.GC(6, 3))
                            {
                                if (cube.GC(4, 6) == cube.GC(4, 7))
                                {
                                    cube.Run("YNA");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 1))
                                {
                                    cube.Run("YNA");
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(1, 4))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 2);
                                    cube.Run("YNA");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(7, 4))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 2);
                                    cube.Run("YNA");
                                    goto endish;
                                }
                            }
                        }
                    }
                }
            } while (llr < 5);
// Solving end position NB
            llr = 1;
            do
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                llr++;
                if (cube.GC(4, 6) == cube.GC(5, 6) && cube.GC(4, 6) == cube.GC(5, 2))
                {
                    if (cube.GC(4, 2) == cube.GC(3, 2) && cube.GC(4, 2) == cube.GC(3, 6))
                    {
                        if (cube.GC(6, 4) == cube.GC(6, 3) && cube.GC(6, 4) == cube.GC(2, 3))
                        {
                            if (cube.GC(2, 4) == cube.GC(2, 5) && cube.GC(2, 4) == cube.GC(6, 5))
                            {
                                if (cube.GC(4, 6) == cube.GC(4, 7))
                                {
                                    cube.Run("YNB");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 1))
                                {
                                    cube.Run("YNB");
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(1, 4))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 2);
                                    cube.Run("YNB");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(7, 4))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 2);
                                    cube.Run("YNB");
                                    goto endish;
                                }
                            }
                        }
                    }
                }
            } while (llr < 5);
// Solving end position RA
            llr = 1;
            do
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                llr++;
                if (cube.GC(4, 2) == cube.GC(2, 3) && cube.GC(4, 2) == cube.GC(6, 3))
                {
                    if (cube.GC(6, 4) == cube.GC(3, 6) && cube.GC(6, 4) == cube.GC(5, 6))
                    {
                        if (cube.GC(4, 6) == cube.GC(3, 2) && cube.GC(4, 6) == cube.GC(6, 5))
                        {
                            if (cube.GC(2, 4) == cube.GC(2, 5) && cube.GC(2, 4) == cube.GC(5, 2))
                            {
                                if (cube.GC(4, 6) == cube.GC(7, 4))
                                {
                                    cube.Run("YRA");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(1, 4))
                                {
                                    cube.Run("YRA");
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 7))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 2);
                                    cube.Run("YRA");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 1))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 2);
                                    cube.Run("YRA");
                                    goto endish;
                                }
                            }
                        }
                    }
                }
            } while (llr < 5);
// Solving end position RB
            llr = 1;
            do
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                llr++;
                if (cube.GC(2, 4) == cube.GC(3, 6) && cube.GC(2, 4) == cube.GC(5, 6))
                {
                    if (cube.GC(4, 2) == cube.GC(2, 3) && cube.GC(4, 2) == cube.GC(6, 3))
                    {
                        if (cube.GC(4, 6) == cube.GC(2, 5) && cube.GC(4, 6) == cube.GC(5, 2))
                        {
                            if (cube.GC(6, 4) == cube.GC(6, 5) && cube.GC(6, 4) == cube.GC(3, 2))
                            {
                                if (cube.GC(4, 6) == cube.GC(1, 4))
                                {
                                    cube.Run("YRB");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(7, 4))
                                {
                                    cube.Run("YRB");
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 1))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 2);
                                    cube.Run("YRB");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 7))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 2);
                                    cube.Run("YRB");
                                    goto endish;
                                }
                            }
                        }
                    }
                }
            } while (llr < 5);
// Solving end position T
            llr = 1;
            do
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                llr++;
                if (cube.GC(4, 2) == cube.GC(3, 6) && cube.GC(4, 2) == cube.GC(5, 6))
                {
                    if (cube.GC(4, 6) == cube.GC(2, 3) && cube.GC(4, 6) == cube.GC(6, 3))
                    {
                        if (cube.GC(2, 4) == cube.GC(2, 5) && cube.GC(2, 4) == cube.GC(5, 2))
                        {
                            if (cube.GC(6, 4) == cube.GC(6, 5) && cube.GC(6, 4) == cube.GC(3, 2))
                            {
                                if (cube.GC(4, 6) == cube.GC(4, 1))
                                {
                                    cube.Run("YT");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 7))
                                {
                                    cube.Run("YT");
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(7, 4))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 2);
                                    cube.Run("YT");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(1, 4))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 2);
                                    cube.Run("YT");
                                    goto endish;
                                }
                            }
                        }
                    }
                }
            } while (llr < 5);
// Solving end position V
            llr = 1;
            do
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                llr++;
                if (cube.GC(6, 4) == cube.GC(5, 2) && cube.GC(6, 4) == cube.GC(5, 6))
                {
                    if (cube.GC(4, 2) == cube.GC(3, 2) && cube.GC(4, 2) == cube.GC(3, 6))
                    {
                        if (cube.GC(2, 4) == cube.GC(2, 3) && cube.GC(2, 4) == cube.GC(6, 3))
                        {
                            if (cube.GC(4, 6) == cube.GC(2, 5) && cube.GC(4, 6) == cube.GC(6, 5))
                            {
                                if (cube.GC(4, 6) == cube.GC(7, 4))
                                {
                                    cube.Run("YV");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(1, 4))
                                {
                                    cube.Run("YV");
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 7))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 2);
                                    cube.Run("YV");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 1))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 2);
                                    cube.Run("YV");
                                    goto endish;
                                }
                            }
                        }
                    }
                }
            } while (llr < 5);
// Solving end position Y
            llr = 1;
            do
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                llr++;
                if (cube.GC(2, 4) == cube.GC(5, 2) && cube.GC(2, 4) == cube.GC(5, 6))
                {
                    if (cube.GC(4, 2) == cube.GC(3, 2) && cube.GC(4, 2) == cube.GC(3, 6))
                    {
                        if (cube.GC(4, 6) == cube.GC(2, 3) && cube.GC(4, 6) == cube.GC(6, 3))
                        {
                            if (cube.GC(6, 4) == cube.GC(6, 5) && cube.GC(6, 4) == cube.GC(2, 5))
                            {
                                if (cube.GC(4, 6) == cube.GC(1, 4))
                                {
                                    cube.Run("YY");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(7, 4))
                                {
                                    cube.Run("YY");
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 1))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 2);
                                    cube.Run("YY");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 7))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 2);
                                    cube.Run("YY");
                                    goto endish;
                                }
                            }
                        }
                    }
                }
            } while (llr < 5);
// Solving end position Z
            llr = 1;
            do
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                llr++;
                if (cube.GC(6, 4) == cube.GC(3, 6) && cube.GC(6, 4) == cube.GC(5, 6))
                {
                    if (cube.GC(2, 4) == cube.GC(3, 2) && cube.GC(2, 4) == cube.GC(5, 2))
                    {
                        if (cube.GC(4, 2) == cube.GC(2, 3) && cube.GC(4, 2) == cube.GC(2, 5))
                        {
                            if (cube.GC(4, 6) == cube.GC(6, 5) && cube.GC(4, 6) == cube.GC(6, 3))
                            {
                                if (cube.GC(4, 6) == cube.GC(7, 4))
                                {
                                    cube.Run("YZ");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(1, 4))
                                {
                                    cube.Run("YZ");
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 1))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 2);
                                    cube.Run("YZ");
                                    goto endish;
                                }
                                if (cube.GC(4, 6) == cube.GC(4, 7))
                                {
                                    cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                                    cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock, 2);
                                    cube.Run("YZ");
                                    goto endish;
                                }
                            }
                        }
                    }
                }
            } while (llr < 5);
            endish:
            cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);
            cube.TurnFront(RubiksCore.TurningDirection.SixoClock, 2);

        }
    }
}
