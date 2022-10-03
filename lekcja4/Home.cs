using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja4
{
    internal class Home : IPublisher
    {
        private List<ISubscriber> subscribers = new List<ISubscriber>();
        public void Add(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void NotifySubscribers()
        {
            foreach (var item in subscribers)
            {
                item.Update();
            }
        }

        public void Remove(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void OpenWindow()
        {
            NotifySubscribers();
        }
    }
}
