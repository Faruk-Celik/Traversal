using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Abstract;

namespace Traversal.WebUI.ViewComponents.Comment
{
    public class CommentListComponentPartial: ViewComponent
    {
        private readonly   ICommentService _commentService;
        

        public CommentListComponentPartial ( ICommentService commentService )
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var value = _commentService.TGetDestinationById(id);
           
            return View(value);
        }
    }
}
