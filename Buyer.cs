using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    class Buyer
    {
          
                int bid, bno;
                string bname, bpswd, bmail;

                public int Bid { get => bid; set => bid = value; }
                public string Bname { get => bname; set => bname = value; }
                public string Bpswd { get => bpswd; set => bpswd = value; }
                public string Bmail { get => bmail; set => bmail = value; }
                public int Bno { get => bno; set => bno = value; }

                public Buyer() { }
                public Buyer(int bid, string bname, string bpswd, string bmail, int bno)
        {
            this.bid = bid;
            this.bname = bname;
            this.bpswd = bpswd;
            this.bmail = bmail;
            this.bno = bno;


        }
    }
}
    //int id;
    //string username;
    //string password;
    //string email_id;
    //int mobile_no;
    //public int Id { get => id; set => id = value; }
    //public string Username { get => username; set => username = value; }
    //public string Password { get => password; set => password = value; }
    //public string Email_id { get => email_id; set => email_id = value; }
    //public int Mobile_no { get => mobile_no; set => mobile_no = value; }

    //public Buyer(int id, string username, string password, string email_id, int mobile_no)
    //{
    //    this.Id = id;
    //    this.Username = username;
    //    this.Password = password;
    //    this.Email_id = email_id;
    //    this.Mobile_no = mobile_no;

    //}
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









