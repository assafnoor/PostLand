using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Queruies.GetPostList
{
    public class GetPostListQuery :IRequest<List<GetPostListViewModel>>
    {
    }
}
