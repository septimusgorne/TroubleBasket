﻿using Interface_Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example_1
{
    class FileDataProvider : IDataProvider
    {
        string IDataProvider.GetData()
        {
            return "Данные из файла";
        }
    }
}
