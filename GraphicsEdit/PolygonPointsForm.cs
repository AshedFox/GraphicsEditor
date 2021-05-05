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
    public partial class PolygonPointsForm : Form
    {
        int pointsAmount;
        public int PointsAmount { get => pointsAmount; set => pointsAmount = value; }

        public PolygonPointsForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int pointsAmount))
            {
                if (pointsAmount > 2)
                {
                    PointsAmount = pointsAmount;
                    return;
                }
            }
            MessageBox.Show("Некорректное количество точек (требуется значение не меньше 3)", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DialogResult = DialogResult.None;
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
