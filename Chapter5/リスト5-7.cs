using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QueueSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private Queue<string> _queue = new Queue<string>();
        private Timer _timer = new Timer();
        private Random _rnd = new Random();

        private void Form1_Load(object sender, EventArgs e) {
            _timer.Tick += new EventHandler(_timer_Tick);
            _timer.Interval = 1000;
            _timer.Start();
            textBox1.Text = "1234";
        }

        private void button1_Click(object sender, EventArgs e) {
            foreach (var s in textBox1.Lines) {
                if (!string.IsNullOrEmpty(s))
                    // キューにデータを入れる
                    _queue.Enqueue(s);
            }
            textBox1.Text = _rnd.Next(1,10000).ToString();
        }

        void _timer_Tick(object sender, EventArgs e) {
            if (_queue.Count > 0) {
                // キューからデータを一つだけ取り出す。
                string s = _queue.Dequeue();
                listBox1.Items.Add(s);
            }
        }
    }
}
