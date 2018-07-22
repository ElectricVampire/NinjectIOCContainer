using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;

namespace NinjectContainer
{
    class NinjectClass : NinjectModule
    {
        public override void Load()
        {
            Bind<INotifier>().To<SMS>();
            Bind<INotifier>().To<Email>();
        }
    }
}
