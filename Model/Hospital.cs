using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("hospitais")]
    public class Hospital : Base
    {
        [Column("razao_social")]
        public string RazaoSocial { get; set; }

        [Column("cnpj")]
        public string Cnpj { get; set; }

        [Column("faturamento")]
        public decimal Faturamento { get; set; }

        [Column("particular")]
        public bool Particular { get; set; }
    }
}
