using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{

    public class OperationClaim : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }//Claim'lerimi veri tabanında tutuyorum. bu claimler operasyon bazlı veya 'admin','editor' vs şeklinde de olabilir.
    }
}
