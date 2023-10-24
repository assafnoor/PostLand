using AutoMapper;
using MediatR;
using PostLand.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Queruies.GetPostList
{
    public class GetPostListQueryHandler : IRequestHandler<GetPostListQuery, List<GetPostListViewModel>>
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public GetPostListQueryHandler(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public IMapper Get_mapper()
        {
            return _mapper;
        }

        public async Task<List<GetPostListViewModel>> Handle(GetPostListQuery request, CancellationToken cancellationToken)
        {
            var posts = await _postRepository.GetAllPostAsync(true);
            return _mapper.Map<List<GetPostListViewModel>>(posts);
        }
    }
}
