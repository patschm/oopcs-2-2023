using ShapesLibrary;
using System.Drawing;
using System.Windows.Forms;

namespace Gravies
{
    public class CirkelDlg : Form
    {
        public Figuur Generate()
        {
            Cirkel c = new Cirkel();
            c.Positie = new ShapesLibrary.Point { X = (int)hX.Value, Y = (int)hY.Value };
            c.Straal = (int)hRadius.Value;
            c.Kleur = selectedColor;
            c.Lijndikte = 3;
            return c;
        }
        public CirkelDlg()
        {
            InitializeComponent();
        }

        private System.ComponentModel.IContainer components = null;

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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            hX = new NumericUpDown();
            hY = new NumericUpDown();
            hRadius = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            colorDialog1 = new ColorDialog();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)hX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hRadius).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 102);
            label1.Name = "label1";
            label1.Size = new Size(64, 30);
            label1.TabIndex = 0;
            label1.Text = "Straal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 13);
            label2.Name = "label2";
            label2.Size = new Size(25, 30);
            label2.TabIndex = 1;
            label2.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(12, 55);
            label3.Name = "label3";
            label3.Size = new Size(25, 30);
            label3.TabIndex = 2;
            label3.Text = "Y";
            // 
            // hX
            // 
            hX.Location = new System.Drawing.Point(102, 19);
            hX.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            hX.Name = "hX";
            hX.Size = new Size(120, 23);
            hX.TabIndex = 3;
            // 
            // hY
            // 
            hY.Location = new System.Drawing.Point(102, 65);
            hY.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            hY.Name = "hY";
            hY.Size = new Size(120, 23);
            hY.TabIndex = 4;
            // 
            // hRadius
            // 
            hRadius.Location = new System.Drawing.Point(102, 112);
            hRadius.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            hRadius.Name = "hRadius";
            hRadius.Size = new Size(120, 23);
            hRadius.TabIndex = 5;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new System.Drawing.Point(352, 223);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.OK;
            button2.Location = new System.Drawing.Point(271, 223);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Create";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new System.Drawing.Point(271, 17);
            button3.Name = "button3";
            button3.Size = new Size(132, 118);
            button3.TabIndex = 9;
            button3.Text = "Color";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // CirkelDlg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 258);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(hRadius);
            Controls.Add(hY);
            Controls.Add(hX);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CirkelDlg";
            Text = "CirkelDlg";
            ((System.ComponentModel.ISupportInitialize)hX).EndInit();
            ((System.ComponentModel.ISupportInitialize)hY).EndInit();
            ((System.ComponentModel.ISupportInitialize)hRadius).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown hX;
        private System.Windows.Forms.NumericUpDown hY;
        private System.Windows.Forms.NumericUpDown hRadius;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private void button3_Click(object sender, System.EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog1.Color;
                button3.BackColor = selectedColor;
            }
        }

        private ColorDialog colorDialog1;
        private Button button3;
        private Color selectedColor;
    }
}
