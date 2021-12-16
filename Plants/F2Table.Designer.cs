namespace Plants
{
    partial class F2Table
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F2Table));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.семействоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.родDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.назначениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.территорияПроизрастанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колличествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.растенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plansDataSet = new Plants.PlansDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.функцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьТаблицуРастенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.функцииToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поискРастенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.растенияTableAdapter = new Plants.PlansDataSetTableAdapters.РастенияTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.растенияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plansDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(248, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Растения ботанического сада";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.семействоDataGridViewTextBoxColumn,
            this.видDataGridViewTextBoxColumn,
            this.родDataGridViewTextBoxColumn,
            this.назначениеDataGridViewTextBoxColumn,
            this.территорияПроизрастанияDataGridViewTextBoxColumn,
            this.колличествоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.растенияBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 175);
            this.dataGridView1.TabIndex = 1;
            // 
            // номерDataGridViewTextBoxColumn
            // 
            this.номерDataGridViewTextBoxColumn.DataPropertyName = "Номер";
            this.номерDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.номерDataGridViewTextBoxColumn.Name = "номерDataGridViewTextBoxColumn";
            this.номерDataGridViewTextBoxColumn.Width = 50;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // семействоDataGridViewTextBoxColumn
            // 
            this.семействоDataGridViewTextBoxColumn.DataPropertyName = "Семейство";
            this.семействоDataGridViewTextBoxColumn.HeaderText = "Семейство";
            this.семействоDataGridViewTextBoxColumn.Name = "семействоDataGridViewTextBoxColumn";
            // 
            // видDataGridViewTextBoxColumn
            // 
            this.видDataGridViewTextBoxColumn.DataPropertyName = "Вид";
            this.видDataGridViewTextBoxColumn.HeaderText = "Вид";
            this.видDataGridViewTextBoxColumn.Name = "видDataGridViewTextBoxColumn";
            // 
            // родDataGridViewTextBoxColumn
            // 
            this.родDataGridViewTextBoxColumn.DataPropertyName = "Род";
            this.родDataGridViewTextBoxColumn.HeaderText = "Род";
            this.родDataGridViewTextBoxColumn.Name = "родDataGridViewTextBoxColumn";
            // 
            // назначениеDataGridViewTextBoxColumn
            // 
            this.назначениеDataGridViewTextBoxColumn.DataPropertyName = "Назначение";
            this.назначениеDataGridViewTextBoxColumn.HeaderText = "Назначение";
            this.назначениеDataGridViewTextBoxColumn.Name = "назначениеDataGridViewTextBoxColumn";
            // 
            // территорияПроизрастанияDataGridViewTextBoxColumn
            // 
            this.территорияПроизрастанияDataGridViewTextBoxColumn.DataPropertyName = "Территория произрастания";
            this.территорияПроизрастанияDataGridViewTextBoxColumn.HeaderText = "Территория произрастания";
            this.территорияПроизрастанияDataGridViewTextBoxColumn.Name = "территорияПроизрастанияDataGridViewTextBoxColumn";
            // 
            // колличествоDataGridViewTextBoxColumn
            // 
            this.колличествоDataGridViewTextBoxColumn.DataPropertyName = "Колличество";
            this.колличествоDataGridViewTextBoxColumn.HeaderText = "Колличество";
            this.колличествоDataGridViewTextBoxColumn.Name = "колличествоDataGridViewTextBoxColumn";
            // 
            // растенияBindingSource
            // 
            this.растенияBindingSource.DataMember = "Растения";
            this.растенияBindingSource.DataSource = this.plansDataSet;
            // 
            // plansDataSet
            // 
            this.plansDataSet.DataSetName = "PlansDataSet";
            this.plansDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Chartreuse;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.функцииToolStripMenuItem,
            this.функцииToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // функцииToolStripMenuItem
            // 
            this.функцииToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.функцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьТаблицуРастенийToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.функцииToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.функцииToolStripMenuItem.Name = "функцииToolStripMenuItem";
            this.функцииToolStripMenuItem.Size = new System.Drawing.Size(190, 25);
            this.функцииToolStripMenuItem.Text = "Работа с растениями";
            // 
            // открытьТаблицуРастенийToolStripMenuItem
            // 
            this.открытьТаблицуРастенийToolStripMenuItem.Name = "открытьТаблицуРастенийToolStripMenuItem";
            this.открытьТаблицуРастенийToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.открытьТаблицуРастенийToolStripMenuItem.Text = "Добавить ";
            this.открытьТаблицуРастенийToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.выходToolStripMenuItem.Text = "Удалить";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // функцииToolStripMenuItem1
            // 
            this.функцииToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискРастенияToolStripMenuItem});
            this.функцииToolStripMenuItem1.Name = "функцииToolStripMenuItem1";
            this.функцииToolStripMenuItem1.Size = new System.Drawing.Size(94, 25);
            this.функцииToolStripMenuItem1.Text = "Функции";
            // 
            // поискРастенияToolStripMenuItem
            // 
            this.поискРастенияToolStripMenuItem.Name = "поискРастенияToolStripMenuItem";
            this.поискРастенияToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.поискРастенияToolStripMenuItem.Text = "Поиск растения";
            this.поискРастенияToolStripMenuItem.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrchid;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(649, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrchid;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить растение";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkOrchid;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(15, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(251, 48);
            this.button3.TabIndex = 8;
            this.button3.Text = "Удалить растение";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(23, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 142);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Работа с растениями";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkOrchid;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(358, 322);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(251, 46);
            this.button4.TabIndex = 9;
            this.button4.Text = "Поиск растения";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // растенияTableAdapter
            // 
            this.растенияTableAdapter.ClearBeforeFill = true;
            // 
            // F2Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F2Table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Растения ботанического сада";
            this.Load += new System.EventHandler(this.F2Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.растенияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plansDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem функцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьТаблицуРастенийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem функцииToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поискРастенияToolStripMenuItem;
        private PlansDataSet plansDataSet;
        private System.Windows.Forms.BindingSource растенияBindingSource;
        private PlansDataSetTableAdapters.РастенияTableAdapter растенияTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn семействоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn родDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn назначениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn территорияПроизрастанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колличествоDataGridViewTextBoxColumn;
    }
}