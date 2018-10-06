#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.ContestChallengeC1", "Operation (q : Qubit) : Int", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC2\\Operation.qs", 206L, 8L, 5L)]
[assembly: OperationDeclaration("Quantum.ContestChallengeC1", "TestOperation (state : Int) : Int", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC2\\Operation.qs", 770L, 40L, 2L)]
#line hidden
namespace Quantum.ContestChallengeC1
{
    public class Operation : Operation<Qubit, Int64>, ICallable
    {
        public Operation(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Operation";
        String ICallable.FullName => "Quantum.ContestChallengeC1.Operation";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
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

        public override Func<Qubit, Int64> Body => (__in) =>
        {
            var q = __in;
#line 11 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC2\\Operation.qs"
            var result = -(1L);
#line 13 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC2\\Operation.qs"
            var ancilla = Allocate.Apply(2L);
#line 15 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC2\\Operation.qs"
            MicrosoftQuantumPrimitiveH.Apply(ancilla[0L]);
#line 16 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC2\\Operation.qs"
            MicrosoftQuantumPrimitiveH.Apply(ancilla[1L]);
#line 18 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC2\\Operation.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((q, ancilla[0L]));
#line 20 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC2\\Operation.qs"
            var m0 = M.Apply(ancilla[0L]);
#line 21 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC2\\Operation.qs"
            var m1 = M.Apply(ancilla[1L]);
#line 23 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC2\\Operation.qs"
            if ((((m0 == Result.Zero) && (m1 == Result.One)) || ((m0 == Result.Zero) && (m1 == Result.One))))
            {
#line 24 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC2\\Operation.qs"
                result = 2L;
            }

#line 26 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC2\\Operation.qs"
            if (((m0 == Result.Zero) && (m1 == Result.Zero)))
            {
#line 27 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC2\\Operation.qs"
                result = 0L;
            }

#line 29 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC2\\Operation.qs"
            if (((m0 == Result.One) && (m1 == Result.One)))
            {
#line 30 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC2\\Operation.qs"
                result = 1L;
            }

#line 32 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC2\\Operation.qs"
            ResetAll.Apply(ancilla);
#line hidden
            Release.Apply(ancilla);
#line 35 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC2\\Operation.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<Operation, Qubit, Int64>(q);
        }
    }

    public class TestOperation : Operation<Int64, Int64>, ICallable
    {
        public TestOperation(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestOperation";
        String ICallable.FullName => "Quantum.ContestChallengeC1.TestOperation";
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

        protected ICallable<Qubit, Int64> Operation
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

        public override Func<Int64, Int64> Body => (__in) =>
        {
            var state = __in;
#line 43 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC2\\Operation.qs"
            var result = -(1L);
#line 45 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC2\\Operation.qs"
            var qubits = Allocate.Apply(1L);
#line 47 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC2\\Operation.qs"
            if ((state == 1L))
            {
#line 48 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC2\\Operation.qs"
                MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
            }

#line 50 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC2\\Operation.qs"
            result = Operation.Apply(qubits[0L]);
#line 52 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC2\\Operation.qs"
            ResetAll.Apply(qubits);
#line hidden
            Release.Apply(qubits);
#line 55 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC2\\Operation.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Operation = this.Factory.Get<ICallable<Qubit, Int64>>(typeof(Quantum.ContestChallengeC1.Operation));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 state)
        {
            return __m__.Run<TestOperation, Int64, Int64>(state);
        }
    }
}