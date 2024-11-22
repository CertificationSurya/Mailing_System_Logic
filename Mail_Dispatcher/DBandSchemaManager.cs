using System;
using System.Windows.Forms;
using Dapper;
using Google.Apis.PeopleService.v1.Data;
using Microsoft.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Mail_Dispatcher
{
    internal class DBandSchemaManager
    {
        private static DBandSchemaManager _instance;
        private static readonly object _lock = new object();

        private SqlConnection _connection;

        // Private constructor to prevent external instantiation
        private DBandSchemaManager()
        {
            try
            {
                string connectionString = @"Data Source=LUCIFER\SQLEXPRESS01;Initial Catalog=mail-dispatcher;Persist Security Info=True;User ID=sa;Password=test;Trust Server Certificate=True";
                _connection = new SqlConnection(connectionString);
                Toaster.Instance.ShowNotification("DB Connection", "Connection To Db Established Successfully !");
                
            }
            catch (Exception)
            {
                Toaster.Instance.ShowNotification("Error: DB Connection", "Connection To Db Failed !!!", NotificationType.Error);
                return;
            }

        }

        // Public static method to get the single instance
        public static DBandSchemaManager Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DBandSchemaManager();
                    }
                }
                return _instance;
            }
        }

        // Method to get the connection
        public SqlConnection GetConnection()
        {
            if (_connection.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    _connection.Open();
                }
                catch (SqlException ex)
                {
                    Toaster.Instance.ShowNotification("Error: DB Connection", $"Failed to open connection: {ex.Message}", NotificationType.Error);
                    throw;
                }
            }
            return _connection;
        }



        // Database setup like: Table Creation for users, group and so on
        public async Task DbSetUp()
        {            
            try
            {
                await _connection.ExecuteAsync(Queries.User.CreateUsersTable);                
                Toaster.Instance.ShowNotification("Success: Table Creation", "Success In User Table Creation - Db Setup");
               
                await _connection.ExecuteAsync(Queries.Group.CreateGroupsTable);
                Toaster.Instance.ShowNotification("Success: Table Creation", "Success In Group Table Creation - Db Setup");

                await _connection.ExecuteAsync(Queries.Mail.CreateMailsTable);
                Toaster.Instance.ShowNotification("Success: Table Creation", "Success In Mail Table Creation - Db Setup");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
                Toaster.Instance.ShowNotification("Error: Table Creation", $"Error In Table Creation - Db Setup: {ex.Message}", NotificationType.Error);
                throw;
            }
        }
    }
}

