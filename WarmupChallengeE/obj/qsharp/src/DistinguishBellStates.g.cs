#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.WarmupChallengeE", "DistinguishBellStates (qubits : Qubit[]) : Int", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs", 409L, 13L, 5L)]
[assembly: OperationDeclaration("Quantum.WarmupChallengeE", "GenerateBellState (qubits : Qubit[], index : Int) : ()", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs", 1160L, 54L, 5L)]
[assembly: OperationDeclaration("Quantum.WarmupChallengeE", "TestState () : Int[]", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs", 1529L, 78L, 2L)]
#line hidden
namespace Quantum.WarmupChallengeE
{
    public class DistinguishBellStates : Operation<QArray<Qubit>, Int64>, ICallable
    {
        public DistinguishBellStates(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "DistinguishBellStates";
        String ICallable.FullName => "Quantum.WarmupChallengeE.DistinguishBellStates";
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

        public override Func<QArray<Qubit>, Int64> Body => (__in) =>
        {
            var qubits = __in;
#line 16 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((qubits[0L], qubits[1L]));
#line 18 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
            MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 20 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
            var res1 = M.Apply(qubits[0L]);
#line 21 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
            var res2 = M.Apply(qubits[1L]);
#line 23 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
            if (((res1 == Result.Zero) && (res2 == Result.Zero)))
            {
#line 25 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
                return 0L;
            }

#line 28 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
            if (((res1 == Result.One) && (res2 == Result.Zero)))
            {
#line 30 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
                return 1L;
            }

#line 33 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
            if (((res1 == Result.Zero) && (res2 == Result.One)))
            {
#line 35 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
                return 2L;
            }

#line 38 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
            if (((res1 == Result.One) && (res2 == Result.One)))
            {
#line 40 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
                return 3L;
            }

#line 43 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
            return -(1L);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Qubit> qubits)
        {
            return __m__.Run<DistinguishBellStates, QArray<Qubit>, Int64>(qubits);
        }
    }

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
        String ICallable.FullName => "Quantum.WarmupChallengeE.GenerateBellState";
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
#line 57 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
            if (((index == 1L) || (index == 3L)))
            {
                /// |0> to |1>
#line 60 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
                MicrosoftQuantumPrimitiveX.Apply(qubits[0L]);
            }

#line 63 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
            if (((index == 2L) || (index == 3L)))
            {
                /// |0> to |1>
#line 66 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
                MicrosoftQuantumPrimitiveX.Apply(qubits[1L]);
            }

            /// |0> to |+> or |1> to |->
#line 70 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
            MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
            /// Entangle
#line 73 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
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

    public class TestState : Operation<QVoid, QArray<Int64>>, ICallable
    {
        public TestState(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestState";
        String ICallable.FullName => "Quantum.WarmupChallengeE.TestState";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, Int64> DistinguishBellStates
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,Int64), QVoid> GenerateBellState
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

        public override Func<QVoid, QArray<Int64>> Body => (__in) =>
        {
#line 81 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
            var results = new QArray<Int64>(4L);
#line 83 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
            foreach (var index in new Range(0L, 3L))
            {
#line 85 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
                var qubits = Allocate.Apply(2L);
#line 87 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
                GenerateBellState.Apply((qubits, index));
#line 89 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
                results[index] = DistinguishBellStates.Apply(qubits);
#line 91 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
                ResetAll.Apply(qubits);
#line hidden
                Release.Apply(qubits);
            }

#line 95 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeE\\DistinguishBellStates.qs"
            return results;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.DistinguishBellStates = this.Factory.Get<ICallable<QArray<Qubit>, Int64>>(typeof(Quantum.WarmupChallengeE.DistinguishBellStates));
            this.GenerateBellState = this.Factory.Get<ICallable<(QArray<Qubit>,Int64), QVoid>>(typeof(Quantum.WarmupChallengeE.GenerateBellState));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__)
        {
            return __m__.Run<TestState, QVoid, QArray<Int64>>(QVoid.Instance);
        }
    }
}