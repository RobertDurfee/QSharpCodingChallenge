#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.Sandbox", "SetQubit (qubit : Qubit, result : Result) : ()", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\Sandbox\\Operations.qs", 172L, 7L, 5L)]
[assembly: OperationDeclaration("Quantum.Sandbox", "TestState (state : Result) : (Result, Result, Result)", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\Sandbox\\Operations.qs", 351L, 18L, 2L)]
#line hidden
namespace Quantum.Sandbox
{
    public class SetQubit : Operation<(Qubit,Result), QVoid>, ICallable
    {
        public SetQubit(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Result)>, IApplyData
        {
            public In((Qubit,Result) data) : base(data)
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

        String ICallable.Name => "SetQubit";
        String ICallable.FullName => "Quantum.Sandbox.SetQubit";
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

        public override Func<(Qubit,Result), QVoid> Body => (__in) =>
        {
            var (qubit,result) = __in;
#line 10 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\Sandbox\\Operations.qs"
            if ((M.Apply(qubit) != result))
            {
#line 12 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\Sandbox\\Operations.qs"
                MicrosoftQuantumPrimitiveX.Apply(qubit);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Qubit,Result) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit qubit, Result result)
        {
            return __m__.Run<SetQubit, (Qubit,Result), QVoid>((qubit, result));
        }
    }

    public class TestState : Operation<Result, (Result,Result,Result)>, ICallable
    {
        public TestState(IOperationFactory m) : base(m)
        {
        }

        public class Out : QTuple<(Result,Result,Result)>, IApplyData
        {
            public Out((Result,Result,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TestState";
        String ICallable.FullName => "Quantum.Sandbox.TestState";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<(QArray<Pauli>,QArray<Qubit>), Result> Measure
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

        protected ICallable<(Qubit,Result), QVoid> SetQubit
        {
            get;
            set;
        }

        public override Func<Result, (Result,Result,Result)> Body => (__in) =>
        {
            var state = __in;
#line 21 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\Sandbox\\Operations.qs"
            var result = (Result.Zero, Result.Zero, Result.Zero);
#line 23 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\Sandbox\\Operations.qs"
            var qubits = Allocate.Apply(3L);
#line 25 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\Sandbox\\Operations.qs"
            SetQubit.Apply((qubits[0L], state));
#line 26 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\Sandbox\\Operations.qs"
            SetQubit.Apply((qubits[1L], state));
#line 27 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\Sandbox\\Operations.qs"
            SetQubit.Apply((qubits[2L], state));
#line 29 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\Sandbox\\Operations.qs"
            result = (Measure.Apply((new QArray<Pauli>()
            {Pauli.PauliX}, new QArray<Qubit>()
            {qubits[0L]})), Measure.Apply((new QArray<Pauli>()
            {Pauli.PauliY}, new QArray<Qubit>()
            {qubits[1L]})), Measure.Apply((new QArray<Pauli>()
            {Pauli.PauliZ}, new QArray<Qubit>()
            {qubits[2L]})));
#line 31 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\Sandbox\\Operations.qs"
            ResetAll.Apply(qubits);
#line hidden
            Release.Apply(qubits);
#line 34 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\Sandbox\\Operations.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Measure = this.Factory.Get<ICallable<(QArray<Pauli>,QArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Primitive.Measure));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.SetQubit = this.Factory.Get<ICallable<(Qubit,Result), QVoid>>(typeof(Quantum.Sandbox.SetQubit));
        }

        public override IApplyData __dataIn(Result data) => new QTuple<Result>(data);
        public override IApplyData __dataOut((Result,Result,Result) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Result,Result,Result)> Run(IOperationFactory __m__, Result state)
        {
            return __m__.Run<TestState, Result, (Result,Result,Result)>(state);
        }
    }
}