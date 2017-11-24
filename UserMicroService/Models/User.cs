using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserMicroService.Models
{
    public class User
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Address { get; set; }
        public String ZipCode { get; set; }
        public String CityName { get; set; }
        public String CountryName { get; set; }
        public String Phone { get; set; }
        public bool Active { get; set; }
        public ActiveStateEnum Active { get; set; }
    }
}