namespace Restaurant.Forms
{
    partial class OrderDetails
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
            this.uiTlpMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.uiTlpClosePanel = new System.Windows.Forms.TableLayoutPanel();
            this.uiBtnClose = new System.Windows.Forms.Button();
            this.uiTxtOrder = new System.Windows.Forms.TextBox();
            this.uiTlpMainPanel.SuspendLayout();
            this.uiTlpClosePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTlpMainPanel
            // 
            this.uiTlpMainPanel.ColumnCount = 1;
            this.uiTlpMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTlpMainPanel.Controls.Add(this.uiTlpClosePanel, 0, 1);
            this.uiTlpMainPanel.Controls.Add(this.uiTxtOrder, 0, 0);
            this.uiTlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTlpMainPanel.Location = new System.Drawing.Point(0, 0);
            this.uiTlpMainPanel.Name = "uiTlpMainPanel";
            this.uiTlpMainPanel.RowCount = 2;
            this.uiTlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.uiTlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.uiTlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uiTlpMainPanel.Size = new System.Drawing.Size(458, 509);
            this.uiTlpMainPanel.TabIndex = 0;
            // 
            // uiTlpClosePanel
            // 
            this.uiTlpClosePanel.ColumnCount = 2;
            this.uiTlpClosePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.uiTlpClosePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.uiTlpClosePanel.Controls.Add(this.uiBtnClose, 1, 0);
            this.uiTlpClosePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTlpClosePanel.Location = new System.Drawing.Point(3, 476);
            this.uiTlpClosePanel.Name = "uiTlpClosePanel";
            this.uiTlpClosePanel.RowCount = 1;
            this.uiTlpClosePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTlpClosePanel.Size = new System.Drawing.Size(452, 30);
            this.uiTlpClosePanel.TabIndex = 1;
            // 
            // uiBtnClose
            // 
            this.uiBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBtnClose.Location = new System.Drawing.Point(387, 4);
            this.uiBtnClose.Name = "uiBtnClose";
            this.uiBtnClose.Size = new System.Drawing.Size(62, 23);
            this.uiBtnClose.TabIndex = 0;
            this.uiBtnClose.Text = "Zamknij";
            this.uiBtnClose.UseVisualStyleBackColor = true;
            this.uiBtnClose.Click += new System.EventHandler(this.uiBtnClose_Click);
            // 
            // uiTxtOrder
            // 
            this.uiTxtOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTxtOrder.Location = new System.Drawing.Point(3, 3);
            this.uiTxtOrder.Multiline = true;
            this.uiTxtOrder.Name = "uiTxtOrder";
            this.uiTxtOrder.ReadOnly = true;
            this.uiTxtOrder.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.uiTxtOrder.Size = new System.Drawing.Size(452, 467);
            this.uiTxtOrder.TabIndex = 2;
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 509);
            this.Controls.Add(this.uiTlpMainPanel);
            this.Name = "OrderDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szczegóły zamówienia";
            this.uiTlpMainPanel.ResumeLayout(false);
            this.uiTlpMainPanel.PerformLayout();
            this.uiTlpClosePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel uiTlpMainPanel;
        private System.Windows.Forms.TableLayoutPanel uiTlpClosePanel;
        private System.Windows.Forms.Button uiBtnClose;
        private System.Windows.Forms.TextBox uiTxtOrder;
    }
}