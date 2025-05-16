using Microsoft.Extensions.DependencyInjection;
using PayloadEncryptor.Application.Services;
using PayloadEncryptor.Domain.Interfaces.Application;
using PayloadEncryptor.Domain.Interfaces.Infrastructure.Services;
using PayloadEncryptor.Infrastructure.Services;

var services = new ServiceCollection();
services.AddScoped<IDecodeService, DecodeService>();
services.AddScoped<IDecryptService, DecryptService>();
services.AddScoped<IEncryptService, EncryptService>();
services.AddScoped<IInputReader, InputReader>();
services.AddScoped<IEncryptionProcess, EncryptionProcess>();
var serviceProvider = services.BuildServiceProvider();

var encryptionProcess = serviceProvider.GetRequiredService<IEncryptionProcess>();

encryptionProcess.Execute();


