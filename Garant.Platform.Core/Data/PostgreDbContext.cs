﻿using Garant.Platform.Models.Entities.Actions;
using Garant.Platform.Models.Entities.Add;
using Garant.Platform.Models.Entities.Blog;
using Garant.Platform.Models.Entities.Business;
using Garant.Platform.Models.Entities.Footer;
using Garant.Platform.Models.Entities.Franchise;
using Garant.Platform.Models.Entities.Header;
using Garant.Platform.Models.Entities.LastBuy;
using Garant.Platform.Models.Entities.Logger;
using Garant.Platform.Models.Entities.News;
using Garant.Platform.Models.Entities.Suggestion;
using Garant.Platform.Models.Entities.Transition;
using Garant.Platform.Models.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace Garant.Platform.Core.Data
{
    public class PostgreDbContext : DbContext
    {
        private readonly DbContextOptions<PostgreDbContext> _options;

        public PostgreDbContext(DbContextOptions<PostgreDbContext> options) : base(options)
        {
            _options = options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }

        /// <summary>
        /// Таблица пользователей.
        /// </summary>
        public DbSet<UserEntity> Users { get; set; }

        /// <summary>
        /// Таблица логов Logs.Logs.
        /// </summary>
        public DbSet<LoggerEntity> Logs { get; set; }

        /// <summary>
        /// Таблица хидера.
        /// </summary>
        public DbSet<HeaderEntity> Headers { get; set; }

        /// <summary>
        /// Таблица футера.
        /// </summary>
        public DbSet<FooterEntity> Footers { get; set; }

        /// <summary>
        /// Таблица информации пользователя Info.UsersInformation.
        /// </summary>
        public DbSet<UserInformationEntity> UsersInformation { get; set; }

        /// <summary>
        /// Таблица новостей Info.News.
        /// </summary>
        public DbSet<NewsEntity> News { get; set; }

        /// <summary>
        /// Таблица категорий Business.BusinessCategories.
        /// </summary>
        public DbSet<BusinessCategoryEntity> BusinessCategories { get; set; }

        /// <summary>
        /// Таблица последних покупок Commerce.LastBuy.
        /// </summary>
        public DbSet<LastBuyEntity> LastBuys { get; set; }

        /// <summary>
        /// Таблица событий на главной странице dbo.MainPageActions.
        /// </summary>
        public DbSet<MainPageActionEntity> MainPageActions { get; set; }

        /// <summary>
        /// Таблица предложений Info.Suggestions.
        /// </summary>
        public DbSet<SuggestionEntity> Suggestions { get; set; }

        /// <summary>
        /// Таблица популярных франшиз Franchises.PopularFranchises.
        /// </summary>
        public DbSet<PopularFranchiseEntity> PopularFranchises { get; set; }

        /// <summary>
        /// Таблица популярных франшиз Franchises.Franchises.
        /// </summary>
        public DbSet<FranchiseEntity> Franchises { get; set; }

        /// <summary>
        /// Таблица объявлений Info.Ads.
        /// </summary>
        public DbSet<AdEntity> Ads { get; set; }

        /// <summary>
        /// Таблица блогов Info.Blogs.
        /// </summary>
        public DbSet<BlogEntity> Blogs { get; set; }

        /// <summary>
        /// Таблица Franchises.FranchiseCities.
        /// </summary>
        public DbSet<FranchiseCityEntity> FranchiseCities { get; set; }

        /// <summary>
        /// Таблица Franchises.ViewBusiness.
        /// </summary>
        public DbSet<ViewBusinessEntity> ViewBusiness { get; set; }

        /// <summary>
        /// Таблица Franchises.FranchiseCategories.
        /// </summary>
        public DbSet<FranchiseCategoryEntity> FranchiseCategories { get; set; }

        /// <summary>
        /// Таблица dbo.Breadcrumbs.
        /// </summary>
        public DbSet<BreadcrumbEntity> Breadcrumbs { get; set; }

        /// <summary>
        /// Таблица Franchises.TempFranchises.
        /// </summary>
        public DbSet<TempFranchiseEntity> TempFranchises { get; set; }

        /// <summary>
        /// Таблица dbo.Transitions.
        /// </summary>
        public DbSet<TransitionEntity> Transitions { get; set; }

        /// <summary>
        /// Таблица Business.Businesses.
        /// </summary>
        public DbSet<BusinessEntity> Businesses { get; set; }

        /// <summary>
        /// Таблица Business.TempBusinesses.
        /// </summary>
        public DbSet<TempBusinessEntity> TempBusinesses { get; set; }

        /// <summary>
        /// Таблица Franchises.FranchiseSubCategories.
        /// </summary>
        public DbSet<FranchiseSubCategoryEntity> FranchiseSubCategories { get; set; }

        /// <summary>
        /// Таблица Business.BusinessSubCategories
        /// </summary>
        public DbSet<BusinessSubCategoryEntity> BusinessSubCategories { get; set; }

        /// <summary>
        /// Таблица Business.BusinessCities
        /// </summary>
        public DbSet<BusinessCitiesEntity> BusinessCities { get; set; }
    }
}
