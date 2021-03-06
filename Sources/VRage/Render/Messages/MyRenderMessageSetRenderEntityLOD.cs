﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRageRender
{
    public class MyRenderMessageSetRenderEntityLOD : IMyRenderMessage
    {
        public uint ID;
        public float Distance; //Multiplier of MyRenderConstants.LodTransitionDistanceBackgroundEnd
        public string Model;

        MyRenderMessageType IMyRenderMessage.MessageClass { get { return MyRenderMessageType.StateChangeOnce; } }
        MyRenderMessageEnum IMyRenderMessage.MessageType { get { return MyRenderMessageEnum.SetRenderEntityLOD; } }
    }
}
