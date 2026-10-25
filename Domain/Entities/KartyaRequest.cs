using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class KartyaRequest
    {
        private int ar;
        private int kilometeroraAllas;

        public required string Marka { get; set; }
        public required string Tipus { get; set; }
        public required int Ar
        {
            get { return ar; }
            set
            {
                if (value < 0) { ar = 0; }
                else { ar = value; }
            }
        }
        public required int KilometeroraAllas
        {
            get { return kilometeroraAllas; }
            set
            {
                if (value < 0) { kilometeroraAllas = 0; }
                else { kilometeroraAllas = value; }
            }
        }
        public required string Evjarat { get; set; }
    }
}
