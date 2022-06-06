# POC.Rotativa.AspNetCore

## Aplicação:
<p>Essa aplicação contém um exemplo de uso da biblioteca Rotativa.AspNetCore, que converte uma view estática ou com dados dinâmicos em .pdf.</p>

---

## Frameworks:
- .Net Core 2.1
- .Net Core 3.1
- .Net 5
- .Net 6

---

## Bibliotecas (principais):
- Rotativa.AspNetCore
- Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation

---

## Como configurar e usar:
1. Criar um projeto **Web Asp.Net Core**
2. Baixe o pacote **Rotativa.AspNetCore** via NuGet
3. Criar uma pasta em **wwwroot** chamada **rotativa-aspnetcore**</li>  
4. Copiar os seguinte arquivos para a pasta:
    - help-wkhtmltoimage.txt
    - help-wkhtmltopdf.txt
    - wkhtmltoimage.exe
    - wkhtmltopdf.exe
  
5. **Observação:** Para cada versão do .Net deve ser feita uma configuração do MVC e Environment.

    No arquivo **Startup.cs** em **Configure**, adicione a linha de código: **"RotativaConfiguration.Setup(env.WebRootPath, @"lib/rotativa-aspnetcore");"**

    <blockquote>
      
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            RotativaConfiguration.Setup(env.WebRootPath, @"lib/rotativa-aspnetcore");
        }
    
   </blockquote>
  
6. Na Controller use o comando **ViewAsPdf()** para gerar o .pdf a partir de uma view, passandos por parâmetro a view e um objeto caso necessário.

    <blockquote>   
  
        public IActionResult Index()
        {
            List<Client> clients = new List<Client>()
            {
                new Client(){ Cpf="127.256.369.35", Name="Lucas Santos", Gender="Masculino", Age=23, Telephone="3841-3856" },
                new Client(){ Cpf="185.989.636.85", Name="Júlia Almeida", Gender="Feminino", Age=13, Telephone="3142-3885" },
                new Client(){ Cpf="589.245.854.14", Name="Carlos Cesar", Gender="Masculino", Age=35, Telephone="3885-1212" },
                new Client(){ Cpf="753.357.147.25", Name="Altair Silva", Gender="Masculino", Age=58, Telephone="3696-1296" },
                new Client(){ Cpf="441.258.369.85", Name="Ana Clara", Gender="Feminino", Age=21, Telephone="3758-4745" },
                new Client(){ Cpf="758.969.354.14", Name="Lara Magalhães", Gender="Feminino", Age=18, Telephone="3996-6658" },
                new Client(){ Cpf="894.758.263.21", Name="Ronaldo Santos", Gender="Masculino", Age=40, Telephone="3745-7585" },
                new Client(){ Cpf="141.456.251.32", Name="Marcus Vinícius", Gender="Masculino", Age=32, Telephone="3442-3365" },
            };

            return new ViewAsPdf("Index", clients);
        }

   </blockquote>