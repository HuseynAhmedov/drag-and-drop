﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.Areas.Manage.ViewModels;
using Pustok.Helper;
using Pustok.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.Areas.Manage.Controllers
{
    [Area("manage")]
    public class ProductController : Controller
    {
        DataContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductController(DataContext context , IWebHostEnvironment env)
        {
            this._context = context;
            this._env = env;
        }

        public ActionResult Index(int page = 1)
        {
            PageNationVM pageNation = new PageNationVM();
            ProductVM productVM = new ProductVM();
            productVM.Products = _context.Products.Include(x=> x.Author).Include(y=> y.Genre).Include(a=> a.Category).Include(w => w.ProductImages).Skip((page - 1) * 4).Take(4).ToList();
            
            pageNation.PageCount = (int)Math.Ceiling(Convert.ToDouble(_context.Products.Count()) / 4);
            pageNation.PageSelected = page;
            productVM.pageNation = pageNation;

            return View(productVM);
        }

        public ActionResult Info(int id)
        {
            Product product = _context.Products.Include(x => x.Author).Include(y => y.Genre).Include(a => a.Category).Include(w=> w.ProductImages).Include(x => x.ProductTags).ThenInclude(pr => pr.Tag).FirstOrDefault(x => x.Id == id);
            return View(product);
        }

        public ActionResult Create()
        {
            ViewBag.Category = _context.Categories.ToList();
            ViewBag.Authors = _context.Authors.ToList();
            ViewBag.Genres = _context.Genres.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            ViewBag.Category = _context.Categories.ToList();
            ViewBag.Authors = _context.Authors.ToList();
            ViewBag.Genres = _context.Genres.ToList();

            if (!_context.Authors.Any(x => x.Id == product.AuthorId))
            {
                ModelState.AddModelError("AuthorId", "Author not found");
                return View();
            }

            if (!_context.Genres.Any(x => x.Id == product.GenreId))
            {
                ModelState.AddModelError("GenreId", "Genre not found");
                return View();
            }

            if (ChkImage("PosterFile", product.PosterImageFile) == false)
            {
                if (!ModelState.IsValid) return View();
            }
            else
            {

                ProductImage poster = new ProductImage
                {
                    Source = FileManager.Save(_env.WebRootPath, "image/upload/product", product.PosterImageFile),
                    Product = product,
                    MainImage = true
                };

                _context.ProductImages.Add(poster);
            }

            if (ChkImage("HoverPosterFile",product.HoverImageFile,true) == false)
            {
               if (!ModelState.IsValid) return View();
            }
            else
            {

                ProductImage hover = new ProductImage
                {
                    Source = FileManager.Save(_env.WebRootPath, "image/upload/product", product.HoverImageFile),
                    Product = product,
                    HoverImage = true
                };

                _context.ProductImages.Add(hover);
            }



            if (product.ImageFiles != null)
            {
                foreach (var item in product.ImageFiles)
                {

                    if (ChkImage("ImageFiles", item) == false)
                    {
                        return View();
                    }
                    else
                    {
                        ProductImage bookImage = new ProductImage
                        {
                            Product = product,
                            Source = FileManager.Save(_env.WebRootPath, "image/upload/product", item)
                        };

                        _context.ProductImages.Add(bookImage);
                    }
                }
            }

            _context.Products.Add(product);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Category = _context.Categories.ToList();
            ViewBag.Authors = _context.Authors.ToList();
            ViewBag.Genres = _context.Genres.ToList();
            Product product = _context.Products.Include(x => x.Author).Include(y => y.Genre).Include(a => a.Category).Include(w => w.ProductImages).FirstOrDefault(x => x.Id == id);
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            ViewBag.Category = _context.Categories.ToList();
            ViewBag.Authors = _context.Authors.ToList();
            ViewBag.Genres = _context.Genres.ToList();

            Product productBase = _context.Products.Include(x => x.Author).Include(y => y.Genre).Include(a => a.Category).Include(w => w.ProductImages).FirstOrDefault(x => x.Id == product.Id);

            if (!_context.Authors.Any(x => x.Id == product.AuthorId))
            {
                ModelState.AddModelError("AuthorId", "Author not found");
                return View();
            }

            if (!_context.Genres.Any(x => x.Id == product.GenreId))
            {
                ModelState.AddModelError("GenreId", "Genre not found");
                return View();
            }

            if (ChkImage("PosterFile", product.PosterImageFile) == false)
            {
                if (!ModelState.IsValid) return View();
            }
            else
            {
                FileManager.Delete(_env.WebRootPath, productBase.ProductImages.FirstOrDefault(x => x.MainImage == true).Source);
                ProductImage image = _context.ProductImages.FirstOrDefault(x => x.ProductID == product.Id && x.MainImage == true);
                image.Source = FileManager.Save(_env.WebRootPath, "image/upload/product", product.PosterImageFile);
                image.ProductID = product.Id;
            }


            if (ChkImage("HoverPosterFile", product.HoverImageFile, true) == false)
            {
                if (!ModelState.IsValid) return View();
            }
            else
            {
                FileManager.Delete(_env.WebRootPath, productBase.ProductImages.FirstOrDefault(x=> x.HoverImage == true).Source);
                ProductImage image = _context.ProductImages.FirstOrDefault(x => x.ProductID == product.Id && x.HoverImage == true);
                image.Source = FileManager.Save(_env.WebRootPath, "image/upload/product", product.PosterImageFile);
                image.ProductID = product.Id;
            }



            if (product.ImageFiles != null)
            {
                foreach (var item in product.ImageFiles)
                {

                    if (ChkImage("ImageFiles", item) == false)
                    {
                        if (!ModelState.IsValid) return View();
                    }
                    else
                    {
                        if (productBase.ProductImages.FirstOrDefault(x => x.HoverImage == false && x.MainImage == false).Source != null)
                        {
                            FileManager.Delete(_env.WebRootPath, productBase.ProductImages.FirstOrDefault(x => x.HoverImage == false && x.MainImage == false).Source);
                        }
                        ProductImage image = _context.ProductImages.FirstOrDefault(x => x.ProductID == product.Id && x.HoverImage == false && x.MainImage == false);
                        image.Source = FileManager.Save(_env.WebRootPath, "image/upload/product", item);
                        image.ProductID = product.Id;
                    }
                }
            }

            
            productBase.Title = product.Title;
            productBase.Article = product.Article;
            productBase.Availability = product.Availability;
            productBase.Featured = product.Featured;
            productBase.New = product.New;
            productBase.Price = product.Price;
            productBase.PriceDiscount = product.PriceDiscount;
            productBase.PriceOld = product.PriceOld;
            productBase.ProductImages = product.ProductImages;
            productBase.CategoryId = product.CategoryId;
            productBase.AuthorId = product.AuthorId;
            productBase.GenreId = product.GenreId;
            productBase.StarCount = product.StarCount;

            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public ActionResult Delete(int id)
        {
            if (_context.Products.FirstOrDefault(x => x.Id == id) == null) { return NotFound(); }
            Product toDelete = _context.Products.Include(x=> x.ProductImages).FirstOrDefault(x => x.Id == id);
            foreach(ProductImage item in toDelete.ProductImages)
            {
                if (!string.IsNullOrWhiteSpace(item.Source))
                {
                    FileManager.Delete(_env.WebRootPath, item.Source);
                }
            }
            _context.Products.Remove(toDelete);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        private bool ChkImage(string fieldName , IFormFile formFile)
        {
            if (formFile == null)
            {
                return false;
            }
            if (formFile.Length > 2097152)
            {
                ModelState.AddModelError($"{fieldName}", "HoverPosterFile max size is 2MB");
                return false;
            }
            if (formFile.ContentType != "image/jpeg" && formFile.ContentType != "image/png")
            {
                ModelState.AddModelError($"{fieldName}", "ContentType must be image/jpeg or image/png");
                return false;
            }
            return true;
        }

        private bool ChkImage(string fieldName, IFormFile formFile , bool requried = true)
        {
            if (formFile == null)
            {
                ModelState.AddModelError($"{fieldName}", "Image is required");
                return false;
            }
            if (formFile.Length > 2097152)
            {
                ModelState.AddModelError($"{fieldName}", "Image max size is 2MB");
                return false;
            }
            if (formFile.ContentType != "image/jpeg" && formFile.ContentType != "image/png")
            {
                ModelState.AddModelError($"{fieldName}", "ContentType must be image/jpeg or image/png");
                return false;
            }
            return true;
        }
    }
}