namespace Tyuiu.KokoulinIV.Sprint7.V2
{
    partial class Add_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxCostNew_KIV = new TextBox();
            textBoxDelNew_KIV = new TextBox();
            textBoxTitelNew_KIV = new TextBox();
            textBoxTypeNew_KIV = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            buttonSaveNewRow_KIV = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxCostNew_KIV
            // 
            textBoxCostNew_KIV.Location = new Point(278, 318);
            textBoxCostNew_KIV.Name = "textBoxCostNew_KIV";
            textBoxCostNew_KIV.Size = new Size(267, 23);
            textBoxCostNew_KIV.TabIndex = 28;
            // 
            // textBoxDelNew_KIV
            // 
            textBoxDelNew_KIV.Location = new Point(278, 276);
            textBoxDelNew_KIV.Name = "textBoxDelNew_KIV";
            textBoxDelNew_KIV.Size = new Size(267, 23);
            textBoxDelNew_KIV.TabIndex = 27;
            // 
            // textBoxTitelNew_KIV
            // 
            textBoxTitelNew_KIV.Location = new Point(278, 230);
            textBoxTitelNew_KIV.Name = "textBoxTitelNew_KIV";
            textBoxTitelNew_KIV.Size = new Size(267, 23);
            textBoxTitelNew_KIV.TabIndex = 26;
            // 
            // textBoxTypeNew_KIV
            // 
            textBoxTypeNew_KIV.Location = new Point(278, 185);
            textBoxTypeNew_KIV.Name = "textBoxTypeNew_KIV";
            textBoxTypeNew_KIV.Size = new Size(267, 23);
            textBoxTypeNew_KIV.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(122, 276);
            label8.Name = "label8";
            label8.Size = new Size(128, 17);
            label8.TabIndex = 23;
            label8.Text = "Стоимость доставки";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(122, 319);
            label7.Name = "label7";
            label7.Size = new Size(74, 17);
            label7.TabIndex = 22;
            label7.Text = "Цена за ед";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(122, 236);
            label6.Name = "label6";
            label6.Size = new Size(65, 17);
            label6.TabIndex = 21;
            label6.Text = "Название";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(120, 191);
            label5.Name = "label5";
            label5.Size = new Size(75, 17);
            label5.TabIndex = 20;
            label5.Text = "Тип товара\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(32, 34);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 18;
            label3.Text = "Новая запись";
            // 
            // buttonSaveNewRow_KIV
            // 
            buttonSaveNewRow_KIV.BackColor = SystemColors.Info;
            buttonSaveNewRow_KIV.FlatStyle = FlatStyle.Popup;
            buttonSaveNewRow_KIV.ForeColor = SystemColors.ControlText;
            buttonSaveNewRow_KIV.Location = new Point(220, 370);
            buttonSaveNewRow_KIV.Name = "buttonSaveNewRow_KIV";
            buttonSaveNewRow_KIV.Size = new Size(128, 54);
            buttonSaveNewRow_KIV.TabIndex = 29;
            buttonSaveNewRow_KIV.Text = "Сохранить";
            buttonSaveNewRow_KIV.UseVisualStyleBackColor = false;
            buttonSaveNewRow_KIV.Click += buttonSaveNewRow_KIV_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(144, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(372, 100);
            panel1.TabIndex = 30;
            // 
            // Add_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 449);
            Controls.Add(panel1);
            Controls.Add(buttonSaveNewRow_KIV);
            Controls.Add(textBoxCostNew_KIV);
            Controls.Add(textBoxDelNew_KIV);
            Controls.Add(textBoxTitelNew_KIV);
            Controls.Add(textBoxTypeNew_KIV);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Name = "Add_Form";
            Text = "Add_Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCostNew_KIV;
        private TextBox textBoxDelNew_KIV;
        private TextBox textBoxTitelNew_KIV;
        private TextBox textBoxTypeNew_KIV;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Button buttonSaveNewRow_KIV;
        private Panel panel1;
    }
}