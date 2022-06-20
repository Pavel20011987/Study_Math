namespace Обучающе_тестирующая_программа__Математика_
{
    partial class Show_rule
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
            this.lbl_ruleName = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSB_back = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tB_ruleText = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ruleName
            // 
            this.lbl_ruleName.AutoSize = true;
            this.lbl_ruleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ruleName.Location = new System.Drawing.Point(27, 47);
            this.lbl_ruleName.MaximumSize = new System.Drawing.Size(656, 50);
            this.lbl_ruleName.Name = "lbl_ruleName";
            this.lbl_ruleName.Size = new System.Drawing.Size(52, 17);
            this.lbl_ruleName.TabIndex = 1;
            this.lbl_ruleName.Text = "label1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSB_back,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(725, 27);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSB_back
            // 
            this.tSB_back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_back.Image = global::Обучающе_тестирующая_программа__Математика_.Properties.Resources.back;
            this.tSB_back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_back.Name = "tSB_back";
            this.tSB_back.Size = new System.Drawing.Size(29, 24);
            this.tSB_back.Text = "Назад";
            this.tSB_back.Click += new System.EventHandler(this.tSB_back_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(51, 24);
            this.toolStripLabel1.Text = "Назад";
            // 
            // tB_ruleText
            // 
            this.tB_ruleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tB_ruleText.Location = new System.Drawing.Point(30, 105);
            this.tB_ruleText.Multiline = true;
            this.tB_ruleText.Name = "tB_ruleText";
            this.tB_ruleText.ReadOnly = true;
            this.tB_ruleText.Size = new System.Drawing.Size(660, 320);
            this.tB_ruleText.TabIndex = 24;
            // 
            // Show_rule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 458);
            this.Controls.Add(this.tB_ruleText);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbl_ruleName);
            this.Name = "Show_rule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Правило";
            this.Load += new System.EventHandler(this.Show_rule_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_ruleName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSB_back;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TextBox tB_ruleText;
    }
}