namespace Tyuiu.KokoulinIV.Sprint7.V2
{
    partial class Entrance
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
            label3 = new Label();
            buttonPassword_KIV = new Button();
            textBox_Password_KIV = new TextBox();
            textBox_Login_KIV = new TextBox();
            label2 = new Label();
            label1 = new Label();
            buttonImput_KIV = new Button();
            LinkToReg_LIV = new LinkLabel();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(223, 74);
            label3.Name = "label3";
            label3.Size = new Size(183, 32);
            label3.TabIndex = 13;
            label3.Text = "АВТОРИЗАЦИЯ";
            // 
            // buttonPassword_KIV
            // 
            buttonPassword_KIV.Location = new Point(437, 246);
            buttonPassword_KIV.Name = "buttonPassword_KIV";
            buttonPassword_KIV.Size = new Size(113, 23);
            buttonPassword_KIV.TabIndex = 12;
            buttonPassword_KIV.Text = "показать пароль";
            buttonPassword_KIV.UseVisualStyleBackColor = true;
            buttonPassword_KIV.Click += buttonPassword_KIV_Click;
            // 
            // textBox_Password_KIV
            // 
            textBox_Password_KIV.Location = new Point(214, 246);
            textBox_Password_KIV.Name = "textBox_Password_KIV";
            textBox_Password_KIV.Size = new Size(205, 23);
            textBox_Password_KIV.TabIndex = 11;
            // 
            // textBox_Login_KIV
            // 
            textBox_Login_KIV.Location = new Point(214, 175);
            textBox_Login_KIV.Name = "textBox_Login_KIV";
            textBox_Login_KIV.Size = new Size(205, 23);
            textBox_Login_KIV.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(96, 242);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 9;
            label2.Text = "ПАРОЛЬ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(96, 173);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 8;
            label1.Text = "ЛОГИН";
            // 
            // buttonImput_KIV
            // 
            buttonImput_KIV.BackColor = Color.FromArgb(192, 255, 192);
            buttonImput_KIV.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonImput_KIV.Location = new Point(256, 320);
            buttonImput_KIV.Name = "buttonImput_KIV";
            buttonImput_KIV.Size = new Size(111, 74);
            buttonImput_KIV.TabIndex = 7;
            buttonImput_KIV.Text = "ВОЙТИ";
            buttonImput_KIV.UseVisualStyleBackColor = false;
            buttonImput_KIV.Click += buttonImput_KIV_Click;
            // 
            // LinkToReg_LIV
            // 
            LinkToReg_LIV.AutoSize = true;
            LinkToReg_LIV.Location = new Point(241, 437);
            LinkToReg_LIV.Name = "LinkToReg_LIV";
            LinkToReg_LIV.Size = new Size(143, 15);
            LinkToReg_LIV.TabIndex = 14;
            LinkToReg_LIV.TabStop = true;
            LinkToReg_LIV.Text = "Еще не создали аккаунт?";
            LinkToReg_LIV.LinkClicked += LinkToReg_LIV_LinkClicked;
            // 
            // Entrance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 482);
            Controls.Add(LinkToReg_LIV);
            Controls.Add(label3);
            Controls.Add(buttonPassword_KIV);
            Controls.Add(textBox_Password_KIV);
            Controls.Add(textBox_Login_KIV);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonImput_KIV);
            Name = "Entrance";
            Text = "Entrance";
            Load += Entrance_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button buttonPassword_KIV;
        private TextBox textBox_Password_KIV;
        private TextBox textBox_Login_KIV;
        private Label label2;
        private Label label1;
        private Button buttonImput_KIV;
        private LinkLabel LinkToReg_LIV;
    }
}