using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Edwin, Sonja, Happy
namespace TravelApp
{
    public partial class TripPlanner : Form
    {
        public class Item
        {
            public string Name;
            public double Value;
            public Item(string name, double value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }
        public TripPlanner()
        {
            InitializeComponent();
            comboBox1.Items.Add(new Item("New Orleans", 550.00));//add item to combobox
            comboBox1.Items.Add(new Item("Hawaii- Honolulu", 650.00));//add item to combobox
            //comboBox1.Items.Add(new Item("New Zealand", 2000));
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
            this.Close();//closes the form
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)//User clicked New Orleans, makes trip options available
            {
                cbAct1.Text = Convert.ToString(new Item ("Art Gallery Tour, $0.00", 0.00)); //make others look like this to get values
                cbAct2.Text = Convert.ToString(new Item ("Mardi Gras World, $19.95", 19.95));
                cbAct3.Text = Convert.ToString(new Item("VIP Private Carriage tour, $100.00", 100.00));
                cbFood1.Text = Convert.ToString(new Item("Donuts. Sliders. Brew. , $10.00", 10.00));
                cbFood2.Text = Convert.ToString(new Item("Antoines, $20.00", 20.00));
                cbFood3.Text = Convert.ToString(new Item("Commander's Palace, $30.00", 30.00));
                rdoHotel1.Text = Convert.ToString(new Item("Drury Inn & Suites/per night, $100.00", 100.00));
                rdoHotel2.Text = Convert.ToString(new Item("Aloft New Orleans Downtown/per night, $150.00", 150.00));
                rdoHotel3.Text = Convert.ToString(new Item("The Pontchartrain Hotel/per night, $325.00", 325.00));
               lbSum.Items.Add(new Item("New Orleans", 550.00));
            }
            else if (comboBox1.SelectedIndex == 1)//User clicked Hawaii, makes trip options available
            {
                cbAct1.Text = Convert.ToString(new Item("Sight Seeing, $0.00", 0.00));
                cbAct2.Text = Convert.ToString(new Item("Beach Day, $49.95", 49.95));
                cbAct3.Text = Convert.ToString(new Item("Zipline, $200.00", 200.00));
                cbFood1.Text = Convert.ToString(new Item("Dunkin Doughnuts, $10.00", 10.00));
                cbFood2.Text = Convert.ToString(new Item("Teshima's, $40.00", 40.00));
                cbFood3.Text = Convert.ToString(new Item("Roy Waikiki's, $50.00", 50.00));
                rdoHotel1.Text = Convert.ToString(new Item("Royal Hawaian Resort/per night, $85.00", 85.00));
                rdoHotel2.Text = Convert.ToString(new Item("Halekulani/per night, $95.00", 95.00));
                rdoHotel3.Text = Convert.ToString(new Item("Aulani Disney Resort and spa/per night, $105.00", 105.00));
                lbSum.Items.Add(new Item("Hawaii- Honolulu", 650.00));
            }

        }

        private void cbAct1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAct1.Checked == true)
            {
                lbSum.Items.Add(cbAct1.Text);//add activity to summary box
            }
            else
            {
                lbSum.Items.Remove(cbAct1.Text);//remove item from summary box
            }
        }
    

        private void cbAct2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAct2.Checked == true)
            {
                lbSum.Items.Add(cbAct2.Text);//add activity to summary box
            }
            else
            {
                lbSum.Items.Remove(cbAct2.Text);//remove item from summary box
            }
        }

        private void cbAct3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAct3.Checked == true)
            {
                lbSum.Items.Add(cbAct3.Text);//add activity to summary box
            }
            else
            {
                lbSum.Items.Remove(cbAct3.Text);//remove item from summary box
            }
        }

        private void cbFood1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFood1.Checked == true)
            {
                lbSum.Items.Add(cbFood1.Text);//add item to summary box
            }
            else
            {
                lbSum.Items.Remove(cbFood1.Text);//remove item from summary box
            }
        }

        private void cbFood2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFood2.Checked == true)
            {
                lbSum.Items.Add(cbFood2.Text);//add item to summary box
            }
            else
            {
                lbSum.Items.Remove(cbFood2.Text);//remove item from summary box
            }
        }

        private void cbFood3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFood3.Checked == true)
            {
                lbSum.Items.Add(cbFood3.Text);//add item to summary box
            }
            else
            {
                lbSum.Items.Remove(cbFood3.Text);//remove item from summary box
            }
        }

        private void gbHotel_Enter(object sender, EventArgs e)
        {
            
        }

        private void rdoHotel1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHotel1.Checked == true)
            {
                lbSum.Items.Add(rdoHotel1.Text);//add item to summary box
            }
            else
            {
                lbSum.Items.Remove(rdoHotel1.Text);//remove item from summary box
            }
        }

        private void rdoHotel2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHotel2.Checked == true)
            {
                lbSum.Items.Add(rdoHotel2.Text);//add item to summary box
            }
            else
            {
                lbSum.Items.Remove(rdoHotel2.Text);//remove item from summary box
            }
        }

        private void rdoHotel3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHotel3.Checked == true)
            {
                lbSum.Items.Add(rdoHotel3.Text);//add item to summary box
            }
            else
            {
                lbSum.Items.Remove(rdoHotel3.Text);//remove item from summary box
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)// this area needs work
        {


            



           txtSubtotal.Text = subtotal.ToString("c2");//convert, format and display in textbox
        }

        
    }


}
