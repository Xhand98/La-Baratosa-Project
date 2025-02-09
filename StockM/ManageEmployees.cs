using LaBaratosa.Operations;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GestionDeEmpleados
{
    public partial class ManageEmployees : Form
    {
        private readonly Database _database;
        private List<Empleado> employees = new List<Empleado>();

        public ManageEmployees()
        {
            InitializeComponent();
            _database = new Database("DSN=LaBaratosa");
        }

        private void ManageEmployees_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            InitializeDataGridViewStyle();
        }

        private void LoadEmployees()
        {
            employees = _database.fetchAllEmployees().ToList();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = employees;

            // Establecer los encabezados en español
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "Apellido";
            dataGridView1.Columns[3].HeaderText = "Cargo";
            dataGridView1.Columns[4].HeaderText = "Salario";
            dataGridView1.Columns[5].HeaderText = "Teléfono";
            dataGridView1.Columns[6].HeaderText = "Correo Electrónico";
        }

        private void InitializeDataGridViewStyle()
        {
            // Establecer el estilo de las celdas
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle.Font = new Font("Arial", 12);

            // Establecer el estilo de la fila seleccionada
            dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.ToLower();
            var filteredList = employees.Where(emp => emp.Nombre.ToLower().Contains(searchTerm)).ToList();
            dataGridView1.DataSource = filteredList;
        }

        private void editButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Empleado selectedEmployee = (Empleado)dataGridView1.SelectedRows[0].DataBoundItem;
                nameTextBox.Text = selectedEmployee.Nombre;
                lastNameTextBox.Text = selectedEmployee.Apellido;
                cargoChoice.Text = selectedEmployee.Cargo;
                salaryTextBox.Text = selectedEmployee.Salario.ToString();
                phoneTextBox.Text = selectedEmployee.Telefono;
                emailTextBox.Text = selectedEmployee.Correo;
            }
        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Empleado selectedEmployee = (Empleado)dataGridView1.SelectedRows[0].DataBoundItem;
                bool isDeleted = _database.DeleteEmployee(selectedEmployee.ID);
                if (isDeleted)
                {
                    employees.Remove(selectedEmployee);
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Failed to delete employee from the database.");
                }
            }
        }


        private void saveButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Editar el registro seleccionado
                Empleado selectedEmployee = (Empleado)dataGridView1.SelectedRows[0].DataBoundItem;
                selectedEmployee.Nombre = nameTextBox.Text;
                selectedEmployee.Apellido = lastNameTextBox.Text;
                selectedEmployee.Cargo = cargoChoice.Text;
                selectedEmployee.Salario = Convert.ToDecimal(salaryTextBox.Text);
                selectedEmployee.Telefono = phoneTextBox.Text;
                selectedEmployee.Correo = emailTextBox.Text;

                // Actualizar el empleado en la base de datos
                bool isUpdated = _database.UpdateEmployee(selectedEmployee);
                if (!isUpdated)
                {
                    MessageBox.Show("Failed to update employee details in the database.");
                }
            }
            else
            {
                // Crear un nuevo registro
                Empleado newEmployee = new Empleado
                {
                    Nombre = nameTextBox.Text,
                    Apellido = lastNameTextBox.Text,
                    Cargo = cargoChoice.Text,
                    Salario = Convert.ToDecimal(salaryTextBox.Text),
                    Telefono = phoneTextBox.Text,
                    Correo = emailTextBox.Text
                };

                // Agregar el nuevo empleado a la base de datos
                bool isAdded = _database.AddEmployee(newEmployee);
                if (isAdded)
                {
                    employees.Add(newEmployee);
                }
                else
                {
                    MessageBox.Show("Failed to add new employee to the database.");
                }
            }
            LoadDataGridView();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
