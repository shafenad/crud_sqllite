using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using crud_database.classes;

namespace crud_database
{
    public partial class tambahdata : Form
    {
        public tambahdata()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {


        }

        void simpanDatabase()
        {
            dataadmin Mhs = new dataadmin();

            Mhs.id_admin = Convert.ToInt32(tbxid.Text);
            Mhs.email = tbxemail.Text;
            Mhs.password = tbxpass.Text;

            Mhs.Createadmin(Mhs);
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            simpanDatabase();
            this.Close();
            new Form1().Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbxid_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbxemail_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbxpass_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void tambahdata_Load(object sender, EventArgs e)
        {

        }
    }
}
