using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Application.Contratos
{
    public interface IEventoSevece
    {
        Task<Evento> AddEventos(Evento model);
        Task<Evento> UpdateEventos(int eventoId, Evento model);
        Task<bool> DeleteEventos(int eventoId);
        Task<Evento[]>GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);
        Task<Evento[]>GetAllEventosAsync(bool includePalestrantes = false);
        Task<Evento>GetAllEventoByIdAsync(int EventoId, bool includePalestrantes = false);
    }
}