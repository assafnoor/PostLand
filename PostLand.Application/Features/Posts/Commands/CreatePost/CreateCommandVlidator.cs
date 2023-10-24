using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Commands.CreatePost
{
    public class CreateCommandVlidator:AbstractValidator<CreatePostCommand>
    {
        public CreateCommandVlidator() 
        {
            RuleFor(p => p.Titel).NotEmpty().NotNull().MaximumLength(100);
            RuleFor(p => p.Content).NotEmpty().NotNull();
        }
    }
}
