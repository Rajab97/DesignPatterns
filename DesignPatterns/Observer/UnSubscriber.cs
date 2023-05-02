using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class UnSubscriber : IDisposable
    {
        private readonly List<IObserver<NotificationMessage>> _observables;
        private readonly IObserver<NotificationMessage> _currentObserver;

        public UnSubscriber(List<IObserver<NotificationMessage>> observables, IObserver<NotificationMessage> currentObserver)
        {
            _observables = observables;
            _currentObserver = currentObserver;
        }
        public void Dispose()
        {
            if (_observables.Contains(_currentObserver))
                _observables.Remove(_currentObserver);
        }
    }
}
