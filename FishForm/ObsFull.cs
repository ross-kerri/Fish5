using System;
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
    public partial class ObserverFull : Form, IObserver
    {
        ISubject _sub;
        int _length;

        //custom constructor pass a ISubject - this is created when the Main Data Entry form is constructed
        public ObserverFull(ISubject s)
        {
            InitializeComponent();
            _sub = s;

        }

        public void Update(int length, int size)
        {
            //update relevant varables for form
            //perform any calculation required for form
            _length = length;
            textBoxLength.Text = _length.ToString();
        }

        private void ObserverFull_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _sub.Register(this);
        }

        private void buttonUnSub_Click(object sender, EventArgs e)
        {
            _sub.Deregister(this);
        }
    }
}
