using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace oraclee_sql_app
{
    public partial class Dashboard2 : Form
    {
        string ordb = "Data source=XE;User Id=system;Password=system123;";
        private DataSet ds = new DataSet();
        private OracleDataAdapter adapter = new OracleDataAdapter();

        OracleConnection conn;
        public Dashboard2()
        {
            InitializeComponent();
        }

        private void Dashboard2_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select ROLEID from ROLES";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }

            dr.Close();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedRoleId = comboBox1.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(selectedRoleId))
                {
                    return;
                }

                using (var connection = new OracleConnection(ordb))
                {
                    connection.Open();
                    var command = new OracleCommand("select * from EMPLOYEES where ROLEID = :roleId", connection);
                    command.Parameters.Add(new OracleParameter("roleId", OracleDbType.Varchar2, selectedRoleId, ParameterDirection.Input));
                    adapter = new OracleDataAdapter(command);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving data from the database. Error message: {ex.Message}");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new OracleConnection(ordb))
                {
                    connection.Open();
                    var adapter = new OracleDataAdapter("select * from EMPLOYEES where ROLEID =:id", connection);
                    var builder = new OracleCommandBuilder(adapter);
                    adapter.Update(ds.Tables[0]);
                    MessageBox.Show("Data has been updated!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating data to the database. Error message: {ex.Message}");
            }


        }
    }
}
