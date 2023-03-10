using ShapesLibrary;
using System.Windows.Forms;

namespace Gravies
{
    public class TriangleDlg : Form
    {
        private Button button2;
        private Button button1;
        private NumericUpDown txtBasis;
        private NumericUpDown hY;
        private NumericUpDown hX;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown hHoogte;
        private NumericUpDown txtHoek;
        private Label label5;
        private Button button3;
        private ColorDialog colorDialog1;
        private Label label4;
        private System.Drawing.Color selectedColor;

        public Figuur Generate()
        {
            Driehoek c = new Driehoek();
            c.Positie = new Point { X = (int)hX.Value, Y = (int)hY.Value };
            c.Hoogte = (int)hHoogte.Value;
            c.Basis = (int)txtBasis.Value;
            c.Hoek = (int)txtHoek.Value;
            c.Kleur = selectedColor;
            c.Lijndikte = 3;
            return c;
        }
        public TriangleDlg()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            button2 = new Button();
            button1 = new Button();
            txtBasis = new NumericUpDown();
            hY = new NumericUpDown();
            hX = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            hHoogte = new NumericUpDown();
            label4 = new Label();
            txtHoek = new NumericUpDown();
            label5 = new Label();
            button3 = new Button();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)txtBasis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hHoogte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtHoek).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.OK;
            button2.Location = new System.Drawing.Point(282, 261);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "Create";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new System.Drawing.Point(363, 261);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtBasis
            // 
            txtBasis.Location = new System.Drawing.Point(99, 117);
            txtBasis.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            txtBasis.Name = "txtBasis";
            txtBasis.Size = new System.Drawing.Size(120, 23);
            txtBasis.TabIndex = 13;
            // 
            // hY
            // 
            hY.Location = new System.Drawing.Point(99, 58);
            hY.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            hY.Name = "hY";
            hY.Size = new System.Drawing.Size(120, 23);
            hY.TabIndex = 12;
            // 
            // hX
            // 
            hX.Location = new System.Drawing.Point(99, 12);
            hX.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            hX.Name = "hX";
            hX.Size = new System.Drawing.Size(120, 23);
            hX.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(9, 48);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(25, 30);
            label3.TabIndex = 10;
            label3.Text = "Y";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(9, 6);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(25, 30);
            label2.TabIndex = 9;
            label2.Text = "X";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(9, 107);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 30);
            label1.TabIndex = 8;
            label1.Text = "Basis";
            // 
            // hHoogte
            // 
            hHoogte.Location = new System.Drawing.Point(99, 156);
            hHoogte.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            hHoogte.Name = "hHoogte";
            hHoogte.Size = new System.Drawing.Size(120, 23);
            hHoogte.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(9, 146);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(82, 30);
            label4.TabIndex = 16;
            label4.Text = "Hoogte";
            // 
            // txtHoek
            // 
            txtHoek.Location = new System.Drawing.Point(99, 199);
            txtHoek.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            txtHoek.Name = "txtHoek";
            txtHoek.Size = new System.Drawing.Size(120, 23);
            txtHoek.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(9, 189);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(61, 30);
            label5.TabIndex = 18;
            label5.Text = "Hoek";
            // 
            // button3
            // 
            button3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button3.Location = new System.Drawing.Point(282, 12);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(132, 118);
            button3.TabIndex = 20;
            button3.Text = "Color";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // TriangleDlg
            // 
            ClientSize = new System.Drawing.Size(450, 296);
            Controls.Add(button3);
            Controls.Add(txtHoek);
            Controls.Add(label5);
            Controls.Add(hHoogte);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtBasis);
            Controls.Add(hY);
            Controls.Add(hX);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TriangleDlg";
            Text = "TriangleDlg";
            ((System.ComponentModel.ISupportInitialize)txtBasis).EndInit();
            ((System.ComponentModel.ISupportInitialize)hY).EndInit();
            ((System.ComponentModel.ISupportInitialize)hX).EndInit();
            ((System.ComponentModel.ISupportInitialize)hHoogte).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtHoek).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog1.Color;
                button3.BackColor = selectedColor;
            }
        }
    }
}
