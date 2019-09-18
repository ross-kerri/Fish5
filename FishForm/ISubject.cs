using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishForm
{
    public interface ISubject
    {
        void Notify();
        void Register(IObserver o);
        void Deregister(IObserver o);
    }
}