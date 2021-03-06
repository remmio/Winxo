﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Winxo.Model.Enums;

namespace Winxo.Model.Entity
{
    internal class Citerne
    {
        [Key]
        public Guid CiterneGuid { get; set; }


        public string Numero { get; set; }


        public Carburants TypeCarburant { get; set; }

        /// <summary>
        /// la capaciter en litre
        /// </summary>
        public int Capaciter { get; set; }


        /// <summary>
        /// la Quantiter en litre
        /// </summary>
        public int Quantiter { get; set; }



        public List<Pompe> Pompes { get; set; }
    }
}
