namespace Restaurant.Forms
{
    partial class ToppingsForDinner
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
            this.uiFlpToppingsChoosen = new System.Windows.Forms.FlowLayoutPanel();
            this.uiPnlDinnerName = new System.Windows.Forms.Panel();
            this.uiTlpLastPanel = new System.Windows.Forms.TableLayoutPanel();
            this.uiPnlAccept = new System.Windows.Forms.Panel();
            this.uiPnlPriceInformation = new System.Windows.Forms.Panel();
            this.uiTlpMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.uiFlpAddToppings = new System.Windows.Forms.FlowLayoutPanel();
            this.uiLblDinnerName = new System.Windows.Forms.Label();
            this.uiTxtPrice = new System.Windows.Forms.TextBox();
            this.uiPnlDinnerName.SuspendLayout();
            this.uiTlpLastPanel.SuspendLayout();
            this.uiPnlPriceInformation.SuspendLayout();
            this.uiTlpMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiFlpToppingsChoosen
            // 
            this.uiFlpToppingsChoosen.AutoScroll = true;
            this.uiFlpToppingsChoosen.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.uiFlpToppingsChoosen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiFlpToppingsChoosen.Location = new System.Drawing.Point(3, 38);
            this.uiFlpToppingsChoosen.Name = "uiFlpToppingsChoosen";
            this.uiFlpToppingsChoosen.Size = new System.Drawing.Size(354, 134);
            this.uiFlpToppingsChoosen.TabIndex = 6;
            // 
            // uiPnlDinnerName
            // 
            this.uiPnlDinnerName.Controls.Add(this.uiLblDinnerName);
            this.uiPnlDinnerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPnlDinnerName.Location = new System.Drawing.Point(3, 3);
            this.uiPnlDinnerName.Name = "uiPnlDinnerName";
            this.uiPnlDinnerName.Size = new System.Drawing.Size(354, 29);
            this.uiPnlDinnerName.TabIndex = 1;
            // 
            // uiTlpLastPanel
            // 
            this.uiTlpLastPanel.ColumnCount = 2;
            this.uiTlpLastPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTlpLastPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTlpLastPanel.Controls.Add(this.uiPnlPriceInformation, 0, 0);
            this.uiTlpLastPanel.Controls.Add(this.uiPnlAccept, 1, 0);
            this.uiTlpLastPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTlpLastPanel.Location = new System.Drawing.Point(3, 318);
            this.uiTlpLastPanel.Name = "uiTlpLastPanel";
            this.uiTlpLastPanel.RowCount = 1;
            this.uiTlpLastPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTlpLastPanel.Size = new System.Drawing.Size(354, 31);
            this.uiTlpLastPanel.TabIndex = 0;
            // 
            // uiPnlAccept
            // 
            this.uiPnlAccept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPnlAccept.Location = new System.Drawing.Point(180, 3);
            this.uiPnlAccept.Name = "uiPnlAccept";
            this.uiPnlAccept.Size = new System.Drawing.Size(171, 25);
            this.uiPnlAccept.TabIndex = 1;
            // 
            // uiPnlPriceInformation
            // 
            this.uiPnlPriceInformation.Controls.Add(this.uiTxtPrice);
            this.uiPnlPriceInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPnlPriceInformation.Location = new System.Drawing.Point(3, 3);
            this.uiPnlPriceInformation.Name = "uiPnlPriceInformation";
            this.uiPnlPriceInformation.Size = new System.Drawing.Size(171, 25);
            this.uiPnlPriceInformation.TabIndex = 0;
            // 
            // uiTlpMainPanel
            // 
            this.uiTlpMainPanel.ColumnCount = 1;
            this.uiTlpMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTlpMainPanel.Controls.Add(this.uiTlpLastPanel, 0, 3);
            this.uiTlpMainPanel.Controls.Add(this.uiPnlDinnerName, 0, 0);
            this.uiTlpMainPanel.Controls.Add(this.uiFlpToppingsChoosen, 0, 1);
            this.uiTlpMainPanel.Controls.Add(this.uiFlpAddToppings, 0, 2);
            this.uiTlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTlpMainPanel.Location = new System.Drawing.Point(0, 0);
            this.uiTlpMainPanel.Name = "uiTlpMainPanel";
            this.uiTlpMainPanel.RowCount = 4;
            this.uiTlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.uiTlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.uiTlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.uiTlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.uiTlpMainPanel.Size = new System.Drawing.Size(360, 352);
            this.uiTlpMainPanel.TabIndex = 1;
            // 
            // uiFlpAddToppings
            // 
            this.uiFlpAddToppings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiFlpAddToppings.Location = new System.Drawing.Point(3, 178);
            this.uiFlpAddToppings.Name = "uiFlpAddToppings";
            this.uiFlpAddToppings.Size = new System.Drawing.Size(354, 134);
            this.uiFlpAddToppings.TabIndex = 7;
            // 
            // uiLblDinnerName
            // 
            this.uiLblDinnerName.AutoSize = true;
            this.uiLblDinnerName.Location = new System.Drawing.Point(160, 6);
            this.uiLblDinnerName.Name = "uiLblDinnerName";
            this.uiLblDinnerName.Size = new System.Drawing.Size(0, 13);
            this.uiLblDinnerName.TabIndex = 0;
            // 
            // uiTxtPrice
            // 
            this.uiTxtPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTxtPrice.Location = new System.Drawing.Point(0, 0);
            this.uiTxtPrice.Name = "uiTxtPrice";
            this.uiTxtPrice.ReadOnly = true;
            this.uiTxtPrice.Size = new System.Drawing.Size(171, 20);
            this.uiTxtPrice.TabIndex = 0;
            // 
            // ToppingsForDinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 352);
            this.Controls.Add(this.uiTlpMainPanel);
            this.Name = "ToppingsForDinner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccessoriesForDinner";
            this.uiPnlDinnerName.ResumeLayout(false);
            this.uiPnlDinnerName.PerformLayout();
            this.uiTlpLastPanel.ResumeLayout(false);
            this.uiPnlPriceInformation.ResumeLayout(false);
            this.uiPnlPriceInformation.PerformLayout();
            this.uiTlpMainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel uiFlpToppingsChoosen;
        private System.Windows.Forms.Panel uiPnlDinnerName;
        private System.Windows.Forms.TableLayoutPanel uiTlpLastPanel;
        private System.Windows.Forms.Panel uiPnlPriceInformation;
        private System.Windows.Forms.Panel uiPnlAccept;
        private System.Windows.Forms.TableLayoutPanel uiTlpMainPanel;
        private System.Windows.Forms.FlowLayoutPanel uiFlpAddToppings;
        private System.Windows.Forms.Label uiLblDinnerName;
        private System.Windows.Forms.TextBox uiTxtPrice;

    }
}