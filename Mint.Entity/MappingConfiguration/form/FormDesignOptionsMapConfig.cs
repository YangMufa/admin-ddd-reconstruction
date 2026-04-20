using Mint.Entity.MappingConfiguration;
using Mint.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mint.Entity.MappingConfiguration
{
    public class FormDesignOptionsMapConfig : EntityMappingConfiguration<FormDesignOptions>
    {
        public override void Map(EntityTypeBuilder<FormDesignOptions>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

