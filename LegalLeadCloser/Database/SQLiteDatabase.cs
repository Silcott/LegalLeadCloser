using Hash;
using System;
using System.Data.SQLite;
using System.IO;

namespace Database
{
    class SQLiteDatabase
    {
        #region CREATE Tables 
        //Create SQLite Command
        private static SQLiteCommand sql_cmd;
        public static void CreateDatabase()
        {
            //Start up path 
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\database\";
            //Path to database
            string fileName = "db.sqlite";
            //If the file is not there or deleted, create the database
            if (!File.Exists(Path.Combine(path, fileName)))
            {
                //Create file at startup path and destinated file location
                SQLiteConnection.CreateFile(Path.Combine(path, fileName));
                //Make the  SQLite connection string
                var sqlite2 = new SQLiteConnection($"Data Source={Path.Combine(path, fileName)}");
                //Open connection to database
                sqlite2.Open();
                //Create the SQLite command
                sql_cmd = sqlite2.CreateCommand();

                //CREATE Table - Users
                string createTableQueryUsers = @"CREATE TABLE IF NOT EXISTS tbl_users (
                                user_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
                                company_name NVARCHAR(2048)  NULL, 
                                years_practing NVARCHAR(2048)  NULL, 
                                months_practing NVARCHAR(2048)  NULL, 
                                first_name NVARCHAR(2048)  NULL, 
                                last_name NVARCHAR(2048)  NULL, 
                                full_name NVARCHAR(2048)  NULL, 
                                email NVARCHAR(2048)  NULL, 
                                password NVARCHAR(2048)  NULL, 
                                phone NVARCHAR(2048)  NULL, 
                                street_address NVARCHAR(2048)  NULL, 
                                city_address NVARCHAR(2048)  NULL, 
                                state_address NVARCHAR(2048)  NULL, 
                                zipcode_address NVARCHAR(2048)  NULL, 
                                creation_date TEXT  NULL, 
                                image_name NVARCHAR(2048)  NULL, 
                                security_level NVARCHAR(2048)  NULL);";
                //Give the command query
                sql_cmd.CommandText = createTableQueryUsers;
                //End the command
                sql_cmd.ExecuteNonQuery();
                //LOAD User - Admin
                int userId = 1;
                string companyName = "Ascent";
                string yearsPracting = "1";
                string monthsPracting = "9";
                string firstName = "James";
                string lastName = "Silcott";
                string fullname = firstName + " " + lastName;
                string email = "silcott.jb@outlook.com";
                string password = HashPassword.CalculateSHA256("123");
                string phone = "907-250-7727";
                string streetAddress = "628 Valley View Drive";
                string cityAddress = "Oneida";
                string stateAddress = "NY";
                string zipCodeAddress = "13421";
                DateTime creationDate = DateTime.Now;
                string imageName = "no-image.png";
                string securityLevel = "Admin";
                string sqliteInsert_User_Admin = @"INSERT INTO tbl_users(
                                user_id, 
                                company_name, 
                                years_practing, 
                                months_practing, 
                                first_name, 
                                last_name, 
                                full_name, 
                                email, 
                                password, 
                                phone, 
                                street_address, 
                                city_address, 
                                state_address, 
                                zipcode_address, 
                                creation_date, 
                                image_name, 
                                security_level
                                ) VALUES (
                                '" + userId + @"'
                                ,'" + companyName + @"'
                                ,'" + yearsPracting + @"'
                                ,'" + monthsPracting + @"'
                                ,'" + firstName + @"'
                                ,'" + lastName + @"'
                                ,'" + fullname + @"'
                                ,'" + email + @"'
                                ,'" + password + @"'
                                ,'" + phone + @"'
                                ,'" + streetAddress + @"'
                                ,'" + cityAddress + @"'
                                ,'" + stateAddress + @"'
                                ,'" + zipCodeAddress + @"'
                                ,'" + DateTime.Now + @"'
                                ,'" + imageName + @"'
                                ,'" + securityLevel + @"');";
                sql_cmd.CommandText = sqliteInsert_User_Admin;
                sql_cmd.ExecuteNonQuery();

