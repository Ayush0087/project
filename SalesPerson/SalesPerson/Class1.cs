using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace SalesPerson
{
    class SalesPerson
    {
        //fields
        private string _salesPersonName;
        private int _salesPersonId;
        private string _salesPersonMobileno;
        private string _salesPersonEmail;
        int x = 1;

        //property
        public string SalesPersonName
        {
            set
            {
                Regex regex = new Regex("^[a-zA-Z. ]*$");
                bool b = regex.IsMatch(value);
                if (b == true)
                {
                    _salesPersonName = value;
                }
                else
                {
                    throw new Exception("SalesPerson  name should calculate alphabet only");
                }
            }
            get
            {
                return _salesPersonName;
            }


        }

        public string SalesPersonMobileno
        {
            set
            {
                Regex regex = new Regex("^[+91]{3}[0-9]{10}*$");
                bool b = regex.IsMatch(value);
                if (b == true)
                {
                    _salesPersonMobileno = value;
                }

            }
            get
            {
                return _salesPersonMobileno;
            }
        }

        public string SalesPersonEmail
        {
            set
            {
                Regex regex = new Regex("^[+91]{3}[0-9]{10}*$");
                bool b = regex.IsMatch(value);
                if (b == true)
                {
                    _salesPersonEmail = value;
                }

            }
            get
            {
                return _salesPersonEmail;
            }
        }
        public SalesPerson()
        {

        }

        public SalesPerson(string SalespersonNmae, string SalespersonMobileNo, string SalesPersonEmail)
        {
            _salesPersonName = SalespersonNmae;
            _salesPersonMobileno = SalespersonMobileNo;
            _salesPersonEmail = SalesPersonEmail;
            _salesPersonId = x;
            x++;

        }

        public static List<SalesPerson> SalesPersonList = new List<SalesPerson>();


        public void AddSalesPerson()
        {
            Console.WriteLine("Enter your Name ");
            SalesPersonName = Console.ReadLine();
            Console.WriteLine("Enter your Mobileno. ");
            SalesPersonMobileno = Console.ReadLine();
            Console.WriteLine("Enter your Email ");
            SalesPersonEmail = Console.ReadLine();
            SalesPersonList.Add(new SalesPerson(SalesPersonName, SalesPersonMobileno, SalesPersonEmail));

        }
        public void RemoveSalesPerson(int SalesPersonId)
        {
            SalesPersonList.RemoveAt(SalesPersonId - 1);
        }
        int choice;
        public void UpdateSalesPersonDetails()
        {
            Console.WriteLine("Choose the detail to be updated" );
            Console.WriteLine("Choose1: Update SalesPersonName ");
            Console.WriteLine("Choose2: Update SalesPerson Mobile number");
            Console.WriteLine("Choose3: update Sales person Email");
            choice = Convert.ToInt32(Console.ReadLine());

            if(choice==1)
            {
                Console.WriteLine("Update SalesPerson Name");
                _salesPersonName = Console.ReadLine();

            }
            else if(choice==2)
            {
                Console.WriteLine("Update SalesPersonMobileNo");
                _salesPersonMobileno = Console.ReadLine();

            }
            else if (choice == 3)
            {
                Console.WriteLine("Update SalesPersonEmail");
                _salesPersonEmail = Console.ReadLine();

            }





        }


        public void ViewSalespersonProfile()

        {
            Console.WriteLine("SalesPersonDetails");
            Console.WriteLine("Sales Person Name :  " +"  "  + SalesPersonName);
            Console.WriteLine("Sales Person Email:  " + "  "  + SalesPersonMobileno);
            Console.WriteLine("Sales Person Mobileno :  " + "  "  + SalesPersonEmail);
            Console.WriteLine("SalesPersonId :  " +"  " + _salesPersonId);


        }



    }
}
