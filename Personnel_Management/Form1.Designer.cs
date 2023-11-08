namespace Personel_Kayit
{
    partial class Form1
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
            this.Per_info = new System.Windows.Forms.GroupBox();
            this.City_Combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Job_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Surname_txt = new System.Windows.Forms.TextBox();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.Single = new System.Windows.Forms.RadioButton();
            this.Married = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.Wage_txt = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Id_txt = new System.Windows.Forms.MaskedTextBox();
            this.Id = new System.Windows.Forms.Label();
            this.Per_prcss = new System.Windows.Forms.GroupBox();
            this.Graph_Button = new System.Windows.Forms.Button();
            this.St_Button = new System.Windows.Forms.Button();
            this.List_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Upgrade_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personel_veri_tabaniDataSet = new Personel_Kayit.Personel_veri_tabaniDataSet();
            this.tbl_PersonelTableAdapter = new Personel_Kayit.Personel_veri_tabaniDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.Per_info.SuspendLayout();
            this.Per_prcss.SuspendLayout();
            this.List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_veri_tabaniDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Per_info
            // 
            this.Per_info.BackColor = System.Drawing.Color.Brown;
            this.Per_info.Controls.Add(this.City_Combo);
            this.Per_info.Controls.Add(this.label1);
            this.Per_info.Controls.Add(this.Job_txt);
            this.Per_info.Controls.Add(this.label5);
            this.Per_info.Controls.Add(this.Surname_txt);
            this.Per_info.Controls.Add(this.Name_txt);
            this.Per_info.Controls.Add(this.Single);
            this.Per_info.Controls.Add(this.Married);
            this.Per_info.Controls.Add(this.label6);
            this.Per_info.Controls.Add(this.Wage_txt);
            this.Per_info.Controls.Add(this.label4);
            this.Per_info.Controls.Add(this.label3);
            this.Per_info.Controls.Add(this.Label_Name);
            this.Per_info.Controls.Add(this.Id_txt);
            this.Per_info.Controls.Add(this.Id);
            this.Per_info.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Per_info.Location = new System.Drawing.Point(12, 12);
            this.Per_info.Name = "Per_info";
            this.Per_info.Size = new System.Drawing.Size(480, 362);
            this.Per_info.TabIndex = 0;
            this.Per_info.TabStop = false;
            this.Per_info.Text = "Per Info";
            // 
            // City_Combo
            // 
            this.City_Combo.FormattingEnabled = true;
            this.City_Combo.Items.AddRange(new object[] {
            "Adıyaman",
            "Denizli",
            "Urfa"});
            this.City_Combo.Location = new System.Drawing.Point(185, 243);
            this.City_Combo.Name = "City_Combo";
            this.City_Combo.Size = new System.Drawing.Size(155, 32);
            this.City_Combo.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(136, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Job:";
            // 
            // Job_txt
            // 
            this.Job_txt.Location = new System.Drawing.Point(185, 281);
            this.Job_txt.Name = "Job_txt";
            this.Job_txt.Size = new System.Drawing.Size(155, 32);
            this.Job_txt.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(48, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Marital Status:";
            // 
            // Surname_txt
            // 
            this.Surname_txt.Location = new System.Drawing.Point(185, 125);
            this.Surname_txt.Name = "Surname_txt";
            this.Surname_txt.Size = new System.Drawing.Size(155, 32);
            this.Surname_txt.TabIndex = 3;
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(185, 87);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(155, 32);
            this.Name_txt.TabIndex = 2;
            // 
            // Single
            // 
            this.Single.AutoSize = true;
            this.Single.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Single.Location = new System.Drawing.Point(274, 201);
            this.Single.Name = "Single";
            this.Single.Size = new System.Drawing.Size(80, 28);
            this.Single.TabIndex = 6;
            this.Single.TabStop = true;
            this.Single.Text = "Single";
            this.Single.UseVisualStyleBackColor = true;
            // 
            // Married
            // 
            this.Married.AutoSize = true;
            this.Married.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Married.Location = new System.Drawing.Point(185, 201);
            this.Married.Name = "Married";
            this.Married.Size = new System.Drawing.Size(91, 28);
            this.Married.TabIndex = 5;
            this.Married.TabStop = true;
            this.Married.Text = "Maried";
            this.Married.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(132, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "City:";
            // 
            // Wage_txt
            // 
            this.Wage_txt.Location = new System.Drawing.Point(185, 163);
            this.Wage_txt.Mask = "0000";
            this.Wage_txt.Name = "Wage_txt";
            this.Wage_txt.Size = new System.Drawing.Size(155, 32);
            this.Wage_txt.TabIndex = 4;
            this.Wage_txt.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(120, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Wage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(91, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname:";
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label_Name.Location = new System.Drawing.Point(116, 90);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(64, 24);
            this.Label_Name.TabIndex = 2;
            this.Label_Name.Text = "Name:";
            // 
            // Id_txt
            // 
            this.Id_txt.Location = new System.Drawing.Point(185, 49);
            this.Id_txt.Mask = "00000";
            this.Id_txt.Name = "Id_txt";
            this.Id_txt.Size = new System.Drawing.Size(155, 32);
            this.Id_txt.TabIndex = 1;
            this.Id_txt.ValidatingType = typeof(int);
            this.Id_txt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Id_txt_MaskInputRejected);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Id.Location = new System.Drawing.Point(149, 57);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(31, 24);
            this.Id.TabIndex = 0;
            this.Id.Text = "Id:";
            // 
            // Per_prcss
            // 
            this.Per_prcss.BackColor = System.Drawing.Color.Brown;
            this.Per_prcss.Controls.Add(this.Graph_Button);
            this.Per_prcss.Controls.Add(this.St_Button);
            this.Per_prcss.Controls.Add(this.List_Button);
            this.Per_prcss.Controls.Add(this.Clear_Button);
            this.Per_prcss.Controls.Add(this.Upgrade_Button);
            this.Per_prcss.Controls.Add(this.Delete_Button);
            this.Per_prcss.Controls.Add(this.Save_Button);
            this.Per_prcss.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Per_prcss.Location = new System.Drawing.Point(498, 12);
            this.Per_prcss.Name = "Per_prcss";
            this.Per_prcss.Size = new System.Drawing.Size(466, 362);
            this.Per_prcss.TabIndex = 1;
            this.Per_prcss.TabStop = false;
            this.Per_prcss.Text = "Per Process";
            // 
            // Graph_Button
            // 
            this.Graph_Button.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Graph_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Graph_Button.Location = new System.Drawing.Point(159, 295);
            this.Graph_Button.Name = "Graph_Button";
            this.Graph_Button.Size = new System.Drawing.Size(175, 38);
            this.Graph_Button.TabIndex = 6;
            this.Graph_Button.Text = "Graphics";
            this.Graph_Button.UseVisualStyleBackColor = true;
            // 
            // St_Button
            // 
            this.St_Button.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.St_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.St_Button.Location = new System.Drawing.Point(159, 251);
            this.St_Button.Name = "St_Button";
            this.St_Button.Size = new System.Drawing.Size(175, 38);
            this.St_Button.TabIndex = 5;
            this.St_Button.Text = "Statistics";
            this.St_Button.UseVisualStyleBackColor = true;
            this.St_Button.Click += new System.EventHandler(this.St_Button_Click);
            // 
            // List_Button
            // 
            this.List_Button.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.List_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.List_Button.Location = new System.Drawing.Point(159, 207);
            this.List_Button.Name = "List_Button";
            this.List_Button.Size = new System.Drawing.Size(175, 38);
            this.List_Button.TabIndex = 4;
            this.List_Button.Text = "List";
            this.List_Button.UseVisualStyleBackColor = true;
            this.List_Button.Click += new System.EventHandler(this.List_Button_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Clear_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Clear_Button.Location = new System.Drawing.Point(159, 163);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(175, 38);
            this.Clear_Button.TabIndex = 3;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Upgrade_Button
            // 
            this.Upgrade_Button.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Upgrade_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Upgrade_Button.Location = new System.Drawing.Point(159, 119);
            this.Upgrade_Button.Name = "Upgrade_Button";
            this.Upgrade_Button.Size = new System.Drawing.Size(175, 38);
            this.Upgrade_Button.TabIndex = 2;
            this.Upgrade_Button.Text = "Upgrade";
            this.Upgrade_Button.UseVisualStyleBackColor = true;
            this.Upgrade_Button.Click += new System.EventHandler(this.Upgrade_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Delete_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Delete_Button.Location = new System.Drawing.Point(159, 75);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(175, 38);
            this.Delete_Button.TabIndex = 1;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Save_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Save_Button.Location = new System.Drawing.Point(159, 31);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(175, 38);
            this.Save_Button.TabIndex = 0;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // List
            // 
            this.List.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.List.Controls.Add(this.dataGridView1);
            this.List.Location = new System.Drawing.Point(12, 380);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(952, 233);
            this.List.TabIndex = 2;
            this.List.TabStop = false;
            this.List.Text = "Per List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(946, 202);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            this.perAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            this.perSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            this.perMaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            this.perDurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            this.perMeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personel_veri_tabaniDataSet;
            // 
            // personel_veri_tabaniDataSet
            // 
            this.personel_veri_tabaniDataSet.DataSetName = "Personel_veri_tabaniDataSet";
            this.personel_veri_tabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(973, 625);
            this.Controls.Add(this.List);
            this.Controls.Add(this.Per_prcss);
            this.Controls.Add(this.Per_info);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Per_info.ResumeLayout(false);
            this.Per_info.PerformLayout();
            this.Per_prcss.ResumeLayout(false);
            this.List.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_veri_tabaniDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Per_info;
        private System.Windows.Forms.GroupBox Per_prcss;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox Wage_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.MaskedTextBox Id_txt;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Surname_txt;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.RadioButton Single;
        private System.Windows.Forms.RadioButton Married;
        private System.Windows.Forms.Button List_Button;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button Upgrade_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Job_txt;
        private System.Windows.Forms.GroupBox List;
        private Personel_veri_tabaniDataSet personel_veri_tabaniDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private Personel_veri_tabaniDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.ComboBox City_Combo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Graph_Button;
        private System.Windows.Forms.Button St_Button;
    }
}

