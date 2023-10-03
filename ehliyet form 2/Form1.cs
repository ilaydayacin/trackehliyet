using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ehliyet_form_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesaplama_Click(object sender, EventArgs e)
        {
            int yas;
            yas = Convert.ToInt32(tbYas.Value);

            if (yas < 18)
            {
                lblSonuc.Text = "Ehliyet almaya uygun mu: Uygun değil";
            }
            if (yas >= 18) 
            {
                lblSonuc.Text = "Ehliyet almaya uygun mu: Uygun";
            }
        }

        private void tbYas_ValueChanged(object sender, EventArgs e)
        {
            lblRenk.Text = tbYas.Value.ToString();
        }
    }
}
