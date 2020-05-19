namespace Datenbanken_Disconnected
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listFirmen = new System.Windows.Forms.ListBox();
            this.btGetData = new System.Windows.Forms.Button();
            this.btGetFile = new System.Windows.Forms.Button();
            this.btCustomerFiles = new System.Windows.Forms.Button();
            this.btCompanynames = new System.Windows.Forms.Button();
            this.btGermanCustomers = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // listFirmen
            // 
            this.listFirmen.BackColor = System.Drawing.Color.LavenderBlush;
            this.listFirmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFirmen.FormattingEnabled = true;
            this.listFirmen.ItemHeight = 16;
            this.listFirmen.Location = new System.Drawing.Point(994, 12);
            this.listFirmen.Name = "listFirmen";
            this.listFirmen.Size = new System.Drawing.Size(190, 516);
            this.listFirmen.TabIndex = 1;
            this.listFirmen.SelectedIndexChanged += new System.EventHandler(this.listFirmen_SelectedIndexChanged);
            // 
            // btGetData
            // 
            this.btGetData.Location = new System.Drawing.Point(13, 535);
            this.btGetData.Name = "btGetData";
            this.btGetData.Size = new System.Drawing.Size(190, 40);
            this.btGetData.TabIndex = 2;
            this.btGetData.Text = "Daten aus DB holen";
            this.btGetData.UseVisualStyleBackColor = true;
            this.btGetData.Click += new System.EventHandler(this.btGetData_Click);
            // 
            // btGetFile
            // 
            this.btGetFile.Location = new System.Drawing.Point(209, 535);
            this.btGetFile.Name = "btGetFile";
            this.btGetFile.Size = new System.Drawing.Size(190, 40);
            this.btGetFile.TabIndex = 3;
            this.btGetFile.Text = "Daten aus Datei holen";
            this.btGetFile.UseVisualStyleBackColor = true;
            this.btGetFile.Click += new System.EventHandler(this.btGetFile_Click);
            // 
            // btCustomerFiles
            // 
            this.btCustomerFiles.Location = new System.Drawing.Point(406, 535);
            this.btCustomerFiles.Name = "btCustomerFiles";
            this.btCustomerFiles.Size = new System.Drawing.Size(190, 40);
            this.btCustomerFiles.TabIndex = 4;
            this.btCustomerFiles.Text = "Kundendaten anzeigen";
            this.btCustomerFiles.UseVisualStyleBackColor = true;
            this.btCustomerFiles.Click += new System.EventHandler(this.btCustomerFiles_Click);
            // 
            // btCompanynames
            // 
            this.btCompanynames.Location = new System.Drawing.Point(602, 535);
            this.btCompanynames.Name = "btCompanynames";
            this.btCompanynames.Size = new System.Drawing.Size(190, 40);
            this.btCompanynames.TabIndex = 5;
            this.btCompanynames.Text = "Firmennamen anzeigen";
            this.btCompanynames.UseVisualStyleBackColor = true;
            this.btCompanynames.Click += new System.EventHandler(this.btCompanynames_Click);
            // 
            // btGermanCustomers
            // 
            this.btGermanCustomers.Location = new System.Drawing.Point(798, 535);
            this.btGermanCustomers.Name = "btGermanCustomers";
            this.btGermanCustomers.Size = new System.Drawing.Size(190, 40);
            this.btGermanCustomers.TabIndex = 6;
            this.btGermanCustomers.Text = "Alle deutschen Kunden anzeigen";
            this.btGermanCustomers.UseVisualStyleBackColor = true;
            this.btGermanCustomers.Click += new System.EventHandler(this.btGermanCustomers_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(994, 535);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(190, 40);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "In Datei speichern";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // DATEN
            // 
            this.data.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.GridColor = System.Drawing.Color.LavenderBlush;
            this.data.Location = new System.Drawing.Point(13, 13);
            this.data.Name = "DATEN";
            this.data.Size = new System.Drawing.Size(975, 516);
            this.data.TabIndex = 0;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATEN_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1196, 587);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btGermanCustomers);
            this.Controls.Add(this.btCompanynames);
            this.Controls.Add(this.btCustomerFiles);
            this.Controls.Add(this.btGetFile);
            this.Controls.Add(this.btGetData);
            this.Controls.Add(this.listFirmen);
            this.Controls.Add(this.data);
            this.Name = "Form1";
            this.Text = "Nordwind";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listFirmen;
        private System.Windows.Forms.Button btGetData;
        private System.Windows.Forms.Button btGetFile;
        private System.Windows.Forms.Button btCustomerFiles;
        private System.Windows.Forms.Button btCompanynames;
        private System.Windows.Forms.Button btGermanCustomers;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DataGridView data;
    }
}

