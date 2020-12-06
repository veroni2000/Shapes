using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Shapes
{
    public partial class FormFilter : Form
    {
        public FormFilter()
        {
            InitializeComponent();
        }
        public List<Type> checkedShapes = new List<Type>();
        public List<Color> checkedColors = new List<Color>();
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (checkRectangle.Checked) checkedShapes.Add(typeof(Rectangle));
            if (checkSquare.Checked) checkedShapes.Add(typeof(Square));
            if (checkCircle.Checked) checkedShapes.Add(typeof(Circle));
            if (checkTriangle.Checked) checkedShapes.Add(typeof(Triangle));

            if (Red.Checked) checkedColors.Add(Color.Red);
            if (Orange.Checked) checkedColors.Add(Color.Orange);
            if (Yellow.Checked) checkedColors.Add(Color.Yellow);
            if (Green.Checked) checkedColors.Add(Color.Green);
            if (Blue.Checked) checkedColors.Add(Color.Blue);
            if (Purple.Checked) checkedColors.Add(Color.Purple);
            if (Pink.Checked) checkedColors.Add(Color.Pink);

            DialogResult = DialogResult.OK;
        }
    }
}
