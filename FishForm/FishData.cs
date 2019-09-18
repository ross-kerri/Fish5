using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishForm
{
    public partial class FishData : Form, ISubject
    {
        ArrayList _observers;
        int _length;
        int _size;

        public FishData()
        {
            InitializeComponent();

            ObserverFull ovsFull = new ObserverFull(this);
            ovsFull.Show();

            ObsSize ovsSize = new ObsSize(this);
            ovsSize.Show();

            _observers = new ArrayList();

        }

        public void Deregister(IObserver o)
        {
            //if not registered deregister
            if (_observers.Contains(o)) {
                _observers.Remove(o);
            }
        }

        public void Notify()
        {
            foreach(IObserver o in _observers)
            {
                o.Update(_length, _size);
            }
        }

        public void Register(IObserver o)
        {
            //if not registered add
            if (!_observers.Contains(o))
            {
                _observers.Add(o);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            ChangeMade();
            Notify();
        }

        public void ChangeMade()
        {
            //TryParse is a boolean which if true will convert text to int
            int.TryParse(textBoxLength.Text, out _length);
            int.TryParse(textBoxSize.Text, out _size);
        }
    }
}
