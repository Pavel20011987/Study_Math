namespace Обучающе_тестирующая_программа__Математика_
{
    partial class Test
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
            this.lbl_qst = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.cLB_answ = new System.Windows.Forms.CheckedListBox();
            this.tB_answ = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_finish = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_qstNumber = new System.Windows.Forms.Label();
            this.lbl_allQstNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_point = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_qst
            // 
            this.lbl_qst.AutoSize = true;
            this.lbl_qst.Location = new System.Drawing.Point(25, 74);
            this.lbl_qst.MaximumSize = new System.Drawing.Size(524, 53);
            this.lbl_qst.Name = "lbl_qst";
            this.lbl_qst.Size = new System.Drawing.Size(62, 17);
            this.lbl_qst.TabIndex = 0;
            this.lbl_qst.Text = "question";
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(465, 374);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(87, 34);
            this.btn_next.TabIndex = 4;
            this.btn_next.Text = "Далее >";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // cLB_answ
            // 
            this.cLB_answ.FormattingEnabled = true;
            this.cLB_answ.Location = new System.Drawing.Point(28, 133);
            this.cLB_answ.Name = "cLB_answ";
            this.cLB_answ.Size = new System.Drawing.Size(524, 208);
            this.cLB_answ.TabIndex = 6;
            this.cLB_answ.Visible = false;
            // 
            // tB_answ
            // 
            this.tB_answ.Location = new System.Drawing.Point(28, 133);
            this.tB_answ.Multiline = true;
            this.tB_answ.Name = "tB_answ";
            this.tB_answ.Size = new System.Drawing.Size(524, 111);
            this.tB_answ.TabIndex = 7;
            this.tB_answ.Visible = false;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(372, 374);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(87, 34);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "< Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_finish
            // 
            this.btn_finish.Location = new System.Drawing.Point(28, 374);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(144, 34);
            this.btn_finish.TabIndex = 9;
            this.btn_finish.Text = "Сдать тест";
            this.btn_finish.UseVisualStyleBackColor = true;
            this.btn_finish.Click += new System.EventHandler(this.btn_finish_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Вопрос";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "из";
            // 
            // lbl_qstNumber
            // 
            this.lbl_qstNumber.AutoSize = true;
            this.lbl_qstNumber.Location = new System.Drawing.Point(87, 32);
            this.lbl_qstNumber.Name = "lbl_qstNumber";
            this.lbl_qstNumber.Size = new System.Drawing.Size(24, 17);
            this.lbl_qstNumber.TabIndex = 12;
            this.lbl_qstNumber.Text = "__";
            this.lbl_qstNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_allQstNumber
            // 
            this.lbl_allQstNumber.AutoSize = true;
            this.lbl_allQstNumber.Location = new System.Drawing.Point(148, 32);
            this.lbl_allQstNumber.Name = "lbl_allQstNumber";
            this.lbl_allQstNumber.Size = new System.Drawing.Size(24, 17);
            this.lbl_allQstNumber.TabIndex = 13;
            this.lbl_allQstNumber.Text = "__";
            this.lbl_allQstNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Максимальный балл за ответ: ";
            // 
            // lbl_point
            // 
            this.lbl_point.AutoSize = true;
            this.lbl_point.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_point.Location = new System.Drawing.Point(519, 49);
            this.lbl_point.Name = "lbl_point";
            this.lbl_point.Size = new System.Drawing.Size(46, 17);
            this.lbl_point.TabIndex = 15;
            this.lbl_point.Text = "label4";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.lbl_point);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_allQstNumber);
            this.Controls.Add(this.lbl_qstNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_finish);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.tB_answ);
            this.Controls.Add(this.cLB_answ);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_qst);
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тест";
            this.Load += new System.EventHandler(this.Test_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_qst;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.CheckedListBox cLB_answ;
        private System.Windows.Forms.TextBox tB_answ;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_finish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_qstNumber;
        private System.Windows.Forms.Label lbl_allQstNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_point;
    }
}