                //CREATE Table - Clients
                string createTableQueryClients = @"CREATE TABLE IF NOT EXISTS tbl_clients (
                                client_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
                                first_name NVARCHAR(2048)  NULL, 
                                last_name NVARCHAR(2048)  NULL, 
                                full_name NVARCHAR(2048)  NULL, 
                                email NVARCHAR(2048)  NULL, 
                                password NVARCHAR(2048)  NULL, 
                                phone NVARCHAR(2048)  NULL, 
                                birth_day NVARCHAR(2048)  NULL, 
                                birth_month VARCHAR(2048)  NULL, 
                                birth_year VARCHAR(2048)  NULL, 
                                court_name VARCHAR(2048)  NULL, 
                                court_county VARCHAR(2048)  NULL, 
                                court_day VARCHAR(2048)  NULL, 
                                court_month VARCHAR(2048)  NULL, 
                                court_year VARCHAR(2048)  NULL, 
                                court_time VARCHAR(2048)  NULL, 
                                street_address VARCHAR(2048)  NULL, 
                                city_address VARCHAR(2048)  NULL, 
                                state_address VARCHAR(2048)  NULL, 
                                zipcode_address VARCHAR(2048)  NULL, 
                                creation_date TEXT  NULL, 
                                image_name VARCHAR(2048)  NULL, 
                                security_level VARCHAR(2048)  NULL);";
                sql_cmd.CommandText = createTableQueryClients;
                sql_cmd.ExecuteNonQuery();

