using PostLand.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Queruies.GetPostList
{
    public class GetPostListViewModel
    {
        public Guid Id { get; set; }
        public string Titel { get; set; }
        public string ImageUrl { get; set; }
        public CategoryDto category { get; set; }
    }
}
