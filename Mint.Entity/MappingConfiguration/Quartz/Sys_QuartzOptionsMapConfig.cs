using Mint.Entity.MappingConfiguration;
using Mint.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mint.Entity.MappingConfiguration
{
    public class Sys_QuartzOptionsMapConfig : EntityMappingConfiguration<Sys_QuartzOptions>
    {
        public override void Map(EntityTypeBuilder<Sys_QuartzOptions>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

