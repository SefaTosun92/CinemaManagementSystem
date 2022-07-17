using EntityLayer.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicLayer
{
    public class MovieTypeManager : Base
    {
        public List<MovieType> AllMovieType()
        {
            try
            {
            return myContext.MovieTypeTable.ToList();
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public void AddMovieType(MovieType addMovieType)
        {
            try
            {
                myContext.MovieTypeTable.Add(addMovieType);
                myContext.SaveChanges();
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
