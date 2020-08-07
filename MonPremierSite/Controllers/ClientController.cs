using Microsoft.AspNetCore.Mvc;
using MonPremierSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MonPremierSite.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListeClients()
        {
            Clients clients = new Clients();
            ViewData["Clients"] = clients.ObtenirListeClients();
            return View();
        }

        public ActionResult Details(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Client
                .FirstOrDefaultAsync(m => m.Id == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);*/
            Clients clients = new Clients();
            Client client = clients.ObtenirListeClients().FirstOrDefault(c => c.Id == id);
            if (client != null)
            {
                ViewData.Add("Id", client.Id);
                ViewData.Add(new KeyValuePair<string, object>("FirstName", client.FirstName));
                ViewData.Add(new KeyValuePair<string, object>("LastName", client.LastName));
                ViewData.Add(new KeyValuePair<string, object>("Username", client.Username));
                ViewData.Add(new KeyValuePair<string, object>("Email", client.Email));                
                return View("Detail");
            }
            return View("NotFound");
        }

        private IActionResult NotFound()
        {
            throw new NotImplementedException();
        }

        // GET: Clients/Delete/5
        /*public async Task<IActionResult> Delete(string id)
        {
            *//*if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Client
                .FirstOrDefaultAsync(m => m.Id == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);*//*
        }*/

        // POST: Clients/Delete/5
        /*[HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            *//*var client = await _context.Client.FindAsync(id);
            _context.Client.Remove(client);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));*//*
        }*/
    }
}