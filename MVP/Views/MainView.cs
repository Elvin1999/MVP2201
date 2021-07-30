using MVP.Models;
using MVP.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP
{
    public partial class Form1 : Form,IMainView
    {
        public EventHandler<EventArgs> AddButtonClicked { get; set; }
        public EventHandler<EventArgs> LoadButtonClicked { get; set; }
        public List<Car> Cars { get; set ; }
        public string ModelText { get; set ; }
        public string VendorText { get; set; }
        public string ColorText { get; set; }
        public string TransmissionText { get; set; }
        public string YearText { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
