using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test1109.Models;

namespace test1109.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            TempData["Name"] = "陳小強";
            ViewData["Name"] = "陳小強";
            ViewBag.Name = "陳小強";
            return RedirectToAction("ShowTempData");
            //return View();
        }
        public ActionResult ShowTempData()
        {
            return View();
        }
        public ActionResult ShowMembers()
        {
            var memberA = new Member() { Id = 1, Name = "Alex", Age = 12 };
            var memberB = new Member() { Id = 2, Name = "Ben", Age = 34 };
            var memberC = new Member() { Id = 3, Name = "Carol", Age = 56 };
            var memberList = new List<Member>() { memberA, memberB, memberC };
            ViewData["Members"] = memberList;
            return View();
        }

        public ActionResult ShowMembers2()
        {
            var memberA = new Member() { Id = 1, Name = "Alex", Age = 12 };
            var memberB = new Member() { Id = 2, Name = "Ben", Age = 34 };
            var memberC = new Member() { Id = 3, Name = "Carol", Age = 56 };
            var memberList = new List<Member>() { memberA, memberB, memberC };
            //ViewData["Members"] = memberList;
            ViewBag.Members = memberList;
            return View();
        }

        public ActionResult ShowMembers3()
        {
            var memberA = new Member() { Id = 1, Name = "Alex", Age = 12 };
            var memberB = new Member() { Id = 2, Name = "Ben", Age = 34 };
            var memberC = new Member() { Id = 3, Name = "Carol", Age = 56 };
            var memberList = new List<Member>() { memberA, memberB, memberC };

            return View(memberList);
        }

        public ActionResult ShowShoppingList()
        {
            var member = new Member() { Id = 1, Name = "Alex", Age = 12 };
            var products = new List<Product>();
            products.Add(new Product { Number = 1, Name = "Apple", Price = 30 });
            products.Add(new Product { Number = 2, Name = "Banana", Price = 50 });
            products.Add(new Product { Number = 3, Name = "Cherry", Price = 100 });

            var memberInfo = new MemberInfoViewModel();
            memberInfo.Member = member;
            memberInfo.Products = products;

            return View(memberInfo);
        }

        //GET: Demo/ShowHelloWorld
        [HttpGet] //可省略
        public string ShowHelloWorld()
        {
            return "Hello World!";
        }
        [HttpGet] //可省略
        public string ShowPrice(string product, int price)
        {
            return $"商品是:{product}，價格是:{price}";
        }
    }
}