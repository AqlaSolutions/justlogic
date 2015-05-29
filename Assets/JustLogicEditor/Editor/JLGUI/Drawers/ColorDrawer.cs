﻿using System;
using UnityEditor;
using UnityEngine;

namespace JustLogic.Editor.JLGUI.Drawers
{
    [ParameterDrawer(typeof(Color))]
    public class ColorDrawer : ParameterDrawerBase
    {
        public override bool Initialize(DrawerInitArgs args, object value, IDrawContext context)
        {
            Layout = ParameterDrawerLayout.HorizontalLimited;
            return base.Initialize(args, value, context);
        }

        protected override bool OnDraw(IDrawContext context, bool isNewAreaStarted)
        {
            var value = (Color)Value;
            context.BeginLook(true);
            try
            {
                object newValue = EditorGUILayout.ColorField(value);
                if (!newValue.Equals(value))
                {
                    Value = newValue;
                    return true;
                }
                return false;
            }
            finally { context.EndLook(); }

        }
    }
}