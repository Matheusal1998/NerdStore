﻿using System.Threading;
using System.Threading.Tasks;
using MediatR;
using NerdStore.Core.Message;

namespace NerdStore.Vendas.Application.Commands
{
    public class PedidoCommandHandler : IRequestHandler<AdicionarItemPedidoCommand, bool>
    {
        public async Task<bool> Handle(AdicionarItemPedidoCommand message, CancellationToken cancellationToken)
        {
            if (!ValidarComando(message)) return false;

            return true; 
        }


        private bool ValidarComando(Command message)
        {
            if(message.EhValido()) return true;

            foreach (var error in message.ValidationResult.Errors)
            {
                // lançar evendo de erro
            }

            return false;
        }
    }
}