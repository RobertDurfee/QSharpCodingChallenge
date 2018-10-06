#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.ContestChallengeE2", "Uf (x : Qubit[], y : Qubit) : ()", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs", 170L, 7L, 5L)]
[assembly: OperationDeclaration("Quantum.ContestChallengeE2", "Operation (N : Int) : Int[]", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs", 491L, 30L, 5L)]
[assembly: OperationDeclaration("Quantum.ContestChallengeE2", "TestOperation () : Int[]", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs", 1053L, 69L, 2L)]
#line hidden
namespace Quantum.ContestChallengeE2
{
    public class Uf : Operation<(QArray<Qubit>,Qubit), QVoid>, ICallable
    {
        public Uf(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Uf";
        String ICallable.FullName => "Quantum.ContestChallengeE2.Uf";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Qubit), QVoid> Body => (__in) =>
        {
            var (x,y) = __in;
#line 10 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
            var b = new QArray<Int64>(0L, 1L, 1L, 0L, 1L, 0L, 1L, 1L);
#line 12 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
            foreach (var k in new Range(0L, (x.Count - 1L)))
            {
#line 14 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
                if ((b[k] == 1L))
                {
#line 15 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((x[k], y));
                }

#line 17 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
                if ((b[k] == 0L))
                {
#line 19 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(x[k]);
#line 21 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((x[k], y));
#line 23 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(x[k]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, Qubit y)
        {
            return __m__.Run<Uf, (QArray<Qubit>,Qubit), QVoid>((x, y));
        }
    }

    public class Operation : Operation<Int64, QArray<Int64>>, ICallable
    {
        public Operation(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Operation";
        String ICallable.FullName => "Quantum.ContestChallengeE2.Operation";
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

        protected ICallable<(QArray<Qubit>,Qubit), QVoid> Uf
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<Int64, QArray<Int64>> Body => (__in) =>
        {
            var N = __in;
#line 33 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
            var result = new QArray<Int64>(N);
#line 35 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
            var x = Allocate.Apply(N);
#line 37 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
            foreach (var k in new Range(0L, (N - 1L)))
            {
#line 38 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
                MicrosoftQuantumPrimitiveH.Apply(x[k]);
            }

#line 40 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
            var y = Allocate.Apply(1L);
#line 42 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(y[0L]);
#line 43 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
            MicrosoftQuantumPrimitiveH.Apply(y[0L]);
#line 45 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
            Uf.Apply((x, y[0L]));
#line 47 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
            foreach (var k in new Range(0L, (N - 1L)))
            {
#line 49 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
                MicrosoftQuantumPrimitiveH.Apply(x[k]);
#line 51 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
                var m = M.Apply(x[k]);
#line 53 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
                if ((m == Result.Zero))
                {
#line 54 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
                    result[k] = 0L;
                }

#line 56 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
                if ((m == Result.One))
                {
#line 57 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
                    result[k] = 1L;
                }
            }

#line 59 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
            ResetAll.Apply(y);
#line hidden
            Release.Apply(y);
#line 61 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
            ResetAll.Apply(x);
#line hidden
            Release.Apply(x);
#line 64 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
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
            this.Uf = this.Factory.Get<ICallable<(QArray<Qubit>,Qubit), QVoid>>(typeof(Quantum.ContestChallengeE2.Uf));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, Int64 N)
        {
            return __m__.Run<Operation, Int64, QArray<Int64>>(N);
        }
    }

    public class TestOperation : Operation<QVoid, QArray<Int64>>, ICallable
    {
        public TestOperation(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestOperation";
        String ICallable.FullName => "Quantum.ContestChallengeE2.TestOperation";
        protected ICallable<Int64, QArray<Int64>> Operation
        {
            get;
            set;
        }

        public override Func<QVoid, QArray<Int64>> Body => (__in) =>
        {
#line 72 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeE2\\Operation.qs"
            return Operation.Apply(8L);
        }

        ;
        public override void Init()
        {
            this.Operation = this.Factory.Get<ICallable<Int64, QArray<Int64>>>(typeof(Quantum.ContestChallengeE2.Operation));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__)
        {
            return __m__.Run<TestOperation, QVoid, QArray<Int64>>(QVoid.Instance);
        }
    }
}