namespace Task_Manager_Client
{
    partial class AddTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.toBox = new System.Windows.Forms.ComboBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.deadlinePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To:";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(70, 13);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(382, 20);
            this.titleBox.TabIndex = 2;
            // 
            // toBox
            // 
            this.toBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toBox.FormattingEnabled = true;
            this.toBox.Location = new System.Drawing.Point(70, 65);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(382, 21);
            this.toBox.TabIndex = 3;
            // 
            // textBox
            // 
            this.textBox.AcceptsReturn = true;
            this.textBox.Location = new System.Drawing.Point(70, 92);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(382, 172);
            this.textBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Text:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(377, 270);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add Task";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deadlinePicker
            // 
            this.deadlinePicker.Checked = false;
            this.deadlinePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.deadlinePicker.Location = new System.Drawing.Point(70, 39);
            this.deadlinePicker.Name = "deadlinePicker";
            this.deadlinePicker.Size = new System.Drawing.Size(382, 20);
            this.deadlinePicker.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Deadline:";
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 307);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deadlinePicker);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.toBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Task";
            this.Load += new System.EventHandler(this.AddTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.ComboBox toBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DateTimePicker deadlinePicker;
        private System.Windows.Forms.Label label4;
    }
}