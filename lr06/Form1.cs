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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lr06DataSet.kv". При необходимости она может быть перемещена или удалена.
            this.kvTableAdapter.Fill(this.lr06DataSet.kv);

        }

        private void button1_Click(object sender, EventArgs e, Model1.Model1 kv)
        {
            Form3 frm = new Form3();
            // Находим объект, который выбрал пользователь (текущий)
            kv rl = (kv)kvBindingSource.Current;
            // передаем данные в форму
            frm.db = kv;
            frm.rl = rl;
            // Показываем форму в диалоговом режиме
            DialogResult dr = frm.ShowDialog();
            // если измененные данные сохранены в БД, то таблицу обновим
            if (dr == DialogResult.OK)
            {
                kvBindingSource.DataSource = rl.Vladelec.ToList();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}