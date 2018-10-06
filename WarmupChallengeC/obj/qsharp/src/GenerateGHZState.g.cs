#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.WarmupChallengeC", "GenerateGHZState (qubits : Qubit[]) : ()", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeC\\GenerateGHZState.qs", 269L, 9L, 5L)]
[assembly: OperationDeclaration("Quantum.WarmupChallengeC", "TestState (length : Int) : Result[]", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeC\\GenerateGHZState.qs", 628L, 26L, 2L)]
#line hidden
namespace Quantum.WarmupChallengeC
{
    public class GenerateGHZState : Operation<QArray<Qubit>, QVoid>, ICallable
    {
        public GenerateGHZState(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GenerateGHZState";
        String ICallable.FullName => "Quantum.WarmupChallengeC.GenerateGHZState";
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

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qubits = __in;
            /// |0> to |+>
#line 13 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeC\\GenerateGHZState.qs"
            MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 15 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeC\\GenerateGHZState.qs"
            foreach (var k in new Range(0L, (qubits.Count - 2L)))
            {
                /// |+> to 1/sqrt(2) (|0> + |1>)
#line 18 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeC\\GenerateGHZState.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((qubits[k], qubits[(k + 1L)]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qubits)
        {
            return __m__.Run<GenerateGHZState, QArray<Qubit>, QVoid>(qubits);
        }
    }

    public class TestState : Operation<Int64, QArray<Result>>, ICallable
    {
        public TestState(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestState";
        String ICallable.FullName => "Quantum.WarmupChallengeC.TestState";
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

        protected ICallable<QArray<Qubit>, QVoid> GenerateGHZState
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

        public override Func<Int64, QArray<Result>> Body => (__in) =>
        {
            var length = __in;
#line 29 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeC\\GenerateGHZState.qs"
            var results = new QArray<Result>(length);
            /// Allocate |0..0>
#line 32 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeC\\GenerateGHZState.qs"
            var qubits = Allocate.Apply(length);
            /// Create 1/sqrt(2) (|0..0> + |1..1>) state
#line 35 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeC\\GenerateGHZState.qs"
            GenerateGHZState.Apply(qubits);
#line 37 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeC\\GenerateGHZState.qs"
            foreach (var index in new Range(0L, (length - 1L)))
            {
#line 38 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeC\\GenerateGHZState.qs"
                AssertProb.Apply((new QArray<Pauli>()
                {Pauli.PauliZ}, new QArray<Qubit>()
                {qubits[index]}, Result.One, 0.5D, "Error: Each state should be equally likely.", 1E-05D));
            }

            /// Collapse to |0..0>
#line 41 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeC\\GenerateGHZState.qs"
            results[0L] = M.Apply(qubits[0L]);
            /// Based on the value of the first qubit, the value of the next qubits are determined
#line 44 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeC\\GenerateGHZState.qs"
            foreach (var index in new Range(1L, (length - 1L)))
            {
#line 46 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeC\\GenerateGHZState.qs"
                if ((results[0L] == Result.Zero))
                {
#line 47 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeC\\GenerateGHZState.qs"
                    AssertProb.Apply((new QArray<Pauli>()
                    {Pauli.PauliZ}, new QArray<Qubit>()
                    {qubits[index]}, Result.One, 0D, "Error: 'One' state impossible.", 1E-05D));
                }

#line 49 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeC\\GenerateGHZState.qs"
                if ((results[0L] == Result.One))
                {
#line 50 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeC\\GenerateGHZState.qs"
                    AssertProb.Apply((new QArray<Pauli>()
                    {Pauli.PauliZ}, new QArray<Qubit>()
                    {qubits[index]}, Result.Zero, 0D, "Error: 'Zero' state impossible.", 1E-05D));
                }

                /// Collapse to |0> or |1>
#line 53 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeC\\GenerateGHZState.qs"
                results[index] = M.Apply(qubits[index]);
            }

#line 56 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeC\\GenerateGHZState.qs"
            ResetAll.Apply(qubits);
#line hidden
            Release.Apply(qubits);
#line 59 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeC\\GenerateGHZState.qs"
            return results;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.AssertProb = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,Double,String,Double)>>(typeof(Microsoft.Quantum.Primitive.AssertProb));
            this.GenerateGHZState = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Quantum.WarmupChallengeC.GenerateGHZState));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(QArray<Result> data) => data;
        public static System.Threading.Tasks.Task<QArray<Result>> Run(IOperationFactory __m__, Int64 length)
        {
            return __m__.Run<TestState, Int64, QArray<Result>>(length);
        }
    }
}