# Rotativa.AspNetCore

<h3>Aplicação:</h3>
<p>Essa aplicação contém um exemplo de geração de .pdf através de uma view com estilo e dados dinâmicos.</p>

<br/>

<p>Biblioteca: Rotativa.AspNetCore</p>
<p>Banco de Dados: Não</p>
<p>ORM (Object Relational Mapping): Não</p>

<br/>

<h3>Como configurar e usar:</h3>
<ol type="number">
  <li>Criar um projeto <b>Web Asp.Net Core</b></li>
  
  <li>Baixe o pacote <b>Rotativa.AspNetCore</b> via NuGet</li>
  
  <li>Criar uma pasta em <b>"wwwroot"</b> chamada <b>"rotativa"</b></li>  
  
  <li>Copiar os seguinte arquivos para a pasta <b>"wwwroot/rotativa"</b>: help-wkhtmltoimage.txt, help-wkhtmltopdf.txt, wkhtmltoimage.exe, wkhtmltopdf.exe</li>
  
  <li>
    No arquivo Startup.cs em Configure, adicione a linha de código: <b>RotativaConfiguration.Setup(env);</b><br/>
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
    Na Controller use o comando <b>ViewAsPdf()</b> para gerar o .pdf a partir de uma view, passandos por parâmetro a view e um objeto caso necessário.</b>
    <blockquote>   
  
      public IActionResult Index()
      {
          List<Pessoa> pessoas = new List<Pessoa>()
          {
              new Pessoa(){ Cpf="127.256.369.35", Nome="Lucas Santos", Sexo="Masculino", Idade=23, Telefone="3841-3856" },
              new Pessoa(){ Cpf="185.989.636.85", Nome="Júlia Almeida", Sexo="Feminino", Idade=13, Telefone="3142-3885" },
              new Pessoa(){ Cpf="589.245.854.14", Nome="Carlos Cesar", Sexo="Masculino", Idade=35, Telefone="3885-1212" },
              new Pessoa(){ Cpf="753.357.147.25", Nome="Altair Silva", Sexo="Masculino", Idade=58, Telefone="3696-1296" },
              new Pessoa(){ Cpf="441.258.369.85", Nome="Ana Clara", Sexo="Feminino", Idade=21, Telefone="3758-4745" },
              new Pessoa(){ Cpf="758.969.354.14", Nome="Lara Magalhães", Sexo="Feminino", Idade=18, Telefone="3996-6658" },
              new Pessoa(){ Cpf="894.758.263.21", Nome="Ronaldo Santos", Sexo="Masculino", Idade=40, Telefone="3745-7585" },
              new Pessoa(){ Cpf="141.456.251.32", Nome="Marcus Vinícius", Sexo="Masculino", Idade=32, Telefone="3442-3365" },
          };

          return new ViewAsPdf("Index", pessoas);
      }
   </blockquote>
  </li> 
</ol>
