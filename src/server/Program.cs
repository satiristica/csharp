using System;
using RequestsHandler;
using Calculator;
using Microsoft.AspNetCore.Mvc.Routing;

// js constructs json once user clicks "=" and sends request 
// => asp.net core deserialization -> c# object 
// => http handler gives data to director 
// => director calls calculator, gets result 
// => http handler returns obj answer 
// => serialization to json and sends back to browser

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


var director = new Director();

app.MapPost("api/calculate", (CalculationRequest request) =>
{
    director.Execute(decimal );
});

app.Run();