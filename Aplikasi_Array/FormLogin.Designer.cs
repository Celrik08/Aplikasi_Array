namespace Aplikasi_Array
{
    partial class FormLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TextUser = new TextBox();
            TextPass = new TextBox();
            button1 = new Button();
            BtnLogout = new Button();
            CheckPass = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(120, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 0;
            label1.Text = "Form Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(53, 64);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(53, 97);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // TextUser
            // 
            TextUser.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextUser.Location = new Point(138, 61);
            TextUser.Name = "TextUser";
            TextUser.Size = new Size(125, 28);
            TextUser.TabIndex = 3;
            TextUser.KeyPress += TextUser_KeyPress;
            // 
            // TextPass
            // 
            TextPass.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextPass.Location = new Point(138, 94);
            TextPass.Name = "TextPass";
            TextPass.Size = new Size(125, 28);
            TextPass.TabIndex = 4;
            TextPass.KeyPress += TextPass_KeyPress;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(53, 181);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Klik";
            button1.UseVisualStyleBackColor = true;
            // 
            // BtnLogout
            // 
            BtnLogout.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLogout.Location = new Point(220, 181);
            BtnLogout.Name = "BtnLogout";
            BtnLogout.Size = new Size(94, 29);
            BtnLogout.TabIndex = 6;
            BtnLogout.Text = "Logout";
            BtnLogout.UseVisualStyleBackColor = true;
            BtnLogout.Click += BtnLogout_Click;
            // 
            // CheckPass
            // 
            CheckPass.AutoSize = true;
            CheckPass.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            CheckPass.Location = new Point(53, 140);
            CheckPass.Name = "CheckPass";
            CheckPass.Size = new Size(147, 24);
            CheckPass.TabIndex = 7;
            CheckPass.Text = "Show Password";
            CheckPass.UseVisualStyleBackColor = true;
            CheckPass.CheckedChanged += CheckPass_CheckedChanged;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 236);
            Controls.Add(CheckPass);
            Controls.Add(BtnLogout);
            Controls.Add(button1);
            Controls.Add(TextPass);
            Controls.Add(TextUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TextUser;
        private TextBox TextPass;
        private Button button1;
        private Button BtnLogout;
        private CheckBox CheckPass;
    }
}