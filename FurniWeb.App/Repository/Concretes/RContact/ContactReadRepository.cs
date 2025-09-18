using FurniWeb.App.Context;
using FurniWeb.App.Entities;
using FurniWeb.App.Repository.Abstracts.RContact;

namespace FurniWeb.App.Repository.Concretes.RContact
{
    public class ContactReadRepository : ReadRepository<Contact>, IContactReadRepository
    {
        public ContactReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
