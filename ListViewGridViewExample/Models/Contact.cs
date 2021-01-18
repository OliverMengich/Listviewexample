using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewGridViewExample.Models
{
    
    class Contact
    {
        public ObservableCollection<Contact> Contacts = new ObservableCollection<Contact>();

        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string COmpany { get; set; }
        public ObservableCollection<Contact> Manage()
        {

            Contacts.Add(new Contact { FirstName = "Oliver ", LastName = "Kipkemei ", COmpany = "Zee Music " });
            Contacts.Add(new Contact { FirstName = "Thiago ", LastName = "Silva ", COmpany = "Chelsea" });
            Contacts.Add(new Contact { FirstName = "Gabriel ", LastName = "Maghalhes ", COmpany = "Arsenal " });
            Contacts.Add(new Contact { FirstName = "Kieran", LastName = "Tierney ", COmpany = "Arseanal " });

            return Contacts;
        }
    }
    
}
