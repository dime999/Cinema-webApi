﻿using KinoAPI.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KinoAPI.CreateModels
{
    public class ArtikalCreateModel
    {
        public int  id { get; set; }
        public string Naziv { get; set; }

        public string Opis { get; set; }

        public string Cijena { get; set; }

    }
}
