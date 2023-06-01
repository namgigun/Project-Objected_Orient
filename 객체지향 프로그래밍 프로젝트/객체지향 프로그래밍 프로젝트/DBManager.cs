using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 객체지향_프로그래밍_프로젝트
{
    internal class DBManager
    {
        MySqlConnection connection = new MySqlConnection("server = 34.64.213.225; Database = Data; Uid = root; Pwd = root");

        public void insert(String Query) { // 삽입

            Boolean success = false;

            using (connection) {

                try {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(Query, connection);

                    if (command.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("인서트 성공");
                        success = true;
                    }
                    else
                    {
                        Console.WriteLine("인서트 실패");
                    }

                }catch (Exception ex)
                {
                    Console.WriteLine("실패");
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public DataTable select(String Query) { 
            using (connection)
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(Query,connection);
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                reader.Close();

                return dataTable;
            }
        }

        public void update(String Query) { // 업데이트
            
        }
    }
}
