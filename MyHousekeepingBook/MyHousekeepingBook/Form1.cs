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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// [追加]をクリックしたときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData();
        }

        /// <summary>
        /// [編集]メニューの[追加]をクリックしたときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 追加AToolStripMenuItemClick(object sender, EventArgs e)
        {
            AddData();
        }

        /// <summary>
        /// AddData()サブルーチン
        /// 登録画面での処理
        /// </summary>
        private void AddData()
        {
            ItemForm frmItem = new ItemForm(categoryDataSet1);
            DialogResult drRet = frmItem.ShowDialog();
            if (drRet == DialogResult.OK)
            {
                moneyDataSet.moneyDataTable.AddmoneyDataTableRow(
                            frmItem.monCalendar.SelectionRange.Start,
                            frmItem.cmbCategory.Text,
                            frmItem.txtItem.Text,
                            int.Parse(frmItem.mtxtMoney.Text),
                            frmItem.txtRemarks.Text);
            }
        }

        /// <summary>
        /// Form1_Load()サブルーチン
        /// フォーム起動時に画面表示時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            categoryDataSet1.categoryDataTable.AddcategoryDataTableRow("給料", "入金");
            categoryDataSet1.categoryDataTable.AddcategoryDataTableRow("食費", "出金");
            categoryDataSet1.categoryDataTable.AddcategoryDataTableRow("雑費", "出金");
            categoryDataSet1.categoryDataTable.AddcategoryDataTableRow("住居", "出金");
        }

        /// <summary>
        /// [終了]ボタンをクリックしたときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// [ファイル]メニューの[終了]をクリックしたときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// SaveData()サブルーチン
        /// ファイルへ出力する処理
        /// </summary>
        private void SaveData()
        {
            string path = "MoneyData.csv";  // 出力データ
            string strData = ""; // 1行分のデータ
            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                                    path,
                                    false,
                                    System.Text.Encoding.Default);
            foreach (MoneyDataSet.moneyDataTableRow drMoney
                        in moneyDataSet.moneyDataTable)
            {
                strData = drMoney.日付.ToShortDateString() + ","
                        + drMoney.分類 + ","
                        + drMoney.品名 + ","
                        + drMoney.金額.ToString() + ","
                        + drMoney.備考;
                sw.WriteLine(strData);
            }
            sw.Close();
        }

        /// <summary>
        /// [ファイル]メニューの[保存]をクリックしたときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        /// <summary>
        /// 生成されたフォームを閉じる処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, EventArgs e)
        {
            SaveData();
        }

        /// <summary>
        /// LoadData()サブルーチン
        /// CSVファイルがなくなるまで読み込む処理を繰り返す
        /// </summary>
        private void LoadData()
        {
            string path = "MoneyData.csv";
            string delimStr = ",";
            char[] delimiter = delimStr.ToCharArray();
            string[] strData;
            string strLine;
            bool fileExists = System.IO.File.Exists(path);
            if (fileExists)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(
                                                path,
                                                System.Text.Encoding.Default);
                while(sr.Peek() >= 0)
                {
                    strLine = sr.ReadLine();
                    strData = strLine.Split(delimiter);
                    moneyDataSet.moneyDataTable.AddmoneyDataTableRow(
                                                DateTime.Parse(strData[0]),
                                                strData[1],
                                                strData[2],
                                                int.Parse(strData[3]),
                                                strData[4]);
                }
                sr.Close();
            }
        }

        /// <summary>
        /// UpdateData()サブルーチン
        /// データを追加・変更する処理
        /// </summary>
        private void UpdateData()
        {
            int nowRow = dgv.CurrentRow.Index;
            DateTime oldDate
                    = DateTime.Parse(dgv.Rows[nowRow].Cells[0].Value.ToString());
            string oldCategory = dgv.Rows[nowRow].Cells[1].Value.ToString();
            string oldItem = dgv.Rows[nowRow].Cells[2].Value.ToString();
            int oldMoney
                = int.Parse(dgv.Rows[nowRow].Cells[3].Value.ToString());
            string oldRemarks = dgv.Rows[nowRow].Cells[4].Value.ToString();
            ItemForm frmItem = new ItemForm(categoryDataSet1,
                                            oldDate,
                                            oldCategory,
                                            oldItem,
                                            oldMoney,
                                            oldRemarks);
            DialogResult drRet = frmItem.ShowDialog();
            if (drRet == DialogResult.OK)
            {
                dgv.Rows[nowRow].Cells[0].Value
                                        = frmItem.monCalendar.SelectionRange.Start;
                dgv.Rows[nowRow].Cells[1].Value = frmItem.cmbCategory.Text;
                dgv.Rows[nowRow].Cells[2].Value = frmItem.txtItem.Text;
                dgv.Rows[nowRow].Cells[3].Value = int.Parse(frmItem.mtxtMoney.Text);
                dgv.Rows[nowRow].Cells[4].Value = frmItem.txtRemarks.Text;
            }
        }

        /// <summary>
        /// [変更]ボタンをクリックしたときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        /// <summary>
        /// [編集]メニューの[変更]をクリックしたときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 変更CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        /// <summary>
        /// DeleteData()サブルーチン
        /// データの削除処理
        /// </summary>
        private void DeleteData()
        {
            int nowRow = dgv.CurrentRow.Index;
            dgv.Rows.RemoveAt(nowRow);
        }

        /// <summary>
        /// [削除]ボタンをクリックしたときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        /// <summary>
        /// [編集]メニューの[削除]をクリックしたときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 削除DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        /// <summary>
        /// CalcSummary()サブルーチン
        /// 金額を日付ごとに集計する処理
        /// </summary>
        private void CalcSummary()
        {
            string expression;
            summaryDataSet.SumDataTable.Clear();
            foreach (MoneyDataSet.moneyDataTableRow drMoney
                    in moneyDataSet.moneyDataTable)
            {
                expression = "日付= '" + drMoney.日付.ToShortDateString() + "'";
                SummaryDataSet.SumDataTableRow[] curDR
                    = (SummaryDataSet.SumDataTableRow[])
                        summaryDataSet.SumDataTable.Select(expression);
                if (curDR.Length == 0)
                {
                    CategoryDataSet.categoryDataTableRow[] selectedDataRow;
                    selectedDataRow = (CategoryDataSet.categoryDataTableRow[])
                                        categoryDataSet1.categoryDataTable.Select(
                                            "分類='" + drMoney.分類 + "'");
                    if (selectedDataRow[0].入出金分類 == "入金")
                    {
                        summaryDataSet.SumDataTable.AddSumDataTableRow(drMoney.日付,
                                                                       drMoney.金額,
                                                                       0);
                    }
                    else if (selectedDataRow[0].入出金分類 == "出金")
                    {
                        summaryDataSet.SumDataTable.AddSumDataTableRow(drMoney.日付,
                                                                       0,
                                                                       drMoney.金額);
                    }
                }
                else
                {
                    CategoryDataSet.categoryDataTableRow[] selectedDataRow;
                    selectedDataRow = (CategoryDataSet.categoryDataTableRow[])
                                        categoryDataSet1.categoryDataTable.Select(
                                            "分類='" + drMoney.分類 + "'");
                    if (selectedDataRow[0].入出金分類 == "入金")
                    {
                        curDR[0].入金合計 += drMoney.金額;
                    }
                    else if (selectedDataRow[0].入出金分類 == "出金")
                    {
                        curDR[0].出金合計 += drMoney.金額;
                    }
                }
            }
        }

        /// <summary>
        /// CalcSummary()サブルーチンを呼び出す処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcSummary();
        }
        
        /// <summary>
        /// [一覧表示]タブをクリックしたときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 一覧表示LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tbList);
        }
        
        /// <summary>
        /// [集計表示]タブをクリックしたときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 集計表示SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tbSummary);
        }
    }
}
