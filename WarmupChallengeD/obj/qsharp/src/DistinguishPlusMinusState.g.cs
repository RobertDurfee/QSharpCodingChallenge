#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.WarmupChallengeD", "DistinguishPlusMinusState (qubit : Qubit) : Int", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeD\\DistinguishPlusMinusState.qs", 253L, 9L, 5L)]
[assembly: OperationDeclaration("Quantum.WarmupChallengeD", "TestState (state : Int) : Int", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeD\\DistinguishPlusMinusState.qs", 605L, 26L, 2L)]
#line hidden
namespace Quantum.WarmupChallengeD
{
    public class DistinguishPlusMinusState : Operation<Qubit, Int64>, ICallable
    {
        public DistinguishPlusMinusState(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "DistinguishPlusMinusState";
        String ICallable.FullName => "Quantum.WarmupChallengeD.DistinguishPlusMinusState";
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

        public override Func<Qubit, Int64> Body => (__in) =>
        {
            var qubit = __in;
            /// |+> to |0> or |-> to |1>
#line 13 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeD\\DistinguishPlusMinusState.qs"
            MicrosoftQuantumPrimitiveH.Apply(qubit);
            /// Collapse to |0> or |1>
#line 16 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeD\\DistinguishPlusMinusState.qs"
            if ((M.Apply(qubit) == Result.Zero))
            {
#line 17 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeD\\DistinguishPlusMinusState.qs"
                return 1L;
            }

#line 19 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeD\\DistinguishPlusMinusState.qs"
            return -(1L);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Qubit qubit)
        {
            return __m__.Run<DistinguishPlusMinusState, Qubit, Int64>(qubit);
        }
    }

    public class TestState : Operation<Int64, Int64>, ICallable
    {
        public TestState(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestState";
        String ICallable.FullName => "Quantum.WarmupChallengeD.TestState";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,String)> Assert
        {
            get;
            set;
        }

        protected ICallable<Qubit, Int64> DistinguishPlusMinusState
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
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
            var state = __in;
#line 29 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeD\\DistinguishPlusMinusState.qs"
            var result = 0L;
            /// Allocate |0>
#line 32 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeD\\DistinguishPlusMinusState.qs"
            var qubits = Allocate.Apply(1L);
            /// If |+> state desired
#line 35 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeD\\DistinguishPlusMinusState.qs"
            if ((state == 1L))
            {
                /// |0> to |+>
#line 38 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeD\\DistinguishPlusMinusState.qs"
                MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 40 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeD\\DistinguishPlusMinusState.qs"
                result = DistinguishPlusMinusState.Apply(qubits[0L]);
#line 42 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeD\\DistinguishPlusMinusState.qs"
                Assert.Apply((new QArray<Pauli>()
                {Pauli.PauliZ}, new QArray<Qubit>()
                {qubits[0L]}, Result.Zero, "Error: Should be in 'Zero' state."));
            }

            /// If |-> state desired
#line 46 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeD\\DistinguishPlusMinusState.qs"
            if ((state == -(1L)))
            {
                /// |0> to |1>
#line 49 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeD\\DistinguishPlusMinusState.qs"
                MicrosoftQuantumPrimitiveX.Apply(qubits[0L]);
                /// |1> to |->
#line 52 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeD\\DistinguishPlusMinusState.qs"
                MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 54 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeD\\DistinguishPlusMinusState.qs"
                result = DistinguishPlusMinusState.Apply(qubits[0L]);
#line 56 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeD\\DistinguishPlusMinusState.qs"
                Assert.Apply((new QArray<Pauli>()
                {Pauli.PauliZ}, new QArray<Qubit>()
                {qubits[0L]}, Result.One, "Error: Should be in 'One' state."));
            }

#line 59 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeD\\DistinguishPlusMinusState.qs"
            ResetAll.Apply(qubits);
#line hidden
            Release.Apply(qubits);
#line 62 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeD\\DistinguishPlusMinusState.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Assert = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,String)>>(typeof(Microsoft.Quantum.Primitive.Assert));
            this.DistinguishPlusMinusState = this.Factory.Get<ICallable<Qubit, Int64>>(typeof(Quantum.WarmupChallengeD.DistinguishPlusMinusState));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 state)
        {
            return __m__.Run<TestState, Int64, Int64>(state);
        }
    }
}