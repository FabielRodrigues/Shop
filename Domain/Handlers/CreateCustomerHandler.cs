using MediatR;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Shop.Domain.Commands.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            var result =  new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Fabiel Rodrigues",
                Email = "fabiel.rodrigues@gmail.com",
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}