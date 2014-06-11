using RubiksApp.RubiksAlgorithmToolset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMove
{
    public class ExampleMoves : ICubeSolvingAlgorithm
    {
        public string AlgorithmName
        {
            get { return "Example Moves"; }
        }

        public string Author
        {
            get { return "Daniel Sandberg"; }
        }

        public string Description
        {
            get { return "An example using new GetColor function."; }
        }

        public void Solve(RubiksCore.RubiksCube cube)
        {
            if(cube.GC(3,8) == cube.GC(4,7))
            {
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);
            }
            else if(cube.GC(3,7) == RubiksCore.RubiksColor.Green)
            {
                cube.TurnUp();
            }
            else
            {
                PhaseOne(cube);
            }
        }

        public void PhaseOne(RubiksCore.RubiksCube cube)
        {
            if (cube.GC(3, 8) == cube.GC(4, 7))
            {
                cube.TurnBack(RubiksCore.TurningDirection.NineoClock);

                //Using other algorithms...
                W01 W01 = new W01();
                W01.Solve(cube);
                
                //also using other algorithms...
                cube.Run("W01");
            }
            else if (cube.GC(3, 7) == RubiksCore.RubiksColor.Green)
            {
                cube.TurnUp();
            }
            else
            {
                cube.TurnLeft();

                
            }

            var vra = "";
        }
    }
}
