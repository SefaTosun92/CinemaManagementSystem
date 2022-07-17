using EntityLayer.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicLayer
{
    public class MovieManager : Base
    {
        public List<Movies> GetAllMovies()
        {
            try
            {
                return myContext.MoviesTable.ToList();
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public void AddMovies(Movies addmovie)
        {
            try
            {
                myContext.MoviesTable.Add(addmovie);
                myContext.SaveChanges();
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
