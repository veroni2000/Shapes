using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shapes
{
    public partial class FormCreateEdit : Form
    {
        public FormCreateEdit()
        {
            InitializeComponent();
        }
        private Shape _shape;
        public Shape Shape
        {
            get
            {
                return _shape;
            }
            set
            {
                _shape = value;
                if (_shape.Color != Color.Empty)
                {
                    comboBoxColor.Text = _shape.Color.Name;
                }
                if (_shape is Square)
                {
                    comboBoxChooseShape.SelectedItem = "Square";
                    Square square = (Square)_shape;
                    Size1.Visible = true;
                    Size1.Text = square.Width.ToString();
                }
                else if (_shape is Rectangle)
                {
                    comboBoxChooseShape.SelectedItem = "Rectangle";
                    Rectangle rectangle = (Rectangle)_shape;
                    Size1.Visible = true;
                    Size1.Text = rectangle.Width.ToString();
                    Size2.Visible = true;
                    Size2.Text = rectangle.Height.ToString();
                }
                else if (_shape is Circle)
                {
                    comboBoxChooseShape.SelectedItem = "Circle";
                    Circle circle = (Circle)_shape;
                    Size1.Visible = true;
                    Size1.Text = circle.Radius.ToString();
                }
                else if (_shape is Triangle)
                {
                    comboBoxChooseShape.SelectedItem = "Triangle";
                    Triangle triangle = (Triangle)_shape;
                    Size1.Visible = true;
                    Size1.Text = triangle.Sides[0].ToString();
                    Size2.Visible = true;
                    Size2.Text = triangle.Sides[1].ToString();
                    Size3.Visible = true;
                    Size3.Text = triangle.Sides[2].ToString();
                }
            }
        }
        private void comboBoxChooseShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBoxChooseShape.SelectedItem == "Rectangle")
            {
                Size1.Visible = true;
                Size2.Visible = true;
                Size3.Visible = false;
            }
            else if ((string)comboBoxChooseShape.SelectedItem == "Square")
            {
                Size1.Visible = true;
                Size2.Visible = false;
                Size3.Visible = false;
            }
            else if ((string)comboBoxChooseShape.SelectedItem == "Circle")
            {
                Size1.Visible = true;
                Size2.Visible = false;
                Size3.Visible = false;
            }
            else if ((string)comboBoxChooseShape.SelectedItem == "Triangle")
            {
                Size1.Visible = true;
                Size2.Visible = true;
                Size3.Visible = true;
            }
            comboBoxColor.Visible = true;
        }

        private void Size1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            Size1.MaxLength = 4;
        }

        private void Size2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            Size2.MaxLength = 4;
        }

        private void Size3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            Size3.MaxLength = 4;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool ready = false;
            if ((string)comboBoxChooseShape.SelectedItem == "Rectangle")
            {
                if (Size1.Text != null && Size2.Text != null)
                {
                    Shape = new Rectangle(int.Parse(Size1.Text), int.Parse(Size2.Text));
                    ready = true;
                }
            }
            else if ((string)comboBoxChooseShape.SelectedItem == "Square")
            {
                if (Size1.Text != null)
                {
                    Shape = new Square(int.Parse(Size1.Text));
                    ready = true;
                }
            }
            else if ((string)comboBoxChooseShape.SelectedItem == "Circle")
            {
                if (Size1.Text != null)
                {
                    Shape = new Circle(int.Parse(Size1.Text));
                    ready = true;
                }
            }
            else if ((string)comboBoxChooseShape.SelectedItem == "Triangle")
            {
                if (Size1.Text != null && Size2.Text != null && Size3.Text != null)
                {
                    if (int.Parse(Size1.Text) >= int.Parse(Size2.Text) + int.Parse(Size3.Text) || int.Parse(Size2.Text) >= int.Parse(Size1.Text) + int.Parse(Size3.Text) || int.Parse(Size3.Text) >= int.Parse(Size2.Text) + int.Parse(Size1.Text))
                    {
                        MessageBox.Show("Enter valid sides!");
                    }
                    else
                    {
                        Shape = new Triangle(int.Parse(Size1.Text), int.Parse(Size2.Text), int.Parse(Size3.Text));
                        ready = true;
                    }
                }
            }
            if (comboBoxColor.SelectedItem == null) ready = false;
            else Shape.Color = Color.FromName((string)comboBoxColor.SelectedItem);

            if (ready) DialogResult = DialogResult.OK;
        }
    }
}
