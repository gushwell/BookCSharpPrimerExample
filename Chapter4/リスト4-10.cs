using System;
using System.Windows.Forms;

namespace AsSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            foreach (Control control in this.Controls) {
                // 書き方1
                if (control is TextBox) {
                    TextBox tb = (TextBox)control;
                    tb.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            foreach (Control control in this.Controls) {
                // 書き方2
                if ( control is TextBox ) {
                    TextBox tb = control as TextBox;
                    tb.Text = "" ;
                }
            }
        }
    }
}
