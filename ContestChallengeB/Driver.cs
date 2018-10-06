using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;
using System.Collections.Generic;

namespace Quantum.ContestChallengeB
{
    class Driver
    {
        static void Main(string[] args)
        {
            Dictionary<long, int> results = new Dictionary<long, int>();

            var sim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: true);

            QArray<bool> bits = new QArray<bool>() { true, false, true, true, true };

            for (int i = 0; i < 2048; i++)
            {
                long result = TestOperation.Run(sim, bits).Result;

                if (results.ContainsKey(result))
                    results[result]++;
                else
                    results[result] = 1;
            }

            foreach (KeyValuePair<long, int> result in results)
            {
                Console.WriteLine($"{Convert.ToString(result.Key, 2), 3} - {result.Value}");
            }

            Console.Read();
        }
    }
}