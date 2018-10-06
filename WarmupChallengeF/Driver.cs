using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;

namespace Quantum.WarmupChallengeF
{
    class Driver
    {
        static void Main(string[] args)
        {
            var sim = new QuantumSimulator(throwOnReleasingQubitsNotInZeroState: true);

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                int length = rnd.Next(1, 10);

                QArray<bool> bits0 = new QArray<bool>(length);
                QArray<bool> bits1 = new QArray<bool>(length);

                for (int index = 0; index < length; index++)
                {
                    bits0[index] = rnd.Next(0, 2) == 0 ? false : true;

                    if (rnd.Next(0, 2) == 0 ? false : true)
                    {
                        bits1[index] = bits0[index];
                    }
                    else
                    {
                        bits1[index] = rnd.Next(0, 2) == 0 ? false : true;
                    }
                }

                int which = rnd.Next(0, 2);
                var result = TestState.Run(sim, length, bits0, bits1, which).Result;

                Console.WriteLine($"0: {bits0}");
                Console.WriteLine($"1: {bits1}");
                Console.WriteLine($"Input: {which} Output: {result}.");
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}