namespace Обучающе_тестирующая_программа__Математика_
{
    partial class Teacher_data
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
            this.tB_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tB_password
            // 
            this.tB_password.Location = new System.Drawing.Point(42, 212);
            this.tB_password.Name = "tB_password";
            this.tB_password.Size = new System.Drawing.Size(202, 22);
            this.tB_password.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Пароль:";
            // 
            // tB_login
            // 
            this.tB_login.Location = new System.Drawing.Point(42, 130);
            this.tB_login.Name = "tB_login";
            this.tB_login.Size = new System.Drawing.Size(202, 22);
            this.tB_login.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Логин:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(82, 286);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(121, 40);
            this.btn_save.TabIndex = 21;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tB_name
            // 
            this.tB_name.Location = new System.Drawing.Point(42, 53);
            this.tB_name.Name = "tB_name";
            this.tB_name.Size = new System.Drawing.Size(202, 22);
            this.tB_name.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "ФИО:";
            // 
            // Teacher_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 365);
            this.Controls.Add(this.tB_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tB_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tB_name);
            this.Controls.Add(this.label1);
            this.Name = "Teacher_data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личная информация";
            this.Load += new System.EventHandler(this.Teacher_data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tB_name;
        private System.Windows.Forms.Label label1;
    }
}