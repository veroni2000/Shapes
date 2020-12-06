using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Shapes
{
    public partial class FormFiles : Form
    {
        public FormFiles()
        {
            InitializeComponent();
        }

        public List<Shape> Shapes { get; set; } = new List<Shape>();
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (var shape in Shapes)
            {
                Methods.DrawShape(shape, e.Graphics);
            }
        }
        private void FormFiles_Load(object sender, EventArgs e)
        {
            foreach (var shape in Shapes)
            {
                using (var graphics = CreateGraphics())
                    Methods.DrawShape(shape, graphics);
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            var saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var binformatter = new BinaryFormatter();
                using (var fileStream = new FileStream(saveFileDialog1.FileName,
                    FileMode.Create, FileAccess.Write))
                    binformatter.Serialize(fileStream, Shapes);
            }
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!File.Exists(openFileDialog1.FileName)) return;
                var binformatter = new BinaryFormatter();
                using (var fileStream = new FileStream(openFileDialog1.FileName,
                    FileMode.Open, FileAccess.Read))
                    Shapes = (List<Shape>)binformatter.Deserialize(fileStream);
                Invalidate();
            }
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
