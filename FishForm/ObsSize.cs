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
    public partial class ObsSize : Form, IObserver
    {
        ISubject sub;
        int _size;

        //custom constructor pass a ISubject - this is created when the Main Data Entry form is constructed
        public ObsSize(ISubject s)
        {
            InitializeComponent();
            sub = s;
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            sub.Register(this);
        }

        //this isn't working
        private void buttonUnSub2_Click(object sender, EventArgs e)
        {
            sub.Deregister(this);
        }

        public void Update(int length, int size)
        {
            //update relevant varables for form
            //perform any calculation required for form
            _size = size;
            textBoxSize.Text = _size.ToString();
        }

        private void ObsSize_Load(object sender, EventArgs e)
        {

        }
    }
}
