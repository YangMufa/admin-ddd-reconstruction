using Mint.Entity.MappingConfiguration;
using Mint.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mint.Entity.MappingConfiguration
{
    public class Sys_WorkFlowStepMapConfig : EntityMappingConfiguration<Sys_WorkFlowStep>
    {
        public override void Map(EntityTypeBuilder<Sys_WorkFlowStep>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

