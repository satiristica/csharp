using System;
using RequestsHandler;

// js constructs json once user clicks "=" and sends request 
// => asp.net core deserialization -> c# object 
// => http handler gives data to director 
// => director calls calculator, gets result 
// => http handler returns obj answer 
// => serialization to json and sends back to browser

