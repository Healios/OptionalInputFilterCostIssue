using OptionalInputFilterCostIssue.Entities;

namespace OptionalInputFilterCostIssue.Queries
{
    [QueryType]
    public class ContactQuery
    {
        [UseOffsetPaging]
        [UseFiltering]
        [UseSorting]
        public IEnumerable<Contact> ReadAllContacts() => new [] { new Contact("Test", "test@gmail.com"), new Contact("Issue", "tissue@gmail.com") };
    }
}
