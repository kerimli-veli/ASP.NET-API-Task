using Domain.BaseEntities;
using DotNetOpenAuth.OpenId.Extensions.SimpleRegistration;
using System.Reflection;
using static Domain.Enum.EnumType;

namespace Domain.Entities;

public class User : BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Username { get; set; }
    public string FatherName { get; set; }
    public string Email { get; set; } //email olmasin validasiya edin
    public string PasswordHash { get; set; }
    public string Address { get; set; }
    public string MobilePhone { get; set; } // "+994 le bashlamasin validasiya edin"
    public string CardNumber { get; set; } // 16 reqemi validasiya edirsiniz
    public string TableNumber { get; set; }
    public DateTime Birthdate { get; set; }
    public DateTime DateOfEmployment { get; set; }
    public DateTime DateOfDismissal { get; set; }
    public string Note { get; set; }
    public Enum.EnumType.Gender Gender { get; set; }  // Enum
    public UserType UserType { get; set; } // Enum
}