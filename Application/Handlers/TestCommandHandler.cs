using Application.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers
{
    public class TestCommandHandler : IRequestHandler<TestCommand, bool>
    {
        public Task<bool> Handle(TestCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
