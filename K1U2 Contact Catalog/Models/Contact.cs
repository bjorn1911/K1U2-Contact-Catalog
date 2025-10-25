using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1U2_Contact_Catalog.Models
{
    public class Contact
        {
            public string _name { get; set; }
            public string _email { get; set; }

            private List<string> _tags = new();

            public void SetName(string name)
            {
                _name = name;

            }

            public string GetName()
            {
                return _name;
            }

            public void AddTag(string tag)
            {
                _tags.Add(tag);
            }

            public bool SetEmail(string email)
            {
                if (IsValidEmail(email))
                {
                    _email = email;
                    return true;

                }
                else { return false; }
            }

            public string GetEmail()
            {
                return _email;
            }

            public string GetTagsAsString() // Returns all tags as a single string with each tag in brackets
            {
                string tags = "Tags: ";
                foreach (var tag in _tags) { tags += $"[{tag}]"; }
                return tags;
            }

            public

            static bool IsValidEmail(string email) // Stolen from the code we were given 
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return addr.Address == email;
                }
                catch { return false; }
            }

        }
}

