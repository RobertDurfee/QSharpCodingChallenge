#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.WarmupChallengeI", "DeutschJozsaAlgorithm (N : Int, Uf : ((Qubit[], Qubit) => ())) : Bool", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeI\\DeutschJozsaAlgorithm.qs", 204L, 7L, 5L)]
#line hidden
namespace Quantum.WarmupChallengeI
{
    public class DeutschJozsaAlgorithm : Operation<(Int64,ICallable), Boolean>, ICallable
    {
        public DeutschJozsaAlgorithm(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable)>, IApplyData
        {
            public In((Int64,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "DeutschJozsaAlgorithm";
        String ICallable.FullName => "Quantum.WarmupChallengeI.DeutschJozsaAlgorithm";
        protected Allocate Allocate
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

        public override Func<(Int64,ICallable), Boolean> Body => (__in) =>
        {
            var (N,Uf) = __in;
#line 10 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeI\\DeutschJozsaAlgorithm.qs"
            var result = true;
            /// Allocate |0..0>
#line 13 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeI\\DeutschJozsaAlgorithm.qs"
            var x = Allocate.Apply(N);
            /// Allocate |0>
#line 16 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeI\\DeutschJozsaAlgorithm.qs"
            var y = Allocate.Apply(1L);
            /// Switch |0> to |1>
#line 19 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeI\\DeutschJozsaAlgorithm.qs"
            MicrosoftQuantumPrimitiveX.Apply(y[0L]);
#line 21 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeI\\DeutschJozsaAlgorithm.qs"
            foreach (var k in new Range(0L, (N - 1L)))
            {
                /// Switch |0> to |+>
#line 24 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeI\\DeutschJozsaAlgorithm.qs"
                MicrosoftQuantumPrimitiveH.Apply(x[k]);
            }

            /// Switch |1> to |->
#line 27 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeI\\DeutschJozsaAlgorithm.qs"
            MicrosoftQuantumPrimitiveH.Apply(y[0L]);
#line 29 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeI\\DeutschJozsaAlgorithm.qs"
            Uf.Apply((x, y[0L]));
#line 31 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeI\\DeutschJozsaAlgorithm.qs"
            foreach (var k in new Range(0L, (N - 1L)))
            {
                /// Switch |+> to |0> or |-> to |1>
#line 34 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeI\\DeutschJozsaAlgorithm.qs"
                MicrosoftQuantumPrimitiveH.Apply(x[k]);
                /// If kth element not zero, Uf not constant
#line 37 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeI\\DeutschJozsaAlgorithm.qs"
                if ((M.Apply(x[k]) != Result.Zero))
                {
#line 38 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeI\\DeutschJozsaAlgorithm.qs"
                    result = false;
                }
            }

#line 41 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeI\\DeutschJozsaAlgorithm.qs"
            ResetAll.Apply(y);
#line hidden
            Release.Apply(y);
#line 44 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeI\\DeutschJozsaAlgorithm.qs"
            ResetAll.Apply(x);
#line hidden
            Release.Apply(x);
#line 47 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeI\\DeutschJozsaAlgorithm.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Int64,ICallable) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Int64 N, ICallable Uf)
        {
            return __m__.Run<DeutschJozsaAlgorithm, (Int64,ICallable), Boolean>((N, Uf));
        }
    }
}