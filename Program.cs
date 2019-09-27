using System;
using System.Collections.Generic;
using _1dv607_WS2.Model;

namespace _1dv607_WS2
{
    class Program
    {
        static void Main(string[] args)
        {
          MembershipRegistration mReg = new MembershipRegistration();
            Console.WriteLine("Hello World!");
            List<Member> memberList = new List<Member>();
            memberList.Add(mReg.Register("John", "850101", 01));
            Console.WriteLine(memberList[0].Name);
        }
    }
}
