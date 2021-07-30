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
        public List<Car> Cars { set {
                carListbox.DataSource = null;
                carListbox.DataSource = value;
            } }
        public string ModelText { get => modelTxtb.Text; set => modelTxtb.Text = value; }
        public string VendorText { get => vendorTxtb.Text; set => vendorTxtb.Text = value; }
        public string ColorText { get => colorTxtb.Text; set => colorTxtb.Text = value; }
        public string TransmissionText { get => transmissionTxtb.Text; set => transmissionTxtb.Text = value; }
        public string YearText { get; set; }

        public Form1()
        {
            InitializeComponent();
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            AddButtonClicked.Invoke(sender, e);
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            LoadButtonClicked.Invoke(sender, e);
        }
    }
}
