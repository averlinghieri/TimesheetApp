namespace TimesheetApp
{
    // Please note - THIS IS A BAD APPLICATION - DO NOT REPLICATE WHAT IT DOES
    // This application was designed to simulate a poorly-built application that
    // you need to support. Do not follow any of these practices. This is for 
    // demonstration purposes only. You have been warned.
    class Program
    {
        static void Main(string[] args)
        {
            string w;
            int i, t, total;
            List<TimeSheetEntry> entries = new List<TimeSheetEntry>();
            Console.Write("Company you worked for: ");
            w = Console.ReadLine();
            Console.Write("How long did you do it for: ");
            t = int.Parse(Console.ReadLine());
            TimeSheetEntry entry = new TimeSheetEntry();
            entry.HoursWorked = t;
            entry.CustomerCompany = w;
            entries.Add(entry);
            Console.Write("Do you want to enter more time (yes/no): ");

            string answer = Console.ReadLine();

            bool cont = false;

            if (answer.ToLower() == "yes")
            {
                cont = true;
            }

            //bool cont = bool.Parse(Console.ReadLine());
            while (cont == true)
            {
                Console.Write("Company you worked for: ");
                w = Console.ReadLine();
                Console.Write("How long did you do it for: ");
                t = int.Parse(Console.ReadLine());
                entry = new TimeSheetEntry();
                entry.HoursWorked = t;
                entry.CustomerCompany = w;
                entries.Add(entry);
                Console.Write("Do you want to enter more time:");

                answer = Console.ReadLine();

                cont = false;

                if (answer.ToLower() == "yes")
                {
                    cont = true;
                }
                //bool cont = bool.Parse(Console.ReadLine());
            }

            total = 0;

            foreach (var e in entries)
            {
                if (e.CustomerCompany.ToLower().Contains("acme"))
                {
                    total += e.HoursWorked;
                }
            }

            //for (i = 0; i < entries.Count; i++)
            //{
            //    if (entries[i].CustomerCompany.ToLower().Contains("acme"))
            //    {
            //        total += entries[i].HoursWorked;
            //    }
            //}
            Console.WriteLine("Simulating Sending email to ACME");
            Console.WriteLine("Your bill is $" + total * 150 + " for the hours worked.");

            total = 0;

            foreach (var e in entries)
            {
                if (e.CustomerCompany.ToLower().Contains("abc"))
                {
                    total += e.HoursWorked;
                }
            }

            //for (i = 0; i < entries.Count; i++)
            //{
            //    if (entries[i].CustomerCompany.ToLower().Contains("abc"))
            //    {
            //        total += entries[i].HoursWorked;
            //    }
            //}
            Console.WriteLine("Simulating Sending email to ABC");
            Console.WriteLine("Your bill is $" + total * 125 + " for the hours worked.");

            total = 0;

            foreach (var e in entries)
            {
                total += e.HoursWorked;
            }

            //for (i = 0; i < entries.Count; i++)
            //{
            //    total += entries[i].HoursWorked;
            //}
            //if total greater than 40 hours is an overtime

            if (total > 40)
            {
                Console.WriteLine("You will get paid $" + ((total - 40) * 15) + (40 * 10) + " for your work.");
            }
            else
            {
                Console.WriteLine("You will get paid $" + total * 10 + " for your time.");
            }
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }
    }

    public class TimeSheetEntry
    {
        public string CustomerCompany;
        public int HoursWorked;
    }
}
