using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Option : IEntity
    {
        public string OptionName { get; set; }
        public string OptionContent { get; set; }
        public string StringQuery
        {
            get
            {
                return string.Format("{0};{1}", OptionName, OptionContent);
            }
            set
            {
                var query = value;
                //var stringArray = query.Split(';');
                OptionName = query.Split(';')[0];
                OptionContent = query.Split(';')[1];
            }
        }

    }
}
