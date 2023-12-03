using crud_database.classes;
using Microsoft.Data.SqlClient;
using System;
using System.Data;


namespace crud_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TabelMahasiswa();
        }

        void TabelMahasiswa()
        {
            List<dataadmin> Mhslist = new List<dataadmin>();
            dataadmin Mahasiswa = new dataadmin();
            Mhslist = Mahasiswa.Getadmin();

            tblMhs.DataSource = Mhslist;


        }

        private void btnTambahdata_Click(object sender, EventArgs e)
        {
            new tambahdata().Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tblMhs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            TabelMahasiswa();
        }

        private void btnUbahdata_Click(object sender, EventArgs e)
        {
            editData();
        }
        void editData()
        {
            int id_admin;

            id_admin = (int)tblMhs.CurrentRow.Cells[0].Value;

            ubahdata formubahdata = new ubahdata(id_admin);
            formubahdata.ShowDialog();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            Hapusdataadmin();
        }

        void Hapusdataadmin()
        {
            int id_admin;

            id_admin = (int)tblMhs.CurrentRow.Cells[0].Value;

            dataadmin admin = new dataadmin();
            admin.Hapusdata(id_admin);
            TabelMahasiswa();

        }
    }

}