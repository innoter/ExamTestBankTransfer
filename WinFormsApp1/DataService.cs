using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class DataService
    {
        internal void LoadAccount(ref List<Account> LstAccount)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pongt\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Database1.mdf;Integrated Security=True";
            string sqlQuery = "select * from Account ";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            LstAccount = new List<Account>();
            using (SqlCommand sc = new SqlCommand(sqlQuery, con))
            {
                SqlDataReader reader = sc.ExecuteReader();
                while (reader.Read())
                {
                    LstAccount.Add(ToDataModel(reader));
                }
                reader.Close();
            }
        }
        private Account ToDataModel(SqlDataReader reader)
        {
            Account model = new Account(); model.IBAN = reader["PK_IBAN"] == DBNull.Value ? null : Convert.ToString(reader["PK_IBAN"]);
            model.AccountName = reader["AccountName"] == DBNull.Value ? null : Convert.ToString(reader["AccountName"]);
            model.Balance = (decimal)reader["Balance"]; return model;
        }
        internal void InsertAccount(string txtIBAN, string accountName)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pongt\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Database1.mdf;Integrated Security=True";
            string sqlQuery = $"INSERT INTO Account (PK_IBAN, AccountName,Balance)VALUES('{txtIBAN}', '{accountName}',0); ";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            using (SqlCommand sc = new SqlCommand(sqlQuery, con))
            {
                SqlDataReader reader = sc.ExecuteReader();
                reader.Close();
            }


            //BindingCombobox(LstAccount, comboBoxTransfer);
        }

        internal void InsertTransactionTax(string txtIBAN, string TransactionStatus, decimal amount, decimal tax)
        {

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pongt\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Database1.mdf;Integrated Security=True";
            string sqlQuery = $"INSERT INTO TransactionTable (FK_IBAN, TransactionStatus,AmountOfMoney,TAX,updatedDate)VALUES('{txtIBAN}', '{TransactionStatus}',{amount},{tax},DEFAULT); ";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            using (SqlCommand sc = new SqlCommand(sqlQuery, con))
            {
                SqlDataReader reader = sc.ExecuteReader();
                reader.Close();
            }



        }
        internal void UpdateBalance(string txtIBAN, decimal balance)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pongt\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Database1.mdf;Integrated Security=True";
            string sqlQuery = $"UPDATE Account SET Balance = {balance} WHERE PK_IBAN ='{txtIBAN}'";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            using (SqlCommand sc = new SqlCommand(sqlQuery, con))
            {
                SqlDataReader reader = sc.ExecuteReader();
                reader.Close();
            }
            //labelAmountTransfer
            //_dataService.BindingCombobox(LstAccount, comboBox2);
        }

        internal string LoadTax()
        {
            string tax = "";
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pongt\\source\\repos\\WinFormsApp1\\WinFormsApp1\\Database1.mdf;Integrated Security=True";
            string sqlQuery = " SELECT SUM(TAX) AS TotalTAX FROM TransactionTable";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            using (SqlCommand sc = new SqlCommand(sqlQuery, con))
            {
                SqlDataReader reader = sc.ExecuteReader();
                while (reader.Read())
                {

                    tax = reader["TotalTAX"].ToString();
                }
                reader.Close();
            }
            return tax;
        }

    }
    }
