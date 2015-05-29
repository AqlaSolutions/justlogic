using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Audio/Get Time Samples")]
[UnitFriendlyName("Audio.Get Time Samples")]
[UnitUsage(typeof(System.Int32), HideExpressionInActionsList = true)]
public class JLAudioSourceGetTimeSamples : JLExpression
{
    [Parameter(ExpressionType = typeof(UnityEngine.AudioSource))]
    public JLExpression OperandValue;

    public override object GetAnyResult(IExecutionContext context)
    {
        UnityEngine.AudioSource opValue = OperandValue.GetResult<UnityEngine.AudioSource>(context);
        return opValue.timeSamples;
    }
}