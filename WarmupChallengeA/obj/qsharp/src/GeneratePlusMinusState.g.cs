#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.WarmupChallengeA", "GenerateState (qubit : Qubit, sign : Int) : ()", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeA\\GeneratePlusMinusState.qs", 243L, 9L, 5L)]
[assembly: OperationDeclaration("Quantum.WarmupChallengeA", "TestState (sign : Int) : Result", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeA\\GeneratePlusMinusState.qs", 545L, 26L, 2L)]
#line hidden
namespace Quantum.WarmupChallengeA
{
    public class GenerateState : Operation<(Qubit,Int64), QVoid>, ICallable
    {
        public GenerateState(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Int64)>, IApplyData
        {
            public In((Qubit,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                }
            }
        }

        String ICallable.Name => "GenerateState";
        String ICallable.FullName => "Quantum.WarmupChallengeA.GenerateState";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Qubit,Int64), QVoid> Body => (__in) =>
        {
            var (qubit,sign) = __in;
#line 12 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeA\\GeneratePlusMinusState.qs"
            if ((sign == -(1L)))
            {
                /// Switch to |1>
#line 15 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeA\\GeneratePlusMinusState.qs"
                MicrosoftQuantumPrimitiveX.Apply(qubit);
            }

            /// Switch |0> to |+> or |1> to |->
#line 19 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeA\\GeneratePlusMinusState.qs"
            MicrosoftQuantumPrimitiveH.Apply(qubit);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Qubit,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit qubit, Int64 sign)
        {
            return __m__.Run<GenerateState, (Qubit,Int64), QVoid>((qubit, sign));
        }
    }

    public class TestState : Operation<Int64, Result>, ICallable
    {
        public TestState(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestState";
        String ICallable.FullName => "Quantum.WarmupChallengeA.TestState";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,Double,String,Double)> AssertProb
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Int64), QVoid> GenerateState
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

        public override Func<Int64, Result> Body => (__in) =>
        {
            var sign = __in;
#line 29 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeA\\GeneratePlusMinusState.qs"
            var result = Result.Zero;
            /// Allocate |0>
#line 32 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeA\\GeneratePlusMinusState.qs"
            var qubits = Allocate.Apply(1L);
            /// Switch |0> to |+> or |->
#line 35 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeA\\GeneratePlusMinusState.qs"
            GenerateState.Apply((qubits[0L], sign));
#line 37 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeA\\GeneratePlusMinusState.qs"
            AssertProb.Apply((new QArray<Pauli>()
            {Pauli.PauliZ}, new QArray<Qubit>()
            {qubits[0L]}, Result.Zero, 0.5D, "Error: Incorrect state", 1E-05D));
            /// Switch |+> to |0> or |-> to |1>
#line 40 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeA\\GeneratePlusMinusState.qs"
            MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 42 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeA\\GeneratePlusMinusState.qs"
            if ((sign == 1L))
            {
#line 43 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeA\\GeneratePlusMinusState.qs"
                AssertProb.Apply((new QArray<Pauli>()
                {Pauli.PauliZ}, new QArray<Qubit>()
                {qubits[0L]}, Result.Zero, 1D, "Error: Incorrect state", 1E-05D));
            }

#line 45 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeA\\GeneratePlusMinusState.qs"
            if ((sign == -(1L)))
            {
#line 46 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeA\\GeneratePlusMinusState.qs"
                AssertProb.Apply((new QArray<Pauli>()
                {Pauli.PauliZ}, new QArray<Qubit>()
                {qubits[0L]}, Result.One, 1D, "Error: Incorrect state", 1E-05D));
            }

            /// Actually measure qubit to collapse to |0> or |1>
#line 49 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeA\\GeneratePlusMinusState.qs"
            result = M.Apply(qubits[0L]);
#line 51 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeA\\GeneratePlusMinusState.qs"
            ResetAll.Apply(qubits);
#line hidden
            Release.Apply(qubits);
#line 54 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeA\\GeneratePlusMinusState.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.AssertProb = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,Double,String,Double)>>(typeof(Microsoft.Quantum.Primitive.AssertProb));
            this.GenerateState = this.Factory.Get<ICallable<(Qubit,Int64), QVoid>>(typeof(Quantum.WarmupChallengeA.GenerateState));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__, Int64 sign)
        {
            return __m__.Run<TestState, Int64, Result>(sign);
        }
    }
}