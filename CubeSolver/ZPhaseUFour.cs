using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class ZPhaseUFour : ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "ZPhaseUFour"; }
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

            int rpt = 1;
            
do
{
    rpt++;
    
                var lle = cube.GC(1, 4);
                var lup = cube.GC(4, 1);
                var lri = cube.GC(7, 4);
                var ldo = cube.GC(4, 7);

                int nmb = 0;

            startish:

                //Position Z 

                if (cube.GC(2, 3) == lle && cube.GC(2, 4) == lup && cube.GC(2, 5) == lle)
                {
                    if (cube.GC(6, 3) == lri && cube.GC(6, 4) == ldo && cube.GC(6, 5) == lri)
                    {
                        if (cube.GC(3, 2) == lup && cube.GC(4, 2) == lle && cube.GC(5, 2) == lup)
                        {
                            if (cube.GC(3, 6) == ldo && cube.GC(4, 6) == lri && cube.GC(5, 6) == ldo)
                            {
                                cube.Run("YZ");
                                goto endish;
                            }
                        }
                    }
                }


                //Position H 

                if (cube.GC(2, 3) == ldo && cube.GC(2, 4) == lup && cube.GC(2, 5) == ldo)
                {
                    if (cube.GC(6, 3) == lup && cube.GC(6, 4) == ldo && cube.GC(6, 5) == lup)
                    {
                        if (cube.GC(3, 2) == lle && cube.GC(4, 2) == lri && cube.GC(5, 2) == lle)
                        {
                            if (cube.GC(3, 6) == lri && cube.GC(4, 6) == lle && cube.GC(5, 6) == lri)
                            {
                                cube.Run("YH");
                                goto endish;
                            }
                        }
                    }
                }


                //Position E 

                if (cube.GC(2, 3) == lup && cube.GC(2, 4) == lle && cube.GC(2, 5) == ldo)
                {
                    if (cube.GC(6, 3) == lup && cube.GC(6, 4) == lri && cube.GC(6, 5) == ldo)
                    {
                        if (cube.GC(3, 2) == lri && cube.GC(4, 2) == lup && cube.GC(5, 2) == lle)
                        {
                            if (cube.GC(3, 6) == lri && cube.GC(4, 6) == ldo && cube.GC(5, 6) == lle)
                            {
                                cube.Run("YE");
                                goto endish;
                            }
                        }
                    }
                }


                //Position GAA 

                if (cube.GC(2, 3) == lup && cube.GC(2, 4) == lri && cube.GC(2, 5) == lle)
                {
                    if (cube.GC(6, 3) == ldo && cube.GC(6, 4) == lup && cube.GC(6, 5) == lle)
                    {
                        if (cube.GC(3, 2) == lri && cube.GC(4, 2) == lle && cube.GC(5, 2) == lri)
                        {
                            if (cube.GC(3, 6) == ldo && cube.GC(4, 6) == ldo && cube.GC(5, 6) == lup)
                            {
                                cube.Run("YGAA");
                                goto endish;
                            }
                        }
                    }
                }


                //Position GAB 

                if (cube.GC(2, 3) == lri && cube.GC(2, 4) == lup && cube.GC(2, 5) == lle)
                {
                    if (cube.GC(6, 3) == lup && cube.GC(6, 4) == lle && cube.GC(6, 5) == lup)
                    {
                        if (cube.GC(3, 2) == ldo && cube.GC(4, 2) == lri && cube.GC(5, 2) == lle)
                        {
                            if (cube.GC(3, 6) == ldo && cube.GC(4, 6) == ldo && cube.GC(5, 6) == lri)
                            {
                                cube.Run("YGAB");
                                goto endish;
                            }
                        }
                    }
                }


                //Position GBA 

                if (cube.GC(2, 3) == ldo && cube.GC(2, 4) == lup && cube.GC(2, 5) == lri)
                {
                    if (cube.GC(6, 3) == lup && cube.GC(6, 4) == lle && cube.GC(6, 5) == lri)
                    {
                        if (cube.GC(3, 2) == lle && cube.GC(4, 2) == lri && cube.GC(5, 2) == lle)
                        {
                            if (cube.GC(3, 6) == lup && cube.GC(4, 6) == ldo && cube.GC(5, 6) == ldo)
                            {
                                cube.Run("YGBA");
                                goto endish;
                            }
                        }
                    }
                }


                //Position GBB 

                if (cube.GC(2, 3) == lup && cube.GC(2, 4) == lri && cube.GC(2, 5) == lup)
                {
                    if (cube.GC(6, 3) == lle && cube.GC(6, 4) == lup && cube.GC(6, 5) == lri)
                    {
                        if (cube.GC(3, 2) == lri && cube.GC(4, 2) == lle && cube.GC(5, 2) == ldo)
                        {
                            if (cube.GC(3, 6) == lle && cube.GC(4, 6) == ldo && cube.GC(5, 6) == ldo)
                            {
                                cube.Run("YGBB");
                                goto endish;
                            }
                        }
                    }
                }


                //Position RA 

                if (cube.GC(2, 3) == lup && cube.GC(2, 4) == lle && cube.GC(2, 5) == lle)
                {
                    if (cube.GC(6, 3) == lup && cube.GC(6, 4) == ldo && cube.GC(6, 5) == lri)
                    {
                        if (cube.GC(3, 2) == lri && cube.GC(4, 2) == lup && cube.GC(5, 2) == lle)
                        {
                            if (cube.GC(3, 6) == ldo && cube.GC(4, 6) == lri && cube.GC(5, 6) == ldo)
                            {
                                cube.Run("YRA");
                                goto endish;
                            }
                        }
                    }
                }


                //Position RB 

                if (cube.GC(2, 3) == lup && cube.GC(2, 4) == ldo && cube.GC(2, 5) == lle)
                {
                    if (cube.GC(6, 3) == lup && cube.GC(6, 4) == lri && cube.GC(6, 5) == lri)
                    {
                        if (cube.GC(3, 2) == lri && cube.GC(4, 2) == lup && cube.GC(5, 2) == lle)
                        {
                            if (cube.GC(3, 6) == ldo && cube.GC(4, 6) == lle && cube.GC(5, 6) == ldo)
                            {
                                cube.Run("YRB");
                                goto endish;
                            }
                        }
                    }
                }


                //Position AA 

                if (cube.GC(2, 3) == ldo && cube.GC(2, 4) == lle && cube.GC(2, 5) == lri)
                {
                    if (cube.GC(6, 3) == lup && cube.GC(6, 4) == lri && cube.GC(6, 5) == lri)
                    {
                        if (cube.GC(3, 2) == lle && cube.GC(4, 2) == lup && cube.GC(5, 2) == lle)
                        {
                            if (cube.GC(3, 6) == lup && cube.GC(4, 6) == ldo && cube.GC(5, 6) == ldo)
                            {
                                cube.Run("AA");
                                goto endish;
                            }
                        }
                    }
                }


                //Position AB 

                if (cube.GC(2, 3) == lup && cube.GC(2, 4) == lle && cube.GC(2, 5) == lup)
                {
                    if (cube.GC(6, 3) == lle && cube.GC(6, 4) == lri && cube.GC(6, 5) == lri)
                    {
                        if (cube.GC(3, 2) == lri && cube.GC(4, 2) == lup && cube.GC(5, 2) == ldo)
                        {
                            if (cube.GC(3, 6) == lle && cube.GC(4, 6) == ldo && cube.GC(5, 6) == ldo)
                            {
                                cube.Run("YAB");
                                goto endish;
                            }
                        }
                    }
                }


                //Position V 

                if (cube.GC(2, 3) == lle && cube.GC(2, 4) == lle && cube.GC(2, 5) == lri)
                {
                    if (cube.GC(6, 3) == lle && cube.GC(6, 4) == ldo && cube.GC(6, 5) == lri)
                    {
                        if (cube.GC(3, 2) == lup && cube.GC(4, 2) == lup && cube.GC(5, 2) == ldo)
                        {
                            if (cube.GC(3, 6) == lup && cube.GC(4, 6) == lri && cube.GC(5, 6) == ldo)
                            {
                                cube.Run("YV");
                                goto endish;
                            }
                        }
                    }
                }


                //Position Y 

                if (cube.GC(2, 3) == lle && cube.GC(2, 4) == ldo && cube.GC(2, 5) == lri)
                {
                    if (cube.GC(6, 3) == lle && cube.GC(6, 4) == lri && cube.GC(6, 5) == lri)
                    {
                        if (cube.GC(3, 2) == lup && cube.GC(4, 2) == lup && cube.GC(5, 2) == ldo)
                        {
                            if (cube.GC(3, 6) == lup && cube.GC(4, 6) == lle && cube.GC(5, 6) == ldo)
                            {
                                cube.Run("YY");
                                goto endish;
                            }
                        }
                    }
                }


                //Position T 

                if (cube.GC(2, 3) == lup && cube.GC(2, 4) == lle && cube.GC(2, 5) == lle)
                {
                    if (cube.GC(6, 3) == lup && cube.GC(6, 4) == lri && cube.GC(6, 5) == lri)
                    {
                        if (cube.GC(3, 2) == lri && cube.GC(4, 2) == ldo && cube.GC(5, 2) == lle)
                        {
                            if (cube.GC(3, 6) == ldo && cube.GC(4, 6) == lup && cube.GC(5, 6) == ldo)
                            {
                                cube.Run("YT");
                                goto endish;
                            }
                        }
                    }
                }


                //Position DA 

                if (cube.GC(2, 3) == lle && cube.GC(2, 4) == lri && cube.GC(2, 5) == lle)
                {
                    if (cube.GC(6, 3) == lri && cube.GC(6, 4) == ldo && cube.GC(6, 5) == lri)
                    {
                        if (cube.GC(3, 2) == lup && cube.GC(4, 2) == lup && cube.GC(5, 2) == lup)
                        {
                            if (cube.GC(3, 6) == ldo && cube.GC(4, 6) == lle && cube.GC(5, 6) == ldo)
                            {
                                cube.Run("YDA");
                                goto endish;
                            }
                        }
                    }
                }


                //Position DB 

                if (cube.GC(2, 3) == lle && cube.GC(2, 4) == ldo && cube.GC(2, 5) == lle)
                {
                    if (cube.GC(6, 3) == lri && cube.GC(6, 4) == lle && cube.GC(6, 5) == lri)
                    {
                        if (cube.GC(3, 2) == lup && cube.GC(4, 2) == lup && cube.GC(5, 2) == lup)
                        {
                            if (cube.GC(3, 6) == ldo && cube.GC(4, 6) == lri && cube.GC(5, 6) == ldo)
                            {
                                cube.Run("YDB");
                                goto endish;
                            }
                        }
                    }
                }


                //Position F 

                if (cube.GC(2, 3) == lle && cube.GC(2, 4) == lle && cube.GC(2, 5) == lle)
                {
                    if (cube.GC(6, 3) == ldo && cube.GC(6, 4) == lri && cube.GC(6, 5) == lup)
                    {
                        if (cube.GC(3, 2) == lup && cube.GC(4, 2) == ldo && cube.GC(5, 2) == lri)
                        {
                            if (cube.GC(3, 6) == ldo && cube.GC(4, 6) == lup && cube.GC(5, 6) == lri)
                            {
                                cube.Run("YF");
                                goto endish;
                            }
                        }
                    }
                }


                //Position JA 

                if (cube.GC(2, 3) == lle && cube.GC(2, 4) == lle && cube.GC(2, 5) == lle)
                {
                    if (cube.GC(6, 3) == ldo && cube.GC(6, 4) == ldo && cube.GC(6, 5) == lup)
                    {
                        if (cube.GC(3, 2) == lup && cube.GC(4, 2) == lup && cube.GC(5, 2) == lri)
                        {
                            if (cube.GC(3, 6) == ldo && cube.GC(4, 6) == lri && cube.GC(5, 6) == lri)
                            {
                                cube.Run("YJA");
                                goto endish;
                            }
                        }
                    }
                }


                //Position JB 

                if (cube.GC(2, 3) == ldo && cube.GC(2, 4) == ldo && cube.GC(2, 5) == lup)
                {
                    if (cube.GC(6, 3) == lri && cube.GC(6, 4) == lri && cube.GC(6, 5) == lri)
                    {
                        if (cube.GC(3, 2) == lle && cube.GC(4, 2) == lup && cube.GC(5, 2) == lup)
                        {
                            if (cube.GC(3, 6) == lle && cube.GC(4, 6) == lle && cube.GC(5, 6) == ldo)
                            {
                                cube.Run("YJB");
                                goto endish;
                            }
                        }
                    }
                }


                //Position NA 

                if (cube.GC(2, 3) == lri && cube.GC(2, 4) == lri && cube.GC(2, 5) == lle)
                {
                    if (cube.GC(6, 3) == lri && cube.GC(6, 4) == lle && cube.GC(6, 5) == lle)
                    {
                        if (cube.GC(3, 2) == ldo && cube.GC(4, 2) == lup && cube.GC(5, 2) == lup)
                        {
                            if (cube.GC(3, 6) == ldo && cube.GC(4, 6) == ldo && cube.GC(5, 6) == lup)
                            {
                                cube.Run("YNA");
                                goto endish;
                            }
                        }
                    }
                }


                //Position NB 

                if (cube.GC(2, 3) == lle && cube.GC(2, 4) == lri && cube.GC(2, 5) == lri)
                {
                    if (cube.GC(6, 3) == lle && cube.GC(6, 4) == lle && cube.GC(6, 5) == lri)
                    {
                        if (cube.GC(3, 2) == lup && cube.GC(4, 2) == lup && cube.GC(5, 2) == ldo)
                        {
                            if (cube.GC(3, 6) == lup && cube.GC(4, 6) == ldo && cube.GC(5, 6) == ldo)
                            {
                                cube.Run("YNB");
                                goto endish;
                            }
                        }
                    }
                }


                //Position SOLVED 

                if (cube.GC(2, 3) == lle && cube.GC(2, 4) == lle && cube.GC(2, 5) == lle)
                {
                    if (cube.GC(6, 3) == lri && cube.GC(6, 4) == lri && cube.GC(6, 5) == lri)
                    {
                        if (cube.GC(3, 2) == lup && cube.GC(4, 2) == lup && cube.GC(5, 2) == lup)
                        {
                            if (cube.GC(3, 6) == ldo && cube.GC(4, 6) == ldo && cube.GC(5, 6) == ldo)
                            {
                                goto endish;
                            }
                        }
                    }
                }

                nmb++;
                if (nmb == 5)
                {
                    goto endish;
                }
                cube.TurnUp(RubiksCore.TurningDirection.ThreeoClock);
                goto startish;

} while (rpt < 5);




endish:
int des = 1;                     
        }
                
        
    }
}
