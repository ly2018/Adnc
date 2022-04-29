﻿global using Adnc.Infra.Core.Configuration;
global using Adnc.Infra.Core.Interfaces;
global using Adnc.Infra.Core.Json;
global using Adnc.Infra.Helper;
global using Adnc.Shared.Application.Contracts.ResultModels;
global using Adnc.Shared.RpcServices.Services;
global using Adnc.Shared.WebApi;
global using Adnc.Shared.WebApi.Extensions;
global using Adnc.Shared.WebApi.Middleware;
global using FluentValidation.AspNetCore;
global using HealthChecks.UI.Client;
global using LiteX.HealthChecks.Redis;
global using MicroElements.Swashbuckle.FluentValidation.AspNetCore;
global using Microsoft.AspNetCore.Authentication;
global using Microsoft.AspNetCore.Authentication.Basic;
global using Microsoft.AspNetCore.Authentication.Hybrid;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Diagnostics.HealthChecks;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Mvc.Filters;
global using Microsoft.AspNetCore.Mvc.ModelBinding;
global using Microsoft.AspNetCore.Routing;
global using Microsoft.Extensions.Caching.Memory;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using Microsoft.IdentityModel.Logging;
global using Microsoft.IdentityModel.Tokens;
global using Microsoft.OpenApi.Models;
global using MongoDB.Driver;
global using System;
global using System.Collections.Generic;
global using System.IdentityModel.Tokens.Jwt;
global using System.IO;
global using System.Linq;
global using System.Net;
global using System.Reflection;
global using System.Security.Claims;
global using System.Text;
global using System.Text.Json;
global using System.Threading;
global using System.Threading.Tasks;