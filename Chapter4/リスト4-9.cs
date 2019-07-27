using System;
using System.Windows.Forms;

namespace AsSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            foreach (Control control in this.Controls) {
                TextBox tb = control as TextBox;
                if (tb != null) {
                    tb.Text = "";
                }
            }
        }
    }
}
