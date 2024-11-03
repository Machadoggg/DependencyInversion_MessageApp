using Microsoft.Extensions.DependencyInjection;
using MessageApp.Core.Services;
using MessageApp.Infrastructure.Services;


// Configuración de inyección de dependencias
var serviceProvider = new ServiceCollection()
    .AddTransient<IMessageSender, EmailSender>()
    .BuildServiceProvider();

var serviceProvider2 = new ServiceCollection()
    .AddTransient<IMessageSender, SmsSender>()
    .BuildServiceProvider();

// Resolviendo la dependencia EmailSender
var messageSender = serviceProvider.GetService<IMessageSender>();
messageSender!.SendMessage("Hola, este es un mensaje de prueba!");

// Resolviendo la dependencia SmsSender
var messageSender2 = serviceProvider2.GetService<IMessageSender>();
messageSender2!.SendMessage("Hola, este es un mensaje de prueba!");

Console.WriteLine();