﻿using JetBrains.Annotations;
using Lykke.Sdk.Settings;
using Lykke.Service.NotificationSystemBroker.Settings.Sms;

namespace Lykke.Service.NotificationSystemBroker.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class AppSettings : BaseAppSettings
    {
        public NotificationSystemBrokerSettings NotificationSystemBrokerService { get; set; }

        public RabbitMqSettings Rabbit { get; set; }

        public EmailSenderSettings EmailSender { get; set; }

        public SmsSenderSettings SmsSender { get; set; }

        public PushSenderSettings PushSender { get; set; }
    }
}
