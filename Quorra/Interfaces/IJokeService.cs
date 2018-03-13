﻿using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace Quorra.Interfaces
{
    public interface IJokeService
    {
        Task HandleJokeAsync(Message message);
    }
}
