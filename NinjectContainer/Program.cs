using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using System.Reflection;


namespace NinjectContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            // INotifier notifier = new Email();
            IKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            INotifier notifier = kernel.Get<SMS>();
           
            Notify notify = new Notify(notifier);
            notify.SendNotification();
            Console.Read();
        }
        
    }
}
