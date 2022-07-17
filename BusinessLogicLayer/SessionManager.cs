using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class SessionManager:Base
    {
        public void AddSession(Session addSession)
        {
            try
            {
                myContext.SessionTable.Add(addSession);
                myContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Session> GetAllSession()
        {
            try
            {
                return myContext.SessionTable.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
