using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeduShop.Model.Models;
using TeduShop.Service;
using TeduShop.Web.Infrastructure.Core;
using TeduShop.Web.Models;
using TeduShop.Web.Infrastructure.Extensions;

namespace TeduShop.Web.Api
{
    [RoutePrefix("api/postcategory")]
    public class PostCategoryController : ApiControllerBase
    {
        IPostCategoryService _postCategoryService;
        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategoryService) : base(errorService)
        {
            this._postCategoryService = postCategoryService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage requestMessage)
        {
            return CreateHttpResponse(requestMessage, () =>
            {
                var listPostCategory = _postCategoryService.GetAll();

                var listPostCategoryVm = Mapper.Map<List<PostCategoryViewModel>>(listPostCategory);

                //HttpResponseMessage response = requestMessage.CreateResponse(HttpStatusCode.OK, listPostCategory);
                HttpResponseMessage response = requestMessage.CreateResponse(HttpStatusCode.OK, listPostCategoryVm);

                return response;
            });
        }

        //public HttpResponseMessage Post(HttpRequestMessage requestMessage, PostCategory postCategory)
        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage requestMessage, PostCategoryViewModel postCategoryVm)
        {
            return CreateHttpResponse(requestMessage, () =>
            {
                HttpResponseMessage response = null;
                 if (ModelState.IsValid)
                 {
                     requestMessage.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                 }
                 else {

                    //var postCategoryNew = _postCategoryService.Add(postCategory);
                    PostCategory postCategoryDb = new PostCategory();
                    postCategoryDb.UpdatePostCategory(postCategoryVm);

                    var postCategoryNew = _postCategoryService.Add(postCategoryDb);
                    _postCategoryService.Save();

                     response = requestMessage.CreateResponse(HttpStatusCode.Created, postCategoryNew);
                 }
                 return response;
             });
        }

        [Route("update")]
        //public HttpResponseMessage Put(HttpRequestMessage requestMessage, PostCategory postCategory)
        public HttpResponseMessage Put(HttpRequestMessage requestMessage, PostCategoryViewModel postCategoryVm)
        {
            return CreateHttpResponse(requestMessage, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    requestMessage.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    //_postCategoryService.Update(postCategory);
                    var postCategoryDb = _postCategoryService.GetById(postCategoryVm.Id);
                    postCategoryDb.UpdatePostCategory(postCategoryVm);

                    _postCategoryService.Update(postCategoryDb);
                    _postCategoryService.Save();

                    response = requestMessage.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }

        public HttpResponseMessage Delete(HttpRequestMessage requestMessage, int id)
        {
            return CreateHttpResponse(requestMessage, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    requestMessage.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var category = _postCategoryService.Delete(id);
                    _postCategoryService.Save();

                    response = requestMessage.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }
        
    }
}