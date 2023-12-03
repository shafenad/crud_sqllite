using crud_database.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_database
{
    public partial class ubahdata : Form
    {
        int selectedid_admin;
        public ubahdata(int id_admin )
        {
            InitializeComponent();
            selectedid_admin = id_admin;
            getDataadmin();
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            EditDataadmin();
            this.Close();
        }

        void getDataadmin()
        {
            dataadmin admin = new dataadmin();
            admin = admin.GetDataadmin(selectedid_admin);

            tbxemail.Text = admin.email;
            tbxpass.Text = admin.password;
        }

        void EditDataadmin()
        {
            dataadmin admin = new dataadmin();

            admin.id_admin = selectedid_admin;
            admin.email = tbxemail.Text;
            admin.password = tbxpass.Text;

            admin.Editdata(admin);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void ubahdata_Load(object sender, EventArgs e)
        {

        }
    }
}
