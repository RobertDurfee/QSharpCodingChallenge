#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.ContestChallengeD1", "Operation (x : Qubit[], y : Qubit, b : Int[]) : ()", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeD1\\Operation.qs", 187L, 7L, 5L)]
[assembly: OperationDeclaration("Quantum.ContestChallengeD1", "TestOperation (xIs : Int[], b : Int[]) : Result", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeD1\\Operation.qs", 404L, 21L, 2L)]
#line hidden
namespace Quantum.ContestChallengeD1
{
    public class Operation : Operation<(QArray<Qubit>,Qubit,QArray<Int64>), QVoid>, ICallable
    {
        public Operation(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Qubit,QArray<Int64>)>, IApplyData
        {
            public In((QArray<Qubit>,Qubit,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Operation";
        String ICallable.FullName => "Quantum.ContestChallengeD1.Operation";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Qubit,QArray<Int64>), QVoid> Body => (__in) =>
        {
            var (x,y,b) = __in;
#line 10 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeD1\\Operation.qs"
            foreach (var k in new Range(0L, (x.Count - 1L)))
            {
#line 12 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeD1\\Operation.qs"
                if ((b[k] == 1L))
                {
#line 14 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeD1\\Operation.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((x[k], y));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Qubit,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, Qubit y, QArray<Int64> b)
        {
            return __m__.Run<Operation, (QArray<Qubit>,Qubit,QArray<Int64>), QVoid>((x, y, b));
        }
    }

    public class TestOperation : Operation<(QArray<Int64>,QArray<Int64>), Result>, ICallable
    {
        public TestOperation(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,QArray<Int64>)>, IApplyData
        {
            public In((QArray<Int64>,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TestOperation";
        String ICallable.FullName => "Quantum.ContestChallengeD1.TestOperation";
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

        protected ICallable<(QArray<Qubit>,Qubit,QArray<Int64>), QVoid> Operation
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

        public override Func<(QArray<Int64>,QArray<Int64>), Result> Body => (__in) =>
        {
            var (xIs,b) = __in;
#line 24 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeD1\\Operation.qs"
            var result = Result.Zero;
#line 26 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeD1\\Operation.qs"
            var xQs = Allocate.Apply(xIs.Count);
#line 28 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeD1\\Operation.qs"
            var y = Allocate.Apply(1L);
#line 30 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeD1\\Operation.qs"
            foreach (var k in new Range(0L, (xIs.Count - 1L)))
            {
#line 31 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeD1\\Operation.qs"
                if ((xIs[k] == 1L))
                {
#line 32 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeD1\\Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(xQs[k]);
                }
            }

#line 34 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeD1\\Operation.qs"
            Operation.Apply((xQs, y[0L], b));
#line 36 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeD1\\Operation.qs"
            result = M.Apply(y[0L]);
#line 38 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeD1\\Operation.qs"
            ResetAll.Apply(y);
#line hidden
            Release.Apply(y);
#line 40 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeD1\\Operation.qs"
            ResetAll.Apply(xQs);
#line hidden
            Release.Apply(xQs);
#line 43 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeD1\\Operation.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Operation = this.Factory.Get<ICallable<(QArray<Qubit>,Qubit,QArray<Int64>), QVoid>>(typeof(Quantum.ContestChallengeD1.Operation));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Int64>,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__, QArray<Int64> xIs, QArray<Int64> b)
        {
            return __m__.Run<TestOperation, (QArray<Int64>,QArray<Int64>), Result>((xIs, b));
        }
    }
}