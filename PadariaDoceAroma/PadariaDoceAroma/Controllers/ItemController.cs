using Microsoft.AspNetCore.Mvc;
using PadariaDoceAroma.Models;

namespace PadariaDoceAroma.Controllers
{
    public class ItemController : Controller
    {

        private static IList<Item> _listaItens = new List<Item>();
        private static int _idItem = 0;

        /*Lista Reserva para adicionar os produtos que contêm
            o nome pesquisado pelo usuario*/
        private static IList<Item> _listaItensReserva = new List<Item>();


        public IActionResult Index()
        {
            return View(_listaItens);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Item item)
        {
            
            item.Id = ++_idItem;
            _listaItens.Add(item);
            Console.WriteLine(item.Nome);
            TempData["mensagem"] = "Item cadastrado com sucesso!";
            return RedirectToAction("Cadastrar"); 
        }


        [HttpGet]
        public IActionResult Editar(int id)
        {
            var item = _listaItens.First(i => i.Id == id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Editar(Item item)
        {
            var index = _listaItens.ToList().FindIndex(i => i.Id == item.Id);
            _listaItens[index] = item;

            TempData["mensagem"] = " Item atualizado com sucesso!!";
            return RedirectToAction("Editar");
        }


        [HttpPost]
        public IActionResult Apagar(int id)

        {
            _listaItens.Remove(_listaItens.First(i => i.Id == id));
            TempData["mensagem"] = "O item selecionado foi removido com sucesso!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Pesquisar(string nomePesquisa)
        {

            _listaItensReserva = _listaItens.Where(
                      i => i.Nome.ToLower().Contains(nomePesquisa.ToLower())).ToList();


            return View(_listaItensReserva);
        }

        public IActionResult Resetar()
        {

            return RedirectToAction("Index");

        }

    }
}
