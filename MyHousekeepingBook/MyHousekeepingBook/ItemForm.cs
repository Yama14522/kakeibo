using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHousekeepingBook
{
    public partial class ItemForm : Form
    {
        /// <summary>
        /// ItemFromの処理
        /// Form1.csのAddData()サブルーチンに送るデータ
        /// </summary>
        /// <param name="dsCategory"></param>
        public ItemForm(CategoryDataSet dsCategory)
        {
            InitializeComponent();
            categoryDataSet.Merge(dsCategory);
        }

        /// <summary>
        /// ItemFormの処理
        /// Form1.csのUpdateData()サブルーチンに送るデータ
        /// </summary>
        /// <param name="dsCategory"></param>
        /// <param name="nowDate"></param>
        /// <param name="category"></param>
        /// <param name="item"></param>
        /// <param name="money"></param>
        /// <param name="remarks"></param>
        public ItemForm(CategoryDataSet dsCategory,
                        DateTime nowDate,
                        string category,
                        string item,
                        int money,
                        string remarks)
        {
            InitializeComponent();
            categoryDataSet.Merge(dsCategory);
            monCalendar.SetDate(nowDate);
            cmbCategory.Text = category;
            txtItem.Text = item;
            mtxtMoney.Text = money.ToString();
            txtRemarks.Text = remarks;
        }
    }
}
