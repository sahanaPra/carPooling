using Contract.Domain.Models.Enums;

namespace Contract.Domain.Models
{
    public class User
    {   
        public int Id { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public AuthorizedEntityTypeEnum AuthorizedDocumentType { get; set; }
        public string AuthorizedDocumentNumber { get; set; }
    }
}
