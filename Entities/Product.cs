using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    //IEntity: IEntity implement eden class veri tabani tablosudur.IEntity Core/Entities altinda olusturulan ve sadece isaretleme gorevi olan bir interface yapisidir.
    public class Product:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

    }
}
