namespace PictureOrganizator
{
    partial class frmOrganizator
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
            this.gbxOrganizator = new System.Windows.Forms.GroupBox();
            this.pbrPicOrg = new System.Windows.Forms.ProgressBar();
            this.btnDestDir = new System.Windows.Forms.Button();
            this.btnPicDir = new System.Windows.Forms.Button();
            this.lblDestDir = new System.Windows.Forms.Label();
            this.lblPicDir = new System.Windows.Forms.Label();
            this.txtDestDir = new System.Windows.Forms.TextBox();
            this.txtPicDir = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.gbxOrganizator.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxOrganizator
            // 
            this.gbxOrganizator.Controls.Add(this.pbrPicOrg);
            this.gbxOrganizator.Controls.Add(this.btnDestDir);
            this.gbxOrganizator.Controls.Add(this.btnPicDir);
            this.gbxOrganizator.Controls.Add(this.lblDestDir);
            this.gbxOrganizator.Controls.Add(this.lblPicDir);
            this.gbxOrganizator.Controls.Add(this.txtDestDir);
            this.gbxOrganizator.Controls.Add(this.txtPicDir);
            this.gbxOrganizator.Controls.Add(this.btnExecute);
            this.gbxOrganizator.Location = new System.Drawing.Point(13, 13);
            this.gbxOrganizator.Name = "gbxOrganizator";
            this.gbxOrganizator.Size = new System.Drawing.Size(259, 153);
            this.gbxOrganizator.TabIndex = 0;
            this.gbxOrganizator.TabStop = false;
            // 
            // pbrPicOrg
            // 
            this.pbrPicOrg.Location = new System.Drawing.Point(6, 121);
            this.pbrPicOrg.Name = "pbrPicOrg";
            this.pbrPicOrg.Size = new System.Drawing.Size(166, 23);
            this.pbrPicOrg.TabIndex = 1;
            // 
            // btnDestDir
            // 
            this.btnDestDir.Location = new System.Drawing.Point(229, 86);
            this.btnDestDir.Name = "btnDestDir";
            this.btnDestDir.Size = new System.Drawing.Size(24, 20);
            this.btnDestDir.TabIndex = 6;
            this.btnDestDir.Text = "...";
            this.btnDestDir.UseVisualStyleBackColor = true;
            this.btnDestDir.Click += new System.EventHandler(this.btnDestDir_Click);
            // 
            // btnPicDir
            // 
            this.btnPicDir.Location = new System.Drawing.Point(229, 41);
            this.btnPicDir.Name = "btnPicDir";
            this.btnPicDir.Size = new System.Drawing.Size(24, 20);
            this.btnPicDir.TabIndex = 5;
            this.btnPicDir.Text = "...";
            this.btnPicDir.UseVisualStyleBackColor = true;
            this.btnPicDir.Click += new System.EventHandler(this.btnPicDir_Click);
            // 
            // lblDestDir
            // 
            this.lblDestDir.AutoSize = true;
            this.lblDestDir.Location = new System.Drawing.Point(6, 70);
            this.lblDestDir.Name = "lblDestDir";
            this.lblDestDir.Size = new System.Drawing.Size(88, 13);
            this.lblDestDir.TabIndex = 4;
            this.lblDestDir.Text = "Diretório Destino:";
            // 
            // lblPicDir
            // 
            this.lblPicDir.AutoSize = true;
            this.lblPicDir.Location = new System.Drawing.Point(7, 20);
            this.lblPicDir.Name = "lblPicDir";
            this.lblPicDir.Size = new System.Drawing.Size(117, 13);
            this.lblPicDir.TabIndex = 3;
            this.lblPicDir.Text = "Diretórios das Imagens:";
            // 
            // txtDestDir
            // 
            this.txtDestDir.Location = new System.Drawing.Point(6, 86);
            this.txtDestDir.Name = "txtDestDir";
            this.txtDestDir.ReadOnly = true;
            this.txtDestDir.Size = new System.Drawing.Size(217, 20);
            this.txtDestDir.TabIndex = 2;
            // 
            // txtPicDir
            // 
            this.txtPicDir.Location = new System.Drawing.Point(6, 41);
            this.txtPicDir.Name = "txtPicDir";
            this.txtPicDir.ReadOnly = true;
            this.txtPicDir.Size = new System.Drawing.Size(217, 20);
            this.txtPicDir.TabIndex = 1;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(178, 121);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 0;
            this.btnExecute.Text = "Organize";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // frmOrganizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 177);
            this.Controls.Add(this.gbxOrganizator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmOrganizator";
            this.Text = "Picture Organizator";
            this.gbxOrganizator.ResumeLayout(false);
            this.gbxOrganizator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOrganizator;
        private System.Windows.Forms.Button btnDestDir;
        private System.Windows.Forms.Button btnPicDir;
        private System.Windows.Forms.Label lblDestDir;
        private System.Windows.Forms.Label lblPicDir;
        private System.Windows.Forms.TextBox txtDestDir;
        private System.Windows.Forms.TextBox txtPicDir;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.ProgressBar pbrPicOrg;
    }
}

