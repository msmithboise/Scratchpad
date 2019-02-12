using System.Collections.Generic;

namespace Practice
{
    class Member
{
  public string FirstName { get; set; }

  public string LastName { get; set; }

  public bool IsDependent { get; set; }

  List<Member> DependentCardHistory = new  List<Member>();

  List<Member> CardHistory = new List<Member>();

  public List<string> MembersList = new List<string>();

  public Member(string firstName, string lastName, bool isDependent)
  {
    FirstName = firstName;
    LastName = lastName;
    IsDependent = isDependent;
    

  }

//   public void ValidateStatus()
//   {
//     foreach (var member in Member)
//     {
        
//     }
//   }

}

}
    
        
