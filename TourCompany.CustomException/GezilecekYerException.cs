﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourCompany.CustomException
{
    public class GezilecekYerException : Exception
    {
        public override string Message
        {
            get
            {
                return "Bu güzergah sistemde zaten mevcut.";
            }
        }

    }
}
