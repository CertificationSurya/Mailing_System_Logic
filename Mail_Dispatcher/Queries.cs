using System;

namespace Mail_Dispatcher
{
    internal class Queries
    {

        // user Related Queries
        public class User
        {
        // Defining the queries as static constants

        // sysobjects is the object holding all info about tables, views etc.
        // xtype = "U" is user-defined Table
        public static string CreateUsersTable = @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'users' AND xtype = 'U')
            BEGIN
            CREATE TABLE users (
            id INT PRIMARY KEY IDENTITY(1,1),
            username VARCHAR(255) NOT NULL,
            email VARCHAR(255) NOT NULL UNIQUE,
            photoUrl VARCHAR(255),
            groupJoined NVARCHAR(MAX) DEFAULT '[]'
        );
        END";

        // if the email isnt register in hamro db, then only store
        public static string CreateUser = @"
            IF NOT EXISTS (SELECT 1 FROM users WHERE email = @Email)
            BEGIN
                INSERT INTO users (username, email, photoUrl)
                VALUES (@Username, @Email, @PhotoUrl);
            END";
        }



        // Group Related Query haru
        public class Group
        {
            // 'groups' is the reserve keyword in SQL and thus the []
        public static string CreateGroupsTable = @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'groups' AND xtype = 'U')
            BEGIN
                CREATE TABLE groups (
                    id INT PRIMARY KEY IDENTITY(1,1),
                    groupName NVARCHAR(100) NOT NULL,
                    members NVARCHAR(MAX), -- Consider using JSON or normalize
                    owner NVARCHAR(255) NOT NULL, -- Use NVARCHAR for consistency
                    createdAt DATETIME DEFAULT GETDATE()
                );
            END";


        }


        // Mail Related Query haru
        public class Mail
        {

        public static string CreateMailsTable = @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'mails' AND xtype = 'U')
            BEGIN
                CREATE TABLE mails (
                    id INT PRIMARY KEY IDENTITY(1,1),
                    groupId NVARCHAR(MAX),
                    senderEmail VARCHAR(255) NOT NULL,
                    subject VARCHAR(255) NOT NULL,
                    body VARCHAR(255) NOT NULL,
                    createdAt DATETIME DEFAULT GETDATE()
                );
            END
        ";

        }



    }
}
