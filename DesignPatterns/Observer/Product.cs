using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class Product : IObservable<NotificationMessage>
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public bool IsAvailable { get; set; }
        public List<IObserver<NotificationMessage>> Observers;

        public Product(string name,int count)
        {
            Observers = new List<IObserver<NotificationMessage>>();
            Name = name;
            Count = count < 0 ? 0 : count;
            IsAvailable = count > 0;
        }
        public IDisposable Subscribe(IObserver<NotificationMessage> observer)
        {
            if (!Observers.Contains(observer))
                Observers.Add(observer);
            return new UnSubscriber(Observers,observer);
        }

        public void AddProduct(int count)
        {
            Count += count;
            if (Count > 0 && !IsAvailable)
            {
                IsAvailable = true;
                foreach (var observer in Observers)
                {
                    observer.OnNext(new NotificationMessage() { Message = $"{Count} {Name} exist in stock" });
                }
            }
        }

        public void SellProduct(int count)
        {
            if (count > Count)
                throw new ApplicationException("There are not enough product to sell");

            Count -= count;
            if (Count == 0)
                IsAvailable = false;
        }
    }
}
