using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components.Forms;
using ReZero;
using ReZero.SuperAPI;
using SuperAPITest;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Register: Register the super API service
//ע�᣺ע�ᳬ��API����
builder.Services.AddReZeroServices(api =>
{
    //���ó���API
    api.EnableSuperApi(new SuperAPIOptions()
    {
        DatabaseOptions = new DatabaseOptions()
        {
            ConnectionConfig = new SuperAPIConnectionConfig()
            {
                ConnectionString = "PORT=5432;DATABASE=SqlSugar5Demo;HOST=localhost;PASSWORD=postgres;USER ID=postgres",
                DbType = SqlSugar.DbType.PostgreSQL,
            },
        },
        InterfaceOptions = new InterfaceOptions()
        {
            SuperApiAop = new JwtAop()//��Ȩ������
        }
    }); ;

});
 
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run(); 
