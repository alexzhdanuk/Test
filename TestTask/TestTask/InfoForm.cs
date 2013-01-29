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
    public partial class InfoForm : Form
    {
        //флаг для определения режима вывода окна, добавление или вывод подробной информации
        public bool IsInfo;
        //обьект для работы с данными
        public DataClass Data;
        //обьект для получение ссылки на главное окно для обновления окна после добавления записи
        public GeneralForm GeneralWindow;


        
        public InfoForm(bool newIsInfo, DataClass refData)
        {
            //инициализация данных при создании обьекта формы
            InitializeComponent();
            IsInfo = newIsInfo;
            Data = refData;
        }

        //функция для заполнения информации при просмотре подробно о студенте
        public void SetInfoForm(String NewFam, String NewIm, String NewOt, DateTime NewDate, String NewAdres)
        {   
            //наполнение формы данными из базы  
            FamTextBox.Text = NewFam;
            ImTextBox.Text = NewIm;
            OtchTextBox.Text = NewOt;
            DateTimePicker.Value = NewDate;
            AdresTextBox.Text = NewAdres;
        }

        //функция проверки введеных данных
        private bool ProverkaVvoda()
        {
            //проверка на пустые занчения полей при добавлении записей в базу
            if (FamTextBox.Text == "") { MessageBox.Show("Введите фамилию студента!!!"); FamTextBox.Focus(); return false; }
            if (ImTextBox.Text == "") { MessageBox.Show("Введите имя студента!!!"); ImTextBox.Focus(); return false; }
            if (OtchTextBox.Text == "") { MessageBox.Show("Введите отчество студента!!!"); OtchTextBox.Focus(); return false; }
            if (AdresTextBox.Text == "") { MessageBox.Show("Введите адрес студента!!!"); AdresTextBox.Focus(); return false; }

            return true;
        }

        //функция обработки отклика на кнопку 'Ok'
        private void OkButton_Click(object sender, EventArgs e)
        {
            //проверка - если окно в режиме инфо просто закрываем окно по кнопке 'Ok'
            if (IsInfo) { Close(); return; }
            //вызов функции проверки вводимых данных
            if (!ProverkaVvoda()) return;
            //вызов функции для выполнения запроса на добавление данных
            Data.GetExecutionQuery("INSERT INTO  Osnov ( Fam, Im, Otch, DataRozd, Adres ) VALUES (  '" + FamTextBox.Text + "' , '" + ImTextBox.Text + "', '" + OtchTextBox.Text + "', @date, '" + AdresTextBox.Text + "'); ", DateTimePicker.Value);
            //обновление данных на главной форме елемента GridView
            GeneralWindow.ConnectToBaseToolStripMenuItem_Click(null, null);
            //закрыти формы
            Close();
        }

        //функция обработки отклика на кнопку 'Cansel'
        private void CanselButton_Click(object sender, EventArgs e)
        {
            //закрыти формы
            Close();
        }




    }
}
