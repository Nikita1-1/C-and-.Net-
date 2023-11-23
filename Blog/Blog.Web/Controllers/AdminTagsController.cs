using Microsoft.AspNetCore.Mvc;
using Blog.Web.Models.ViewModels;
using Blog.Web.Data;
using Blog.Web.Models.Domain;
using Microsoft.Identity.Client;
using Microsoft.EntityFrameworkCore;
using Blog.Web.Repositories;

namespace Blog.Web.Controllers
{
    public class AdminTagsController : Controller
    {
        // construction injection to use data from sql
      
        private readonly ITagRepositories tagRepository;
        public AdminTagsController(ITagRepositories tagRepositories)
        {
            this.tagRepository = tagRepositories;
           
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        // for form functionality when submit
        [HttpPost]
        public async Task<IActionResult> Add(AddTagRequest requestData)
        {
            // Mapping AddTagRequest to Tag domain model
            var tag = new Tag
            {
                Name = requestData.Name,
                DisplayName = requestData.DisplayName
            };

            await tagRepository.AddAsync(tag);

            return RedirectToAction("List");
        }

        [HttpGet]
        [ActionName("List")]
        public async Task<IActionResult> List()
        {
            // use DbContext to read the tags
            var tags = await tagRepository.GetAllAsync();

            return View(tags);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            // var tag = blogDbContext.Tags.Find(id);

            // second method
            var tag = await tagRepository.GetAsync(id);
            if (tag != null)
            {
                var editTagRequest = new EditTagRequest
                {
                    Id = tag.Id,
                    Name = tag.Name,
                    DisplayName = tag.DisplayName
                };
                return View(editTagRequest);
            }
            return View(null);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditTagRequest editTagRequest)
        {

            //updating tag from changes.
            var tag = new Tag
            {
                Id = editTagRequest.Id,
                Name = editTagRequest.Name,
                DisplayName = editTagRequest.DisplayName
            };

            var updatedTag = await tagRepository.UpdateAsync(tag);

            if( updatedTag != null)
            {

                // show notification
            }
            else
            {

            }
            return RedirectToAction("Edit", new { id = editTagRequest.Id });
        }
        [HttpPost]
        public async Task<IActionResult> Delete(EditTagRequest editTagRequest) {
            var deletedTag = tagRepository.DeleteAsync(editTagRequest.Id);

            if (deletedTag != null) 
            {
                //show success notif
                return RedirectToAction("List");
            }
            return RedirectToAction("Edit", new {id = editTagRequest.Id});
        }
    }
}
