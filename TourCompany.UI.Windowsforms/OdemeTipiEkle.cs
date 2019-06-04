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
    public partial class OdemeTipiEkle : Form
    {
        OdemeTipiBLL _odemeTipiBLL;
        List<OdemeTipi> odemeTipi;
        OdemeTipi seciliTip;

        public OdemeTipiEkle()
        {
            InitializeComponent();
            _odemeTipiBLL = new OdemeTipiBLL();
            odemeTipi = new List<OdemeTipi>();
        }

        private void OdemeTipiEkle_Load(object sender, EventArgs e)
        {
            FillList();
        }

        private void btnTypeSave_Click(object sender, EventArgs e)
        {
            seciliTip = new OdemeTipi();
            seciliTip.Tip = txtOdemeTipi.Text;
            odemeTipi = _odemeTipiBLL.GetAll();

            foreach (OdemeTipi item in odemeTipi)
            {
                if (txtOdemeTipi.Text == item.Tip)
                {
                    throw new PaymentTypeException();
                }
            }
            try
            {
                bool result = _odemeTipiBLL.Add(seciliTip);

                if (result)
                {
                    MessageBox.Show("Ödeme tip ekleme başarılı");
                    FillList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillList()
        {
            odemeTipi = _odemeTipiBLL.GetAll();
            dgvOdemeTipi.DataSource = odemeTipi;
        }

        private void dgvOdemeTipi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPayUpdate.Text = dgvOdemeTipi.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnPayUpdate_Click(object sender, EventArgs e)
        {
            seciliTip = new OdemeTipi();
            seciliTip.TipID = (int)dgvOdemeTipi.SelectedRows[0].Cells[0].Value;

            seciliTip.Tip = txtPayUpdate.Text;
            _odemeTipiBLL.Update(seciliTip);
            FillList();
        }
    }
}
