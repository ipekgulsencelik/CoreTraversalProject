using Traversal.DataAccessLayer.Concrete;
using Traversal.WebUI.CQRS.Commands.DestinationCommands;

namespace Traversal.WebUI.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;
        
        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }
        
        public void Handle(UpdateDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.DestinationID);

            values.City = command.City;
            values.DayNight = command.DayNight;
            values.Price = command.Price;

            _context.SaveChanges();
        }
    }
}