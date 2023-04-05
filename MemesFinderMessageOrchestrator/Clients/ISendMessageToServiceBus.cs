﻿using MemesFinderMessageOrchestrator.Options;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace MemesFinderMessageOrchestrator.Clients
{
    public interface ISendMessageToServiceBus
    {
        ISendMessageToServiceBus SetNext(ISendMessageToServiceBus next);
        Task SendMessageAsync(Update message);
        public bool SupportsMode(AnalysisMode mode);
    }
}
