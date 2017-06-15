using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPIApplication.Models;

namespace WebAPIApplication.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            var result = DocumentRepo.GetDocuments();
            return new ObjectResult(result);
        }

        public static class DocumentRepo
        {
            public static List<Document> GetDocuments()
            {
                // Initialize list with collection initializer.
                List<Document> docs = new List<Document>(){
                new Document(){ id = 890, institution = "Richter & Jeter Ltd"},
                new Document(){ id = 391, institution = "Biscayne Investment Inc."},
                new Document(){ id = 248, institution = "Wynwood Ventures"},
                new Document(){ id = 427, institution = "International Advisors"},
                new Document(){ id = 892, institution = "The Cobb Group"}
            };

                return docs;
            }
        }
    }
}
