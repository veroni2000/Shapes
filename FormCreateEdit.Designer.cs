namespace Shapes
{
    partial class FormCreateEdit
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
            this.comboBoxChooseShape = new System.Windows.Forms.ComboBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.Size1 = new System.Windows.Forms.TextBox();
            this.Size2 = new System.Windows.Forms.TextBox();
            this.Size3 = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxChooseShape
            // 
            this.comboBoxChooseShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseShape.FormattingEnabled = true;
            this.comboBoxChooseShape.Items.AddRange(new object[] {
            "Rectangle",
            "Square",
            "Circle",
            "Triangle"});
            this.comboBoxChooseShape.Location = new System.Drawing.Point(25, 31);
            this.comboBoxChooseShape.Name = "comboBoxChooseShape";
            this.comboBoxChooseShape.Size = new System.Drawing.Size(133, 21);
            this.comboBoxChooseShape.TabIndex = 0;
            this.comboBoxChooseShape.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseShape_SelectedIndexChanged);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple",
            "Pink"});
            this.comboBoxColor.Location = new System.Drawing.Point(25, 80);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(99, 21);
            this.comboBoxColor.TabIndex = 1;
            this.comboBoxColor.Visible = false;
            // 
            // Size1
            // 
            this.Size1.Location = new System.Drawing.Point(241, 32);
            this.Size1.Name = "Size1";
            this.Size1.Size = new System.Drawing.Size(80, 20);
            this.Size1.TabIndex = 2;
            this.Size1.Visible = false;
            this.Size1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Size1_KeyPress);
            // 
            // Size2
            // 
            this.Size2.Location = new System.Drawing.Point(241, 81);
            this.Size2.Name = "Size2";
            this.Size2.Size = new System.Drawing.Size(80, 20);
            this.Size2.TabIndex = 3;
            this.Size2.Visible = false;
            this.Size2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Size2_KeyPress);
            // 
            // Size3
            // 
            this.Size3.Location = new System.Drawing.Point(241, 130);
            this.Size3.Name = "Size3";
            this.Size3.Size = new System.Drawing.Size(80, 20);
            this.Size3.TabIndex = 4;
            this.Size3.Visible = false;
            this.Size3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Size3_KeyPress);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(241, 197);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(80, 51);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormCreateEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 289);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.Size3);
            this.Controls.Add(this.Size2);
            this.Controls.Add(this.Size1);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.comboBoxChooseShape);
            this.Name = "FormCreateEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreateEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChooseShape;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.TextBox Size1;
        private System.Windows.Forms.TextBox Size2;
        private System.Windows.Forms.TextBox Size3;
        private System.Windows.Forms.Button buttonSave;
    }
}