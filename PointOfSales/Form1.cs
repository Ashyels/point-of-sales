using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PointOfSales
{
    public partial class Form1 : Form
    {
        DateTime tgl = DateTime.Now;
        PenjualanComponent.Penjualan penjualan = new PenjualanComponent.Penjualan();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = lv_datapenjualan.Items.Count;
            int j = i+1;

/*            string harga;
            if (cmb_kendaraan.Text == "Honda CRV")
            {
                harga = "250.000.000";
            }
            if (cmb_kendaraan.Text == "Honda Vario")
            {
                harga = "14.000.000";
            }
            if (cmb_kendaraan.Text == "Suzuki Smash")
            {
                harga = "13.000.000";
            }
*/
            if (lv_datapenjualan.Items.Count == 0)
            {
                lv_datapenjualan.Items.Add(j.ToString());
                lv_datapenjualan.Items[0].SubItems.Add(tb_tgl.Text);
                lv_datapenjualan.Items[0].SubItems.Add(tb_namakonsumen.Text);
                lv_datapenjualan.Items[0].SubItems.Add(cmb_kendaraan.Text);
//                lv_datapenjualan.Items[0].SubItems.Add(harga);

            }

            else
            {
                int k = lv_datapenjualan.Items.Count;

                lv_datapenjualan.Items.Add(j.ToString());
                lv_datapenjualan.Items[k].SubItems.Add(tb_tgl.Text);
                lv_datapenjualan.Items[k].SubItems.Add(tb_namakonsumen.Text);
                lv_datapenjualan.Items[k].SubItems.Add(cmb_kendaraan.Text);
//                lv_datapenjualan.Items[k].SubItems.Add(harga);

            }

            tb_namakonsumen.Text = "";

//            tb_kode.Focus();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

//            penjualan.TanggalPenjualan = DateTime.Now;

            cmb_kendaraan.Items.Add("Honda CRV");
            cmb_kendaraan.Items.Add("Honda Vario");
            cmb_kendaraan.Items.Add("Suzuki Smash");

            tb_tgl.Text = tgl.ToString();
        }
    }
}
