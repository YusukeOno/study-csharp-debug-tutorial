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

            while (!parser.EndOfData)
            {
                string[] row = parser.ReadFields(); // 1行読み込み
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
