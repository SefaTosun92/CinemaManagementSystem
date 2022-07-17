using BusinessLogicLayer;
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
    public partial class frmAddSession : Form
    {
        public frmAddSession()
        {
            InitializeComponent();
        } 
        private void frmAddSession_Load(object sender, EventArgs e)
        {
            GetSessionToGrid();
        }
        SessionManager sessionManager = new SessionManager();
        private void btnAddMovieSession_Click(object sender, EventArgs e)
        {
            Session addSession = new Session()
            {
                MovieSession = txtAddMovieSession.Text,
            };
            try
            {
                sessionManager.AddSession(addSession);
                MessageBox.Show("Session Başarıyla Eklendi");
                GetSessionToGrid();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message + "Beklenmedik Bir Hata Oluştu !");
            }
            
        }
        void GetSessionToGrid()
        {
            dataGridView1.DataSource = sessionManager.GetAllSession();
        }

       
    }
}
