using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormLesson_2 {
    public enum ButClick {
        Ok,
        Cancel,
        Help
    }
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }
        public ButClick ButClick = ButClick.Ok;
        private void Form2_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            ButClick = ButClick.Ok;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            ButClick = ButClick.Cancel;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) {
            ButClick = ButClick.Help;
            this.Close();
        }
    }
}
