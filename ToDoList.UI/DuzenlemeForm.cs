using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.Data;

namespace ToDoList.UI
{
    public partial class DuzenlemeForm : Form
    {
        private readonly Not _not;
        public DuzenlemeForm(Not not)
        {
            _not = not;
            InitializeComponent();
            NotuYaz();
            Degisen(_not);
        }

        private void Degisen(Not not)
        {
            not.Metin = txtYapilan.Text;
            not.Zaman = dtpZaman.Value;
        }

        private void NotuYaz()
        {
            txtYapilan.Text = _not.Metin;
            dtpZaman.Value = _not.Zaman;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _not.Metin = txtYapilan.Text;
            _not.Zaman = dtpZaman.Value;
            Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            new AnaForm().Refresh();
        }
    }
}
