using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E_UAS2_160420014_Michael
{
    [Serializable]
    public abstract class MichaelPendanaanPribadi
    {
        #region Field
        private int noRekening;
        private string nama;
        private int noTelpon;
        #endregion
        #region Constructor
        public MichaelPendanaanPribadi(int noRekening, string nama, int noTelpon)
        {
            this.NoRekening = noRekening;
            this.Nama = nama;
            this.NoTelpon = noTelpon;
        }
        #endregion
        #region Properties
        public int NoRekening 
        { 
            get => noRekening; 
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Nomor Rekening tidak boleh negatif!");
                }
                else
                {
                    noRekening = value;
                }
            }
        }
        public string Nama 
        {
            get => nama; 
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("Nama tidak boleh kosong!");
                }
                else
                {
                    nama = value;
                }
            }
        }
        public int NoTelpon
        { 
            get => noTelpon;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Nomor Telepon tidak boleh negatif!");
                }
                else
                {
                    noTelpon = value;
                }
            }
        }
        #endregion
        #region Method

        public virtual string DisplayData()
        {
            string data = "Nama : " + Nama +
                          "\nNomor Rekening : " + NoRekening +
                          "\nNomor Telepon : " + NoTelpon;
            return data;
        }

        public virtual void Menyimpan(int uang)
        {
            
        }
        public virtual void Menyimpan(int uang, int bulan)
        {

        }

        #endregion
    }
}