namespace Tyuiu.KokoulinIV.Sprint6.V2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer1 = new SplitContainer();
            panel2 = new Panel();
            button1 = new Button();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            textBoxKol_KIV = new TextBox();
            textBox_del_KIV = new TextBox();
            textBoxSum_KIV = new TextBox();
            textBox_cost_KIV = new TextBox();
            label9 = new Label();
            buttonUpdate_KIV = new Button();
            label1 = new Label();
            textBoxSearch_KIV = new TextBox();
            buttonMenu_KIV = new Button();
            ContextMenu = new ContextMenuStrip(components);
            buttonOpenFile_KIV = new ToolStripMenuItem();
            buttonSaveHow_KIV = new ToolStripMenuItem();
            buttonAbout_KIV = new ToolStripMenuItem();
            splitter1 = new Splitter();
            panel1 = new Panel();
            splitter2 = new Splitter();
            buttonSaveCol_KIV = new Button();
            textBoxCost_KIV = new TextBox();
            textBoxDel_KIV = new TextBox();
            textBoxTitel_KIV = new TextBox();
            textBoxType_KIV = new TextBox();
            textBoxID_KIV = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            buttonAdd_KIV = new Button();
            buttonChange_KIV = new Button();
            buttonDelete_KIV = new Button();
            label2 = new Label();
            dataGridView_KIV = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog_KIV = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            ContextMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_KIV).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ActiveBorder;
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(buttonUpdate_KIV);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(textBoxSearch_KIV);
            splitContainer1.Panel1.Controls.Add(buttonMenu_KIV);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitter1);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(dataGridView_KIV);
            splitContainer1.Size = new Size(1428, 751);
            splitContainer1.SplitterDistance = 192;
            splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBoxKol_KIV);
            panel2.Controls.Add(textBox_del_KIV);
            panel2.Controls.Add(textBoxSum_KIV);
            panel2.Controls.Add(textBox_cost_KIV);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(860, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 138);
            panel2.TabIndex = 21;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(403, 16);
            button1.Name = "button1";
            button1.Size = new Size(87, 23);
            button1.TabIndex = 12;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label16.Location = new Point(339, 74);
            label16.Name = "label16";
            label16.Size = new Size(27, 30);
            label16.TabIndex = 11;
            label16.Text = "=";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label15.Location = new Point(209, 81);
            label15.Name = "label15";
            label15.Size = new Size(21, 21);
            label15.TabIndex = 10;
            label15.Text = "+";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label14.Location = new Point(111, 81);
            label14.Name = "label14";
            label14.Size = new Size(22, 30);
            label14.TabIndex = 9;
            label14.Text = "*";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label13.Location = new Point(403, 55);
            label13.Name = "label13";
            label13.Size = new Size(56, 21);
            label13.TabIndex = 8;
            label13.Text = "Итого:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label12.Location = new Point(246, 57);
            label12.Name = "label12";
            label12.Size = new Size(76, 21);
            label12.TabIndex = 7;
            label12.Text = "Доставка";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.Location = new Point(139, 57);
            label11.Name = "label11";
            label11.Size = new Size(59, 21);
            label11.TabIndex = 6;
            label11.Text = "Кол-во";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(39, 36);
            label10.Name = "label10";
            label10.Size = new Size(66, 42);
            label10.TabIndex = 5;
            label10.Text = "Цена за\r\nшт.\r\n";
            // 
            // textBoxKol_KIV
            // 
            textBoxKol_KIV.Location = new Point(139, 81);
            textBoxKol_KIV.Name = "textBoxKol_KIV";
            textBoxKol_KIV.Size = new Size(64, 23);
            textBoxKol_KIV.TabIndex = 4;
            // 
            // textBox_del_KIV
            // 
            textBox_del_KIV.Location = new Point(246, 81);
            textBox_del_KIV.Name = "textBox_del_KIV";
            textBox_del_KIV.Size = new Size(64, 23);
            textBox_del_KIV.TabIndex = 3;
            // 
            // textBoxSum_KIV
            // 
            textBoxSum_KIV.Location = new Point(403, 79);
            textBoxSum_KIV.Name = "textBoxSum_KIV";
            textBoxSum_KIV.Size = new Size(99, 23);
            textBoxSum_KIV.TabIndex = 2;
            // 
            // textBox_cost_KIV
            // 
            textBox_cost_KIV.Location = new Point(41, 81);
            textBox_cost_KIV.Name = "textBox_cost_KIV";
            textBox_cost_KIV.Size = new Size(64, 23);
            textBox_cost_KIV.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(196, 18);
            label9.Name = "label9";
            label9.Size = new Size(137, 21);
            label9.TabIndex = 0;
            label9.Text = "Расчет стоимости";
            // 
            // buttonUpdate_KIV
            // 
            buttonUpdate_KIV.BackColor = SystemColors.Info;
            buttonUpdate_KIV.FlatStyle = FlatStyle.Popup;
            buttonUpdate_KIV.ForeColor = SystemColors.ControlText;
            buttonUpdate_KIV.Location = new Point(10, 144);
            buttonUpdate_KIV.Name = "buttonUpdate_KIV";
            buttonUpdate_KIV.Size = new Size(87, 23);
            buttonUpdate_KIV.TabIndex = 20;
            buttonUpdate_KIV.Text = "Обновить";
            buttonUpdate_KIV.UseVisualStyleBackColor = false;
            buttonUpdate_KIV.Click += buttonUpdate_KIV_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(191, 108);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 2;
            label1.Text = "Поиск \r\n";
            // 
            // textBoxSearch_KIV
            // 
            textBoxSearch_KIV.Location = new Point(191, 144);
            textBoxSearch_KIV.Name = "textBoxSearch_KIV";
            textBoxSearch_KIV.Size = new Size(267, 23);
            textBoxSearch_KIV.TabIndex = 1;
            textBoxSearch_KIV.TextChanged += textBoxSearch_KIV_TextChanged;
            // 
            // buttonMenu_KIV
            // 
            buttonMenu_KIV.BackColor = SystemColors.ButtonFace;
            buttonMenu_KIV.ContextMenuStrip = ContextMenu;
            buttonMenu_KIV.Image = (Image)resources.GetObject("buttonMenu_KIV.Image");
            buttonMenu_KIV.Location = new Point(10, 10);
            buttonMenu_KIV.Name = "buttonMenu_KIV";
            buttonMenu_KIV.Size = new Size(69, 58);
            buttonMenu_KIV.TabIndex = 0;
            buttonMenu_KIV.UseVisualStyleBackColor = false;
            buttonMenu_KIV.Click += button1_Click;
            // 
            // ContextMenu
            // 
            ContextMenu.Items.AddRange(new ToolStripItem[] { buttonOpenFile_KIV, buttonSaveHow_KIV, buttonAbout_KIV });
            ContextMenu.Name = "contextMenuStrip";
            ContextMenu.Size = new Size(164, 70);
            ContextMenu.Text = "Меню";
            ContextMenu.UseWaitCursor = true;
            // 
            // buttonOpenFile_KIV
            // 
            buttonOpenFile_KIV.Name = "buttonOpenFile_KIV";
            buttonOpenFile_KIV.Size = new Size(163, 22);
            buttonOpenFile_KIV.Text = "Открыть файл";
            buttonOpenFile_KIV.Click += открытьФайлToolStripMenuItem_Click;
            // 
            // buttonSaveHow_KIV
            // 
            buttonSaveHow_KIV.Name = "buttonSaveHow_KIV";
            buttonSaveHow_KIV.Size = new Size(163, 22);
            buttonSaveHow_KIV.Text = "Сохранить как...";
            buttonSaveHow_KIV.Click += buttonSaveHow_KIV_Click;
            // 
            // buttonAbout_KIV
            // 
            buttonAbout_KIV.Name = "buttonAbout_KIV";
            buttonAbout_KIV.Size = new Size(163, 22);
            buttonAbout_KIV.Text = "О приложении";
            buttonAbout_KIV.Click += buttonAbout_KIV_Click;
            // 
            // splitter1
            // 
            splitter1.BorderStyle = BorderStyle.Fixed3D;
            splitter1.Location = new Point(919, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 551);
            splitter1.TabIndex = 5;
            splitter1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(splitter2);
            panel1.Controls.Add(buttonSaveCol_KIV);
            panel1.Controls.Add(textBoxCost_KIV);
            panel1.Controls.Add(textBoxDel_KIV);
            panel1.Controls.Add(textBoxTitel_KIV);
            panel1.Controls.Add(textBoxType_KIV);
            panel1.Controls.Add(textBoxID_KIV);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(buttonAdd_KIV);
            panel1.Controls.Add(buttonChange_KIV);
            panel1.Controls.Add(buttonDelete_KIV);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(919, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(505, 551);
            panel1.TabIndex = 4;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(0, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(10, 551);
            splitter2.TabIndex = 20;
            splitter2.TabStop = false;
            // 
            // buttonSaveCol_KIV
            // 
            buttonSaveCol_KIV.BackColor = SystemColors.Info;
            buttonSaveCol_KIV.FlatStyle = FlatStyle.Popup;
            buttonSaveCol_KIV.ForeColor = SystemColors.ControlText;
            buttonSaveCol_KIV.Location = new Point(188, 93);
            buttonSaveCol_KIV.Name = "buttonSaveCol_KIV";
            buttonSaveCol_KIV.Size = new Size(87, 23);
            buttonSaveCol_KIV.TabIndex = 19;
            buttonSaveCol_KIV.Text = "Сохранить";
            buttonSaveCol_KIV.UseVisualStyleBackColor = false;
            buttonSaveCol_KIV.Click += buttonSaveCol_KIV_Click;
            // 
            // textBoxCost_KIV
            // 
            textBoxCost_KIV.Location = new Point(188, 354);
            textBoxCost_KIV.Name = "textBoxCost_KIV";
            textBoxCost_KIV.Size = new Size(267, 23);
            textBoxCost_KIV.TabIndex = 17;
            // 
            // textBoxDel_KIV
            // 
            textBoxDel_KIV.Location = new Point(188, 312);
            textBoxDel_KIV.Name = "textBoxDel_KIV";
            textBoxDel_KIV.Size = new Size(267, 23);
            textBoxDel_KIV.TabIndex = 16;
            // 
            // textBoxTitel_KIV
            // 
            textBoxTitel_KIV.Location = new Point(188, 266);
            textBoxTitel_KIV.Name = "textBoxTitel_KIV";
            textBoxTitel_KIV.Size = new Size(267, 23);
            textBoxTitel_KIV.TabIndex = 15;
            // 
            // textBoxType_KIV
            // 
            textBoxType_KIV.Location = new Point(188, 221);
            textBoxType_KIV.Name = "textBoxType_KIV";
            textBoxType_KIV.Size = new Size(267, 23);
            textBoxType_KIV.TabIndex = 14;
            // 
            // textBoxID_KIV
            // 
            textBoxID_KIV.Location = new Point(188, 177);
            textBoxID_KIV.Name = "textBoxID_KIV";
            textBoxID_KIV.Size = new Size(267, 23);
            textBoxID_KIV.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(32, 312);
            label8.Name = "label8";
            label8.Size = new Size(128, 17);
            label8.TabIndex = 12;
            label8.Text = "Стоимость доставки";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(32, 355);
            label7.Name = "label7";
            label7.Size = new Size(74, 17);
            label7.TabIndex = 11;
            label7.Text = "Цена за ед";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(32, 272);
            label6.Name = "label6";
            label6.Size = new Size(65, 17);
            label6.TabIndex = 10;
            label6.Text = "Название";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(30, 227);
            label5.Name = "label5";
            label5.Size = new Size(75, 17);
            label5.TabIndex = 9;
            label5.Text = "Тип товара\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(32, 183);
            label4.Name = "label4";
            label4.Size = new Size(20, 17);
            label4.TabIndex = 8;
            label4.Text = "ID";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(32, 122);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 7;
            label3.Text = "Запись";
            // 
            // buttonAdd_KIV
            // 
            buttonAdd_KIV.BackColor = SystemColors.Info;
            buttonAdd_KIV.FlatStyle = FlatStyle.Popup;
            buttonAdd_KIV.ForeColor = SystemColors.ControlText;
            buttonAdd_KIV.Location = new Point(281, 64);
            buttonAdd_KIV.Name = "buttonAdd_KIV";
            buttonAdd_KIV.Size = new Size(87, 23);
            buttonAdd_KIV.TabIndex = 6;
            buttonAdd_KIV.Text = "Создать";
            buttonAdd_KIV.UseVisualStyleBackColor = false;
            buttonAdd_KIV.Click += buttonAdd_KIV_Click;
            // 
            // buttonChange_KIV
            // 
            buttonChange_KIV.BackColor = SystemColors.Info;
            buttonChange_KIV.FlatStyle = FlatStyle.Popup;
            buttonChange_KIV.ForeColor = SystemColors.ControlText;
            buttonChange_KIV.Location = new Point(188, 64);
            buttonChange_KIV.Name = "buttonChange_KIV";
            buttonChange_KIV.Size = new Size(87, 23);
            buttonChange_KIV.TabIndex = 5;
            buttonChange_KIV.Text = "Изменить";
            buttonChange_KIV.UseVisualStyleBackColor = false;
            buttonChange_KIV.Click += buttonChange_KIV_Click;
            // 
            // buttonDelete_KIV
            // 
            buttonDelete_KIV.BackColor = SystemColors.Info;
            buttonDelete_KIV.FlatStyle = FlatStyle.Popup;
            buttonDelete_KIV.ForeColor = SystemColors.ControlText;
            buttonDelete_KIV.Location = new Point(95, 64);
            buttonDelete_KIV.Name = "buttonDelete_KIV";
            buttonDelete_KIV.Size = new Size(87, 23);
            buttonDelete_KIV.TabIndex = 4;
            buttonDelete_KIV.Text = "Удалить";
            buttonDelete_KIV.UseVisualStyleBackColor = false;
            buttonDelete_KIV.Click += buttonDelete_KIV_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(163, 21);
            label2.Name = "label2";
            label2.Size = new Size(139, 17);
            label2.TabIndex = 0;
            label2.Text = "Управление записями";
            label2.Click += label2_Click;
            // 
            // dataGridView_KIV
            // 
            dataGridView_KIV.AllowUserToAddRows = false;
            dataGridView_KIV.AllowUserToDeleteRows = false;
            dataGridView_KIV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView_KIV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_KIV.Dock = DockStyle.Left;
            dataGridView_KIV.EnableHeadersVisualStyles = false;
            dataGridView_KIV.Location = new Point(0, 0);
            dataGridView_KIV.Name = "dataGridView_KIV";
            dataGridView_KIV.ReadOnly = true;
            dataGridView_KIV.Size = new Size(919, 551);
            dataGridView_KIV.TabIndex = 0;
            dataGridView_KIV.CellClick += dataGridView_KIV_CellClick;
            dataGridView_KIV.CellContentClick += dataGridView_KIV_CellContentClick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1428, 751);
            Controls.Add(splitContainer1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 7 | Кокоулин И.В.";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ContextMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_KIV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button buttonMenu_KIV;
        private ContextMenuStrip ContextMenu;
        private ToolStripMenuItem buttonOpenFile_KIV;
        private ToolStripMenuItem buttonSaveHow_KIV;
        private ToolStripMenuItem buttonAbout_KIV;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog_KIV;
        private Label label1;
        private TextBox textBoxSearch_KIV;
        private Panel panel1;
        private Label label2;
        private Button buttonAdd_KIV;
        private Button buttonChange_KIV;
        private Button buttonDelete_KIV;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBoxCost_KIV;
        private TextBox textBoxDel_KIV;
        private TextBox textBoxTitel_KIV;
        private TextBox textBoxType_KIV;
        private TextBox textBoxID_KIV;
        private Button buttonUpdate_KIV;
        private Button buttonSaveCol_KIV;
        private Panel panel2;
        private Label label9;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox textBoxKol_KIV;
        private TextBox textBox_del_KIV;
        private TextBox textBoxSum_KIV;
        private TextBox textBox_cost_KIV;
        private Button button1;
        private Splitter splitter1;
        private Splitter splitter2;
        private DataGridView dataGridView_KIV;
    }
}