                //LOAD Client - Default Client
                int clientId = 1;
                firstName = "Default";
                lastName = "Client";
                fullname = firstName + " " + lastName;
                email = "defaultClient@outlook.com";
                password = HashPassword.CalculateSHA256("123");
                phone = "555-555-5555";
                string birthDay = "5";
                string birthMonth = "April";
                string birthYear = "1900";
                string courtName = "Oneida City Court";
                string courtCounty = "Oneida";
                string courtDay = "1";
                string courtMonth = "June";
                string courtYear = "2022";
                string courtTime = "09:00 PM";
                streetAddress = "123 Ascent Ave";
                cityAddress = "Oneida";
                stateAddress = "NY";
                zipCodeAddress = "13421";
                creationDate = DateTime.Now;
                imageName = "no-image.png";
                securityLevel = "Client";
                string sqliteInsert_Client_Default = @"INSERT INTO tbl_clients(
                                client_id, 
                                first_name, 
                                last_name, 
                                full_name, 
                                email, 
                                password, 
                                phone, 
                                birth_day, 
                                birth_month, 
                                birth_year, 
                                court_name, 
                                court_county, 
                                court_day, 
                                court_month, 
                                court_year, 
                                court_time, 
                                street_address, 
                                city_address, 
                                state_address, 
                                zipcode_address, 
                                creation_date, 
                                image_name, 
                                security_level
                                ) VALUES (
                                '" + clientId + @"'
                                ,'" + firstName + @"'
                                ,'" + lastName + @"'
                                ,'" + fullname + @"'
                                ,'" + email + @"'
                                ,'" + password + @"'
                                ,'" + phone + @"'
                                ,'" + birthDay + @"'
                                ,'" + birthMonth + @"'
                                ,'" + birthYear + @"'
                                ,'" + courtName + @"'
                                ,'" + courtCounty + @"'
                                ,'" + courtDay + @"'
                                ,'" + courtMonth + @"'
                                ,'" + courtYear + @"'
                                ,'" + courtTime + @"'
                                ,'" + streetAddress + @"'
                                ,'" + cityAddress + @"'
                                ,'" + stateAddress + @"'
                                ,'" + zipCodeAddress + @"'
                                ,'" + DateTime.Now + @"'
                                ,'" + imageName + @"'
                                ,'" + securityLevel + "');";
                sql_cmd.CommandText = sqliteInsert_Client_Default;
                sql_cmd.ExecuteNonQuery();

                //CREATE Table - Responses to Questions
                string createTableQueryResponses = @"CREATE TABLE IF NOT EXISTS tbl_responses (
                                client_id INTEGER PRIMARY KEY, 
                                q1 NVARCHAR(2048)  NULL, 
                                q2 NVARCHAR(2048)  NULL, 
                                q3 NVARCHAR(2048)  NULL, 
                                q4 NVARCHAR(2048)  NULL, 
                                q5 NVARCHAR(2048)  NULL, 
                                q6 NVARCHAR(2048)  NULL, 
                                q7 NVARCHAR(2048)  NULL, 
                                q8 NVARCHAR(2048)  NULL, 
                                q9 NVARCHAR(2048)  NULL, 
                                q10 NVARCHAR(2048)  NULL, 
                                q11 NVARCHAR(2048)  NULL, 
                                q12 NVARCHAR(2048)  NULL, 
                                q13 NVARCHAR(2048)  NULL, 
                                q14 NVARCHAR(2048)  NULL, 
                                q15 NVARCHAR(2048)  NULL, 
                                q16 NVARCHAR(2048)  NULL, 
                                q17 NVARCHAR(2048)  NULL,
                                q18 NVARCHAR(2048)  NULL, 
                                q19 NVARCHAR(2048)  NULL, 
                                q20 NVARCHAR(2048)  NULL, 
                                q21 NVARCHAR(2048)  NULL, 
                                q22 NVARCHAR(2048)  NULL, 
                                q23 NVARCHAR(2048)  NULL, 
                                q24 NVARCHAR(2048)  NULL, 
                                q25 NVARCHAR(2048)  NULL, 
                                q26 NVARCHAR(2048)  NULL, 
                                q27 NVARCHAR(2048)  NULL, 
                                q28 NVARCHAR(2048)  NULL, 
                                q29 NVARCHAR(2048)  NULL);";
                sql_cmd.CommandText = createTableQueryResponses;
                sql_cmd.ExecuteNonQuery();

                //LOAD Responses - Default
                clientId = 1;
                //Question 1: Why were you stopped by the police? Or how did they engage you? 
                string q1 = "";
                //Question 2: Were you involved in an accident?
                string q2 = "";
                //Question 3: DId you hit another vehicle?
                string q3 = "";
                //Question 4: Were they injured and if so to what extent? 
                string q4 = "";
                //Question 5: Tell me about your accident? 
                string q5 = "";
                //Question 6: Were you medically evaluated and if so by whom? 
                string q6 = "";
                //Question 7: What did they say to you when the officer approached your vehicle?
                string q7 = "";
                //Question 8: Did you make any statements to the officer?
                string q8 = "";
                //Question 9: If yes, what did you say? 
                string q9 = "";
                //Question 10: Did you tell the officer how much you have been drinking or what drugs you may have been on? 
                string q10 = "";
                //Question 11: Did he make you step out of the vehicle?
                string q11 = "";
                //Question 12: Did you have to do any Field Sobriety Tests? 
                string q12 = "";
                //Question 13: If so, which ones? (a drop down of, Horizontal gaze nystagmus/ One leg stand/ Walk and turn/ Romberg balance/ Alphabet recital/ Finger to nose/ Finger count/ Other______
                string q13 = "";
                //Question 14: Did you take a breathalyzer at the scene?
                string q14 = "";
                //Question 15: Were you handcuffed at that point? 
                string q15 = "";
                //Question 16: Did the officer read you the Miranda warnings? 
                string q16 = "";
                //Question 17: Were you taken to the police station?
                string q17 = "";
                //Question 18: Did they put you in a cell or handcuff you to a bench?
                string q18 = "";
                //Question 19: Did you take the chemical test (breathalyzer) at the station?
                string q19 = "";
                //Question 20: If yes- Was it a breath test or a blood test?
                string q20 = "";
                //Question 21: What was your BAC?
                string q21 = "";
                //Question 22: Was your vehicle impounded or towed? 
                string q22 = "";
                //Question 23: If yes have you recovered it yet? 
                string q23 = "";

                //Personal Pain Point Questions
                //Question 24: What do you do for a living? 
                string q24 = "";
                //Question 25: Is this something that could affect you professionally? 
                string q25 = "";
                //Question 26: If yes- How so? (note to lawyer, have them express to you what they may have to lose)
                string q26 = "";
                //Question 27: Do you have a family member or members that rely on your income?
                string q27 = "";
                //Question 28: If yes- How do you think this will affect them?
                string q28 = "";
                //Question 29: What is your biggest concern or fear facing this charge? (Drop down box of the following: Prison/Jail, loss of license, loss of job, costs associated with legal fees and fines, criminal record, other)
                string q29 = "";

                string sqliteInsert_Client_Responses = @"INSERT INTO tbl_responses(
                                    client_id, 
                                    q1, 
                                    q2, 
                                    q3, 
                                    q4, 
                                    q5, 
                                    q6, 
                                    q7, 
                                    q8, 
                                    q9, 
                                    q10, 
                                    q11, 
                                    q12, 
                                    q13, 
                                    q14, 
                                    q15, 
                                    q16, 
                                    q17, 
                                    q18, 
                                    q19, 
                                    q20, 
                                    q21, 
                                    q22, 
                                    q23, 
                                    q24, 
                                    q25, 
                                    q26, 
                                    q27, 
                                    q28, 
                                    q29
                                    ) VALUES (
                                    '" + clientId + @"',
                                    '" + q1 + @"',
                                    '" + q2 + @"',
                                    '" + q3 + @"',
                                    '" + q4 + @"',
                                    '" + q5 + @"',
                                    '" + q6 + @"',
                                    '" + q7 + @"',
                                    '" + q8 + @"',
                                    '" + q9 + @"',
                                    '" + q10 + @"',
                                    '" + q11 + @"',
                                    '" + q12 + @"',
                                    '" + q13 + @"',
                                    '" + q14 + @"',
                                    '" + q15 + @"',
                                    '" + q16 + @"',
                                    '" + q17 + @"',
                                    '" + q18 + @"',
                                    '" + q19 + @"',
                                    '" + q20 + @"',
                                    '" + q21 + @"',
                                    '" + q22 + @"',
                                    '" + q23 + @"',
                                    '" + q24 + @"',
                                    '" + q25 + @"',
                                    '" + q26 + @"',
                                    '" + q27 + @"',
                                    '" + q28 + @"',
                                    '" + q29 + @"');";
                sql_cmd.CommandText = sqliteInsert_Client_Responses;
                sql_cmd.ExecuteNonQuery();


                //CREATE Table - Payment 
                string createTableQueryPayment = @"CREATE TABLE IF NOT EXISTS tbl_payment (
                                    client_id INTEGER PRIMARY KEY, 
                                    case_cost NVARCHAR(2048)  NULL, 
                                    q30 NVARCHAR(2048)  NULL, 
                                    credit_card_number NVARCHAR(2048)  NULL, 
                                    q31 NVARCHAR(2048)  NULL, 
                                    q32 NVARCHAR(2048)  NULL);";
                sql_cmd.CommandText = createTableQueryPayment;
                sql_cmd.ExecuteNonQuery();


                //LOAD Payment - Default
                clientId = 1;
                //Your investment for our firm to represent you in a case like this is $__________
                string caseCost = "";
                //Question 30: Is that something you can put on a credit or debit card so that we may start to defend you right away? 
                string q30 = "";
                //Credit card number
                string creditCardNumber = "1234-4564-7894-1234"; //NOT STORED
                string hashedCreditCardNumber = HashPassword.CalculateSHA256(creditCardNumber);
                //Question 31: Do you like the idea of working with a law firm that only focuses on DWI / DUI defense ?
                string q31 = "";
                //Question 32: Sound fair enough?
                string q32 = "";
                string sqliteInsert_Client_Payment = @"INSERT INTO tbl_payment(
                                    client_id, 
                                    case_cost, 
                                    q30, 
                                    credit_card_number, 
                                    q31, 
                                    q32
                                    ) VALUES (
                                    '" + clientId + @"',
                                    '" + caseCost + @"',
                                    '" + q30 + @"',
                                    '" + hashedCreditCardNumber + @"',
                                    '" + q31 + @"',
                                    '" + q32 + @"');";
                sql_cmd.CommandText = sqliteInsert_Client_Payment;
                sql_cmd.ExecuteNonQuery();

                //Close connection to database
                sqlite2.Close();
            }
        }
        #endregion
    }
}