namespace Contract.Repository.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public int AuthorizedDocumentType { get; set; }
        public string AuthorizedDocumentNumber { get; set; }

    }
}
