using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;
using System.Collections.Generic;

namespace Quantum.ContestChallengeB3
{
    class Driver
    {
        static string LeadingZeros(string input, int length) => new string('0', length - input.Length) + input;

        static void Main(string[] args)
        {
            var sim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: true);

            for (int state = 0; state < 4; state++)
            {
                //Dictionary<long, int> results = new Dictionary<long, int>();

                //for (int i = 0; i < 2048; i++)
                //{
                //    long result = TestGenerate.Run(sim, state).Result;

                //    if (results.ContainsKey(result))
                //        results[result]++;
                //    else
                //        results[result] = 1;
                //}

                //Console.WriteLine($"{state}:");

                //foreach (KeyValuePair<long, int> result in results)
                //    Console.WriteLine($"  {LeadingZeros(Convert.ToString(result.Key, 2), 2)} - {result.Value / 2048m}");

                //Console.WriteLine();

                Console.WriteLine($"{state} - {TestOperation.Run(sim, state).Result}");
            }

            Console.Read();
        }
    }
}