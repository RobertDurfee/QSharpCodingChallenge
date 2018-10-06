using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Quantum.WarmupChallengeB
{
    class Driver
    {
        static void Main(string[] args)
        {
            var sim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: true);

            Dictionary<int, string> bellStates = new Dictionary<int, string>()
            {
                { 1, "1/sqrt(2) (|00> + |11>)" },
                { 2, "1/sqrt(2) (|00> - |11>)" },
                { 3, "1/sqrt(2) (|01> + |10>)" },
                { 4, "1/sqrt(2) (|01> - |10>)" }
            };

            Dictionary<ValueTuple<Result, Result>, int> resultIndex = new Dictionary<ValueTuple<Result, Result>, int>()
            {
                { (Result.Zero, Result.Zero), 0 },
                { (Result.Zero, Result.One), 1 },
                { (Result.One, Result.Zero), 2},
                { (Result.One, Result.One), 3 }
            };

            foreach (var bellState in Enumerable.Range(1, 4))
            {
                int[] count = new int[4];

                foreach (var index in Enumerable.Range(1, 1000))
                {
                    var result = TestState.Run(sim, bellState).Result;

                    count[resultIndex[result]]++;
                }

                Console.WriteLine($"Bell State {bellStates[bellState]}:");
                Console.WriteLine($"(Zero, Zero): {count[0]}");
                Console.WriteLine($"(Zero, One): {count[1]}");
                Console.WriteLine($"(One, Zero): {count[2]}");
                Console.WriteLine($"(One, One): {count[3]}");
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}