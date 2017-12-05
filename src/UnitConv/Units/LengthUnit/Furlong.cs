using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnit
{
    public class Furlong : LengthUnit
    {
        private Furlong()
        {

        }

        private static readonly Furlong _instance = new Furlong();

        public static Furlong GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.ChineseSimplify, "弗隆" },
                { Languages.English, "fur" }
            };
        }

        protected override void InitRate()
        {
            _rate = 201.168m;
        }
    }
}
