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
    [RoutePrefix("api/Dependente")]
    public class DependenteController : ApiController
    {
        private readonly IDependenteRepository repository;

        public DependenteController(IDependenteRepository repository)
        {
            this.repository = repository;
        }
        [HttpPost]
        public HttpResponseMessage Post(DependenteCadastroModel model)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpPut]
        public HttpResponseMessage Put(DependenteEdicaoModel model)
        {
            return Request.CreateResponse(HttpStatusCode.OK);

        }

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpGet]
        [ResponseType(typeof(List<DependenteConsultaModel>))]
        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpGet]
        [ResponseType(typeof(DependenteConsultaModel))]
        public HttpResponseMessage GetById (int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
