using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;
using System.Collections.Generic;

namespace Quantum.ContestChallengeC1
{
    class Driver
    {
        static void Main(string[] args)
        {
            var sim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: true);

            Dictionary<bool, int> results = new Dictionary<bool, int>()
            {
                { false, 0 },
                { true, 0 }
            };

            Dictionary<int, int> states = new Dictionary<int, int>()
            {
                { 0, 0 },
                { 1, 0 }
            };

            Random rnd = new Random();

            for (int i = 0; i < 10000; i++)
            {
                int state = rnd.Next(0, 2);

                states[state]++;

                long result = TestOperation.Run(sim, state).Result;

                results[state == result]++;
            }

            foreach (KeyValuePair<int, int> state in states)
                Console.WriteLine($"{state.Key} - {state.Value / 100m}");

            Console.WriteLine();

            foreach (KeyValuePair<bool, int> result in results)
                Console.WriteLine($"{result.Key} - {result.Value / 100m}");

            Console.Read();
        }
    }
}