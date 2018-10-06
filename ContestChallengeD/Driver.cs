using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;
using System.Collections.Generic;

namespace Quantum.ContestChallengeD
{
    class Driver
    {
        static string LeadingZeros(string input, int length) => new string('0', length - input.Length) + input;

        static void Main(string[] args)
        {
            var sim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: true);

            Random rnd = new Random();
            
            for (int j = 0; j < 10; j++)
            {
                Dictionary<long, int> results = new Dictionary<long, int>();

                int k = 2;// rnd.Next(0, 5);

                for (int i = 0; i < 2048; i++)
                {
                    long result = TestOperation.Run(sim, (int)Math.Pow(2, k)).Result;

                    if (results.ContainsKey(result))
                        results[result]++;
                    else
                        results[result] = 1;
                }

                foreach (KeyValuePair<long, int> result in results)
                    Console.WriteLine($"{LeadingZeros(Convert.ToString(result.Key, 2), (int)Math.Pow(2, k))} - {result.Value / 2048m}");

                Console.WriteLine();
            }

            Console.Read();
        }
    }
}