using INF2011S_Project.Hotel;
using INF2011S_Project.Presentation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF2011S_Project
{
    public partial class MakeBooking : Form
    {
        public MakeBooking()
        {
            InitializeComponent();
        }

        public void RefreshInfo()
        {
            if (selected)
            {
                txtCustName.Text =  aCustomer.GetName();
                custID = aCustomer.GetID();
                selected = false;
            }
        }

        public static Customer aCustomer;
        HotelBrand hotel;
        bool selected = false;
        string custID;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectCustomer selectCustomer = new SelectCustomer();
            selectCustomer.MdiParent = this.MdiParent;
            selected = true;
            selectCustomer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateCustomer createCustomer = new CreateCustomer();
            createCustomer.MdiParent = this.MdiParent;
            createCustomer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MakeBooking_Activated(object sender, EventArgs e)
        {
            RefreshInfo();
        }

        private void MakeBooking_Load(object sender, EventArgs e)
        {
            Collection<string> hotels = HotelBrand.GetAllHotelsByName();

            cmbHotel.Items.AddRange(hotels.ToArray());
        }

        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            if (aCustomer == null)
            {
                MessageBox.Show("Please select a customer first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (hotel == null)
            {
                MessageBox.Show("Please select a hotel first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                Booking booking = new Booking();
                bool result = booking.CreateBooking((int)numDuration.Value, hotel.GetID(), (int)numRoomNum.Value, int.Parse(custID), dtpCheckin.Value);
                if (result)
                {
                    MessageBox.Show("Successfully added booking!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add booking!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            hotel = new HotelBrand();
            hotel = HotelBrand.FindHotel((cmbHotel.SelectedIndex + 1).ToString());
        }
    }
}
