﻿using MicroCMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroCMS.Infra.EntityConfig
{
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Title)
                .IsRequired()
                .HasColumnName("Title");

            builder.HasOne(u => u.User)
                .WithMany(p => p.Posts)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.PostCategory)
                .WithMany(p => p.Posts)
                .HasForeignKey(c => c.PostCategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
