using System.ComponentModel.DataAnnotations;

namespace OnlineSweetShopy.Models
{
    public class AspNetUser
    {
        [Key]
        public string id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public  string MobileNumber{get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string ZipCode{ get; set; }
        public string Role{ get; set; }



    }
}
