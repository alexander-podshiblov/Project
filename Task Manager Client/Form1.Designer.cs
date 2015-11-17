namespace Task_Manager_Client
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab = new System.Windows.Forms.TabControl();
            this.myTasks = new System.Windows.Forms.TabPage();
            this.updateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.statusTaskBox = new System.Windows.Forms.ComboBox();
            this.openTaskButton = new System.Windows.Forms.Button();
            this.tasksView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.myOrders = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.openButton = new System.Windows.Forms.Button();
            this.ordersView = new System.Windows.Forms.ListView();
            this.titleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deadlineHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addTaskButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeServerIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab.SuspendLayout();
            this.myTasks.SuspendLayout();
            this.myOrders.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.myTasks);
            this.tab.Controls.Add(this.myOrders);
            this.tab.Location = new System.Drawing.Point(12, 42);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(600, 417);
            this.tab.TabIndex = 0;
            // 
            // myTasks
            // 
            this.myTasks.Controls.Add(this.updateButton);
            this.myTasks.Controls.Add(this.label2);
            this.myTasks.Controls.Add(this.statusTaskBox);
            this.myTasks.Controls.Add(this.openTaskButton);
            this.myTasks.Controls.Add(this.tasksView);
            this.myTasks.Location = new System.Drawing.Point(4, 22);
            this.myTasks.Name = "myTasks";
            this.myTasks.Padding = new System.Windows.Forms.Padding(3);
            this.myTasks.Size = new System.Drawing.Size(592, 391);
            this.myTasks.TabIndex = 0;
            this.myTasks.Text = "My Tasks";
            this.myTasks.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(510, 361);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Refresh";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Status of tasks:";
            // 
            // statusTaskBox
            // 
            this.statusTaskBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusTaskBox.FormattingEnabled = true;
            this.statusTaskBox.Items.AddRange(new object[] {
            "Active",
            "Done",
            "Failed",
            "<All>"});
            this.statusTaskBox.Location = new System.Drawing.Point(225, 363);
            this.statusTaskBox.Name = "statusTaskBox";
            this.statusTaskBox.Size = new System.Drawing.Size(121, 21);
            this.statusTaskBox.TabIndex = 6;
            this.statusTaskBox.SelectedIndexChanged += new System.EventHandler(this.statusTaskBox_SelectedIndexChanged);
            // 
            // openTaskButton
            // 
            this.openTaskButton.Location = new System.Drawing.Point(6, 361);
            this.openTaskButton.Name = "openTaskButton";
            this.openTaskButton.Size = new System.Drawing.Size(75, 23);
            this.openTaskButton.TabIndex = 5;
            this.openTaskButton.Text = "Open";
            this.openTaskButton.UseVisualStyleBackColor = true;
            this.openTaskButton.Click += new System.EventHandler(this.openTaskButton_Click);
            // 
            // tasksView
            // 
            this.tasksView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.tasksView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.tasksView.Location = new System.Drawing.Point(6, 6);
            this.tasksView.MultiSelect = false;
            this.tasksView.Name = "tasksView";
            this.tasksView.Size = new System.Drawing.Size(579, 349);
            this.tasksView.TabIndex = 2;
            this.tasksView.UseCompatibleStateImageBehavior = false;
            this.tasksView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 171;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "From";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 152;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 98;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Deadline";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 84;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Status";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 57;
            // 
            // myOrders
            // 
            this.myOrders.AutoScroll = true;
            this.myOrders.Controls.Add(this.label1);
            this.myOrders.Controls.Add(this.statusBox);
            this.myOrders.Controls.Add(this.openButton);
            this.myOrders.Controls.Add(this.ordersView);
            this.myOrders.Controls.Add(this.addTaskButton);
            this.myOrders.Location = new System.Drawing.Point(4, 22);
            this.myOrders.Name = "myOrders";
            this.myOrders.Padding = new System.Windows.Forms.Padding(3);
            this.myOrders.Size = new System.Drawing.Size(592, 391);
            this.myOrders.TabIndex = 1;
            this.myOrders.Text = "My Orders";
            this.myOrders.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status of tasks:";
            // 
            // statusBox
            // 
            this.statusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Active",
            "Done",
            "Failed",
            "<All>"});
            this.statusBox.Location = new System.Drawing.Point(225, 363);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(121, 21);
            this.statusBox.TabIndex = 3;
            this.statusBox.SelectedIndexChanged += new System.EventHandler(this.statusBox_SelectedIndexChanged);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(6, 361);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // ordersView
            // 
            this.ordersView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleHeader,
            this.toHeader,
            this.dateHeader,
            this.deadlineHeader,
            this.statusHeader});
            this.ordersView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ordersView.Location = new System.Drawing.Point(6, 6);
            this.ordersView.MultiSelect = false;
            this.ordersView.Name = "ordersView";
            this.ordersView.Size = new System.Drawing.Size(579, 349);
            this.ordersView.TabIndex = 1;
            this.ordersView.UseCompatibleStateImageBehavior = false;
            this.ordersView.View = System.Windows.Forms.View.Details;
            // 
            // titleHeader
            // 
            this.titleHeader.Text = "Title";
            this.titleHeader.Width = 171;
            // 
            // toHeader
            // 
            this.toHeader.Text = "Executor";
            this.toHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toHeader.Width = 152;
            // 
            // dateHeader
            // 
            this.dateHeader.Text = "Date";
            this.dateHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateHeader.Width = 98;
            // 
            // deadlineHeader
            // 
            this.deadlineHeader.Text = "Deadline";
            this.deadlineHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deadlineHeader.Width = 84;
            // 
            // statusHeader
            // 
            this.statusHeader.Text = "Status";
            this.statusHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusHeader.Width = 57;
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(511, 361);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(75, 23);
            this.addTaskButton.TabIndex = 0;
            this.addTaskButton.Text = "Add";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signInToolStripMenuItem,
            this.changeServerIPToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // signInToolStripMenuItem
            // 
            this.signInToolStripMenuItem.Name = "signInToolStripMenuItem";
            this.signInToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.signInToolStripMenuItem.Text = "Sign In";
            this.signInToolStripMenuItem.Click += new System.EventHandler(this.signInToolStripMenuItem_Click);
            // 
            // changeServerIPToolStripMenuItem
            // 
            this.changeServerIPToolStripMenuItem.Name = "changeServerIPToolStripMenuItem";
            this.changeServerIPToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.changeServerIPToolStripMenuItem.Text = "Change server IP";
            this.changeServerIPToolStripMenuItem.Click += new System.EventHandler(this.changeServerIPToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 471);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tab.ResumeLayout(false);
            this.myTasks.ResumeLayout(false);
            this.myTasks.PerformLayout();
            this.myOrders.ResumeLayout(false);
            this.myOrders.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage myTasks;
        private System.Windows.Forms.TabPage myOrders;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.ListView ordersView;
        private System.Windows.Forms.ColumnHeader titleHeader;
        private System.Windows.Forms.ColumnHeader toHeader;
        private System.Windows.Forms.ColumnHeader dateHeader;
        private System.Windows.Forms.ColumnHeader deadlineHeader;
        private System.Windows.Forms.ColumnHeader statusHeader;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox statusTaskBox;
        private System.Windows.Forms.Button openTaskButton;
        private System.Windows.Forms.ListView tasksView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeServerIPToolStripMenuItem;
    }
}

