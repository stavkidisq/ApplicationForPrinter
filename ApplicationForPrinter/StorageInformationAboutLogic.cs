﻿using ApplicationStyles;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationForPrinter
{
    public class StorageInformationAboutLogic // Дописывать сюда всю информацию из бизнесс логики
    {
        public readonly static List<DocumentForPrint> documents = new List<DocumentForPrint>();

        private ComputerPrint _informationAboutComputerPrint = new ComputerPrint();
        public ComputerPrint InformationAboutComputerPrint
        {
            get
            {
                return _informationAboutComputerPrint;
            }
        }
    }
}
