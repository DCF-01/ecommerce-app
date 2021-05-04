﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using semenarna_id2.Areas.Store.ViewModels;
using semenarna_id2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semenarna_id2.Areas.Store.Controllers {
    [Area("Store")]
    public class ProductController : Controller {
        private ApplicationDbContext _ctx;
        public ProductController(ApplicationDbContext applicationDbContext) {
            _ctx = applicationDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> Single(int id) {

            var item = await _ctx.Products.Include(item => item.Categories)
                                    .Include(item => item.Spec)
                                    .Include(item => item.GalleryImages)
                                    .Include(item => item.Variations)
                                    .Where(item => item.ProductId == id)
                                    .Select(item => item)
                                    .FirstOrDefaultAsync();




            //finish spec

            if (item != null) {
                var spec = await _ctx.Specs
                .Where(s => s.Name == item.Spec.Name)
                .Select(s => s).FirstOrDefaultAsync();



                var product = new ProductViewModel {
                    ProductId = item.ProductId,
                    Name = item.Name,
                    Description = item.Description,
                    Price = int.Parse(item.Price),
                    SalePrice = int.Parse(item.SalePrice),
                    OnSale = item.OnSale,
                    InStock = item.InStock,
                    Categories = item.Categories,
                    Variations = item.Variations.ToList(),
                    Spec = new StoreSpecViewModel {
                        ItemsPerRow = spec.ItemsPerRow,
                        First = spec.First,
                        Rest = spec.Rest,
                        Name = spec.Name
                    },
                    Img = Convert.ToBase64String(item.Img)
                };
                if (item.GalleryImages != null) {
                    List<string> img_gallery = new List<string>();
                    foreach (var image in item.GalleryImages) {
                        img_gallery.Add(Convert.ToBase64String(image.Img));
                    }
                    product.GalleryImages = img_gallery;
                }
                return View(product);
            }

            return NotFound();

        }
    }
}
