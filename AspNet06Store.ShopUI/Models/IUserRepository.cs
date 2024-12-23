namespace AspNet06Store.ShopUI.Models
{
    public interface IUserRepository
    {
        public void Insert(User user);
        public void Update(User user);
        public void Delete(User user);  
        public void DeleteAll();    
        public User GetById(int id);    
        public User GetById(string id);
        public IEnumerable<User> GetAll();  

    }
}
