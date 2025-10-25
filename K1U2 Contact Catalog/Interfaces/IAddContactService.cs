using K1U2_Contact_Catalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1U2_Contact_Catalog.Interfaces
{
    public interface IAddContactService
    {
        public Contact AddContact(int ID, HashSet<string> EmailIndex);

    }
}
