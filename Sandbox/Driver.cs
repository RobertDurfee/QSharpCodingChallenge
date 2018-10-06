using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Quantum.Sandbox
{
    class Driver
    {
        static void Main(string[] args)
        {
            var sim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: true);

            foreach (var state in new Result[] { Result.Zero, Result.One })
            {
                foreach (var index in Enumerable.Range(1, 10))
                {
                    var (pauliX, pauliY, pauliZ) = TestState.Run(sim, state).Result;
                    Console.WriteLine($"X: {pauliX}, Y: {pauliY}, Z: {pauliZ}");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}