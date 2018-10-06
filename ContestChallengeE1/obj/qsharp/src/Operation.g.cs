#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.ContestChallengeE1", "Operation (N : Int, Uf : ((Qubit[], Qubit) => ())) : Int[]", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE1\\Operation.qs", 195L, 7L, 5L)]
#line hidden
namespace Quantum.ContestChallengeE1
{
    public class Operation : Operation<(Int64,ICallable), QArray<Int64>>, ICallable
    {
        public Operation(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable)>, IApplyData
        {
            public In((Int64,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "Operation";
        String ICallable.FullName => "Quantum.ContestChallengeE1.Operation";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable), QArray<Int64>> Body => (__in) =>
        {
            var (N,Uf) = __in;
#line 10 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE1\\Operation.qs"
            var result = new QArray<Int64>(N);
#line 12 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE1\\Operation.qs"
            var x = Allocate.Apply(N);
#line 14 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE1\\Operation.qs"
            foreach (var k in new Range(0L, (N - 1L)))
            {
#line 15 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE1\\Operation.qs"
                MicrosoftQuantumPrimitiveH.Apply(x[k]);
            }

#line 17 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE1\\Operation.qs"
            var y = Allocate.Apply(1L);
#line 19 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE1\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(y[0L]);
#line 20 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE1\\Operation.qs"
            MicrosoftQuantumPrimitiveH.Apply(y[0L]);
#line 22 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE1\\Operation.qs"
            Uf.Apply((x, y[0L]));
#line 24 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE1\\Operation.qs"
            foreach (var k in new Range(0L, (N - 1L)))
            {
#line 26 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE1\\Operation.qs"
                MicrosoftQuantumPrimitiveH.Apply(x[k]);
#line 28 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE1\\Operation.qs"
                var m = M.Apply(x[k]);
#line 30 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE1\\Operation.qs"
                if ((m == Result.Zero))
                {
#line 31 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE1\\Operation.qs"
                    result[k] = 0L;
                }

#line 33 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE1\\Operation.qs"
                if ((m == Result.One))
                {
#line 34 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE1\\Operation.qs"
                    result[k] = 1L;
                }
            }

#line 36 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE1\\Operation.qs"
            ResetAll.Apply(y);
#line hidden
            Release.Apply(y);
#line 38 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE1\\Operation.qs"
            ResetAll.Apply(x);
#line hidden
            Release.Apply(x);
#line 41 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE1\\Operation.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Int64,ICallable) data) => new In(data);
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, Int64 N, ICallable Uf)
        {
            return __m__.Run<Operation, (Int64,ICallable), QArray<Int64>>((N, Uf));
        }
    }
}