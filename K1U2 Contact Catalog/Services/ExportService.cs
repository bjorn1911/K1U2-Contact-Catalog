using K1U2_Contact_Catalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1U2_Contact_Catalog.Services
{
    public static class ExportService
    {
        public static string ToCsv(Dictionary<int, Contact> contacts)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Id,Name,Email,Tags");
            foreach (var c in contacts)
            {
                //var tags = string.Join('|', c.Value.GetTagsAsString);
                sb.AppendLine($"{c.Value.GetID},{c.Value.GetName},{c.Value.GetEmail},{c.Value.GetTagsAsString}");
            }
            return sb.ToString();
        }
    }
}
