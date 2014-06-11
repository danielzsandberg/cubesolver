using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class ZPhasePTwo1Aux : ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "ZPhasePTwo1Aux"; }
        }

        public string Author
        {
            get { return "Walter Praça"; }
        }

        public string Description
        {
            get { return "Auxiliar Code"; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {
            cube.Run("ZPhasePTwo1");
        }
    }
}
