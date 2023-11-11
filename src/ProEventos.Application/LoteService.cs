using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProEventos.Application.Contratos;
using ProEventos.Application.Dtos;
using ProEventos.Domain;
using ProEventos.Persistence;
using ProEventos.Persistence.Contratos;

namespace ProEventos.Application
{
    public class LoteService : ILoteService
    {
        private readonly IMapper _mapper;
        private readonly IGeralPersist _geralPersist;
        private readonly ILotePersist _lotePersist;

        public LoteService(IGeralPersist geralPersist,
                           ILotePersist lotePersist,
                           IMapper mapper)
        {
            _mapper = mapper;
            _lotePersist = lotePersist;
            _geralPersist = geralPersist;
        }

        // Adiciona um lote a um evento
        public async Task AddLote(int eventoId, LoteDto model)
        {
            try
            {
                // Mapeia o objeto DTO para a entidade Lote
                var lote = _mapper.Map<Lote>(model);
                lote.EventoId = eventoId;

                // Adiciona o lote no contexto
                _geralPersist.Add<Lote>(lote);

                // Salva as alterações no banco de dados
                await _geralPersist.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Lança uma exceção caso ocorra algum erro
                throw new Exception(ex.Message);
            }
        }

        // Salva os lotes de um evento
        public async Task<LoteDto[]> SaveLotes(int eventoId, LoteDto[] models)
        {
            try
            {
                // Obtém todos os lotes do evento pelo seu ID
                var lotes = await _lotePersist.GetLotesByEventoIdAsync(eventoId);
                if (lotes == null) return null;

                foreach (var model in models)
                {
                    if (model.Id == 0)
                    {
                        // Se o ID do modelo for 0, significa que é um novo lote a ser adicionado
                        await AddLote(eventoId, model);
                    }
                    else
                    {
                        // Se o ID do modelo for diferente de 0, significa que é um lote existente a ser atualizado
                        var lote = lotes.FirstOrDefault(lote => lote.Id == model.Id);
                        model.EventoId = eventoId;

                        // Mapeia as propriedades do DTO para o lote encontrado
                        _mapper.Map(model, lote);

                        // Atualiza o lote no contexto
                        _geralPersist.Update<Lote>(lote);

                        // Salva as alterações no banco de dados
                        await _geralPersist.SaveChangesAsync();
                    }
                }

                // Obtém os lotes atualizados do evento pelo seu ID
                var loteRetorno = await _lotePersist.GetLotesByEventoIdAsync(eventoId);

                // Mapeia os lotes para um array de DTOs
                return _mapper.Map<LoteDto[]>(loteRetorno);
            }
            catch (Exception ex)
            {
                // Lança uma exceção caso ocorra algum erro
                throw new Exception(ex.Message);
            }
        }

        // Deleta um lote pelo seu ID
        public async Task<bool> DeleteLote(int eventoId, int loteId)
        {
            try
            {
                // Obtém o lote pelo ID do evento e ID do lote
                var lote = await _lotePersist.GetLoteByIdsAsync(eventoId, loteId);
                if (lote == null) throw new Exception("Lote para delete não encontrado.");

                // Deleta o lote do contexto
                _geralPersist.Delete<Lote>(lote);

                // Salva as alterações no banco de dados
                return await _geralPersist.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Lança uma exceção caso ocorra algum erro
                throw new Exception(ex.Message);
            }
        }

        // Obtém todos os lotes de um evento pelo seu ID
        public async Task<LoteDto[]> GetLotesByEventoIdAsync(int eventoId)
        {
            try
            {
                // Obtém todos os lotes do evento pelo seu ID
                var lotes = await _lotePersist.GetLotesByEventoIdAsync(eventoId);
                if (lotes == null) return null;

                // Mapeia os lotes para um array de DTOs
                var resultado = _mapper.Map<LoteDto[]>(lotes);

                return resultado;
            }
            catch (Exception ex)
            {
                // Lança uma exceção caso ocorra algum erro
                throw new Exception(ex.Message);
            }
        }

        // Obtém um lote pelo ID do evento e ID do lote
        public async Task<LoteDto> GetLoteByIdsAsync(int eventoId, int loteId)
        {
            try
            {
                // Obtém o lote pelo ID do evento e ID do lote
                var lote = await _lotePersist.GetLoteByIdsAsync(eventoId, loteId);
                if (lote == null) return null;

                // Mapeia o lote para um DTO
                var resultado = _mapper.Map<LoteDto>(lote);

                return resultado;
            }
            catch (Exception ex)
            {
                // Lança uma exceção caso ocorra algum erro
                throw new Exception(ex.Message);
            }
        }
    }
}
