﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuicNet.Infrastructure.Connections
{
    public enum ConnectionState
    {
        Open,
        Closing,
        Closed,
        Draining
    }
}
