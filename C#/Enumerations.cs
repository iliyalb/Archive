using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Enumeration
{
    public enum EducationalStatuses : byte
    {
        Diploma,
        Bachelor,
        Master,
        PhD
    }

    public enum AboHavas
    {
        Abri = 1,
        Aftabi = 2,
        NimeAbri = 4,
        Tufani = 8,
        Barani = 16,
        Barfi = 32
    }

    public enum MaritalStatuses
    {
        Single = 20,
        Married = 30,
        InRelationShip = 4,
        Divorced = 12
    }
}
