namespace lab4
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lab4DataSet = new lab4.lab4DataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выборкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.срокВкладаНеМенееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычислениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.суммаНачислений8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lab4DataSet1 = new lab4.lab4DataSet();
            this.информацияОКлиентахBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.информация_о_клиентахTableAdapter = new lab4.lab4DataSetTableAdapters.Информация_о_клиентахTableAdapter();
            this.банкРасчётныйСчётDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.банкDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фирмаРасчётныйСчётDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаВкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фирмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.срокмесDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фирмаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фирмаTableAdapter = new lab4.lab4DataSetTableAdapters.ФирмаTableAdapter();
            this.tableAdapterManager = new lab4.lab4DataSetTableAdapters.TableAdapterManager();
            this.фирмаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.групповаяОперацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.банкBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.банкTableAdapter = new lab4.lab4DataSetTableAdapters.БанкTableAdapter();
            this.банкDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lab4DataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОКлиентахBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фирмаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фирмаDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.банкBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.банкDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lab4DataSet
            // 
            this.lab4DataSet.DataSetName = "lab4DataSet";
            this.lab4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выборкаToolStripMenuItem,
            this.вычислениеToolStripMenuItem,
            this.групповаяОперацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выборкаToolStripMenuItem
            // 
            this.выборкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.срокВкладаНеМенееToolStripMenuItem,
            this.сортировкаToolStripMenuItem});
            this.выборкаToolStripMenuItem.Name = "выборкаToolStripMenuItem";
            this.выборкаToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.выборкаToolStripMenuItem.Text = "Выборка";
            // 
            // срокВкладаНеМенееToolStripMenuItem
            // 
            this.срокВкладаНеМенееToolStripMenuItem.Name = "срокВкладаНеМенееToolStripMenuItem";
            this.срокВкладаНеМенееToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.срокВкладаНеМенееToolStripMenuItem.Text = "Срок вклада не менее 3 мес.";
            this.срокВкладаНеМенееToolStripMenuItem.Click += new System.EventHandler(this.срокВкладаНеМенееToolStripMenuItem_Click);
            // 
            // вычислениеToolStripMenuItem
            // 
            this.вычислениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.суммаНачислений8ToolStripMenuItem});
            this.вычислениеToolStripMenuItem.Name = "вычислениеToolStripMenuItem";
            this.вычислениеToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.вычислениеToolStripMenuItem.Text = "Вычисление";
            this.вычислениеToolStripMenuItem.Click += new System.EventHandler(this.вычислениеToolStripMenuItem_Click);
            // 
            // суммаНачислений8ToolStripMenuItem
            // 
            this.суммаНачислений8ToolStripMenuItem.Name = "суммаНачислений8ToolStripMenuItem";
            this.суммаНачислений8ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.суммаНачислений8ToolStripMenuItem.Text = "Сумма начислений 8%";
            this.суммаНачислений8ToolStripMenuItem.Click += new System.EventHandler(this.суммаНачислений8ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.банкРасчётныйСчётDataGridViewTextBoxColumn,
            this.странаDataGridViewTextBoxColumn,
            this.банкDataGridViewTextBoxColumn,
            this.фирмаРасчётныйСчётDataGridViewTextBoxColumn,
            this.суммаВкладаDataGridViewTextBoxColumn,
            this.фирмаDataGridViewTextBoxColumn,
            this.срокмесDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.информацияОКлиентахBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(759, 196);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lab4DataSet1
            // 
            this.lab4DataSet1.DataSetName = "lab4DataSet";
            this.lab4DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // информацияОКлиентахBindingSource
            // 
            this.информацияОКлиентахBindingSource.DataMember = "Информация о клиентах";
            this.информацияОКлиентахBindingSource.DataSource = this.lab4DataSet1;
            // 
            // информация_о_клиентахTableAdapter
            // 
            this.информация_о_клиентахTableAdapter.ClearBeforeFill = true;
            // 
            // банкРасчётныйСчётDataGridViewTextBoxColumn
            // 
            this.банкРасчётныйСчётDataGridViewTextBoxColumn.DataPropertyName = "Банк_Расчётный счёт";
            this.банкРасчётныйСчётDataGridViewTextBoxColumn.HeaderText = "Банк_Расчётный счёт";
            this.банкРасчётныйСчётDataGridViewTextBoxColumn.Name = "банкРасчётныйСчётDataGridViewTextBoxColumn";
            // 
            // странаDataGridViewTextBoxColumn
            // 
            this.странаDataGridViewTextBoxColumn.DataPropertyName = "Страна";
            this.странаDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.странаDataGridViewTextBoxColumn.Name = "странаDataGridViewTextBoxColumn";
            // 
            // банкDataGridViewTextBoxColumn
            // 
            this.банкDataGridViewTextBoxColumn.DataPropertyName = "Банк";
            this.банкDataGridViewTextBoxColumn.HeaderText = "Банк";
            this.банкDataGridViewTextBoxColumn.Name = "банкDataGridViewTextBoxColumn";
            // 
            // фирмаРасчётныйСчётDataGridViewTextBoxColumn
            // 
            this.фирмаРасчётныйСчётDataGridViewTextBoxColumn.DataPropertyName = "Фирма_Расчётный счёт";
            this.фирмаРасчётныйСчётDataGridViewTextBoxColumn.HeaderText = "Фирма_Расчётный счёт";
            this.фирмаРасчётныйСчётDataGridViewTextBoxColumn.Name = "фирмаРасчётныйСчётDataGridViewTextBoxColumn";
            // 
            // суммаВкладаDataGridViewTextBoxColumn
            // 
            this.суммаВкладаDataGridViewTextBoxColumn.DataPropertyName = "Сумма вклада";
            this.суммаВкладаDataGridViewTextBoxColumn.HeaderText = "Сумма вклада";
            this.суммаВкладаDataGridViewTextBoxColumn.Name = "суммаВкладаDataGridViewTextBoxColumn";
            // 
            // фирмаDataGridViewTextBoxColumn
            // 
            this.фирмаDataGridViewTextBoxColumn.DataPropertyName = "Фирма";
            this.фирмаDataGridViewTextBoxColumn.HeaderText = "Фирма";
            this.фирмаDataGridViewTextBoxColumn.Name = "фирмаDataGridViewTextBoxColumn";
            // 
            // срокмесDataGridViewTextBoxColumn
            // 
            this.срокмесDataGridViewTextBoxColumn.DataPropertyName = "Срок(мес)";
            this.срокмесDataGridViewTextBoxColumn.HeaderText = "Срок(мес)";
            this.срокмесDataGridViewTextBoxColumn.Name = "срокмесDataGridViewTextBoxColumn";
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            this.сортировкаToolStripMenuItem.Click += new System.EventHandler(this.сортировкаToolStripMenuItem_Click);
            // 
            // фирмаBindingSource
            // 
            this.фирмаBindingSource.DataMember = "Фирма";
            this.фирмаBindingSource.DataSource = this.lab4DataSet1;
            // 
            // фирмаTableAdapter
            // 
            this.фирмаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = lab4.lab4DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БанкTableAdapter = this.банкTableAdapter;
            this.tableAdapterManager.ФирмаTableAdapter = this.фирмаTableAdapter;
            // 
            // фирмаDataGridView
            // 
            this.фирмаDataGridView.AutoGenerateColumns = false;
            this.фирмаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.фирмаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.фирмаDataGridView.DataSource = this.фирмаBindingSource;
            this.фирмаDataGridView.Location = new System.Drawing.Point(12, 245);
            this.фирмаDataGridView.Name = "фирмаDataGridView";
            this.фирмаDataGridView.Size = new System.Drawing.Size(456, 108);
            this.фирмаDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Расчётный счёт";
            this.dataGridViewTextBoxColumn1.HeaderText = "Расчётный счёт";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Сумма вклада";
            this.dataGridViewTextBoxColumn2.HeaderText = "Сумма вклада";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Фирма";
            this.dataGridViewTextBoxColumn3.HeaderText = "Фирма";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Срок(мес)";
            this.dataGridViewTextBoxColumn4.HeaderText = "Срок(мес)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // групповаяОперацияToolStripMenuItem
            // 
            this.групповаяОперацияToolStripMenuItem.Name = "групповаяОперацияToolStripMenuItem";
            this.групповаяОперацияToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.групповаяОперацияToolStripMenuItem.Text = "Групповая операция";
            this.групповаяОперацияToolStripMenuItem.Click += new System.EventHandler(this.групповаяОперацияToolStripMenuItem_Click);
            // 
            // банкBindingSource
            // 
            this.банкBindingSource.DataMember = "Банк";
            this.банкBindingSource.DataSource = this.lab4DataSet1;
            // 
            // банкTableAdapter
            // 
            this.банкTableAdapter.ClearBeforeFill = true;
            // 
            // банкDataGridView
            // 
            this.банкDataGridView.AutoGenerateColumns = false;
            this.банкDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.банкDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.банкDataGridView.DataSource = this.банкBindingSource;
            this.банкDataGridView.Location = new System.Drawing.Point(12, 359);
            this.банкDataGridView.Name = "банкDataGridView";
            this.банкDataGridView.Size = new System.Drawing.Size(387, 140);
            this.банкDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Расчётный счёт";
            this.dataGridViewTextBoxColumn5.HeaderText = "Расчётный счёт";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Страна";
            this.dataGridViewTextBoxColumn6.HeaderText = "Страна";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Банк";
            this.dataGridViewTextBoxColumn7.HeaderText = "Банк";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 670);
            this.Controls.Add(this.банкDataGridView);
            this.Controls.Add(this.фирмаDataGridView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Лабораторная 4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lab4DataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОКлиентахBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фирмаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фирмаDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.банкBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.банкDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lab4DataSet lab4DataSet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выборкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem срокВкладаНеМенееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вычислениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem суммаНачислений8ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private lab4DataSet lab4DataSet1;
        private System.Windows.Forms.BindingSource информацияОКлиентахBindingSource;
        private lab4DataSetTableAdapters.Информация_о_клиентахTableAdapter информация_о_клиентахTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn банкРасчётныйСчётDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn банкDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фирмаРасчётныйСчётDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаВкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фирмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn срокмесDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.BindingSource фирмаBindingSource;
        private lab4DataSetTableAdapters.ФирмаTableAdapter фирмаTableAdapter;
        private lab4DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView фирмаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripMenuItem групповаяОперацияToolStripMenuItem;
        private lab4DataSetTableAdapters.БанкTableAdapter банкTableAdapter;
        private System.Windows.Forms.BindingSource банкBindingSource;
        private System.Windows.Forms.DataGridView банкDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}

