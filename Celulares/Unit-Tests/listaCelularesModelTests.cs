using Xunit;
using WebApplication1.Pages.ViewCel;
using System.Collections.Generic;

namespace Unit_Tests
{
    public class listaCelularesModelTests
    {
        [Fact]
        public void OnGet_CargaListaCelulares()
        {
            // Arrange
            var model = new listaCelularesModel();

            // Act
            model.OnGet();

            // Assert
            Assert.NotNull(model.Celulares);
            Assert.True(model.Celulares.Count >= 0);
        }

        [Fact]
        public void AgregarCelular_AgregaCorrectamente()
        {
            // Arrange
            var model = new listaCelularesModel();
            var celular = new Celular { Id = 1, Marca = "Samsung", Modelo = "A10", Precio = 100 };

            // Act
            model.AgregarCelular(celular);

            // Assert
            Assert.Contains(model.Celulares, c => c.Id == 1);
        }

        [Fact]
        public void ModificarCelular_ModificaCorrectamente()
        {
            // Arrange
            var model = new listaCelularesModel();
            model.Celulares = new List<Celular>
            {
                new Celular { Id = 1, Marca = "Samsung", Modelo = "A10", Precio = 100 }
            };
            var celularModificado = new Celular { Id = 1, Marca = "Samsung", Modelo = "A20", Precio = 150 };

            // Act
            model.ModificarCelular(celularModificado);

            // Assert
            var celular = model.Celulares.Find(c => c.Id == 1);
            Assert.Equal("A20", celular.Modelo);
            Assert.Equal(150, celular.Precio);
        }

        [Fact]
        public void EliminarCelular_EliminaCorrectamente()
        {
            // Arrange
            var model = new listaCelularesModel();
            model.Celulares = new List<Celular>
            {
                new Celular { Id = 1, Marca = "Samsung", Modelo = "A10", Precio = 100 }
            };

            // Act
            model.EliminarCelular(1);

            // Assert
            Assert.DoesNotContain(model.Celulares, c => c.Id == 1);
        }
    }
}