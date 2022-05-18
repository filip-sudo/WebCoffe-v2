using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCoffe.Models
{
    public class KavaDB
    {
        private static List<Kava> lista = new List<Kava>();
        private static bool listaInicijalizirana = false;

        public KavaDB()
        {
            if (listaInicijalizirana == false)
            {
                listaInicijalizirana = true;

                lista.Add(new Kava()
                {
                    Id = 1,
                    Naziv = "prvakava",
                    Cijena = 12
                });

                lista.Add(new Kava()
                {
                    Id = 2,
                    Naziv = "drugakava",
                    Cijena = 14
                });
            }
        }
        public List<Kava> VratiListu()
        {
            return lista;
        }
    }
}