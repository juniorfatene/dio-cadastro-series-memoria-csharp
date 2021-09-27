using System;
using System.Collections.Generic;
using DIOJR.Series.Interfaces;
using System.Linq;

namespace DIOJR.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
                var verificaID = listaSerie.FirstOrDefault(x=>x.Id == id);

                if(verificaID != null)
                {
                    return listaSerie[id];
                }
                else
                {
                    return null;
                }
                    
               
            
        }
    }
}