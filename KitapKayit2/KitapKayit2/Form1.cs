using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace KitapKayit2
{
    public partial class Form1 : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kutuphane.accdb");
        OleDbCommand command = new OleDbCommand();
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        DataSet dataset = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }
        void ListeGoster()    //DATA GR�DE VER�LER� AKTARMA
        {
            connection.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from kutuphane", connection);
            adapter.Fill(dataset, "kutuphane");
            dataGridView1.DataSource = dataset.Tables["kutuphane"];
            adapter.Dispose();
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)  //KAYIT BUTONU
        {
            resim.Text = pictureBox1.ImageLocation;
            if (seri_no.Text != "" && ad.Text != "" && yazar.Text != "" && basim_tarihi.Text != "" && sayfa_sayisi.Text != "" && t�r.Text != "" && yayin_evi.Text != "" && resim.Text != "")
            {
                command.Connection = connection;
                command.CommandText = "Insert Into kutuphane(seri_no,ad,yazar,basim_tarihi,sayfa_sayisi,t�r,yayin_evi,resim) Values ('" + seri_no.Text + "','" + ad.Text + "','" + yazar.Text + "','" + basim_tarihi.Text + "','" + sayfa_sayisi.Text + "','" + t�r.Text + "','" + yayin_evi.Text + "','" + resim.Text + "')";
                connection.Open();
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show("Kay�t Tamamland�!");
                dataset.Clear();
                ListeGoster();
            }
            else
            {
                MessageBox.Show("Bo� alan ge�meyiniz!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListeGoster();
        }

        private void button2_Click(object sender, EventArgs e)  //S�LME BUTONU
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = "Delete from kutuphane where seri_no=" + seri_no.Text + "";
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            dataset.Clear();
            ListeGoster();
        }

        private void button3_Click(object sender, EventArgs e)  //ARAMA BUTONU
        {
            connection = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=kutuphane.accdb");
            adapter = new OleDbDataAdapter("Select * from kutuphane where ad like '" + ad.Text + "%'", connection);
            dataset = new DataSet();
            connection.Open();
            adapter.Fill(dataset, "kutuphane");
            dataGridView1.DataSource = dataset.Tables["kutuphane"];
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)     //G�NCELLEME BUTONU
        {
            command = new OleDbCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = " update kutuphane set ad='" + ad.Text + "', yazar='" + yazar.Text + "', basim_tarihi='" + basim_tarihi.Text + "', sayfa_sayisi='" + sayfa_sayisi.Text + "',t�r='" + t�r.Text + "',yayin_evi='" + yayin_evi.Text + "',resim='" + resim.Text +"' where seri_no=" + seri_no.Text + "";
            command.ExecuteNonQuery();
            connection.Close();
            dataset.Clear();
            ListeGoster();
        }

        private void button5_Click(object sender, EventArgs e)   //RES�M EKLEME BUTONU
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)  //TIKLADI�IMIZ VER�LER�N G�STER�LMES�
        {
            seri_no.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            yazar.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            basim_tarihi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            sayfa_sayisi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            t�r.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            yayin_evi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }
    }
}