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
    public partial class FormEditPendanaanPribadi : Form
    {
        public FormEditPendanaanPribadi()
        {
            InitializeComponent();
        }
        FormMenu formMenu;
        private void FormEditPendanaanPribadi_Load(object sender, EventArgs e)
        {
            formMenu = (FormMenu)this.Owner;
            comboBoxRekening.DropDownStyle = ComboBoxStyle.DropDownList;
            radioButtonSimpananRencana.Checked = true;
            groupBoxAmbilUang.Enabled = false;
            groupBoxSimpanUang.Enabled = false;
            radioButtonAmbilUang.Enabled = false;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            MichaelPendanaanPribadi rekeningPilihan = null;
            int simpanUang = int.Parse(textBoxSimpanUang.Text);
            if (radioButtonSimpanan.Checked)
            {
                rekeningPilihan = (MichaelSimpanan)comboBoxRekening.SelectedItem;
                if (radioButtonSimpanUang.Checked)
                {
                    rekeningPilihan.Menyimpan(simpanUang);
                }
                else if (radioButtonAmbilUang.Checked)
                {
                    int ambilUang = int.Parse(textBoxAmbilUang.Text);
                    (rekeningPilihan as MichaelSimpanan).AmbilUang(ambilUang);
                }
            }
            else if (radioButtonSimpananRencana.Checked)
            {
                rekeningPilihan = (MichaelSimpananRencana)comboBoxRekening.SelectedItem;
                if (radioButtonSimpanUang.Checked)
                {
                    int bulan = int.Parse(textBoxBulanKe.Text);
                    if (simpanUang<(rekeningPilihan as MichaelSimpananRencana).JumlahTabunganPerBulan || bulan > 12)
                    {
                        MessageBox.Show("Nominal harus lebih kecil dari jumlah tabungan per bulan!");
                        return;
                    }
                    else
                    {
                        rekeningPilihan.Menyimpan(simpanUang, bulan);
                    }
                }
            }
            listBoxInfo.Items.AddRange(rekeningPilihan.DisplayData().Split('\n'));
            listBoxInfo.Items.Add("");

            FileStream fs = new FileStream("PendanaanPribadi.idr", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, formMenu.listOfPendanaanPribadi);
            fs.Close();
        }

        private void radioButtonSimpanan_CheckedChanged(object sender, EventArgs e)
        {
            labelBulanKe.Enabled = false;
            textBoxBulanKe.Enabled = false;
            radioButtonAmbilUang.Enabled = true;
            comboBoxRekening.Items.Clear();
            foreach (MichaelPendanaanPribadi item in formMenu.listOfPendanaanPribadi)
            {
                if (item is MichaelSimpanan)
                {
                    comboBoxRekening.Items.Add(item);
                }
            }
            comboBoxRekening.DisplayMember = "NoRekening";
        }

        private void radioButtonSimpananRencana_CheckedChanged(object sender, EventArgs e)
        {
            labelBulanKe.Enabled = true;
            textBoxBulanKe.Enabled = true;
            radioButtonAmbilUang.Enabled = false;
            comboBoxRekening.Items.Clear();
            foreach (MichaelPendanaanPribadi item in formMenu.listOfPendanaanPribadi)
            {
                if (item is MichaelSimpananRencana)
                {
                    comboBoxRekening.Items.Add(item);
                }
            }
            comboBoxRekening.DisplayMember = "NoRekening";
        }

        private void radioButtonSimpanUang_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxSimpanUang.Enabled = true;
            groupBoxAmbilUang.Enabled = false;
        }

        private void radioButtonAmbilUang_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxSimpanUang.Enabled = false;
            groupBoxAmbilUang.Enabled = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
