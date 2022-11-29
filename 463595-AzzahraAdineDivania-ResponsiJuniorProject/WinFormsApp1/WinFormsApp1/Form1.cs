using Npgsql;
using System.Data;
using System.Data.Common;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connString = "Host=localhost;Username=postgres;Password=informatika;Port=2022;Database=Karyawan;";
        public DataTable dt;
        private string sql = null;
        public static NpgsqlCommand cmd;
        private DataGridViewRow r;


        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connString);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvKaryawan.DataSource = dt;
                sql = "select * from karyawan_r()";
                cmd = new NpgsqlCommand(sql, conn); 
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvKaryawan.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Failed to Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                int idDepartemen = 0;

                if (rb1.Checked)
                    idDepartemen = 1;
                else if (rb2.Checked)
                    idDepartemen = 2;
                else if (rb3.Checked)
                    idDepartemen = 3;
                else if (rb4.Checked)
                    idDepartemen = 4;
                else 
                    idDepartemen = 5;

                sql = @"select * from karyawan_c(:_nama, :_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_id_dep", idDepartemen);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Berhasil Diinputkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoad.PerformClick();
                    tbNama.Text  = null;
                    idDepartemen = 0;
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Invalid Data", "Gagal Menginsertkan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon Pilih Row Data yang Ingin Dihapus", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn.Open();

                int idDepartemen = 0;

                if (rb1.Checked)
                    idDepartemen = 1;
                else if (rb2.Checked)
                    idDepartemen = 2;
                else if (rb3.Checked)
                    idDepartemen = 3;
                else if (rb4.Checked)
                    idDepartemen = 4;
                else
                    idDepartemen = 5;

                sql = @"select * from karyawan_u(:_id_karyawan, :_nama,:_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["_id_karyawan"].Value.ToString());
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_id_dep", idDepartemen);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Berhasil DiEdit", "Update Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoad.PerformClick();
                    tbNama.Text = null;
                    idDepartemen = 0;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Invalid Data", "Gagal Mengupdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvKaryawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvKaryawan.Rows[e.RowIndex];
                tbNama.Text = r.Cells["_nama"].Value.ToString();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon Pilih Row Data yang Ingin Dihapus", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(MessageBox.Show ("Apakah yakin ingin menghapus data " + r.Cells["_nama"].Value.ToString() + "?", "Hapus data terkonfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            try
            {
                conn.Open();

                int idDepartemen = 0;

                if (rb1.Checked)
                    idDepartemen = 1;
                else if (rb2.Checked)
                    idDepartemen = 2;
                else if (rb3.Checked)
                    idDepartemen = 3;
                else if (rb4.Checked)
                    idDepartemen = 4;
                else
                    idDepartemen = 5;

                sql = @"select * from karyawan_d(:_id_karyawan)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["_id_karyawan"].Value.ToString());
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Berhasil Dihapus", "Delete Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoad.PerformClick();
                    tbNama.Text = null;
                    idDepartemen = 0;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Invalid Data", "Gagal Menghapus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}