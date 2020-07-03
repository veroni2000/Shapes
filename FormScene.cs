using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Shapes
{
    public partial class FormScene : Form
    {
        public List<Shape> _shapes = new List<Shape>();
        private Shape _selectedShape = null;
        private Shape _shapeToBeDrawn = null;
        private bool _tracingMouse = false;
        private Point _mouseDownLocation;
        private Color _rememberColor;
        public FormScene()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (var shape in _shapes)
            {
                Methods.DrawShape(shape, e.Graphics);
            }
        }
        private void FormScene_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (_shapeToBeDrawn != null)
                {
                    _shapeToBeDrawn.Location = e.Location;
                    _selectedShape = null;

                    using (var graphics = CreateGraphics())
                        Methods.DrawShape(_shapeToBeDrawn, graphics);

                    _shapeToBeDrawn = null;

                    buttonEditShape.Visible = false;
                    buttonDeleteShape.Visible = false;
                    buttonCalculate.Visible = false;

                    buttonFilter.Visible = true;
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                _tracingMouse = true;
                _mouseDownLocation = e.Location;

                buttonEditShape.Visible = false;
                buttonDeleteShape.Visible = false;
                buttonCalculate.Visible = false;

                if (_selectedShape != null)
                    _selectedShape.Color = _rememberColor;

                _selectedShape = _shapes.OrderByDescending(o => o.Order).Where(shape => shape.Contains(e.Location)).LastOrDefault();

                if (_selectedShape != null)
                {
                    _rememberColor = _selectedShape.Color;
                    _selectedShape.Color = Color.Gray;

                    buttonEditShape.Visible = true;
                    buttonDeleteShape.Visible = true;
                    buttonCalculate.Visible = true;
                }

                Invalidate();
                Application.DoEvents();
            }
        }
        private void FormScene_MouseMove(object sender, MouseEventArgs e)
        {
            if (_tracingMouse && _selectedShape != null)
            {
                _selectedShape.Move(_mouseDownLocation, e.Location);
                _mouseDownLocation = e.Location;
                Refresh();
            }
        }
        private void FormScene_MouseUp(object sender, MouseEventArgs e)
        {
            _tracingMouse = false;
        }
        private void buttonAddShape_Click(object sender, EventArgs e)
        {
            if (_selectedShape != null)
                _selectedShape.Color = _rememberColor;
            _selectedShape = null;
            var create = new FormCreateEdit();
            var shape = new Shape();
            create.Shape = shape;
            if (create.ShowDialog() == DialogResult.OK)
            {
                shape = create.Shape;

                _shapes.Add(shape);
                _shapeToBeDrawn = shape;
            }
        }
        private void buttonEditShape_Click(object sender, EventArgs e)
        {
            if (_selectedShape != null)
            {
                var edit = new FormCreateEdit();
                var shape = _selectedShape;
                shape.Color = _rememberColor;
                edit.Shape = shape;
                if (edit.ShowDialog() == DialogResult.OK)
                {
                    _shapes.Remove(_selectedShape);

                    shape = edit.Shape;
                    shape.Location = _selectedShape.Location;
                    _shapes.Add(shape);
                    _selectedShape = null;

                }
                buttonEditShape.Visible = false;
                buttonDeleteShape.Visible = false;
                buttonCalculate.Visible = false;
            }
            Invalidate();
        }
        private void buttonDeleteShape_Click(object sender, EventArgs e)
        {
            if (_selectedShape != null)
            {
                _shapes.Remove(_selectedShape);
                _selectedShape = null;
                buttonEditShape.Visible = false;
                buttonDeleteShape.Visible = false;
                buttonCalculate.Visible = false;

                if (_shapes.Count() == 0) buttonFilter.Visible = false;
                Invalidate();
            }
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (_selectedShape != null)
                MessageBox.Show(_selectedShape.ToString());
        }
        private void buttonFiles_Click(object sender, EventArgs e)
        {
            if (_selectedShape != null)
            {
                _selectedShape.Color = _rememberColor;
                _selectedShape = null;
            }

            var formFiles = new FormFiles();
            formFiles.Shapes = _shapes;
            if (formFiles.ShowDialog() == DialogResult.OK)
            {
                _shapes = formFiles.Shapes;
            }
            if (_shapes.Count() > 0) buttonFilter.Visible = true;

            Invalidate();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            List<Type> checkedShapes = null;
            List<Color> checkedColors = null;

            var filter = new FormFilter();
            if (filter.ShowDialog() == DialogResult.OK)
            {
                checkedShapes = filter.checkedShapes;
                checkedColors = filter.checkedColors;
            }

            var filteredShapes = new List<Shape>();
            var filteredShapesColors = new List<Shape>();
            if (checkedShapes != null && checkedColors != null)
            {
                foreach (var type in checkedShapes)
                {
                    var shapesType = _shapes
                        .Where(shape => shape.GetType() == type)
                        .ToList();
                    foreach (var shape in shapesType)
                        filteredShapes.Add(shape);
                }
                foreach (var color in checkedColors)
                {
                    var shapesColor = filteredShapes
                        .Where(shape => shape.Color == color)
                        .ToList();
                    foreach (var shape in shapesColor)
                        filteredShapesColors.Add(shape);
                }
            }

            _shapes = filteredShapesColors;
            if (_shapes.Count() == 0) buttonFilter.Visible = false;
            Invalidate();
        }
    }
}
