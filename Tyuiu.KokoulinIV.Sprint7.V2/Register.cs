using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KokoulinIV.Sprint6.V2;

namespace Tyuiu.KokoulinIV.Sprint7.V2
{
    public partial class Register : Form
    {
        DataBase dataBase = new DataBase();
        public Register()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            textBox_PasswordReg_KIV.UseSystemPasswordChar = true;
            textBox_LoginReg_KIV.MaxLength = 50;
            textBox_PasswordReg_KIV.MaxLength = 50;
        }

        private void buttonRegister_KIV_Click(object sender, EventArgs e)
        {
            
            
            var loginUser = textBox_LoginReg_KIV.Text;
            var passUser = textBox_PasswordReg_KIV.Text;
                

            string querystring = $"Insert into register (login_user, password_user) values ('{loginUser}','{passUser}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
            try
            {
                dataBase.openConnectiion();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт успешно создан", "Успех!");
                    Entrance entrance = new Entrance();
                    this.Hide();
                    entrance.ShowDialog();


                }
                else
                {
                    MessageBox.Show("Аккаунт не создан!");
                }
                dataBase.closeConnectiion();
            }
            finally
            {
                dataBase.closeConnectiion();
            }

        }

        private Boolean checkuser()
        {
            var loginUser = textBox_LoginReg_KIV.Text;
            var passUser = textBox_PasswordReg_KIV.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Аккаунт с таким логином уже есть!", "Аккаунт уже есть", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonPasswordReg_KIV_Click(object sender, EventArgs e)
        {
            textBox_PasswordReg_KIV.UseSystemPasswordChar = false;
        }
    }
}
