using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace C18_Ex02
{
    interface IFinder
    {
        ArrayList findByCategory(ArrayList i_genders, string i_city, int i_fromAge, int i_toAge);
        ArrayList findByGender(ArrayList i_genders);
        ArrayList findByCity(string i_city);
        ArrayList findByAge(int i_from, int i_to);
    }
}
