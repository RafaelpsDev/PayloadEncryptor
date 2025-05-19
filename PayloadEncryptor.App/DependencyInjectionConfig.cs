using Microsoft.Extensions.DependencyInjection;
using PayloadEncryptor.Application.Factories;
using PayloadEncryptor.Application.Services;
using PayloadEncryptor.Domain.Interfaces.Application;
using PayloadEncryptor.Domain.Interfaces.Factories;
using PayloadEncryptor.Domain.Interfaces.Infrastructure.Services;
using PayloadEncryptor.Infrastructure.Services;

namespace PayloadEncryptor.App
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddPayloadEncryptorServices(this IServiceCollection services)
        {
            services.AddScoped<IDecodeService, DecodeService>();
            services.AddScoped<IDecryptService, DecryptService>();
            services.AddScoped<IEncryptService, EncryptService>();
            services.AddScoped<IInputReader, InputReader>();
            services.AddScoped<IEncryptionProcess, EncryptionProcess>();
            services.AddScoped<IMockJsonFactory, MockJsonFactory>();
            return services;
        }
    }
}
