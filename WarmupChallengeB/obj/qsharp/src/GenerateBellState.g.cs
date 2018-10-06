#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.WarmupChallengeB", "GenerateBellState (qubits : Qubit[], index : Int) : ()", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs", 417L, 13L, 5L)]
[assembly: OperationDeclaration("Quantum.WarmupChallengeB", "TestState (index : Int) : (Result, Result)", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs", 1048L, 43L, 2L)]
#line hidden
namespace Quantum.WarmupChallengeB
{
    public class GenerateBellState : Operation<(QArray<Qubit>,Int64), QVoid>, ICallable
    {
        public GenerateBellState(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "GenerateBellState";
        String ICallable.FullName => "Quantum.WarmupChallengeB.GenerateBellState";
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64), QVoid> Body => (__in) =>
        {
            var (qubits,index) = __in;
#line 16 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
            if (((index == 1L) || (index == 3L)))
            {
                /// |0> to |1>
#line 19 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
                MicrosoftQuantumPrimitiveX.Apply(qubits[0L]);
            }

#line 22 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
            if (((index == 2L) || (index == 3L)))
            {
                /// |0> to |1>
#line 25 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
                MicrosoftQuantumPrimitiveX.Apply(qubits[1L]);
            }

            /// |0> to |+> or |1> to |->
#line 29 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
            MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
            /// Entangle
#line 32 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((qubits[0L], qubits[1L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qubits, Int64 index)
        {
            return __m__.Run<GenerateBellState, (QArray<Qubit>,Int64), QVoid>((qubits, index));
        }
    }

    public class TestState : Operation<Int64, (Result,Result)>, ICallable
    {
        public TestState(IOperationFactory m) : base(m)
        {
        }

        public class Out : QTuple<(Result,Result)>, IApplyData
        {
            public Out((Result,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TestState";
        String ICallable.FullName => "Quantum.WarmupChallengeB.TestState";
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

        protected ICallable<(QArray<Qubit>,Int64), QVoid> GenerateBellState
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

        public override Func<Int64, (Result,Result)> Body => (__in) =>
        {
            var index = __in;
#line 46 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
            var result1 = Result.Zero;
#line 47 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
            var result2 = Result.Zero;
            /// Allocate |00>
#line 50 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
            var qubits = Allocate.Apply(2L);
#line 52 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
            GenerateBellState.Apply((qubits, index));
#line 54 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
            AssertProb.Apply((new QArray<Pauli>()
            {Pauli.PauliZ}, new QArray<Qubit>()
            {qubits[0L]}, Result.Zero, 0.5D, "Error: Each state should be equally likely.", 1E-05D));
#line 55 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
            AssertProb.Apply((new QArray<Pauli>()
            {Pauli.PauliZ}, new QArray<Qubit>()
            {qubits[1L]}, Result.Zero, 0.5D, "Error: Each state should be equally likely.", 1E-05D));
            /// Collapse first qubit to |0> or |1>
#line 58 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
            result1 = M.Apply(qubits[0L]);
            /// Based on the Bell state, the value of the next qubit is determined
#line 61 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
            if (((index == 0L) || (index == 1L)))
            {
#line 63 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
                if ((result1 == Result.Zero))
                {
#line 64 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
                    AssertProb.Apply((new QArray<Pauli>()
                    {Pauli.PauliZ}, new QArray<Qubit>()
                    {qubits[1L]}, Result.One, 0D, "Error: 'One' state impossible.", 1E-05D));
                }

#line 66 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
                if ((result1 == Result.One))
                {
#line 67 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
                    AssertProb.Apply((new QArray<Pauli>()
                    {Pauli.PauliZ}, new QArray<Qubit>()
                    {qubits[1L]}, Result.Zero, 0D, "Error: 'Zero' state impossible.", 1E-05D));
                }
            }

            /// Based on the bell state, the value of the next qubit is determined
#line 71 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
            if (((index == 2L) || (index == 3L)))
            {
#line 73 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
                if ((result1 == Result.Zero))
                {
#line 74 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
                    AssertProb.Apply((new QArray<Pauli>()
                    {Pauli.PauliZ}, new QArray<Qubit>()
                    {qubits[1L]}, Result.Zero, 0D, "Error: 'Zero' state impossible.", 1E-05D));
                }

#line 76 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
                if ((result1 == Result.One))
                {
#line 77 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
                    AssertProb.Apply((new QArray<Pauli>()
                    {Pauli.PauliZ}, new QArray<Qubit>()
                    {qubits[1L]}, Result.One, 0D, "Error: 'One' state impossible.", 1E-05D));
                }
            }

            /// Collapse second qubit to |0> or |1>
#line 81 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
            result2 = M.Apply(qubits[1L]);
#line 83 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
            ResetAll.Apply(qubits);
#line hidden
            Release.Apply(qubits);
#line 86 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeB\\GenerateBellState.qs"
            return (result1, result2);
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.AssertProb = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,Double,String,Double)>>(typeof(Microsoft.Quantum.Primitive.AssertProb));
            this.GenerateBellState = this.Factory.Get<ICallable<(QArray<Qubit>,Int64), QVoid>>(typeof(Quantum.WarmupChallengeB.GenerateBellState));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut((Result,Result) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Result,Result)> Run(IOperationFactory __m__, Int64 index)
        {
            return __m__.Run<TestState, Int64, (Result,Result)>(index);
        }
    }
}