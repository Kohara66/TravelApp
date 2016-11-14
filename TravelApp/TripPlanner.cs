﻿using System;
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
        private class Item
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
            comboBox1.Items.Add(new Item("New Orleans", 550.00));
            comboBox1.Items.Add(new Item("Hawaii- Honolulu", 650.00));
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
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                cbAct1.Text = "Art Gallery Tour, $0.00";
                cbAct2.Text = "Mardi Gras World, $19.95";
                cbAct3.Text = "VIP Private Carriage tour, $100.00";
                cbFood1.Text = "Donuts. Sliders. Brew. , $10.00";
                cbFood2.Text = "Antoines, $20.00";
                cbFood3.Text = "Commander's Palace, $30.00";
                rdoHotel1.Text = "Drury Inn & Suites $100.00/per night";
                rdoHotel2.Text = "Aloft New Orleans Downtown $150.00/ per night";
                rdoHotel3.Text = "The Pontchartrain Hotel $325.00/ per night";
                lbSum.Items.Add(new Item("Hawaii- Honolulu", 650.00));
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                cbAct1.Text = "Sight Seeing, $0.00";
                cbAct2.Text = "Beach Day, $49.95";
                cbAct3.Text = "Zipline, $200.00";
                cbFood1.Text = "Dunkin Doughnuts, $10.00";
                cbFood2.Text = "Teshima's, $40.00";
                cbFood3.Text = "Roy Waikiki's, $50.00";
                rdoHotel1.Text = "Royal Hawaian Resort $85.00/per night";
                rdoHotel2.Text = "Halekulani $95.00/per night";
                rdoHotel3.Text = "Aulani Disney Resort and spa $105.00/per night";
                lbSum.Items.Add(new Item("New Orleans", 550.00));
            }

        }

        private void cbAct1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAct1.Checked == true)
            {
                lbSum.Items.Add(cbAct1.Text);
            }
            else
            {
                lbSum.Items.Remove(cbAct1.Text);
            }
        }

        private void cbAct2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAct2.Checked == true)
            {
                lbSum.Items.Add(cbAct2.Text);
            }
            else
            {
                lbSum.Items.Remove(cbAct2.Text);
            }
        }

        private void cbAct3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAct3.Checked == true)
            {
                lbSum.Items.Add(cbAct3.Text);
            }
            else
            {
                lbSum.Items.Remove(cbAct3.Text);
            }
        }

        private void cbFood1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFood1.Checked == true)
            {
                lbSum.Items.Add(cbFood1.Text);
            }
            else
            {
                lbSum.Items.Remove(cbFood1.Text);
            }
        }

        private void cbFood2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFood2.Checked == true)
            {
                lbSum.Items.Add(cbFood2.Text);
            }
            else
            {
                lbSum.Items.Remove(cbFood2.Text);
            }
        }

        private void cbFood3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFood3.Checked == true)
            {
                lbSum.Items.Add(cbFood3.Text);
            }
            else
            {
                lbSum.Items.Remove(cbFood3.Text);
            }
        }

        private void gbHotel_Enter(object sender, EventArgs e)
        {
            if (rdoHotel1.Checked == true)
            {
                lbSum.Items.Add(rdoHotel1.Text);
            }
            if (rdoHotel2.Checked == true)
            {
                lbSum.Items.Add(rdoHotel2.Text);
            }
            if (rdoHotel3.Checked == true)
            {
                lbSum.Items.Add(rdoHotel3.Text);
            } 

            
        }
    }
}
