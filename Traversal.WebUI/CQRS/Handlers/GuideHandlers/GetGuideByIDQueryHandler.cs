﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Traversal.DataAccessLayer.Concrete;
using Traversal.WebUI.CQRS.Queries.GuideQueries;
using Traversal.WebUI.CQRS.Results.GuideResults;

namespace Traversal.WebUI.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIDQueryHandler : IRequestHandler<GetGuideByIDQuery, GetGuideByIDQueryResult>
    {
        private readonly Context _context;

        public GetGuideByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIDQueryResult> Handle(GetGuideByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.Id);
            
            return new GetGuideByIDQueryResult
            {
                GuideID = values.GuideID,
                Description = values.Description,
                Name = values.Name
            };
        }
    }
}
