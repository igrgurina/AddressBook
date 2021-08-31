using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace AddressBook.Contacts.Dto
{
    [AutoMap(typeof(Contact))]
    public class ContactDto : FullAuditedEntityDto
    {
        [Required]
        [StringLength(Contact.MaxNameLength)]
        public string Name { get; set; }
        public string AddressStreet { get; set; }
        public int AddressNumber { get; set; }
        public string AddressCity { get; set; }
        public string AddressCountry { get; set; }

        public DateTime BirthDate { get; set; }

        public List<string> PhoneNumbers { get; set; }
    }
}
