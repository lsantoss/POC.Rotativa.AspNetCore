# POC.Rotativa.AspNetCore

<h2>Aplicação:</h2>
<p>Essa aplicação contém um exemplo de uso da biblioteca Rotativa.AspNetCore, que converte uma view estática ou com dados dinâmicos em .pdf.</p>

***

<h2>Frameworks:</h2>
<ul type="disc">
  <li>.Net Core 2.1</li>
  <li>.Net Core 2.1</li>
  <li>.Net 5</li>
  <li>.Net 6</li>
</ul>

***

<h2>Bibliotecas (principais):</h2>
<ul>
  <li>Rotativa.AspNetCore</li>
</ul>

***

<h2>Como configurar e usar:</h2>
<ol type="number">
  <li>Criar um projeto <b>Web Asp.Net Core</b></li>
  
  <li>Baixe o pacote <b>Rotativa.AspNetCore</b> via NuGet</li>
  
  <li>Criar uma pasta em <b>"wwwroot"</b> chamada <b>"rotativa-aspnetcore"</b></li>  
  
  <li>Copiar os seguinte arquivos para a pasta <b>"wwwroot/rotativa-aspnetcore"</b>: 
  <ul type="disc">
    <li>help-wkhtmltoimage.txt</li>
    <li>help-wkhtmltopdf.txt</li>
    <li>wkhtmltoimage.exe</li>
    <li>wkhtmltopdf.exe</li>
  </ul>
  
  <li>    
    <b>Observação:</b> Para cada versão do .Net deve ser feita uma configuração do MVC e Environment <br/>    
    No arquivo Startup.cs em Configure, adicione a linha de código: <b>"RotativaConfiguration.Setup(env.WebRootPath, @"lib/rotativa-aspnetcore");"</b><br/><br/>    
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
  </li> 
  
  <li>
    Na Controller use o comando <b>ViewAsPdf()</b> para gerar o .pdf a partir de uma view, passandos por parâmetro a view e um objeto caso necessário.</b><br/><br/>
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
  </li> 
</ol>
