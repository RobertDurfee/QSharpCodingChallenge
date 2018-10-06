#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.ContestChallengeD2", "Operation (x : Qubit[], y : Qubit, b : Int[]) : ()", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeD2\\Operation.qs", 187L, 7L, 5L)]
#line hidden
namespace Quantum.ContestChallengeD2
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
        String ICallable.FullName => "Quantum.ContestChallengeD2.Operation";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Qubit,QArray<Int64>), QVoid> Body => (__in) =>
        {
            var (x,y,b) = __in;
#line 10 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeD2\\Operation.qs"
            foreach (var k in new Range(0L, (x.Count - 1L)))
            {
#line 12 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeD2\\Operation.qs"
                if ((b[k] == 1L))
                {
#line 13 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeD2\\Operation.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((x[k], y));
                }

#line 15 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeD2\\Operation.qs"
                if ((b[k] == 0L))
                {
#line 17 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeD2\\Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(x[k]);
#line 19 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeD2\\Operation.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((x[k], y));
#line 21 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\ContestChallengeD2\\Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(x[k]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Qubit,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, Qubit y, QArray<Int64> b)
        {
            return __m__.Run<Operation, (QArray<Qubit>,Qubit,QArray<Int64>), QVoid>((x, y, b));
        }
    }
}