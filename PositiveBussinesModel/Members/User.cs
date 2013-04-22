using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using PositiveBussinesModel.Content.PublishingItems;

namespace PositiveBussinesModel.Members
{
    public class User
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Oras { get; set; }
        public string Judet { get; set; }
        public string Email { get; set; }
        public string Institution { get; set; }
        public Guid UserId { get; set; }
        public string  Description { get; set; }
        public DateTime BirthDate { get; set; }
        public string PictureUrl { get; set; }
        public bool IsAdmin { get; set; }
        public string Password { get; set; }
        public bool AuthState { get; set; }
        public int Ranking { get; set; }
        
        private List<Article> joinedGroups;
        public virtual List<Article> JoinedGroups
        {
            get
            {
              joinedGroups.ForEach(t=>t.Users.Remove(this));
                return joinedGroups;
            }
            set { joinedGroups = value; }
        }

        public User()
        {
            JoinedGroups = new List<Article>();
        }

    }
}
