using BlogCoursework.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BlogCoursework.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string? RoleName { get; set; }
        [JsonIgnore]
        public List<User>? Users { get; set; }
    }
}