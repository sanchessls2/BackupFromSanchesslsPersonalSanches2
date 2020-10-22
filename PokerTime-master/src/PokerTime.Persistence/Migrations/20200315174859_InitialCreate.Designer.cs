﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PokerTime.Persistence;

namespace PokerTime.Persistence.Migrations
{
    [DbContext(typeof(PokerTimeDbContext))]
    [Migration("20200315174859_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PokerTime.Domain.Entities.Estimation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ParticipantId")
                        .HasColumnType("int");

                    b.Property<int?>("SymbolId")
                        .HasColumnType("int");

                    b.Property<int>("UserStoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParticipantId");

                    b.HasIndex("SymbolId");

                    b.HasIndex("UserStoryId");

                    b.ToTable("Estimation");
                });

            modelBuilder.Entity("PokerTime.Domain.Entities.Participant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsFacilitator")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<int>("SessionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SessionId");

                    b.ToTable("Participant");
                });

            modelBuilder.Entity("PokerTime.Domain.Entities.PredefinedParticipantColor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("PredefinedParticipantColor");
                });

            modelBuilder.Entity("PokerTime.Domain.Entities.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("CreationTimestamp")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CurrentStage")
                        .HasColumnType("int");

                    b.Property<string>("FacilitatorHashedPassphrase")
                        .IsRequired()
                        .HasColumnType("char(64)")
                        .IsFixedLength(true)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    b.Property<string>("HashedPassphrase")
                        .HasColumnType("char(64)")
                        .IsFixedLength(true)
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("Session");
                });

            modelBuilder.Entity("PokerTime.Domain.Entities.Symbol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("ValueAsNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Symbol");
                });

            modelBuilder.Entity("PokerTime.Domain.Entities.UserStory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SessionId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SessionId");

                    b.ToTable("UserStory");
                });

            modelBuilder.Entity("PokerTime.Domain.Entities.Estimation", b =>
                {
                    b.HasOne("PokerTime.Domain.Entities.Participant", "Participant")
                        .WithMany()
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PokerTime.Domain.Entities.Symbol", "Symbol")
                        .WithMany()
                        .HasForeignKey("SymbolId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PokerTime.Domain.Entities.UserStory", "UserStory")
                        .WithMany("Estimations")
                        .HasForeignKey("UserStoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PokerTime.Domain.Entities.Participant", b =>
                {
                    b.HasOne("PokerTime.Domain.Entities.Session", "Session")
                        .WithMany("Participants")
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("PokerTime.Domain.ValueObjects.ParticipantColor", "Color", b1 =>
                        {
                            b1.Property<int>("ParticipantId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<byte>("B")
                                .HasColumnType("tinyint");

                            b1.Property<byte>("G")
                                .HasColumnType("tinyint");

                            b1.Property<byte>("R")
                                .HasColumnType("tinyint");

                            b1.HasKey("ParticipantId");

                            b1.ToTable("Participant");

                            b1.WithOwner()
                                .HasForeignKey("ParticipantId");
                        });
                });

            modelBuilder.Entity("PokerTime.Domain.Entities.PredefinedParticipantColor", b =>
                {
                    b.OwnsOne("PokerTime.Domain.ValueObjects.ParticipantColor", "Color", b1 =>
                        {
                            b1.Property<int>("PredefinedParticipantColorId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<byte>("B")
                                .HasColumnType("tinyint");

                            b1.Property<byte>("G")
                                .HasColumnType("tinyint");

                            b1.Property<byte>("R")
                                .HasColumnType("tinyint");

                            b1.HasKey("PredefinedParticipantColorId");

                            b1.ToTable("PredefinedParticipantColor");

                            b1.WithOwner()
                                .HasForeignKey("PredefinedParticipantColorId");
                        });
                });

            modelBuilder.Entity("PokerTime.Domain.Entities.Session", b =>
                {
                    b.OwnsOne("PokerTime.Domain.ValueObjects.SessionIdentifier", "UrlId", b1 =>
                        {
                            b1.Property<int>("SessionId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("StringId")
                                .IsRequired()
                                .HasColumnType("varchar(32)")
                                .HasMaxLength(32)
                                .IsUnicode(false);

                            b1.HasKey("SessionId");

                            b1.HasIndex("StringId")
                                .IsUnique()
                                .HasFilter("[UrlId_StringId] IS NOT NULL");

                            b1.ToTable("Session");

                            b1.WithOwner()
                                .HasForeignKey("SessionId");
                        });
                });

            modelBuilder.Entity("PokerTime.Domain.Entities.UserStory", b =>
                {
                    b.HasOne("PokerTime.Domain.Entities.Session", "Session")
                        .WithMany()
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
