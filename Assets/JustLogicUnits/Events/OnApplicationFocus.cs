﻿#if !JUSTLOGIC_FREE
using System;
using System.Collections.Generic;
using UnityEngine;

using System;

namespace JustLogic.Core.Events
{
    public struct OnApplicationFocus : IEventDescription
    {
        public string RequiredEventHandler { get { return "JustLogicEventHandlerLite"; } }
        public string Name { get { return "OnApplicationFocus"; } }
        readonly static EventDescriptionArguments Args = new EventDescriptionArguments(new[] { new KeyValuePair<string, Type>("focus", typeof(bool)) });
        public EventDescriptionArguments Arguments { get { return Args; } }
    }
}
#endif