using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;
using System.Linq;

namespace Quantum.WarmupChallengeD
{
    class Driver
    {
        static void Main(string[] args)
        {
            var sim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: true);

            foreach (var state in new int[] { 1, -1 })
            {
                foreach (var iteration in Enumerable.Range(1, 100))
                {
                    var result = TestState.Run(sim, state).Result;

                    Console.WriteLine($"Input: {state} Output: {result}.");
                }

                Console.WriteLine();
            }

            Console.Read();
        }
    }
}