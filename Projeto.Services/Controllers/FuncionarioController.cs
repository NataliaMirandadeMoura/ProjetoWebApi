using Projeto.DAL.Contracts;
using Projeto.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Projeto.Services.Controllers
{
    [RoutePrefix("api/Funcionario")]
    public class FuncionarioController : ApiController
    {
        private readonly IFuncionarioRepository repository;

        public FuncionarioController(IFuncionarioRepository repository)
        {
            this.repository = repository;
        }
        [HttpPost] 
        public HttpResponseMessage Post(FuncionarioCadastroModel model)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [HttpPut]
        public HttpResponseMessage Put(FuncionarioEdicaoModel model)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpDelete]
        public HttpResponseMessage Delete (int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [HttpGet]
        [ResponseType(typeof(List<FuncionarioConsultaModel>))]
        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpGet]
        [ResponseType(typeof(FuncionarioConsultaModel))]
        public HttpResponseMessage GetById()
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
