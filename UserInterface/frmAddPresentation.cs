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
    public partial class frmAddPresentation : Form
    {
        PresentationManager presentationManager = new PresentationManager();

        MovieManager movieManager = new MovieManager();

        SessionManager sessionManager = new SessionManager();

        SaloonManager saloonManager = new SaloonManager();

        public frmAddPresentation()
        {
            InitializeComponent();
        }

        private void frmAddPresentation_Load(object sender, EventArgs e)
        {
            GetAllPresentations();
            GetSaloonIdAndNameToCombo();
            GetSessionIdAndNameToCombo();
            GetMovieIdAndNameToCombo();
            ColumnVisible();
        }

        private void btnAddPresentation_Click(object sender, EventArgs e)
        {
            Presentation presentation = new Presentation()
            {
                IsPresentation = true,
                MovieID = Convert.ToInt32(comboBoxMovie.SelectedValue),
                SaloonID = Convert.ToByte(comboBoxSaloon.SelectedValue),
                SessionID = Convert.ToByte(comboBoxSession.SelectedValue)
            };
            presentationManager.AddPresentations(presentation);
            MessageBox.Show("Added");
            GetAllPresentations();
        }


        void GetMovieIdAndNameToCombo()
        {
            comboBoxMovie.DisplayMember = "Name";
            comboBoxMovie.ValueMember = "ID";
            comboBoxMovie.DataSource = movieManager.GetAllMovies();

        }

        void GetSessionIdAndNameToCombo()
        {
            comboBoxSession.DisplayMember = "MovieSession";
            comboBoxSession.ValueMember = "ID";
            comboBoxSession.DataSource = sessionManager.GetAllSession();

        }

        void GetSaloonIdAndNameToCombo()
        {
            comboBoxSaloon.DisplayMember = "SaloonNo";
            comboBoxSaloon.ValueMember = "ID";
            comboBoxSaloon.DataSource = saloonManager.GetAllSaloons();

        }
        void GetAllPresentations()
        {
            dataGridView1.DataSource = presentationManager.GetAllPresentations();
        }

        void ColumnVisible()
        {
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }


    }
}
