using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Values;
using Microsoft.EntityFrameworkCore;

namespace AddressBook.Contacts
{
    public class Contact : FullAuditedEntity
    {
        public virtual string Name { get; protected set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public virtual DateTime BirthDate { get; protected set; }

        public virtual Address Address { get; protected set; }

        public virtual ICollection<PhoneNumber> PhoneNumbers { get; protected set; }
    }

    [Owned]
    public class Address : ValueObject
    {
        public virtual string Street { get; init; }
        public virtual int Number { get; init; }
        public virtual string City { get; init; }
        public virtual string Country { get; init; }

        // Requires to implement this method to return properties.
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Street;
            yield return Number;
            yield return City;
            yield return Country;
        }
    }

    public class PhoneNumber : Entity
    {
        [DataType(DataType.PhoneNumber)]
        public virtual int Number { get; protected set; }
        public virtual Contact Contact { get; protected set; }
    }
}
