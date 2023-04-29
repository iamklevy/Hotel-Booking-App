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
    public partial class Dashboard : Form
    {
        string ordb = "Data source=XE;User Id=system;Password=system123;";
        int booking_id_counter = 9;
        OracleConnection conn;
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select GUESTID from GUEST";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) {
                comboBox1.Items.Add(dr[0]);
            }

            dr.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select FIRSTNAME,LASTNAME,GENDER,PHONENO,EMAIL,CITY,COUNTRY,PASSPORTNO from GUEST where GUESTID=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", comboBox1.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if(dr.Read())
            {
                textBox1.Text = dr[0].ToString();
                textBox3.Text = dr[1].ToString();
                textBox2.Text = dr[2].ToString();
                textBox5.Text = dr[3].ToString();
                textBox4.Text = dr[4].ToString();
                textBox8.Text = dr[5].ToString();
                textBox6.Text = dr[6].ToString();
                textBox7.Text = dr[7].ToString();
            }
            dr.Close();

        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into GUEST values (:book_id,:guest_id,:firstname,:lastname,:gender,:phoneno,:email,:city,:country,:passportno)";  
            cmd.Parameters.Add("booking_id", ++booking_id_counter);
            cmd.Parameters.Add("guest_id", comboBox1.Text);
            cmd.Parameters.Add("firstname", textBox1.Text);
            cmd.Parameters.Add("lastname", textBox3.Text);
            cmd.Parameters.Add("gender", textBox2.Text);
            cmd.Parameters.Add("phoneno", textBox5.Text);
            cmd.Parameters.Add("email", textBox4.Text);
            cmd.Parameters.Add("city", textBox8.Text);
            cmd.Parameters.Add("country", textBox6.Text);
            cmd.Parameters.Add("passportno", textBox7.Text);
            int r = cmd.ExecuteNonQuery();
            if(r != -1)
            {
                comboBox1.Items.Add(comboBox1.Text);
                MessageBox.Show("new guest has been added successfully");
            }
            comboBox1.Items.Add(booking_id_counter);
            booking_id_counter++;

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update GUEST set firstname=:firstname,lastname=:lastname,gender=:gender,phoneno=:phoneno,email=:email,city=:city,country=:country,passportno=:passportno where GUESTID =:id";
            cmd.Parameters.Add("firstname", textBox1.Text);
            cmd.Parameters.Add("lastname", textBox3.Text);
            cmd.Parameters.Add("gender", textBox2.Text);
            cmd.Parameters.Add("phoneno", textBox5.Text);
            cmd.Parameters.Add("email", textBox4.Text);
            cmd.Parameters.Add("city", textBox8.Text);
            cmd.Parameters.Add("country", textBox6.Text);
            cmd.Parameters.Add("passportno", textBox7.Text);
            cmd.Parameters.Add("id", comboBox1.Text);
            int r = cmd.ExecuteNonQuery();
            if(r != -1)
            {
                MessageBox.Show("Guest Data has been modified successfully");
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Delete from GUEST where GUESTID =: id";
            cmd.Parameters.Add("id", comboBox1.Text);
            int r  = cmd.ExecuteNonQuery();
            if(r != -1)
            {
                MessageBox.Show("Guest has been deleted successfully");
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = ""; 
                textBox8.Text = "";
            }
     

        }

        private void button1_click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GETGUESTBOOKINGID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("firstname", textBox1.Text);
            cmd.Parameters.Add("lastname", textBox3.Text);
            cmd.Parameters.Add("bookingID", ParameterDirection.Output);
            int r = cmd.ExecuteNonQuery();
            while (r != -1)
            {
                textBox9.Text = r.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GET_AVAILABLE_ROOMS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("roomtype", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("roomprice", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                string roomType = dr1.GetString(0);
                comboBox2.Items.Add(roomType);
            }
            dr1.Close();

            OracleDataReader dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {
                var roomPrice = dr2[0];
                comboBox3.Items.Add(roomPrice.ToString());
            }
            dr2.Close();

        }
    }
}
