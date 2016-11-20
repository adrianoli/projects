namespace Restaurant.Forms
{
    partial class AddressForm
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
            this.uiLblFieldRequired = new System.Windows.Forms.Label();
            this.uiLblStreet = new System.Windows.Forms.Label();
            this.uiLblHouseNumber = new System.Windows.Forms.Label();
            this.uiLblFlatNumber = new System.Windows.Forms.Label();
            this.uiLblCity = new System.Windows.Forms.Label();
            this.uiLblPhoneNumber = new System.Windows.Forms.Label();
            this.uiTxtStreet = new System.Windows.Forms.TextBox();
            this.uiTxtHouseNumber = new System.Windows.Forms.TextBox();
            this.uiTxtFlatNumber = new System.Windows.Forms.TextBox();
            this.uiTxtCity = new System.Windows.Forms.TextBox();
            this.uiBtnAccept = new System.Windows.Forms.Button();
            this.uiBtnCancel = new System.Windows.Forms.Button();
            this.uiNudPhoneNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.uiNudPhoneNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLblFieldRequired
            // 
            this.uiLblFieldRequired.AutoSize = true;
            this.uiLblFieldRequired.Location = new System.Drawing.Point(133, 9);
            this.uiLblFieldRequired.Name = "uiLblFieldRequired";
            this.uiLblFieldRequired.Size = new System.Drawing.Size(94, 13);
            this.uiLblFieldRequired.TabIndex = 0;
            this.uiLblFieldRequired.Text = "* - pola wymagane";
            // 
            // uiLblStreet
            // 
            this.uiLblStreet.AutoSize = true;
            this.uiLblStreet.Location = new System.Drawing.Point(23, 52);
            this.uiLblStreet.Name = "uiLblStreet";
            this.uiLblStreet.Size = new System.Drawing.Size(100, 13);
            this.uiLblStreet.TabIndex = 1;
            this.uiLblStreet.Text = "Ulica / Nazwa wsi*:";
            // 
            // uiLblHouseNumber
            // 
            this.uiLblHouseNumber.AutoSize = true;
            this.uiLblHouseNumber.Location = new System.Drawing.Point(23, 83);
            this.uiLblHouseNumber.Name = "uiLblHouseNumber";
            this.uiLblHouseNumber.Size = new System.Drawing.Size(74, 13);
            this.uiLblHouseNumber.TabIndex = 2;
            this.uiLblHouseNumber.Text = "Numer domu*:";
            // 
            // uiLblFlatNumber
            // 
            this.uiLblFlatNumber.AutoSize = true;
            this.uiLblFlatNumber.Location = new System.Drawing.Point(23, 115);
            this.uiLblFlatNumber.Name = "uiLblFlatNumber";
            this.uiLblFlatNumber.Size = new System.Drawing.Size(96, 13);
            this.uiLblFlatNumber.TabIndex = 3;
            this.uiLblFlatNumber.Text = "Numer mieszkania:";
            // 
            // uiLblCity
            // 
            this.uiLblCity.AutoSize = true;
            this.uiLblCity.Location = new System.Drawing.Point(23, 147);
            this.uiLblCity.Name = "uiLblCity";
            this.uiLblCity.Size = new System.Drawing.Size(75, 13);
            this.uiLblCity.TabIndex = 4;
            this.uiLblCity.Text = "Miejscowość*:";
            // 
            // uiLblPhoneNumber
            // 
            this.uiLblPhoneNumber.AutoSize = true;
            this.uiLblPhoneNumber.Location = new System.Drawing.Point(23, 180);
            this.uiLblPhoneNumber.Name = "uiLblPhoneNumber";
            this.uiLblPhoneNumber.Size = new System.Drawing.Size(107, 13);
            this.uiLblPhoneNumber.TabIndex = 5;
            this.uiLblPhoneNumber.Text = "Telefon komórkowy*:";
            // 
            // uiTxtStreet
            // 
            this.uiTxtStreet.Location = new System.Drawing.Point(136, 49);
            this.uiTxtStreet.MaxLength = 50;
            this.uiTxtStreet.Name = "uiTxtStreet";
            this.uiTxtStreet.Size = new System.Drawing.Size(230, 20);
            this.uiTxtStreet.TabIndex = 6;
            // 
            // uiTxtHouseNumber
            // 
            this.uiTxtHouseNumber.Location = new System.Drawing.Point(136, 80);
            this.uiTxtHouseNumber.MaxLength = 10;
            this.uiTxtHouseNumber.Name = "uiTxtHouseNumber";
            this.uiTxtHouseNumber.Size = new System.Drawing.Size(230, 20);
            this.uiTxtHouseNumber.TabIndex = 7;
            // 
            // uiTxtFlatNumber
            // 
            this.uiTxtFlatNumber.Location = new System.Drawing.Point(136, 112);
            this.uiTxtFlatNumber.MaxLength = 10;
            this.uiTxtFlatNumber.Name = "uiTxtFlatNumber";
            this.uiTxtFlatNumber.Size = new System.Drawing.Size(229, 20);
            this.uiTxtFlatNumber.TabIndex = 8;
            // 
            // uiTxtCity
            // 
            this.uiTxtCity.Location = new System.Drawing.Point(136, 144);
            this.uiTxtCity.MaxLength = 50;
            this.uiTxtCity.Name = "uiTxtCity";
            this.uiTxtCity.Size = new System.Drawing.Size(229, 20);
            this.uiTxtCity.TabIndex = 9;
            // 
            // uiBtnAccept
            // 
            this.uiBtnAccept.Location = new System.Drawing.Point(209, 216);
            this.uiBtnAccept.Name = "uiBtnAccept";
            this.uiBtnAccept.Size = new System.Drawing.Size(75, 23);
            this.uiBtnAccept.TabIndex = 11;
            this.uiBtnAccept.Text = "OK";
            this.uiBtnAccept.UseVisualStyleBackColor = true;
            this.uiBtnAccept.Click += new System.EventHandler(this.uiBtnAccept_Click);
            // 
            // uiBtnCancel
            // 
            this.uiBtnCancel.Location = new System.Drawing.Point(290, 216);
            this.uiBtnCancel.Name = "uiBtnCancel";
            this.uiBtnCancel.Size = new System.Drawing.Size(75, 23);
            this.uiBtnCancel.TabIndex = 12;
            this.uiBtnCancel.Text = "Anuluj";
            this.uiBtnCancel.UseVisualStyleBackColor = true;
            this.uiBtnCancel.Click += new System.EventHandler(this.uiBtnCancel_Click);
            // 
            // uiNudPhoneNumber
            // 
            this.uiNudPhoneNumber.Location = new System.Drawing.Point(136, 178);
            this.uiNudPhoneNumber.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.uiNudPhoneNumber.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.uiNudPhoneNumber.Name = "uiNudPhoneNumber";
            this.uiNudPhoneNumber.Size = new System.Drawing.Size(230, 20);
            this.uiNudPhoneNumber.TabIndex = 13;
            this.uiNudPhoneNumber.Value = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 251);
            this.Controls.Add(this.uiNudPhoneNumber);
            this.Controls.Add(this.uiBtnCancel);
            this.Controls.Add(this.uiBtnAccept);
            this.Controls.Add(this.uiTxtCity);
            this.Controls.Add(this.uiTxtFlatNumber);
            this.Controls.Add(this.uiTxtHouseNumber);
            this.Controls.Add(this.uiTxtStreet);
            this.Controls.Add(this.uiLblPhoneNumber);
            this.Controls.Add(this.uiLblCity);
            this.Controls.Add(this.uiLblFlatNumber);
            this.Controls.Add(this.uiLblHouseNumber);
            this.Controls.Add(this.uiLblStreet);
            this.Controls.Add(this.uiLblFieldRequired);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adres dostarczenia zamówienia";
            ((System.ComponentModel.ISupportInitialize)(this.uiNudPhoneNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uiLblFieldRequired;
        private System.Windows.Forms.Label uiLblStreet;
        private System.Windows.Forms.Label uiLblHouseNumber;
        private System.Windows.Forms.Label uiLblFlatNumber;
        private System.Windows.Forms.Label uiLblCity;
        private System.Windows.Forms.Label uiLblPhoneNumber;
        private System.Windows.Forms.TextBox uiTxtStreet;
        private System.Windows.Forms.TextBox uiTxtHouseNumber;
        private System.Windows.Forms.TextBox uiTxtFlatNumber;
        private System.Windows.Forms.TextBox uiTxtCity;
        private System.Windows.Forms.Button uiBtnAccept;
        private System.Windows.Forms.Button uiBtnCancel;
        private System.Windows.Forms.NumericUpDown uiNudPhoneNumber;
    }
}