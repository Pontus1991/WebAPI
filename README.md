# CentrumBiblioteket Application

#### Why you should use this application

This application is made for Centrumbiblioteket and is going to serve as a tool to manage bookrentals. 
It's not fully developed yet and in the view you can only see the bookrentals that are late return.

# New Features
 - See late rentals in the application. 
 - Delete RentalId:s that are back to the library.

### For developer

You'll need Visual Studio for developing in this application. 
You need an Azure Account
This particular program is made in ASP.NET core 3.1
The application uses Entity Framework.

Read more about .Net at https://docs.microsoft.com/en-us/

You will need to create the database in Microsoft SQL manager Studio 18.

##### Installation

CentrumBiblioteket requires Visual Studio 2019

Install the dependencies and devDependencies and start the server.

You'll need to install 5 nuget packages to work with this application:

Microsoft.EntityFrameworkCore (3.1.10)
Microsoft.EntityFrameworkCore.Design (3.1.10)
Microsoft.EntityFrameworkCore.SqlServer (3.1.10)
Microsoft.AspNetCore.Mvc.NewtonsoftJson (3.1.10)
Microsoft.Visualstudio.Web.CodeGeneration.Design (3.1.4)

Setup the database in SQL


### Codeexample

This Codeexample shows how you can see bookrentals that haven't been turned in to the library yet. 

```csharp
  // GET: LateRentals
public async Task<IActionResult> Index()
{
    var context = _context.Rentals.Where(r => r.ReturnDate < DateTime.Now).Include(r => r.Inventory); 
    return View(await context.ToListAsync());
}

```

This codeexample adds 3 days for returningdate
```csharp
  [HttpPost]
        public async Task<ActionResult<Rental>> PostRental(Rental rental)
        {
            rental.RentalDate = DateTime.Now; 
            rental.ReturnDate = DateTime.Now.AddDays(3); 
            rental.Rented = true;

            _context.Rentals.Add(rental);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRental", new { id = rental.RentalId }, rental);
        }
        
```

### Tech

CentrumBiblioteket uses a number of open source projects to work properly:
* [Twitter Bootstrap] - great UI boilerplate for modern web apps
* [markdown-it] - Markdown parser done right. Fast and easy to extend.
* [.Net Core]
* Database - SSMS

License
----

MIT

## Free Software

   <https://docs.microsoft.com/en-us/>
    <https://github.com/markdown-it/markdown-it>
   <http://twitter.github.com/bootstrap/>
