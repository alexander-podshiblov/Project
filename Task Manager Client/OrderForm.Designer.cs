﻿namespace Task_Manager_Client
{
    partial class OrderForm
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
            this.commOrdPanel = new System.Windows.Forms.TableLayoutPanel();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.sendCommButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.failButton = new System.Windows.Forms.Button();
            this.updateCommButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commOrdPanel
            // 
            this.commOrdPanel.AutoScroll = true;
            this.commOrdPanel.ColumnCount = 1;
            this.commOrdPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.commOrdPanel.Location = new System.Drawing.Point(12, 12);
            this.commOrdPanel.Name = "commOrdPanel";
            this.commOrdPanel.RowCount = 1;
            this.commOrdPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commOrdPanel.Size = new System.Drawing.Size(480, 350);
            this.commOrdPanel.TabIndex = 0;
            // 
            // commentBox
            // 
            this.commentBox.AcceptsReturn = true;
            this.commentBox.AcceptsTab = true;
            this.commentBox.Enabled = false;
            this.commentBox.Location = new System.Drawing.Point(13, 369);
            this.commentBox.Multiline = true;
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(479, 111);
            this.commentBox.TabIndex = 1;
            // 
            // sendCommButton
            // 
            this.sendCommButton.Enabled = false;
            this.sendCommButton.Location = new System.Drawing.Point(13, 486);
            this.sendCommButton.Name = "sendCommButton";
            this.sendCommButton.Size = new System.Drawing.Size(350, 23);
            this.sendCommButton.TabIndex = 2;
            this.sendCommButton.Text = "Send Comment";
            this.sendCommButton.UseVisualStyleBackColor = true;
            this.sendCommButton.Click += new System.EventHandler(this.sendCommButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Enabled = false;
            this.acceptButton.Location = new System.Drawing.Point(499, 13);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 3;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // failButton
            // 
            this.failButton.Enabled = false;
            this.failButton.Location = new System.Drawing.Point(499, 43);
            this.failButton.Name = "failButton";
            this.failButton.Size = new System.Drawing.Size(75, 23);
            this.failButton.TabIndex = 4;
            this.failButton.Text = "It\'s Failed";
            this.failButton.UseVisualStyleBackColor = true;
            this.failButton.Click += new System.EventHandler(this.failButton_Click);
            // 
            // updateCommButton
            // 
            this.updateCommButton.Location = new System.Drawing.Point(369, 486);
            this.updateCommButton.Name = "updateCommButton";
            this.updateCommButton.Size = new System.Drawing.Size(123, 23);
            this.updateCommButton.TabIndex = 5;
            this.updateCommButton.Text = "Refresh";
            this.updateCommButton.UseVisualStyleBackColor = true;
            this.updateCommButton.Click += new System.EventHandler(this.updateCommButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 521);
            this.Controls.Add(this.updateCommButton);
            this.Controls.Add(this.failButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.sendCommButton);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.commOrdPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel commOrdPanel;
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.Button sendCommButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button failButton;
        private System.Windows.Forms.Button updateCommButton;
    }
}