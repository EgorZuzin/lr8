using lr06.Model1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr06
{
    public partial class Form3 : Form
    {
        public Model1.Model1 db { get; set; }
        // свойство для передачи объекта корректируемой записи
        public kv rl { get; set; }
        // private поле в классе, доступно во всех методах
        kv kv;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = kv.ID.ToString();
            textBox2.Text = kv.Vladelec;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kv.Vladelec = textBox2.Text;
            // если бы свойств было бы больше, то они сохранялись здесь ...
            // теперь пытаемся сохранить измененный объект в БД
            try
            {
                // сохраняем изменения, сделанные в объектах коллекции в БД
                db.SaveChanges();
                // задаем свойство DialogResult, чтобы закрыть форму
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            { // если произошла ошибка - сообщаем
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }
    }
}
