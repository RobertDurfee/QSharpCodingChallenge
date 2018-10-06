using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;

namespace Quantum.ContestChallengeE2
{
    class Driver
    {
        static void Main(string[] args)
        {
            var sim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: true);

            for (int i = 0; i < 10; i++)
                Console.WriteLine($"{TestOperation.Run(sim).Result}");

            Console.Read();
        }
    }
}