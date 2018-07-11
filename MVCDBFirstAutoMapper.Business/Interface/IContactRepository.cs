using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCDBFirstAutoMapper.Business.ModelEntity;

namespace MVCDBFirstAutoMapper.Business.Interface
{
    public interface IContactRepository
    {
        List<ContactDTO> GetContacts();

        ContactDTO GetContactbyId(int Id);

        void CreateContact(ContactDTO Contact);

        void UpdateContact(ContactDTO Contact);

        void DeleteContact(ContactDTO Contact);
    }
}
