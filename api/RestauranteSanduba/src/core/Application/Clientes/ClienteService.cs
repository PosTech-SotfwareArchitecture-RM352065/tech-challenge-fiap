﻿using RestauranteSanduba.Core.Application.Abstraction.Clientes;
using RestauranteSanduba.Core.Application.Abstraction.Clientes.Request;
using RestauranteSanduba.Core.Application.Abstraction.Clientes.Response;
using RestauranteSanduba.Core.Application.Abstraction.Pedidos;
using RestauranteSanduba.Core.Domain.Clientes;
using System;
using System.Linq;


namespace RestauranteSanduba.Core.Application.Clientes
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IPedidoRepository _pedidoRepository;

        public ClienteService(IClienteRepository clienteRepository, IPedidoRepository pedidoRepository)
        {
            _clienteRepository = clienteRepository;
            _pedidoRepository = pedidoRepository;
        }

        public CadastroClienteResponse CadastrarCliente(CadastroClienteRequest request)
        {
            var cliente = ClienteIdentificado.CriarCliente(Guid.NewGuid(), request.CPF, request.Nome, request.Email);
            _clienteRepository.CadastrarCliente(cliente);

            return new CadastroClienteResponse() { Id = cliente.Id };
        }

        public ConsultaPedidosClienteResponse ConsultaPedidosCliente(ConsultaClienteRequest request)
        {
            var cliente = _clienteRepository.ConsultarCliente(new CPF(request.CPF));
            var pedidos = _pedidoRepository.ConsultaPedidosPorCliente(cliente.Id);

            return new ConsultaPedidosClienteResponse() { Pedidos = pedidos.Select(p => p.Id).ToList() };
        }

        public ConsultaClienteResponse ConsultarCliente(ConsultaClienteRequest request)
        {
            var cliente = _clienteRepository.ConsultarCliente(new CPF(request.CPF));

            return new ConsultaClienteResponse()
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Email = cliente.Email
            };
        }
    }
}
