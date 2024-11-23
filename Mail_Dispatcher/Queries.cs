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
            username NVARCHAR(255) NOT NULL,
            email NVARCHAR(255) NOT NULL UNIQUE,
            photoUrl NVARCHAR(255),
            groupJoined NVARCHAR(MAX) DEFAULT '[]'
        );                                        
        END";

            // if the email isnt register in hamro db, then only store
            //public static string CreateOrFindUser = @"
            //IF NOT EXISTS (SELECT 1 FROM users WHERE email = @Email)
            //BEGIN
            //    INSERT INTO users (username, email, photoUrl)
            //    VALUES (@Username, @Email, @PhotoUrl);
            //END";

            public static string CreateUserAndGetId = @"
    IF NOT EXISTS (SELECT id FROM users WHERE email = @Email)
    BEGIN
        INSERT INTO users (username, email, photoUrl)
        OUTPUT INSERTED.id
        VALUES (@Username, @Email, @PhotoUrl);
    END
    ELSE
    BEGIN
        SELECT id FROM users WHERE email = @Email;
    END";

            public static string UpdateUserGroupJoined = @"
    UPDATE users
    SET groupJoined = 
        CASE 
            WHEN groupJoined = '[]' THEN CONCAT('[', @GroupId, ']') -- If groupJoined is empty, set it to the new group
            ELSE CONCAT(
                LEFT(groupJoined, LEN(groupJoined) - 1), -- Remove the trailing ']'
                ',', @GroupId, ']') -- Append the new groupId and re-add the ']'
        END
    WHERE email = @Email;";


            public static string UserJoinedGroupArray = @"
                SELECT groupJoined FROM users WHERE id = @UserId
            ";




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
                    membersId NVARCHAR(MAX), -- members ko id
                    members NVARCHAR(MAX) DEFAULT '[]', -- members ko email haru
                    memberCount INT DEFAULT 0,
                    ownerEmail NVARCHAR(255) NOT NULL, -- Use NVARCHAR for consistency
                    ownerId NVARCHAR(255) NOT NULL, -- Use NVARCHAR for consistency
                    createdAt DATETIME DEFAULT GETDATE()
                );
            END";

                //public static string CreateGroup = @"
                //INSERT INTO [groups] (groupName, membersId, members, memberCount, ownerEmail, ownerId, createdAt)
                //VALUES (
                //    @GroupName, 
                //    CONCAT('[', @OwnerId, ']'), -- Initialize membersId with the owner's ID
                //    CONCAT('["", @OwnerEmail, ""]'), -- Initialize members with the owner's email
                //    1, -- Start with 1 member(the owner)
                //    @OwnerEmail, 
                //    @OwnerId, 
                //    GETDATE()
                //);";
            public static string CreateGroupAndGetId = @"
                INSERT INTO [groups] (groupName, membersId, members, memberCount, ownerEmail, ownerId, createdAt)
                OUTPUT INSERTED.id
                VALUES (
                    @GroupName, 
                    CONCAT('[', @OwnerId, ']'), -- Initialize membersId with the owner's ID
                    CONCAT('[""', @OwnerEmail, '""', 
                           CASE WHEN @OtherEmails IS NOT NULL THEN CONCAT(',', @OtherEmails) ELSE '' END, ']'), -- Initialize members with the owner's email and possibly additional emails
                    CASE WHEN @OtherEmails IS NOT NULL THEN 1 + LEN(@OtherEmails) - LEN(REPLACE(@OtherEmails, ',', '')) ELSE 1 END, -- Calculate member count (owner + additional emails)
                    @OwnerEmail, 
                    @OwnerId, 
                    GETDATE()
                )";

            public static string CheckGroupName = @"
                SELECT COUNT(*) 
                FROM [groups] 
                WHERE groupName = @GroupName;";

            public static string ViewGroup = @"
                SELECT 
                    groupName, 
                    ownerEmail, 
                    memberCount, 
                    createdAt
                FROM 
                    [groups]
                WHERE 
                    id = @GroupId;
            ";

            public static string GetMembersArrayByGroupName = @"
                SELECT 
                    members,
                    id
                FROM 
                    [groups]
                WHERE 
                    groupName = @GroupName;
            ";

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
                    groupName NVARCHAR(255),
                    senderEmail NVARCHAR(255) NOT NULL,
                    senderId NVARCHAR(MAX), -- sender ko id
                    subject NVARCHAR(255) NOT NULL,
                    body NVARCHAR(MAX) NOT NULL,
                    createdAt DATETIME DEFAULT GETDATE()
                );
            END";


                public static string CreateMail = @"
                INSERT INTO [mails] (subject, body, groupId, groupName, senderId, senderEmail, createdAt)
                VALUES (
                    @Subject, 
                    @Body, 
                    @GroupId,
                    @GroupName,
                    @SenderId, 
                    @SenderEmail, 
                    GETDATE()
                );";

                public static string ViewSingleMail = @"
                SELECT 
                    id,
                    subject,
                    body,
                    groupId,
                    groupName,
                    senderEmail,
                    senderId,
                    createdAt
                FROM 
                    [mails]
                WHERE 
                    id = @MailId;
            ";
            }

        }
}