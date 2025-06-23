using AdmVeterinaria.Datos.Clases;

namespace AdmVeterinaria.Datos
{
    public static class DbInitializer
    {
        public static void Initialize(TodoContext context)
        {
            // Busca por un TipoDocumento
            if (context.TiposAnimals.Any())
            {
                return; // La tabla TipoDocumento fue inicializada
            }
            // Busca por un TipoDocumento
            if (context.Medicamentos.Any())
            {
                return; // La tabla TipoDocumento fue inicializada
            }

            var Tipoanimal = new TipoAnimal[]
            {
                new TipoAnimal { Tipoanimal = "Canino" },
                new TipoAnimal { Tipoanimal = "Felino" },
                new TipoAnimal { Tipoanimal = "Roedor" },
                new TipoAnimal { Tipoanimal = "etc" },
            };

            context.TiposAnimals.AddRangeAsync(Tipoanimal).Wait();

            var medicamentos = new Medicamento[]
            {
                new Medicamento { Nombre = "Antibiotico" },
                new Medicamento { Nombre = "Antiparasitarios Ext" },
                new Medicamento { Nombre = "Antiparasitarios Int" },
                new Medicamento { Nombre = "Vacunas" },
                new Medicamento { Nombre = "Sedantes" },

            };

            context.Medicamentos.AddRangeAsync(medicamentos).Wait();


            context.SaveChangesAsync();
        }
    }
}
