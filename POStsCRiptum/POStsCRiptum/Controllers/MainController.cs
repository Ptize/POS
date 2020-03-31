using Microsoft.AspNetCore.Mvc;
using POStsCRiptum.Model;
using POStsCRiptum.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POStsCRiptum.Controllers
{
    //Основной контроллер, который содержит в себе методы 
    //отдачи листа категорий товаров, 
    //списков самих товаров
    [ApiController]
    [Route("[controller]")]
    public class MainController
    {
        /// <summary>
        /// Заглушка
        /// Возвращает список доступных категорий товаров
        /// </summary>
        /// <returns>IEnumerable<string></returns>
        [HttpGet]
        public IEnumerable<string> GetListOfCategory()
        {
            var result = new CategoryView();
            return result.CategoryList;
        }

        /// <summary>
        /// Заглушка
        /// Возвращает список доступных товаров
        /// </summary>
        /// <returns>IEnumerable<Goods></returns>
        [HttpGet]
        public IEnumerable<Goods> GetListOfGoods(string category)
        {
            //TODO:Поиск в БД товаров по категории
            var result = new GoodsView();
            return result.GoodsList;
        }
    }
}
