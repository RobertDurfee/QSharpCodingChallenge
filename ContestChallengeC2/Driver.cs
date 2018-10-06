using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;
using System.Collections.Generic;

namespace Quantum.ContestChallengeC1
{
    class Driver
    {
        enum Validities
        {
            Correct,
            Incorrect,
            Inconclusive
        }

        static void Main(string[] args)
        {
            var sim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: true);

            Dictionary<Validities, int> results = new Dictionary<Validities, int>()
            {
                { Validities.Correct, 0 },
                { Validities.Incorrect, 0 },
                { Validities.Inconclusive, 0 }
            };
            
            Random rnd = new Random();

            for (int i = 0; i < 1000; i++)
            {
                int state = rnd.Next(0, 2);
                
                long result = TestOperation.Run(sim, state).Result;

                if (result == 2)
                    results[Validities.Inconclusive]++;
                else
                {
                    if (result == state)
                        results[Validities.Correct]++;
                    else
                        results[Validities.Incorrect]++;
                }

            }

            foreach (KeyValuePair<Validities, int> result in results)
                Console.WriteLine($"{result.Key} - {result.Value / 10m}");

            Console.Read();
        }
    }
}