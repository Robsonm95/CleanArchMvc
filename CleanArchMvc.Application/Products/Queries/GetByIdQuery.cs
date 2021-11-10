using CleanArchMvc.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Products.Queries
{
    public class GetByIdQuery : IRequest<Product>
    {
        public int Id{ get; set; }
        public GetByIdQuery(int id)
        {
            Id = id;
        }

    }
}
