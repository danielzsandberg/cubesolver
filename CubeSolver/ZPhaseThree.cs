using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class ZPhaseThree : ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "ZPhaseThree"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "A guide to solve several positions"; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {
            MainWork(cube);
        }
        public void MainWork(RubiksCore.RubiksCube cube)
        {
            var vra = "";
            var vrb = "";
            var vrc = "";
            var vrd = "";
            var vre = "";
            var vrf = "";
            var vrg = "";
            var vrh = "";
            var vri = "";
            var vrj = "";
            var vrk = "";
            var vrl = "";
            var vrm = "";
            var vrn = "";
            var vro = "";
            var vrp = "";
            var vrq = "";
            var vrr = "";
            var vrs = "";
            var vrt = "";
            var vru = "";

            if (cube.GC(3, 2) == cube.GC(4, 4))
            {
                vra = "a";
            }

            if (cube.GC(5, 2) == cube.GC(4, 4))
            {
                vrb = "b";
            }

            if (cube.GC(2, 3) == cube.GC(4, 4))
            {
                vrc = "c";
            }

            if (cube.GC(3, 3) == cube.GC(4, 4))
            {
                vrd = "d";
            }

            if (cube.GC(4, 3) == cube.GC(4, 4))
            {
                vre = "e";
            }

            if (cube.GC(5, 3) == cube.GC(4, 4))
            {
                vrf = "f";
            }

            if (cube.GC(6, 3) == cube.GC(4, 4))
            {
                vrg = "g";
            }

            if (cube.GC(3, 4) == cube.GC(4, 4))
            {
                vrh = "h";
            }

            if (cube.GC(5, 4) == cube.GC(4, 4))
            {
                vri = "i";
            }

            if (cube.GC(2, 5) == cube.GC(4, 4))
            {
                vrj = "j";
            }

            if (cube.GC(3, 5) == cube.GC(4, 4))
            {
                vrk = "k";
            }

            if (cube.GC(4, 5) == cube.GC(4, 4))
            {
                vrl = "l";
            }

            if (cube.GC(5, 5) == cube.GC(4, 4))
            {
                vrm = "m";
            }

            if (cube.GC(6, 5) == cube.GC(4, 4))
            {
                vrn = "n";
            }

            if (cube.GC(3, 6) == cube.GC(4, 4))
            {
                vro = "o";
            }

            if (cube.GC(5, 6) == cube.GC(4, 4))
            {
                vrp = "p";
            }

            vrq = vra + vrb + vrc + vrd; // at Visual Studio use + instead of &
            vrr = vre + vrf + vrg + vrh;
            vrs = vri + vrj + vrk + vrl;
            vrt = vrm + vrn + vro + vrp;
            vru = vrq + vrr + vrs + vrt;

            //W01
            if (vru == "cgjn")
            {
                cube.Run("W01");
            }
            if (vru == "abop")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W01");
            }
            //W02
            if (vru == "agno")
            {
                cube.Run("W02");
            }
            if (vru == "abjn")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W02");
            }
            if (vru == "cgop")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W02");
            }
            if (vru == "bcjp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W02");
            }
            //'W03A
            if (vru == "bcmo")
            {
                cube.Run("W03A");
            }
            if (vru == "cfno")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W03A");
            }
            if (vru == "bckn")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W03A");
            }
            if (vru == "bdno")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W03A");
            }
            //'W03B
            if (vru == "agkp")
            {
                cube.Run("W03B");
            }
            if (vru == "agjm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W03B");
            }
            if (vru == "dgjp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W03B");
            }
            if (vru == "afjp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W03B");
            }
            //'W04
            if (vru == "dgmo")
            {
                cube.Run("W04");
            }
            if (vru == "afkn")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W04");
            }
            if (vru == "cfkp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W04");
            }
            if (vru == "bdjm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W04");
            }
            //'W05
            if (vru == "dfop")
            {
                cube.Run("W05");
            }
            if (vru == "dgkn")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W05");
            }
            if (vru == "cfjm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W05");
            }
            if (vru == "abkm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W05");
            }
            //'W06
            if (vru == "cgkm")
            {
                cube.Run("W06");
            }
            if (vru == "afmo")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W06");
            }
            if (vru == "bdkp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W06");
            }
            if (vru == "dfjn")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W06");
            }
            //'W07
            if (vru == "dfkm")
            {
                cube.Run("W07");
            }
            //'W08
            if (vru == "cegjln")
            {
                cube.Run("W08");
            }
            if (vru == "abhiop")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W08");
            }
            //'W09
            if (vru == "abelop")
            {
                cube.Run("W09");
            }
            if (vru == "cghijn")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W09");
            }
            //'W10A
            if (vru == "abejln")
            {
                cube.Run("W10A");
            }
            if (vru == "bchijp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W10A");
            }
            if (vru == "aghino")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W10A");
            }
            if (vru == "ceglop")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W10A");
            }
            //'W11
            if (vru == "aeglno")
            {
                cube.Run("W11");
            }
            if (vru == "abhijn")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W11");
            }
            if (vru == "cghiop")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W11");
            }
            if (vru == "bcejlp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W11");
            }
            //'W12A
            if (vru == "cghjln")
            {
                cube.Run("W12A");
            }
            if (vru == "abilop")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W12A");
            }
            if (vru == "abehop")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W12A");
            }
            if (vru == "cegijn")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W12A");
            }
            //'W12B
            if (vru == "cgijln")
            {
                cube.Run("W12B");
            }
            if (vru == "abeiop")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W12B");
            }
            if (vru == "abhlop")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W12B");
            }
            if (vru == "ceghjn")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W12B");
            }
            //'W13A
            if (vru == "aghlno")
            {
                cube.Run("W13A");
            }
            if (vru == "abijln")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W13A");
            }
            if (vru == "ceghop")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W13A");
            }
            if (vru == "bceijp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W13A");
            }
            //'13B
            if (vru == "aeghno")
            {
                cube.Run("W13B");
            }
            if (vru == "abhjln")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W13B");
            }
            if (vru == "cegiop")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W13B");
            }
            if (vru == "bcijlp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W13B");
            }
            //'W14A
            if (vru == "cghlop")
            {
                cube.Run("W14A");
            }
            if (vru == "agilno")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W14A");
            }
            if (vru == "bcehjp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W14A");
            }
            if (vru == "abeijn")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W14A");
            }
            //'W14B
            if (vru == "cgilop")
            {
                cube.Run("W14B");
            }
            if (vru == "aegino")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W14B");
            }
            if (vru == "bchjlp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W14B");
            }
            if (vru == "abehjn")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W14B");
            }
            //'W15A
            if (vru == "afijlp")
            {
                cube.Run("W15A");
            }
            if (vru == "degijp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W15A");
            }
            if (vru == "aghjlm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W15A");
            }
            if (vru == "aeghkp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W15A");
            }
            //'W15B
            if (vru == "bdhlno")
            {
                cube.Run("W15B");
            }
            if (vru == "bcikln")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W15B");
            }
            if (vru == "cefhno")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W15B");
            }
            if (vru == "bceimo")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W15B");
            }
            //'W16A
            if (vru == "cfilno")
            {
                cube.Run("W16A");
            }
            if (vru == "bdeino")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W16A");
            }
            if (vru == "bchlmo")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W16A");
            }
            if (vru == "bcehkn")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W16A");
            }
            //'W16B
            if (vru == "dghjlp")
            {
                cube.Run("W16B");
            }
            if (vru == "agiklp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W16B");
            }
            if (vru == "aefhjp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W16B");
            }
            if (vru == "aegijm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W16B");
            }
            //'W17A
            if (vru == "cfhlno")
            {
                cube.Run("W17A");
            }
            if (vru == "bdilno")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W17A");
            }
            if (vru == "bcehmo")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W17A");
            }
            if (vru == "bceikn")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W17A");
            }
            //'W17B
            if (vru == "dgijlp")
            {
                cube.Run("W17B");
            }
            if (vru == "aegikp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W17B");
            }
            if (vru == "afhjlp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W17B");
            }
            if (vru == "aeghjm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W17B");
            }
            //'W18A
            if (vru == "agijlm")
            {
                cube.Run("W18A");
            }
            if (vru == "aefijp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W18A");
            }
            if (vru == "aghklp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W18A");
            }
            if (vru == "deghjp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W18A");
            }
            //'W18B
            if (vru == "bchkln")
            {
                cube.Run("W18B");
            }
            if (vru == "bcilmo")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W18B");
            }
            if (vru == "bdehno")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W18B");
            }
            if (vru == "cefino")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W18B");
            }
            //'W19A
            if (vru == "afhijp")
            {
                cube.Run("W19A");
            }
            if (vru == "degjlp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W19A");
            }
            if (vru == "aegjlm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W19A");
            }
            if (vru == "aghikp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W19A");
            }
            //'W19B
            if (vru == "bdhino")
            {
                cube.Run("W19B");
            }
            if (vru == "bcekln")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W19B");
            }
            if (vru == "ceflno")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W19B");
            }
            if (vru == "bchimo")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W19B");
            }
            //'W20A
            if (vru == "cfhino")
            {
                cube.Run("W20A");
            }
            if (vru == "bdelno")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W20A");
            }
            if (vru == "bcelmo")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W20A");
            }
            if (vru == "bchikn")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W20A");
            }
            //'W20B
            if (vru == "dghijp")
            {
                cube.Run("W20B");
            }
            if (vru == "aegklp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W20B");
            }
            if (vru == "aefjlp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W20B");
            }
            if (vru == "aghijm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W20B");
            }
            //'W21A
            if (vru == "dfilop")
            {
                cube.Run("W21A");
            }
            if (vru == "degikn")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W21A");
            }
            if (vru == "cfhjlm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W21A");
            }
            if (vru == "abehkm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W21A");
            }
            //'W21B
            if (vru == "dfhlop")
            {
                cube.Run("W21B");
            }
            if (vru == "dgikln")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W21B");
            }
            if (vru == "cefhjm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W21B");
            }
            if (vru == "abeikm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W21B");
            }
            //'W22A
            if (vru == "dfijln")
            {
                cube.Run("W22A");
            }
            if (vru == "bdeikp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W22A");
            }
            if (vru == "afhlmo")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W22A");
            }
            if (vru == "ceghkm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W22A");
            }
            //'W22B
            if (vru == "dfhjln")
            {
                cube.Run("W22B");
            }
            if (vru == "bdiklp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W22B");
            }
            if (vru == "aefhmo")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W22B");
            }
            if (vru == "cegikm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W22B");
            }
            //'W23A
            if (vru == "afilmo")
            {
                cube.Run("W23A");
            }
            if (vru == "defijn")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W23A");
            }
            if (vru == "cghklm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W23A");
            }
            if (vru == "bdehkp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W23A");
            }
            //'W23B
            if (vru == "bdhklp")
            {
                cube.Run("W23B");
            }
            if (vru == "cgiklm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W23B");
            }
            if (vru == "defhjn")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W23B");
            }
            if (vru == "aefimo")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W23B");
            }
            //'W24
            if (vru == "bdijlm")
            {
                cube.Run("W24");
            }
            if (vru == "cefikp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W24");
            }
            if (vru == "afhkln")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W24");
            }
            if (vru == "deghmo")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W24");
            }
            //'W25A
            if (vru == "abhklm")
            {
                cube.Run("W25A");
            }
            if (vru == "cfijlm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W25A");
            }
            if (vru == "deghkn")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W25A");
            }
            if (vru == "defiop")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W25A");
            }
            //'W25B
            if (vru == "abiklm")
            {
                cube.Run("W25B");
            }
            if (vru == "cefijm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W25B");
            }
            if (vru == "dghkln")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W25B");
            }
            if (vru == "defhop")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W25B");
            }
            //'W26
            if (vru == "dgilmo")
            {
                cube.Run("W26");
            }
            if (vru == "aefikn")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W26");
            }
            if (vru == "cfhklp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W26");
            }
            if (vru == "bdehjm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W26");
            }
            //'W27
            if (vru == "cfhijm")
            {
                cube.Run("W27");
            }
            if (vru == "deflop")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W27");
            }
            if (vru == "abeklm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W27");
            }
            if (vru == "dghikn")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W27");
            }
            //'W28
            if (vru == "afhimo")
            {
                cube.Run("W28");
            }
            if (vru == "defjln")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W28");
            }
            if (vru == "cegklm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W28");
            }
            if (vru == "bdhikp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W28");
            }
            //'W29A
            if (vru == "cfhikp")
            {
                cube.Run("W29A");
            }
            if (vru == "deglmo")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W29A");
            }
            if (vru == "bdejlm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W29A");
            }
            if (vru == "afhikn")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W29A");
            }
            //'W29B
            if (vru == "dghimo")
            {
                cube.Run("W29B");
            }
            if (vru == "aefkln")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W29B");
            }
            if (vru == "cefklp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W29B");
            }
            if (vru == "bdhijm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W29B");
            }
            //'W30
            if (vru == "dfhijn")
            {
                cube.Run("W30");
            }
            if (vru == "bdeklp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W30");
            }
            if (vru == "aeflmo")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W30");
            }
            if (vru == "cghikm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W30");
            }
            //'W31
            if (vru == "dfhiop")
            {
                cube.Run("W31");
            }
            if (vru == "degkln")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W31");
            }
            if (vru == "cefjlm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W31");
            }
            if (vru == "abhikm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W31");
            }
            //'W32A
            if (vru == "cfiklp")
            {
                cube.Run("W32A");
            }
            if (vru == "degimo")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W32A");
            }
            if (vru == "bdhjlm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W32A");
            }
            if (vru == "aefhkn")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W32A");
            }
            //'W32B
            if (vru == "dghlmo")
            {
                cube.Run("W32B");
            }
            if (vru == "afikln")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W32B");
            }
            if (vru == "cefhkp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W32B");
            }
            if (vru == "bdeijm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W32B");
            }
            //'W33
            if (vru == "ceghijln")
            {
                cube.Run("W33");
            }
            if (vru == "abehilop")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W33");
            }
            //'W34
            if (vru == "ceghilop")
            {
                cube.Run("W34");
            }
            if (vru == "aeghilno")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W34");
            }
            if (vru == "bcehijlp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W34");
            }
            if (vru == "abehijln")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W34");
            }
            //'W35
            if (vru == "abehiklm")
            {
                cube.Run("W35");
            }
            if (vru == "cefhijlm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W35");
            }
            if (vru == "bdehikl") //wrong group of letters
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W35");
            }
            if (vru == "defhilop")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W35");
            }
            //'W36
            if (vru == "aefhilmo")
            {
                cube.Run("W36");
            }
            if (vru == "defhijln")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W36");
            }
            if (vru == "ceghiklm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W36");
            }
            if (vru == "bdehiklp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W36");
            }
            //'W37
            if (vru == "deghilmo")
            {
                cube.Run("W37");
            }
            if (vru == "aefhikln")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W37");
            }
            if (vru == "cefhiklp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W37");
            }
            if (vru == "bdehijlm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W37");
            }
            //'W38A
            if (vru == "bdehilno")
            {
                cube.Run("W38A");
            }
            if (vru == "bcehikln")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W38A");
            }
            if (vru == "cefhilno")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W38A");
            }
            if (vru == "bcehilmo")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W38A");
            }
            //'W38B
            if (vru == "aeghiklp")
            {
                cube.Run("W38B");
            }
            if (vru == "aeghijlm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W38B");
            }
            if (vru == "deghijlp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W38B");
            }
            if (vru == "aefhijlp")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W38B");
            }
            //'W39
            if (vru == "defhkm")
            {
                cube.Run("W39");
            }
            if (vru == "dfhklm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W39");
            }
            if (vru == "defikm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.NineoClock);
                cube.Run("W39");
            }
            if (vru == "dfiklm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.SixoClock);
                cube.Run("W39");
            }
            //'W40
            if (vru == "defklm")
            {
                cube.Run("W40");
            }
            if (vru == "dfhikm")
            {
                cube.TurnFront(RubiksCore.TurningDirection.ThreeoClock);
                cube.Run("W40");
            }
            cube.Run("ZPhaseUFourNewVersion");
        }
    }
}