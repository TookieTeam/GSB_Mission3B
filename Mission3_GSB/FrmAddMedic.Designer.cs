
namespace Mission3_GSB
{
    partial class FrmAddMedic
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
            this.grbxAjouter = new System.Windows.Forms.GroupBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.grBxNom = new System.Windows.Forms.GroupBox();
            this.txtNameAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grBxFamille = new System.Windows.Forms.GroupBox();
            this.cmbFamille = new System.Windows.Forms.ComboBox();
            this.bdgFamille = new System.Windows.Forms.BindingSource(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblFamille = new System.Windows.Forms.Label();
            this.grBxContradiction = new System.Windows.Forms.GroupBox();
            this.txtContradiction = new System.Windows.Forms.TextBox();
            this.lblContradiction = new System.Windows.Forms.Label();
            this.grpBxCompo = new System.Windows.Forms.GroupBox();
            this.txtCompo = new System.Windows.Forms.TextBox();
            this.lblCompo = new System.Windows.Forms.Label();
            this.grBxEffets = new System.Windows.Forms.GroupBox();
            this.txtEffets = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bdgSourceADDM = new System.Windows.Forms.BindingSource(this.components);
            this.grbxAjouter.SuspendLayout();
            this.grBxNom.SuspendLayout();
            this.grBxFamille.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgFamille)).BeginInit();
            this.grBxContradiction.SuspendLayout();
            this.grpBxCompo.SuspendLayout();
            this.grBxEffets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceADDM)).BeginInit();
            this.SuspendLayout();
            // 
            // grbxAjouter
            // 
            this.grbxAjouter.Controls.Add(this.btnFermer);
            this.grbxAjouter.Controls.Add(this.btnAjouter);
            this.grbxAjouter.Controls.Add(this.grBxNom);
            this.grbxAjouter.Controls.Add(this.grBxFamille);
            this.grbxAjouter.Controls.Add(this.grBxContradiction);
            this.grbxAjouter.Controls.Add(this.grpBxCompo);
            this.grbxAjouter.Controls.Add(this.grBxEffets);
            this.grbxAjouter.Location = new System.Drawing.Point(9, 10);
            this.grbxAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.grbxAjouter.Name = "grbxAjouter";
            this.grbxAjouter.Padding = new System.Windows.Forms.Padding(2);
            this.grbxAjouter.Size = new System.Drawing.Size(333, 646);
            this.grbxAjouter.TabIndex = 10;
            this.grbxAjouter.TabStop = false;
            this.grbxAjouter.Text = "Ajouter";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(210, 504);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(97, 41);
            this.btnFermer.TabIndex = 10;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(111, 504);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(90, 41);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // grBxNom
            // 
            this.grBxNom.Controls.Add(this.txtNameAdd);
            this.grBxNom.Controls.Add(this.label1);
            this.grBxNom.Location = new System.Drawing.Point(27, 24);
            this.grBxNom.Margin = new System.Windows.Forms.Padding(2);
            this.grBxNom.Name = "grBxNom";
            this.grBxNom.Padding = new System.Windows.Forms.Padding(2);
            this.grBxNom.Size = new System.Drawing.Size(295, 81);
            this.grBxNom.TabIndex = 3;
            this.grBxNom.TabStop = false;
            this.grBxNom.Text = "Nom";
            // 
            // txtNameAdd
            // 
            this.txtNameAdd.Location = new System.Drawing.Point(133, 33);
            this.txtNameAdd.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameAdd.Name = "txtNameAdd";
            this.txtNameAdd.Size = new System.Drawing.Size(140, 20);
            this.txtNameAdd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du médicament :";
            // 
            // grBxFamille
            // 
            this.grBxFamille.Controls.Add(this.cmbFamille);
            this.grBxFamille.Controls.Add(this.linkLabel1);
            this.grBxFamille.Controls.Add(this.lblFamille);
            this.grBxFamille.Location = new System.Drawing.Point(27, 121);
            this.grBxFamille.Margin = new System.Windows.Forms.Padding(2);
            this.grBxFamille.Name = "grBxFamille";
            this.grBxFamille.Padding = new System.Windows.Forms.Padding(2);
            this.grBxFamille.Size = new System.Drawing.Size(295, 95);
            this.grBxFamille.TabIndex = 4;
            this.grBxFamille.TabStop = false;
            this.grBxFamille.Text = "Famille";
            // 
            // cmbFamille
            // 
            this.cmbFamille.DataSource = this.bdgFamille;
            this.cmbFamille.DisplayMember = "id";
            this.cmbFamille.FormattingEnabled = true;
            this.cmbFamille.Location = new System.Drawing.Point(121, 30);
            this.cmbFamille.Name = "cmbFamille";
            this.cmbFamille.Size = new System.Drawing.Size(157, 21);
            this.cmbFamille.TabIndex = 3;
            // 
            // bdgFamille
            // 
            this.bdgFamille.DataSource = typeof(Mission3_GSB.famille);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(20, 47);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 41);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Vous trouvez pas ? crée une Famille";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblFamille
            // 
            this.lblFamille.AutoSize = true;
            this.lblFamille.Location = new System.Drawing.Point(20, 33);
            this.lblFamille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFamille.Name = "lblFamille";
            this.lblFamille.Size = new System.Drawing.Size(93, 13);
            this.lblFamille.TabIndex = 0;
            this.lblFamille.Text = "Nom de la Famille:";
            // 
            // grBxContradiction
            // 
            this.grBxContradiction.Controls.Add(this.txtContradiction);
            this.grBxContradiction.Controls.Add(this.lblContradiction);
            this.grBxContradiction.Location = new System.Drawing.Point(27, 419);
            this.grBxContradiction.Margin = new System.Windows.Forms.Padding(2);
            this.grBxContradiction.Name = "grBxContradiction";
            this.grBxContradiction.Padding = new System.Windows.Forms.Padding(2);
            this.grBxContradiction.Size = new System.Drawing.Size(295, 81);
            this.grBxContradiction.TabIndex = 7;
            this.grBxContradiction.TabStop = false;
            this.grBxContradiction.Text = "Contradiction";
            // 
            // txtContradiction
            // 
            this.txtContradiction.Location = new System.Drawing.Point(94, 33);
            this.txtContradiction.Margin = new System.Windows.Forms.Padding(2);
            this.txtContradiction.Name = "txtContradiction";
            this.txtContradiction.Size = new System.Drawing.Size(180, 20);
            this.txtContradiction.TabIndex = 1;
            // 
            // lblContradiction
            // 
            this.lblContradiction.AutoSize = true;
            this.lblContradiction.Location = new System.Drawing.Point(20, 33);
            this.lblContradiction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContradiction.Name = "lblContradiction";
            this.lblContradiction.Size = new System.Drawing.Size(75, 13);
            this.lblContradiction.TabIndex = 0;
            this.lblContradiction.Text = "Contradiction :";
            // 
            // grpBxCompo
            // 
            this.grpBxCompo.Controls.Add(this.txtCompo);
            this.grpBxCompo.Controls.Add(this.lblCompo);
            this.grpBxCompo.Location = new System.Drawing.Point(27, 220);
            this.grpBxCompo.Margin = new System.Windows.Forms.Padding(2);
            this.grpBxCompo.Name = "grpBxCompo";
            this.grpBxCompo.Padding = new System.Windows.Forms.Padding(2);
            this.grpBxCompo.Size = new System.Drawing.Size(295, 81);
            this.grpBxCompo.TabIndex = 5;
            this.grpBxCompo.TabStop = false;
            this.grpBxCompo.Text = "Composition";
            // 
            // txtCompo
            // 
            this.txtCompo.Location = new System.Drawing.Point(94, 33);
            this.txtCompo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompo.Name = "txtCompo";
            this.txtCompo.Size = new System.Drawing.Size(180, 20);
            this.txtCompo.TabIndex = 1;
            // 
            // lblCompo
            // 
            this.lblCompo.AutoSize = true;
            this.lblCompo.Location = new System.Drawing.Point(20, 33);
            this.lblCompo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompo.Name = "lblCompo";
            this.lblCompo.Size = new System.Drawing.Size(70, 13);
            this.lblCompo.TabIndex = 0;
            this.lblCompo.Text = "Composition :";
            // 
            // grBxEffets
            // 
            this.grBxEffets.Controls.Add(this.txtEffets);
            this.grBxEffets.Controls.Add(this.label4);
            this.grBxEffets.Location = new System.Drawing.Point(27, 323);
            this.grBxEffets.Margin = new System.Windows.Forms.Padding(2);
            this.grBxEffets.Name = "grBxEffets";
            this.grBxEffets.Padding = new System.Windows.Forms.Padding(2);
            this.grBxEffets.Size = new System.Drawing.Size(295, 81);
            this.grBxEffets.TabIndex = 6;
            this.grBxEffets.TabStop = false;
            this.grBxEffets.Text = "Effets";
            // 
            // txtEffets
            // 
            this.txtEffets.Location = new System.Drawing.Point(63, 33);
            this.txtEffets.Margin = new System.Windows.Forms.Padding(2);
            this.txtEffets.Name = "txtEffets";
            this.txtEffets.Size = new System.Drawing.Size(210, 20);
            this.txtEffets.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Effets :";
            // 
            // bdgSourceADDM
            // 
            this.bdgSourceADDM.DataSource = typeof(Mission3_GSB.medicament);
            // 
            // FrmAddMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 562);
            this.Controls.Add(this.grbxAjouter);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAddMedic";
            this.Text = "Ajouter";
            this.grbxAjouter.ResumeLayout(false);
            this.grBxNom.ResumeLayout(false);
            this.grBxNom.PerformLayout();
            this.grBxFamille.ResumeLayout(false);
            this.grBxFamille.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgFamille)).EndInit();
            this.grBxContradiction.ResumeLayout(false);
            this.grBxContradiction.PerformLayout();
            this.grpBxCompo.ResumeLayout(false);
            this.grpBxCompo.PerformLayout();
            this.grBxEffets.ResumeLayout(false);
            this.grBxEffets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceADDM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbxAjouter;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.GroupBox grBxNom;
        private System.Windows.Forms.TextBox txtNameAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grBxFamille;
        private System.Windows.Forms.Label lblFamille;
        private System.Windows.Forms.GroupBox grBxContradiction;
        private System.Windows.Forms.TextBox txtContradiction;
        private System.Windows.Forms.Label lblContradiction;
        private System.Windows.Forms.GroupBox grpBxCompo;
        private System.Windows.Forms.TextBox txtCompo;
        private System.Windows.Forms.Label lblCompo;
        private System.Windows.Forms.GroupBox grBxEffets;
        private System.Windows.Forms.TextBox txtEffets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.BindingSource bdgFamille;
        private System.Windows.Forms.BindingSource bdgSourceADDM;
        private System.Windows.Forms.ComboBox cmbFamille;
    }
}