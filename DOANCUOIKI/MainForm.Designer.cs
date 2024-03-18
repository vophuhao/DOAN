namespace DOANCUOIKI
{
    partial class MainForm
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
            this.ReportBtn = new System.Windows.Forms.Button();
            this.FinanceBtn = new System.Windows.Forms.Button();
            this.TreatmentBtn = new System.Windows.Forms.Button();
            this.AppoimentBtn = new System.Windows.Forms.Button();
            this.ListBtn = new System.Windows.Forms.Button();
            this.panel_body = new System.Windows.Forms.Panel();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReportBtn
            // 
            this.ReportBtn.Location = new System.Drawing.Point(60, 547);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(140, 44);
            this.ReportBtn.TabIndex = 10;
            this.ReportBtn.Text = "Report";
            this.ReportBtn.UseVisualStyleBackColor = true;
            this.ReportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // FinanceBtn
            // 
            this.FinanceBtn.Location = new System.Drawing.Point(48, 422);
            this.FinanceBtn.Name = "FinanceBtn";
            this.FinanceBtn.Size = new System.Drawing.Size(140, 44);
            this.FinanceBtn.TabIndex = 9;
            this.FinanceBtn.Text = "Finance";
            this.FinanceBtn.UseVisualStyleBackColor = true;
            this.FinanceBtn.Click += new System.EventHandler(this.FinanceBtn_Click);
            // 
            // TreatmentBtn
            // 
            this.TreatmentBtn.Location = new System.Drawing.Point(48, 323);
            this.TreatmentBtn.Name = "TreatmentBtn";
            this.TreatmentBtn.Size = new System.Drawing.Size(140, 44);
            this.TreatmentBtn.TabIndex = 8;
            this.TreatmentBtn.Text = "Treatment";
            this.TreatmentBtn.UseVisualStyleBackColor = true;
            this.TreatmentBtn.Click += new System.EventHandler(this.TreatmentBtn_Click);
            // 
            // AppoimentBtn
            // 
            this.AppoimentBtn.Location = new System.Drawing.Point(48, 247);
            this.AppoimentBtn.Name = "AppoimentBtn";
            this.AppoimentBtn.Size = new System.Drawing.Size(166, 44);
            this.AppoimentBtn.TabIndex = 7;
            this.AppoimentBtn.Text = "appointment schedules";
            this.AppoimentBtn.UseVisualStyleBackColor = true;
            this.AppoimentBtn.Click += new System.EventHandler(this.AppoimentBtn_Click);
            // 
            // ListBtn
            // 
            this.ListBtn.Location = new System.Drawing.Point(48, 179);
            this.ListBtn.Name = "ListBtn";
            this.ListBtn.Size = new System.Drawing.Size(140, 44);
            this.ListBtn.TabIndex = 6;
            this.ListBtn.Text = "LIST PATIENT";
            this.ListBtn.UseVisualStyleBackColor = true;
            this.ListBtn.Click += new System.EventHandler(this.ListBtn_Click);
            // 
            // panel_body
            // 
            this.panel_body.Location = new System.Drawing.Point(229, 68);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1156, 658);
            this.panel_body.TabIndex = 11;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(48, 101);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(140, 44);
            this.AddBtn.TabIndex = 12;
            this.AddBtn.Text = "ADD PATIENT";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 758);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.ReportBtn);
            this.Controls.Add(this.FinanceBtn);
            this.Controls.Add(this.TreatmentBtn);
            this.Controls.Add(this.AppoimentBtn);
            this.Controls.Add(this.ListBtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReportBtn;
        private System.Windows.Forms.Button FinanceBtn;
        private System.Windows.Forms.Button TreatmentBtn;
        private System.Windows.Forms.Button AppoimentBtn;
        private System.Windows.Forms.Button ListBtn;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Button AddBtn;
    }
}