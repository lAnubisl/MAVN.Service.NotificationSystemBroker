﻿// <auto-generated />
using System;
using Lykke.Service.NotificationSystemBroker.MsSqlRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lykke.Service.NotificationSystemBroker.MsSqlRepositories.Migrations
{
    [DbContext(typeof(NotificationSystemBrokerContext))]
    [Migration("20190611132511_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("notification_system_broker")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lykke.Service.NotificationSystemBroker.MsSqlRepositories.Entities.EmailMessageEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Body")
                        .HasColumnName("body");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasMaxLength(320);

                    b.Property<Guid>("MessageId")
                        .HasColumnName("message_id");

                    b.Property<string>("Subject")
                        .HasColumnName("subject")
                        .HasMaxLength(1000);

                    b.Property<DateTime>("Timestamp")
                        .HasColumnName("timestamp");

                    b.HasKey("Id");

                    b.ToTable("email_messages");
                });
#pragma warning restore 612, 618
        }
    }
}
