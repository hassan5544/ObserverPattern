using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface ISubject
    {
        void Attact(IObserver observer);
        void DeAttach(IObserver observer);
        void Notify();
    }
}
