using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Plants
{
    public partial class F2Table : Form
    {
        //Подключение базы данных
        public string CommandText = "SELECT * FROM [Растения]"; 
        public string ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Даша Дима\\KURSOVAY\\Plants\\Plants\\Plans.accdb";

        public void My_Execute_Non(string CommandText)
        {
            OleDbConnection conn = new OleDbConnection(ConnString);
            conn.Open();
            OleDbCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = CommandText;
            myCommand.ExecuteNonQuery();
            conn.Close();

        }


        public F2Table()
        {
            InitializeComponent();

            OleDbDataAdapter dA = new OleDbDataAdapter(CommandText, ConnString);
            DataSet ds = new DataSet();
            //Заполняем таблицу
            dA.Fill(ds, "[Растения]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            F3AddPlan F3 = new F3AddPlan();
            F3.Owner = this;
            F3.ShowDialog();

            if (F3.textBox1.Text != "" && F3.textBox2.Text != "" 
                && F3.textBox3.Text != "" && F3.comboBox1.Text != ""
                && F3.comboBox2.Text != "" && F3.comboBox3.Text != "" 
                && F3.comboBox5.Text != "")
            {
                int nrow = dataGridView1.Rows.Count - 2; //Номер последней строки
                int number = Convert.ToInt16(dataGridView1.Rows[nrow].Cells[0].Value.ToString()) + 1; //значение в последней сторке
                string name = F3.textBox1.Text;
                string famili = F3.comboBox1.Text;
                string view = F3.comboBox2.Text;
                string rod = F3.comboBox3.Text;
                string need = F3.textBox3.Text;
                string terr = F3.comboBox5.Text;
                double quantity = Convert.ToDouble(F3.textBox2.Text);

                string ComText = "INSERT INTO [Растения] ([Номер], [Название], [Семейство], [Вид], [Род], [Назначение], [Территория произрастания], [Колличество])"
                     + "VALUES ('" + number + "', '" + name + 
                     "', '" + famili + "', '" + view + "', '" 
                     + rod + "', '" + need + "', '" + terr +
                     "', '" + quantity + "')";

                My_Execute_Non(ComText);
                
                OleDbDataAdapter dAd = new OleDbDataAdapter(CommandText, ConnString);
                DataSet dse = new DataSet();
                dAd.Fill(dse, "[Растения]");
                dataGridView1.DataSource = dse.Tables["[Растения]"].DefaultView;
                dataGridView1.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            F4DeletePlan F4 = new F4DeletePlan();
            F4.Owner = this;
            F4.ShowDialog();
            if (F4.textBox1.Text != "")
            {
                string ComText = "DELETE FROM";
                int index = -1;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {

                    if (dataGridView1.Rows[i].Cells[1].Value != null)
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString().Equals(F4.textBox1.Text))
                        {
                            index = i;
                            break;
                        }
                }

                if (index > -1)
                {
                    string ID = Convert.ToString(dataGridView1[0, index].Value);
                    ComText = "DELETE FROM [Растения] WHERE [Растения].[Номер] = " + ID;

                    My_Execute_Non(ComText);

                    OleDbDataAdapter dAd = new OleDbDataAdapter(CommandText, ConnString);
                    DataSet dse = new DataSet();
                    dAd.Fill(dse, "[Растения]");
                    dataGridView1.DataSource = dse.Tables[0].DefaultView;
                    dataGridView1.Refresh();
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Нет совпадений!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void F2Table_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'plansDataSet.Растения' table. You can move, or remove it, as needed.
            this.растенияTableAdapter.Fill(this.plansDataSet.Растения);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            F5Search F5 = new F5Search();
            F5.Owner = this;
            F5.ShowDialog();
            F3AddPlan F3 = new F3AddPlan();
            F3.Owner = this;
            
            int nstr = -1;
            if (F5.textBox1.Text != "")
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value != null)
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString().Equals(F5.textBox1.Text))
                        {
                            nstr = i;
                            break;
                        }

                }

            

                if (nstr != -1)
                {
                    
                    F3.textBox1.Text = dataGridView1.Rows[nstr].Cells[1].Value.ToString();
                    F3.comboBox1.Text = dataGridView1.Rows[nstr].Cells[2].Value.ToString();
                    F3.comboBox2.Text = dataGridView1.Rows[nstr].Cells[3].Value.ToString();
                    F3.comboBox3.Text = dataGridView1.Rows[nstr].Cells[4].Value.ToString();
                    F3.textBox3.Text = dataGridView1.Rows[nstr].Cells[5].Value.ToString();
                    F3.comboBox5.Text = dataGridView1.Rows[nstr].Cells[6].Value.ToString();
                    F3.textBox2.Text = dataGridView1.Rows[nstr].Cells[7].Value.ToString();
                    
                    
                    
                    F3.ShowDialog();
                    

                    string ID = Convert.ToString(dataGridView1[0, nstr].Value);
                    string ComText1 = "DELETE FROM [Растения] WHERE [Растения].[Номер] = " + ID;
                    My_Execute_Non(ComText1);
                    OleDbDataAdapter dAd = new OleDbDataAdapter(CommandText, ConnString);
                    DataSet dse = new DataSet();
                    dAd.Fill(dse, "[Растения]");
                    dataGridView1.DataSource = dse.Tables["[Растения]"].DefaultView;
                    dataGridView1.Refresh();

                    //в базу внести
                    int nrow = dataGridView1.Rows.Count - 2; //Номер последней строки
                    int r = Convert.ToInt16(dataGridView1.Rows[nrow].Cells[0].Value.ToString()) + 1;
                    string ComText2 = "INSERT INTO [Растения] ([Номер], [Название], [Семейство], [Вид], [Род], [Назначение], [Территория произрастания], [Колличество])"
                   + "VALUES ('" + r + "', '" + F3.textBox1.Text +
                   "', '" + F3.comboBox1.Text + "', '" + F3.comboBox2.Text + "', '"
                   + F3.comboBox3.Text + "', '" + F3.textBox3.Text + "', '" + F3.comboBox5.Text +
                   "', '" + F3.textBox2.Text + "')";
                                                            
                    My_Execute_Non(ComText2);

                    OleDbDataAdapter dA = new OleDbDataAdapter(CommandText, ConnString);
                    DataSet ds = new DataSet();
                    dA.Fill(ds, "[Растения]");
                    dataGridView1.DataSource = ds.Tables["[Растения]"].DefaultView;
                    dataGridView1.Refresh();

                }
                else
                {
                    DialogResult dr = MessageBox.Show("Клиент не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }
    }
}
