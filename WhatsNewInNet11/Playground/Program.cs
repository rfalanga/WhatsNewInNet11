#region Goodies #1

HashSet<string> tags = [with(StringComparer.OrdinalIgnoreCase), "one", "two"];

#endregion

#region Goodies #2

loop_i: for (int i = 0; i < 19; i++)
{
    for (int j = 0; j < 23; j++)
    {
        if ((i + j) % 2 == 0)
        {
            break loop_i;
        }
    }
}

#endregion

    static int Compute(Operation op)
{
    return op switch
    {
        Number(var value) => value,
        Add(var op1, var op2) => Compute(op1) + Compute(op2),
        Subtract(var op1, var op2) => Compute(op1) - Compute(op2),
        Multiply(var op1, var op2) => Compute(op1) * Compute(op2),
        Divide(var op1, var op2) => Compute(op1) / Compute(op2)
    };
}

Console.WriteLine(Compute(new Add(new Number(19), new Number(23))));

public closed record class Operation;

public sealed record class Number(int Value) : Operation;
public sealed record class Add(Operation Op1, Operation Op2) : Operation;
public sealed record class Subtract(Operation Op1, Operation Op2) : Operation;
public sealed record class Multiply(Operation Op1, Operation Op2) : Operation;
public sealed record class Divide(Operation Op1, Operation Op2) : Operation;