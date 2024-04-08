using System;
using Exiled.API.Features;
using Exiled.CustomRoles.API;

namespace ZombieRework_EXILED8
{
    public class Plugin : Plugin<Config>
    {
        public override string Name { get; } = "Custom Zombies";
        public override string Author { get; } = "6hundred9";
        public override string Prefix { get; } = "MoreZombies";
        public override Version Version { get; } = new Version(1, 0);
        public override Version RequiredExiledVersion { get; } = new Version(8, 8, 0);
        public override bool IgnoreRequiredVersionCheck { get; } = true;
        public static Plugin Instance;
        public override void OnEnabled()
        {
            Instance = this;
            Config.Asyphixator.Register();
            Config.Tanky.Register();
            Config.Speedjunkie.Register();
            Config.TestSubject.Register();
            Exiled.Events.Handlers.Scp049.FinishingRecall += EventHandler.RecallFinished;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Config.Asyphixator.Unregister();
            Config.Tanky.Unregister();
            Config.Speedjunkie.Unregister();
            Config.TestSubject.Unregister();
            Exiled.Events.Handlers.Scp049.FinishingRecall -= EventHandler.RecallFinished;
            base.OnDisabled();
        }
        
    }
}
