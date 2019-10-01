// ~/Models/User.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models
{
    public class User
    {
        public User()
        {

        }

        public int Id { get; set; }

        //[Required(ErrorMessageResourceType 
        //                        = typeof(Resources.ErrorMessages),
        //    ErrorMessageResourceName = "RequiredError")]
        //[System.Web.Mvc.Remote("CheckUsername", "Account")]

        [Infrastructures.MaxWords(3)]
        public string Username { get; set; }

        [RegularExpression(pattern: "[a-zA-Z0-9]{8,20}", ErrorMessage="{0} must be between 8 to 20 chars")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Range(18,80)]
        public int Age { get; set; }

        [Range(typeof(decimal), "0.00", "49.99")]
        //[ScaffoldColumn(false)]
        //[DisplayFormat(ApplyFormatInEditMode=true, DataFormatString="{0:c}")]
        //[ReadOnly(true)]
        //[HiddenInput]
        public decimal Score { get; set; }
    }
}

// ~/Models/UserContext.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UserContext : System.Data.Entity.DbContext
    {
        public UserContext()
        {

        }
        public System.Data.Entity.DbSet<User> Users { get; set; }
    }
}

// ~/Controllers/UserController
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Models;

namespace Validation_In_MVC.Controllers
{
    public class UserController : Controller //Infrastructure.BaseController
    {
        private UserContext db = new UserContext();

        // GET: /User/
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        // GET: /User/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: /User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /User/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Username,Password,ConfirmPassword,Age,Score")] User user)
        {
            if (ModelState.IsValid)
            //if(ModelState.IsValidField("Password"))
            //if(ModelState["Password"].Errors.Count > 0)
            {
                //ModelState["Password"].Errors[0].ErrorMessage;
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user);
        }

        // GET: /User/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: /User/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Username,Password,ConfirmPassword,Age,Score")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: /User/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: /User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

// ~/Controllers/AccountController.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Validation_In_MVC.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CheckUsername(string Username)
        {
            Models.UserContext db = new Models.UserContext();
            var result = db.Users.Where(current => current.Username == Username).FirstOrDefault();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
	}
}

// ~/Web.Config
  <connectionStrings>
    <add name="UserContext" connectionString="Data Source=.;Integrated Security=SSPI;Initial Catalog=Validation;" providerName="System.Data.SqlClient" />
  </connectionStrings>