using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using br.com.Chronos.Entidade;

namespace br.com.Chronos.Negocio
{
    public interface IAcoesBanco<T> where T : AEntidade
    {
        /// <summary>
        /// Retorna a entidade correspondente ao id passado
        /// </summary>
        /// <param name="id">Id da entidade</param>
        /// <returns>Entidade que atenda ao parametro.</returns>
        T RetornarEntidadePor(int id);

        /// <summary>
        /// Salva a entidade passada
        /// </summary>
        /// <param name="entidade">Entidade a ser salva</param>
        /// <returns>Código da entidade salva no banco de dados.</returns>
        int Salvar(T entidade);

        /// <summary>
        /// Retorna lista das entidades que atendam ao filtro passado
        /// </summary>
        /// <param name="entidade">Entidade que deve ser preenchida com os dados utilizados para filtrar a consulta. Passar parametro nulo para pesquisa sem filtro.</param>
        /// <returns>Lista contendo todas as entidades que atendam ao filtro passado. No caso de parametro nulo, retorna todas as entidades da tabela.</returns>
        IList<T> RetornarLista(T entidade);

        /// <summary>
        /// Excluir entidade correspondente ao id passado
        /// </summary>
        /// <param name="id">Id da entidade</param>
        /// <returns>Booleano indicando se a exclusão foi executada com sucesso.</returns>
        bool ExcluirEntidadePor(int id);
    }
}
