using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas
{
    public partial class Input : Form
    {
        // Deklarasi delegate dan event untuk komunikasi antar form input dan hasil
        public delegate void PerhitunganDelegate(int a, int b, string operasi);
        public event PerhitunganDelegate Hitung;

        public Input()
        {
            InitializeComponent();
        }
        // Event handler untuk tombol proses.
        public void btnProses_Click(object sender, EventArgs e)
        {
            // Deklarasikan variabel untuk menyimpan nilai yang diinput.
            int nilai1, nilai2;

            //memastikan input hanya angka
            if (int.TryParse(nilaia.Text, out nilai1) && int.TryParse(nilaib.Text, out nilai2))
            {
                string pilihanOp = cmbOperasi.SelectedItem.ToString();
                Hitung?.Invoke(nilai1, nilai2, pilihanOp);
            }
            else
            {
                MessageBox.Show("Hanya masukkan angka.");
            }
        }
    }
}
