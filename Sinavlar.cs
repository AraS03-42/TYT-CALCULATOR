using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace odev1
{
    public partial class Sinavlar : Form
    {
        public Sinavlar()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=sinavlar.mdb");
        OleDbCommand komut;
        OleDbDataAdapter da;
        OleDbDataReader dr;
        DataSet ds;
        int i = 0;
        void getir()
        {
            con.Open();
            da = new OleDbDataAdapter("select * from sinavlar", con);
            ds = new DataSet();
            da.Fill(ds, "sinavlar");
            dataGridView1.DataSource = ds.Tables["sinavlar"];
            for(i=0;i<dataGridView1.Rows.Count -1;i++)
            {
                
              dataGridView1.Rows[i].Cells[6].Value += " - " + dataGridView1.Rows[i].Cells[7].Value.ToString() + " - " + dataGridView1.Rows[i].Cells[8].Value.ToString();
            
            dataGridView1.Rows[i].Cells[9].Value += " - " + dataGridView1.Rows[i].Cells[10].Value.ToString()+ " - " + dataGridView1.Rows[i].Cells[11].Value.ToString();
                
            dataGridView1.Rows[i].Cells[12].Value += " - " + dataGridView1.Rows[i].Cells[13].Value.ToString() + " - " + dataGridView1.Rows[i].Cells[14].Value.ToString();
                
            dataGridView1.Rows[i].Cells[15].Value += " - " + dataGridView1.Rows[i].Cells[16].Value.ToString()+ " - " + dataGridView1.Rows[i].Cells[17].Value.ToString();

            }   
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[13].Visible = false;
                dataGridView1.Columns[14].Visible = false;
                dataGridView1.Columns[16].Visible = false;
                dataGridView1.Columns[17].Visible = false;
                con.Close();
            
           
        } 

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Sinavlar_Load(object sender, EventArgs e)
        {
            getir();
        }
    }
}
