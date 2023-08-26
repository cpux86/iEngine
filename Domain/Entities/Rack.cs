using Domain.Entities.ProductAggregate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = Domain.Entities.ProductAggregate.Type;

namespace Domain.Entities
{
    /* Стеллаж
     * может быть шкаф, стеллаж, сейф.
     * не содержит штрихкод, для идентификации в рамках одного помещения используется уникальное имя
     *
     */
    public class Rack
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Cell> Cells { get; set; } = new();
        public Type Type { get; set; } = new();
    }
}
