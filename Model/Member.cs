using System;
using System.Collections.Generic;


  namespace _1dv607_WS2.Model {
  public class Member {
      private string _name;
      private string _personalNumber;
      private int _memberId;
      private List<Boat> _boats;

      public string Name {
        get { return _name; }
        set { _name = value; }
      }

      public string PersonalNumber {
        get { return _personalNumber; }
        set { _personalNumber = value; }
      }

      public int MemberId {
        get { return _memberId; }
        set { _memberId = value; }
      }

      public Member(string name, string personNumber, int memberId) {
        Name = name;
        PersonalNumber = personNumber;
        MemberId = memberId;
      }

      public void AddBoat(Boat boat) {

      }
    }
  }
  