using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLesson_2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 500000;
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e) {
            this.Close();
        }
        public ComboBox ComboBox = new ComboBox();
        private void button1_Click(object sender, EventArgs e) {
            Form1 form1 = new Form1();
            Form form = new Form();
            Button button = new Button();
            button.Text = "Кнопка";
            button.Location = new Point(form.Width / 2, form.Height / 2);
            ComboBox comboBox = new ComboBox();
            comboBox.Location = new Point(form.Width / 2, form.Height / 2 - button.Height - 5);
            ComboBox = comboBox;
            form.Controls.Add(button);
            form.Controls.Add(comboBox);
            button.Click += Button_Click1;
            button.Click += Button_Click;
            
            form1.Show();
            void Button_Click1(object sender, EventArgs e) {
                comboBox.Items.Add("Третий");
                Form2 form2 = new Form2();
                form2.ShowDialog();

            }
            form.ShowDialog();

        }

       

        private void Button_Click(object sender, EventArgs e) {
            ComboBox.Items.Add("Первый");
            ComboBox.Items.Add("Второй");
            ComboBox.Text = "Выберите значение";
            ComboBox.Text = ComboBox.Items[0].ToString();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Dispose();
        }
    }
}
