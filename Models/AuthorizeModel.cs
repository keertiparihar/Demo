using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminProject.Models
{
    public class AuthorizeModel
    {
        public int Id { get; set; }
        public string RollName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}