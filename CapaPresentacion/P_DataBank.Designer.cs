namespace CapaPresentacion
{
    partial class P_DataBank
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_DataBank));
            this.lblDB = new System.Windows.Forms.Label();
            this.bunifuDragControlDB = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelDB = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pbxDB2 = new System.Windows.Forms.PictureBox();
            this.pbxDB1 = new System.Windows.Forms.PictureBox();
            this.pbxDB3 = new System.Windows.Forms.PictureBox();
            this.bunifuTileBtnCli = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileBtnCon = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileBtnPre = new Bunifu.Framework.UI.BunifuTileButton();
            this.panelDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDB3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.BackColor = System.Drawing.Color.White;
            this.lblDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDB.Location = new System.Drawing.Point(110, 254);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(364, 29);
            this.lblDB.TabIndex = 0;
            this.lblDB.Text = "Sistema de Préstamos DataBank";
            // 
            // bunifuDragControlDB
            // 
            this.bunifuDragControlDB.Fixed = true;
            this.bunifuDragControlDB.Horizontal = true;
            this.bunifuDragControlDB.TargetControl = this.panelDB;
            this.bunifuDragControlDB.Vertical = true;
            // 
            // panelDB
            // 
            this.panelDB.BackColor = System.Drawing.Color.Orange;
            this.panelDB.Controls.Add(this.bunifuCustomLabel1);
            this.panelDB.Controls.Add(this.pbxDB2);
            this.panelDB.Controls.Add(this.pbxDB1);
            this.panelDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDB.Location = new System.Drawing.Point(0, 0);
            this.panelDB.Name = "panelDB";
            this.panelDB.Size = new System.Drawing.Size(590, 47);
            this.panelDB.TabIndex = 4;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(55, 13);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(89, 20);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "DataBank";
            // 
            // pbxDB2
            // 
            this.pbxDB2.Image = ((System.Drawing.Image)(resources.GetObject("pbxDB2.Image")));
            this.pbxDB2.Location = new System.Drawing.Point(540, 0);
            this.pbxDB2.Name = "pbxDB2";
            this.pbxDB2.Size = new System.Drawing.Size(50, 47);
            this.pbxDB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDB2.TabIndex = 1;
            this.pbxDB2.TabStop = false;
            this.pbxDB2.Click += new System.EventHandler(this.pbxDB2_Click);
            // 
            // pbxDB1
            // 
            this.pbxDB1.Image = ((System.Drawing.Image)(resources.GetObject("pbxDB1.Image")));
            this.pbxDB1.Location = new System.Drawing.Point(0, 0);
            this.pbxDB1.Name = "pbxDB1";
            this.pbxDB1.Size = new System.Drawing.Size(48, 47);
            this.pbxDB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDB1.TabIndex = 0;
            this.pbxDB1.TabStop = false;
            // 
            // pbxDB3
            // 
            this.pbxDB3.Image = ((System.Drawing.Image)(resources.GetObject("pbxDB3.Image")));
            this.pbxDB3.Location = new System.Drawing.Point(212, 77);
            this.pbxDB3.Name = "pbxDB3";
            this.pbxDB3.Size = new System.Drawing.Size(167, 159);
            this.pbxDB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDB3.TabIndex = 2;
            this.pbxDB3.TabStop = false;
            // 
            // bunifuTileBtnCli
            // 
            this.bunifuTileBtnCli.BackColor = System.Drawing.Color.SteelBlue;
            this.bunifuTileBtnCli.color = System.Drawing.Color.SteelBlue;
            this.bunifuTileBtnCli.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileBtnCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileBtnCli.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileBtnCli.ForeColor = System.Drawing.Color.White;
            this.bunifuTileBtnCli.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileBtnCli.Image")));
            this.bunifuTileBtnCli.ImagePosition = 20;
            this.bunifuTileBtnCli.ImageZoom = 50;
            this.bunifuTileBtnCli.LabelPosition = 41;
            this.bunifuTileBtnCli.LabelText = "Cliente";
            this.bunifuTileBtnCli.Location = new System.Drawing.Point(87, 311);
            this.bunifuTileBtnCli.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileBtnCli.Name = "bunifuTileBtnCli";
            this.bunifuTileBtnCli.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileBtnCli.TabIndex = 7;
            this.bunifuTileBtnCli.Click += new System.EventHandler(this.bunifuTileBtnCli_Click);
            // 
            // bunifuTileBtnCon
            // 
            this.bunifuTileBtnCon.BackColor = System.Drawing.Color.DarkOrange;
            this.bunifuTileBtnCon.color = System.Drawing.Color.DarkOrange;
            this.bunifuTileBtnCon.colorActive = System.Drawing.Color.Orange;
            this.bunifuTileBtnCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileBtnCon.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileBtnCon.ForeColor = System.Drawing.Color.White;
            this.bunifuTileBtnCon.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileBtnCon.Image")));
            this.bunifuTileBtnCon.ImagePosition = 20;
            this.bunifuTileBtnCon.ImageZoom = 50;
            this.bunifuTileBtnCon.LabelPosition = 41;
            this.bunifuTileBtnCon.LabelText = "Consulta";
            this.bunifuTileBtnCon.Location = new System.Drawing.Point(367, 311);
            this.bunifuTileBtnCon.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileBtnCon.Name = "bunifuTileBtnCon";
            this.bunifuTileBtnCon.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileBtnCon.TabIndex = 8;
            this.bunifuTileBtnCon.Click += new System.EventHandler(this.bunifuTileBtnCon_Click);
            // 
            // bunifuTileBtnPre
            // 
            this.bunifuTileBtnPre.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileBtnPre.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileBtnPre.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileBtnPre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileBtnPre.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileBtnPre.ForeColor = System.Drawing.Color.White;
            this.bunifuTileBtnPre.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileBtnPre.Image")));
            this.bunifuTileBtnPre.ImagePosition = 20;
            this.bunifuTileBtnPre.ImageZoom = 50;
            this.bunifuTileBtnPre.LabelPosition = 41;
            this.bunifuTileBtnPre.LabelText = "Servicio";
            this.bunifuTileBtnPre.Location = new System.Drawing.Point(227, 311);
            this.bunifuTileBtnPre.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileBtnPre.Name = "bunifuTileBtnPre";
            this.bunifuTileBtnPre.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileBtnPre.TabIndex = 9;
            this.bunifuTileBtnPre.Click += new System.EventHandler(this.bunifuTileBtnPre_Click);
            // 
            // P_DataBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 511);
            this.Controls.Add(this.bunifuTileBtnPre);
            this.Controls.Add(this.bunifuTileBtnCon);
            this.Controls.Add(this.bunifuTileBtnCli);
            this.Controls.Add(this.pbxDB3);
            this.Controls.Add(this.panelDB);
            this.Controls.Add(this.lblDB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "P_DataBank";
            this.Text = "DataBank";
            this.panelDB.ResumeLayout(false);
            this.panelDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDB3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDB;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlDB;
        private System.Windows.Forms.Panel panelDB;
        private System.Windows.Forms.PictureBox pbxDB2;
        private System.Windows.Forms.PictureBox pbxDB1;
        private System.Windows.Forms.PictureBox pbxDB3;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileBtnCli;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileBtnCon;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileBtnPre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}

