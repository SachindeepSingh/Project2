using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message1 = "Located in Calgary, Alberta and serving all of Canada, the Silk Road is a family business inspired by the senses. We love to cook and experiment with unusual ingredients. And when you love to feed the senses, there’s nothing quite like the colours, smells and flavours of spices. We are totally passionate about the ability of spices to turn a standard kitchen into an incredible adventure.";
            ViewBag.Message2 = "We started The Silk Road in 2008 after realizing that it was very difficult – if not impossible – to find the spices, herbs and chiles we needed for recipes we wanted to try. One recipe would often mean trips to several different stores, and sometimes there would still be something we just couldn’t find. This is certainly the case in Calgary, and we suspect it’s much the same everywhere in Canada. We used to wonder why there wasn’t one specialty shop that had every kind of spice imaginable, and eventually we decided to open that shop ourselves.";
            ViewBag.Message3 = "We’re not a fancy, high-priced boutique – we’re aiming to be your local go-to shop, and thanks to the internet, we think of ourselves as being right in your neighbourhood. We sell a complete range of spices, herbs, chiles and seasonings from around the world and take great care in sourcing the finest products available. We buy our stock regularly and in small batches to ensure that everything is as fresh as possible. As much as we can, we grind our own spices to ensure they are never sitting for months in a warehouse. All of our spice blends are hand-mixed and have been developed, tested, and perfected by us. We mix them using fresh ingredients, and we don’t bulk them up with cheap fillers. You will be amazed at the difference in freshness and flavour compared to most commercial spice blends.";
            ViewBag.Message4 = "Thanks for visiting our website. We encourage you to browse through the spices, categories and cuisines, and hopefully you will see things you’ve never seen before, learn something new, and start to get as excited about the possibilities as we are. If you’re looking for something that we don’t seem to have, or have questions about any of our products, please contact us.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message1 = "Whether a comment from a recent visit to one of our restaurants or a question ... If you don't find what you need on our brand websites, please contact us so we can address your needs.";
            ViewBag.Message2 = "";

            return View();
        }
    }
}