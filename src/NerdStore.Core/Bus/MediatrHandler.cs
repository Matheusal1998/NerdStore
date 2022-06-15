using System.Threading.Tasks;
using MediatR;
using NerdStore.Core.Message;

namespace NerdStore.Core.Bus
{
    public class MediatrHandler : IMediatrHandler
    {
        private readonly IMediator _midiator;

        public MediatrHandler(IMediator midiator)
        {
            _midiator = midiator;
        }

        public async Task PublicarEvento<T>(T evento) where T : Event
        {
            await _midiator.Publish(evento);
        }
    }

   
}