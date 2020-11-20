using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethod
{
    public partial class PngForm : Form
    {
        Bitmap contour;
        int x1, y1;

        public PngForm(string path)
        {
            InitializeComponent();
            if (path != "new")
            {
                contour = new Bitmap(path);
                Graphics g = Graphics.FromImage(contour);
                pictureBox1.Image = contour;
                int difX = contour.Width - pictureBox1.Width;
                int difY = contour.Height - pictureBox1.Height;

                pictureBox1.Width += difX;
                pictureBox1.Height += difY;

                this.Width += difX;
                this.Height += difY;
            }
            else
                contour = new Bitmap(308, 334);
            x1 = y1 = 0;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Файлы png|*.png";
            ImageFormat format = ImageFormat.Png;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName, format);
                MessageBox.Show("Файл сохранен!");
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ColorDialog ColorPicker = new ColorDialog();
            ColorPicker.Color = pictureBox2.BackColor;

            if (ColorPicker.ShowDialog() == DialogResult.OK)
                pictureBox2.BackColor = ColorPicker.Color;

        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Pen myPen = new Pen(pictureBox2.BackColor);
            Graphics g = Graphics.FromImage(contour);
            g.SmoothingMode = SmoothingMode.HighQuality;

            if (e.Button == MouseButtons.Left)
            {
                g.DrawLine(myPen, x1, y1, e.X, e.Y);
                pictureBox1.Image = contour;
            }
            x1 = e.X;
            y1 = e.Y;
        }

    }
}
