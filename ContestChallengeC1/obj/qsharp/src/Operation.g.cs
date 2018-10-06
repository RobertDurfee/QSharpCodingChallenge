#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.ContestChallengeC1", "Operation (q : Qubit) : Int", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC1\\Operation.qs", 206L, 8L, 5L)]
[assembly: OperationDeclaration("Quantum.ContestChallengeC1", "TestOperation (state : Int) : Int", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC1\\Operation.qs", 449L, 26L, 2L)]
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
        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRy
        {
            get;
            set;
        }

        public override Func<Qubit, Int64> Body => (__in) =>
        {
            var q = __in;
#line 11 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC1\\Operation.qs"
            MicrosoftQuantumPrimitiveRy.Apply(((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance) / 4D), q));
#line 13 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC1\\Operation.qs"
            var m = M.Apply(q);
#line 15 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC1\\Operation.qs"
            if ((m == Result.One))
            {
#line 16 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC1\\Operation.qs"
                return 1L;
            }

#line 18 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC1\\Operation.qs"
            if ((m == Result.Zero))
            {
#line 19 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC1\\Operation.qs"
                return 0L;
            }

#line 21 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC1\\Operation.qs"
            return -(1L);
        }

        ;
        public override void Init()
        {
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.MicrosoftQuantumPrimitiveRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.Ry));
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
#line 29 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC1\\Operation.qs"
            var result = -(1L);
#line 31 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC1\\Operation.qs"
            var qubits = Allocate.Apply(1L);
#line 33 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC1\\Operation.qs"
            if ((state == 1L))
            {
#line 34 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC1\\Operation.qs"
                MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
            }

#line 36 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC1\\Operation.qs"
            result = Operation.Apply(qubits[0L]);
#line 38 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC1\\Operation.qs"
            ResetAll.Apply(qubits);
#line hidden
            Release.Apply(qubits);
#line 41 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC1\\Operation.qs"
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