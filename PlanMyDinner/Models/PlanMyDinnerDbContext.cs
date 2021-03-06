﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanMyDinner.Models
{
    /// <summary>
    /// This class is the database. As you would define all of your tables in a database,
    /// we define classes in the file - to be represented by tables by entity framework.
    /// Since Category, Context and Ingredient are only accessed directly from the Recipe I have not included it here as a DbSet - only through relations.
    /// The Category, Context and Ingredient classea will still be added as a database table automatically since it are used from within Recipe and
    /// I have defined the relations.
    /// </summary>
    public class PlanMyDinnerDbContext : DbContext //Your class must inherit from “DbContext” which will do all the work to create your database and give you access to it.
    {
        /// <summary>
        /// The string “PlanMyDinnerDbConnection” is the name of the connection string defined in the
        /// web.config file in the project (web.config is created by VS when you add Entity framework).
        /// If you don’t specify a name for connection string, Entity Framework will use
        /// the name of the class as the name of the connection string.
        /// </summary>
        public PlanMyDinnerDbContext() : base("PlanMyDinnerDbConnection") { }

        /// <summary>
        /// Configure relation between Recipe,  Category, Context and Ingredient.
        /// 
        /// See below for more information on how to configure this relation;
        ///     http://marisks.net/2015/05/20/handling-child-collections-in-entity-framework/
        ///     https://msdn.microsoft.com/en-us/data/jj591583.aspx#Composite
        ///     http://www.entityframeworktutorial.net/code-first/configure-one-to-many-relationship-in-code-first.aspx
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure foreign key relationship between Recipe and Category, Context and Ingredient.
            modelBuilder.Entity<Recipe>()
                .HasMany(o => o.Ingredients)
                .WithOptional()
                .HasForeignKey(oi => oi.RecipeId);
            /*
             * Not sure if this needed...
             * It seems to be working without this...
            modelBuilder.Entity<Recipe>()
                .HasMany(o => o.Categories)
                .WithOptional()
                .HasForeignKey(oi => oi.RecipeId);
            modelBuilder.Entity<Recipe>()
                .HasMany(o => o.Contexts)
                .WithOptional()
                .HasForeignKey(oi => oi.RecipeId);
            */
            //Define composite key for FileDetailsDb using anonymous object.
            //Configure Id column values to be auto-generated by database, because it does not generate those for composite keys.
            modelBuilder.Entity<Ingredient>()
                .HasKey(oi => new { oi.Id, oi.RecipeId })
                .Property(oi => oi.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            /*
             * Not sure if this needed...
             * It seems to be working without this...
            modelBuilder.Entity<Category>()
                .HasKey(oi => new { oi.Id, oi.RecipeId })
                .Property(oi => oi.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Context>()
                .HasKey(oi => new { oi.Id, oi.RecipeId })
                .Property(oi => oi.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
           */
        }

        /// <summary>
        /// Now each time the database is generated. It will be seeded with some default data.
        /// If you want to test it you must either change your model or you can delete the database
        /// (it will be regenerated on next run).
        /// This is very useful during development, the database gets recreated each time we change the model,
        /// but since we are seeding it we have some data in it for testing during development.
        /// 
        /// Use of static constructor:
        ///     https://stackoverflow.com/questions/20451554/whats-the-function-of-a-static-constructor-in-a-non-static-class
        /// </summary>
        static PlanMyDinnerDbContext()
        {
            //Put my seeding strategy/data in MovieDbContext,
            Database.SetInitializer<PlanMyDinnerDbContext>(new MySeedingStrategy());

            //Use migrations automatic upgrading for it to work on remote database/ddwap.
            //Database.SetInitializer<MovieDbContext>(new MigrateDatabaseToLatestVersion<MovieDbContext, Migrations.Configuration>());
        }

        public DbSet<Recipe> Recipes { get; set; }
    }
}