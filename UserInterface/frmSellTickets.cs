using BusinessLogicLayer;
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
    public partial class frmSellTickets : Form
    {
        public frmSellTickets()
        {
            InitializeComponent();
        }
        SellTicketManager sellTicketManager = new SellTicketManager();
        private void frmSellTickets_Load(object sender, EventArgs e)
        {
            GetTickedToGrid();
        }


        void GetTickedToGrid()
        {
            dataGridView1.DataSource = sellTicketManager.GetAllTicket();
        }
    }
}
