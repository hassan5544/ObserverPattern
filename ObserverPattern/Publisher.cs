using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Publisher : ISubject
    {
        private readonly List<IObserver> observers = new List<IObserver>();
   
        public void Attact(IObserver Newobserver)
        {

            Console.WriteLine("Adding new ");
            observers.Add(Newobserver);
        }

        public void DeAttach(IObserver RemovedObserver)
        {
            Console.WriteLine("Remove Observer");
            observers.Remove(RemovedObserver);
        }

        public void Notify()
        {

            Console.WriteLine("Notify");
            foreach (IObserver observer in observers)
            {
                observer.Update(this);
            }
        }

        public void Publish()
        {
            Console.WriteLine("Publish new Article");
            this.Notify();
        }
    }
}
