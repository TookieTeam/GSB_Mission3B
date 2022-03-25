
namespace Mission3_GSB
{
    partial class FrmAddFamily
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
            this.grBxLibelle = new System.Windows.Forms.GroupBox();
            this.txtNameF = new System.Windows.Forms.TextBox();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.grBxId = new System.Windows.Forms.GroupBox();
            this.txtAbrev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.grBxLibelle.SuspendLayout();
            this.grBxId.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBxLibelle
            // 
            this.grBxLibelle.Controls.Add(this.txtNameF);
            this.grBxLibelle.Controls.Add(this.lblLibelle);
            this.grBxLibelle.Location = new System.Drawing.Point(9, 10);
            this.grBxLibelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grBxLibelle.Name = "grBxLibelle";
            this.grBxLibelle.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grBxLibelle.Size = new System.Drawing.Size(296, 93);
            this.grBxLibelle.TabIndex = 0;
            this.grBxLibelle.TabStop = false;
            this.grBxLibelle.Text = "Libelle";
            // 
            // txtNameF
            // 
            this.txtNameF.Location = new System.Drawing.Point(106, 42);
            this.txtNameF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNameF.Name = "txtNameF";
            this.txtNameF.Size = new System.Drawing.Size(186, 20);
            this.txtNameF.TabIndex = 1;
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(16, 42);
            this.lblLibelle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(85, 13);
            this.lblLibelle.TabIndex = 0;
            this.lblLibelle.Text = "Nom de Famille :";
            // 
            // grBxId
            // 
            this.grBxId.Controls.Add(this.txtAbrev);
            this.grBxId.Controls.Add(this.label1);
            this.grBxId.Location = new System.Drawing.Point(9, 108);
            this.grBxId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grBxId.Name = "grBxId";
            this.grBxId.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grBxId.Size = new System.Drawing.Size(296, 93);
            this.grBxId.TabIndex = 2;
            this.grBxId.TabStop = false;
            this.grBxId.Text = "Id";
            // 
            // txtAbrev
            // 
            this.txtAbrev.Location = new System.Drawing.Point(106, 42);
            this.txtAbrev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAbrev.Name = "txtAbrev";
            this.txtAbrev.Size = new System.Drawing.Size(186, 20);
            this.txtAbrev.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abréviation :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(151, 232);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 39);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(230, 232);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 39);
            this.btnFermer.TabIndex = 4;
            this.btnFermer.Text = "Annuler";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FrmAddFamily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 281);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.grBxId);
            this.Controls.Add(this.grBxLibelle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAddFamily";
            this.Text = "FrmAddFamily";
            this.grBxLibelle.ResumeLayout(false);
            this.grBxLibelle.PerformLayout();
            this.grBxId.ResumeLayout(false);
            this.grBxId.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBxLibelle;
        private System.Windows.Forms.TextBox txtNameF;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.GroupBox grBxId;
        private System.Windows.Forms.TextBox txtAbrev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnFermer;
    }
}