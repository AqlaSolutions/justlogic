﻿using System;
using System.Collections.Generic;
using UnityEngine;

using System;

namespace JustLogic.Core.Events
{
    public struct OnTriggerStay : IEventDescription
    {
        public string RequiredEventHandler { get { return "JustLogicEventHandlerLite"; } }
        public string Name { get { return "OnTriggerStay"; } }
        readonly static EventDescriptionArguments Args = new EventDescriptionArguments(new[] { new KeyValuePair<string, Type>("other", typeof(Collider)) });
        public EventDescriptionArguments Arguments { get { return Args; } }
    }
}