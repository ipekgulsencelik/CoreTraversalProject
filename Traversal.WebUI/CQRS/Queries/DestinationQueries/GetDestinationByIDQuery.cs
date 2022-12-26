namespace Traversal.WebUI.CQRS.Queries.DestinationQueries
{
    public class GetDestinationByIDQuery
    {
        public GetDestinationByIDQuery(int id)
        {
            this.Id = id;
        }

        public int Id { get; set; }
    }
}
