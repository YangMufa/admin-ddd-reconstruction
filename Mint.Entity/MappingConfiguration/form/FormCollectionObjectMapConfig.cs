using Mint.Entity.MappingConfiguration;
using Mint.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mint.Entity.MappingConfiguration
{
    public class FormCollectionObjectMapConfig : EntityMappingConfiguration<FormCollectionObject>
    {
        public override void Map(EntityTypeBuilder<FormCollectionObject>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

