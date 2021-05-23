using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LegalLeadCloser.Data;
using LegalLeadCloser.Models;
using Scrypt;

namespace LegalLeadCloser.Controllers
{
    public class UsersController : Controller
    {
        //Construct a name to call on the database
        private readonly LegalLeadCloserContext _context;
        public UsersController(LegalLeadCloserContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.Users
                .FirstOrDefaultAsync(m => m.UserID == id);
            if (users == null)
            {
                return NotFound();
            }
            return View(users);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            var users = new Users();
            users = new Users
            {
                CreationDate = DateTime.Now,
                Roles = "USER",
        };
            return View(users);
        }
    

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind(@"
                        UserID,
                        CompanyName,
                        CompanyStartDate,
                        FirstName,
                        LastName,
                        StreetAddress,
                        CityAddress,
                        StateAddress,
                        ZipCodeAddress,
                        Phone,
                        Email,
                        CreationDate,
                        SubscriptionSerivice,
                        Roles,
                        Username,
                        Password")] Users users)
        {
            //Initiate the encryption encoder for the password
            ScryptEncoder encoder = new ScryptEncoder();
            //Check if username is already registered
            var registeredUser = (from c in _context.Users
                                  where c.Username.Equals(users.Username)
                                  select c).SingleOrDefault();
            //If the username is found in database send message
            if (registeredUser != null)
            {
                ModelState.AddModelError("", "That username already exists!");
                return View();
            }
            //Check if all the User properties are vaild
            if (ModelState.IsValid)
            {
                //Add property values from Register form - need to add first before encryption to have the user in the database first
                _context.Add(users);
                //Hash password from the User
                string hash = encoder.Encode(users.Password);
                //Assign th ehashed password to the password property
                users.Password = hash;
                //Re-add the property values to capture the new hashed password 
                //TODO : verify the password is protected accross the url/post
                _context.Add(users);
                //Save database
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(users);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.Users.FindAsync(id);
            if (users == null)
            {
                return NotFound();
            }
            return View(users);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind(@"
                        UserID,
                        CompanyName,
                        CompanyStartDate,
                        FirstName,
                        LastName,
                        StreetAddress,
                        CityAddress,
                        StateAddress,
                        ZipCodeAddress,
                        Phone,
                        Email,
                        CreationDate,
                        SubscriptionSerivice,
                        Roles,
                        Username,
                        Password")] Users users)
        {
            if (id != users.UserID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(users);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsersExists(users.UserID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(users);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.Users
                .FirstOrDefaultAsync(m => m.UserID == id);
            if (users == null)
            {
                return NotFound();
            }

            return View(users);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var users = await _context.Users.FindAsync(id);
            _context.Users.Remove(users);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsersExists(int id)
        {
            return _context.Users.Any(e => e.UserID == id);
        }
    }
}
