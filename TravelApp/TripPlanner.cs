using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelApp
{
    public partial class TripPlanner : Form
    {
        public TripPlanner()
        {
            InitializeComponent();
        }


        const double tax = .0775;
        double ntax = 0;
        double subtotal = 0;
        double total = 0;



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        public void comboPop(string text, string value)
        {
                IList<Locations> location = new List<Locations>();
                comboBox1.DataSource = location.ToList();
                comboBox1.DisplayMember = "Text";
                comboBox1.ValueMember = "Value";
                location.Add(new Locations("New Orleans", "$500"));
                location.Add(new Locations("Hawaii", "$650"));
                location.Add(new Locations("New Zealand", "$1000"));
        }
    }
}
