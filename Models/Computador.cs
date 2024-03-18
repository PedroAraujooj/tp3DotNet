using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestaoDeLaboratorios.Models
{
    public class Computador
    {
        [Key]
        public string Id { get; set; }
        public string Marca { get; set;}
        public string Processador { get; set;}
        [DisplayName("Placa Mãe")]
        public string PlacaMae { get; set;}
        public string Memoria { get; set; }
        public string HD { get; set; }
        [DisplayName("Número do Patrimonio")]
        public string NumeroPratrimonio { get; set; }
        [DisplayName("Data de compra")]
        public DateOnly DataCompra { get; set; }
}
}
