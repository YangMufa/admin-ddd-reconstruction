using Mint.Entity.MappingConfiguration;
using Mint.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mint.Entity.MappingConfiguration
{
    public class TestServiceMapConfig : EntityMappingConfiguration<TestService>
    {
        public override void Map(EntityTypeBuilder<TestService>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

