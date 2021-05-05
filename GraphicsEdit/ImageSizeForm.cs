using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsEdit
{
    public partial class ImageSizeForm : Form
    {
        public ImageSizeForm()
        {
            InitializeComponent();
        }

        int width;
        int height;

        public int WidthResult { get => width; set => width = value; }
        public int HeightResult { get => height; set => height = value; }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(widthBox.Text, out int width) && int.TryParse(heightBox.Text, out int height))
            {
                if (width > 0 && height > 0)
                {
                    WidthResult = width;
                    HeightResult = height;
                    return;
                }
            }
            MessageBox.Show("Некорректные значения размеров", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DialogResult = DialogResult.None;
        }

        private void WidthBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                acceptButton.PerformClick();
        }

        private void HeightBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                acceptButton.PerformClick();
        }
    }
}
