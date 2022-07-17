using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class PresentationManager : Base
    {
       
        public void AddPresentations(Presentation presentation)
        {
            try
            {
                myContext.Presentation.Add(presentation);
                myContext.SaveChanges();
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Presentation> GetAllPresentations()
        {
            try
            {
                List<Presentation> presentations = myContext.Presentation.ToList();
                return presentations;
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
