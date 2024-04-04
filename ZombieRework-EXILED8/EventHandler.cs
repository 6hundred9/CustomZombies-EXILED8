using System;
using System.Collections.Generic;
using Exiled.CustomRoles.API.Features;
using Exiled.Events.EventArgs.Scp049;
using static System.Random;

namespace ZombieRework_EXILED8
{
    public class EventHandler
    {
        // Tanky 1 - Asyphixator 2 - Speedjunkie 3
        // 1-10
        public static void FinishingRecall(FinishingRecallEventArgs ev)
        {
            Random rnd = new Random();
            int var = rnd.Next(1, 10);
            if (var == 1)
            {
                Plugin.Instance.Config.tanky.AddRole(ev.Target);
            } else if (var == 2)
            {
                Plugin.Instance.Config.asyphixator.AddRole(ev.Target);
            } else if (var == 3)
            {
                Plugin.Instance.Config.speedjunkie.AddRole(ev.Target);
            }
        }
    }
}