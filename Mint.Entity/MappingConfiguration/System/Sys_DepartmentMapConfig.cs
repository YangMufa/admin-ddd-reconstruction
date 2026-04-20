using Mint.Entity.MappingConfiguration;
using Mint.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mint.Entity.MappingConfiguration
{
    public class Sys_DepartmentMapConfig : EntityMappingConfiguration<Sys_Department>
    {
        public override void Map(EntityTypeBuilder<Sys_Department>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

