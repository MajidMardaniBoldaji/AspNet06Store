
namespace AspNet06Store.ShopUI.Models
{
    public class UserRepository:IUserRepository
    {
        public StoreDbContext StoreDbContext { get; }
        public UserRepository(StoreDbContext storeDbContext)
        {
            StoreDbContext = storeDbContext;
        }

        public void Insert(User user)
        {
            StoreDbContext.Add(user);
            StoreDbContext.SaveChanges();   
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public User GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
