﻿using Exiled.API.Interfaces;
using ZombieRework_EXILED8.Zombies;

namespace ZombieRework_EXILED8
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        public  TankyZombie tanky = new TankyZombie();
        public  Asyphixator asyphixator = new Asyphixator();
        public  Speedjunkie speedjunkie = new Speedjunkie();
        public TestSubject testSubject = new TestSubject();
    }
    
}