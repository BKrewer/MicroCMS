using MicroCMS.Domain.Entities;
using MicroCMS.Domain.Interfaces.Repository;
using MicroCMS.Infra.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroCMS.Infra.Repository
{
    public class PostCategoryRepository : APIRepository<PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(APIContext context) : base(context)
        {

        }
    }
}
