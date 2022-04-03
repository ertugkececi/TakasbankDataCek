using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOpitonService
    {
        void Add(Option option);
        void AddAll(List<Option> optionList);
        void Delete(Option path);
        void DeleteAll(List<Option> optionList);
        void Update(Option oldOption, Option newOption);
        void UpdateAll(List<Option> oldOptionList, List<Option> newOptionList);
        Option Get(string containsString);
        List<Option> GetAll();
    }
}
