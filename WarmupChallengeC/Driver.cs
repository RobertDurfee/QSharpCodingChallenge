using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;
using System.Linq;

namespace Quantum.WarmupChallengeC
{
    class Driver
    {
        static void Main(string[] args)
        {
            var sim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: true);

            foreach (var length in Enumerable.Range(1,8))
            {
                foreach (var index in Enumerable.Range(1,100))
                {
                    var results = TestState.Run(sim, length).Result;

                    Console.WriteLine($"{results}");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}