using Clase4.POO.Entidades;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.POO.Logica
{
    public class AnimalFactory
    {
        private readonly Dictionary<string, IAnimalCreator> _creators;

        public AnimalFactory(IEnumerable<IAnimalCreator> creators)
        {
            _creators = creators.ToDictionary(c => c.Tipo.ToLower());
        }

        public Animal CrearAnimal(string tipo, string nombre, int edad)
        {
            if (_creators.TryGetValue(tipo.ToLower(), out var creator))
                return creator.Crear(nombre, edad);

            throw new ArgumentException("Tipo de animal no reconocido");
        }

        public List<SelectListItem> ObtenerTiposAnimales()
        {
            return _creators.Select(c => new SelectListItem
            {
                Text = Capitalize(c.Key),
                Value = c.Key
            }).ToList();
        }

        private string Capitalize(string input) =>
            char.ToUpper(input[0]) + input.Substring(1).ToLower();
    }
}
