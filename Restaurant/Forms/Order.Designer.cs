﻿namespace Restaurant.Forms
{
    partial class Order
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
            this.uiTlpMainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.uiFlpFood = new System.Windows.Forms.FlowLayoutPanel();
            this.uiPnlEmail = new System.Windows.Forms.Panel();
            this.uiTxtEmail = new System.Windows.Forms.TextBox();
            this.uiLblSetEmail = new System.Windows.Forms.Label();
            this.uiPnlShoppingCard = new System.Windows.Forms.Panel();
            this.uiBtnDelete = new System.Windows.Forms.Button();
            this.uiTxtAttentionToOrder = new System.Windows.Forms.TextBox();
            this.uiLblAttentionToOrder = new System.Windows.Forms.Label();
            this.uiLblOrderCost = new System.Windows.Forms.Label();
            this.uiTxtOrderCost = new System.Windows.Forms.TextBox();
            this.uiClbShopingCard = new System.Windows.Forms.CheckedListBox();
            this.uiTlpHistoryAndSendOrder = new System.Windows.Forms.TableLayoutPanel();
            this.uiBtnOrderHistory = new System.Windows.Forms.Button();
            this.uiBtnSendOrder = new System.Windows.Forms.Button();
            this.uiTlpMainLayout.SuspendLayout();
            this.uiPnlEmail.SuspendLayout();
            this.uiPnlShoppingCard.SuspendLayout();
            this.uiTlpHistoryAndSendOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTlpMainLayout
            // 
            this.uiTlpMainLayout.ColumnCount = 2;
            this.uiTlpMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTlpMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTlpMainLayout.Controls.Add(this.uiFlpFood, 0, 0);
            this.uiTlpMainLayout.Controls.Add(this.uiPnlEmail, 0, 1);
            this.uiTlpMainLayout.Controls.Add(this.uiPnlShoppingCard, 1, 0);
            this.uiTlpMainLayout.Controls.Add(this.uiTlpHistoryAndSendOrder, 1, 1);
            this.uiTlpMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTlpMainLayout.Location = new System.Drawing.Point(0, 0);
            this.uiTlpMainLayout.Name = "uiTlpMainLayout";
            this.uiTlpMainLayout.RowCount = 2;
            this.uiTlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.uiTlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.uiTlpMainLayout.Size = new System.Drawing.Size(728, 538);
            this.uiTlpMainLayout.TabIndex = 0;
            // 
            // uiFlpFood
            // 
            this.uiFlpFood.AutoScroll = true;
            this.uiFlpFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiFlpFood.Location = new System.Drawing.Point(3, 3);
            this.uiFlpFood.Name = "uiFlpFood";
            this.uiFlpFood.Size = new System.Drawing.Size(358, 478);
            this.uiFlpFood.TabIndex = 0;
            this.uiFlpFood.SizeChanged += new System.EventHandler(this.uiFlpFood_SizeChanged);
            // 
            // uiPnlEmail
            // 
            this.uiPnlEmail.Controls.Add(this.uiTxtEmail);
            this.uiPnlEmail.Controls.Add(this.uiLblSetEmail);
            this.uiPnlEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPnlEmail.Location = new System.Drawing.Point(3, 487);
            this.uiPnlEmail.Name = "uiPnlEmail";
            this.uiPnlEmail.Size = new System.Drawing.Size(358, 48);
            this.uiPnlEmail.TabIndex = 1;
            // 
            // uiTxtEmail
            // 
            this.uiTxtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTxtEmail.Location = new System.Drawing.Point(101, 16);
            this.uiTxtEmail.MaxLength = 50;
            this.uiTxtEmail.Name = "uiTxtEmail";
            this.uiTxtEmail.Size = new System.Drawing.Size(245, 20);
            this.uiTxtEmail.TabIndex = 1;
            // 
            // uiLblSetEmail
            // 
            this.uiLblSetEmail.AutoSize = true;
            this.uiLblSetEmail.Location = new System.Drawing.Point(9, 19);
            this.uiLblSetEmail.Name = "uiLblSetEmail";
            this.uiLblSetEmail.Size = new System.Drawing.Size(89, 13);
            this.uiLblSetEmail.TabIndex = 0;
            this.uiLblSetEmail.Text = "Wprowadź Email:";
            // 
            // uiPnlShoppingCard
            // 
            this.uiPnlShoppingCard.Controls.Add(this.uiBtnDelete);
            this.uiPnlShoppingCard.Controls.Add(this.uiTxtAttentionToOrder);
            this.uiPnlShoppingCard.Controls.Add(this.uiLblAttentionToOrder);
            this.uiPnlShoppingCard.Controls.Add(this.uiLblOrderCost);
            this.uiPnlShoppingCard.Controls.Add(this.uiTxtOrderCost);
            this.uiPnlShoppingCard.Controls.Add(this.uiClbShopingCard);
            this.uiPnlShoppingCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPnlShoppingCard.Location = new System.Drawing.Point(367, 3);
            this.uiPnlShoppingCard.Name = "uiPnlShoppingCard";
            this.uiPnlShoppingCard.Size = new System.Drawing.Size(358, 478);
            this.uiPnlShoppingCard.TabIndex = 2;
            // 
            // uiBtnDelete
            // 
            this.uiBtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBtnDelete.Location = new System.Drawing.Point(247, 253);
            this.uiBtnDelete.Name = "uiBtnDelete";
            this.uiBtnDelete.Size = new System.Drawing.Size(108, 23);
            this.uiBtnDelete.TabIndex = 5;
            this.uiBtnDelete.Text = "Usuń Zaznaczone";
            this.uiBtnDelete.UseVisualStyleBackColor = true;
            this.uiBtnDelete.Click += new System.EventHandler(this.uiBtnDelete_Click);
            // 
            // uiTxtAttentionToOrder
            // 
            this.uiTxtAttentionToOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTxtAttentionToOrder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.uiTxtAttentionToOrder.Location = new System.Drawing.Point(6, 338);
            this.uiTxtAttentionToOrder.MaxLength = 1000;
            this.uiTxtAttentionToOrder.Multiline = true;
            this.uiTxtAttentionToOrder.Name = "uiTxtAttentionToOrder";
            this.uiTxtAttentionToOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uiTxtAttentionToOrder.Size = new System.Drawing.Size(343, 127);
            this.uiTxtAttentionToOrder.TabIndex = 4;
            // 
            // uiLblAttentionToOrder
            // 
            this.uiLblAttentionToOrder.AutoSize = true;
            this.uiLblAttentionToOrder.Location = new System.Drawing.Point(3, 322);
            this.uiLblAttentionToOrder.Name = "uiLblAttentionToOrder";
            this.uiLblAttentionToOrder.Size = new System.Drawing.Size(113, 13);
            this.uiLblAttentionToOrder.TabIndex = 3;
            this.uiLblAttentionToOrder.Text = "Uwagi do zamówienia:";
            // 
            // uiLblOrderCost
            // 
            this.uiLblOrderCost.AutoSize = true;
            this.uiLblOrderCost.Location = new System.Drawing.Point(3, 280);
            this.uiLblOrderCost.Name = "uiLblOrderCost";
            this.uiLblOrderCost.Size = new System.Drawing.Size(74, 13);
            this.uiLblOrderCost.TabIndex = 2;
            this.uiLblOrderCost.Text = "Łączna suma:";
            // 
            // uiTxtOrderCost
            // 
            this.uiTxtOrderCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTxtOrderCost.Location = new System.Drawing.Point(4, 299);
            this.uiTxtOrderCost.Name = "uiTxtOrderCost";
            this.uiTxtOrderCost.ReadOnly = true;
            this.uiTxtOrderCost.Size = new System.Drawing.Size(351, 20);
            this.uiTxtOrderCost.TabIndex = 1;
            // 
            // uiClbShopingCard
            // 
            this.uiClbShopingCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiClbShopingCard.CheckOnClick = true;
            this.uiClbShopingCard.FormattingEnabled = true;
            this.uiClbShopingCard.HorizontalScrollbar = true;
            this.uiClbShopingCard.Location = new System.Drawing.Point(3, 3);
            this.uiClbShopingCard.Name = "uiClbShopingCard";
            this.uiClbShopingCard.Size = new System.Drawing.Size(352, 244);
            this.uiClbShopingCard.TabIndex = 0;
            // 
            // uiTlpHistoryAndSendOrder
            // 
            this.uiTlpHistoryAndSendOrder.ColumnCount = 2;
            this.uiTlpHistoryAndSendOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTlpHistoryAndSendOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTlpHistoryAndSendOrder.Controls.Add(this.uiBtnOrderHistory, 0, 0);
            this.uiTlpHistoryAndSendOrder.Controls.Add(this.uiBtnSendOrder, 1, 0);
            this.uiTlpHistoryAndSendOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTlpHistoryAndSendOrder.Location = new System.Drawing.Point(367, 487);
            this.uiTlpHistoryAndSendOrder.Name = "uiTlpHistoryAndSendOrder";
            this.uiTlpHistoryAndSendOrder.RowCount = 1;
            this.uiTlpHistoryAndSendOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTlpHistoryAndSendOrder.Size = new System.Drawing.Size(358, 48);
            this.uiTlpHistoryAndSendOrder.TabIndex = 3;
            // 
            // uiBtnOrderHistory
            // 
            this.uiBtnOrderHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBtnOrderHistory.Location = new System.Drawing.Point(6, 22);
            this.uiBtnOrderHistory.Name = "uiBtnOrderHistory";
            this.uiBtnOrderHistory.Size = new System.Drawing.Size(170, 23);
            this.uiBtnOrderHistory.TabIndex = 0;
            this.uiBtnOrderHistory.Text = "Historia zamówień";
            this.uiBtnOrderHistory.UseVisualStyleBackColor = true;
            this.uiBtnOrderHistory.Click += new System.EventHandler(this.uiBtnOrderHistory_Click);
            // 
            // uiBtnSendOrder
            // 
            this.uiBtnSendOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBtnSendOrder.Location = new System.Drawing.Point(182, 22);
            this.uiBtnSendOrder.Name = "uiBtnSendOrder";
            this.uiBtnSendOrder.Size = new System.Drawing.Size(173, 23);
            this.uiBtnSendOrder.TabIndex = 1;
            this.uiBtnSendOrder.Text = "Wyślij zamówienie";
            this.uiBtnSendOrder.UseVisualStyleBackColor = true;
            this.uiBtnSendOrder.Click += new System.EventHandler(this.uiBtnSendOrder_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 538);
            this.Controls.Add(this.uiTlpMainLayout);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zamówienie";
            this.uiTlpMainLayout.ResumeLayout(false);
            this.uiPnlEmail.ResumeLayout(false);
            this.uiPnlEmail.PerformLayout();
            this.uiPnlShoppingCard.ResumeLayout(false);
            this.uiPnlShoppingCard.PerformLayout();
            this.uiTlpHistoryAndSendOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel uiTlpMainLayout;
        private System.Windows.Forms.FlowLayoutPanel uiFlpFood;
        private System.Windows.Forms.Panel uiPnlEmail;
        private System.Windows.Forms.TextBox uiTxtEmail;
        private System.Windows.Forms.Label uiLblSetEmail;
        private System.Windows.Forms.Panel uiPnlShoppingCard;
        private System.Windows.Forms.Label uiLblOrderCost;
        private System.Windows.Forms.TextBox uiTxtOrderCost;
        private System.Windows.Forms.CheckedListBox uiClbShopingCard;
        private System.Windows.Forms.TextBox uiTxtAttentionToOrder;
        private System.Windows.Forms.Label uiLblAttentionToOrder;
        private System.Windows.Forms.Button uiBtnDelete;
        private System.Windows.Forms.TableLayoutPanel uiTlpHistoryAndSendOrder;
        private System.Windows.Forms.Button uiBtnOrderHistory;
        private System.Windows.Forms.Button uiBtnSendOrder;
    }
}