﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException:Exception
    {
        public NacionalidadInvalidaException() : this("La Nacionalidad no coincide con el numero dni")
        {

        }
        public NacionalidadInvalidaException(string message) : base(message)
        {

        }
    }
}
