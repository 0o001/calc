using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class frm_calc : Form
    {
        public frm_calc()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            txt_calc.Text += ((Button)sender).Text;

            txt_calc.SelectionStart = txt_calc.Text.Length;
            txt_calc.Focus();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_calc.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (txt_calc.Text.Length > 0)
            {
                txt_calc.Text = txt_calc.Text.Substring(0, txt_calc.Text.Length - 1);
            }
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            try
            {
                txt_calc.Text = new DataTable().Compute(txt_calc.Text, null).ToString();              
            }
            catch
            {
            }
        }

        private void txt_calc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || new char[] { '.', ',', '(', ')', '/', '*', '-', '+' }.Contains(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_calc.PerformClick();

                return;
            }

            e.Handled = true;
        }
    }
}
