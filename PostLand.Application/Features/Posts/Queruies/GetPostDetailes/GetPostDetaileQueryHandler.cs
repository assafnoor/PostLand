using AutoMapper;
using MediatR;
using PostLand.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Queruies.GetPostDetailes
{
    public class GetPostDetaileQueryHandler:IRequestHandler<GetPostDetaileQuery,GetPostDetaileViewModel>
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public GetPostDetaileQueryHandler(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public async Task<GetPostDetaileViewModel> Handle(GetPostDetaileQuery request, CancellationToken cancellationToken)
        {
           var post = await _postRepository.GetPostByIdAsync(request.Id,true);
            return _mapper.Map<GetPostDetaileViewModel>(post);
        }
    }
}
