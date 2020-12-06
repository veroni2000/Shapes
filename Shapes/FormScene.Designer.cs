namespace Shapes
{
    partial class FormScene
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddShape = new System.Windows.Forms.Button();
            this.buttonFiles = new System.Windows.Forms.Button();
            this.buttonDeleteShape = new System.Windows.Forms.Button();
            this.buttonEditShape = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddShape
            // 
            this.buttonAddShape.Location = new System.Drawing.Point(12, 12);
            this.buttonAddShape.Name = "buttonAddShape";
            this.buttonAddShape.Size = new System.Drawing.Size(103, 66);
            this.buttonAddShape.TabIndex = 0;
            this.buttonAddShape.Text = "Add shape";
            this.buttonAddShape.UseVisualStyleBackColor = true;
            this.buttonAddShape.Click += new System.EventHandler(this.buttonAddShape_Click);
            // 
            // buttonFiles
            // 
            this.buttonFiles.Location = new System.Drawing.Point(121, 22);
            this.buttonFiles.Name = "buttonFiles";
            this.buttonFiles.Size = new System.Drawing.Size(75, 38);
            this.buttonFiles.TabIndex = 1;
            this.buttonFiles.Text = "Files";
            this.buttonFiles.UseVisualStyleBackColor = true;
            this.buttonFiles.Click += new System.EventHandler(this.buttonFiles_Click);
            // 
            // buttonDeleteShape
            // 
            this.buttonDeleteShape.Location = new System.Drawing.Point(493, 12);
            this.buttonDeleteShape.Name = "buttonDeleteShape";
            this.buttonDeleteShape.Size = new System.Drawing.Size(75, 30);
            this.buttonDeleteShape.TabIndex = 2;
            this.buttonDeleteShape.Text = "Delete";
            this.buttonDeleteShape.UseVisualStyleBackColor = true;
            this.buttonDeleteShape.Visible = false;
            this.buttonDeleteShape.Click += new System.EventHandler(this.buttonDeleteShape_Click);
            // 
            // buttonEditShape
            // 
            this.buttonEditShape.Location = new System.Drawing.Point(493, 48);
            this.buttonEditShape.Name = "buttonEditShape";
            this.buttonEditShape.Size = new System.Drawing.Size(75, 30);
            this.buttonEditShape.TabIndex = 3;
            this.buttonEditShape.Text = "Edit";
            this.buttonEditShape.UseVisualStyleBackColor = true;
            this.buttonEditShape.Visible = false;
            this.buttonEditShape.Click += new System.EventHandler(this.buttonEditShape_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(412, 22);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 38);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Details";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Visible = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(259, 22);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 38);
            this.buttonFilter.TabIndex = 5;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Visible = false;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // FormScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 405);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonEditShape);
            this.Controls.Add(this.buttonDeleteShape);
            this.Controls.Add(this.buttonFiles);
            this.Controls.Add(this.buttonAddShape);
            this.DoubleBuffered = true;
            this.Name = "FormScene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scene";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddShape;
        private System.Windows.Forms.Button buttonFiles;
        private System.Windows.Forms.Button buttonDeleteShape;
        private System.Windows.Forms.Button buttonEditShape;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonFilter;
    }
}

