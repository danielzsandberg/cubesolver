using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class ZFren2Esquerda //: ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "ZFren2Esquerda"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "Front Two-layer Go Left"; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {
            cube.TurnFront(RubiksCore.TurningDirection.NineoClock, 1);

        }
    }
}
