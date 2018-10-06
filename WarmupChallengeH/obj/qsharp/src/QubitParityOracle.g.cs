#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.WarmupChallengeH", "QubitParityOracle (x : Qubit[], y : Qubit) : ()", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeH\\QubitParityOracle.qs", 290L, 9L, 5L)]
#line hidden
namespace Quantum.WarmupChallengeH
{
    public class QubitParityOracle : Operation<(QArray<Qubit>,Qubit), QVoid>, ICallable
    {
        public QubitParityOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "QubitParityOracle";
        String ICallable.FullName => "Quantum.WarmupChallengeH.QubitParityOracle";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Qubit), QVoid> Body => (__in) =>
        {
            var (x,y) = __in;
#line 12 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeH\\QubitParityOracle.qs"
            foreach (var k in new Range(0L, (x.Count - 1L)))
            {
                /// If x[k] is |1>, flip y
#line 15 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeH\\QubitParityOracle.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((x[k], y));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, Qubit y)
        {
            return __m__.Run<QubitParityOracle, (QArray<Qubit>,Qubit), QVoid>((x, y));
        }
    }
}