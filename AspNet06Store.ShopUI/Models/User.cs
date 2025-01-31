using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace AspNet06Store.ShopUI.Models
{
    public class User
    {     
        public int Id { get; set; }
        [AllowNull]
        public string UserName { get; set; }
        [AllowNull]
        public string Password { get; set; }
        [AllowNull]
        public string FullName { get; set; }
        [AllowNull]
        public string City { get; set; }
        [AllowNull]
        public string Address { get; set; }
        [AllowNull]
        public string Tell { get; set; }
        [AllowNull]
        public string Mobile { get; set; }
        [AllowNull]
        public string Email { get; set; }
    }
}
