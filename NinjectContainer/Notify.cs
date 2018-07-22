using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectContainer
{
    public class Notify
    {
        private INotifier _notifier;

        public Notify(INotifier notifier)
        {
            // Returns the registered dependency 
            _notifier = notifier;
        }

        public void SendNotification()
        {
            _notifier.Send();
        }
    }
}
