﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.EntityLayer.Concrete;

namespace Traversal.BusinessLayer.Abstract
{
    public interface ICommentService :IGenericService<Comment>
    {
        List<Comment> TGetDestinationById(int id);
    }
}
