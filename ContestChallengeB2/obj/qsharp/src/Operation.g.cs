#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.ContestChallengeB1", "Operation (qs : Qubit[]) : Int", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB2\\Operation.qs", 167L, 7L, 5L)]
[assembly: OperationDeclaration("Quantum.ContestChallengeB1", "TestOperation (N : Int) : Int", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB2\\Operation.qs", 464L, 26L, 2L)]
#line hidden
namespace Quantum.ContestChallengeB1
{
    public class Operation : Operation<QArray<Qubit>, Int64>, ICallable
    {
        public Operation(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Operation";
        String ICallable.FullName => "Quantum.ContestChallengeB1.Operation";
        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, Int64> Body => (__in) =>
        {
            var qs = __in;
#line 10 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB2\\Operation.qs"
            var ones = 0L;
#line 12 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB2\\Operation.qs"
            foreach (var k in new Range(0L, (qs.Count - 1L)))
            {
#line 14 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB2\\Operation.qs"
                if ((M.Apply(qs[k]) == Result.One))
                {
#line 15 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB2\\Operation.qs"
                    ones = (ones + 1L);
                }
            }

#line 18 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB2\\Operation.qs"
            if (((ones == 0L) || (ones > 1L)))
            {
#line 19 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB2\\Operation.qs"
                return 0L;
            }

#line 21 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB2\\Operation.qs"
            return 1L;
        }

        ;
        public override void Init()
        {
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<Operation, QArray<Qubit>, Int64>(qs);
        }
    }

    public class TestOperation : Operation<Int64, Int64>, ICallable
    {
        public TestOperation(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestOperation";
        String ICallable.FullName => "Quantum.ContestChallengeB1.TestOperation";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, Int64> Operation
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

        public override Func<Int64, Int64> Body => (__in) =>
        {
            var N = __in;
#line 29 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB2\\Operation.qs"
            var result = -(1L);
#line 31 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB2\\Operation.qs"
            var qubits = Allocate.Apply(N);
#line 33 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB2\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(qubits[2L]);
#line 34 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB2\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(qubits[3L]);
#line 36 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB2\\Operation.qs"
            result = Operation.Apply(qubits);
#line 38 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB2\\Operation.qs"
            ResetAll.Apply(qubits);
#line hidden
            Release.Apply(qubits);
#line 41 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB2\\Operation.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Operation = this.Factory.Get<ICallable<QArray<Qubit>, Int64>>(typeof(Quantum.ContestChallengeB1.Operation));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 N)
        {
            return __m__.Run<TestOperation, Int64, Int64>(N);
        }
    }
}