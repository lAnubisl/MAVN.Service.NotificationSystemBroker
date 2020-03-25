﻿using System;

namespace Lykke.Service.NotificationSystemBroker.Settings
{
    public class PushSenderSettings
    {
        public TimeSpan Timeout { get; set; }
        public int RetriesCount { get; set; }
        public string ServiceClient { get; set; }
    }
}
