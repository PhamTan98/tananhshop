using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TanShop.Model.Models;
using TanShop.Web.Models;

namespace TanShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
        }
    }
}