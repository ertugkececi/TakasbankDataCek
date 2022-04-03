using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OptionManager : IOpitonService
    {
        IOptionDal _optionDal;

        public OptionManager(IOptionDal optionDal)
        {
            _optionDal = optionDal;
            _optionDal.FilePath = Environment.CurrentDirectory + "\\Options.txt";

            if (!File.Exists(_optionDal.FilePath))
            {
                File.Create(_optionDal.FilePath).Close();
            }

            //Default save path
            if (File.ReadAllLines(_optionDal.FilePath).Length<=0)
            {
                Option option = new Option();
                option.OptionName = "Path";
                option.OptionContent = $"{Environment.CurrentDirectory}\\Teminatlar.txt";
                _optionDal.Add(option);
            }
        }

        public void Add(Option option)
        {
            _optionDal.Add(option);
        }

        public void AddAll(List<Option> optionList)
        {
            _optionDal.AddAll(optionList);
        }

        public void Delete(Option option)
        {
            _optionDal.Delete(option);
        }

        public void DeleteAll(List<Option> optionList)
        {
            _optionDal.DeleteAll(optionList);
        }

        public Option Get(string containsString)
        {
            return _optionDal.Get(containsString);
        }

        public List<Option> GetAll()
        {
            return _optionDal.GetAll();
        }

        public void Update(Option oldOption, Option newOption)
        {
            _optionDal.Update(oldOption, newOption);
        }

        public void UpdateAll(List<Option> oldOptionList, List<Option> newOptionList)
        {
            _optionDal.UpdateAll(oldOptionList, newOptionList);
        }
    }
}
