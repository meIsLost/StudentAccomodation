using StudentAccomodation.Services.ADOServices.ADOApartmentServices;
using StudentAccomodation.Services.ADOServices.ADODormitoryServices;
using StudentAccomodation.Services.ADOServices.ADOLeasingServices;
using StudentAccomodation.Services.ADOServices.ADORoomServices;
using StudentAccomodation.Services.ADOServices.ADOStudentServices;
using StudentAccomodation.Services.Interfaces.IApartmentService;
using StudentAccomodation.Services.Interfaces.IDormitoryService;
using StudentAccomodation.Services.Interfaces.ILeasingService;
using StudentAccomodation.Services.Interfaces.IRoomService;
using StudentAccomodation.Services.Interfaces.IStudent;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddScoped<IApartmentService, ADOApartmentService>();
builder.Services.AddScoped<ADOApartment>();

builder.Services.AddScoped<IDormitoryService, ADODormitoryServices>();
builder.Services.AddScoped<ADODormitory>();

builder.Services.AddScoped<ILeasingService, ADOLeasingService>();
builder.Services.AddScoped<ADOLeasing>();

builder.Services.AddScoped<IRoomService, ADORoomServices>();
builder.Services.AddScoped<ADORoom>();

builder.Services.AddScoped<IStudentService, ADOStudentService>();
builder.Services.AddScoped<ADOStudent>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
