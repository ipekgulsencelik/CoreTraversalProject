using System.Collections.Generic;
using Traversal.EntityLayer.Concrete;

namespace Traversal.BusinessLayer.Abstract
{
    public interface IDestinationService : IGenericService<Destination>
    {
        public Destination TGetDestinationWithGuide(int id);
        public List<Destination> TGetLast4Destinations();
    }
}
