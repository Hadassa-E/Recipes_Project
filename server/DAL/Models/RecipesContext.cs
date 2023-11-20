using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class RecipesContext : DbContext
{
    public RecipesContext()
    {
    }

    public RecipesContext(DbContextOptions<RecipesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ing> Ings { get; set; }

    public virtual DbSet<IngToRecipe> IngToRecipes { get; set; }

    public virtual DbSet<Recipe> Recipes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=Recipes;Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ing>(entity =>
        {
            entity.ToTable("Ing");

            entity.Property(e => e.IngId).HasColumnName("ingId");
            entity.Property(e => e.IngName)
                .HasMaxLength(20)
                .HasColumnName("ingName");
        });

        modelBuilder.Entity<IngToRecipe>(entity =>
        {
            entity.ToTable("IngToRecipe");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IngId).HasColumnName("ingId");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.RecipeId).HasColumnName("recipeId");

            entity.HasOne(d => d.Ing).WithMany(p => p.IngToRecipes)
                .HasForeignKey(d => d.IngId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ingToRecipe_Ing");

            entity.HasOne(d => d.Recipe).WithMany(p => p.IngToRecipes)
                .HasForeignKey(d => d.RecipeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ingToRecipe_Recipes");
        });

        modelBuilder.Entity<Recipe>(entity =>
        {
            entity.Property(e => e.RecipeId).HasColumnName("recipeId");
            entity.Property(e => e.Level)
                .HasMaxLength(10)
                .HasColumnName("level");
            entity.Property(e => e.Pic)
                .HasMaxLength(50)
                .HasColumnName("pic");
            entity.Property(e => e.RecipeName)
                .HasMaxLength(20)
                .HasColumnName("recipeName");
            entity.Property(e => e.Time).HasColumnName("time");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Recipes_Users");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.Email)
                .HasMaxLength(20)
                .HasColumnName("email");
            entity.Property(e => e.FirstName).HasMaxLength(10);
            entity.Property(e => e.LastName).HasMaxLength(20);
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
