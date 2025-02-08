namespace GestionDeEmpleados
{
    partial class ManageEmployees
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            searchButton = new Button();
            searchTextBox = new TextBox();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            emailTextBox = new TextBox();
            phoneTextBox = new TextBox();
            salaryTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            nameTextBox = new TextBox();
            label4 = new Label();
            label2 = new Label();
            editButton = new Button();
            deleteButton = new Button();
            saveButton = new Button();
            panel4 = new Panel();
            cargoChoice = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(searchTextBox);
            panel1.Controls.Add(panel3);
            panel1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(14, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(863, 520);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle5.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Menu;
            dataGridViewCellStyle7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.Location = new Point(4, 181);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(224, 224, 224);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(830, 314);
            dataGridView1.TabIndex = 3;
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchButton.Location = new Point(595, 110);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(123, 65);
            searchButton.TabIndex = 2;
            searchButton.Text = "Buscar";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click_1;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.Location = new Point(60, 124);
            searchTextBox.Multiline = true;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(452, 36);
            searchTextBox.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(34, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(684, 67);
            panel3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(168, 14);
            label1.Name = "label1";
            label1.Size = new Size(298, 35);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Empleados";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(cargoChoice);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(emailTextBox);
            panel2.Controls.Add(phoneTextBox);
            panel2.Controls.Add(salaryTextBox);
            panel2.Controls.Add(lastNameTextBox);
            panel2.Controls.Add(nameTextBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(914, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(470, 520);
            panel2.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(25, 446);
            label8.Name = "label8";
            label8.Size = new Size(202, 27);
            label8.TabIndex = 17;
            label8.Text = "Correo Electrónico:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(28, 374);
            label7.Name = "label7";
            label7.Size = new Size(102, 27);
            label7.TabIndex = 16;
            label7.Text = "Teléfono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(28, 311);
            label6.Name = "label6";
            label6.Size = new Size(84, 27);
            label6.TabIndex = 15;
            label6.Text = "Salario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 241);
            label5.Name = "label5";
            label5.Size = new Size(76, 27);
            label5.TabIndex = 14;
            label5.Text = "Cargo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 171);
            label3.Name = "label3";
            label3.Size = new Size(100, 27);
            label3.TabIndex = 13;
            label3.Text = "Apellido:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(239, 446);
            emailTextBox.Multiline = true;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(220, 29);
            emailTextBox.TabIndex = 12;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(239, 374);
            phoneTextBox.Multiline = true;
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(220, 29);
            phoneTextBox.TabIndex = 10;
            // 
            // salaryTextBox
            // 
            salaryTextBox.Location = new Point(239, 311);
            salaryTextBox.Multiline = true;
            salaryTextBox.Name = "salaryTextBox";
            salaryTextBox.Size = new Size(220, 29);
            salaryTextBox.TabIndex = 9;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(239, 171);
            lastNameTextBox.Multiline = true;
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(220, 29);
            lastNameTextBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(239, 99);
            nameTextBox.Multiline = true;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(220, 31);
            nameTextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 97);
            label4.Name = "label4";
            label4.Size = new Size(96, 27);
            label4.TabIndex = 2;
            label4.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(92, 29);
            label2.Name = "label2";
            label2.Size = new Size(298, 35);
            label2.TabIndex = 0;
            label2.Text = "Edición de Empleados";
            // 
            // editButton
            // 
            editButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editButton.Location = new Point(91, 542);
            editButton.Name = "editButton";
            editButton.Size = new Size(115, 58);
            editButton.TabIndex = 3;
            editButton.Text = "Editar";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click_1;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.Location = new Point(245, 542);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(115, 58);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Eliminar";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click_1;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.Location = new Point(1069, 542);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(179, 58);
            saveButton.TabIndex = 5;
            saveButton.Text = "Guardar";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click_1;
            // 
            // panel4
            // 
            panel4.Controls.Add(saveButton);
            panel4.Controls.Add(deleteButton);
            panel4.Controls.Add(editButton);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1423, 662);
            panel4.TabIndex = 6;
            // 
            // cargoChoice
            // 
            cargoChoice.FormattingEnabled = true;
            cargoChoice.Items.AddRange(new object[] { "Administrador", "Vendedor", "Gerente" });
            cargoChoice.Location = new Point(239, 238);
            cargoChoice.Name = "cargoChoice";
            cargoChoice.Size = new Size(220, 30);
            cargoChoice.TabIndex = 18;
            // 
            // ManageEmployees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1423, 662);
            Controls.Add(panel4);
            Name = "ManageEmployees";
            Text = "ManageEmployees";
            Load += ManageEmployees_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private ComboBox cargoChoice;
    }
}

