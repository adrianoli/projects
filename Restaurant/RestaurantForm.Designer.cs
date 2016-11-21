namespace Restaurant
{
    partial class RestaurantForm
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
            this.uiLblRestaurantName = new System.Windows.Forms.Label();
            this.uiPictureBox = new System.Windows.Forms.PictureBox();
            this.uiBtnEnter = new System.Windows.Forms.Button();
            this.uiBtnGoAway = new System.Windows.Forms.Button();
            this.CreateDatabase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLblRestaurantName
            // 
            this.uiLblRestaurantName.AutoSize = true;
            this.uiLblRestaurantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiLblRestaurantName.Location = new System.Drawing.Point(12, 9);
            this.uiLblRestaurantName.Name = "uiLblRestaurantName";
            this.uiLblRestaurantName.Size = new System.Drawing.Size(99, 13);
            this.uiLblRestaurantName.TabIndex = 1;
            this.uiLblRestaurantName.Text = "Zjesz co chcesz";
            // 
            // uiPictureBox
            // 
            this.uiPictureBox.ErrorImage = null;
            this.uiPictureBox.Image = global::Restaurant.Properties.Resources.CloseDoor;
            this.uiPictureBox.Location = new System.Drawing.Point(15, 26);
            this.uiPictureBox.Name = "uiPictureBox";
            this.uiPictureBox.Size = new System.Drawing.Size(96, 172);
            this.uiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uiPictureBox.TabIndex = 2;
            this.uiPictureBox.TabStop = false;
            // 
            // uiBtnEnter
            // 
            this.uiBtnEnter.Location = new System.Drawing.Point(168, 81);
            this.uiBtnEnter.Name = "uiBtnEnter";
            this.uiBtnEnter.Size = new System.Drawing.Size(75, 23);
            this.uiBtnEnter.TabIndex = 3;
            this.uiBtnEnter.Text = "Wejdź";
            this.uiBtnEnter.UseVisualStyleBackColor = true;
            this.uiBtnEnter.Click += new System.EventHandler(this.uiBtnEnter_Click);
            // 
            // uiBtnGoAway
            // 
            this.uiBtnGoAway.Location = new System.Drawing.Point(168, 110);
            this.uiBtnGoAway.Name = "uiBtnGoAway";
            this.uiBtnGoAway.Size = new System.Drawing.Size(75, 23);
            this.uiBtnGoAway.TabIndex = 4;
            this.uiBtnGoAway.Text = "Odejdź";
            this.uiBtnGoAway.UseVisualStyleBackColor = true;
            this.uiBtnGoAway.Click += new System.EventHandler(this.uiBtnGoAway_Click);
            // 
            // CreateDatabase
            // 
            this.CreateDatabase.Location = new System.Drawing.Point(190, 175);
            this.CreateDatabase.Name = "CreateDatabase";
            this.CreateDatabase.Size = new System.Drawing.Size(94, 23);
            this.CreateDatabase.TabIndex = 5;
            this.CreateDatabase.Text = "Baza danych";
            this.CreateDatabase.UseVisualStyleBackColor = true;
            this.CreateDatabase.Visible = false;
            this.CreateDatabase.Click += new System.EventHandler(this.CreateDatabase_Click);
            // 
            // RestaurantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 210);
            this.Controls.Add(this.CreateDatabase);
            this.Controls.Add(this.uiBtnGoAway);
            this.Controls.Add(this.uiBtnEnter);
            this.Controls.Add(this.uiPictureBox);
            this.Controls.Add(this.uiLblRestaurantName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RestaurantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restauracja";
            ((System.ComponentModel.ISupportInitialize)(this.uiPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uiLblRestaurantName;
        private System.Windows.Forms.PictureBox uiPictureBox;
        private System.Windows.Forms.Button uiBtnEnter;
        private System.Windows.Forms.Button uiBtnGoAway;
        private System.Windows.Forms.Button CreateDatabase;

    }
}

