﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;

namespace scoala.Models
{
    public class Nota
    {
        private decimal _valoare;
        public decimal Valoare { get { return _valoare; } }

        public Nota(decimal valoare)
        {
            Contract.Requires<ArgumentException>(valoare > 0, "valoare");
            Contract.Requires<ArgumentException>(valoare <= 10, "valoare");

            _valoare = valoare;
        }

        internal void AdaugaNota(Nota nota)
        {
            Contract.Requires(nota != null, "nota");
           
        }

        #region override object
        public override bool Equals(object obj)
        {
            var nota = (Nota)obj;
            return Valoare == nota.Valoare;
        }

        public override int GetHashCode()
        {
            return Valoare.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}", Valoare);
        }
        #endregion
    }
}