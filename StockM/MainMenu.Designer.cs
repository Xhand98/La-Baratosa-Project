using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LaBaratosa
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnFerrateria = new Button();
            label1 = new Label();
            label2 = new Label();
            btnElectrodomesticos = new Button();
            label3 = new Label();
            btnTecnologia = new Button();
            label4 = new Label();
            PAlmacenamiento = new Panel();
            mEmployees = new Button();
            mStock = new Button();
            PAlmacenamiento.SuspendLayout();
            SuspendLayout();
            // 
            // btnFerrateria
            // 
            btnFerrateria.BackColor = Color.Black;
            btnFerrateria.BackgroundImage = Properties.Resources.Ferrateria;
            btnFerrateria.BackgroundImageLayout = ImageLayout.Stretch;
            btnFerrateria.Cursor = Cursors.Hand;
            btnFerrateria.FlatAppearance.BorderColor = Color.Black;
            btnFerrateria.FlatAppearance.BorderSize = 3;
            btnFerrateria.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFerrateria.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnFerrateria.FlatStyle = FlatStyle.Flat;
            btnFerrateria.ForeColor = SystemColors.ControlText;
            btnFerrateria.Location = new Point(32, 184);
            btnFerrateria.Margin = new Padding(3, 4, 3, 4);
            btnFerrateria.Name = "btnFerrateria";
            btnFerrateria.Size = new Size(327, 335);
            btnFerrateria.TabIndex = 0;
            btnFerrateria.UseVisualStyleBackColor = false;
            btnFerrateria.Click += btnFerrateria_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(106, 124);
            label1.Name = "label1";
            label1.Size = new Size(208, 55);
            label1.TabIndex = 0;
            label1.Text = "Ferreteria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new System.Drawing.Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(405, 121);
            label2.Name = "label2";
            label2.Size = new Size(373, 55);
            label2.TabIndex = 1;
            label2.Text = "Electrodómesticos";
            // 
            // btnElectrodomesticos
            // 
            btnElectrodomesticos.BackColor = Color.Black;
            btnElectrodomesticos.BackgroundImage = Properties.Resources.Electrodomesticos;
            btnElectrodomesticos.BackgroundImageLayout = ImageLayout.Stretch;
            btnElectrodomesticos.Cursor = Cursors.Hand;
            btnElectrodomesticos.FlatAppearance.BorderColor = Color.Black;
            btnElectrodomesticos.FlatAppearance.BorderSize = 3;
            btnElectrodomesticos.FlatStyle = FlatStyle.Flat;
            btnElectrodomesticos.ForeColor = SystemColors.ControlText;
            btnElectrodomesticos.Location = new Point(428, 180);
            btnElectrodomesticos.Margin = new Padding(3, 4, 3, 4);
            btnElectrodomesticos.Name = "btnElectrodomesticos";
            btnElectrodomesticos.Size = new Size(327, 335);
            btnElectrodomesticos.TabIndex = 2;
            btnElectrodomesticos.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new System.Drawing.Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(856, 121);
            label3.Name = "label3";
            label3.Size = new Size(232, 55);
            label3.TabIndex = 3;
            label3.Text = "Tecnologia";
            // 
            // btnTecnologia
            // 
            btnTecnologia.BackColor = Color.Black;
            btnTecnologia.BackgroundImage = Properties.Resources.Tecnología;
            btnTecnologia.BackgroundImageLayout = ImageLayout.Stretch;
            btnTecnologia.Cursor = Cursors.Hand;
            btnTecnologia.FlatAppearance.BorderColor = Color.Black;
            btnTecnologia.FlatAppearance.BorderSize = 3;
            btnTecnologia.FlatStyle = FlatStyle.Flat;
            btnTecnologia.ForeColor = SystemColors.ControlText;
            btnTecnologia.Location = new Point(825, 184);
            btnTecnologia.Margin = new Padding(3, 4, 3, 4);
            btnTecnologia.Name = "btnTecnologia";
            btnTecnologia.Size = new Size(327, 335);
            btnTecnologia.TabIndex = 4;
            btnTecnologia.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new System.Drawing.Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(338, 12);
            label4.Name = "label4";
            label4.Size = new Size(583, 46);
            label4.TabIndex = 5;
            label4.Text = "La Baratosa - herramienta checkout";
            // 
            // PAlmacenamiento
            // 
            PAlmacenamiento.BackColor = Color.Black;
            PAlmacenamiento.Controls.Add(label4);
            PAlmacenamiento.Location = new Point(-15, -3);
            PAlmacenamiento.Margin = new Padding(3, 4, 3, 4);
            PAlmacenamiento.Name = "PAlmacenamiento";
            PAlmacenamiento.Size = new Size(1241, 64);
            PAlmacenamiento.TabIndex = 6;
            PAlmacenamiento.Paint += PAlmacenamiento_Paint;
            PAlmacenamiento.MouseDown += PAlmacenamiento_MouseDown;
            // 
            // mEmployees
            // 
            mEmployees.Location = new Point(185, 568);
            mEmployees.Name = "mEmployees";
            mEmployees.Size = new Size(194, 46);
            mEmployees.TabIndex = 7;
            mEmployees.Text = "Administrar Empleados";
            mEmployees.UseVisualStyleBackColor = true;
            mEmployees.Visible = false;
            mEmployees.Click += mEmployees_Click;
            // 
            // mStock
            // 
            mStock.Location = new Point(740, 568);
            mStock.Name = "mStock";
            mStock.Size = new Size(194, 46);
            mStock.TabIndex = 8;
            mStock.Text = "Administrar Productos";
            mStock.UseVisualStyleBackColor = true;
            mStock.Visible = false;
            mStock.Click += mStock_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 641);
            Controls.Add(mStock);
            Controls.Add(mEmployees);
            Controls.Add(label3);
            Controls.Add(btnTecnologia);
            Controls.Add(label2);
            Controls.Add(btnElectrodomesticos);
            Controls.Add(label1);
            Controls.Add(btnFerrateria);
            Controls.Add(PAlmacenamiento);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            PAlmacenamiento.ResumeLayout(false);
            PAlmacenamiento.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFerrateria;
        private Label label1;
        private Label label2;
        private Button btnElectrodomesticos;
        private Label label3;
        private Button btnTecnologia;
        private Label label4;
        private Panel PAlmacenamiento;
        private Button mEmployees;
        private Button mStock;
    }
}
