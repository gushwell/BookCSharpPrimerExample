using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToWareki {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int dc;
            if (int.TryParse(textBox1.Text, out dc) == false) {
                MessageBox.Show("数値を入力してください");
                return;
            }
            if (dc < 1868) {
                MessageBox.Show("1868年以降が対象です");
                return;
            }
            string s = ToWareki(dc);    // (*) ブレーク・ポイント設定
            label2.Text = s;
        }

        private static string ToWareki(int dc) {
            int[] years = { 1868, 1912, 1926, 1989, int.MaxValue };
            string[] eras = { "明治", "大正", "昭和", "平成" };
            int i = 0;
            while (dc >= years[i]) {
                i++;

            }
            i--;
            int year = dc - years[i] + 1;
            string s = string.Format("{0}{1}年", eras[i], year);
            return s;
        }
    }
}

