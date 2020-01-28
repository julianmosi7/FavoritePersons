using MVVM.Tools;
using NorthwindDbLib;
using PersonalDbLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelLib
{
    public class ViewModel : ObservableObject
    {
        public ViewModel(PersonalContext personalDb, NorthwindContext northwindDb)
        {

        }


    }
}
