using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Tyuiu.KokoulinIV.Sprint6.V2;

namespace Tyuiu.KokoulinIV.Sprint7.V2
{
    public partial class Entrance : Form
    {
        DataBase dataDase = new DataBase();
        public Entrance()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        
        private void buttonImput_KIV_Click(object sender, EventArgs e)
        {
            var loginUser = textBox_Login_KIV.Text;
            var passUser = textBox_Password_KIV.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataDase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 frm = new Form1();
                this.Hide();
                frm.ShowDialog();
                this.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Аккааунта не существует", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




        }

        private void LinkToReg_LIV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
            
        }

        private void buttonPassword_KIV_Click(object sender, EventArgs e)
        {
            textBox_Password_KIV.UseSystemPasswordChar = false;
        }

        private void Entrance_Load(object sender, EventArgs e)
        {
            
            textBox_Password_KIV.UseSystemPasswordChar = true;
            textBox_Login_KIV.MaxLength = 50;
            textBox_Password_KIV.MaxLength = 50;
        }
    }
}
