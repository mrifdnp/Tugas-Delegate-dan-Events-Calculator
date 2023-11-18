using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas
{
    public partial class Hasil : Form
    {

        private Input Input;
        // Objek kalkulator untuk melakukan perhitungan
        private Calculator kalkulator;

        public Hasil()
        {
            InitializeComponent();
            // Inisialisasi objek Form `Input`
            Input = new Input();
            // Menambahkan metode Operasi sebagai handler event Hitung dari Form `Input`
            Input.Hitung += Operasi;
            //inisialiasi objek calculator
            kalkulator = new Calculator();
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //menampilkan form input ketika btnHitung ditekan
            Input.ShowDialog();
        }

        public void Operasi(int a, int b, string operasi)
        {
            int hasil = 0;
            string simbol = "";
            switch (operasi)
            {
                case "Penjumlahan":
                    hasil = kalkulator.Tambah(a, b);
                    simbol = "+";
                    break;
                case "Pengurangan":
                    hasil = kalkulator.Kurang(a, b);
                    simbol = "-";
                    break;
                case "Perkalian":
                    hasil = kalkulator.Kali(a, b);
                    simbol = "*";
                    break;
                case "Pembagian":
                    hasil = kalkulator.Bagi(a, b);
                    simbol = "/";
                    break;
                default:
                    MessageBox.Show("Operasi tidak valid");
                    break;
            }

            // Tampilkan hasil perhitungan
            tbHasil.AppendText($"Hasil {operasi} {a} {simbol} {b} = {hasil}" + Environment.NewLine);
        }

      
    }
}
