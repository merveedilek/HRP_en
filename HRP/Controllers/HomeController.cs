using HRP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace HRP.Models
{
    public class HomeController : Controller
    {
        // GET: Home
        private HrpData _data;
        public HomeController()
        {
            _data = new HrpData();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        [Route("Garden-furniture")]

        public ActionResult BahceMobilyalari()
        {
            return View();
        }
        [Route("Indoor-furniture")]

        public ActionResult IcMekanMobilyalari()
        {
            return View();
        }
        [Route("Accesories")]

        public ActionResult Aksesuarlar()
        {
            return View();
        }
        [Route("Lighting-Produtcs")]

        public ActionResult AydinlatmaUrunleri()
        {
            return View();
        }
        [Route("Urban-Furniture")]

        public ActionResult KentMobilyalari()
        {
            return View();
        }
        [Route("Complementary-products")]

        public ActionResult TamamlayiciUrunler()
        {
            return View();
        }
        [Route("Gallery")]

        public ActionResult Galeri()
        {
            return View();
        }
        [Route("garden-details")]

        public ActionResult BahceDetay(int id)
        {
            HrpData data = new HrpData();
            BahceModel bahceModel = new BahceModel();
            var urun = data.bahceModels.Where(x => x.BahceId == id).FirstOrDefault();
            bahceModel = urun;
            return View(bahceModel);
        }
        [Route("indoor-details")]

        public ActionResult icMekanDetay(int id)
        {
            HrpData data = new HrpData();

            icMekanModel icMekanModel = new icMekanModel();
            var urun = data.icMekanModels.Where(x => x.icMekanId == id).FirstOrDefault();
            icMekanModel = urun;
            return View(icMekanModel);
        }
        [Route("accesories-details")]

        public ActionResult AksesuarDetay(int id)
        {
            HrpData data = new HrpData();

            AksesuarModel aksesuarModel = new AksesuarModel();
            var urun = data.aksesuarModels.Where(x => x.aksesuarId == id).FirstOrDefault();
            aksesuarModel = urun;
            return View(aksesuarModel);
        }
        [Route("urban-details")]

        public ActionResult KentMobilyaDetay(int id)
        {
            HrpData data = new HrpData();

            KentModel kentModel = new KentModel();
            var urun = data.kentModels.Where(x => x.KentId == id).FirstOrDefault();
            kentModel = urun;
            return View(kentModel);
        }
        [Route("lighting-details")]

        public ActionResult AydinlatmaDetay(int id)
        {
            HrpData data = new HrpData();

            AydinlatmaModel aydinlatmaModel = new AydinlatmaModel();
            var urun = data.aydinlatmaModels.Where(x => x.AydinlatmaId == id).FirstOrDefault();
            aydinlatmaModel = urun;
            return View(aydinlatmaModel);
        }
        [Route("Wood-type-options")]

        public ActionResult AhsapTipi()
        {
            return View();
        }
        [Route("Fabrics-options")]

        public ActionResult Kumas()
        {
            return View();
        }
        [Route("Leather-options")]

        public ActionResult DeriDoseme()
        {
            return View();
        }
        [Route("Metal-color-options")]

        public ActionResult MetalRenk()
        {
            return View();
        }
        [HttpPost]
        public ActionResult iletisim(iletisim form)
        {
            SmtpClient mailClient = new SmtpClient("smtp.gmail.com", 587);
            NetworkCredential cred = new NetworkCredential("hrpiletisim@gmail.com", "Hrp123...");
            mailClient.Credentials = cred;
            MailMessage contact = new MailMessage();
            contact.From = new MailAddress("hrpiletisim@gmail.com"); //burası kendi maili
            contact.Subject = "İletişim Formu " + DateTime.Now;
            contact.IsBodyHtml = true;
            contact.Body = "www.hrpfurniture.co.uk web sitesinden iletişim formu dolduruldu. <br/>";
            contact.Body += "<br/>Ad Soyad: " + form.Ad;
            contact.Body += "<br/>Email: " + form.Mail;
            contact.Body += "<br/>Mesaj: " + form.Mesaj;
            mailClient.EnableSsl = true;
            contact.To.Add("mdilek3496@gmail.com"); //burası info maili
            mailClient.EnableSsl = true;
            mailClient.Send(contact);
            return RedirectToAction("iletisim");

        }
        [Route("Contact")]

        public ActionResult iletisim()
        {
            return View();
        }
    }
}