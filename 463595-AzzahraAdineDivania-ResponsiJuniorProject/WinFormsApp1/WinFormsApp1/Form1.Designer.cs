namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblDep = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvKaryawan = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKaryawan)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(23, 20);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(61, 56);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(98, 39);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(31, 15);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "logo";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(27, 128);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(102, 15);
            this.lblNama.TabIndex = 2;
            this.lblNama.Text = "Nama Karyawan : ";
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Location = new System.Drawing.Point(27, 171);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(91, 15);
            this.lblDep.TabIndex = 3;
            this.lblDep.Text = "Dep Karyawan : ";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(170, 125);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(189, 23);
            this.tbNama.TabIndex = 4;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(171, 172);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(41, 19);
            this.rb1.TabIndex = 5;
            this.rb1.TabStop = true;
            this.rb1.Text = "HR";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(234, 171);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(48, 19);
            this.rb2.TabIndex = 6;
            this.rb2.TabStop = true;
            this.rb2.Text = "ENG";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(300, 169);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(46, 19);
            this.rb3.TabIndex = 7;
            this.rb3.TabStop = true;
            this.rb3.Text = "DEV";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(365, 169);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(43, 19);
            this.rb4.TabIndex = 8;
            this.rb4.TabStop = true;
            this.rb4.Text = "PM";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(439, 167);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(43, 19);
            this.rb5.TabIndex = 9;
            this.rb5.TabStop = true;
            this.rb5.Text = "FIN";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(30, 209);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(99, 23);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(171, 209);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(321, 209);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvKaryawan
            // 
            this.dgvKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKaryawan.Location = new System.Drawing.Point(30, 250);
            this.dgvKaryawan.Name = "dgvKaryawan";
            this.dgvKaryawan.RowTemplate.Height = 25;
            this.dgvKaryawan.Size = new System.Drawing.Size(452, 150);
            this.dgvKaryawan.TabIndex = 13;
            this.dgvKaryawan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKaryawan_CellContentClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(383, 415);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(99, 23);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvKaryawan);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.rb5);
            this.Controls.Add(this.rb4);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.pbLogo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKaryawan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbLogo;
        private Label lblLogo;
        private Label lblNama;
        private Label lblDep;
        private TextBox tbNama;
        private RadioButton rb1;
        private RadioButton rb2;
        private RadioButton rb3;
        private RadioButton rb4;
        private RadioButton rb5;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvKaryawan;
        private Button btnLoad;
    }
}