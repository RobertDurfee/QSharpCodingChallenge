#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.WarmupChallengeG", "KthQubitOracle (x : Qubit[], y : Qubit, k : Int) : ()", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeG\\KthQubitOracle.qs", 310L, 10L, 5L)]
#line hidden
namespace Quantum.WarmupChallengeG
{
    public class KthQubitOracle : Operation<(QArray<Qubit>,Qubit,Int64), QVoid>, ICallable
    {
        public KthQubitOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Qubit,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Qubit,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "KthQubitOracle";
        String ICallable.FullName => "Quantum.WarmupChallengeG.KthQubitOracle";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Qubit,Int64), QVoid> Body => (__in) =>
        {
            var (x,y,k) = __in;
            /// If kth qubit in x is |1>, flip y
#line 14 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeG\\KthQubitOracle.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((x[k], y));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Qubit,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, Qubit y, Int64 k)
        {
            return __m__.Run<KthQubitOracle, (QArray<Qubit>,Qubit,Int64), QVoid>((x, y, k));
        }
    }
}