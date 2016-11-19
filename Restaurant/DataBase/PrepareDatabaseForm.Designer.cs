namespace Restaurant.DataBase
{
    partial class PrepareDatabaseForm
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
            this.uiBtnCreateDatabase = new System.Windows.Forms.Button();
            this.ConnectDbTest = new System.Windows.Forms.Button();
            this.uiBtnCreateTable = new System.Windows.Forms.Button();
            this.uiBtnAddData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiBtnCreateDatabase
            // 
            this.uiBtnCreateDatabase.Location = new System.Drawing.Point(13, 13);
            this.uiBtnCreateDatabase.Name = "uiBtnCreateDatabase";
            this.uiBtnCreateDatabase.Size = new System.Drawing.Size(143, 23);
            this.uiBtnCreateDatabase.TabIndex = 0;
            this.uiBtnCreateDatabase.Text = "Utwórz bazę danych";
            this.uiBtnCreateDatabase.UseVisualStyleBackColor = true;
            this.uiBtnCreateDatabase.Click += new System.EventHandler(this.uiBtnCreateDatabase_Click);
            // 
            // ConnectDbTest
            // 
            this.ConnectDbTest.Location = new System.Drawing.Point(195, 13);
            this.ConnectDbTest.Name = "ConnectDbTest";
            this.ConnectDbTest.Size = new System.Drawing.Size(140, 23);
            this.ConnectDbTest.TabIndex = 1;
            this.ConnectDbTest.Text = "Test połączenia z bazą";
            this.ConnectDbTest.UseVisualStyleBackColor = true;
            this.ConnectDbTest.Click += new System.EventHandler(this.ConnectDbTest_Click);
            // 
            // uiBtnCreateTable
            // 
            this.uiBtnCreateTable.Location = new System.Drawing.Point(13, 43);
            this.uiBtnCreateTable.Name = "uiBtnCreateTable";
            this.uiBtnCreateTable.Size = new System.Drawing.Size(143, 23);
            this.uiBtnCreateTable.TabIndex = 2;
            this.uiBtnCreateTable.Text = "Utwórz tabele";
            this.uiBtnCreateTable.UseVisualStyleBackColor = true;
            this.uiBtnCreateTable.Click += new System.EventHandler(this.uiBtnCreateTable_Click);
            // 
            // uiBtnAddData
            // 
            this.uiBtnAddData.Location = new System.Drawing.Point(13, 72);
            this.uiBtnAddData.Name = "uiBtnAddData";
            this.uiBtnAddData.Size = new System.Drawing.Size(143, 23);
            this.uiBtnAddData.TabIndex = 4;
            this.uiBtnAddData.Text = "Załaduj początkowe dane";
            this.uiBtnAddData.UseVisualStyleBackColor = true;
            this.uiBtnAddData.Click += new System.EventHandler(this.uiBtnAddData_Click);
            // 
            // PrepareDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 127);
            this.Controls.Add(this.uiBtnAddData);
            this.Controls.Add(this.uiBtnCreateTable);
            this.Controls.Add(this.ConnectDbTest);
            this.Controls.Add(this.uiBtnCreateDatabase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrepareDatabaseForm";
            this.Text = "Przygotowanie bazy danych";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiBtnCreateDatabase;
        private System.Windows.Forms.Button ConnectDbTest;
        private System.Windows.Forms.Button uiBtnCreateTable;
        private System.Windows.Forms.Button uiBtnAddData;
    }
}