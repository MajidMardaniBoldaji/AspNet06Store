using System.ComponentModel.DataAnnotations;

namespace AspNet06Store.ShopUI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName{ get; set; }
        public string Password{ get; set; }
        public string FullName{ get; set; }
        public string Tell{ get; set; }
        public string Mobile{ get; set; }
        public string Email{ get; set; }
        public string City{ get; set; }
        public string Address{ get; set; }
    }
}
