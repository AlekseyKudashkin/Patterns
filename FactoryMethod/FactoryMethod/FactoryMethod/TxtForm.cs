using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethod
{
    public partial class TxtForm : Form
    {
        public TxtForm(string path)
        {
            InitializeComponent();
            if (path != "new")
            {
                var text = new System.IO.StreamReader(path, Encoding.GetEncoding(1251));
                richTextBox1.Text = text.ReadToEnd();
                text.Close();
            }
        }

        private void TxtForm_Load(object sender, EventArgs e)
        {

        }   

        private void dfgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Файлы txt|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var save = new System.IO.StreamWriter(saveFileDialog1.FileName, false, System.Text.Encoding.GetEncoding(1251));
                save.Write(richTextBox1.Text);
                save.Close();
                MessageBox.Show("Файл сохранен!");
                this.Close();
            }
        }
    }
}
