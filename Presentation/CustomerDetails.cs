using System;
using System.Collections.Generic;
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
    public partial class CustomerDetails : Form
    {
        public CustomerDetails()
        {
            InitializeComponent();
        }

        public CustomerDetails(Customer customer)
        {
            InitializeComponent();
            lblName.Text = "Name: " + customer.GetName();
            lblID.Text = "CustomerID: " + customer.GetID();
            lblPhone.Text = "Phone Number: " + customer.GetPhone();
            lblCare.Text = "Requires Special Care: " + customer.GetCare();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditBooking editBooking = new EditBooking();
            editBooking.MdiParent = this.MdiParent;
            editBooking.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreditStatus creditStatus = new CreditStatus();
            creditStatus.MdiParent = this.MdiParent;
            creditStatus.Show();
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

        private void CustomerDetails_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
