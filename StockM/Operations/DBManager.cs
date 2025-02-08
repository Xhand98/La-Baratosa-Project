using System;
using Dapper;
using System.Data.Odbc;
using System.Collections.Generic;

namespace LaBaratosa.Operations
{
    internal class Database
    {
        private readonly string _connectionString;

        public Database(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("Connection string cannot be empty.");
            }
            _connectionString = connectionString;
        }

        public IEnumerable<Empleado> fetchAllEmployees()
        {
            using (var connection = new OdbcConnection(_connectionString))
            {
                string query = @"SELECT * FROM Empleados";
                return connection.Query<Empleado>(query);
            }
        }

        public IEnumerable<Producto> fetchAllProducts()
        {
            using (var connection = new OdbcConnection(_connectionString))
            {
                string query = @"SELECT * FROM Products";
                return connection.Query<Producto>(query);
            }
        }
        public Usuario VerifyCredentials(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Username and password cannot be empty.");
            }

            try
            {
                using (var connection = new OdbcConnection(_connectionString))
                {
                    string query = $@"SELECT * FROM Usuario WHERE NombreUsuario = '{username}' AND Contraseña = '{password}'";
                    return connection.QueryFirstOrDefault<Usuario>(query);
                }
            }
            catch (OdbcException ex)
            {
                // Log the exception or show a message to the user
                MessageBox.Show($"An error occurred while connecting to the database: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                // Log the exception or show a message to the user
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
                return null;
            }
        }
        public bool IsUserManagerOrAdmin(string username)
        {
            try
            {
                using (var connection = new OdbcConnection(_connectionString))
                {
                    string query = $@"
                SELECT e.Cargo
                FROM Usuario u
                JOIN EmpleadoUsuario eu ON u.ID = eu.ID_Usuario
                JOIN Empleados e ON eu.ID_Empleado = e.ID
                WHERE u.NombreUsuario = '{username}' AND (e.Cargo = 'Administrador' OR e.Cargo = 'Gerente')";

                    var cargo = connection.QueryFirstOrDefault<string>(query);
                    return cargo != null;
                }
            }
            catch (OdbcException ex)
            {
                // Log the exception or show a message to the user
                MessageBox.Show($"An error occurred while connecting to the database: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                // Log the exception or show a message to the user
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
                return false;
            }
        }

        public bool UpdateEmployee(Empleado employee)
        {
            using (var connection = new OdbcConnection(_connectionString))
            {
                string query = $@"UPDATE Empleados 
                         SET Nombre = '{employee.Nombre}', Apellido = '{employee.Apellido}', Cargo = '{employee.Cargo}', 
                             Salario = '{employee.Salario}', Telefono = '{employee.Telefono}', Correo = '{employee.Correo}'
                         WHERE ID = {employee.ID}";
                var result = connection.Execute(query);
                return result > 0;
            }
        }

        public bool AddEmployee(Empleado employee)
        {
            using (var connection = new OdbcConnection(_connectionString))
            {
                string query = $@"INSERT INTO Empleados (Nombre, Apellido, Cargo, Salario, Telefono, Correo) 
                         VALUES ('{employee.Nombre}', '{employee.Apellido}', '{employee.Cargo}', '{employee.Salario}', '{employee.Telefono}', '{employee.Correo}')";
                var result = connection.Execute(query);
                return result > 0;
            }

        }
        public bool DeleteEmployee(int employeeId)
        {
            using (var connection = new OdbcConnection(_connectionString))
            {
                string query = $@"DELETE FROM Empleados WHERE ID = '{employeeId}'";
                var result = connection.Execute(query);
                return result > 0;
            }
        }




    }



    public class Empleado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
    }

    public class Producto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public string Categoria { get; set; }
    }

    public class Usuario
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
    }
}