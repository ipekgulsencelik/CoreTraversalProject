using Traversal.DataAccessLayer.Concrete;
using Traversal.WebUI.CQRS.Queries.DestinationQueries;
using Traversal.WebUI.CQRS.Results.DestinationResults;

namespace Traversal.WebUI.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIDQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetDestinationByIDQueryResult Handle(GetDestinationByIDQuery query)
        {
            var values = _context.Destinations.Find(query.Id);
            return new GetDestinationByIDQueryResult
            {
                DestinationID = values.DestinationID,
                City = values.City,
                DayNight = values.DayNight,
                Price = values.Price
            };
        }
    }
}