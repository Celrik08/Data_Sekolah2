namespace Data_Sekolah2
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
            BtnKlik = new Button();
            BtnLogout = new Button();
            CheckPass = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(160, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 0;
            label1.Text = "Form Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 69);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 110);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // TextUser
            // 
            TextUser.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextUser.Location = new Point(175, 69);
            TextUser.Margin = new Padding(4, 3, 4, 3);
            TextUser.Name = "TextUser";
            TextUser.Size = new Size(155, 28);
            TextUser.TabIndex = 3;
            TextUser.KeyPress += TextUser_KeyPress;
            // 
            // TextPass
            // 
            TextPass.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextPass.Location = new Point(175, 110);
            TextPass.Margin = new Padding(4, 3, 4, 3);
            TextPass.Name = "TextPass";
            TextPass.Size = new Size(155, 28);
            TextPass.TabIndex = 4;
            TextPass.KeyPress += TextPass_KeyPress;
            // 
            // BtnKlik
            // 
            BtnKlik.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnKlik.Location = new Point(32, 199);
            BtnKlik.Margin = new Padding(4, 3, 4, 3);
            BtnKlik.Name = "BtnKlik";
            BtnKlik.Size = new Size(118, 29);
            BtnKlik.TabIndex = 5;
            BtnKlik.Text = "Klik";
            BtnKlik.UseVisualStyleBackColor = true;
            BtnKlik.Click += BtnKlik_Click;
            // 
            // BtnLogout
            // 
            BtnLogout.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLogout.Location = new Point(289, 199);
            BtnLogout.Margin = new Padding(4, 3, 4, 3);
            BtnLogout.Name = "BtnLogout";
            BtnLogout.Size = new Size(118, 29);
            BtnLogout.TabIndex = 6;
            BtnLogout.Text = "Logout";
            BtnLogout.UseVisualStyleBackColor = true;
            BtnLogout.Click += BtnLogout_Click;
            // 
            // CheckPass
            // 
            CheckPass.AutoSize = true;
            CheckPass.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            CheckPass.Location = new Point(32, 154);
            CheckPass.Margin = new Padding(4, 3, 4, 3);
            CheckPass.Name = "CheckPass";
            CheckPass.Size = new Size(147, 24);
            CheckPass.TabIndex = 7;
            CheckPass.Text = "Show Password";
            CheckPass.UseVisualStyleBackColor = true;
            CheckPass.CheckedChanged += CheckPass_CheckedChanged;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 245);
            Controls.Add(CheckPass);
            Controls.Add(BtnLogout);
            Controls.Add(BtnKlik);
            Controls.Add(TextPass);
            Controls.Add(TextUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
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
        private Button BtnKlik;
        private Button BtnLogout;
        private CheckBox CheckPass;
    }
}