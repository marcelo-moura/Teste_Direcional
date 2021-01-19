﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.Direcional.WEB.Models
{
    public class ContatoViewModel
    {
        public int Id { get; set; }        

        public string Nome { get; set; }

        public string CPF { get; set; }
   
        public string Email { get; set; }

        public string Anexo { get; set; }      

    }
}
