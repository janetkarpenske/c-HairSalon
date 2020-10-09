using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Linq;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
  private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

  public ActionResult Index() //displays main page with list of all stylists
  {
    List<Stylist> model = _db.Stylists.ToList();
      return View(model);
  }
    public ActionResult Create() //displays page with form to add another stylist
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist) //Adds the new stylist to the database
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id) //Returns page with details on a specific stylist and all of their clients
    {
      Stylist thisStylist = _db.Stylists.Include(stylist => stylist.Items).FirstOrDefault(stylists => stylists.StylistId == id);
      return View(thisStylist);
    }

    public ActionResult Edit(int id) //Takes you to edit page for a specific stylist
    {
      var thisStylist = _db.Stylists.FirstOrDefault(stylists => stylists.StylistId == id);
      return View(thisStylist);
    }

    [HttpPost] //Makes an edit to the info of a stylist
    public ActionResult Edit(Stylist stylist)
    {
      _db.Entry(stylist).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

  public ActionResult Delete(int id) //Takes to page to confirm deletion of a stylist
{
    var thisStylist = _db.Stylists.FirstOrDefault(stylists => stylists.StylistId == id);
    return View(thisStylist);
}

[HttpPost, ActionName("Delete")] //Deletes the stylist and redirects to index
public ActionResult DeleteConfirmed(int id)
{
    var thisStylist = _db.Stylists.FirstOrDefault(stylists => stylists.StylistId == id);
    _db.Stylists.Remove(thisStylist);
    _db.SaveChanges();
    return RedirectToAction("Index");
}
  }
}