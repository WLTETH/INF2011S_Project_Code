using INF2011S_Project.Hotel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF2011S_Project
{
    public partial class BookingDetails : Form
    {
        public BookingDetails()
        {
            InitializeComponent();
        }

        public BookingDetails(Booking booking)
        {
            InitializeComponent();
            lblBookID.Text = "Booking ID: " + booking.GetID();
            lblDuration.Text = "Duration of Stay: " + booking.GetDuration();
            lblCheckin.Text = "Check-in Date: NEED TO UPDATE DATABASE";
            lblCustID.Text = "CustomerID: NEED TO UPDATE DATABASE";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditBooking editBooking = new EditBooking();
            editBooking.MdiParent = this.MdiParent;
            editBooking.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // mark is checked in or checked out
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerDetails customerDetails = new CustomerDetails();
            customerDetails.MdiParent = this.MdiParent;
            customerDetails.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
