using Api.Helper;
using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Api.Controllers
{
    public class EdenrecoController : ApiController
    {

        [Route("api/ListarEstados"),HttpGet]
        public async Task<HttpResponseMessage> ListarEstados()
        {
            HttpResponseMessage response = new HttpResponseMessage();

            var estados = EnderecoHelper.CarregarEstado();
            response = Request.CreateResponse(HttpStatusCode.OK, estados);

            return await TaskHelper<HttpResponseMessage>.CreateTask(response);

        }

        [Route("api/ListarCidadePorUF"), HttpGet]
        public async Task<HttpResponseMessage> ListarCidades(int idEstado)
        {
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                if (idEstado == 0)
                    throw new InvalidOperationException("Id do Estado inválido");

                var cidades =  EnderecoHelper.CarregaCidades().Where(x => x.IdEstado == idEstado).ToList();

                response =  Request.CreateResponse(HttpStatusCode.OK, cidades);
            }
            catch (Exception e)
            {
                response = Request.CreateErrorResponse(HttpStatusCode.NotAcceptable, e);
            }

            return await TaskHelper<HttpResponseMessage>.CreateTask(response);
        }

    }
}
