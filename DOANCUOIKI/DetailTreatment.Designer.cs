namespace DOANCUOIKI
{
    partial class DetailTreatment
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelSTT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.labelPatient = new System.Windows.Forms.Label();
            this.labelDieutri = new System.Windows.Forms.Label();
            this.labelAdvice = new System.Windows.Forms.Label();
            this.labelMedicine = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // labelSTT
            // 
            this.labelSTT.AutoSize = true;
            this.labelSTT.Location = new System.Drawing.Point(48, 24);
            this.labelSTT.Name = "labelSTT";
            this.labelSTT.Size = new System.Drawing.Size(80, 16);
            this.labelSTT.TabIndex = 1;
            this.labelSTT.Text = "Lan dieu tri : ";
            this.labelSTT.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 2;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(718, 24);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(46, 16);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Ngay: ";
            this.labelDate.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelDoctor
            // 
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Location = new System.Drawing.Point(49, 90);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(87, 16);
            this.labelDoctor.TabIndex = 4;
            this.labelDoctor.Text = "Name Doctor";
            // 
            // labelPatient
            // 
            this.labelPatient.AutoSize = true;
            this.labelPatient.Location = new System.Drawing.Point(48, 154);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(88, 16);
            this.labelPatient.TabIndex = 5;
            this.labelPatient.Text = "Name Patient";
            // 
            // labelDieutri
            // 
            this.labelDieutri.AutoSize = true;
            this.labelDieutri.Location = new System.Drawing.Point(49, 218);
            this.labelDieutri.Name = "labelDieutri";
            this.labelDieutri.Size = new System.Drawing.Size(92, 16);
            this.labelDieutri.TabIndex = 6;
            this.labelDieutri.Text = "Van de dieu tri";
            // 
            // labelAdvice
            // 
            this.labelAdvice.AutoSize = true;
            this.labelAdvice.Location = new System.Drawing.Point(774, 81);
            this.labelAdvice.Name = "labelAdvice";
            this.labelAdvice.Size = new System.Drawing.Size(136, 16);
            this.labelAdvice.TabIndex = 7;
            this.labelAdvice.Text = "Loi Khuyen cua bac si";
            // 
            // labelMedicine
            // 
            this.labelMedicine.AutoSize = true;
            this.labelMedicine.Location = new System.Drawing.Point(49, 300);
            this.labelMedicine.Name = "labelMedicine";
            this.labelMedicine.Size = new System.Drawing.Size(67, 16);
            this.labelMedicine.TabIndex = 8;
            this.labelMedicine.Text = "Don thuoc";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(793, 446);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(75, 16);
            this.labelCost.TabIndex = 9;
            this.labelCost.Text = "Thanh Tien";
            // 
            // DetailTreatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 561);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelMedicine);
            this.Controls.Add(this.labelAdvice);
            this.Controls.Add(this.labelDieutri);
            this.Controls.Add(this.labelPatient);
            this.Controls.Add(this.labelDoctor);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSTT);
            this.Controls.Add(this.label1);
            this.Name = "DetailTreatment";
            this.Text = "DetailTreatMent";
            this.Load += new System.EventHandler(this.Treatment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label labelAdvice;
        public System.Windows.Forms.Label labelMedicine;
        public System.Windows.Forms.Label labelSTT;
        public System.Windows.Forms.Label labelDate;
        public System.Windows.Forms.Label labelDoctor;
        public System.Windows.Forms.Label labelPatient;
        public System.Windows.Forms.Label labelDieutri;
        public System.Windows.Forms.Label labelCost;
    }
}