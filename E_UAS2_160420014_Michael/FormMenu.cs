using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace E_UAS2_160420014_Michael
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        public List<MichaelPendanaanPribadi> listOfPendanaanPribadi = new List<MichaelPendanaanPribadi>();

        private void simpananToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreatePendanaanPribadi form1 = new FormCreatePendanaanPribadi();
            form1.Owner = this;
            form1.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            if (File.Exists("PendanaanPribadi.idr"))
            {
                FileStream fs = new FileStream("PendanaanPribadi.idr", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                listOfPendanaanPribadi = bf.Deserialize(fs) as List<MichaelPendanaanPribadi>;
                fs.Close();
            }
            else
            {
                FileStream fs = new FileStream("PendanaanPribadi.idr", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, listOfPendanaanPribadi);
                fs.Close();
            }
        }

        private void simpanDanAmbilUangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditPendanaanPribadi form2 = new FormEditPendanaanPribadi();
            form2.Owner = this;
            form2.ShowDialog();
        }

        private void displayDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisplayData form3 = new FormDisplayData();
            form3.Owner = this;
            form3.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            FileStream fs = new FileStream("PendanaanPribadi.idr", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, listOfPendanaanPribadi);
            fs.Close();
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs = new FileStream("PendanaanPribadi.idr", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, listOfPendanaanPribadi);
            fs.Close();
        }
    }
}
