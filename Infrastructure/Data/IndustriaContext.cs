using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class IndustriaContext : DbContext{
    public IndustriaContext(DbContextOptions<IndustriaContext> options): base(options){

    }

    DbSet<User> ? User {get;set;}


}