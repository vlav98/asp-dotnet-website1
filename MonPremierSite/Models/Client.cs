using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonPremierSite.Models
{
    public class Client
    {
        public int Id{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username{ get; set; }
        public string Email { get; set; }
    }

    public class Clients
    {
        public List<Client> ObtenirListeClients()
        {
            return new List<Client>
            {
                new Client { Id = 1, FirstName = "Nicolas", LastName = "N", Username = "nicolasn", Email = "nicolas@gmail.com"},
                new Client { Id = 2, FirstName = "Delphine", LastName = "N", Username = "delphinen", Email = "delphine@gmail.com"},
                new Client { Id = 3, FirstName = "Jérémie", LastName = "N", Username = "jeremien", Email = "jeremie@gmail.com"},
                new Client { Id = 4, FirstName = "Timéo", LastName = "N", Username = "timeon", Email = "timeo@gmail.com"}
            };
        }
    }
}