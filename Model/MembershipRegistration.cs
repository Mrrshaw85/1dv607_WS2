using System;

namespace _1dv607_WS2.Model {
  public class MembershipRegistration {
    public Member Register(string name, string pNum, int id){
      Member member = new Member(name, pNum, id);

      return member;
    }
  }
}