using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;
using System.Linq;

namespace Quantum.WarmupChallengeA
{
    class Driver
    {
        static void Main(string[] args)
        {
            var sim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: true);
            
            var ones = Enumerable.Range(0, 1000).Where(w =>
                TestState.Run(sim, 1).Result == Result.One).Count();

            Console.WriteLine($"Ones: {ones}/1000");
            Console.Read();
        }
    }
}