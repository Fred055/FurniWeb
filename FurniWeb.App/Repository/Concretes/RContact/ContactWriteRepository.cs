using FurniWeb.App.Context;
using FurniWeb.App.Entities;
using FurniWeb.App.Repository.Abstracts.RContact;

namespace FurniWeb.App.Repository.Concretes.RContact
{
    public class ContactWriteRepository : WriteRepository<Contact>, IContactWriteRepository
    {
        public ContactWriteRepository(AppDbContext context) : base(context)
        {
        }
    }


}
