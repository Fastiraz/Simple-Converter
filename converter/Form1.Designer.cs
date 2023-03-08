namespace converter
{
    partial class converter
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(converter));
            this.panldrop = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblfrom = new System.Windows.Forms.Label();
            this.lblto = new System.Windows.Forms.Label();
            this.tbxfrom = new System.Windows.Forms.TextBox();
            this.tbxto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panldrop
            // 
            this.panldrop.AllowDrop = true;
            this.panldrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.panldrop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panldrop.BackgroundImage")));
            this.panldrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panldrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panldrop.Location = new System.Drawing.Point(0, 0);
            this.panldrop.Name = "panldrop";
            this.panldrop.Size = new System.Drawing.Size(624, 310);
            this.panldrop.TabIndex = 0;
            this.panldrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.Drag_Drop);
            this.panldrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.Drag_Enter);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // lblfrom
            // 
            this.lblfrom.AutoSize = true;
            this.lblfrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.lblfrom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(68)))), ((int)(((byte)(55)))));
            this.lblfrom.Location = new System.Drawing.Point(12, 9);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(44, 17);
            this.lblfrom.TabIndex = 1;
            this.lblfrom.Text = "From:";
            // 
            // lblto
            // 
            this.lblto.AutoSize = true;
            this.lblto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.lblto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(68)))), ((int)(((byte)(55)))));
            this.lblto.Location = new System.Drawing.Point(29, 39);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(27, 17);
            this.lblto.TabIndex = 2;
            this.lblto.Text = "To:";
            // 
            // tbxfrom
            // 
            this.tbxfrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.tbxfrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxfrom.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxfrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(68)))), ((int)(((byte)(55)))));
            this.tbxfrom.Location = new System.Drawing.Point(62, 6);
            this.tbxfrom.Name = "tbxfrom";
            this.tbxfrom.Size = new System.Drawing.Size(100, 22);
            this.tbxfrom.TabIndex = 3;
            this.tbxfrom.Text = ".docx";
            this.tbxfrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxto
            // 
            this.tbxto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.tbxto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxto.Enabled = false;
            this.tbxto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(68)))), ((int)(((byte)(55)))));
            this.tbxto.Location = new System.Drawing.Point(62, 39);
            this.tbxto.Name = "tbxto";
            this.tbxto.Size = new System.Drawing.Size(100, 22);
            this.tbxto.TabIndex = 4;
            this.tbxto.Text = ".pdf";
            this.tbxto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(624, 310);
            this.Controls.Add(this.tbxto);
            this.Controls.Add(this.tbxfrom);
            this.Controls.Add(this.lblto);
            this.Controls.Add(this.lblfrom);
            this.Controls.Add(this.panldrop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "converter";
            this.Text = "Fastiraz";
            this.Load += new System.EventHandler(this.converter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panldrop;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblfrom;
        private System.Windows.Forms.Label lblto;
        private System.Windows.Forms.TextBox tbxfrom;
        private System.Windows.Forms.TextBox tbxto;
    }
}

