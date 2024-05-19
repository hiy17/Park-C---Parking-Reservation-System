using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Park_C_Updated
{
    public class Admin
    {
        public string usernames {  get; set; } 
        public string slot { get; set; }
        public string dateReserved { get; set; }
        public string timeArrival { get; set; }
        public int hours { get; set; }
        public int price { get; set; }

        public void ReserveSlot(string username)
        {

            string filepath = ("Admin.csv");
            try
            {
                if (!File.Exists(filepath))
                {
                    using (StreamWriter writer = new StreamWriter(filepath))
                    {
                        writer.WriteLine("USERNAME,PARKING SLOT,DATE OF RESERVATION,TIME OF ARRIVAL,HOURS,AMOUNT");
                        writer.WriteLine($"{usernames},{slot},{dateReserved},{timeArrival},{hours},{price}");
                        Console.WriteLine("Reserved Successfully");
                    }
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(filepath, true))
                    {
                        writer.WriteLine($"{usernames},{slot},{dateReserved},{timeArrival},{hours},{price}");
                        Console.WriteLine("Reserved Successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateAdminRecord(string username, string originalSlot)
        {
            string filepath = "Admin.csv";
            var lines = File.ReadAllLines(filepath).ToList();
            var index = lines.FindIndex(line => line.StartsWith($"{username},{originalSlot}"));
            if (index != -1)
            {
                lines[index] = $"{usernames},{slot},{dateReserved},{timeArrival},{hours},{price}";
                File.WriteAllLines(filepath, lines);
            }
        }

    }
}
