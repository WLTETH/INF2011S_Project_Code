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
using INF2011S_Project.Hotel;

namespace INF2011S_Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakeBooking makeBooking = new MakeBooking();
            makeBooking.MdiParent = this.MdiParent;
            makeBooking.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoomAvailability roomAvailability = new RoomAvailability();
            roomAvailability.MdiParent = this.MdiParent;
            roomAvailability.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Collection<string> customers = Customer.GetAllCustomersByID();
            Collection<string> bookings = Booking.GetAllBookingsByID();

            cmbCustomer.Items.AddRange(customers.ToArray());
            cmbBooking.Items.AddRange(bookings.ToArray());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer = Customer.FindCustomer(cmbCustomer.SelectedItem.ToString());

            CustomerDetails customerDetails = new CustomerDetails(customer);
            customerDetails.MdiParent = this.MdiParent;
            customerDetails.Show();
        }

        private void cmbBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking = Booking.FindBooking(cmbBooking.SelectedItem.ToString());

            BookingDetails bookingDetails = new BookingDetails(booking);
            bookingDetails.MdiParent = this.MdiParent;
            bookingDetails.Show();
        }
    }
}
