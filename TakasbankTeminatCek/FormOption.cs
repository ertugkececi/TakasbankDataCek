using Business.Concrete;
using DataAccess.Concrete.FileDals;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakasbankTeminatCek
{
    public partial class FormOption : Form
    {
        public FormOption()
        {
            InitializeComponent();
            RefreshOptions();
        }

        private void buttonAddTime_Click(object sender, EventArgs e)
        {
            Option option = new Option();
            option.OptionName = "Time";
            option.OptionContent = $"{dateTimePicker1.Value.Hour}:{dateTimePicker1.Value.Minute}";
            OptionManager optionManager = new OptionManager(new FileOptionDal());
            optionManager.Add(option);

            RefreshOptions();
        }

        private void buttonDeleteTime_Click(object sender, EventArgs e)
        {
            Option option = new Option();
            option.OptionName = "Time";
            option.OptionContent = $"{listBoxTime.SelectedItem}";
            OptionManager optionManager = new OptionManager(new FileOptionDal());
            optionManager.Delete(option);

            RefreshOptions();
        }

        private void buttonAddPath_Click(object sender, EventArgs e)
        {
            Option option = new Option();
            option.OptionName = "Path";
            option.OptionContent = textBox1.Text;
            OptionManager optionManager = new OptionManager(new FileOptionDal());
            optionManager.Add(option);

            RefreshOptions();
        }

        private void buttonDeletePath_Click(object sender, EventArgs e)
        {
            Option option = new Option();
            option.OptionName = "Path";
            option.OptionContent = listBoxPaths.SelectedItem.ToString();
            OptionManager optionManager = new OptionManager(new FileOptionDal());
            optionManager.Delete(option);

            RefreshOptions();
        }


        //Personal methods
        private void RefreshOptions()
        {
            listBoxPaths.Items.Clear();
            listBoxTime.Items.Clear();

            OptionManager optionManager = new OptionManager(new FileOptionDal());
            var optionList = optionManager.GetAll();

            foreach (var option in optionList)
            {
                if (option.OptionName == "Path")
                {
                    listBoxPaths.Items.Add(option.OptionContent);
                }
                if (option.OptionName == "Time")
                {
                    listBoxTime.Items.Add(option.OptionContent);
                }
            }
        }
    }
}
