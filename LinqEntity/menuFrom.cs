using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using CodeFirst;
using LinqEntity.Entity;
using MySql.Data.MySqlClient;



namespace LinqEntity
{
    public partial class menuForm : Form
    {
        agentModel dbcontex = new agentModel();

        BindingList<client> clients;
        List<program> programs;

        public menuForm()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            loadClient();
        }

        private void loadClient()
        {
            try
            {
                dbcontex.client.Load();
                clients = dbcontex.client.Local.ToBindingList();

                // Заполняем 
                dataGridView1.DataSource = clients;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
                      

        // Добавление
        private void tbAdd_Click(object sender, EventArgs e)
        {
            AddClientForm ClientTab = new AddClientForm();
            DialogResult result = ClientTab.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            client client = new client();
            client.fio = ClientTab.textBox_fio.Text;

            var s = ClientTab.textBox_pas.Text;
            client.pass = Convert.ToInt32(s);
            client.born = ClientTab.dateTimePicker_born.Value;

            var id = ClientTab.textBox_id.Text;
            client.idclient = Convert.ToInt32(id);
            dbcontex.client.Add(client);
            dbcontex.SaveChanges();

            MessageBox.Show("Новый объект добавлен");
        }


        // Изменение
        private void tbEdit_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow(dataGridView1);
            if (index != -1)
            {
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                client client = dbcontex.client.Where(i => i.idclient == id).FirstOrDefault();
                if (client != null)
                {

                    AddClientForm ClientTab = new AddClientForm();

                    ClientTab.textBox_fio.Text = client.fio;
                    ClientTab.textBox_pas.Text = client.pass.Value.ToString();
                    ClientTab.dateTimePicker_born.Text = client.born.ToString();
                    ClientTab.textBox_id.Text = client.idclient.ToString();
                    DialogResult result = ClientTab.ShowDialog(this);

                    if (result == DialogResult.Cancel)
                        return;

                    client.fio = ClientTab.textBox_fio.Text;

                    var s = ClientTab.textBox_pas.Text;
                    client.pass = Convert.ToInt32(s);
                    client.born = ClientTab.dateTimePicker_born.Value;

                    var idClient = ClientTab.textBox_id.Text;
                    client.idclient = Convert.ToInt32(idClient);

                    dbcontex.SaveChanges();
                    dataGridView1.Refresh(); // обновляем грид
                    MessageBox.Show("Объект обновлен");
                }
            }
        }

        // Удаление
        private void tbDel_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow(dataGridView1);
            if (index != -1)
            {
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                client client = dbcontex.client.Where(i => i.idclient == id).FirstOrDefault();
                if (client != null)
                {
                    dbcontex.client.Remove(client);
                    dbcontex.SaveChanges();
                }

            }
        }

        //Linq
        private void tbRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                var request = dbcontex.contract
                    .Where(i => i.client.fio == textBox_pass.Text)
                    .Select(i => new { i.client.fio, i.client.pass, i.client.born, i.program.name, i.price, i.program.discount, })
                    .ToList();
                dataGridView3.DataSource = request;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Выбор 
        private int getSelectedRow(DataGridView dataGridView)
        {
            int index = -1;
            if (dataGridView.SelectedRows.Count > 0 || dataGridView.SelectedCells.Count == 1)
            {
                if (dataGridView.SelectedRows.Count > 0)
                    index = dataGridView.SelectedRows[0].Index;
                else index = dataGridView.SelectedCells[0].RowIndex;
            }
            return index;
        }


        private void tbSave_Click(object sender, EventArgs e)
        {
            bool res = Validate();
            if (res)
            {
                dbcontex.SaveChanges();
                dataGridView1.Refresh();
            }
        }

        private void tbPrint_Click(object sender, EventArgs e)
        {
            dbcontex.program.Load();
            programs = dbcontex.program.Local.ToList();

            // Заполняем 
            dataGridView2.DataSource = programs;
        }

        private class SPResult
        {
            public string name { get; set; }

            public string price { get; set; }

            public int? discount { get; set; }

            public int? client_id { get; set; }

        }


        private void tbReport_Click(object sender, EventArgs e)
        {
            try
            {
                var parameter = new MySqlParameter("@str", textBox_program.Text);
                var result = dbcontex.Database.SqlQuery<SPResult>("mydb.getPrograms(@str)", parameter); // mydb.getPrograms
                var data = result.Join(dbcontex.client, // второй набор

                        t => t.client_id, // свойство-селектор объекта из первого набора
                        pl => pl.idclient, // свойство-селектор объекта из второго набора
                        (t, pl) => new  // результирующий объект
                        {
                            client_id = t.client_id,
                            name = t.name,
                            pass = pl.pass,
                            born = pl.born,                                                
                            price = t.price,
                            discount = t.discount
                        }).ToList();

                dataGridView4.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void tbExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exit?");
            Application.Exit();
        }
    }
}
