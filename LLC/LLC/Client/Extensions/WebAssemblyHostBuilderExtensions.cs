﻿using Blazored.LocalStorage;
using LLC.Client.Infrastructure.Authentication;
using LLC.Client.Infrastructure.Managers;
using LLC.Client.Infrastructure.Managers.Preferences;
using LLC.Shared.Constants.Permission;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor;
using MudBlazor.Services;
using System;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using Toolbelt.Blazor.Extensions.DependencyInjection;

namespace LLC.Client.Extensions
{
    public static class WebAssemblyHostBuilderExtensions
    {
        private const string ClientName = "LegalLeadCloser.API";

        public static WebAssemblyHostBuilder AddRootComponents(this WebAssemblyHostBuilder builder)
        {
            builder.RootComponents.Add<App>("#app");

            return builder;
        }

        public static WebAssemblyHostBuilder AddClientServices(this WebAssemblyHostBuilder builder)
        {
            builder
                .Services
                .AddLocalization(options =>
                {
                    options.ResourcesPath = "Resources";
                })
                .AddAuthorizationCore(options =>
                {
                    foreach (var permissionModule in PermissionModules.GetAllPermissionsModules())
                    {
                        RegisterPermissionClaimPolicyByModule(options, permissionModule);
                    }
                })
                .AddBlazoredLocalStorage()
                .AddMudServices(configuration =>
                {
                    configuration.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomRight;
                    configuration.SnackbarConfiguration.HideTransitionDuration = 100;
                    configuration.SnackbarConfiguration.ShowTransitionDuration = 100;
                    configuration.SnackbarConfiguration.VisibleStateDuration = 3000;
                    configuration.SnackbarConfiguration.ShowCloseIcon = false;
                })
                .AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies())
                .AddScoped<ClientPreferenceManager>()
                .AddScoped<BlazorHeroStateProvider>()
                .AddScoped<AuthenticationStateProvider, BlazorHeroStateProvider>()
                .AddManagers()
                .AddTransient<AuthenticationHeaderHandler>()
                .AddScoped(sp => sp
                    .GetRequiredService<IHttpClientFactory>()
                    .CreateClient(ClientName).EnableIntercept(sp))
                .AddHttpClient(ClientName, client =>
                {
                    client.DefaultRequestHeaders.AcceptLanguage.Clear();
                    client.DefaultRequestHeaders.AcceptLanguage.ParseAdd(CultureInfo.DefaultThreadCurrentCulture?.TwoLetterISOLanguageName);
                    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
                })
                .AddHttpMessageHandler<AuthenticationHeaderHandler>();
            builder.Services.AddHttpClientInterceptor();
            return builder;
        }

        public static IServiceCollection AddManagers(this IServiceCollection services)
        {
            var managers = typeof(IManager);

            var types = managers
                .Assembly
                .GetExportedTypes()
                .Where(t => t.IsClass && !t.IsAbstract)
                .Select(t => new
                {
                    Service = t.GetInterface($"I{t.Name}"),
                    Implementation = t
                })
                .Where(t => t.Service != null);

            foreach (var type in types)
            {
                if (managers.IsAssignableFrom(type.Service))
                {
                    services.AddTransient(type.Service, type.Implementation);
                }
            }

            return services;
        }

        private static void RegisterPermissionClaimPolicyByModule(AuthorizationOptions options, string module)
        {
            var allPermissions = PermissionModules.GeneratePermissionsForModule(module);
            foreach (var permission in allPermissions)
            {
                options.AddPolicy(permission, policy => policy.RequireClaim(ApplicationClaimTypes.Permission, permission));
            }
            //Test
            options.AddPolicy("Permissions.Communication.Chat", policy => policy.RequireClaim(ApplicationClaimTypes.Permission, "Permissions.Communication.Chat"));
        }
    }
}