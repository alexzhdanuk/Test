using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask
{
    public partial class GeneralForm : Form
    {
        //обьект класа данных
        DataClass Data;

        InfoForm InfoWindow;


        public GeneralForm()
        {
            InitializeComponent();
            Data = new DataClass(this);
            InfoWindow = null;
        }

               
        //отклик срабатывает после закрытия формы
        private void GeneralForm_FormClosed(object sender, System.EventArgs e)
        {
            //удаление обьекта класса данных
            Data.Dispose();
            //InfoWindow.Dispose();
        }

        private void GeneralForm_Resize(object sender, EventArgs e)
        {
                //при изменении размера окна програмно измняем размер элементов управления на форме 
                TabControl.Location = new Point(0, GeneralMenu.Height);
                TabControl.Size = new Size(ClientSize.Width, ClientSize.Height - GeneralMenu.Height);
                DataGridView.Location = TabControl.ClientRectangle.Location;
                DataGridView.Size = TabControl.ClientSize;
                FindDataGridView.Location = new Point(0, 95);
                FindDataGridView.Size = new Size(TabControl.ClientSize.Width, TabControl.ClientSize.Height - 95);
        }

        //выход из приложения по кнопке "Выход"
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //закрываем главную форму
            this.Close();
        }

        private void GeneralForm_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Для работы с программой подлючитесь к базе данных!!!");
            GeneralForm_Resize(null, null);
        }

        //подключение к базе данных
        public void ConnectToBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //проверка был ли конект к базе раннее
            if(!Data.IsConnect) Data.ConectToBase();
            //заполнение данными обьект DataGridView
            DataGridView.DataSource = Data.GetSelectQuery("SELECT * FROM Osnov");
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //проверка был ли конект к базе раннее
            if (!Data.IsConnect) return;
            if (DataGridView[0, DataGridView.CurrentRow.Index].Value == DBNull.Value) return;

            String Fam = Convert.ToString(DataGridView[1, DataGridView.CurrentRow.Index].Value);
            String Im = Convert.ToString(DataGridView[2, DataGridView.CurrentRow.Index].Value);
            String Otch = Convert.ToString(DataGridView[3, DataGridView.CurrentRow.Index].Value);
            DateTime Date = Convert.ToDateTime(DataGridView[4, DataGridView.CurrentRow.Index].Value);
            String Adres = Convert.ToString(DataGridView[5, DataGridView.CurrentRow.Index].Value);

            InfoWindow = new InfoForm(true, Data);

            InfoWindow.SetInfoForm(Fam, Im, Otch, Date, Adres);
            InfoWindow.Show();
            InfoWindow.Location = new Point(Location.X + 20, Location.Y + 70);

        }

        //открываем окно добавления записи
        private void AddGridViewMenuItem_Click(object sender, EventArgs e)
        {
            if (!Data.IsConnect) return;
            InfoWindow = new InfoForm(false, Data);
            InfoWindow.GeneralWindow = this;
            InfoWindow.Show();
            InfoWindow.Location = new Point(Location.X + 20, Location.Y + 70);
        }

        //удаляем выбраную запись
        private void DelGridViewMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Data.IsConnect) return;
                if (DataGridView[0, DataGridView.CurrentRow.Index].Value == DBNull.Value) return;
                int DelKod = Convert.ToInt32(DataGridView[0, DataGridView.CurrentRow.Index].Value);
                Data.GetExecutionQuery("DELETE FROM  Osnov WHERE kod =  " + DelKod + " ");
                DataGridView.DataSource = Data.GetSelectQuery("SELECT * FROM Osnov");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //поиск записей в базе по услловиям
        private void FindButton_Click(object sender, EventArgs e)
        {
            String str_query,str1,str2, str3="";
            str1 = str2 = str3;
            str1 = "Fam = '";
            str2 = "Im = '";
            str3 = " DataRozd = @data";
            str_query = "SELECT * FROM Osnov ";
            bool IsDatePar = false;

            if(FindFamText.Text != "" && FindImText.Text == "" && FindDatePicker.Value == FindDatePicker.MinDate ) str_query+="WHERE " + str1+FindFamText.Text+"' ";
            if (FindFamText.Text == "" && FindImText.Text != "" && FindDatePicker.Value == FindDatePicker.MinDate) str_query += "WHERE " + str2 + FindImText.Text + "' ";
            if (FindFamText.Text == "" && FindImText.Text == "" && FindDatePicker.Value != FindDatePicker.MinDate) { str_query += "WHERE " + str3; IsDatePar = true; }

            if (FindFamText.Text != "" && FindImText.Text != "" && FindDatePicker.Value == FindDatePicker.MinDate) str_query += "WHERE " + str1 + FindFamText.Text + "'  and  " + str2 + FindImText.Text + "' ";
            if (FindFamText.Text == "" && FindImText.Text != "" && FindDatePicker.Value != FindDatePicker.MinDate) { str_query += "WHERE " + str2 + FindImText.Text + "'  and  " + str3; IsDatePar = true; }
            if (FindFamText.Text != "" && FindImText.Text == "" && FindDatePicker.Value != FindDatePicker.MinDate) { str_query += "WHERE " + str1 + FindFamText.Text + "'  and  " + str3; IsDatePar = true; }

            if (FindFamText.Text != "" && FindImText.Text != "" && FindDatePicker.Value != FindDatePicker.MinDate) { str_query += "WHERE " + str1 + FindFamText.Text + "'  and  " + str2 + FindImText.Text + "'  and  " + str3; IsDatePar = true; }

            if (IsDatePar) FindDataGridView.DataSource = Data.GetSelectQuery(str_query, FindDatePicker.Value);
            else FindDataGridView.DataSource = Data.GetSelectQuery(str_query);

        }
    
    }
}
