using JustLogic.Core;
using System.Collections.Generic;
using System.Collections;

[UnitMenu("ArrayList/Set Capacity")]
[UnitFriendlyName("ArrayList.Set Capacity")]
[UnitUsage(typeof(System.Int32))]
public class JLArrayListSetCapacity : JLExpression
{
    [Parameter(ExpressionType = typeof(System.Collections.ArrayList))]
    public JLExpression OperandValue;

    [Parameter(ExpressionType = typeof(System.Int32))]
    public JLExpression Value;

    public override object GetAnyResult(IExecutionContext context)
    {
        System.Collections.ArrayList opValue = OperandValue.GetResult<System.Collections.ArrayList>(context);
        return opValue.Capacity = Value.GetResult<System.Int32>(context);
    }
}
