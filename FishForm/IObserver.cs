using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishForm
{
    public interface IObserver
    {
        void Update(int length, int size);
    }
}