﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Garant.Platform.Core.Abstraction;
using Garant.Platform.Core.Data;
using Garant.Platform.Core.Logger;
using Garant.Platform.Models.Ad.Output;
using Microsoft.EntityFrameworkCore;

namespace Garant.Platform.Service.Service.Ad
{
    /// <summary>
    /// Сервис объявлений.
    /// </summary>
    public sealed class AdService : IAdService
    {
        private readonly PostgreDbContext _postgreDbContext;

        public AdService(PostgreDbContext postgreDbContext)
        {
            _postgreDbContext = postgreDbContext;
        }

        /// <summary>
        /// Метод получит список новых объявлений.
        /// </summary>
        /// <returns>Список объявлений.</returns>
        public async Task<IEnumerable<AdOutput>> GetNewAdsAsync()
        {
            try
            {
                var result = await (from a in _postgreDbContext.Ads
                                    orderby a.DateCreate
                                    select new AdOutput
                                    {
                                        CountDays = a.CountDays,
                                        DateCreate = a.DateCreate,
                                        DayDeclination = a.DayDeclination,
                                        Price = string.Format("{0:0,0}", a.Price),
                                        Text = a.Text,
                                        TextDoPrice = a.TextDoPrice,
                                        Title = a.Title,
                                        Url = a.Url
                                    })
                    .Reverse()
                    .Take(4)
                    .ToListAsync();

                return result;
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                var logger = new Logger(_postgreDbContext, e.GetType().FullName, e.Message, e.StackTrace);
                await logger.LogError();
                throw;
            }
        }
    }
}