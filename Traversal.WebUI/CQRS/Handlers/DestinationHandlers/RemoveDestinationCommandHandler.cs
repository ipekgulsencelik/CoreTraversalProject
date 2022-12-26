﻿using Traversal.DataAccessLayer.Concrete;
using Traversal.WebUI.CQRS.Commands.DestinationCommands;

namespace Traversal.WebUI.CQRS.Handlers.DestinationHandlers
{
    public class RemoveDestinationCommandHandler
    {
        private readonly Context _context;

        public RemoveDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.Id);

            _context.Destinations.Remove(values);
            _context.SaveChanges();
        }
    }
}
