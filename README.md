# POC.Rotativa.AspNetCore

## Application:
This application contains an example of using the Rotativa.AspNetCore library, which converts a static view or a view with dynamic data into .pdf.

---

## Frameworks:
- .Net Core 2.1
- .Net Core 3.1
- .Net 5
- .Net 6

---

## Libraries (only most important):
- Bootstrap
- Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
- Rotativa.AspNetCore

---

## How to configure and use:
1. Create an Asp.Net Core Web Project

2. Download the `Rotativa.AspNetCore` package via NuGet

3. Create a folder in `wwwroot` called `rotativa-aspnetcore`

4. Copy the following files to the folder:
    - `help-wkhtmltoimage.txt`
    - `help-wkhtmltopdf.txt`
    - `wkhtmltoimage.exe`
    - `wkhtmltopdf.exe`

5. **Observation:** For each version of .Net an MVC and Environment configuration must be used.
    
    In the `Startup.cs` file, add in the `Configure` method, the line of code:  
    
    ```c#
    RotativaConfiguration.Setup(env.WebRootPath, @"lib/rotativa-aspnetcore");
    ```

    For example:

    ```c#
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
        });

        RotativaConfiguration.Setup(env.WebRootPath, @"lib/rotativa-aspnetcore");
    }
    ```
  
6. In the Controller, use the `ViewAsPdf()` command to generate the .pdf from a view, passing the view and an object as parameters if necessary.

    ```c#
    public IActionResult Index()
    {
        List<Client> clients = new List<Client>()
        {
            new Client(){ Cpf="127.256.369.35", Name="Lucas Santos", Gender="Male", Age=23, Telephone="3841-3856" },
            new Client(){ Cpf="185.989.636.85", Name="Júlia Almeida", Gender="Female", Age=13, Telephone="3142-3885" },
            new Client(){ Cpf="589.245.854.14", Name="Carlos Cesar", Gender="Male", Age=35, Telephone="3885-1212" },
            new Client(){ Cpf="753.357.147.25", Name="Altair Silva", Gender="Male", Age=58, Telephone="3696-1296" },
            new Client(){ Cpf="441.258.369.85", Name="Ana Clara", Gender="Female", Age=21, Telephone="3758-4745" },
            new Client(){ Cpf="758.969.354.14", Name="Lara Magalhães", Gender="Female", Age=18, Telephone="3996-6658" },
            new Client(){ Cpf="894.758.263.21", Name="Ronaldo Santos", Gender="Male", Age=40, Telephone="3745-7585" },
            new Client(){ Cpf="141.456.251.32", Name="Marcus Vinícius", Gender="Male", Age=32, Telephone="3442-3365" }
        };

        return new ViewAsPdf("Index", clients);
    }
    ```