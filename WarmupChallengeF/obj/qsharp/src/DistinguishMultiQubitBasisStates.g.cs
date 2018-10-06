#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.WarmupChallengeF", "DistinguishMultiQubitBasisStates (qubits : Qubit[], bits0 : Bool[], bits1 : Bool[]) : Int", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeF\\DistinguishMultiQubitBasisStates.qs", 423L, 11L, 5L)]
[assembly: OperationDeclaration("Quantum.WarmupChallengeF", "TestState (length : Int, bits0 : Bool[], bits1 : Bool[], which : Int) : Int", new string[] { }, "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeF\\DistinguishMultiQubitBasisStates.qs", 1272L, 41L, 2L)]
#line hidden
namespace Quantum.WarmupChallengeF
{
    public class DistinguishMultiQubitBasisStates : Operation<(QArray<Qubit>,QArray<Boolean>,QArray<Boolean>), Int64>, ICallable
    {
        public DistinguishMultiQubitBasisStates(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Boolean>,QArray<Boolean>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Boolean>,QArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "DistinguishMultiQubitBasisStates";
        String ICallable.FullName => "Quantum.WarmupChallengeF.DistinguishMultiQubitBasisStates";
        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Boolean>,QArray<Boolean>), Int64> Body => (__in) =>
        {
            var (qubits,bits0,bits1) = __in;
#line 14 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeF\\DistinguishMultiQubitBasisStates.qs"
            foreach (var k in new Range(0L, (qubits.Count - 1L)))
            {
                /// If the kth element of bits0 and bits1 is different
#line 17 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeF\\DistinguishMultiQubitBasisStates.qs"
                if ((bits0[k] != bits1[k]))
                {
                    /// Collapse to |0> or |1>
#line 20 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeF\\DistinguishMultiQubitBasisStates.qs"
                    var res = M.Apply(qubits[k]);
                    /// If qubit matches the bit in bits0, then bits0 describes qubits
#line 23 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeF\\DistinguishMultiQubitBasisStates.qs"
                    if ((((res == Result.One) && (bits0[k] == true)) || ((res == Result.Zero) && (bits0[k] == false))))
                    {
#line 24 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeF\\DistinguishMultiQubitBasisStates.qs"
                        return 0L;
                    }

                    /// Otherwise bits1 describes qubits
#line 27 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeF\\DistinguishMultiQubitBasisStates.qs"
                    return 1L;
                }
            }

#line 31 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeF\\DistinguishMultiQubitBasisStates.qs"
            return -(1L);
        }

        ;
        public override void Init()
        {
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Boolean>,QArray<Boolean>) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Qubit> qubits, QArray<Boolean> bits0, QArray<Boolean> bits1)
        {
            return __m__.Run<DistinguishMultiQubitBasisStates, (QArray<Qubit>,QArray<Boolean>,QArray<Boolean>), Int64>((qubits, bits0, bits1));
        }
    }

    public class TestState : Operation<(Int64,QArray<Boolean>,QArray<Boolean>,Int64), Int64>, ICallable
    {
        public TestState(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,QArray<Boolean>,QArray<Boolean>,Int64)>, IApplyData
        {
            public In((Int64,QArray<Boolean>,QArray<Boolean>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TestState";
        String ICallable.FullName => "Quantum.WarmupChallengeF.TestState";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,QArray<Boolean>,QArray<Boolean>), Int64> DistinguishMultiQubitBasisStates
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

        public override Func<(Int64,QArray<Boolean>,QArray<Boolean>,Int64), Int64> Body => (__in) =>
        {
            var (length,bits0,bits1,which) = __in;
#line 44 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeF\\DistinguishMultiQubitBasisStates.qs"
            var result = -(1L);
            /// Allocate |0..0>
#line 47 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeF\\DistinguishMultiQubitBasisStates.qs"
            var qubits = Allocate.Apply(length);
#line 49 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeF\\DistinguishMultiQubitBasisStates.qs"
            foreach (var index in new Range(0L, (length - 1L)))
            {
                /// If using bits0
#line 52 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeF\\DistinguishMultiQubitBasisStates.qs"
                if ((which == 0L))
                {
                    /// If element should be 1
#line 55 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeF\\DistinguishMultiQubitBasisStates.qs"
                    if ((bits0[index] == true))
                    {
                        /// |0> to |1>
#line 58 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeF\\DistinguishMultiQubitBasisStates.qs"
                        MicrosoftQuantumPrimitiveX.Apply(qubits[index]);
                    }
                }

                /// If using bits1
#line 63 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeF\\DistinguishMultiQubitBasisStates.qs"
                if ((which == 1L))
                {
                    /// If element should be 1
#line 66 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeF\\DistinguishMultiQubitBasisStates.qs"
                    if ((bits1[index] == true))
                    {
                        /// |0> to |1>
#line 69 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeF\\DistinguishMultiQubitBasisStates.qs"
                        MicrosoftQuantumPrimitiveX.Apply(qubits[index]);
                    }
                }
            }

#line 74 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeF\\DistinguishMultiQubitBasisStates.qs"
            result = DistinguishMultiQubitBasisStates.Apply((qubits, bits0, bits1));
#line 76 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeF\\DistinguishMultiQubitBasisStates.qs"
            ResetAll.Apply(qubits);
#line hidden
            Release.Apply(qubits);
#line 79 "C:\\Users\\rober\\Source\\Repos\\QSharpCodingContest\\WarmupChallengeF\\DistinguishMultiQubitBasisStates.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.DistinguishMultiQubitBasisStates = this.Factory.Get<ICallable<(QArray<Qubit>,QArray<Boolean>,QArray<Boolean>), Int64>>(typeof(Quantum.WarmupChallengeF.DistinguishMultiQubitBasisStates));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Int64,QArray<Boolean>,QArray<Boolean>,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 length, QArray<Boolean> bits0, QArray<Boolean> bits1, Int64 which)
        {
            return __m__.Run<TestState, (Int64,QArray<Boolean>,QArray<Boolean>,Int64), Int64>((length, bits0, bits1, which));
        }
    }
}