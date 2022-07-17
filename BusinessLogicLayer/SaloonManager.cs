using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class SaloonManager:Base
    {
        public List<Saloon> GetAllSaloons()
        {
            try
            {
            return myContext.SaloonTable.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void AddSaloon(Saloon addSaloon)
        {
            try
            {
                myContext.SaloonTable.Add(addSaloon);
                myContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
