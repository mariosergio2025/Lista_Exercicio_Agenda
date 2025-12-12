using AgendaTelefonica.DbContext;
using Microsoft.AspNetCore.Mvc;

namespace AgendaTelefonica.Controllers
{
    [Route("/api/agenda")]
    public class MyControllers : ControllerBase
    {
        private MyDbContext myDbContext;
        
        public MyControllers(MyDbContext myDbContext)
        {
            this.myDbContext = myDbContext; 
        }
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
