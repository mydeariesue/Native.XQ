﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Native.XQ.SDK.Event.EventArgs;

namespace Native.XQ.SDK.Interfaces
{
    public interface IXQGroupMessage
    {
        void GroupMessage(object sender, XQAppGroupMsgEventArgs e);
    }
}
