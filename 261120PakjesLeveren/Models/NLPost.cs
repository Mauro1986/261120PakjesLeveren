using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _261120PakjesLeveren.Models
{
   public class NLPost : Bpost
    {
        public override void PackageRecived()
        {
            Console.WriteLine("Package recived by NL Post");
        }

        public override void Deliverd()
        {
            Console.WriteLine("Package is deliverd by NL Post");
            SmsConfirmationToBPost();
        }
    }
}
