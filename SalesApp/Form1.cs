using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string name;
            Double price;
            Double amount;
            Double total;
            name = txtItemName.Text;
            price = Convert.ToDouble(txtPrice.Text);
            amount = Convert.ToDouble(txtAmount.Text);
            total = price * amount;
            txtTotal.Text = Convert.ToString(total);
            MessageBox.Show("thanks your shopping our shop..This item" );
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
