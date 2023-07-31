using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_UAS2_160420014_Michael
{
    public partial class FormCreatePendanaanPribadi : Form
    {
        public FormCreatePendanaanPribadi()
        {
            InitializeComponent();
        }
        FormMenu formMenu;
        private void FormCreatePendanaanPribadi_Load(object sender, EventArgs e)
        {
            formMenu = (FormMenu)this.Owner;
            radioButtonSimpanan.Checked = true;
            groupBoxSimpanan.Enabled = true;
            groupBoxSimpananRencana.Enabled = false;
            foreach(MichaelPendanaanPribadi item in formMenu.listOfPendanaanPribadi)
            {
                listBoxInfo.Items.AddRange(item.DisplayData().Split('\n'));
                listBoxInfo.Items.Add("");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string nama = textBoxNama.Text;
                int noRekening = int.Parse(textBoxNoRekening.Text);
                int noTelpon = int.Parse(textBoxNoTelepon.Text);
                MichaelPendanaanPribadi pendanaanPribadi = null;
                if (radioButtonSimpanan.Checked)
                {
                    int saldo = int.Parse(textBoxSaldo.Text);
                    int biayaAdmin = int.Parse(textBoxBiayaAdmin.Text);
                    pendanaanPribadi = new MichaelSimpanan(saldo, biayaAdmin, noRekening, nama, noTelpon);
                }
                else if (radioButtonSimpananRencana.Checked)
                {
                    int jangkaWaktu = int.Parse(textBoxJangkaWaktu.Text);
                    int sukuBunga = int.Parse(textBoxSukuBunga.Text);
                    int tabunganPerBulan = int.Parse(textBoxTabunganPerBulan.Text);
                    pendanaanPribadi = new MichaelSimpananRencana(jangkaWaktu, sukuBunga, tabunganPerBulan, noRekening, nama, noTelpon);
                }
                formMenu.listOfPendanaanPribadi.Add(pendanaanPribadi);
                listBoxInfo.Items.AddRange(pendanaanPribadi.DisplayData().Split('\n'));
                listBoxInfo.Items.Add("");
                textBoxBiayaAdmin.Clear();
                textBoxJangkaWaktu.Clear();
                textBoxNama.Clear();
                textBoxNoRekening.Clear();
                textBoxNoTelepon.Clear();
                textBoxSaldo.Clear();
                textBoxSukuBunga.Clear();
                textBoxTabunganPerBulan.Clear();

                FileStream fs = new FileStream("PendanaanPribadi.idr",FileMode.Create,FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, formMenu.listOfPendanaanPribadi);
                fs.Close();
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonSimpanan_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxSimpanan.Enabled = true;
            groupBoxSimpananRencana.Enabled = false;
        }

        private void radioButtonSimpananRencana_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxSimpanan.Enabled = false;
            groupBoxSimpananRencana.Enabled = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
