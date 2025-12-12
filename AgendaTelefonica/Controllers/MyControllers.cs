using Microsoft.AspNetCore.Mvc;

namespace AgendaTelefonica.Controllers
{
    public class MyControllers : ControllerBase
    {
        [Route("/api/agenda")]
        [HttpGet]
        public ActionResult VerTodos()
        {
            return Ok("Deu Certo");
        }
        [HttpGet("{id}")]
        public ActionResult VerItem(int id)
        {
            return Ok("Deu Certo");
        }



        [HttpDelete("{id}")]
        public ActionResult DeletaItem(int id)
        {
            return Ok("Deu Certo");
        }

        [HttpPut("{id}")]
        public ActionResult AtualizaItem(int id)
        {
            return Ok("Deu Certo");
        }

        [HttpPost]
        public ActionResult CriaItem(int id)
        {

            return Created();
        }

    }
}
