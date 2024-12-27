using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bufe_Satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasaTutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int popcorn, ticket, water, tea,total;
            popcorn = Convert.ToInt16(txtPopcorn.Text);
            ticket = Convert.ToInt16(txtTicket.Text);
            water = Convert.ToInt16(txtWater.Text);
            tea = Convert.ToInt16(txtTea.Text);

            total = popcorn * 40 + ticket * 35 + water * 10 + tea * 10; 
            lblTotal.Text = total.ToString() +"TL";

            kasaTutar = kasaTutar + total;
            lblCashRegister.Text = kasaTutar.ToString() + "TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTicket.Text = "";
            txtTea.Text = "";
            txtWater.Text = "";
            txtPopcorn.Text = "";
            txtPopcorn.Focus();
        }
    }
}
