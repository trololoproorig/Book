﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public interface Interface
    {
        Shop[] GetByTitle(string titlePart);

    }
}
