using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja4
{
    internal interface IPublisher
    {
        void Add(ISubscriber subscriber);
        void Remove(ISubscriber subscriber);
        void NotifySubscribers();
    }
}
