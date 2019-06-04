using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourCompany.BLL;
using TourCompany.CustomException;
using TourCompany.Model;

namespace TourCompany.UI.Windowsforms
{
    public partial class GezilecekYerEkle : Form
    {
        GezilecekYerBLL _gezilecekYerBLL;
        List<GezilecekYer> gezilecekYerler;
        GezilecekYer seciliYer;

        public GezilecekYerEkle()
        {
            InitializeComponent();
            _gezilecekYerBLL = new GezilecekYerBLL();
            gezilecekYerler = new List<GezilecekYer>();
        }

        private void GezilecekYerEkle_Load(object sender, EventArgs e)
        {
            FillList();
        }

        private void FillList()
        {
            gezilecekYerler = _gezilecekYerBLL.GetAll();
            dgvGezilecekYerler.DataSource = gezilecekYerler;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            seciliYer = new GezilecekYer();
            seciliYer.YerAdi = txtYerAdi.Text;
            seciliYer.Ucret = Convert.ToDecimal(txtUcret.Text);
            seciliYer.Dolar = Convert.ToDecimal(txtDolar.Text);
            seciliYer.Euro = Convert.ToDecimal(txtEuro.Text);
            gezilecekYerler = _gezilecekYerBLL.GetAll();

            foreach (GezilecekYer item in gezilecekYerler)
            {
                if (txtYerAdi.Text == item.YerAdi)
                {
                    throw new GezilecekYerException();
                }
            }
            try
            {
                bool result = _gezilecekYerBLL.Add(seciliYer);

                if (result)
                {
                    MessageBox.Show("Güzergah ekleme başarılı");
                    FillList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvGezilecekYerler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtYerAdi.Text = dgvGezilecekYerler.SelectedRows[0].Cells[1].Value.ToString();
            txtUcret.Text = dgvGezilecekYerler.SelectedRows[0].Cells[2].Value.ToString();
            txtDolar.Text = dgvGezilecekYerler.SelectedRows[0].Cells[3].Value.ToString();
            txtEuro.Text = dgvGezilecekYerler.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            seciliYer = new GezilecekYer();
            seciliYer.YerID = (int)dgvGezilecekYerler.SelectedRows[0].Cells[0].Value;
            seciliYer.YerAdi = txtYerAdi.Text;
            seciliYer.Ucret = Convert.ToDecimal(txtUcret.Text);
            seciliYer.Dolar = Convert.ToDecimal(txtDolar.Text);
            seciliYer.Euro = Convert.ToDecimal(txtEuro.Text);
            _gezilecekYerBLL.Update(seciliYer);
            FillList();
        }

        private void txtUcret_Leave(object sender, EventArgs e)
        {
            txtDolar.Text = (Convert.ToInt32(txtUcret.Text) / 6.09).ToString();
            txtEuro.Text = (Convert.ToInt32(txtUcret.Text) / 6.80).ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            seciliYer = new GezilecekYer();
            seciliYer.YerID = (int)dgvGezilecekYerler.SelectedRows[0].Cells[0].Value;
            try
            {
                bool result = _gezilecekYerBLL.Remove(seciliYer);

                if (result)
                {
                    MessageBox.Show("Güzergah silme başarılı");
                    FillList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FillList();
        }
    }
}
