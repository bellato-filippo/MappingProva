using Dapper.FluentMap.Dommel.Mapping;
using MappingProva.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingProva.Mapping
{
    internal class PortoMap : DommelEntityMap<Porto>
    {
        public PortoMap()
        {
            ToTable("Porto");
            Map(x => x.Id).ToColumn("IDPorto").IsIdentity().IsKey();
            Map(x => x.Descrizione).ToColumn("DSPorto");
            Map(x => x.Annullato).ToColumn("Annullato");
            Map(x => x.IdInsieme).ToColumn("Insieme");
        }
    }
}
