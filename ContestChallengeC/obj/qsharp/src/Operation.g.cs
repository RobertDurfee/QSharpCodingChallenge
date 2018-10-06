#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.ContestChallengeC", "Operation (qs : Qubit[], bits0 : Bool[], bits1 : Bool[]) : ()", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs", 381L, 18L, 5L)]
[assembly: OperationDeclaration("Quantum.ContestChallengeC", "TestOperation (bits0 : Bool[], bits1 : Bool[]) : Int", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs", 953L, 51L, 2L)]
[assembly: FunctionDeclaration("Quantum.ContestChallengeC", "FindFirstDiff (bits0 : Bool[], bits1 : Bool[]) : Int", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs", 126L, 6L, 11L)]
#line hidden
namespace Quantum.ContestChallengeC
{
    public class FindFirstDiff : Operation<(QArray<Boolean>,QArray<Boolean>), Int64>, ICallable
    {
        public FindFirstDiff(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Boolean>,QArray<Boolean>)>, IApplyData
        {
            public In((QArray<Boolean>,QArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "FindFirstDiff";
        String ICallable.FullName => "Quantum.ContestChallengeC.FindFirstDiff";
        public override Func<(QArray<Boolean>,QArray<Boolean>), Int64> Body => (__in) =>
        {
            var (bits0,bits1) = __in;
#line 8 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs"
            foreach (var k in new Range(0L, (bits0.Count - 1L)))
            {
#line 10 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs"
                if ((bits0[k] != bits1[k]))
                {
#line 11 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs"
                    return k;
                }
            }

#line 14 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs"
            return -(1L);
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((QArray<Boolean>,QArray<Boolean>) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Boolean> bits0, QArray<Boolean> bits1)
        {
            return __m__.Run<FindFirstDiff, (QArray<Boolean>,QArray<Boolean>), Int64>((bits0, bits1));
        }
    }

    public class Operation : Operation<(QArray<Qubit>,QArray<Boolean>,QArray<Boolean>), QVoid>, ICallable
    {
        public Operation(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Boolean>,QArray<Boolean>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Boolean>,QArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "Operation";
        String ICallable.FullName => "Quantum.ContestChallengeC.Operation";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected ICallable<(QArray<Boolean>,QArray<Boolean>), Int64> FindFirstDiff
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

        public override Func<(QArray<Qubit>,QArray<Boolean>,QArray<Boolean>), QVoid> Body => (__in) =>
        {
            var (qs,bits0,bits1) = __in;
#line 21 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs"
            var firstDiff = FindFirstDiff.Apply((bits0, bits1));
#line 23 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs"
            if (bits0[firstDiff])
            {
#line 25 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs"
                foreach (var k in new Range(0L, (qs.Count - 1L)))
                {
#line 27 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs"
                    if ((bits1[k] == true))
                    {
#line 28 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs"
                        MicrosoftQuantumPrimitiveX.Apply(qs[k]);
                    }
                }
            }
            else
            {
#line 33 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs"
                foreach (var k in new Range(0L, (qs.Count - 1L)))
                {
#line 35 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs"
                    if ((bits0[k] == true))
                    {
#line 36 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs"
                        MicrosoftQuantumPrimitiveX.Apply(qs[k]);
                    }
                }
            }

#line 40 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs"
            MicrosoftQuantumPrimitiveH.Apply(qs[firstDiff]);
#line 42 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs"
            foreach (var k in new Range((firstDiff + 1L), (qs.Count - 1L)))
            {
#line 44 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs"
                if ((bits0[k] != bits1[k]))
                {
#line 45 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((qs[firstDiff], qs[k]));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.FindFirstDiff = this.Factory.Get<ICallable<(QArray<Boolean>,QArray<Boolean>), Int64>>(typeof(Quantum.ContestChallengeC.FindFirstDiff));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Boolean>,QArray<Boolean>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs, QArray<Boolean> bits0, QArray<Boolean> bits1)
        {
            return __m__.Run<Operation, (QArray<Qubit>,QArray<Boolean>,QArray<Boolean>), QVoid>((qs, bits0, bits1));
        }
    }

    public class TestOperation : Operation<(QArray<Boolean>,QArray<Boolean>), Int64>, ICallable
    {
        public TestOperation(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Boolean>,QArray<Boolean>)>, IApplyData
        {
            public In((QArray<Boolean>,QArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TestOperation";
        String ICallable.FullName => "Quantum.ContestChallengeC.TestOperation";
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

        protected ICallable<(QArray<Qubit>,QArray<Boolean>,QArray<Boolean>), QVoid> Operation
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

        public override Func<(QArray<Boolean>,QArray<Boolean>), Int64> Body => (__in) =>
        {
            var (bits0,bits1) = __in;
#line 54 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs"
            var results = new QArray<Result>(bits0.Count);
#line 56 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs"
            var qubits = Allocate.Apply(bits0.Count);
#line 58 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs"
            Operation.Apply((qubits, bits0, bits1));
#line 60 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs"
            foreach (var k in new Range(0L, (bits0.Count - 1L)))
            {
#line 61 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs"
                results[k] = M.Apply(qubits[k]);
            }

#line 63 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs"
            ResetAll.Apply(qubits);
#line hidden
            Release.Apply(qubits);
#line 66 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeC\\Operation.qs"
            return MicrosoftQuantumCanonResultAsInt.Apply(results);
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Operation = this.Factory.Get<ICallable<(QArray<Qubit>,QArray<Boolean>,QArray<Boolean>), QVoid>>(typeof(Quantum.ContestChallengeC.Operation));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumCanonResultAsInt = this.Factory.Get<ICallable<QArray<Result>, Int64>>(typeof(Microsoft.Quantum.Canon.ResultAsInt));
        }

        public override IApplyData __dataIn((QArray<Boolean>,QArray<Boolean>) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Boolean> bits0, QArray<Boolean> bits1)
        {
            return __m__.Run<TestOperation, (QArray<Boolean>,QArray<Boolean>), Int64>((bits0, bits1));
        }
    }
}