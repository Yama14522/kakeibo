
namespace MyHousekeepingBook
{
    partial class Form1
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.日付DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.分類DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.金額DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備考DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moneyDataSet = new MyHousekeepingBook.MoneyDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbList = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbSummary = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.日付DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入金合計DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出金合計DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.summaryDataSet = new MyHousekeepingBook.SummaryDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.追加TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.変更CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.削除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.表示VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一覧表示LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.集計表示SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryDataSet1 = new MyHousekeepingBook.CategoryDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbList.SuspendLayout();
            this.tbSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.summaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.日付DataGridViewTextBoxColumn,
            this.分類DataGridViewTextBoxColumn,
            this.品名DataGridViewTextBoxColumn,
            this.金額DataGridViewTextBoxColumn,
            this.備考DataGridViewTextBoxColumn});
            this.dgv.DataSource = this.moneyDataTableBindingSource;
            this.dgv.Location = new System.Drawing.Point(6, 6);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 27;
            this.dgv.Size = new System.Drawing.Size(1426, 788);
            this.dgv.TabIndex = 0;
            // 
            // 日付DataGridViewTextBoxColumn
            // 
            this.日付DataGridViewTextBoxColumn.DataPropertyName = "日付";
            this.日付DataGridViewTextBoxColumn.HeaderText = "日付";
            this.日付DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.日付DataGridViewTextBoxColumn.Name = "日付DataGridViewTextBoxColumn";
            this.日付DataGridViewTextBoxColumn.Width = 150;
            // 
            // 分類DataGridViewTextBoxColumn
            // 
            this.分類DataGridViewTextBoxColumn.DataPropertyName = "分類";
            this.分類DataGridViewTextBoxColumn.HeaderText = "分類";
            this.分類DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.分類DataGridViewTextBoxColumn.Name = "分類DataGridViewTextBoxColumn";
            this.分類DataGridViewTextBoxColumn.Width = 150;
            // 
            // 品名DataGridViewTextBoxColumn
            // 
            this.品名DataGridViewTextBoxColumn.DataPropertyName = "品名";
            this.品名DataGridViewTextBoxColumn.HeaderText = "品名";
            this.品名DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.品名DataGridViewTextBoxColumn.Name = "品名DataGridViewTextBoxColumn";
            this.品名DataGridViewTextBoxColumn.Width = 150;
            // 
            // 金額DataGridViewTextBoxColumn
            // 
            this.金額DataGridViewTextBoxColumn.DataPropertyName = "金額";
            this.金額DataGridViewTextBoxColumn.HeaderText = "金額";
            this.金額DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.金額DataGridViewTextBoxColumn.Name = "金額DataGridViewTextBoxColumn";
            this.金額DataGridViewTextBoxColumn.Width = 150;
            // 
            // 備考DataGridViewTextBoxColumn
            // 
            this.備考DataGridViewTextBoxColumn.DataPropertyName = "備考";
            this.備考DataGridViewTextBoxColumn.HeaderText = "備考";
            this.備考DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.備考DataGridViewTextBoxColumn.Name = "備考DataGridViewTextBoxColumn";
            this.備考DataGridViewTextBoxColumn.Width = 150;
            // 
            // moneyDataTableBindingSource
            // 
            this.moneyDataTableBindingSource.DataMember = "moneyDataTable";
            this.moneyDataTableBindingSource.DataSource = this.moneyDataSet;
            // 
            // moneyDataSet
            // 
            this.moneyDataSet.DataSetName = "MoneyDataSet";
            this.moneyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbList);
            this.tabControl1.Controls.Add(this.tbSummary);
            this.tabControl1.Location = new System.Drawing.Point(12, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1454, 869);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tbList
            // 
            this.tbList.Controls.Add(this.btnDelete);
            this.tbList.Controls.Add(this.btnEnd);
            this.tbList.Controls.Add(this.btnChange);
            this.tbList.Controls.Add(this.btnAdd);
            this.tbList.Controls.Add(this.dgv);
            this.tbList.Location = new System.Drawing.Point(4, 28);
            this.tbList.Name = "tbList";
            this.tbList.Padding = new System.Windows.Forms.Padding(3);
            this.tbList.Size = new System.Drawing.Size(1446, 837);
            this.tbList.TabIndex = 0;
            this.tbList.Text = "一覧表示";
            this.tbList.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(270, 800);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(1306, 800);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(126, 30);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(138, 800);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(126, 30);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "変更";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 800);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "追加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbSummary
            // 
            this.tbSummary.Controls.Add(this.dataGridView1);
            this.tbSummary.Location = new System.Drawing.Point(4, 28);
            this.tbSummary.Name = "tbSummary";
            this.tbSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tbSummary.Size = new System.Drawing.Size(1446, 837);
            this.tbSummary.TabIndex = 1;
            this.tbSummary.Text = "集計表示";
            this.tbSummary.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.日付DataGridViewTextBoxColumn1,
            this.入金合計DataGridViewTextBoxColumn,
            this.出金合計DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sumDataTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1426, 816);
            this.dataGridView1.TabIndex = 0;
            // 
            // 日付DataGridViewTextBoxColumn1
            // 
            this.日付DataGridViewTextBoxColumn1.DataPropertyName = "日付";
            this.日付DataGridViewTextBoxColumn1.HeaderText = "日付";
            this.日付DataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.日付DataGridViewTextBoxColumn1.Name = "日付DataGridViewTextBoxColumn1";
            this.日付DataGridViewTextBoxColumn1.Width = 150;
            // 
            // 入金合計DataGridViewTextBoxColumn
            // 
            this.入金合計DataGridViewTextBoxColumn.DataPropertyName = "入金合計";
            this.入金合計DataGridViewTextBoxColumn.HeaderText = "入金合計";
            this.入金合計DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.入金合計DataGridViewTextBoxColumn.Name = "入金合計DataGridViewTextBoxColumn";
            this.入金合計DataGridViewTextBoxColumn.Width = 150;
            // 
            // 出金合計DataGridViewTextBoxColumn
            // 
            this.出金合計DataGridViewTextBoxColumn.DataPropertyName = "出金合計";
            this.出金合計DataGridViewTextBoxColumn.HeaderText = "出金合計";
            this.出金合計DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.出金合計DataGridViewTextBoxColumn.Name = "出金合計DataGridViewTextBoxColumn";
            this.出金合計DataGridViewTextBoxColumn.Width = 150;
            // 
            // sumDataTableBindingSource
            // 
            this.sumDataTableBindingSource.DataMember = "SumDataTable";
            this.sumDataTableBindingSource.DataSource = this.summaryDataSet;
            // 
            // summaryDataSet
            // 
            this.summaryDataSet.DataSetName = "SummaryDataSet";
            this.summaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyHousekeepingBook.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(1241, 922);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 193);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // mainMenu
            // 
            this.mainMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.編集EToolStripMenuItem,
            this.表示VToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1478, 33);
            this.mainMenu.TabIndex = 3;
            this.mainMenu.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存SToolStripMenuItem,
            this.終了XToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.保存SToolStripMenuItem.Text = "保存(&S)";
            this.保存SToolStripMenuItem.Click += new System.EventHandler(this.保存SToolStripMenuItem_Click);
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.終了XToolStripMenuItem.Text = "終了(&X)";
            this.終了XToolStripMenuItem.Click += new System.EventHandler(this.終了XToolStripMenuItem_Click);
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.追加TToolStripMenuItem,
            this.変更CToolStripMenuItem,
            this.削除DToolStripMenuItem});
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.編集EToolStripMenuItem.Text = "編集(&E)";
            // 
            // 追加TToolStripMenuItem
            // 
            this.追加TToolStripMenuItem.Name = "追加TToolStripMenuItem";
            this.追加TToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.追加TToolStripMenuItem.Text = "追加(&A)";
            this.追加TToolStripMenuItem.Click += new System.EventHandler(this.追加AToolStripMenuItemClick);
            // 
            // 変更CToolStripMenuItem
            // 
            this.変更CToolStripMenuItem.Name = "変更CToolStripMenuItem";
            this.変更CToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.変更CToolStripMenuItem.Text = "変更(&C)";
            this.変更CToolStripMenuItem.Click += new System.EventHandler(this.変更CToolStripMenuItem_Click);
            // 
            // 削除DToolStripMenuItem
            // 
            this.削除DToolStripMenuItem.Name = "削除DToolStripMenuItem";
            this.削除DToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.削除DToolStripMenuItem.Text = "削除(&D)";
            this.削除DToolStripMenuItem.Click += new System.EventHandler(this.削除DToolStripMenuItem_Click);
            // 
            // 表示VToolStripMenuItem
            // 
            this.表示VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.一覧表示LToolStripMenuItem,
            this.集計表示SToolStripMenuItem});
            this.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem";
            this.表示VToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.表示VToolStripMenuItem.Text = "表示(&V)";
            // 
            // 一覧表示LToolStripMenuItem
            // 
            this.一覧表示LToolStripMenuItem.Name = "一覧表示LToolStripMenuItem";
            this.一覧表示LToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.一覧表示LToolStripMenuItem.Text = "一覧表示(&L)";
            this.一覧表示LToolStripMenuItem.Click += new System.EventHandler(this.一覧表示LToolStripMenuItem_Click);
            // 
            // 集計表示SToolStripMenuItem
            // 
            this.集計表示SToolStripMenuItem.Name = "集計表示SToolStripMenuItem";
            this.集計表示SToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.集計表示SToolStripMenuItem.Text = "集計表示(&S)";
            this.集計表示SToolStripMenuItem.Click += new System.EventHandler(this.集計表示SToolStripMenuItem_Click);
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョン情報VToolStripMenuItem});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // バージョン情報VToolStripMenuItem
            // 
            this.バージョン情報VToolStripMenuItem.Name = "バージョン情報VToolStripMenuItem";
            this.バージョン情報VToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.バージョン情報VToolStripMenuItem.Text = "バージョン情報(&V)";
            // 
            // categoryDataSet1
            // 
            this.categoryDataSet1.DataSetName = "CategoryDataSet";
            this.categoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 1127);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.Text = "簡易家計簿";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbList.ResumeLayout(false);
            this.tbSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.summaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日付DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 分類DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 金額DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備考DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource moneyDataTableBindingSource;
        private MoneyDataSet moneyDataSet;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbList;
        private System.Windows.Forms.TabPage tbSummary;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 追加TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 変更CToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem 削除DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 表示VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一覧表示LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 集計表示SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報VToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日付DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入金合計DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出金合計DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sumDataTableBindingSource;
        private SummaryDataSet summaryDataSet;
        private CategoryDataSet categoryDataSet1;
    }
}