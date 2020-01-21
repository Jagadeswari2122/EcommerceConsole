using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{

    class Buyerbo : Buyer
    {
        List<Buyer> lb = new List<Buyer>();
        public bool signin(int bid, string bpswd)
        {

            Buyer b = lb.Find(res => (bid.Equals(res.Bid)));
            if (b != null)
                return true;
            else
                return false;
            

        }
        public string Register(int bid, string bname, string bpswd, string bmail, int bno)
        {
            lb.Add(new Buyer(bid, bname, bpswd, bmail, bno));
            return "registered Successfully..!!!";
        }
    }
}
        //int id;
        //string username;
        //string password;
        //string email_id;
        //int mobile_no;

        //public void register(int id, string username,
        //                      string password,
        //                     string email_id,
        //                                int mobile_no)
        //{
        //    Console.WriteLine("enter the buyer Id");
        //    int i = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("enter the buyer username");
        //    string un = Console.ReadLine();
        //    Console.WriteLine("enter the buyer password");
        //    string pwd = Console.ReadLine();
        //    Console.WriteLine("enter the buyer email Id");
        //    string eid = Console.ReadLine();
        //    Console.WriteLine("enter the buyer mobile no");
        //    int mbl = Convert.ToInt32(Console.ReadLine());
        //}
        //public register()
        //{
        //    Console.WriteLine("Complete the registration process");

        //}
    


