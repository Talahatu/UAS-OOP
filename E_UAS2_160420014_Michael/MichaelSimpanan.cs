using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E_UAS2_160420014_Michael
{
    [Serializable]
    public class MichaelSimpanan : MichaelPendanaanPribadi
    {
        #region Field
        private int saldo;
        private int biayaAdmin;
        #endregion
        #region Constructors
        public MichaelSimpanan(int saldo, int biayaAdmin, int noRekening, string nama, int noTelpon):base(noRekening,nama,noTelpon)
        {
            this.Saldo = saldo;
            this.BiayaAdmin = biayaAdmin;
        }
        #endregion
        #region Properties
        public int Saldo 
        { 
            get => saldo; 
            set
            {
                if(value <0)
                {
                    throw new ArgumentException("Saldo tidak boleh negatif!");
                }
                else
                {
                    saldo = value;
                }
            }
        }
        public int BiayaAdmin 
        { 
            get => biayaAdmin; 
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Biaya Admin tidak boleh negatif!");
                }
                else
                {
                    biayaAdmin = value;
                }
            }
        }
        #endregion
        #region Method

        public override string DisplayData()
        {
            return base.DisplayData() + "\nSaldo : " + Saldo + "\nBiaya Admin : " + BiayaAdmin;
        }
        public override void Menyimpan(int uang)
        {
            Saldo += uang;
        }
        public void AmbilUang(int uang)
        {
            Saldo -= uang;
        }
        #endregion
    }
}