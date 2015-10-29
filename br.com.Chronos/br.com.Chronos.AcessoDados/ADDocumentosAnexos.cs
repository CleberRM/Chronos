using br.com.Chronos.Entidade;
using br.com.Chronos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Chronos.AcessoDados
{
    public class ADDocumentosAnexos : IAcoesBanco<DocumentosAnexos>
    {
        private OSContext _contexto;
        public ADDocumentosAnexos(OSContext contexto)
        {
            _contexto = contexto;
        }

        public bool ExcluirEntidadePor(int id)
        {
            var result = RetornarEntidadePor(id);
            if (result != null)
            {
                _contexto.DocumentosAnexosDaOS.Remove(result);
                _contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public DocumentosAnexos RetornarEntidadePor(int id)
        {
            return (from c in _contexto.DocumentosAnexosDaOS
                    where c.IdDocAnexos == id
                    select c).FirstOrDefault();
        }

        public IList<DocumentosAnexos> RetornarLista(DocumentosAnexos entidade)
        {
            return _contexto.DocumentosAnexosDaOS.Where(x => x.NomeDocumento.Contains(entidade.NomeDocumento)).ToList();
        }

        public int Salvar(DocumentosAnexos entidade)
        {
            var result = RetornarEntidadePor(entidade.IdDocAnexos);
            if (result != null)
            {
                _contexto.Entry(entidade).CurrentValues.SetValues(entidade);
            }
            else
            {
                _contexto.DocumentosAnexosDaOS.Add(entidade);
            }
            _contexto.SaveChanges();
            return entidade.IdDocAnexos;
        }
    }
}