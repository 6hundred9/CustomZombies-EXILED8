using Exiled.Events.EventArgs.Scp049;
// ReSharper disable IdentifierTypo

namespace ZombieRework_EXILED8
{
    public class EventHandler
    {
        public static void RecallFinished(FinishingRecallEventArgs ev)
        {
            int asyphixator = UnityEngine.Random.Range(1, 2);
            int speedjunkie = UnityEngine.Random.Range(1, 4);
            int tanky = UnityEngine.Random.Range(3,4);
            int subject = UnityEngine.Random.Range(3, 10);
            if (asyphixator == 1)
            {
                 Plugin.Instance.Config.Asyphixator.AddRole(ev.Player);
            } else if (speedjunkie == 1)
            {
                Plugin.Instance.Config.Speedjunkie.AddRole(ev.Player);
            } else if (tanky == 3)
            {
                Plugin.Instance.Config.Tanky.AddRole(ev.Player);
            } else if (subject == 3)
            {
                Plugin.Instance.Config.TestSubject.AddRole(ev.Player);
            }
        }
    }
}