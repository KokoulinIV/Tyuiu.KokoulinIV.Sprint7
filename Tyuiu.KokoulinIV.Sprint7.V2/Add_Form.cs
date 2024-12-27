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

namespace Tyuiu.KokoulinIV.Sprint7.V2
{
    public partial class Add_Form : Form
    {
        DataBase dataBase = new DataBase();

        public Add_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonSaveNewRow_KIV_Click(object sender, EventArgs e)
        {
            dataBase.openConnectiion();
            var type = textBoxTypeNew_KIV.Text;
            var name = textBoxTitelNew_KIV.Text;
            int del;
            int cost;
            if (int.TryParse(textBoxDelNew_KIV.Text , out del) && int.TryParse(textBoxCostNew_KIV.Text, out cost))
            {
                var addQuery = $"insert into test_db (type_of, name_of, delivery, price_of) values ('{type}','{name}','{del}','{cost}')";
                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Цена и стоимость доставки должны иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataBase.closeConnectiion();
        }
    }
}
