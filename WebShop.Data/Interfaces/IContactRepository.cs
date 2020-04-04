using System.Threading.Tasks;
using WebShop.Core.Entities;

namespace WebShop.Data.Interfaces
{
    public interface IContactRepository
    {
        Task<Contact> SendMessage(Contact contact);
        Task<Contact> Subscribe(string address);
    }
}
