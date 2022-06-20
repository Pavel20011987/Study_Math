namespace Обучающе_тестирующая_программа__Математика_
{
    partial class Change_theme_name
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
            this.btn_change = new System.Windows.Forms.Button();
            this.tB_themeName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(156, 119);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(156, 40);
            this.btn_change.TabIndex = 0;
            this.btn_change.Text = "Изменить";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // tB_themeName
            // 
            this.tB_themeName.Location = new System.Drawing.Point(25, 31);
            this.tB_themeName.Multiline = true;
            this.tB_themeName.Name = "tB_themeName";
            this.tB_themeName.Size = new System.Drawing.Size(417, 70);
            this.tB_themeName.TabIndex = 1;
            // 
            // Change_theme_name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 178);
            this.Controls.Add(this.tB_themeName);
            this.Controls.Add(this.btn_change);
            this.Name = "Change_theme_name";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение названия темы";
            this.Load += new System.EventHandler(this.Change_theme_name_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.TextBox tB_themeName;
    }
}