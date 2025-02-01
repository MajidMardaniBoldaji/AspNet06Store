using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace AspNet06Store.ShopUI.Models
{
    public class User
    {     
        public int Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string? FullName { get; set; }
        public bool IsConfirm{ get; set; }
    }
}
