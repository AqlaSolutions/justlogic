﻿using System;

namespace JustLogic.Editor.JLGUI
{
    /// <summary>
    /// Allows to specify exactly parameter drawer class to display the unit in the inspector
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    public sealed class UseDrawerAttribute : Attribute
    {
        public string TypeFullName { get; set; }
    }
}