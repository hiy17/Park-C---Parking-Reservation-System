using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Park_C_Updated
{
    public class User
    {
        public string usernames { get; set; }
        public string slot { get; set; }
        public string dateReserved { get; set; }
        public string timeArrival { get; set; }
        public int hours { get; set; }
        public int price { get; set; }

        public void ReserveSlot(string username)
        {

            string filepath = ($"{username}.csv");

            try
            {
                if (!File.Exists(filepath))
                {
                    using (StreamWriter writer = new StreamWriter(filepath))
                    {
                        writer.WriteLine("PARKING SLOT,DATE OF RESERVATION,TIME OF ARRIVAL,HOURS,AMOUNT");
                        writer.WriteLine($"{slot},{dateReserved},{timeArrival},{hours},{price}");
                    }
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(filepath, true))
                    {
                        writer.WriteLine($"{slot},{dateReserved},{timeArrival},{hours},{price}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}