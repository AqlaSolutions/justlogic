using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("WWW/Get Response Headers")]
[UnitFriendlyName("WWW.Get Response Headers")]
[UnitUsage(typeof(System.Collections.Generic.Dictionary<System.String, System.String>), HideExpressionInActionsList = true)]
public class JLWwwGetResponseHeaders : JLExpression
{
    [Parameter(ExpressionType = typeof(UnityEngine.WWW))]
    public JLExpression OperandValue;

    public override object GetAnyResult(IExecutionContext context)
    {
        UnityEngine.WWW opValue = OperandValue.GetResult<UnityEngine.WWW>(context);
        return opValue.responseHeaders;
    }
}
