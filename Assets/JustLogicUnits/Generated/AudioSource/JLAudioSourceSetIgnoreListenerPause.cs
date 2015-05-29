using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Audio/Set Ignore Listener Pause")]
[UnitFriendlyName("Audio.Set Ignore Listener Pause")]
[UnitUsage(typeof(System.Boolean))]
public class JLAudioSourceSetIgnoreListenerPause : JLExpression
{
    [Parameter(ExpressionType = typeof(UnityEngine.AudioSource))]
    public JLExpression OperandValue;

    [Parameter(ExpressionType = typeof(System.Boolean))]
    public JLExpression Value;

    public override object GetAnyResult(IExecutionContext context)
    {
        UnityEngine.AudioSource opValue = OperandValue.GetResult<UnityEngine.AudioSource>(context);
        return opValue.ignoreListenerPause = Value.GetResult<System.Boolean>(context);
    }
}