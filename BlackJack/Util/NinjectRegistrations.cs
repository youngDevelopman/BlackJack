﻿using BlackJack.Interfaces;
using BlackJack.Models;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlackJack.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository>().To<PlayerRepository>();
        }
    }
}