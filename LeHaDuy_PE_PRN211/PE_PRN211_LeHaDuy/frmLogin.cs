using Microsoft.Extensions.Configuration;
using PE_PRN211_LeHaDuy_RePo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_PRN211_LeHaDuy
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void tbnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserID.Text.Trim() == "")
            {
                MessageBox.Show("UserID can't null");
            }
            else if(txtUserID.Text.Trim() == "")
            {
                MessageBox.Show("UserID can't null");
            }
            else
            {
                string cs = GetConnectionString();
                using (var db = new BookPubLisherContext(cs))
                {
                    var user = db.AccountUsers.Where(a => a.UserId == txtUserID.Text && a.UserPassword == txtPassword.Text)
                        .FirstOrDefault();
                    if(user == null)
                    {
                        MessageBox.Show("Invalid username or password");
                    }
                    else
                    {
                        if(user.UserRole == 2)
                        {
                            frmBookManagement frmAccountCustomer = new frmBookManagement();
                            frmAccountCustomer.Closed += (_, _) => this.Close();
                            this.Hide();
                            frmAccountCustomer.Show();
                        }
                        else
                        {
                            MessageBox.Show("You are not allowed to access this funtion");
                        }
                    }
                }
            }
        }
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:PeDB"];
            return strConn;
        }
    }
}
