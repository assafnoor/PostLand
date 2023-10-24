using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Queruies.GetPostDetailes
{
    public class GetPostDetaileQuery :IRequest<GetPostDetaileViewModel>
    {
        public Guid Id { get; set; }
    }
}
