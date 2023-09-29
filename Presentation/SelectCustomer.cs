using INF2011S_Project.Hotel;
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

namespace INF2011S_Project.Presentation
{
    public partial class SelectCustomer : Form
    {
        public SelectCustomer()
        {
            InitializeComponent();
        }

        private Customer customer;

        private void SelectCustomer_Load(object sender, EventArgs e)
        {
            Collection<string> customers = Customer.GetAllCustomersByID();

            cmbCustomer.Items.AddRange(customers.ToArray());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MakeBooking.aCustomer = customer;
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            customer = new Customer();
            customer = Customer.FindCustomer(cmbCustomer.SelectedItem.ToString());

            
        }
    }
}
