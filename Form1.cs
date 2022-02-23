using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje5._32_AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int atGenisligi, bitisUzakligi, konumBirinciAt;
        Random rastgeleAtHizi = new Random();
        int[] konumlar = new int[4];
        private void Form1_Load(object sender, EventArgs e)
        {
            atGenisligi = pbAt1.Width;

            //At görüntülerinin genislikleri eşit hale getirilir.
            pbAt2.Width = atGenisligi;
            pbAt3.Width = atGenisligi;
            pbAt4.Width = atGenisligi;
            timer1.Interval = 100;

            bitisUzakligi = lBitisNoktasi.Left - atGenisligi;
        }

        private void btnBaslatDurdur_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
                timer1.Start();
            else
                timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            konumlar[0] = pbAt1.Left;
            konumlar[1] = pbAt2.Left;
            konumlar[2] = pbAt3.Left;
            konumlar[3] = pbAt4.Left;

            int birinciAtNo = atNoDondur();
            lDurum.Text = birinciAtNo + " numaralı at önde";
            konumBirinciAt = konumlar[birinciAtNo-1];

            if(konumBirinciAt > bitisUzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show(birinciAtNo + " numaralı at yarışı kazandı.");
            }

            //At konumlarının eski konumunu 1 ile 20 arasında rastgele kadar arttırılır.
            pbAt1.Left += rastgeleAtHizi.Next(1, 20);
            pbAt2.Left += rastgeleAtHizi.Next(1, 20);
            pbAt3.Left += rastgeleAtHizi.Next(1, 20);
            pbAt4.Left += rastgeleAtHizi.Next(1, 20);
        }

        private int atNoDondur()
        {
            Array.Sort(konumlar);
            if (pbAt1.Left == konumlar[3]) return 1;
            else if (pbAt2.Left == konumlar[3]) return 2;
            else if (pbAt3.Left == konumlar[3]) return 3;
            else if (pbAt4.Left == konumlar[3]) return 4;
            else return 0;
        }
    }
}
