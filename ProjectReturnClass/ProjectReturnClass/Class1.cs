using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProjectReturnClass
{
  
    class ReturnOnlineOrder

    {
        //fields
        private static int _returnId=0;
        private string _PurposeofReturn;
       // private string _statusOfReturn;
        private string _noOfReturn;
        private DateTime _dateOfReturn;

        public static int ReturnId { get => _returnId; set => _returnId = value; }

        public string PurposeOfReturn
        {
            set
            {
                Console.WriteLine("Choose purpose of return");
                Console.WriteLine("1: Unsatisfactory Product ");
                Console.WriteLine("2: Defective product");
                Console.WriteLine("3: Incomplete Product ");
                Console.WriteLine("4: Wrong Product Ordered ");
                Console.WriteLine("5: wrong Product shipped");
                _PurposeofReturn = Console.ReadLine();

                Regex regex = new Regex("^[12345]$");
                bool b = regex.IsMatch(value);
                if (b == true)
                {
                    int a = int.Parse(value);
                    if(a==1)
                    {
                        _PurposeofReturn = "Unsatisfactory Product";
                    }
                    if(a==2)
                    {
                        _PurposeofReturn = "Defective product";
                    }
                    if(a == 3)
                    {
                        _PurposeofReturn = "Incomplete Product";
                    }
                    if (a == 4)
                    {
                        _PurposeofReturn = "Wrong Product Ordered";
                    }
                    if (a == 5)
                    {
                        _PurposeofReturn = "wrong Product shipped";
                    }

                }
                else
                {
                    throw new Exception("incorrect returnid");
                }

            }

            get
            {
                return _PurposeofReturn;
            }

        }


        public string NoOfReturn
        {
            set
            {
                Console.WriteLine("Enter number of return product ");
                _noOfReturn = Console.ReadLine();
                _noOfReturn = value;
            }
            get
            {
                return _noOfReturn;
            }

        }

        public DateTime DateOfReturn { get => DateOfReturn; set => DateOfReturn = value; }
       
        //constructor
        public ReturnOnlineOrder (int NoOfReturn, int PurposeOfReturn)
        {
            this.NoOfReturn = _noOfReturn;
            this.PurposeOfReturn = _PurposeofReturn;
            
        }
        
        //method
        InitiateReturn(orderid, productid)
        {
            ReturnId 
        }


    }
}
