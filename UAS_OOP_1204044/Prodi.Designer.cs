namespace UAS_OOP_1204044
{
    partial class Prodi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prodi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtKodePrd = new System.Windows.Forms.TextBox();
            this.txtNamaProdi = new System.Windows.Forms.TextBox();
            this.txtSingkatan = new System.Windows.Forms.TextBox();
            this.txtBiayaKuliah = new System.Windows.Forms.TextBox();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Program Studi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Prodi      :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Prodi     :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Singkatan       :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Biaya Kuliah    :";
            // 
            // btnSubmi
            // 
            this.btnSubmi.Location = new System.Drawing.Point(68, 294);
            this.btnSubmi.Name = "btnSubmi";
            this.btnSubmi.Size = new System.Drawing.Size(75, 23);
            this.btnSubmi.TabIndex = 5;
            this.btnSubmi.Text = "Submit";
            this.btnSubmi.UseVisualStyleBackColor = true;
            this.btnSubmi.Click += new System.EventHandler(this.btnSubmi_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtKodePrd
            // 
            this.txtKodePrd.Location = new System.Drawing.Point(176, 105);
            this.txtKodePrd.Name = "txtKodePrd";
            this.txtKodePrd.Size = new System.Drawing.Size(171, 20);
            this.txtKodePrd.TabIndex = 7;
            this.txtKodePrd.TextChanged += new System.EventHandler(this.tbKodePrd_TextChanged);
            this.txtKodePrd.Leave += new System.EventHandler(this.txtKodePrd_Leave);
            // 
            // txtNamaProdi
            // 
            this.txtNamaProdi.Location = new System.Drawing.Point(176, 145);
            this.txtNamaProdi.Name = "txtNamaProdi";
            this.txtNamaProdi.Size = new System.Drawing.Size(171, 20);
            this.txtNamaProdi.TabIndex = 8;
            this.txtNamaProdi.Leave += new System.EventHandler(this.txtNamaProdi_Leave);
            // 
            // txtSingkatan
            // 
            this.txtSingkatan.Location = new System.Drawing.Point(176, 182);
            this.txtSingkatan.Name = "txtSingkatan";
            this.txtSingkatan.Size = new System.Drawing.Size(171, 20);
            this.txtSingkatan.TabIndex = 9;
            this.txtSingkatan.Leave += new System.EventHandler(this.txtSingkatan_Leave);
            // 
            // txtBiayaKuliah
            // 
            this.txtBiayaKuliah.Location = new System.Drawing.Point(176, 222);
            this.txtBiayaKuliah.Name = "txtBiayaKuliah";
            this.txtBiayaKuliah.Size = new System.Drawing.Size(171, 20);
            this.txtBiayaKuliah.TabIndex = 10;
            this.txtBiayaKuliah.Leave += new System.EventHandler(this.txtBiayaKuliah_Leave);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // Prodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 363);
            this.Controls.Add(this.txtBiayaKuliah);
            this.Controls.Add(this.txtSingkatan);
            this.Controls.Add(this.txtNamaProdi);
            this.Controls.Add(this.txtKodePrd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSubmi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Prodi";
            this.Text = "Prodi";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtKodePrd;
        private System.Windows.Forms.TextBox txtNamaProdi;
        private System.Windows.Forms.TextBox txtSingkatan;
        private System.Windows.Forms.TextBox txtBiayaKuliah;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}