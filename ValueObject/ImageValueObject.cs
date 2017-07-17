using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_ShopGao
{
    public class ImageValueObject
    {
        public int? id { get; set; }
        public string link { get; set; }
        public int? idSp { get; set; }

        public ImageValueObject(int? id, string link, int? sp)
        {
            this.id = id;
            this.link = link;
            this.idSp = sp;
        }
    }
}
