#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.ContestChallengeB", "Operation (qs : Qubit[], bits : Bool[]) : ()", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB\\Operation.qs", 180L, 7L, 5L)]
[assembly: OperationDeclaration("Quantum.ContestChallengeB", "TestOperation (bits : Bool[]) : Int", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB\\Operation.qs", 399L, 21L, 2L)]
#line hidden
namespace Quantum.ContestChallengeB
{
    public class Operation : Operation<(QArray<Qubit>,QArray<Boolean>), QVoid>, ICallable
    {
        public Operation(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Boolean>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "Operation";
        String ICallable.FullName => "Quantum.ContestChallengeB.Operation";
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

        public override Func<(QArray<Qubit>,QArray<Boolean>), QVoid> Body => (__in) =>
        {
            var (qs,bits) = __in;
#line 10 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB\\Operation.qs"
            MicrosoftQuantumPrimitiveH.Apply(qs[0L]);
#line 12 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB\\Operation.qs"
            foreach (var k in new Range(1L, (qs.Count - 1L)))
            {
#line 14 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB\\Operation.qs"
                if ((bits[k] == true))
                {
#line 15 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB\\Operation.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((qs[0L], qs[k]));
                }
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

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Boolean>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs, QArray<Boolean> bits)
        {
            return __m__.Run<Operation, (QArray<Qubit>,QArray<Boolean>), QVoid>((qs, bits));
        }
    }

    public class TestOperation : Operation<QArray<Boolean>, Int64>, ICallable
    {
        public TestOperation(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestOperation";
        String ICallable.FullName => "Quantum.ContestChallengeB.TestOperation";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,QArray<Boolean>), QVoid> Operation
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

        protected ICallable<QArray<Result>, Int64> MicrosoftQuantumCanonResultAsInt
        {
            get;
            set;
        }

        public override Func<QArray<Boolean>, Int64> Body => (__in) =>
        {
            var bits = __in;
#line 24 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB\\Operation.qs"
            var results = new QArray<Result>(5L);
#line 26 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB\\Operation.qs"
            var qubits = Allocate.Apply(bits.Count);
#line 28 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB\\Operation.qs"
            Operation.Apply((qubits, bits));
#line 30 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB\\Operation.qs"
            foreach (var k in new Range(0L, (bits.Count - 1L)))
            {
#line 31 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB\\Operation.qs"
                results[k] = M.Apply(qubits[k]);
            }

#line 33 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB\\Operation.qs"
            ResetAll.Apply(qubits);
#line hidden
            Release.Apply(qubits);
#line 36 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB\\Operation.qs"
            return MicrosoftQuantumCanonResultAsInt.Apply(results);
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Operation = this.Factory.Get<ICallable<(QArray<Qubit>,QArray<Boolean>), QVoid>>(typeof(Quantum.ContestChallengeB.Operation));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumCanonResultAsInt = this.Factory.Get<ICallable<QArray<Result>, Int64>>(typeof(Microsoft.Quantum.Canon.ResultAsInt));
        }

        public override IApplyData __dataIn(QArray<Boolean> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Boolean> bits)
        {
            return __m__.Run<TestOperation, QArray<Boolean>, Int64>(bits);
        }
    }
}