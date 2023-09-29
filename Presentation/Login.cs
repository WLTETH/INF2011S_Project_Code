using INF2011S_Project.Data;
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
    public partial class Login : Form
    {
        public const bool DEBUG = true;
        public Login()
        {
            InitializeComponent();

            if (DEBUG)
            {
                lblDebug.Enabled = true;
                lblDebug.ForeColor = Color.Red;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!DEBUG)
            {
                string userID = edtEmpID.Text;
                string password = edtPassword.Text;

                if (string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("User ID and password cannot be empty.");
                    return;
                }

                bool valid = false;

                try
                {

                    Clerk clerk = Clerk.FindClerk(userID);

                    if (clerk != null)
                    {
                        if (clerk.CheckPassword(password))
                        {
                            valid = true;
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password! Try again.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not found! Try again.");
                    }

                    if (valid)
                    {
                        Home home = new Home();
                        home.MdiParent = this.MdiParent;
                        home.Show();
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                Home home = new Home();
                home.MdiParent = this.MdiParent;
                home.Show();
                this.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
