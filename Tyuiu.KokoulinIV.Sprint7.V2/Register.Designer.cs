namespace Tyuiu.KokoulinIV.Sprint7.V2
{
    partial class Register
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
            buttonRegister_KIV = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox_LoginReg_KIV = new TextBox();
            textBox_PasswordReg_KIV = new TextBox();
            buttonPasswordReg_KIV = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // buttonRegister_KIV
            // 
            buttonRegister_KIV.BackColor = Color.FromArgb(192, 255, 192);
            buttonRegister_KIV.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRegister_KIV.Location = new Point(251, 306);
            buttonRegister_KIV.Name = "buttonRegister_KIV";
            buttonRegister_KIV.Size = new Size(111, 74);
            buttonRegister_KIV.TabIndex = 0;
            buttonRegister_KIV.Text = "СОЗДАТЬ АККАУНТ";
            buttonRegister_KIV.UseVisualStyleBackColor = false;
            buttonRegister_KIV.Click += buttonRegister_KIV_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(91, 159);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 1;
            label1.Text = "ЛОГИН";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(91, 228);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 2;
            label2.Text = "ПАРОЛЬ";
            // 
            // textBox_LoginReg_KIV
            // 
            textBox_LoginReg_KIV.Location = new Point(209, 161);
            textBox_LoginReg_KIV.Name = "textBox_LoginReg_KIV";
            textBox_LoginReg_KIV.Size = new Size(205, 23);
            textBox_LoginReg_KIV.TabIndex = 3;
            // 
            // textBox_PasswordReg_KIV
            // 
            textBox_PasswordReg_KIV.Location = new Point(209, 232);
            textBox_PasswordReg_KIV.Name = "textBox_PasswordReg_KIV";
            textBox_PasswordReg_KIV.Size = new Size(205, 23);
            textBox_PasswordReg_KIV.TabIndex = 4;
            // 
            // buttonPasswordReg_KIV
            // 
            buttonPasswordReg_KIV.Location = new Point(432, 232);
            buttonPasswordReg_KIV.Name = "buttonPasswordReg_KIV";
            buttonPasswordReg_KIV.Size = new Size(113, 23);
            buttonPasswordReg_KIV.TabIndex = 5;
            buttonPasswordReg_KIV.Text = "показать пароль";
            buttonPasswordReg_KIV.UseVisualStyleBackColor = true;
            buttonPasswordReg_KIV.Click += buttonPasswordReg_KIV_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(227, 57);
            label3.Name = "label3";
            label3.Size = new Size(174, 32);
            label3.TabIndex = 6;
            label3.Text = "РЕГИСТРАЦИЯ\r\n";
            // 
            // Register
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(633, 431);
            Controls.Add(label3);
            Controls.Add(buttonPasswordReg_KIV);
            Controls.Add(textBox_PasswordReg_KIV);
            Controls.Add(textBox_LoginReg_KIV);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonRegister_KIV);
            Name = "Register";
            Text = "sing_up";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegister_KIV;
        private Label label1;
        private Label label2;
        private TextBox textBox_LoginReg_KIV;
        private TextBox textBox_PasswordReg_KIV;
        private Button buttonPasswordReg_KIV;
        private Label label3;
    }
}