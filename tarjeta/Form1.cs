using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // 

namespace tarjeta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Clase para la tarjeta
        public class Tarjeta
        {
            public string NumeroTarjeta { get; set; }
            public string ApellidoNombreTitular { get; set; }
            public string Email { get; set; }
            public DateTime VencimientoTarjeta { get; set; }
            public int CodigoSeguridad { get; set; }

            // Constructor de la tarjeta
            public Tarjeta(string numeroTarjeta, string apellidoNombreTitular, string email, DateTime vencimientoTarjeta, int codigoSeguridad)
            {
                this.NumeroTarjeta = numeroTarjeta;
                this.ApellidoNombreTitular = apellidoNombreTitular;
                this.Email = email;
                this.VencimientoTarjeta = vencimientoTarjeta;
                this.CodigoSeguridad = codigoSeguridad;
            }
        }

        // Evento del botón para insertar y mostrar datos
        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener los valores del formulario
            string numeroTarjeta = txtNumeroTarjeta.Text;
            string apellidoNombreTitular = txtApellidoNombreTitular.Text;
            string email = txtEmail.Text;
            DateTime vencimientoTarjeta = dtVencimientoTarjeta.Value;
            int codigoSeguridad = int.Parse(txtCodigoSeguridad.Text);

            // Crear objeto Tarjeta
            Tarjeta nuevaTarjeta = new Tarjeta(numeroTarjeta, apellidoNombreTitular, email, vencimientoTarjeta, codigoSeguridad);

            // Insertar los datos en la base de datos
            string connectionString = "Server=localhost;Database=parque_tematico;Uid=tu_usuario;Pwd=tu_contraseña;";
            string queryInsert = "INSERT INTO tarjeta (numeroTarjeta, apellidoNombre, email, vencimientoTarjeta, codigoSeguridad) " +
                                 "VALUES (@numeroTarjeta, @apellidoNombre, @email, @vencimientoTarjeta, @codigoSeguridad)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Comando para la inserción
                    using (MySqlCommand command = new MySqlCommand(queryInsert, connection))
                    {
                        command.Parameters.AddWithValue("@numeroTarjeta", nuevaTarjeta.NumeroTarjeta);
                        command.Parameters.AddWithValue("@apellidoNombre", nuevaTarjeta.ApellidoNombreTitular);
                        command.Parameters.AddWithValue("@email", nuevaTarjeta.Email);
                        command.Parameters.AddWithValue("@vencimientoTarjeta", nuevaTarjeta.VencimientoTarjeta);
                        command.Parameters.AddWithValue("@codigoSeguridad", nuevaTarjeta.CodigoSeguridad);

                        command.ExecuteNonQuery(); // Ejecutar el insert
                    }

                    // Mostrar los datos en el DataGridView
                    string querySelect = "SELECT * FROM tarjeta";
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(querySelect, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Llenar el DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Mostrar cualquier error
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}

