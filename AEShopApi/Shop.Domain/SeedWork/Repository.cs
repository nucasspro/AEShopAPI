using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Shop.Domain.SeedWork
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        //public AeDbContext DbContext;
        //public DbSet<T> DbSet;
        //public IConfiguration Configuration;
        //public IUnitOfWork UnitOfWork;

        //public Repository(AeDbContext context, IConfiguration configuration, IUnitOfWork unitOfWork)
        //{
        //    DbContext = context;
        //    Configuration = configuration;
        //    DbSet = context.Set<T>();
        //    UnitOfWork = unitOfWork;
        //}
        public AeDbContext Context;
        public DbSet<T> DbSet;
        public IDbConnection Connection;

        public Repository(AeDbContext context)
        {
            Context = context;
            DbSet = context.Set<T>();
            Connection = context.Database.GetDbConnection();
        }

        public virtual void Insert(T entity)
        {
            DbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            DbSet.Update(entity);
        }

        public virtual void Delete(T entity)
        {
            DbSet.Remove(entity);
        }
    }
}
