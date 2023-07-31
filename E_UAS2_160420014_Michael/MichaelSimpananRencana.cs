using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E_UAS2_160420014_Michael
{
    [Serializable]
    public class MichaelSimpananRencana : MichaelPendanaanPribadi
    {
        #region Field
        private int jangkaWaktu;
        private int sukuBunga;
        private int jumlahTabunganPerBulan;
        #endregion
        #region Constructor
        public MichaelSimpananRencana(int jangkaWaktu, int sukuBunga, int jumlahTabunganPerBulan, int noRekening, string nama, int noTelpon):base(noRekening,nama,noTelpon)
        {
            this.JangkaWaktu = jangkaWaktu;
            this.SukuBunga = sukuBunga;
            this.JumlahTabunganPerBulan = jumlahTabunganPerBulan;
        }
        #endregion
        #region Properties
        public int JangkaWaktu
        { 
            get => jangkaWaktu;
            set
            {
                if(value <0)
                {
                    throw new ArgumentException("Jangka waktu tidak boleh negatif!");
                }
                else
                {
                    jangkaWaktu = value;
                }
            }
        }
        public int SukuBunga 
        {
            get => sukuBunga;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Suku bunga tidak boleh negatif!");
                }
                else
                {
                    sukuBunga = value;
                }
            }
        }
        public int JumlahTabunganPerBulan
        {
            get => jumlahTabunganPerBulan;
            set
            {
                if(value <0)
                {
                    throw new ArgumentException("Jumlah Tabungan per Bulan tidak boleh negatif!");
                }
                else
                {
                    jumlahTabunganPerBulan = value;
                }
            }
        }
        #endregion
        #region Method
        int totalSimpanan = 0;
        public override string DisplayData()
        {
            return base.DisplayData() + "\nJangka Waktu : " + JangkaWaktu + "\nSuku Bunga : " + SukuBunga+"%" + "\nJumlah Tabungan Per Bulan : " + JumlahTabunganPerBulan
                                       +"\nTotal Simpanan : "+totalSimpanan+"\nBunga Bulanan : "+BungaBulanan(totalSimpanan) ;
        }
        public override void Menyimpan(int uang, int bulan)
        {
            totalSimpanan = TotalSimpanan(uang, bulan);
            BungaBulanan(totalSimpanan);
        }
        private int TotalSimpanan(int uang, int bulan)
        {
            return uang * bulan;
        }
        private int BungaBulanan(int totalSimpanan)
        {
            int bunga = (int)Math.Round(totalSimpanan * SukuBunga*0.01 / JangkaWaktu);
            return bunga;
        }
        #endregion
    }
}