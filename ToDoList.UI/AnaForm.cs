using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.Data;

namespace ToDoList.UI
{
    public partial class AnaForm : Form
    {
        private List<Not> _notlar;
        private BindingList<Not> _blNotlar;
        public AnaForm()
        {
            NotlariOku();
            InitializeComponent();
            lblZaman.Text = DateTime.Now.ToShortTimeString();            
            Listele();
        }

        private void NotlariOku()
        {
            _notlar = new List<Not>();
            _blNotlar = new BindingList<Not>(_notlar);
        }

        private void Listele()
        {
            lstNotlar.DataSource = _blNotlar;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var icerik = txtNot.Text;

            if(icerik == "")
            {
                MessageBox.Show("Lütfen notunuzu giriniz.");
                return;
            }

            _notlar.Add(new Not(icerik));
            _notlar.Sort();
            _blNotlar.ResetBindings();
            txtNot.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _notlar.Remove((Not)lstNotlar.SelectedItem);
            Listele();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            new DuzenlemeForm((Not)lstNotlar.SelectedItem).ShowDialog();
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Not n = (Not)lstNotlar.SelectedItem;

            if (n.YildizliMi == false)
            {
                n.YildizliMi = true;
                button1.Text = "☆";
                Listele();
            }
            else if (n.YildizliMi == true)
            {
                n.YildizliMi = false;
                button1.Text = "★";
                Listele();
            }

        }
        private void txtNot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnEkle.PerformClick();
            }
        }
        private void lstNotlar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _blNotlar.Remove((Not)lstNotlar.SelectedItem);
                Listele();
            }
        }
        private void VerileriKaydet()
        {
            var options = new JsonSerializerOptions() { WriteIndented = true }; //json'ı okunaklı (indentation ile) oluşur
            string json = JsonSerializer.Serialize(_notlar, options);
            File.WriteAllText("veri.json", json);
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerileriKaydet();
        }
        private void VerileriOku()
        {
            try
            {
                string json = File.ReadAllText("veri.json");
                _notlar = JsonSerializer.Deserialize<List<Not>>(json);
            }
            catch (Exception)
            {
                _notlar = new List<Not>();
            }
        }
    }
}
