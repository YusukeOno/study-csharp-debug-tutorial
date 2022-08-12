using Microsoft.VisualBasic.FileIO;
using System;
using System.Text;
using System.Windows.Forms;

namespace Csv2DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); // DGV初期化

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    csvFilePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); // DGV初期化

            TextFieldParser parser = new TextFieldParser(csvFilePath.Text, Encoding.GetEncoding("Shift_JIS"))
            {
                TextFieldType = FieldType.Delimited
            };
            parser.SetDelimiters(","); // 区切り文字はコンマ

            int i = 0;  // CSV行カウント
            bool errorFlg = false;
            while (!parser.EndOfData)
            {
                string[] row = parser.ReadFields(); // 1行読み込み
                dataGridView1.Rows.Add(row);

                // CSVエラーチェック（列ごとにチェック）
                for(int j = 0; j < row.Length; j++)
                {
                    // 1列目のチェック
                    if (j == 0)
                    {
                        // 必須であること
                        if (String.IsNullOrEmpty(row[j])){
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Yellow;
                            errorFlg = true;
                        }
                        // 数値であること
                        if (!int.TryParse(row[j], out int num))
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Yellow;
                            errorFlg = true;
                        }
                    }
                    // 2列目のチェック
                    if (j == 1)
                    {
                        // 必須チェック
                        if (String.IsNullOrEmpty(row[j]))
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Yellow;
                            errorFlg = true;
                        }
                    }
                    // 14列目のチェック
                    if (j == 13)
                    {
                        // 数値5桁であること
                        if (row[j].ToString().Length != 5)
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Yellow;
                            errorFlg = true;
                        }
                    }
                }
                i++;
            }

            if (errorFlg == true)
            {
                MessageBox.Show("Error!");
                return;
            }

            MessageBox.Show("OK!");
            return;
        }
    }
}
