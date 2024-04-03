using Exiled.API.Interfaces;

namespace ZombieRework_EXILED8
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
    }
}