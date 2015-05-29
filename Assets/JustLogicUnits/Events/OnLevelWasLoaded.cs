﻿#if !JUSTLOGIC_FREE
using System;
using System.Collections.Generic;
using UnityEngine;

using System;

namespace JustLogic.Core.Events
{
    public struct OnLevelWasLoaded : IEventDescription
    {
        public string RequiredEventHandler { get { return "JustLogicEventHandlerLite"; } }
        public string Name { get { return "OnLevelWasLoaded"; } }
        readonly static EventDescriptionArguments Args = new EventDescriptionArguments(new[] { new KeyValuePair<string, Type>("level", typeof(int)) });
        public EventDescriptionArguments Arguments { get { return Args; } }
    }
}
#endif