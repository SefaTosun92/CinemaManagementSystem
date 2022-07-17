using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class SellTicketManager:Base
    {
        public List<SellTicket> GetAllTicket()
        {
            try
            {
                return myContext.SellTicketTable.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AddSellTicket(SellTicket addsellticket)
        {
            try
            {
                myContext.SellTicketTable.Add(addsellticket);
                myContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
