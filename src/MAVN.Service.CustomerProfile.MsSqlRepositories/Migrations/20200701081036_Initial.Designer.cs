﻿// <auto-generated />
using System;
using MAVN.Service.CustomerProfile.MsSqlRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MAVN.Service.CustomerProfile.MsSqlRepositories.Migrations
{
    [DbContext(typeof(CustomerProfileContext))]
    [Migration("20200701081036_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("customer_profile")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("MAVN.Service.CustomerProfile.MsSqlRepositories.Entities.AdminProfileArchiveEntity", b =>
                {
                    b.Property<Guid>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("admin_id")
                        .HasColumnType("uuid");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnName("company")
                        .HasColumnType("text");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnName("department")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("first_name")
                        .HasColumnType("text");

                    b.Property<bool>("IsEmailVerified")
                        .HasColumnName("email_verified")
                        .HasColumnType("boolean");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnName("job_title")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnName("phone_number")
                        .HasColumnType("text");

                    b.Property<bool>("WasEmailEverVerified")
                        .HasColumnName("was_email_ever_verified")
                        .HasColumnType("boolean");

                    b.HasKey("AdminId");

                    b.ToTable("admin_profiles_archive");
                });

            modelBuilder.Entity("MAVN.Service.CustomerProfile.MsSqlRepositories.Entities.AdminProfileEntity", b =>
                {
                    b.Property<Guid>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("admin_id")
                        .HasColumnType("uuid");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnName("company")
                        .HasColumnType("text");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnName("department")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("first_name")
                        .HasColumnType("text");

                    b.Property<bool>("IsEmailVerified")
                        .HasColumnName("email_verified")
                        .HasColumnType("boolean");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnName("job_title")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnName("phone_number")
                        .HasColumnType("text");

                    b.Property<bool>("WasEmailEverVerified")
                        .HasColumnName("was_email_ever_verified")
                        .HasColumnType("boolean");

                    b.HasKey("AdminId");

                    b.HasIndex("Email");

                    b.ToTable("admin_profiles");
                });

            modelBuilder.Entity("MAVN.Service.CustomerProfile.MsSqlRepositories.Entities.CustomerProfileArchiveEntity", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnName("customer_id")
                        .HasColumnType("text");

                    b.Property<int?>("CountryOfNationalityId")
                        .HasColumnName("country_of_nationality_id")
                        .HasColumnType("integer");

                    b.Property<int?>("CountryOfResidenceId")
                        .HasColumnName("country_of_residence_id")
                        .HasColumnType("integer");

                    b.Property<int?>("CountryPhoneCodeId")
                        .HasColumnName("country_phone_code_id")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnName("first_name")
                        .HasColumnType("text");

                    b.Property<bool>("IsEmailVerified")
                        .HasColumnName("email_verified")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPhoneVerified")
                        .HasColumnName("phone_verified")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnName("last_name")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("phone_number")
                        .HasColumnType("text");

                    b.Property<DateTime>("Registered")
                        .HasColumnName("registered_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ShortPhoneNumber")
                        .HasColumnName("short_phone_number")
                        .HasColumnType("text");

                    b.Property<string>("TierId")
                        .HasColumnName("tier_id")
                        .HasColumnType("text");

                    b.Property<bool>("WasPhoneEverVerified")
                        .HasColumnName("was_phone_ever_verified")
                        .HasColumnType("boolean");

                    b.HasKey("CustomerId");

                    b.HasIndex("Email");

                    b.ToTable("customer_profile_archive");
                });

            modelBuilder.Entity("MAVN.Service.CustomerProfile.MsSqlRepositories.Entities.CustomerProfileEntity", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnName("customer_id")
                        .HasColumnType("text");

                    b.Property<int?>("CountryOfNationalityId")
                        .HasColumnName("country_of_nationality_id")
                        .HasColumnType("integer");

                    b.Property<int?>("CountryOfResidenceId")
                        .HasColumnName("country_of_residence_id")
                        .HasColumnType("integer");

                    b.Property<int?>("CountryPhoneCodeId")
                        .HasColumnName("country_phone_code_id")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnName("first_name")
                        .HasColumnType("text");

                    b.Property<bool>("IsEmailVerified")
                        .HasColumnName("email_verified")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPhoneVerified")
                        .HasColumnName("phone_verified")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnName("last_name")
                        .HasColumnType("text");

                    b.Property<string>("LowerCasedEmail")
                        .IsRequired()
                        .HasColumnName("lower_cased_email")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("phone_number")
                        .HasColumnType("text");

                    b.Property<DateTime>("Registered")
                        .HasColumnName("registered_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ShortPhoneNumber")
                        .HasColumnName("short_phone_number")
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TierId")
                        .HasColumnName("tier_id")
                        .HasColumnType("text");

                    b.Property<bool>("WasEmailEverVerified")
                        .HasColumnName("was_email_ever_verified")
                        .HasColumnType("boolean");

                    b.Property<bool>("WasPhoneEverVerified")
                        .HasColumnName("was_phone_ever_verified")
                        .HasColumnType("boolean");

                    b.HasKey("CustomerId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("LowerCasedEmail")
                        .IsUnique();

                    b.HasIndex("Status");

                    b.ToTable("customer_profile");
                });

            modelBuilder.Entity("MAVN.Service.CustomerProfile.MsSqlRepositories.Entities.LoginProviderEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnName("customer_id")
                        .HasColumnType("text");

                    b.Property<int>("LoginProvider")
                        .HasColumnName("login_provider")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("login_providers");
                });

            modelBuilder.Entity("MAVN.Service.CustomerProfile.MsSqlRepositories.Entities.PartnerContactArchiveEntity", b =>
                {
                    b.Property<string>("LocationId")
                        .HasColumnName("location_id")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnName("first_name")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnName("last_name")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("phone_number")
                        .HasColumnType("text");

                    b.HasKey("LocationId");

                    b.ToTable("partner_contact_archive");
                });

            modelBuilder.Entity("MAVN.Service.CustomerProfile.MsSqlRepositories.Entities.PartnerContactEntity", b =>
                {
                    b.Property<string>("LocationId")
                        .HasColumnName("location_id")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnName("first_name")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnName("last_name")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("phone_number")
                        .HasColumnType("text");

                    b.HasKey("LocationId");

                    b.HasIndex("Email");

                    b.HasIndex("PhoneNumber");

                    b.ToTable("partner_contact");
                });

            modelBuilder.Entity("MAVN.Service.CustomerProfile.MsSqlRepositories.Entities.PaymentProviderDetailsEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PartnerId")
                        .HasColumnName("partner_id")
                        .HasColumnType("uuid");

                    b.Property<string>("PaymentIntegrationProperties")
                        .IsRequired()
                        .HasColumnName("payment_integration_properties")
                        .HasColumnType("text");

                    b.Property<string>("PaymentIntegrationProvider")
                        .IsRequired()
                        .HasColumnName("payment_integration_provider")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PartnerId");

                    b.HasIndex("PartnerId", "PaymentIntegrationProvider")
                        .IsUnique();

                    b.ToTable("payment_provider_details");
                });

            modelBuilder.Entity("MAVN.Service.CustomerProfile.MsSqlRepositories.Entities.ReferralFriendProfileArchiveEntity", b =>
                {
                    b.Property<Guid>("ReferralFriendId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("referral_friend_id")
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnName("full_name")
                        .HasColumnType("text");

                    b.Property<Guid>("ReferrerId")
                        .HasColumnName("referrer_id")
                        .HasColumnType("uuid");

                    b.HasKey("ReferralFriendId");

                    b.ToTable("referral_friend_profiles_archive");
                });

            modelBuilder.Entity("MAVN.Service.CustomerProfile.MsSqlRepositories.Entities.ReferralFriendProfileEntity", b =>
                {
                    b.Property<Guid>("ReferralFriendId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("referral_friend_id")
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnName("full_name")
                        .HasColumnType("text");

                    b.Property<Guid>("ReferrerId")
                        .HasColumnName("referrer_id")
                        .HasColumnType("uuid");

                    b.HasKey("ReferralFriendId");

                    b.HasIndex("Email");

                    b.HasIndex("ReferrerId");

                    b.ToTable("referral_friend_profiles");
                });

            modelBuilder.Entity("MAVN.Service.CustomerProfile.MsSqlRepositories.Entities.ReferralHotelProfileArchiveEntity", b =>
                {
                    b.Property<Guid>("ReferralHotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("referral_hotel_id")
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("text");

                    b.HasKey("ReferralHotelId");

                    b.ToTable("referral_hotel_profiles_archive");
                });

            modelBuilder.Entity("MAVN.Service.CustomerProfile.MsSqlRepositories.Entities.ReferralHotelProfileEntity", b =>
                {
                    b.Property<Guid>("ReferralHotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("referral_hotel_id")
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnName("phone_number")
                        .HasColumnType("text");

                    b.HasKey("ReferralHotelId");

                    b.HasIndex("Email");

                    b.ToTable("referral_hotel_profiles");
                });

            modelBuilder.Entity("MAVN.Service.CustomerProfile.MsSqlRepositories.Entities.ReferralLeadProfileArchiveEntity", b =>
                {
                    b.Property<Guid>("ReferralLeadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("referral_lead_id")
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("first_name")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasColumnType("text");

                    b.Property<string>("Note")
                        .HasColumnName("note")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnName("phone_number")
                        .HasColumnType("text");

                    b.HasKey("ReferralLeadId");

                    b.ToTable("referral_lead_profiles_archive");
                });

            modelBuilder.Entity("MAVN.Service.CustomerProfile.MsSqlRepositories.Entities.ReferralLeadProfileEntity", b =>
                {
                    b.Property<Guid>("ReferralLeadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("referral_lead_id")
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("first_name")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasColumnType("text");

                    b.Property<string>("Note")
                        .HasColumnName("note")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnName("phone_number")
                        .HasColumnType("text");

                    b.HasKey("ReferralLeadId");

                    b.HasIndex("Email");

                    b.HasIndex("PhoneNumber");

                    b.ToTable("referral_lead_profiles");
                });

            modelBuilder.Entity("MAVN.Service.CustomerProfile.MsSqlRepositories.Entities.LoginProviderEntity", b =>
                {
                    b.HasOne("MAVN.Service.CustomerProfile.MsSqlRepositories.Entities.CustomerProfileEntity", "CustomerProfile")
                        .WithMany("LoginProviders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}