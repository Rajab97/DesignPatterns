using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class User : IObserver<NotificationMessage>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        private Dictionary<IObservable<NotificationMessage>, IDisposable> SubscriptionCancelation;
        public User()
        {
            SubscriptionCancelation = new Dictionary<IObservable<NotificationMessage>, IDisposable>();
        }
        public void SubscribeToProduct(IObservable<NotificationMessage> observable)
        {
            SubscriptionCancelation.Add(observable, observable.Subscribe(this));
        }
        public void UnSubscribeToProduct(IObservable<NotificationMessage> observable)
        {
            if (SubscriptionCancelation.ContainsKey(observable))
                SubscriptionCancelation[observable].Dispose();
        }
        public void OnCompleted()
        {
            Console.WriteLine("Observe product completed");
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(NotificationMessage notification)
        {
            Console.WriteLine(notification.Message);
        }
    }
}
