using MyCofeeProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCofeeProject.Concrete
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long NationalityId { get; set; }
    }
}
