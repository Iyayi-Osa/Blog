using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using BlogCoursework.Models;
using Microsoft.EntityFrameworkCore;
namespace BlogCoursework.Models
{
public class AuthModel
 {
 public string? Email { get; set; }
 public string? Password { get; set; }
 }
}