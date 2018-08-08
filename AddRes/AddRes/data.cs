using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddRes
{
    class data
    {
        Form1 form;
        private String dbFileName = @"sample.sqlite"; //имя ДБ 

        private SQLiteConnection m_dbConn;
        private SQLiteCommand m_sqlCmd;


        public void Aut(Form1 form)
        {
            m_dbConn = new SQLiteConnection();
            m_sqlCmd = new SQLiteCommand();
            
            if (!File.Exists(dbFileName)) // выполняется если нет ДБ в корне программы
            {
                SQLiteConnection.CreateFile(dbFileName);
                
                try
                {
                    m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                    m_dbConn.Open();
                    m_sqlCmd.Connection = m_dbConn;
                    // происходит создание таблицы
                    m_sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS Address (id INTEGER PRIMARY KEY AUTOINCREMENT, region TEXT, area TEXT, nasp TEXT NOT NULL, street TEXT, house TEXT, flat TEXT)";
                    m_sqlCmd.ExecuteNonQuery();

                    form.label7.Text = "ConnectedCreateDateBase";//тестовое поле для отображения состояния
                }
                catch (SQLiteException ex)
                {
                    form.label7.Text = "Disconnected";//тестовое поле для отображения состояния
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (File.Exists(dbFileName)) // просто коннект к имеющейся БД
            {
                try
                {
                    m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                    m_dbConn.Open();
                    m_sqlCmd.Connection = m_dbConn;

                    form.label7.Text = "ConnectedOpenDateBase";//тестовое поле для отображения состояния
                }
                catch (SQLiteException ex)
                {
                    form.label7.Text = "Disconnected";//тестовое поле для отображения состояния
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        public void Op(Form1 form)
        {
            m_dbConn = new SQLiteConnection();
            m_sqlCmd = new SQLiteCommand();

            if (!File.Exists(dbFileName)) // выполняется если нет ДБ в корне программы
            {
                form.label7.Text = "ConnectedNoDateBase"; //тестовое поле для отображения состояния
                
            }
            else
                form.label7.Text = "ConnectedOpenDateBase"; //тестовое поле для отображения состояния

        }

        public void Up(Form1 form)

        {
            m_dbConn = new SQLiteConnection();
            m_sqlCmd = new SQLiteCommand();

            if (!File.Exists(dbFileName)) // выполняется если нет ДБ в корне программы
            {
                form.label7.Text = "ConnectedNoDateBase"; //тестовое поле для отображения состояния
                MessageBox.Show("Нет Базы Данных " + "\n" + "Создайте Базу Данных" + "\n" + "Следует нажать на кнопку с Базой Данных", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }
           else if (File.Exists(dbFileName)) // просто коннект к имеющейся БД
            {
                try
                {
                    m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                    m_dbConn.Open();
                    m_sqlCmd.Connection = m_dbConn;
                    SQLiteCommand command = new SQLiteCommand("INSERT INTO 'Address' ('region', 'area', 'nasp', 'street', 'house', 'flat') VALUES ('"+form.obl.Text+ "', '" + form.rn.Text + "', '" + form.nas.Text + "', '" + form.yl.Text + "', '" + form.dom.Text + "', '" + form.kv.Text + "');", m_dbConn);
                    command.ExecuteNonQuery();
                    m_dbConn.Close();

                    form.label7.Text = "ConnectedInsertDateBase";//тестовое поле для отображения состояния
                }
                catch (SQLiteException ex)
                {
                    form.label7.Text = "Disconnected";//тестовое поле для отображения состояния
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}

