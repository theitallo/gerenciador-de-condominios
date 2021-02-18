﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCondominios.BLL.Models
{
    public class ServicoPredio
    {
        public int ServicoPredioId { get; set; }

        public int ServicoId { get; set; }
        public virtual Servico Servico { get; set; }

        public DateTime DataExecucao { get; set; }
    }
}
