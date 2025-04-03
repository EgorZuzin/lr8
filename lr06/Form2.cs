using lr06.ModelEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lr06
{
    public partial class Form2 : Form
    {
        public Model1 db { get; set; }

        public Form2(Model1 DB_)
        {
            InitializeComponent();
            db = DB_;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Нужно ввести все требуемые данные!");
                return;
            }
            // преобразуем данные из textBox1 (поля ID) в целый тип
            int id;
            bool b = int.TryParse(textBox1.Text, out id);
            if (b == false)
            {
                MessageBox.Show("Неверный формат ID - " + textBox1.Text);
                return;
            }

            int Vladelec;
            bool a = int.TryParse(textBox4.Text, out Vladelec);
            if (a == false)
            {
                MessageBox.Show("Неверный формат Vladelec - " + textBox4.Text);
                return;
            }
            // добавление новой записи в таблицу БД
            // создаем новый объект для коллекции Roles
            kv rl = new kv();
            // задаем свойства объекта
            rl.ID = id;
            rl.Vladelec = textBox2.Text;
            rl.Размер = textBox3.Text;
            rl.Vozvrast = Vladelec;
            if (rl != null)


                // добавляем новый объект к коллекции
                db.kv.Add(rl);
            try
            {
                // сохраняем изменения коллекции в БД
                db.SaveChanges();
                // задаем свойство DialogResult, чтобы закрыть форму
                DialogResult = DialogResult.OK;
                MessageBox.Show("Запись добавлена");
                Form1 f = new Form1();
                f.Show();
                this.Close();

            }
            catch (Exception ex)
            { // сложная конструкция для показа сообщений сервера БД
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}

