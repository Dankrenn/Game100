using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game100Classes
{
    internal interface IPlayer
    {
        void AdvancedValue(int _advanced_value_playergame); // Метод позволяет получить значение от соперника и записать его 
        int ResultingValueReturn(); //Метод передающий твое значение
    }
}
