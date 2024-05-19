using System.Collections.Generic;
using System.IO;

namespace Park_C_Updated
{
    public static class ReservationService
    {
        private static string FilePath = @"Path\To\Your\UserName.csv"; // Update path appropriately
        public static Dictionary<string, bool> ReservedSlots = new Dictionary<string, bool>();

        public static void ReserveSlot(string slot)
        {
            ReservedSlots[slot] = true;
        }

        public static void UnreserveSlot(string slot)
        {
            ReservedSlots.Remove(slot);
        }

        public static bool IsSlotReserved(string slot)
        {
            return ReservedSlots.ContainsKey(slot) && ReservedSlots[slot];
        }

        public static void SaveCurrentReservation(User user)
        {
            List<User> reservations = ReadReservationData();
            var index = reservations.FindIndex(u => u.slot == user.slot);
            if (index != -1)
            {
                reservations[index] = user; // Update existing reservation
            }
            else
            {
                reservations.Add(user); // Add new reservation
            }
            WriteReservationData(reservations);
        }

        private static List<User> ReadReservationData()
        {
            List<User> reservations = new List<User>();
            if (File.Exists(FilePath))
            {
                using (StreamReader reader = new StreamReader(FilePath))
                {
                    string line;
                    reader.ReadLine(); // Skip header
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        User reservation = new User
                        {
                            slot = data[0],
                            dateReserved = data[1],
                            timeArrival = data[2],
                            hours = int.Parse(data[3]),
                            price = int.Parse(data[4])
                        };
                        reservations.Add(reservation);
                    }
                }
            }
            return reservations;
        }

        private static void WriteReservationData(List<User> reservations)
        {
            using (StreamWriter writer = new StreamWriter(FilePath, false))
            {
                writer.WriteLine("Parking Slot,Date,Time Arrival,Hours,Price");
                foreach (User reservation in reservations)
                {
                    writer.WriteLine($"{reservation.slot},{reservation.dateReserved},{reservation.timeArrival},{reservation.hours},{reservation.price}");
                }
            }
        }
    }
}
