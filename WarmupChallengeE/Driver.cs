using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;
using System.Linq;

namespace Quantum.WarmupChallengeE
{
    class Driver
    {
        static void Main(string[] args)
        {
            var sim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: true);

            foreach (var index in Enumerable.Range(1, 100))
            {
                var result = TestState.Run(sim).Result;

                Console.WriteLine($"{result}");
            }

            Console.Read();
        }
    }
}