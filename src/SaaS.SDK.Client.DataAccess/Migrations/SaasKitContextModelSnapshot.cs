﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Marketplace.SaasKit.Client.DataAccess.Context;

namespace SaaS.SDK.Client.DataAccess.Migrations
{
    [DbContext(typeof(SaasKitContext))]
    partial class SaasKitContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.ApplicationConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApplicationConfiguration");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.ApplicationLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ActionTime")
                        .HasColumnType("datetime");

                    b.Property<string>("LogDetail")
                        .HasColumnType("varchar(4000)")
                        .HasMaxLength(4000)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("ApplicationLog");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.DatabaseVersionHistory", b =>
                {
                    b.Property<string>("ChangeLog")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("VersionNumber")
                        .HasColumnType("decimal(6, 2)");

                    b.ToTable("DatabaseVersionHistory");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.EmailTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bcc")
                        .HasColumnName("BCC")
                        .HasColumnType("varchar(1000)")
                        .HasMaxLength(1000)
                        .IsUnicode(false);

                    b.Property<string>("Cc")
                        .HasColumnName("CC")
                        .HasColumnType("varchar(1000)")
                        .HasMaxLength(1000)
                        .IsUnicode(false);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(1000)")
                        .HasMaxLength(1000)
                        .IsUnicode(false);

                    b.Property<DateTime?>("InsertDate")
                        .HasColumnType("datetime");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Status")
                        .HasColumnType("varchar(1000)")
                        .HasMaxLength(1000)
                        .IsUnicode(false);

                    b.Property<string>("Subject")
                        .HasColumnType("varchar(1000)")
                        .HasMaxLength(1000)
                        .IsUnicode(false);

                    b.Property<string>("TemplateBody")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("ToRecipients")
                        .HasColumnType("varchar(1000)")
                        .HasMaxLength(1000)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("EmailTemplate");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Events", b =>
                {
                    b.Property<int>("EventsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("EventsName")
                        .HasColumnType("varchar(225)")
                        .HasMaxLength(225)
                        .IsUnicode(false);

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("EventsId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.KnownUsers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserEmail")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("KnownUsers");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.MeteredAuditLogs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("RequestJson")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("ResponseJson")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("StatusCode")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int?>("SubscriptionId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SubscriptionUsageDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("MeteredAuditLogs");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.MeteredDimensions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<string>("Dimension")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<int?>("PlanId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlanId");

                    b.ToTable("MeteredDimensions");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.OfferAttributes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(225)")
                        .HasMaxLength(225)
                        .IsUnicode(false);

                    b.Property<string>("DisplayName")
                        .HasColumnType("varchar(225)")
                        .HasMaxLength(225)
                        .IsUnicode(false);

                    b.Property<int?>("DisplaySequence")
                        .HasColumnType("int");

                    b.Property<bool>("FromList")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsRequired")
                        .HasColumnType("bit");

                    b.Property<bool>("Isactive")
                        .HasColumnType("bit");

                    b.Property<int?>("Max")
                        .HasColumnType("int");

                    b.Property<int?>("Min")
                        .HasColumnType("int");

                    b.Property<Guid>("OfferId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ParameterId")
                        .HasColumnType("varchar(225)")
                        .HasMaxLength(225)
                        .IsUnicode(false);

                    b.Property<string>("Type")
                        .HasColumnType("varchar(225)")
                        .HasMaxLength(225)
                        .IsUnicode(false);

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("ValueTypeId")
                        .HasColumnType("int");

                    b.Property<string>("ValuesList")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("OfferAttributes");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Offers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<Guid>("OfferGuid")
                        .HasColumnName("OfferGUId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OfferId")
                        .HasColumnType("varchar(225)")
                        .HasMaxLength(225)
                        .IsUnicode(false);

                    b.Property<string>("OfferName")
                        .HasColumnType("varchar(225)")
                        .HasMaxLength(225)
                        .IsUnicode(false);

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.PlanAttributeMapping", b =>
                {
                    b.Property<int>("PlanAttributeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<int>("OfferAttributeId")
                        .HasColumnName("OfferAttributeID")
                        .HasColumnType("int");

                    b.Property<Guid>("PlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PlanAttributeId")
                        .HasName("PK__PlanAttr__8B476A98C058FAF2");

                    b.ToTable("PlanAttributeMapping");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.PlanAttributeOutput", b =>
                {
                    b.Property<int>("RowNumber")
                        .HasColumnType("int");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("varchar(225)")
                        .HasMaxLength(225)
                        .IsUnicode(false);

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<int>("OfferAttributeId")
                        .HasColumnType("int");

                    b.Property<int>("PlanAttributeId")
                        .HasColumnType("int");

                    b.Property<Guid>("PlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .HasColumnType("varchar(225)")
                        .HasMaxLength(225)
                        .IsUnicode(false);

                    b.HasKey("RowNumber")
                        .HasName("PK__PlanAttr__AAAC09D888FE3E40");

                    b.ToTable("PlanAttributeOutput");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.PlanEventsMapping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("CopyToCustomer")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("FailureStateEmails")
                        .HasColumnType("varchar(225)")
                        .HasMaxLength(225)
                        .IsUnicode(false);

                    b.Property<bool>("Isactive")
                        .HasColumnType("bit");

                    b.Property<Guid>("PlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SuccessStateEmails")
                        .HasColumnType("varchar(225)")
                        .HasMaxLength(225)
                        .IsUnicode(false);

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PlanEventsMapping");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.PlanEventsOutPut", b =>
                {
                    b.Property<int>("RowNumber")
                        .HasColumnType("int");

                    b.Property<bool?>("CopyToCustomer")
                        .HasColumnType("bit");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("EventsName")
                        .IsRequired()
                        .HasColumnType("varchar(225)")
                        .HasMaxLength(225)
                        .IsUnicode(false);

                    b.Property<string>("FailureStateEmails")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<int>("Id")
                        .HasColumnName("ID")
                        .HasColumnType("int");

                    b.Property<bool>("Isactive")
                        .HasColumnType("bit");

                    b.Property<Guid>("PlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SuccessStateEmails")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.HasKey("RowNumber")
                        .HasName("PK__PlanEven__AAAC09D8C9229532");

                    b.ToTable("PlanEventsOutPut");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Plans", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("DisplayName")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<bool?>("IsPerUser")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsmeteringSupported")
                        .HasColumnType("bit");

                    b.Property<Guid>("OfferId")
                        .HasColumnName("OfferID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlanGuid")
                        .HasColumnName("PlanGUID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PlanId")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Plans");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.SubscriptionAttributeValues", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<Guid>("OfferId")
                        .HasColumnName("OfferID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PlanAttributeId")
                        .HasColumnType("int");

                    b.Property<Guid>("PlanId")
                        .HasColumnName("PlanID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubscriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("varchar(225)")
                        .HasMaxLength(225)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("SubscriptionAttributeValues");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.SubscriptionAuditLogs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Attribute")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<int?>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("NewValue")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("OldValue")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int?>("SubscriptionId")
                        .HasColumnName("SubscriptionID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("SubscriptionAuditLogs");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.SubscriptionEmailOutput", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("varchar(225)")
                        .HasMaxLength(225)
                        .IsUnicode(false);

                    b.Property<string>("Value")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.ToTable("SubscriptionEmailOutput");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.SubscriptionParametersOutput", b =>
                {
                    b.Property<int>("RowNumber")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("varchar(225)")
                        .HasMaxLength(225)
                        .IsUnicode(false);

                    b.Property<int>("DisplaySequence")
                        .HasColumnType("int");

                    b.Property<bool>("FromList")
                        .HasColumnType("bit");

                    b.Property<string>("Htmltype")
                        .IsRequired()
                        .HasColumnName("HTMLType")
                        .HasColumnType("varchar(225)")
                        .HasMaxLength(225)
                        .IsUnicode(false);

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsRequired")
                        .HasColumnType("bit");

                    b.Property<int>("Max")
                        .HasColumnType("int");

                    b.Property<int>("Min")
                        .HasColumnType("int");

                    b.Property<int>("OfferAttributeId")
                        .HasColumnName("OfferAttributeID")
                        .HasColumnType("int");

                    b.Property<Guid>("OfferId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PlanAttributeId")
                        .HasColumnType("int");

                    b.Property<Guid>("PlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubscriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(225)")
                        .HasMaxLength(225)
                        .IsUnicode(false);

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("ValueType")
                        .IsRequired()
                        .HasColumnType("varchar(225)")
                        .HasMaxLength(225)
                        .IsUnicode(false);

                    b.Property<string>("ValuesList")
                        .IsRequired()
                        .HasColumnType("varchar(225)")
                        .HasMaxLength(225)
                        .IsUnicode(false);

                    b.HasKey("RowNumber")
                        .HasName("PK__Subscrip__AAAC09D8BA727059");

                    b.ToTable("SubscriptionParametersOutput");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Subscriptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AmpplanId")
                        .HasColumnName("AMPPlanId")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int>("Ampquantity")
                        .HasColumnName("AMPQuantity")
                        .HasColumnType("int");

                    b.Property<Guid>("AmpsubscriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AMPSubscriptionId")
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<int?>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("PurchaserEmail")
                        .HasColumnType("varchar(225)")
                        .HasMaxLength(225)
                        .IsUnicode(false);

                    b.Property<Guid?>("PurchaserTenantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SubscriptionStatus")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("FullName")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.ValueTypes", b =>
                {
                    b.Property<int>("ValueTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Htmltype")
                        .HasColumnName("HTMLType")
                        .HasColumnType("varchar(225)")
                        .HasMaxLength(225)
                        .IsUnicode(false);

                    b.Property<string>("ValueType")
                        .HasColumnType("varchar(225)")
                        .HasMaxLength(225)
                        .IsUnicode(false);

                    b.HasKey("ValueTypeId")
                        .HasName("PK__ValueTyp__A51E9C5AEA096123");

                    b.ToTable("ValueTypes");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.WebJobSubscriptionStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<DateTime?>("InsertDate")
                        .HasColumnType("datetime");

                    b.Property<Guid?>("SubscriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SubscriptionStatus")
                        .HasColumnType("varchar(225)")
                        .HasMaxLength(225)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("WebJobSubscriptionStatus");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.KnownUsers", b =>
                {
                    b.HasOne("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Roles", "Role")
                        .WithMany("KnownUsers")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK__KnownUser__RoleI__619B8048")
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.MeteredAuditLogs", b =>
                {
                    b.HasOne("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Subscriptions", "Subscription")
                        .WithMany("MeteredAuditLogs")
                        .HasForeignKey("SubscriptionId")
                        .HasConstraintName("FK__MeteredAu__Subsc__628FA481");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.MeteredDimensions", b =>
                {
                    b.HasOne("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Plans", "Plan")
                        .WithMany("MeteredDimensions")
                        .HasForeignKey("PlanId")
                        .HasConstraintName("FK__MeteredDi__PlanI__6383C8BA");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.SubscriptionAuditLogs", b =>
                {
                    b.HasOne("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Subscriptions", "Subscription")
                        .WithMany("SubscriptionAuditLogs")
                        .HasForeignKey("SubscriptionId")
                        .HasConstraintName("FK__Subscript__Subsc__6477ECF3");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Subscriptions", b =>
                {
                    b.HasOne("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Users", "User")
                        .WithMany("Subscriptions")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Subscript__UserI__656C112C");
                });
#pragma warning restore 612, 618
        }
    }
}
