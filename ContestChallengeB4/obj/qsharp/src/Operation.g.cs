#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.ContestChallengeB3", "Generate (qs : Qubit[], state : Int) : ()", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs", 214L, 8L, 2L)]
[assembly: OperationDeclaration("Quantum.ContestChallengeB3", "Operation (qs : Qubit[]) : Int", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs", 875L, 61L, 5L)]
[assembly: OperationDeclaration("Quantum.ContestChallengeB3", "TestGenerate (state : Int) : Int", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs", 1345L, 92L, 2L)]
[assembly: OperationDeclaration("Quantum.ContestChallengeB3", "TestOperation (state : Int) : Int", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs", 1664L, 112L, 2L)]
#line hidden
namespace Quantum.ContestChallengeB3
{
    public class Generate : Operation<(QArray<Qubit>,Int64), QVoid>, ICallable
    {
        public Generate(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "Generate";
        String ICallable.FullName => "Quantum.ContestChallengeB3.Generate";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRx
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64), QVoid> Body => (__in) =>
        {
            var (qs,state) = __in;
#line 11 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            if ((state == 0L))
            {
#line 13 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
                MicrosoftQuantumPrimitiveX.Apply(qs[0L]);
#line 14 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
                MicrosoftQuantumPrimitiveX.Apply(qs[1L]);
#line 16 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
                MicrosoftQuantumPrimitiveRx.Apply((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance), qs[0L]));
#line 18 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
                MicrosoftQuantumPrimitiveH.Apply(qs[0L]);
#line 19 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
                MicrosoftQuantumPrimitiveH.Apply(qs[1L]);
#line 21 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
                MicrosoftQuantumPrimitiveZ.Controlled.Apply((new QArray<Qubit>()
                {qs[0L]}, qs[1L]));
            }

#line 24 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            if ((state == 1L))
            {
#line 26 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
                MicrosoftQuantumPrimitiveX.Apply(qs[1L]);
#line 28 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
                MicrosoftQuantumPrimitiveRx.Apply((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance), qs[0L]));
#line 30 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
                MicrosoftQuantumPrimitiveH.Apply(qs[0L]);
#line 31 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
                MicrosoftQuantumPrimitiveH.Apply(qs[1L]);
#line 33 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
                MicrosoftQuantumPrimitiveZ.Controlled.Apply((new QArray<Qubit>()
                {qs[0L]}, qs[1L]));
            }

#line 36 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            if ((state == 2L))
            {
#line 38 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
                MicrosoftQuantumPrimitiveX.Apply(qs[0L]);
#line 40 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
                MicrosoftQuantumPrimitiveRx.Apply((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance), qs[0L]));
#line 42 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
                MicrosoftQuantumPrimitiveH.Apply(qs[0L]);
#line 43 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
                MicrosoftQuantumPrimitiveH.Apply(qs[1L]);
#line 45 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
                MicrosoftQuantumPrimitiveZ.Controlled.Apply((new QArray<Qubit>()
                {qs[0L]}, qs[1L]));
            }

#line 48 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            if ((state == 3L))
            {
#line 50 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
                MicrosoftQuantumPrimitiveRx.Apply((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance), qs[0L]));
#line 52 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
                MicrosoftQuantumPrimitiveH.Apply(qs[0L]);
#line 53 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
                MicrosoftQuantumPrimitiveH.Apply(qs[1L]);
#line 55 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
                MicrosoftQuantumPrimitiveZ.Controlled.Apply((new QArray<Qubit>()
                {qs[0L]}, qs[1L]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.MicrosoftQuantumPrimitiveRx = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.Rx));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs, Int64 state)
        {
            return __m__.Run<Generate, (QArray<Qubit>,Int64), QVoid>((qs, state));
        }
    }

    public class Operation : Operation<QArray<Qubit>, Int64>, ICallable
    {
        public Operation(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Operation";
        String ICallable.FullName => "Quantum.ContestChallengeB3.Operation";
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, Int64> Body => (__in) =>
        {
            var qs = __in;
#line 64 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            MicrosoftQuantumPrimitiveZ.Controlled.Apply((new QArray<Qubit>()
            {qs[1L]}, qs[0L]));
#line 66 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            MicrosoftQuantumPrimitiveH.Apply(qs[0L]);
#line 67 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            MicrosoftQuantumPrimitiveH.Apply(qs[1L]);
#line 69 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(qs[0L]);
#line 70 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(qs[1L]);
#line 72 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            var m0 = M.Apply(qs[0L]);
#line 73 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            var m1 = M.Apply(qs[1L]);
#line 75 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            if (((m0 == Result.One) && (m1 == Result.One)))
            {
#line 76 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
                return 0L;
            }

#line 78 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            if (((m0 == Result.Zero) && (m1 == Result.One)))
            {
#line 79 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
                return 1L;
            }

#line 81 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            if (((m0 == Result.One) && (m1 == Result.Zero)))
            {
#line 82 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
                return 2L;
            }

#line 84 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            if (((m0 == Result.Zero) && (m1 == Result.Zero)))
            {
#line 85 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
                return 3L;
            }

#line 87 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            return -(1L);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<Operation, QArray<Qubit>, Int64>(qs);
        }
    }

    public class TestGenerate : Operation<Int64, Int64>, ICallable
    {
        public TestGenerate(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestGenerate";
        String ICallable.FullName => "Quantum.ContestChallengeB3.TestGenerate";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,Int64), QVoid> Generate
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

        protected ICallable<QArray<Result>, Int64> MicrosoftQuantumCanonResultAsInt
        {
            get;
            set;
        }

        public override Func<Int64, Int64> Body => (__in) =>
        {
            var state = __in;
#line 95 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            var results = new QArray<Result>(2L);
#line 97 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            var qubits = Allocate.Apply(2L);
#line 99 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            Generate.Apply((qubits, state));
#line 101 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            results[0L] = M.Apply(qubits[0L]);
#line 102 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            results[1L] = M.Apply(qubits[1L]);
#line 104 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            ResetAll.Apply(qubits);
#line hidden
            Release.Apply(qubits);
#line 107 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            return MicrosoftQuantumCanonResultAsInt.Apply(results);
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Generate = this.Factory.Get<ICallable<(QArray<Qubit>,Int64), QVoid>>(typeof(Quantum.ContestChallengeB3.Generate));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumCanonResultAsInt = this.Factory.Get<ICallable<QArray<Result>, Int64>>(typeof(Microsoft.Quantum.Canon.ResultAsInt));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 state)
        {
            return __m__.Run<TestGenerate, Int64, Int64>(state);
        }
    }

    public class TestOperation : Operation<Int64, Int64>, ICallable
    {
        public TestOperation(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestOperation";
        String ICallable.FullName => "Quantum.ContestChallengeB3.TestOperation";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,Int64), QVoid> Generate
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, Int64> Operation
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
#line 115 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            var result = -(1L);
#line 117 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            var qubits = Allocate.Apply(2L);
#line 119 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            Generate.Apply((qubits, state));
#line 121 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            result = Operation.Apply(qubits);
#line 123 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            ResetAll.Apply(qubits);
#line hidden
            Release.Apply(qubits);
#line 126 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeB4\\Operation.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Generate = this.Factory.Get<ICallable<(QArray<Qubit>,Int64), QVoid>>(typeof(Quantum.ContestChallengeB3.Generate));
            this.Operation = this.Factory.Get<ICallable<QArray<Qubit>, Int64>>(typeof(Quantum.ContestChallengeB3.Operation));
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