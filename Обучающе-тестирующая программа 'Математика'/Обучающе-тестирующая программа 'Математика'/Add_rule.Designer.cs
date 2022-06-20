namespace Обучающе_тестирующая_программа__Математика_
{
    partial class Add_rule
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
            this.tB_ruleName = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_ruleText = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSB_back = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tB_ruleName
            // 
            this.tB_ruleName.Location = new System.Drawing.Point(105, 40);
            this.tB_ruleName.Name = "tB_ruleName";
            this.tB_ruleName.Size = new System.Drawing.Size(640, 22);
            this.tB_ruleName.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(516, 411);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(214, 35);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Сохранить правило и выйти";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Название:";
            // 
            // tB_ruleText
            // 
            this.tB_ruleText.Location = new System.Drawing.Point(26, 83);
            this.tB_ruleText.Multiline = true;
            this.tB_ruleText.Name = "tB_ruleText";
            this.tB_ruleText.Size = new System.Drawing.Size(719, 322);
            this.tB_ruleText.TabIndex = 10;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSB_back,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(780, 31);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSB_back
            // 
            this.tSB_back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_back.Image = global::Обучающе_тестирующая_программа__Математика_.Properties.Resources.back;
            this.tSB_back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_back.Name = "tSB_back";
            this.tSB_back.Size = new System.Drawing.Size(29, 28);
            this.tSB_back.Text = "Назад";
            this.tSB_back.Click += new System.EventHandler(this.tSB_back_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(51, 24);
            this.toolStripLabel1.Text = "Назад";
            // 
            // Add_rule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 456);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tB_ruleText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB_ruleName);
            this.Controls.Add(this.btn_add);
            this.Name = "Add_rule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор правила";
            this.Load += new System.EventHandler(this.Add_rule_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tB_ruleName;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_ruleText;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tSB_back;
    }
}