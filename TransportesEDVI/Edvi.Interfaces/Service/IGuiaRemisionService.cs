using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edvi.Models.Model;

namespace Edvi.Interfaces.Service
{
    public interface IGuiaRemisionService
    {
        //GuiaRemision GetFromGuiaRemisionById(Int32 id);
        void AddGuiaRemision(GuiaRemision guiaRemision);
        IList<GuiaRemision> AllGuiaRemision();
    }
}
