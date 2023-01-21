using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Traversal.DataAccessLayer.Concrete;
using Traversal.EntityLayer.Concrete;
using Traversal.WebUI.CQRS.Commands.GuideCommands;

namespace Traversal.WebUI.CQRS.Handlers.GuideHandlers
{
    public class CreateGuideCommanHandler : IRequestHandler<CreateGuideCommand>
    {
        private readonly Context _context;

        public CreateGuideCommanHandler(Context context)
        {
            _context = context;
        }
        
        public async Task<Unit> Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
            _context.Guides.Add(new Guide
            {
                Name = request.Name,
                Description = request.Description,
                Status = true
            });
            await _context.SaveChangesAsync();
            
            return Unit.Value;
        }
    }
}