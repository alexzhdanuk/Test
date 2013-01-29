namespace TestTask
{
    partial class GeneralForm
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
            this.components = new System.ComponentModel.Container();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.GridViewMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddGridViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DelGridViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeneralMenu = new System.Windows.Forms.MenuStrip();
            this.FileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectToBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.GeneralPage = new System.Windows.Forms.TabPage();
            this.FindPage = new System.Windows.Forms.TabPage();
            this.FindButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FindDatePicker = new System.Windows.Forms.DateTimePicker();
            this.FindImText = new System.Windows.Forms.TextBox();
            this.FindFamText = new System.Windows.Forms.TextBox();
            this.FindDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.GridViewMenuStrip.SuspendLayout();
            this.GeneralMenu.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.GeneralPage.SuspendLayout();
            this.FindPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FindDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.ContextMenuStrip = this.GridViewMenuStrip;
            this.DataGridView.Location = new System.Drawing.Point(6, 3);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(557, 216);
            this.DataGridView.TabIndex = 0;
            // 
            // GridViewMenuStrip
            // 
            this.GridViewMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddGridViewMenuItem,
            this.toolStripSeparator2,
            this.DelGridViewMenuItem,
            this.InfoToolStripMenuItem});
            this.GridViewMenuStrip.Name = "contextMenuStrip1";
            this.GridViewMenuStrip.Size = new System.Drawing.Size(167, 76);
            // 
            // AddGridViewMenuItem
            // 
            this.AddGridViewMenuItem.Name = "AddGridViewMenuItem";
            this.AddGridViewMenuItem.Size = new System.Drawing.Size(166, 22);
            this.AddGridViewMenuItem.Text = "Добавить запись";
            this.AddGridViewMenuItem.Click += new System.EventHandler(this.AddGridViewMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(163, 6);
            // 
            // DelGridViewMenuItem
            // 
            this.DelGridViewMenuItem.Name = "DelGridViewMenuItem";
            this.DelGridViewMenuItem.Size = new System.Drawing.Size(166, 22);
            this.DelGridViewMenuItem.Text = "Удалить запись";
            this.DelGridViewMenuItem.Click += new System.EventHandler(this.DelGridViewMenuItem_Click);
            // 
            // InfoToolStripMenuItem
            // 
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.InfoToolStripMenuItem.Text = "Подробнее";
            this.InfoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // GeneralMenu
            // 
            this.GeneralMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileStripMenuItem});
            this.GeneralMenu.Location = new System.Drawing.Point(0, 0);
            this.GeneralMenu.Name = "GeneralMenu";
            this.GeneralMenu.Size = new System.Drawing.Size(571, 24);
            this.GeneralMenu.TabIndex = 1;
            this.GeneralMenu.Text = "MenuGridView";
            // 
            // FileStripMenuItem
            // 
            this.FileStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectToBaseToolStripMenuItem,
            this.toolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.FileStripMenuItem.Name = "FileStripMenuItem";
            this.FileStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileStripMenuItem.Text = "Файл";
            // 
            // ConnectToBaseToolStripMenuItem
            // 
            this.ConnectToBaseToolStripMenuItem.Name = "ConnectToBaseToolStripMenuItem";
            this.ConnectToBaseToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.ConnectToBaseToolStripMenuItem.Text = "Подключение к базе данных";
            this.ConnectToBaseToolStripMenuItem.Click += new System.EventHandler(this.ConnectToBaseToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(228, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.GeneralPage);
            this.TabControl.Controls.Add(this.FindPage);
            this.TabControl.Location = new System.Drawing.Point(0, 27);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(571, 248);
            this.TabControl.TabIndex = 2;
            // 
            // GeneralPage
            // 
            this.GeneralPage.Controls.Add(this.DataGridView);
            this.GeneralPage.Location = new System.Drawing.Point(4, 22);
            this.GeneralPage.Name = "GeneralPage";
            this.GeneralPage.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralPage.Size = new System.Drawing.Size(563, 222);
            this.GeneralPage.TabIndex = 0;
            this.GeneralPage.Text = "Главная";
            this.GeneralPage.UseVisualStyleBackColor = true;
            // 
            // FindPage
            // 
            this.FindPage.Controls.Add(this.FindButton);
            this.FindPage.Controls.Add(this.label3);
            this.FindPage.Controls.Add(this.label2);
            this.FindPage.Controls.Add(this.label1);
            this.FindPage.Controls.Add(this.FindDatePicker);
            this.FindPage.Controls.Add(this.FindImText);
            this.FindPage.Controls.Add(this.FindFamText);
            this.FindPage.Controls.Add(this.FindDataGridView);
            this.FindPage.Location = new System.Drawing.Point(4, 22);
            this.FindPage.Name = "FindPage";
            this.FindPage.Padding = new System.Windows.Forms.Padding(3);
            this.FindPage.Size = new System.Drawing.Size(563, 222);
            this.FindPage.TabIndex = 1;
            this.FindPage.Text = "Поиск";
            this.FindPage.UseVisualStyleBackColor = true;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(225, 26);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 7;
            this.FindButton.Text = "Поиск";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата рождения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Фамилия";
            // 
            // FindDatePicker
            // 
            this.FindDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FindDatePicker.Location = new System.Drawing.Point(100, 60);
            this.FindDatePicker.Name = "FindDatePicker";
            this.FindDatePicker.Size = new System.Drawing.Size(100, 20);
            this.FindDatePicker.TabIndex = 3;
            this.FindDatePicker.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // FindImText
            // 
            this.FindImText.Location = new System.Drawing.Point(100, 33);
            this.FindImText.Name = "FindImText";
            this.FindImText.Size = new System.Drawing.Size(100, 20);
            this.FindImText.TabIndex = 2;
            // 
            // FindFamText
            // 
            this.FindFamText.Location = new System.Drawing.Point(100, 6);
            this.FindFamText.Name = "FindFamText";
            this.FindFamText.Size = new System.Drawing.Size(100, 20);
            this.FindFamText.TabIndex = 1;
            // 
            // FindDataGridView
            // 
            this.FindDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FindDataGridView.Location = new System.Drawing.Point(0, 95);
            this.FindDataGridView.Name = "FindDataGridView";
            this.FindDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FindDataGridView.Size = new System.Drawing.Size(563, 128);
            this.FindDataGridView.TabIndex = 0;
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 275);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.GeneralMenu);
            this.MainMenuStrip = this.GeneralMenu;
            this.Name = "GeneralForm";
            this.Text = "Главное окно";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GeneralForm_FormClosed);
            this.Shown += new System.EventHandler(this.GeneralForm_Shown);
            this.Resize += new System.EventHandler(this.GeneralForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.GridViewMenuStrip.ResumeLayout(false);
            this.GeneralMenu.ResumeLayout(false);
            this.GeneralMenu.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.GeneralPage.ResumeLayout(false);
            this.FindPage.ResumeLayout(false);
            this.FindPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FindDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.MenuStrip GeneralMenu;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage GeneralPage;
        private System.Windows.Forms.TabPage FindPage;
        private System.Windows.Forms.ToolStripMenuItem FileStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConnectToBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip GridViewMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddGridViewMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem DelGridViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem;
        private System.Windows.Forms.TextBox FindImText;
        private System.Windows.Forms.TextBox FindFamText;
        private System.Windows.Forms.DataGridView FindDataGridView;
        private System.Windows.Forms.DateTimePicker FindDatePicker;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

