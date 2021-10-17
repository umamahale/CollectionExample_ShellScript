using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBook1
    {
        public readonly contact[] contacts;

        public AddressBook1()
        {
            contacts = new contact[2]; ;
        }

        public void AddEntry(string name, string address)
        {
            contact AddContact = new contact(name, address);
            if (CheckEntry(name))
            {
                for (int i = 0; i < contacts.Length; i++)
                {
                    if (contacts[i] == null)
                    {
                        contacts[i] = AddContact;
                        Console.WriteLine("Address Book updated. {0} has been added!", name);
                        break;
                    }
                }
            }
        }

        private string existingContact = "";

        private bool CheckEntry(string name)
        {
            foreach (contact contact in contacts)
            {
                if (contact == null)
                {
                    break;
                }
                else if (contact != null && contact.ToString() != name)
                {
                    continue;
                }
                else if (contact.ToString() == name)
                {
                    existingContact = contact.ToString();
                    return false;
                }

            }
            return true;
        }

        public void RemoveEntry(string name)
        {
            if (!(CheckEntry(name)))
            {
                existingContact = null;
                Console.WriteLine("{0} removed from contacts", name);
            }
        }

        public string View()
        {
            string contactList = "";
            foreach (contact contact in contacts)
            {
                if (contact == null)
                {
                    break;
                }
                contactList += String.Format("Name: {0} -- Address: {1}" + Environment.NewLine, contact.Name, contact.Address);
            }
            return contactList;
            {

            }
        }
    }
}
