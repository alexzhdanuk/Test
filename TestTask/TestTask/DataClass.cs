using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace TestTask
{
    public class DataClass : Object
    {
        //Строка подключения
        private String DataSourse;
        //указатель на главную форму
        private GeneralForm Parrent;
        //обьект для подключения к базе данных
        private OleDbConnection Connection;
        //флаг для определения было ли подключение к базе или нет
        public bool IsConnect;


        //конструктор для инициализаци переменных
        public DataClass()
        {
            DataSourse = "PROVIDER=Microsoft.ACE.OLEDB.12.0;data source=";
            Parrent = new GeneralForm();
            Connection = new OleDbConnection();
            IsConnect = false;
        }

        //конструктор для инициализаци переменных
        public DataClass(GeneralForm NewParrent)
        {
            DataSourse = "PROVIDER=Microsoft.ACE.OLEDB.12.0;data source=";
            Parrent = NewParrent;
            Connection = new OleDbConnection();
            IsConnect = false;
        }

        //функция для получения данных из главной таблицы
        public bool ConectToBase()
        {
            try
            {
                //получение пути к файлу базы данных с помощью стандартного диалога выбора файлов
                OpenFileDialog OpenFile = new OpenFileDialog();
                OpenFile.Filter = "Файлы базы данных (*.accdb)|*.accdb;";
                if (OpenFile.ShowDialog(Parrent) != DialogResult.OK) return false;
                DataSourse += OpenFile.FileName;
                
                //создание обьекта OleDbConnection для подключения к базе 
                Connection = new OleDbConnection(DataSourse);
                
                //открываем подключение
                Connection.Open();
                //установка флага 
                IsConnect = true;
                return IsConnect;
            }

            catch (Exception ex)
            {
                if (Connection.State == ConnectionState.Open) Connection.Close();
                MessageBox.Show(ex.Message);
                IsConnect = false;
                return IsConnect;
            }

        }

        //выполнение запроса на выполнение и возврат результата выполненя
        public bool GetExecutionQuery(String str_query, DateTime Date = new DateTime())
        {
            try
            {
                //проверка активно ли подключение к базе, без активного подключения выполнение запроса не возможно
                if (Connection.State != ConnectionState.Open) return false;

                //создание обьекта OleDbCommand для выполнения запроса к базе данных и получении данных
                OleDbCommand Command = new OleDbCommand(str_query, Connection);
                if (Date != new DateTime())Command.Parameters.AddWithValue("@date", Date);
                //выполнение запроса без возврата набора
                Command.ExecuteNonQuery();

                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        //выполняет запрос на выборку и возвращает обьект DataTable
        public DataTable GetSelectQuery(String str_query, DateTime Date = new DateTime())
        {
            try 
            {
                //проверка активно ли подключение к базе, без активного подключения выполнение запроса не возможно
                if (Connection.State != ConnectionState.Open) return null;
                
                //создание обьекта OleDbCommand для выполнения запроса к базе данных и получении данных
                OleDbCommand Command = new OleDbCommand(str_query, Connection);

                if (Date != new DateTime()) Command.Parameters.AddWithValue("@date", Date);
                //создание таблицы данных для наполнение dataGridView
                DataTable DataTable = new DataTable();
                //создания набора данных на основании обьекта OleDbCommand в котором уже есть запрос к базе
                OleDbDataAdapter DataAdapter = new OleDbDataAdapter(Command);

                //наполнение обьекта DataTable из готового набора DataAdapter полученого посредством выполнения запроса
                DataAdapter.Fill(DataTable);
                return DataTable;
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        
        }


        //деструкток класа DataClass
        public virtual void Dispose()
        {
            //закрываем подключение с базой если оно было открыто
            if (Connection.State == ConnectionState.Open) Connection.Close();
        }

       

    }
}
