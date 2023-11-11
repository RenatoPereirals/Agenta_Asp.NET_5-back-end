
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contratos
{
    public interface ILotePersist
    {
        /// <summary>
        /// Método get que retornará uma losta de lotes por eventoId
        /// </summary>
        /// <param name="eventoId">Código chave da tabela Evento</param>
        /// <returns>Array de lotes</returns>
        Task<Lote[]> GetLotesByEventoIdAsync(int eventoId);
        /// <summary>
        /// Método get qu retornará apenas um lote
        /// </summary>
        /// <param name="eventoId">Código chave da tabela Evento</param>
        /// <param name="id"> Código chave da tabela Lote</param>
        /// <returns>Apenas um lote</returns>
        Task<Lote> GetLoteByIdsAsync(int eventoId, int id);
    }
}