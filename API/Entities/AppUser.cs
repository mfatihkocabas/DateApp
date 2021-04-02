using System;
using System.Collections.Generic;
using API.Extentions;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public byte[] PasswordHash{ get; set; }

        public byte[] PasswordSalt{ get; set; }

        public DateTime DateTimeBirth{ get; set; }

        public string KnownAs{ get; set; }

        public DateTime Created { get; set; }

        public DateTime LastActive { get; set; }

        public string Introduction { get; set; }

        public string LookingFor { get; set; }

        public string Interests { get; set; }

        public string City { get; set; }

        public string Country { get; set;}

        public ICollection<Photo> Photos{ get; set;}

        public int GetAge()
        {
            return DateTimeBirth.CalculateAge();
        }



        
    }
}