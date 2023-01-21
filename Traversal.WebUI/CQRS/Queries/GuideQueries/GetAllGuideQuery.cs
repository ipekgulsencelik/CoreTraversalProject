using MediatR;
using System.Collections.Generic;
using Traversal.WebUI.CQRS.Results.GuideResults;

namespace Traversal.WebUI.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery : IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
