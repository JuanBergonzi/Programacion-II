using CDatos.Context;
using Celulares.Celulares;
using CLogica.Implementation;
using Microsoft.EntityFrameworkCore;

namespace Unit_Tests
{
    public class CelularesTests
    {
        private DataContext GetInMemoryContext()
        {
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            return new DataContext(options);
        }

        [Fact]
        public void Add_Celular_Should_Add_To_Context()
        {
            var context = GetInMemoryContext();
            var service = new CelularService(context);

            var celular = new Celular { Id = 1, Marca = "Samsung", Modelo = "S23", Precio = 1000m };
            service.AgregarCelulares(celular);

            var result = context.Celulares.Find(1);
            Assert.NotNull(result);
            Assert.Equal("Samsung", result.Marca);
        }

        [Fact]
        public void GetAll_Should_Return_All_Celulares()
        {
            var context = GetInMemoryContext();
            context.Celulares.AddRange(new List<Celular>
            {
                new Celular { Id = 1, Marca = "Samsung", Modelo = "S23", Precio = 1000m },
                new Celular { Id = 2, Marca = "Apple", Modelo = "iPhone 15", Precio = 1200m }
            });
            context.SaveChanges();

            var service = new CelularService(context);
            var result = service.GetCelulares();

            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void GetById_Should_Return_Correct_Celular()
        {
            var context = GetInMemoryContext();
            context.Celulares.Add(new Celular { Id = 1, Marca = "Samsung", Modelo = "S23", Precio = 1000m });
            context.SaveChanges();

            var service = new CelularService(context);
            var result = service.GetCelularesId(1);

            Assert.NotNull(result);
            Assert.Equal("Samsung", result.Marca);
        }

        [Fact]
        public void Update_Should_Modify_Celular()
        {
            var context = GetInMemoryContext();
            context.Celulares.Add(new Celular { Id = 1, Marca = "Samsung", Modelo = "S23", Precio = 1000m });
            context.SaveChanges();

            var service = new CelularService(context);
            var updated = new Celular { Id = 1, Marca = "Samsung", Modelo = "S23 Ultra", Precio = 1100m };
            service.ActualizarCelulares(updated);

            var result = context.Celulares.Find(1);
            Assert.Equal("S23 Ultra", result.Modelo);
            Assert.Equal(1100m, result.Precio);
        }

        [Fact]
        public void Delete_Should_Remove_Celular()
        {
            var context = GetInMemoryContext();
            context.Celulares.Add(new Celular { Id = 1, Marca = "Samsung", Modelo = "S23", Precio = 1000m });
            context.SaveChanges();

            var service = new CelularService(context);
            service.DeleteCelulares(1);

            var result = context.Celulares.Find(1);
            Assert.Null(result);
        }
    }
}