using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1U2_Contact_Catalog.Models
{
    public class Contact
    {
        private int _id { get; set; }
        private string _name { get; set; }
        private string _email { get; set; }

        private List<string> _tags = new();

        public Contact(int ID)
        {
            _id = ID;
        }

        public int GetID()
        {
            return _id;
        }

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

        public void SetEmail(string email)
        {

            _email = email;
        }

        public string GetEmail()
        {
            return _email;
        }

        public string GetTagsAsString() // Returns all tags as a single string with each tag in brackets
        {
            string tags = "Tags: ";
            foreach (var tag in _tags) { tags += $"{tag} "; }
            return tags;
        }



    }            
}

