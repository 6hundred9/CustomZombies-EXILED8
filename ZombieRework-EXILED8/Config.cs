using Exiled.API.Interfaces;
using ZombieRework_EXILED8.Zombies;

namespace ZombieRework_EXILED8
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        public  TankyZombie Tanky = new TankyZombie();
        public  Asyphixator Asyphixator = new Asyphixator();
        public  Speedjunkie Speedjunkie = new Speedjunkie();
        public TestSubject TestSubject = new TestSubject();
    }
    
}