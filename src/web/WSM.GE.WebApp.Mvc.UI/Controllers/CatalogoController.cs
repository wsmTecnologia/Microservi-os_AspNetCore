﻿using Microsoft.AspNetCore.Mvc;

namespace WSM.GE.WebApp.Mvc.UI.Controllers
{
    public class CatalogoController : MainController
    {
        //private readonly ICatalogoService _catalogoService;

        //public CatalogoController(ICatalogoService catalogoService)
        //{
        //    _catalogoService = catalogoService;
        //}

        [HttpGet]
        [Route("")]
        [Route("vitrine")]
        public async Task<IActionResult> Index()
        {
            //var produtos = await _catalogoService.ObterTodos();

            //return View(produtos);
            return View();
        }

        [HttpGet]
        [Route("produto-detalhe/{id}")]
        public async Task<IActionResult> ProdutoDetalhe(Guid id)
        {
            //var produto = await _catalogoService.ObterPorId(id);

            //return View(produto);
            return View();
        }
    }
}