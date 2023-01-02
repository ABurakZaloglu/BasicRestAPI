using System;
namespace ContactsAPI.Models
{
	public class UpdateContactRequest
	{
        public string FullName { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}

