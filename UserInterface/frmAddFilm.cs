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
    public partial class frmAddFilm : Form
    {
        public frmAddFilm()
        {
            InitializeComponent();
        }
        MovieManager movieManager = new MovieManager();
        MovieTypeManager movieTypeManager = new MovieTypeManager();
      private void frmAddFilm_Load(object sender, EventArgs e)
        {
            GetMovieTypeToGrid();
            GetMovieTypeToCombo();
        }
            
        
        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            try
            {
                Movies addMovie = new Movies()
                {
                    Name = txtMovieName.Text,
                    MovieTypeID = Convert.ToByte(cBoxMovieType.SelectedValue),
                    Director = txtDirector.Text,
                    Duration = txtDuration.Text,
                };
                movieManager.AddMovies(addMovie);
                MessageBox.Show("Film Başarıyla Eklendi !");
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message +"Beklenmedik Bir Hata Oluştu");
            }
        }

        private void btnAddMovieType_Click(object sender, EventArgs e)
        {
            try
            {
                MovieType movieType = new MovieType()
                {
                    TypeName = txtAddMovieType.Text,
                };
                movieTypeManager.AddMovieType(movieType);
                MessageBox.Show("Film Türü Başarıyla Eklendi !");
                GetMovieTypeToGrid();
                GetMovieTypeToCombo();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message+"Beklenmedik Bir Hata Oluştu !");
            }

        }

        void GetMovieTypeToCombo()
        {
            cBoxMovieType.ValueMember = "Id";
            cBoxMovieType.DisplayMember = "TypeName";
            try
            {
                cBoxMovieType.DataSource = movieTypeManager.AllMovieType();
            }
            catch (Exception)
            {

                throw;
            }
        }

        void GetMovieTypeToGrid()
        {
            try
            {
                dataGridView1.DataSource = movieTypeManager.AllMovieType();
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
