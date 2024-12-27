using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Tyuiu.KokoulinIV.Sprint7.V2;
using Tyuiu.KokoulinIV.Sprint6.V2.Lib;
using Tyuiu.KokoulinIV.Sprint6.V2;
using Aspose.Pdf.Operators;
using System.ComponentModel;


namespace Tyuiu.KokoulinIV.Sprint6.V2
{

    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }



    public partial class Form1 : Form
    {

        DataBase dataBase = new DataBase();
        int selectedRow;

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Отображение, отображение файла(*.csv)|*.csv|Вид файла(*.*)|*.*";
            saveFileDialog_KIV.Filter = "Отображение, отображение файла(*.csv)|*.csv|Вид файла(*.*)|*.*";

        }
        private void CreateColumns()
        {
            dataGridView_KIV.Columns.Add("id", "id");
            dataGridView_KIV.Columns.Add("type_of", "Тип товара");
            dataGridView_KIV.Columns.Add("name_of", "Название");
            dataGridView_KIV.Columns.Add("delivery", "Доставка");
            dataGridView_KIV.Columns.Add("price_of", "Цена");
            dataGridView_KIV.Columns.Add("IsNew", String.Empty);
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetInt32(4));
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from test_db";
            using (SqlCommand command = new SqlCommand(queryString, dataBase.getConnection()))
            {
                try
                {
                    dataBase.openConnectiion();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ReadSingleRow(dgw, reader);
                    }
                    reader.Close();

                    dataBase.closeConnectiion();
                }
                finally
                {
                    dataBase.closeConnectiion();
                }
            }
        }


        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            ContextMenu.Show(buttonMenu_KIV, new Point(50, 50));
        }


        public static string[,] LoadFromFileData(string filepath)
        {
            string filedata = File.ReadAllText(filepath);
            filedata = filedata.Replace('\n', '\r');
            string[] lines = filedata.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            string[,] array = new string[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = line_r[j];
                }
            }
            return array;
        }




        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                openFileDialog1.ShowDialog();
                openFilePath = openFileDialog1.FileName;

                string[,] array = new string[rows, columns];
                array = LoadFromFileData(openFilePath);
                dataGridView_KIV.ColumnCount = columns;
                dataGridView_KIV.RowCount = rows;


                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridView_KIV.Rows[i].Cells[j].Value = array[i, j];

                    }

                }

            }
            catch
            {
                MessageBox.Show("ОЙ, что то пошло не так!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }










        }

        private void dataGridView_KIV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSave_KIV_Click(object sender, EventArgs e)
        {


        }

        private void buttonSaveHow_KIV_Click(object sender, EventArgs e)
        {
            saveFileDialog_KIV.FileName = "OutPutFile.csv";
            saveFileDialog_KIV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_KIV.ShowDialog();

            string path = saveFileDialog_KIV.FileName;



            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridView_KIV.RowCount;
            int columns = dataGridView_KIV.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridView_KIV.Rows[i].Cells[j].Value + ";";

                    }
                    else
                    {
                        str += dataGridView_KIV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonAbout_KIV_Click(object sender, EventArgs e)
        {
            About_me formAbout = new About_me();
            formAbout.ShowDialog();
        }

        private void buttonSearch_KIV_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView_KIV);
        }

        private void dataGridView_KIV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_KIV.Rows[selectedRow];
                textBoxID_KIV.Text = row.Cells[0].Value.ToString();
                textBoxType_KIV.Text = row.Cells[1].Value.ToString();
                textBoxTitel_KIV.Text = row.Cells[2].Value.ToString();
                textBoxDel_KIV.Text = row.Cells[3].Value.ToString();
                textBoxCost_KIV.Text = row.Cells[4].Value.ToString();

                textBox_cost_KIV.Text = textBoxCost_KIV.Text;
                textBox_del_KIV.Text = textBoxDel_KIV.Text;

            }
        }

        private void buttonUpdate_KIV_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView_KIV);
        }

        private void buttonAdd_KIV_Click(object sender, EventArgs e)
        {
            Add_Form addfrm = new Add_Form();
            addfrm.Show();
        }


        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from test_db where concat (id , type_of, name_of, delivery, price_of) like '%" + textBoxSearch_KIV.Text + "%' ";

            using (SqlCommand com = new SqlCommand(searchString, dataBase.getConnection()))
            {
                try
                {
                    dataBase.openConnectiion();
                    SqlDataReader read = com.ExecuteReader();

                    while (read.Read())
                    {
                        ReadSingleRow(dgw, read);
                    }
                    read.Close();
                }
                finally
                {
                    dataBase.closeConnectiion();
                }
            }
        }



        private void textBoxSearch_KIV_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView_KIV);
        }


        private void deleteRow()
        {
            int index = dataGridView_KIV.CurrentCell.RowIndex;
            dataGridView_KIV.Rows[index].Visible = false;
            if (dataGridView_KIV.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView_KIV.Rows[index].Cells[5].Value = RowState.Deleted;

            }
            dataGridView_KIV.Rows[index].Cells[5].Value = RowState.Deleted;
            return;

        }
        private void Updates()
        {
            try
            {
                dataBase.openConnectiion();

                for (int index = 0; index < dataGridView_KIV.Rows.Count; index++)
                {
                    // Проверка на null для строки
                    if (dataGridView_KIV.Rows[index] == null)
                    {
                        continue; // Пропустить, если строка пустая
                    }

                    // Проверка на null для состояния строки
                    var cellValue = dataGridView_KIV.Rows[index].Cells[5]?.Value;
                    if (cellValue == null)
                    {
                        continue; // Пропустить, если значение состояния отсутствует
                    }

                    var rowState = (RowState)cellValue;

                    if (rowState == RowState.Existed)
                    {
                        continue;
                    }
                    else if (rowState == RowState.Deleted)
                    {
                        // Проверка на null для ID
                        var idCellValue = dataGridView_KIV.Rows[index].Cells[0]?.Value;
                        if (idCellValue == null)
                        {
                            MessageBox.Show("Ошибка: отсутствует ID для строки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            continue; // Пропустить, если ID отсутствует
                        }

                        var id = Convert.ToInt32(idCellValue);

                        var deleteQuery = "DELETE FROM test_db WHERE id = @id";
                        using (var command = new SqlCommand(deleteQuery, dataBase.getConnection()))
                        {
                            command.Parameters.AddWithValue("@id", id); // Использование параметризированного запроса
                            command.ExecuteNonQuery();
                        }
                    }
                    if (rowState == RowState.Modified)
                    {
                        var id = dataGridView_KIV.Rows[index].Cells[0].Value.ToString();
                        var type = dataGridView_KIV.Rows[index].Cells[1].Value.ToString();
                        var name = dataGridView_KIV.Rows[index].Cells[2].Value.ToString();
                        var del = dataGridView_KIV.Rows[index].Cells[3].Value.ToString();
                        var cost = dataGridView_KIV.Rows[index].Cells[4].Value.ToString();

                        var changeQuery = $"update test_db set type_of = '{type}', name_of = '{name}', delivery = '{del}', price_of = '{cost}' where id = '{id}'";
                        var command = new SqlCommand(changeQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();




                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Грустно очень!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                dataBase.closeConnectiion();
            }
        }

        private void buttonDelete_KIV_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void buttonSaveCol_KIV_Click(object sender, EventArgs e)
        {
            Updates();
        }

        private void Chanhe()
        {
            var selectedRowIndex = dataGridView_KIV.CurrentCell.RowIndex;

            var id = textBoxID_KIV.Text;
            var type = textBoxType_KIV.Text;
            var name = textBoxTitel_KIV.Text;
            int del;
            int cost;
            if (dataGridView_KIV.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty) ;
            {
                if (int.TryParse(textBoxDel_KIV.Text, out del) && int.TryParse(textBoxCost_KIV.Text, out cost))
                {
                    dataGridView_KIV.Rows[selectedRowIndex].SetValues(id, type, name, del, cost);
                    dataGridView_KIV.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Ошибка: ", "Грустно очень!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonChange_KIV_Click(object sender, EventArgs e)
        {
            Chanhe();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int cost;
            int kol;
            int del;
            if (int.TryParse(textBox_del_KIV.Text, out del) && int.TryParse(textBox_cost_KIV.Text, out cost) && int.TryParse(textBoxKol_KIV.Text, out kol))
            {
                int a = (cost * kol) + del;
                textBoxSum_KIV.Text = a.ToString();
            }
            else
            {
                MessageBox.Show("Ошибка: ", "Грустно очень!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
/*try
            {
                dataBase.openConnectiion();
                for (int index = 0; index < dataGridView_KIV.Rows.Count; index++)
                {
                    var rowState = (RowState)dataGridView_KIV.Rows[index].Cells[5].Value;
                    if (rowState == RowState.Existed)
                    {
                        continue;
                    }
                    if (rowState == RowState.Deleted)
                    {
                        var id = Convert.ToInt32(dataGridView_KIV.Rows[index].Cells[0].Value);
                        var deleteQuery = $"delete from test_db where id = {id}";
                        var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();


                    }
                }
                dataBase.closeConnectiion();
            }
            catch
            {
                MessageBox.Show("Ошибка: " , "Грустно очень!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                dataBase.closeConnectiion();
            }
*/
