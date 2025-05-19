using Microsoft.Extensions.DependencyInjection;
using PayloadEncryptor.App;
using PayloadEncryptor.Domain.Interfaces.Application;

var services = new ServiceCollection();
services.AddPayloadEncryptorServices();

var serviceProvider = services.BuildServiceProvider();

var encryptionProcess = serviceProvider.GetRequiredService<IEncryptionProcess>();

encryptionProcess.Execute();


