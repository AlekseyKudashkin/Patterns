using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = "new";
            Creator creator = new TxtCreator(path);
            Product doc = creator.FactoryMethod();
        }

        private void pngDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = "new";
            Creator creator = new PngCreator(path);
            Product doc = creator.FactoryMethod();
        }

        private void txtDocumentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файлы txt|*.txt";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                Creator creator = new TxtCreator(OPF.FileName);
                Product doc = creator.FactoryMethod();
            }
        }

        private void pngDocumentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файлы png|*.png";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                Creator creator = new PngCreator(OPF.FileName);
                Product doc = creator.FactoryMethod();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
