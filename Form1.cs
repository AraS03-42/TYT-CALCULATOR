using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace odev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=sinavlar.mdb");
        OleDbCommand komut;
        OleDbDataAdapter da;
        OleDbDataReader dr;
        DataSet ds;

        
        void tythesap()
        {
            double a, b, c, d, e,f=0;
            a = Convert.ToDouble(textBox2.Text);
            b = Convert.ToDouble(textBox6.Text);
            c = Convert.ToDouble(textBox7.Text);
            d = Convert.ToDouble(textBox10.Text);
            e = Convert.ToDouble(textBox13.Text);
            f = a + 100 + (b * 3.3) + (c * 3.4) + (d * 3.3) + (e * 3.4);
            textBox16.Text = f.ToString();
        }
        int sayi = 0;

       
      
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            if (textBox4.Text == "")
            {
                textBox4.Text = 0.ToString();
            }
            else { }
            if (textBox9.Text == "")
            {
                textBox9.Text = 0.ToString();
            }
            else { }
            if (textBox6.Text == "")
            {
                textBox6.Text = 0.ToString();
            }
            else { }
            if (textBox5.Text == "")
            {
                textBox5.Text = 0.ToString();
            }
            else { }
            if (textBox8.Text == "")
            {
                textBox8.Text = 0.ToString();
            }
            else { }
            if (textBox7.Text == "")
            {
                textBox7.Text = 0.ToString();
            }
            else { }

            if (textBox12.Text == "")
            {
                textBox12.Text = 0.ToString();
            }
            else { }
            if (textBox11.Text == "")
            {
                textBox11.Text = 0.ToString();
            }
            else { }
            if (textBox15.Text == "")
            {
                textBox15.Text = 0.ToString();
            }
            else { }

            if (textBox10.Text == "")
            {
                textBox10.Text = 0.ToString();
            }
            else { }
            if (textBox14.Text == "")
            {
                textBox14.Text = 0.ToString();
            }
            else { }
            if (textBox13.Text == "")
            {
                textBox13.Text = 0.ToString();
            }
            else { }
        }

        private void button1_Click(object sender, EventArgs e)
        {if (string.IsNullOrEmpty(textBox2.Text))
            { MessageBox.Show("Diploma notunuzu giriniz"); }
           else
            
            {
                tythesap();                            
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double c = 0, a;
            if (textBox2.Text == "")
            {
                textBox2.Text = "50";
                a = Convert.ToDouble(textBox2.Text);
                if (a >= 101)
                { MessageBox.Show("Lütfen 50-100 arasında bir değer giriniz."); }
                else
                {
                    a = Convert.ToDouble(textBox2.Text);
                    c = a * 0.6;
                    textBox3.Text = c.ToString();
                }
            }
            else
            {
                a = Convert.ToDouble(textBox2.Text);
                c = a * 0.6;
                textBox3.Text = c.ToString();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double c = 0, a, b;
            if (textBox4.Text == "" && textBox5.Text == "")
            {
                a = 0;
                b = 0;
            }
            else if (textBox4.Text == "")
            { a = 0; }
            else if (textBox5.Text == "")
            { b = 0; }
            else
            {
                a = Convert.ToInt16(textBox4.Text);
                b = Convert.ToInt16(textBox5.Text);
                a = a * 1;
                b = b * 0.25;
                if (a < b)
                {
                    c = 0;
                    textBox6.Text = c.ToString();
                }
                else
                {
                    c = a - b;
                    textBox6.Text = c.ToString();
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            double c = 0, a, b;
            if (textBox4.Text == "" && textBox5.Text == "")
            {
                a = 0;
                b = 0;
            }
            else if (textBox4.Text == "")
            { a = 0; }
            else if (textBox5.Text == "")
            { b = 0; }
            else
            {
                a = Convert.ToInt16(textBox4.Text);
                b = Convert.ToInt16(textBox5.Text);
                a = a * 1;
                b = b * 0.25;
                if (a < b)
                {
                    c = 0;
                    textBox6.Text = c.ToString();
                }
                else
                {
                    c = a - b;
                    textBox6.Text = c.ToString();
                }
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            double c = 0, a, b;
            if (textBox7.Text == "" && textBox8.Text == "")
            {
                a = 0;
                b = 0;
            }
            else if (textBox7.Text == "")
            { a = 0; }
            else if (textBox8.Text == "")
            { b = 0; }
            else
            {
                a = Convert.ToInt16(textBox7.Text);
                b = Convert.ToInt16(textBox8.Text);
                a = a * 1;
                b = b * 0.25;
                if (a < b)
                {
                    c = 0;
                    textBox9.Text = c.ToString();
                }
                else
                {
                    c = a - b;
                    textBox9.Text = c.ToString();
                }
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            double c = 0, a, b;
            if (textBox10.Text == "" && textBox11.Text == "")
            {
                a = 0;
                b = 0;
            }
            else if (textBox10.Text == "")
            { a = 0; }
            else if (textBox11.Text == "")
            { b = 0; }
            else
            {
                a = Convert.ToInt16(textBox10.Text);
                b = Convert.ToInt16(textBox11.Text);
                a = a * 1;
                b = b * 0.25;
                if (a < b)
                {
                    c = 0;
                    textBox12.Text = c.ToString();
                }
                else
                {
                    c = a - b;
                    textBox12.Text = c.ToString();
                }
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            double c = 0, a, b;
            if (textBox13.Text == "" && textBox14.Text == "")
            {
                a = 0;
                b = 0;
            }
            else if (textBox13.Text == "")
            { a = 0; }
            else if (textBox14.Text == "")
            { b = 0; }
            else
            {
                a = Convert.ToInt16(textBox13.Text);
                b = Convert.ToInt16(textBox14.Text);
                a = a * 1;
                b = b * 0.25;
                if (a < b)
                {
                    c = 0;
                    textBox15.Text = c.ToString();
                }
                else
                {
                    c = a - b;
                    textBox15.Text = c.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            sayi = sayi + 1;
            string a, b,c, c1,c2,d, d1,d2, e1,e2,e3,f, f1,f2, g1; ;
            a = textBox1.Text;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            b = dateTimePicker1.Text;
            double a1, b1;
            a1 = Convert.ToDouble(textBox2.Text);
            b1 = Convert.ToDouble(textBox3.Text);
             c = textBox4.Text;
            c1 = textBox5.Text;
            c2 = textBox6.Text;
             d = textBox7.Text;
            d1 = textBox8.Text;
            d2 = textBox9.Text;
            e1 = textBox10.Text;
            e2 = textBox11.Text;
            e3 = textBox12.Text;
            f = textBox13.Text;
            f1 = textBox14.Text;
            f2 = textBox15.Text;
            g1 = textBox16.Text;


            if (textBox1.Text=="")
            {
                MessageBox.Show("Boş Alan Bırakmayın"); 

            }
            else
            {
                try
                {
                    con.Close();

                    con.Open();
                    komut = new OleDbCommand("select *from sinavlar", con);
                    komut.Connection = con;
                    komut.CommandText = "insert into sinavlar(sira,sinav_adi,sinav_tarihi,diploma_puani,obp,t_dogru,t_yanlis,t_net,sosyal_dogru,sosyal_yanlis,sosyal_net,mat_dogru,mat_yanlis,mat_net,fen_dogru,fen_yanlis,fen_net,tyt_puan) values(sira,sinav_adi,sinav_tarihi,diploma_puani,obp,t_dogru,t_yanlis,t_net,sosyal_dogru,sosyal_yanlis,sosyal_net,mat_dogru,mat_yanlis,mat_net,fen_dogru,fen_yanlis,fen_net,tyt_puan)";
                    komut.Parameters.AddWithValue("sira", sayi);
                    komut.Parameters.AddWithValue("sinav_adi", a);
                    komut.Parameters.AddWithValue("sinav_tarihi", b);
                    komut.Parameters.AddWithValue("diploma_puani", a1);
                    komut.Parameters.AddWithValue("obp", b1);
                    komut.Parameters.AddWithValue("t_dogru", c);
                    komut.Parameters.AddWithValue("t_yanlis", c1);
                    komut.Parameters.AddWithValue("t_net", c2);
                    komut.Parameters.AddWithValue("sosyal_dogru", d);
                    komut.Parameters.AddWithValue("sosyal_yanlis", d1);
                    komut.Parameters.AddWithValue("sosyal_net", d2);
                    komut.Parameters.AddWithValue("mat_dogru", e1);
                    komut.Parameters.AddWithValue("mat_yanlis", e2);
                    komut.Parameters.AddWithValue("mat_net", e3);
                    komut.Parameters.AddWithValue("fen_dogru", f);
                    komut.Parameters.AddWithValue("fen_yanlis", f1);
                    komut.Parameters.AddWithValue("fen_net", f2);
                    komut.Parameters.AddWithValue("tyt_puan", g1);
                    int sonuc = komut.ExecuteNonQuery();
                    
                    

                }
                

                catch (Exception hata)
                { MessageBox.Show("" + hata); }
                
               
              
               

               

            }
                
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            double c = 0, a, b;
            if (textBox7.Text == "" && textBox8.Text == "")
            {
                a = 0;
                b = 0;
            }
            else if (textBox7.Text == "")
            { a = 0; }
            else if (textBox8.Text == "")
            { b = 0; }
            else
            {
                a = Convert.ToInt16(textBox7.Text);
                b = Convert.ToInt16(textBox8.Text);
                a = a * 1;
                b = b * 0.25;
                if (a < b)
                {
                    c = 0;
                    textBox9.Text = c.ToString();
                }
                else
                {
                    c = a - b;
                    textBox9.Text = c.ToString();
                }
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            double c = 0, a, b;
            if (textBox10.Text == "" && textBox11.Text == "")
            {
                a = 0;
                b = 0;
            }
            else if (textBox10.Text == "")
            { a = 0; }
            else if (textBox11.Text == "")
            { b = 0; }
            else
            {
                a = Convert.ToInt16(textBox10.Text);
                b = Convert.ToInt16(textBox11.Text);
                a = a * 1;
                b = b * 0.25;
                if (a < b)
                {
                    c = 0;
                    textBox12.Text = c.ToString();
                }
                else
                {
                    c = a - b;
                    textBox12.Text = c.ToString();
                }
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            double c = 0, a, b;
            if (textBox13.Text == "" && textBox14.Text == "")
            {
                a = 0;
                b = 0;
            }
            else if (textBox13.Text == "")
            { a = 0; }
            else if (textBox14.Text == "")
            { b = 0; }
            else
            {
                a = Convert.ToInt16(textBox13.Text);
                b = Convert.ToInt16(textBox14.Text);
                a = a * 1;
                b = b * 0.25;
                if (a < b)
                {
                    c = 0;
                    textBox15.Text = c.ToString();
                }
                else
                {
                    c = a - b;
                    textBox15.Text = c.ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sinavlar goster = new Sinavlar();
            goster.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
