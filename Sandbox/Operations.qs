namespace Quantum.Sandbox
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation SetQubit (qubit : Qubit, result : Result) : ()
    {
        body
        {
            if (M(qubit) != result)
			{
				X(qubit);
			}
        }
    }

	operation TestState (state : Result) : (Result, Result, Result)
	{
		body
		{
			mutable result = (Zero, Zero, Zero);

			using (qubits = Qubit[3])
			{
				SetQubit(qubits[0], state);
				SetQubit(qubits[1], state);
				SetQubit(qubits[2], state);

				set result = (Measure([PauliX], [qubits[0]]), Measure([PauliY], [qubits[1]]), Measure([PauliZ], [qubits[2]]));

				ResetAll(qubits);
			}

			return result;
		}
	}
}
