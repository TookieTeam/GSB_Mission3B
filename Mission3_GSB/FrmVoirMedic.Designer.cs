
namespace Mission3_GSB
{
    partial class FrmVoirMedic
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
            this.btnFermer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bdgSourceOffrir = new System.Windows.Forms.BindingSource(this.components);
            this.bdgSourceVMedic = new System.Windows.Forms.BindingSource(this.components);
            this.cmBxFam = new System.Windows.Forms.ComboBox();
            this.bdgSourceFamille = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddFam = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.idMedicamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRapportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rapportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceOffrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceVMedic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceFamille)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFermer.Location = new System.Drawing.Point(550, 471);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(95, 44);
            this.btnFermer.TabIndex = 1;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMedicamentDataGridViewTextBoxColumn,
            this.quantiteDataGridViewTextBoxColumn,
            this.idRapportDataGridViewTextBoxColumn,
            this.medicamentDataGridViewTextBoxColumn,
            this.rapportDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bdgSourceOffrir;
            this.dataGridView1.Location = new System.Drawing.Point(0, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 357);
            this.dataGridView1.TabIndex = 2;
            // 
            // bdgSourceOffrir
            // 
            this.bdgSourceOffrir.DataSource = typeof(Mission3_GSB.offrir);
            // 
            // bdgSourceVMedic
            // 
            this.bdgSourceVMedic.DataSource = typeof(Mission3_GSB.medicament);
            // 
            // cmBxFam
            // 
            this.cmBxFam.DataSource = this.bdgSourceFamille;
            this.cmBxFam.DisplayMember = "id";
            this.cmBxFam.FormattingEnabled = true;
            this.cmBxFam.Location = new System.Drawing.Point(74, 44);
            this.cmBxFam.Name = "cmBxFam";
            this.cmBxFam.Size = new System.Drawing.Size(121, 21);
            this.cmBxFam.TabIndex = 4;
            // 
            // bdgSourceFamille
            // 
            this.bdgSourceFamille.DataSource = typeof(Mission3_GSB.famille);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Famille";
            // 
            // btnAddFam
            // 
            this.btnAddFam.Location = new System.Drawing.Point(210, 43);
            this.btnAddFam.Name = "btnAddFam";
            this.btnAddFam.Size = new System.Drawing.Size(75, 23);
            this.btnAddFam.TabIndex = 6;
            this.btnAddFam.Text = "Ajouter";
            this.btnAddFam.UseVisualStyleBackColor = true;
            this.btnAddFam.Click += new System.EventHandler(this.btnAddFam_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddFam);
            this.groupBox1.Controls.Add(this.cmBxFam);
            this.groupBox1.Location = new System.Drawing.Point(0, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Famille";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(0, 474);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 43);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(91, 474);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(85, 43);
            this.btnModif.TabIndex = 9;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(182, 474);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 43);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // idMedicamentDataGridViewTextBoxColumn
            // 
            this.idMedicamentDataGridViewTextBoxColumn.DataPropertyName = "idMedicament";
            this.idMedicamentDataGridViewTextBoxColumn.HeaderText = "idMedicament";
            this.idMedicamentDataGridViewTextBoxColumn.Name = "idMedicamentDataGridViewTextBoxColumn";
            // 
            // quantiteDataGridViewTextBoxColumn
            // 
            this.quantiteDataGridViewTextBoxColumn.DataPropertyName = "quantite";
            this.quantiteDataGridViewTextBoxColumn.HeaderText = "quantite";
            this.quantiteDataGridViewTextBoxColumn.Name = "quantiteDataGridViewTextBoxColumn";
            // 
            // idRapportDataGridViewTextBoxColumn
            // 
            this.idRapportDataGridViewTextBoxColumn.DataPropertyName = "idRapport";
            this.idRapportDataGridViewTextBoxColumn.HeaderText = "idRapport";
            this.idRapportDataGridViewTextBoxColumn.Name = "idRapportDataGridViewTextBoxColumn";
            this.idRapportDataGridViewTextBoxColumn.Visible = false;
            // 
            // medicamentDataGridViewTextBoxColumn
            // 
            this.medicamentDataGridViewTextBoxColumn.DataPropertyName = "medicament";
            this.medicamentDataGridViewTextBoxColumn.HeaderText = "medicament";
            this.medicamentDataGridViewTextBoxColumn.Name = "medicamentDataGridViewTextBoxColumn";
            this.medicamentDataGridViewTextBoxColumn.Visible = false;
            // 
            // rapportDataGridViewTextBoxColumn
            // 
            this.rapportDataGridViewTextBoxColumn.DataPropertyName = "rapport";
            this.rapportDataGridViewTextBoxColumn.HeaderText = "rapport";
            this.rapportDataGridViewTextBoxColumn.Name = "rapportDataGridViewTextBoxColumn";
            this.rapportDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmVoirMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 539);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFermer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmVoirMedic";
            this.Text = "FrmVoirMedic";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceOffrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceVMedic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceFamille)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.BindingSource bdgSourceVMedic;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmBxFam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdgSourceOffrir;
        private System.Windows.Forms.BindingSource bdgSourceFamille;
        private System.Windows.Forms.Button btnAddFam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRapportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rapportDataGridViewTextBoxColumn;
    }
}