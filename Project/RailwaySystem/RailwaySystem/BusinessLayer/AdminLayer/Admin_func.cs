using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwaySystem.BusinessLayer.AdminLayer
{
    class Admin_func
    {
        //using (var Rb = new RailDBEntities())
        static RailDBEntities Rb = new RailDBEntities();
        static train t = new train();
        public static void AdminLogin()
        {

        }
        public static void ValidateAdmin()
        {
            Console.Write("Enter AdminId: ");
    
            int Aid = int.Parse(Console.ReadLine());
            Console.Write("Enter Password: ");
            string pass = Console.ReadLine();

            bool vl = validate(Aid, pass);
            if (vl)
            {
                AdminOptions();
            }
            else
            {
                Console.WriteLine("Invalid UserId or Password\n TRY AGAIN.....");
                ValidateAdmin();

            }
        }
        private static bool validate(int Aid, string pass)
        {
            var admin = Rb.admins.FirstOrDefault(x => x.admin_id == Aid && x.admin_password == pass);
            return admin != null;
        }
        public static void AdminOptions()
        {
            Console.WriteLine("============================================================================");
            Console.WriteLine("\t\tWelcome To Admin Portal");
            Console.WriteLine("============================================================================");
            Console.WriteLine("\t1. Add Train -> Press 1");
            Console.WriteLine("\t2. Modify Train -> Press 2");
            Console.WriteLine("\t3. Delete Train -> Press 3");
            Console.WriteLine("\t4. Show trains Details -> Press 4");
            Console.WriteLine("\t5. Exit");
            Console.Write("YOUR CHOICE:: ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("-------------------------------------------------");
                    Addtrain();
                    Console.WriteLine("-------------------------------------------------");
                    break;
                case 2:
                    Console.WriteLine("-------------------------------------------------");
                    UpdateTrain();
                    Console.WriteLine("-------------------------------------------------");
                    break;

                case 3:
                    Console.WriteLine("-------------------------------------------------");
                    DeleteTrain();
                    Console.WriteLine("-------------------------------------------------");
                    break;
                case 4:
                    Console.WriteLine("-------------------------------------------------");
                    ShowTrainAdmin();
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Press TAB or ENTER to Continue.....");
                    Console.ReadKey();
                    Console.Clear();
                    AdminOptions();
                  
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Enter Valid Options from above...");
                    AdminOptions();
                    break;
            }

        }
        public static void Addtrain()
        {
            
            train t = new train();
            Console.Write("Enter Train Number: ");
            t.train_no = int.Parse(Console.ReadLine());
            Console.Write("Enter Train Name: ");
            t.train_name = Console.ReadLine();
            Console.Write("Enter Source: ");
            t.source = Console.ReadLine();
            Console.Write("Enter Destination: ");
            t.destination = Console.ReadLine();
            t.isActive = "Active";
            Rb.trains.Add(t);


            Rb.SaveChanges();


            // Adding seats of new trains
            Console.Write("Enter 1AC Seats: ");
            int firstAcSeats = int.Parse(Console.ReadLine());
            Console.Write("Enter 2AC Seats: ");
            int SecAcSeats = int.Parse(Console.ReadLine());
            Console.Write("Enter SL Seats: ");
            int SLSeats = int.Parse(Console.ReadLine());
            Rb.AddclassSeats(t.train_no, firstAcSeats, SecAcSeats, SLSeats);    // calling procedure to add the train seats of 1ac,2ac,and sl class.

            // Adding fare of new trains
            Console.Write("Enter 1AC Fare: ");
            int firstAcSeatsfare = int.Parse(Console.ReadLine());
            Console.Write("Enter 2AC Seats: ");
            int SecAcSeatsfare = int.Parse(Console.ReadLine());
            Console.Write("Enter SL Seats: ");
            int SLSeatsfare = int.Parse(Console.ReadLine());
            Rb.AddclassFair(t.train_no, firstAcSeatsfare, SecAcSeatsfare, SLSeatsfare); // calling procedure to add the fares....

            //Rb.SaveChanges();
            Console.WriteLine("Train Added Successfull");

        }
        public static void UpdateTrain()
        {
            UserLayer.User_func.ShowTrain();
            Console.WriteLine();
            Console.Write("Enter the Train Number You want to modify: ");
            int trNo = int.Parse(Console.ReadLine());
            var updTrNo = Rb.trains.Find(trNo);
            if (updTrNo != null)
            {
                Console.WriteLine("Are You Sure You Want to update Y/N");
                string ans = Console.ReadLine().ToUpper();
                if (ans == "Y")
                {
                    Console.WriteLine($"Enter Train New Name for Train Number: {trNo}");
                    string tname = Console.ReadLine();
                    updTrNo.train_name = tname;
                    Rb.SaveChanges();
                    Console.WriteLine("Your Train Name Has been modified...\n");
                  
                    AdminOptions();

                }
                else
                {
                    Console.WriteLine("Train Could not found....");
                    AdminOptions();
                }

            }
            else
            {
                AdminOptions();

            }



        }
        public static void DeleteTrain()
        {
            UserLayer.User_func.ShowTrain();
            Console.WriteLine("Enter Train Number You want to delete: ");
            int trNo = int.Parse(Console.ReadLine());
            var trainRemove = Rb.trains.Find(trNo);
            if(trainRemove!=null)
            {
                Console.WriteLine("Are You Sure You Want to delete: Y/N");
                string ans = Console.ReadLine().ToUpper();
                if(ans=="Y")
                {

                    //Rb.trains.Remove(trainRemove);

                    //Rb.SaveChanges();
                    trainRemove.isActive = "InActive";              // implementing soft delete....
                    Rb.SaveChanges();
                    Console.WriteLine("Your Train Has been Deleted....\n");
                    AdminOptions();
                   
                }
                else
                {
                    AdminOptions();
                }
               
            }
            else
            {
                Console.WriteLine("No Train Found");
                AdminOptions();
            }
        }

        public static void ShowTrainAdmin()
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("\t\t---Train Details---");
            Console.WriteLine("-------------------------------------------------");
            //var trains = Rb.trains.Where(t => t.isActive == "Active").ToList();
            var trains = Rb.trains.ToList();
            int ct = 1;
            Console.WriteLine($"->\tTrain-No\t\tTrain-Name\t\tSource\t\tDestination\t\tStatus");
            foreach (var train in trains)
            {
                Console.WriteLine($"{ct}\t{train.train_no}\t\t\t{train.train_name}\t\t{train.source}\t{train.destination}\t\t\t{train.isActive}");
                ct++;

            }
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
