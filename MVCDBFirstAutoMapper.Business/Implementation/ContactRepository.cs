using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCDBFirstAutoMapper.Business.Interface;
using MVCDBFirstAutoMapper.Business.ModelEntity;
using MVCDBFirstAutoMapper.Data;
using System.Data.Entity;

namespace MVCDBFirstAutoMapper.Business.Implementation
{
    public class ContactRepository : BusinessBase, IContactRepository
    {
        public List<ContactDTO> GetContacts()
        {
            return _CustomMapping.Mapper.Map<List<Contact>, List<ContactDTO>>(_db.Contacts.Where(x => x.Status == true).ToList());
        }

        public ContactDTO GetContactbyId(int Id)
        {
            return _CustomMapping.Mapper.Map<Contact, ContactDTO>(_db.Contacts.FirstOrDefault(x => x.Id == Id));
        }
        public void CreateContact(ContactDTO Contactobject)
        {
            if (Contactobject != null)
            {
                Contact entity = _CustomMapping.Mapper.Map<ContactDTO, Contact>(Contactobject);
                if (entity != null)
                {
                    _db.Contacts.Add(entity);
                    _db.SaveChanges();
                }
            }
        }

        public void UpdateContact(ContactDTO Contactobject)
        {
            if (Contactobject != null)
            {
                Contact entity = _db.Contacts.Find(Contactobject.Id);
                if (entity != null)
                {
                    entity.FirstName = Contactobject.FirstName;
                    entity.LastName = Contactobject.LastName;
                    entity.Phone = Contactobject.Phone;
                    entity.Email = Contactobject.Email;
                    entity.Status = Contactobject.Status;

                    _db.Entry(entity).State = EntityState.Modified;
                    _db.SaveChanges();
                }
            }
        }

        public void DeleteContact(ContactDTO Contactobject)
        {
            if (Contactobject != null)
            {
                Contact entity = _db.Contacts.Find(Contactobject.Id);
                if (entity != null)
                {
                    entity.Status = false;

                    _db.Entry(entity).State = EntityState.Modified;
                    _db.SaveChanges();

                }
            }

        }
    }
}
