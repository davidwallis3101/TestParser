﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParser
{
    public enum Command
    {
        Presentation = 0, //Sent by a node when they present attached sensors. This is usually done in the presentation() function which runs at startup.
        Set	= 1,// This message is sent from or to a sensor when a sensor value should be updated
        Req	= 2,    // Requests a variable value (usually from an actuator destined for controller)
        Internal = 3, // This is a special internal message.See table below for the details
        Stream = 4, // Used for OTA firmware updates
    }
}
