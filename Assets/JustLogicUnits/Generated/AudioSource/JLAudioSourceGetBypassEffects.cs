using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Audio/Get Bypass Effects")]
[UnitFriendlyName("Audio.Get Bypass Effects")]
[UnitUsage(typeof(System.Boolean), HideExpressionInActionsList = true)]
public class JLAudioSourceGetBypassEffects : JLExpression
{
    [Parameter(ExpressionType = typeof(UnityEngine.AudioSource))]
    public JLExpression OperandValue;

    public override object GetAnyResult(IExecutionContext context)
    {
        UnityEngine.AudioSource opValue = OperandValue.GetResult<UnityEngine.AudioSource>(context);
        return opValue.bypassEffects;
    }
}
