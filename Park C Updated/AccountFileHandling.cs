using System;
using System.IO;

namespace Park_C_Updated
{
    public class AccountFileHandling : Account
    {
        private string filepath = "accounts.csv";

        public bool Exists(string username, string email)
        {
            if (!File.Exists(filepath)) return false;

            using (StreamReader reader = new StreamReader(filepath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] accData = line.Split(',');
                    if (accData[0] == username || accData[1] == email)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override void Save()
        {
            if (Exists(username, email))
            {
                throw new Exception("Username or Email already exists!");
            }

            try
            {
                if (!File.Exists(filepath))
                {
                    using (StreamWriter writer = new StreamWriter(filepath))
                    {
                        writer.WriteLine("USERNAME,EMAIL,PASSWORD,PHONE");
                        writer.WriteLine($"admin1,admin1@example.com,admin123,1234567890");
                    }
                }
                using (StreamWriter writer = new StreamWriter(filepath, true))
                {
                    writer.WriteLine($"{username},{email},{password},{phoneNumber}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        public override bool Validate(string username, string password)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] accData = line.Split(',');
                        if ((accData[0] == username || accData[1] == username) && accData[2] == password)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }
    }
}
