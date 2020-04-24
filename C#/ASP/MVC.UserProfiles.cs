using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;

// UserProfile.cs in Models folder:
namespace Models
{
    public class UserProfile
    {
        public UserProfile()
        {

        }

        // For ActionResult ListOfUserProfiles();
        public UserProfile(string username,  string password, bool iua)
        {
            Username = username;
            Password = password;
            IsUserActive = iua;
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsUserActive { get; set; }
    }
}

namespace SendingDataToView.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/

        public ActionResult Index()
        {
            // ViewData Key Value Pair
            ViewData["message1"] = "This is a test message1!";

            // ViewBag Dynamic Key Value Pair
            ViewBag.message2 = "This is a test message2!";

            // ViewData and ViewBag can interchange data
            ViewData["message3"] = "This is a test message3!";

            // ViewBag is a newer method
            ViewBag.message4 = "This is a test message4!";
            return View();
        }

        // Example usage in View:

        // <div>
        //     Message1: @ViewData["message1"]
        //     <br />
        //     Message2: @ViewBag.message2
        //     <br />
        //     Message3: @ViewBag.message3
        //     <br />
        //     Message4: @ViewData["message4"]
        // </div>

        public ActionResult ShowUserProfile()
        {
            UserProfile oUserProfile = new UserProfile();
            oUserProfile.Username = "havij";
            oUserProfile.Password = "12345";
            oUserProfile.IsUserActive = true;

            ViewBag.MyUserProfile = oUserProfile;

            return View();
        }

        // Expamle usage in View:

        // <div>
        //     Username: @ViewBag.MyUserProfile.Username
        //     <br />
        //     Password: @ViewBag.MyUserProfile.Password
        //     <br />
        //     Is User Active? @ViewBag.MyUserProfile.IsUserActive
        // </div>
        
        public ActionResult ShowUserProfile2()
        {
            UserProfile oUserProfile = new UserProfile();
            oUserProfile.Username = "havij";
            oUserProfile.Password = "12345";
            oUserProfile.IsUserActive = true;

            ViewBag.ProductName = "Sibzamini";

            // Write @model Models.UserProfile in View to access intellisense

            return View(oUserProfile);
        }

        // Example in View:

        // Username: @Model.Username

        // Password: @Model.Password

        // Is User Active? @Model.IsUserActive

        // Product Name: @ViewBag.ProductName


        public ActionResult ShowUserProfile3()
        {
            // 0- Models.UserProfile namespace
            // 1- Create ViewModels folder in Solution
            // 2- Add MyClassViewModel file to ViewModels
            // 3- Rename namespace to ViewModels

            // namespace ViewModels
            // {
            //     public class MyClassViewModel
            //     {
            //         public Models.UserProfile UserProfile { get; set; }
            //         public string ProductName { get; set; }
            //     }
            // }

            ViewModels.MyClassViewModel oMyClassViewModel = new ViewModels.MyClassViewModel();

            oMyClassViewModel.UserProfile = new UserProfile();
            oMyClassViewModel.UserProfile.Username = "khiarshoor";
            oMyClassViewModel.UserProfile.Password = "12345789";
            oMyClassViewModel.UserProfile.IsUserActive = true;

            oMyClassViewModel.ProductName = "shalgham";

            return View(oMyClassViewModel);
        }

        // Example usage in ShowUserProfile3.cshtml View

        /*
        @model ViewModels.MyClassViewModel
        @{
            Layout = null;
        }

        <!DOCTYPE html>
        <html>
        <head>
            <meta name="viewport" content="width=device-width" />
            <title>ShowUserProfile3</title>
        </head>
        <body>
            <div> 
                Username: @Model.UserProfile.Username
            </div>
            <div>
                Password: @Model.UserProfile.Password
            </div>
            <div>
                Is User Active? @Model.UserProfile.IsUserActive
            </div>
            <div>
                Product Name: @Model.ProductName
            </div>
        </body>
        </html>
         */

        public ActionResult ListOfUserProfiles()
        {
            UserProfile oup1 = new UserProfile("havij","12345",true);
            UserProfile oup2 = new UserProfile("sib", "67890", false);
            UserProfile oup3 = new UserProfile("shalgham","12",true);

            List<UserProfile> userProfiles = new List<UserProfile>();

            userProfiles.Add(oup1);
            userProfiles.Add(oup2);
            userProfiles.Add(oup3);

            return View(userProfiles);
        }

        // View:

        /*
        @model IEnumerable<Models.UserProfile>

        @{
            Layout = null;
        }

        <!DOCTYPE html>

        <html>
        <head>
            <meta name="viewport" content="width=device-width" />
            <title>List Of User Profiles</title>
        </head>
        <body>
            <div> 
                @foreach (var item in Model)
                {
                    <div>Username: @item.Username</div>
                    <div>Password: @item.Password</div>
                    <div>Is User Active? @item.IsUserActive</div>
                    <div>------------------------------------------</div>
                }
            </div>
        </body>
        </html>
         */

        public ActionResult CreateUserProfile()
        {
            // T4 Scaffolding:
            // 1- Add View
            // 2- Template: Create
            // 3- Model Class: UserProfile.cs
            return View();
        }
	}
}