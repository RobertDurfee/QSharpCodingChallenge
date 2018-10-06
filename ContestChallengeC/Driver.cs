using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Quantum.ContestChallengeC
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

                int int0 = rnd.Next(0, 256);
                int int1 = rnd.Next(0, 256);

                string bitString0 = Convert.ToString(int0, 2);
                string bitString1 = Convert.ToString(int1, 2);

                int length = Math.Max(bitString0.Length, bitString1.Length);

                bitString0 = LeadingZeros(bitString0, length);
                bitString1 = LeadingZeros(bitString1, length);

                Console.WriteLine($"{bitString0} {bitString1}");

                QArray<bool> bitArray0 = new QArray<bool>();
                QArray<bool> bitArray1 = new QArray<bool>();

                foreach (char bit in bitString0.ToCharArray().Reverse())
                    bitArray0.Add(bit == '1');

                foreach (char bit in bitString1.ToCharArray().Reverse())
                    bitArray1.Add(bit == '1');

                for (int i = 0; i < 2048; i++)
                {
                    long result = TestOperation.Run(sim, bitArray0, bitArray1).Result;

                    if (results.ContainsKey(result))
                        results[result]++;
                    else
                        results[result] = 1;
                }

                foreach (KeyValuePair<long, int> result in results)
                    Console.Write($"{LeadingZeros(Convert.ToString(result.Key, 2), bitString0.Length)} ");

                Console.WriteLine("\n");
            }

            Console.Read();
        }
    }
}