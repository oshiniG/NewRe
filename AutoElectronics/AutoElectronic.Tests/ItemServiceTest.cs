using AutoElectronic.Application.Mappings;
using AutoElectronic.Application.Services;
using AutoElectronic.Domain.Models;
using AutoElectronic.Infrastructure.Data;
using AutoElectronic.Infrastructure.Data.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AutoElectronic.Tests
{
    public class ItemServiceTest
    {
        [Fact]
        public async Task Get_Item_ShouldNotBeNull()
        {
            var dbOptionsBuilder = new DbContextOptionsBuilder().UseInMemoryDatabase("AutoElectronics");

            // arrange
            using (var db = new AutoElectronicDbContext(dbOptionsBuilder.Options))
            {
                // fix up some data
                db.Set<Item>().Add(new Item()
                {
                    Id = 5,
                    AssetNumber = "123123",
                    Name = "LG",
                    AvailableUnits = 16,
                    ReOrderLevel = 2,
                    UnitPrice = 4500
                });
                await db.SaveChangesAsync();
            }

            using (var db = new AutoElectronicDbContext(dbOptionsBuilder.Options))
            {
                // create the service
                ILoggerFactory loggerFactory = new LoggerFactory();
                ILogger logger = loggerFactory.CreateLogger<ItemRepository>();
                var itemRepository = new ItemRepository(new AutoElectronicDbContext(dbOptionsBuilder.Options),logger);
                var myprofile = new MappingProfile();
                //configure mapping
                var config = new MapperConfiguration(opts =>
                {
                    opts.AddProfile(myprofile);
                });
                
                var mapper = config.CreateMapper();
                var service = new ItemService(itemRepository, mapper);

                // act
                var result = service.GetItem(1);

                // assert
                Assert.NotNull(result);
            }
        }
    }
}
