using BusinessLogicLayer;
using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class frmAddSaloon : Form
    {
        public frmAddSaloon()
        {
            InitializeComponent();
        }
        SaloonManager saloonManager = new SaloonManager();
        private void frmAddSaloon_Load(object sender, EventArgs e)
        {
            GetSaloonsToGrid();
        }
        private void btnAddMovieSaloon_Click(object sender, EventArgs e)
        {
            Saloon addSaloon = new Saloon()
            {
                SaloonNo = txtAddMovieSaloon.Text,
                SeatNo = Convert.ToInt32(textBoxSeatNo.Text)
            };
            try
            {
                saloonManager.AddSaloon(addSaloon);
                MessageBox.Show("Saloon Başarıyla Eklendi !");
                GetSaloonsToGrid();
            }
            catch (Exception)
            {
                throw;
            }
        }

        void GetSaloonsToGrid()
        {
            try
            {
           dataGridView1.DataSource= saloonManager.GetAllSaloons();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message+"Beklenmedik Bir Hata Oluştu !");
            }
            
        }
    }
}
