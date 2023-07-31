using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_UAS2_160420014_Michael
{
    public partial class FormDisplayData : Form
    {
        public FormDisplayData()
        {
            InitializeComponent();
        }
        FormMenu formMenu;
        private void FormDisplayData_Load(object sender, EventArgs e)
        {
            formMenu = (FormMenu)this.Owner;
        }


        private void radioButtonSimpanan_CheckedChanged(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            foreach (MichaelPendanaanPribadi item in formMenu.listOfPendanaanPribadi)
            {
                if (item is MichaelSimpanan)
                {
                    listBoxInfo.Items.AddRange(item.DisplayData().Split('\n'));
                    listBoxInfo.Items.Add("");
                }
            }
        }

        private void radioButtonSimpananRencana_CheckedChanged(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            foreach (MichaelPendanaanPribadi item in formMenu.listOfPendanaanPribadi)
            {
                if (item is MichaelSimpananRencana)
                {
                    listBoxInfo.Items.AddRange(item.DisplayData().Split('\n'));
                    listBoxInfo.Items.Add("");
                }
            }
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            listBoxInfo.Items.Add("Jenis Simpanan : ");
            foreach (MichaelPendanaanPribadi item in formMenu.listOfPendanaanPribadi)
            {
                if (item is MichaelSimpanan)
                {
                    listBoxInfo.Items.AddRange(item.DisplayData().Split('\n'));
                    listBoxInfo.Items.Add("");
                }
            }
            listBoxInfo.Items.Add("Jenis Simpanan Rencana : ");
            foreach (MichaelPendanaanPribadi item in formMenu.listOfPendanaanPribadi)
            {
                if (item is MichaelSimpananRencana)
                {
                    listBoxInfo.Items.AddRange(item.DisplayData().Split('\n'));
                    listBoxInfo.Items.Add("");
                }
            }
        }
    }
}
