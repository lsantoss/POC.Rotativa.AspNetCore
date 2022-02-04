# Rotativa.AspNetCore

<h3>Aplicação:</h3>
<p>Essa aplicação contém um exemplo de geração de .pdf através de uma view com estilo e dados dinâmicos.</p>

<br/>

<p>Biblioteca: Rotativa.AspNetCore</p>
<p>Frameworks: .Net Core 2.1</p>
<p>Frameworks: .Net Core 2.1</p>
<p>Frameworks: .Net 5</p>
<p>Frameworks: .Net 6</p>

<br/>

<h3>Como configurar e usar:</h3>
<ol type="number">
  <li>Criar um projeto <b>Web Asp.Net Core</b></li>
  
  <li>Baixe o pacote <b>Rotativa.AspNetCore</b> via NuGet</li>
  
  <li>Criar uma pasta em <b>"wwwroot"</b> chamada <b>"rotativa-aspnetcore"</b></li>  
  
  <li>Copiar os seguinte arquivos para a pasta <b>"wwwroot/rotativa-aspnetcore"</b>: help-wkhtmltoimage.txt, help-wkhtmltopdf.txt, wkhtmltoimage.exe, wkhtmltopdf.exe</li>
  
  <li>    
    <b>Observação:</b> Para cada versão do .Net deve ser feita uma configuração do MVC e Environment <br/>    
    No arquivo Startup.cs em Configure, adicione a linha de código: <b>RotativaConfiguration.Setup(env);</b><br/><br/>    
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

        RotativaConfiguration.Setup(env);
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
