
namespace MyHousekeepingBook
{
    partial class ItemForm
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
            this.monCalendar = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtMoney = new System.Windows.Forms.MaskedTextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.categoryDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryDataSet = new MyHousekeepingBook.CategoryDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // monCalendar
            // 
            this.monCalendar.Location = new System.Drawing.Point(18, 18);
            this.monCalendar.Name = "monCalendar";
            this.monCalendar.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(113, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "登録";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(401, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "キャンセル";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "分類";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "品名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "金額";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "備考";
            // 
            // mtxtMoney
            // 
            this.mtxtMoney.Location = new System.Drawing.Point(401, 171);
            this.mtxtMoney.Mask = "999999";
            this.mtxtMoney.Name = "mtxtMoney";
            this.mtxtMoney.Size = new System.Drawing.Size(150, 25);
            this.mtxtMoney.TabIndex = 7;
            this.mtxtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(401, 92);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(150, 25);
            this.txtItem.TabIndex = 8;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(401, 250);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(150, 25);
            this.txtRemarks.TabIndex = 9;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DataSource = this.categoryDataTableBindingSource;
            this.cmbCategory.DisplayMember = "分類";
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(401, 20);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(175, 26);
            this.cmbCategory.TabIndex = 10;
            // 
            // categoryDataTableBindingSource
            // 
            this.categoryDataTableBindingSource.DataMember = "categoryDataTable";
            this.categoryDataTableBindingSource.DataSource = this.categoryDataSet;
            // 
            // categoryDataSet
            // 
            this.categoryDataSet.DataSetName = "CategoryDataSet";
            this.categoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 324);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.mtxtMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monCalendar);
            this.Name = "ItemForm";
            this.Text = "登録";
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.MonthCalendar monCalendar;
        public System.Windows.Forms.MaskedTextBox mtxtMoney;
        public System.Windows.Forms.TextBox txtItem;
        public System.Windows.Forms.TextBox txtRemarks;
        public System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.BindingSource categoryDataTableBindingSource;
        private CategoryDataSet categoryDataSet;
    }
}