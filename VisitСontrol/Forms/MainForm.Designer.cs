namespace VisitСontrol
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.dtpThisDay = new System.Windows.Forms.DateTimePicker();
            this.labelThisDay = new System.Windows.Forms.Label();
            this.lblLastLeaving = new System.Windows.Forms.Label();
            this.lblReturnedFromLunch = new System.Windows.Forms.Label();
            this.lblLeftForLunch = new System.Windows.Forms.Label();
            this.lblFirstVisit = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.cmbxEmployee = new System.Windows.Forms.ComboBox();
            this.tbxLastLeaving = new System.Windows.Forms.TextBox();
            this.tbxReturnedFromLunch = new System.Windows.Forms.TextBox();
            this.tbxLeftForLunch = new System.Windows.Forms.TextBox();
            this.tbxFirstVisit = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.referenceToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // referenceToolStripMenuItem
            // 
            this.referenceToolStripMenuItem.Name = "referenceToolStripMenuItem";
            this.referenceToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.referenceToolStripMenuItem.Text = "Справка";
            this.referenceToolStripMenuItem.Click += new System.EventHandler(this.referenceToolStripMenuItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.pbxLogo);
            this.mainPanel.Controls.Add(this.dtpThisDay);
            this.mainPanel.Controls.Add(this.labelThisDay);
            this.mainPanel.Controls.Add(this.lblLastLeaving);
            this.mainPanel.Controls.Add(this.lblReturnedFromLunch);
            this.mainPanel.Controls.Add(this.lblLeftForLunch);
            this.mainPanel.Controls.Add(this.lblFirstVisit);
            this.mainPanel.Controls.Add(this.labelFIO);
            this.mainPanel.Controls.Add(this.cmbxEmployee);
            this.mainPanel.Controls.Add(this.tbxLastLeaving);
            this.mainPanel.Controls.Add(this.tbxReturnedFromLunch);
            this.mainPanel.Controls.Add(this.tbxLeftForLunch);
            this.mainPanel.Controls.Add(this.tbxFirstVisit);
            this.mainPanel.Controls.Add(this.btnClear);
            this.mainPanel.Controls.Add(this.btnSave);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainPanel.Location = new System.Drawing.Point(584, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(200, 537);
            this.mainPanel.TabIndex = 1;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::VisitСontrol.Properties.Resources.logo;
            this.pbxLogo.Location = new System.Drawing.Point(6, 55);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(182, 105);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 5;
            this.pbxLogo.TabStop = false;
            // 
            // dtpThisDay
            // 
            this.dtpThisDay.Location = new System.Drawing.Point(6, 214);
            this.dtpThisDay.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpThisDay.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpThisDay.Name = "dtpThisDay";
            this.dtpThisDay.Size = new System.Drawing.Size(182, 20);
            this.dtpThisDay.TabIndex = 21;
            // 
            // labelThisDay
            // 
            this.labelThisDay.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThisDay.Location = new System.Drawing.Point(6, 163);
            this.labelThisDay.Name = "labelThisDay";
            this.labelThisDay.Size = new System.Drawing.Size(182, 48);
            this.labelThisDay.TabIndex = 3;
            this.labelThisDay.Text = "Выберите сегодняшнее число";
            this.labelThisDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastLeaving
            // 
            this.lblLastLeaving.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.lblLastLeaving.Location = new System.Drawing.Point(6, 375);
            this.lblLastLeaving.Name = "lblLastLeaving";
            this.lblLastLeaving.Size = new System.Drawing.Size(182, 20);
            this.lblLastLeaving.TabIndex = 3;
            this.lblLastLeaving.Text = "Ушел с работы";
            this.lblLastLeaving.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReturnedFromLunch
            // 
            this.lblReturnedFromLunch.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.lblReturnedFromLunch.Location = new System.Drawing.Point(6, 329);
            this.lblReturnedFromLunch.Name = "lblReturnedFromLunch";
            this.lblReturnedFromLunch.Size = new System.Drawing.Size(182, 20);
            this.lblReturnedFromLunch.TabIndex = 3;
            this.lblReturnedFromLunch.Text = "Вернулся с обеда";
            this.lblReturnedFromLunch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLeftForLunch
            // 
            this.lblLeftForLunch.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.lblLeftForLunch.Location = new System.Drawing.Point(6, 283);
            this.lblLeftForLunch.Name = "lblLeftForLunch";
            this.lblLeftForLunch.Size = new System.Drawing.Size(182, 20);
            this.lblLeftForLunch.TabIndex = 3;
            this.lblLeftForLunch.Text = "Ушел на обед";
            this.lblLeftForLunch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstVisit
            // 
            this.lblFirstVisit.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.lblFirstVisit.Location = new System.Drawing.Point(6, 237);
            this.lblFirstVisit.Name = "lblFirstVisit";
            this.lblFirstVisit.Size = new System.Drawing.Size(182, 20);
            this.lblFirstVisit.TabIndex = 3;
            this.lblFirstVisit.Text = "Пришел на работу";
            this.lblFirstVisit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFIO
            // 
            this.labelFIO.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.Location = new System.Drawing.Point(6, 0);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(182, 25);
            this.labelFIO.TabIndex = 3;
            this.labelFIO.Text = "Выберите сотрудника";
            this.labelFIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbxEmployee
            // 
            this.cmbxEmployee.DisplayMember = "ID";
            this.cmbxEmployee.FormattingEnabled = true;
            this.cmbxEmployee.Location = new System.Drawing.Point(6, 28);
            this.cmbxEmployee.Name = "cmbxEmployee";
            this.cmbxEmployee.Size = new System.Drawing.Size(182, 21);
            this.cmbxEmployee.TabIndex = 10;
            this.cmbxEmployee.ValueMember = "ID";
            // 
            // tbxLastLeaving
            // 
            this.tbxLastLeaving.Location = new System.Drawing.Point(6, 398);
            this.tbxLastLeaving.Name = "tbxLastLeaving";
            this.tbxLastLeaving.Size = new System.Drawing.Size(182, 20);
            this.tbxLastLeaving.TabIndex = 65;
            // 
            // tbxReturnedFromLunch
            // 
            this.tbxReturnedFromLunch.Location = new System.Drawing.Point(6, 352);
            this.tbxReturnedFromLunch.Name = "tbxReturnedFromLunch";
            this.tbxReturnedFromLunch.Size = new System.Drawing.Size(182, 20);
            this.tbxReturnedFromLunch.TabIndex = 54;
            // 
            // tbxLeftForLunch
            // 
            this.tbxLeftForLunch.Location = new System.Drawing.Point(6, 306);
            this.tbxLeftForLunch.Name = "tbxLeftForLunch";
            this.tbxLeftForLunch.Size = new System.Drawing.Size(182, 20);
            this.tbxLeftForLunch.TabIndex = 43;
            // 
            // tbxFirstVisit
            // 
            this.tbxFirstVisit.Location = new System.Drawing.Point(6, 260);
            this.tbxFirstVisit.Name = "tbxFirstVisit";
            this.tbxFirstVisit.Size = new System.Drawing.Size(182, 20);
            this.tbxFirstVisit.TabIndex = 32;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(6, 502);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(182, 23);
            this.btnClear.TabIndex = 98;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(6, 473);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(182, 23);
            this.btnSave.TabIndex = 87;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mainDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.mainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDataGridView.Location = new System.Drawing.Point(0, 24);
            this.mainDataGridView.MultiSelect = false;
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.Size = new System.Drawing.Size(584, 537);
            this.mainDataGridView.TabIndex = 1;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mainDataGridView);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenceToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.ComboBox cmbxEmployee;
        private System.Windows.Forms.TextBox tbxFirstVisit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelThisDay;
        private System.Windows.Forms.DateTimePicker dtpThisDay;
        private System.Windows.Forms.Label lblLastLeaving;
        private System.Windows.Forms.Label lblReturnedFromLunch;
        private System.Windows.Forms.Label lblLeftForLunch;
        private System.Windows.Forms.Label lblFirstVisit;
        private System.Windows.Forms.TextBox tbxLastLeaving;
        private System.Windows.Forms.TextBox tbxReturnedFromLunch;
        private System.Windows.Forms.TextBox tbxLeftForLunch;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

