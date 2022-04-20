﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sectors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AuthorizationsRoles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorizationsRoles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BankInformations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    BankID = table.Column<int>(type: "int", nullable: false),
                    Ttile = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    HesapNo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Sube = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SubeNo = table.Column<int>(type: "int", nullable: true),
                    IBAN = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankInformations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    BankDescirption = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Birims",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Short = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birims", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CollectionReceipts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    CurrencyID = table.Column<int>(type: "int", nullable: false),
                    CurrencyExchange = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentTypeID = table.Column<int>(type: "int", nullable: false),
                    Taksit = table.Column<short>(type: "smallint", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KartinUstundekiIsım = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    NameSurname = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectionReceipts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CollectionReceipts_Currencies",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CustomerAddresses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    AddressName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Il = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ilce = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeliveryAddress = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddresses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerBillingAddresses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    AddressName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VergiNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VergiDairesi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BillingAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBillingAddresses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerContacts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactSurname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GSM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerContacts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CurrencyID = table.Column<int>(type: "int", nullable: false),
                    SideSuppliers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CustomerDetails_Currencies",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CustomerRepresentetiveUsers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerRepresentetiveUsers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TicariUnvan = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SectorID = table.Column<int>(type: "int", nullable: true),
                    CariKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SegmentID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    TypeID = table.Column<int>(type: "int", nullable: false),
                    LastContactDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Customers_CustomerTypes",
                        column: x => x.TypeID,
                        principalTable: "CustomerTypes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Customers_Sectors",
                        column: x => x.SectorID,
                        principalTable: "Sectors",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DepartmentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentsOfUsers",
                columns: table => new
                {
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    IsResponsible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentsOfUsers", x => new { x.UserID, x.DepartmentID });
                    table.ForeignKey(
                        name: "FK_DepartmentsOfUsers_Departments",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DepositRelations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositRelations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Deposits",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DepositRelationID = table.Column<int>(type: "int", nullable: false),
                    DepositTypeID = table.Column<int>(type: "int", nullable: false),
                    KurumAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IlgiliKisi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VerilisTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    CurrencyID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BitisSuresi = table.Column<DateTime>(type: "datetime", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deposits", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Deposits_Currencies",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Deposits_DepositRelations",
                        column: x => x.DepositRelationID,
                        principalTable: "DepositRelations",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DepositTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DiscountCupons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CuponCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CuponCurrencyID = table.Column<int>(type: "int", nullable: false),
                    DiscountAmountMoney = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CuponName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CuponDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountCupons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DiscountCupons_Currencies",
                        column: x => x.CuponCurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DiscountCuponsOfCustomers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    DiscountCuponID = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeginDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ExpryDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountCuponsOfCustomers", x => new { x.CustomerID, x.DiscountCuponID });
                    table.ForeignKey(
                        name: "FK_DiscountCuponsOfCustomers_Customers",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DiscountCuponsOfCustomers_DiscountCupons",
                        column: x => x.DiscountCuponID,
                        principalTable: "DiscountCupons",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DocumentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentDownloadPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Documents_DocumentTypes",
                        column: x => x.TypeID,
                        principalTable: "DocumentTypes",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "EmailTemplates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentID = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTemplates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EmailTemplates_Departments",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Expansions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ShortCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expansions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceBills",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    SellingRepresentetiveUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomerRepresentetiveUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductGroupID = table.Column<int>(type: "int", nullable: false),
                    MaintenencePeriodID = table.Column<int>(type: "int", nullable: false),
                    MainteneceTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    SozlesmeBedeli = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyID = table.Column<int>(type: "int", nullable: false),
                    SozlesmeBaslangicTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    SozlesmeBitisTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceBills", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MaintenanceBills_Currencies",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_MaintenanceBills_Customers",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "MaintenencePeriods",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenencePeriods", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MarketPlaces",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    MarketPlaceName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    MarketPlaceDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketPlaces", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MarketPlacesOfSuppliers",
                columns: table => new
                {
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    MarketPlaceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketPlacesOfSuppliers", x => new { x.SupplierID, x.MarketPlaceID });
                    table.ForeignKey(
                        name: "FK_MarketPlacesOfSuppliers_MarketPlaces",
                        column: x => x.MarketPlaceID,
                        principalTable: "MarketPlaces",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "OrderAndProductStates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderAndProductStates", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    OrderStateID = table.Column<int>(type: "int", nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsFrequentlyUsed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Orders_OrderStates",
                        column: x => x.OrderStateID,
                        principalTable: "OrderAndProductStates",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "OrdersCurrencies",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    CurrencyID = table.Column<int>(type: "int", nullable: false),
                    ExchangeRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersCurrencies", x => new { x.OrderID, x.CurrencyID });
                    table.ForeignKey(
                        name: "FK_OrdersCurrencies_Currencies",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrdersCurrencies_Orders",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "OrdersProducts",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    ReferanceCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ProductStateID = table.Column<int>(type: "int", nullable: false),
                    KesinCurrencyID = table.Column<int>(type: "int", nullable: true),
                    ReferansCurrencyID = table.Column<int>(type: "int", nullable: true),
                    Adet = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    KesinFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BirimFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BirimID = table.Column<int>(type: "int", nullable: false),
                    ReferansBirimFiyat = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KesinSupplierID = table.Column<int>(type: "int", nullable: true),
                    ReferansSupplierID = table.Column<int>(type: "int", nullable: false),
                    AbonelikBaslangic = table.Column<DateTime>(type: "datetime", nullable: true),
                    AbonelikBitis = table.Column<DateTime>(type: "datetime", nullable: true),
                    KesinSevkTarihi = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersProducts", x => new { x.OrderID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_OrdersProducts_Birims",
                        column: x => x.BirimID,
                        principalTable: "Birims",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrdersProducts_Currencies",
                        column: x => x.KesinCurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrdersProducts_Currencies1",
                        column: x => x.ReferansCurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrdersProducts_OrderAndProductStates",
                        column: x => x.ProductStateID,
                        principalTable: "OrderAndProductStates",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrdersProducts_Orders",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    ProductGroupID = table.Column<int>(type: "int", nullable: false),
                    ProductCategoryName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ProductCategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductGroups",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    GroupName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    GroupDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroups", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductGroupsFAQs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ProductGroupID = table.Column<int>(type: "int", nullable: true),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroupsFAQs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductCategoriesFAQs_ProductCategories",
                        column: x => x.ProductGroupID,
                        principalTable: "ProductGroups",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ProductGroupsOfSuppliers",
                columns: table => new
                {
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    ProductGroupID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategoriesSuppliers", x => new { x.SupplierID, x.ProductGroupID });
                    table.ForeignKey(
                        name: "FK_ProductCategoriesSuppliers_ProductCategories",
                        column: x => x.ProductGroupID,
                        principalTable: "ProductGroups",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductGroupID = table.Column<int>(type: "int", nullable: true),
                    StockCount = table.Column<int>(type: "int", nullable: false),
                    PorductBrandID = table.Column<int>(type: "int", nullable: false),
                    KdvOrani = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((18))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OurServices_ServiceCategories",
                        column: x => x.ProductGroupID,
                        principalTable: "ProductGroups",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Products_Brands",
                        column: x => x.PorductBrandID,
                        principalTable: "Brands",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ProductsOfSuppliers",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsOfSuppliers", x => new { x.ProductID, x.SupplierID });
                    table.ForeignKey(
                        name: "FK_ProductsOfSuppliers_Products",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ReturnAndFaults",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    OrderIdIfExist = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    RepresentitveUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlannedDeadline = table.Column<DateTime>(type: "datetime", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentStateID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnAndFaults", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ReturnAndFaultStates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    StatName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StatDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnAndFaultStates", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Rules",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    RuleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RuleDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rules", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SegmentOrans",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SegmentID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    StartPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EndPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TL_ORAN = table.Column<double>(type: "float", nullable: true),
                    EURO_ORAN = table.Column<double>(type: "float", nullable: true),
                    USD_ORAN = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SegmentOrans", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Segments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Segments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SellsAndBuysAssets",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SABCategoryID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSell = table.Column<bool>(type: "bit", nullable: false),
                    CurrentStepID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellsAndBuysAssets", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SellsAndBuysCategories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellsAndBuysCategories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SellsAndBuysGuideSteps",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    StepCount = table.Column<int>(type: "int", nullable: true),
                    StepName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StepDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SABCategoryID = table.Column<int>(type: "int", nullable: false),
                    IsSell = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellsAndBuysGuideSteps", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SellsAndBuysGuideSteps_SellsAndBuysCategories",
                        column: x => x.SABCategoryID,
                        principalTable: "SellsAndBuysCategories",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ServicePlaces",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicePlaces", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ServiceReasons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceReasons", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ServiceRecords",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    ArizaTanimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServicePersonalUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceBeginDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ServiceEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    YapilacakIslem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceReasonID = table.Column<int>(type: "int", nullable: false),
                    ServiceTypeID = table.Column<int>(type: "int", nullable: false),
                    ServicePlaceID = table.Column<int>(type: "int", nullable: false),
                    MudahaleEdilenCihaz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MudahaleEdilenModel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRecords", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ServiceRecords_Customers",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ServiceRecords_ServicePlaces",
                        column: x => x.ServicePlaceID,
                        principalTable: "ServicePlaces",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ServiceRecords_ServiceReasons",
                        column: x => x.ServiceReasonID,
                        principalTable: "ServiceReasons",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShippingDeals",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingDeals", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SupplierDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    IadeKargoUcreti = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ArizaKargoUcreti = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MusteriTemsilcisi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    GSM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsTel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Dahili = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SıparisSaati = table.Column<DateTime>(type: "datetime", nullable: true),
                    SiparisSiniri = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    YetkiliKisi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepoAdres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GonderiTuru = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Sevkiyat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KargoBedeliSatisSiniri = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KargoBedeli = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CurrencyID = table.Column<int>(type: "int", nullable: false),
                    Vade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OdemeSekli = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SupplierDetails_Currencies",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SupplierPaymentStates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierPaymentStates", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    SupplierName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OncelikSirasi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DealerCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastContactDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SuppliersBrands",
                columns: table => new
                {
                    BrandID = table.Column<int>(type: "int", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuppliersBrands", x => new { x.BrandID, x.SupplierID });
                    table.ForeignKey(
                        name: "FK_SuppliersBrands_Brands",
                        column: x => x.BrandID,
                        principalTable: "Brands",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SuppliersBrands_Suppliers",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SuppliersPayments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    TaksitSayisi = table.Column<int>(type: "int", nullable: true),
                    OdemeTutari = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyID = table.Column<int>(type: "int", nullable: false),
                    CurrencyAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentOfficerUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StateID = table.Column<int>(type: "int", nullable: false),
                    Descripiton = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuppliersPayments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SuppliersPayments_SupplierPaymentStatuses",
                        column: x => x.StateID,
                        principalTable: "SupplierPaymentStates",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "UserCompanies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CompanyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Fatura = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TicaretSicilNo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MersisNo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    FaliyetKodu = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    KepAdresi = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCompanies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    UserCompanyID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PassHash = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_UserCompanies",
                        column: x => x.UserCompanyID,
                        principalTable: "UserCompanies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Users_Users",
                        column: x => x.AddedBy,
                        principalTable: "Users",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Users_Users1",
                        column: x => x.ModifiedBy,
                        principalTable: "Users",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "UsersAuthorizationRoles",
                columns: table => new
                {
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorizationRoleID = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersAuthorizations", x => new { x.UserID, x.AuthorizationRoleID });
                    table.ForeignKey(
                        name: "FK_UsersAuthorizations_Authorizations",
                        column: x => x.AuthorizationRoleID,
                        principalTable: "AuthorizationsRoles",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UsersAuthorizations_Users",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UsersAuthorizations_Users1",
                        column: x => x.AddedBy,
                        principalTable: "Users",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UsersAuthorizations_Users2",
                        column: x => x.ModifiedBy,
                        principalTable: "Users",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "VehicleInformations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserCompanyID = table.Column<int>(type: "int", nullable: false),
                    Plaka = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModelYear = table.Column<short>(type: "smallint", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TescilTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    TrafikSigPoliceBitisTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    KaskoPoliceBitisTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    GelecekMuayeneTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    SonBakimKM = table.Column<int>(type: "int", nullable: true),
                    BakimKMPeriod = table.Column<int>(type: "int", nullable: true),
                    SonBakimTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    SonrakiBakimTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    KiraToplamKMTaahhut = table.Column<int>(type: "int", nullable: true),
                    KiraBitisTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    BazKM = table.Column<int>(type: "int", nullable: true),
                    SonOkunanKM = table.Column<int>(type: "int", nullable: true),
                    SonOkunanKMTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    KisLastigiDegisimTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    YazLastigiDegisimTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    K2BelgesiBitisTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    TakipCihaziYenilemeTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleInformations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_VehicleInformations_UserCompanies",
                        column: x => x.UserCompanyID,
                        principalTable: "UserCompanies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_VehicleInformations_Users",
                        column: x => x.AddedBy,
                        principalTable: "Users",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_VehicleInformations_Users1",
                        column: x => x.ModifiedBy,
                        principalTable: "Users",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "WarrantyTrackings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ProductCategoryID = table.Column<int>(type: "int", nullable: false),
                    BrandID = table.Column<int>(type: "int", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarrantyTrackings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WarrantyTrackings_Brands",
                        column: x => x.BrandID,
                        principalTable: "Brands",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_WarrantyTrackings_Users",
                        column: x => x.AddedBy,
                        principalTable: "Users",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_WarrantyTrackings_Users1",
                        column: x => x.ModifiedBy,
                        principalTable: "Users",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "WorkStandarts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Period = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ApplicationCalendar = table.Column<DateTime>(type: "datetime", nullable: true),
                    AvalibleHours = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    WorkTime = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    WorkDefinition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkStandarts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WorkStandarts_Departments",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_WorkStandarts_Users",
                        column: x => x.AddedBy,
                        principalTable: "Users",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_WorkStandarts_Users1",
                        column: x => x.ModifiedBy,
                        principalTable: "Users",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationsRoles_AddedBy",
                table: "AuthorizationsRoles",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationsRoles_ModifiedBy",
                table: "AuthorizationsRoles",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BankInformations_BankID",
                table: "BankInformations",
                column: "BankID");

            migrationBuilder.CreateIndex(
                name: "IX_BankInformations_CompanyID",
                table: "BankInformations",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Banks_AddedBy",
                table: "Banks",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Banks_ModifiedBy",
                table: "Banks",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Birims_AddedBy",
                table: "Birims",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Birims_ModifiedBy",
                table: "Birims",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_AddedBy",
                table: "Brands",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_ModifiedBy",
                table: "Brands",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionReceipts_CurrencyID",
                table: "CollectionReceipts",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionReceipts_CustomerID",
                table: "CollectionReceipts",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionReceipts_PaymentTypeID",
                table: "CollectionReceipts",
                column: "PaymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionReceipts_SupplierID",
                table: "CollectionReceipts",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddresses_AddedBy",
                table: "CustomerAddresses",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddresses_CustomerID",
                table: "CustomerAddresses",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddresses_ModifiedBy",
                table: "CustomerAddresses",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBillingAddresses_CustomerID",
                table: "CustomerBillingAddresses",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerContacts_AddedBy",
                table: "CustomerContacts",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerContacts_CustomerID",
                table: "CustomerContacts",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerContacts_ModifiedBy",
                table: "CustomerContacts",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDetails_CurrencyID",
                table: "CustomerDetails",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDetails_CustomerID",
                table: "CustomerDetails",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRepresentetiveUsers_CustomerID",
                table: "CustomerRepresentetiveUsers",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRepresentetiveUsers_UserID",
                table: "CustomerRepresentetiveUsers",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AddedBy",
                table: "Customers",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ModifiedBy",
                table: "Customers",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_SectorID",
                table: "Customers",
                column: "SectorID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_SegmentID",
                table: "Customers",
                column: "SegmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TypeID",
                table: "Customers",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_AddedBy",
                table: "Departments",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ModifiedBy",
                table: "Departments",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentsOfUsers_DepartmentID",
                table: "DepartmentsOfUsers",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_DepositRelations_AddedBy",
                table: "DepositRelations",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DepositRelations_ModifiedBy",
                table: "DepositRelations",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Deposits_AddedBy",
                table: "Deposits",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Deposits_CurrencyID",
                table: "Deposits",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_Deposits_DepositRelationID",
                table: "Deposits",
                column: "DepositRelationID");

            migrationBuilder.CreateIndex(
                name: "IX_Deposits_DepositTypeID",
                table: "Deposits",
                column: "DepositTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Deposits_ModifiedBy",
                table: "Deposits",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DepositTypes_AddedBy",
                table: "DepositTypes",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DepositTypes_ModifiedBy",
                table: "DepositTypes",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountCupons_AddedBy",
                table: "DiscountCupons",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountCupons_CuponCurrencyID",
                table: "DiscountCupons",
                column: "CuponCurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountCupons_ModifiedBy",
                table: "DiscountCupons",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountCuponsOfCustomers_AddedBy",
                table: "DiscountCuponsOfCustomers",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountCuponsOfCustomers_DiscountCuponID",
                table: "DiscountCuponsOfCustomers",
                column: "DiscountCuponID");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountCuponsOfCustomers_ModifiedBy",
                table: "DiscountCuponsOfCustomers",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_AddedBy",
                table: "Documents",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_ModifiedBy",
                table: "Documents",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_TypeID",
                table: "Documents",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplates_AddedBy",
                table: "EmailTemplates",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplates_DepartmentID",
                table: "EmailTemplates",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplates_ModifiedBy",
                table: "EmailTemplates",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Expansions_AddedBy",
                table: "Expansions",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Expansions_ModifiedBy",
                table: "Expansions",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceBills_AddedBy",
                table: "MaintenanceBills",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceBills_CurrencyID",
                table: "MaintenanceBills",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceBills_CustomerID",
                table: "MaintenanceBills",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceBills_CustomerRepresentetiveUserID",
                table: "MaintenanceBills",
                column: "CustomerRepresentetiveUserID");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceBills_MaintenencePeriodID",
                table: "MaintenanceBills",
                column: "MaintenencePeriodID");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceBills_ModifiedBy",
                table: "MaintenanceBills",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceBills_ProductGroupID",
                table: "MaintenanceBills",
                column: "ProductGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceBills_SellingRepresentetiveUserID",
                table: "MaintenanceBills",
                column: "SellingRepresentetiveUserID");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenencePeriods_AddedBy",
                table: "MaintenencePeriods",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenencePeriods_ModifiedBy",
                table: "MaintenencePeriods",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MarketPlaces_AddedBy",
                table: "MarketPlaces",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MarketPlaces_ModifiedBy",
                table: "MarketPlaces",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MarketPlacesOfSuppliers_MarketPlaceID",
                table: "MarketPlacesOfSuppliers",
                column: "MarketPlaceID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderAndProductStates_AddedBy",
                table: "OrderAndProductStates",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrderAndProductStates_ModifiedBy",
                table: "OrderAndProductStates",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AddedBy",
                table: "Orders",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ModifiedBy",
                table: "Orders",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderStateID",
                table: "Orders",
                column: "OrderStateID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersCurrencies_CurrencyID",
                table: "OrdersCurrencies",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProducts_AddedBy",
                table: "OrdersProducts",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProducts_BirimID",
                table: "OrdersProducts",
                column: "BirimID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProducts_KesinCurrencyID",
                table: "OrdersProducts",
                column: "KesinCurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProducts_KesinSupplierID",
                table: "OrdersProducts",
                column: "KesinSupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProducts_ModifiedBy",
                table: "OrdersProducts",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProducts_ProductID",
                table: "OrdersProducts",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProducts_ProductStateID",
                table: "OrdersProducts",
                column: "ProductStateID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProducts_ReferansCurrencyID",
                table: "OrdersProducts",
                column: "ReferansCurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProducts_ReferansSupplierID",
                table: "OrdersProducts",
                column: "ReferansSupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTypes_AddedBy",
                table: "PaymentTypes",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTypes_ModifiedBy",
                table: "PaymentTypes",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_AddedBy",
                table: "ProductCategories",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_ModifiedBy",
                table: "ProductCategories",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_ProductGroupID",
                table: "ProductCategories",
                column: "ProductGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroups_AddedBy",
                table: "ProductGroups",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroups_ModifiedBy",
                table: "ProductGroups",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroupsFAQs_AddedBy",
                table: "ProductGroupsFAQs",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroupsFAQs_ModifiedBy",
                table: "ProductGroupsFAQs",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroupsFAQs_ProductGroupID",
                table: "ProductGroupsFAQs",
                column: "ProductGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroupsOfSuppliers_ProductGroupID",
                table: "ProductGroupsOfSuppliers",
                column: "ProductGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_AddedBy",
                table: "Products",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ModifiedBy",
                table: "Products",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Products_PorductBrandID",
                table: "Products",
                column: "PorductBrandID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductGroupID",
                table: "Products",
                column: "ProductGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsOfSuppliers_SupplierID",
                table: "ProductsOfSuppliers",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnAndFaults_AddedBy",
                table: "ReturnAndFaults",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnAndFaults_CurrentStateID",
                table: "ReturnAndFaults",
                column: "CurrentStateID");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnAndFaults_ModifiedBy",
                table: "ReturnAndFaults",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnAndFaults_RepresentitveUser",
                table: "ReturnAndFaults",
                column: "RepresentitveUser");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnAndFaultStates_AddedBy",
                table: "ReturnAndFaultStates",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnAndFaultStates_ModifiedBy",
                table: "ReturnAndFaultStates",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Rules_AddedBy",
                table: "Rules",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Rules_ModifiedBy",
                table: "Rules",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SegmentOrans_AddedBy",
                table: "SegmentOrans",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SegmentOrans_ModifiedBy",
                table: "SegmentOrans",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SegmentOrans_SegmentID",
                table: "SegmentOrans",
                column: "SegmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Segments_AddedBy",
                table: "Segments",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Segments_ModifiedBy",
                table: "Segments",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SellsAndBuysAssets_AddedBy",
                table: "SellsAndBuysAssets",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SellsAndBuysAssets_CurrentStepID",
                table: "SellsAndBuysAssets",
                column: "CurrentStepID");

            migrationBuilder.CreateIndex(
                name: "IX_SellsAndBuysAssets_ModifiedBy",
                table: "SellsAndBuysAssets",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SellsAndBuysAssets_SABCategoryID",
                table: "SellsAndBuysAssets",
                column: "SABCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_SellsAndBuysCategories_AddedBy",
                table: "SellsAndBuysCategories",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SellsAndBuysCategories_ModifiedBy",
                table: "SellsAndBuysCategories",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SellsAndBuysGuideSteps_AddedBy",
                table: "SellsAndBuysGuideSteps",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SellsAndBuysGuideSteps_ModifiedBy",
                table: "SellsAndBuysGuideSteps",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SellsAndBuysGuideSteps_SABCategoryID",
                table: "SellsAndBuysGuideSteps",
                column: "SABCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ServicePlaces_AddedBy",
                table: "ServicePlaces",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ServicePlaces_ModifiedBy",
                table: "ServicePlaces",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceReasons_AddedBy",
                table: "ServiceReasons",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceReasons_ModifiedBy",
                table: "ServiceReasons",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRecords_AddedBy",
                table: "ServiceRecords",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRecords_CustomerID",
                table: "ServiceRecords",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRecords_ModifiedBy",
                table: "ServiceRecords",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRecords_ServicePersonalUser",
                table: "ServiceRecords",
                column: "ServicePersonalUser");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRecords_ServicePlaceID",
                table: "ServiceRecords",
                column: "ServicePlaceID");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRecords_ServiceReasonID",
                table: "ServiceRecords",
                column: "ServiceReasonID");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRecords_ServiceTypeID",
                table: "ServiceRecords",
                column: "ServiceTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceTypes_AddedBy",
                table: "ServiceTypes",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceTypes_ModifiedBy",
                table: "ServiceTypes",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingDeals_CompanyID",
                table: "ShippingDeals",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierDetails_CurrencyID",
                table: "SupplierDetails",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierDetails_SupplierID",
                table: "SupplierDetails",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPaymentStates_AddedBy",
                table: "SupplierPaymentStates",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPaymentStates_ModifiedBy",
                table: "SupplierPaymentStates",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_AddedBy",
                table: "Suppliers",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_ModifiedBy",
                table: "Suppliers",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliersBrands_SupplierID",
                table: "SuppliersBrands",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliersPayments_AddedBy",
                table: "SuppliersPayments",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliersPayments_ModifiedBy",
                table: "SuppliersPayments",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliersPayments_StateID",
                table: "SuppliersPayments",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_UserCompanies_AddedBy",
                table: "UserCompanies",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserCompanies_ModifiedBy",
                table: "UserCompanies",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AddedBy",
                table: "Users",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ModifiedBy",
                table: "Users",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserCompanyID",
                table: "Users",
                column: "UserCompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_UsersAuthorizationRoles_AddedBy",
                table: "UsersAuthorizationRoles",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UsersAuthorizationRoles_AuthorizationRoleID",
                table: "UsersAuthorizationRoles",
                column: "AuthorizationRoleID");

            migrationBuilder.CreateIndex(
                name: "IX_UsersAuthorizationRoles_ModifiedBy",
                table: "UsersAuthorizationRoles",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleInformations_AddedBy",
                table: "VehicleInformations",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleInformations_ModifiedBy",
                table: "VehicleInformations",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleInformations_UserCompanyID",
                table: "VehicleInformations",
                column: "UserCompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_WarrantyTrackings_AddedBy",
                table: "WarrantyTrackings",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WarrantyTrackings_BrandID",
                table: "WarrantyTrackings",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_WarrantyTrackings_ModifiedBy",
                table: "WarrantyTrackings",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WorkStandarts_AddedBy",
                table: "WorkStandarts",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WorkStandarts_DepartmentID",
                table: "WorkStandarts",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkStandarts_ModifiedBy",
                table: "WorkStandarts",
                column: "ModifiedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Authorizations_Users",
                table: "AuthorizationsRoles",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Authorizations_Users1",
                table: "AuthorizationsRoles",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_BankInformations_Banks",
                table: "BankInformations",
                column: "BankID",
                principalTable: "Banks",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_BankInformations_UserCompanies",
                table: "BankInformations",
                column: "CompanyID",
                principalTable: "UserCompanies",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Banks_Users",
                table: "Banks",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Banks_Users1",
                table: "Banks",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Birims_Users",
                table: "Birims",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Birims_Users1",
                table: "Birims",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_Users",
                table: "Brands",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_Users1",
                table: "Brands",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CollectionReceipts_Customers",
                table: "CollectionReceipts",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CollectionReceipts_PaymentTypes",
                table: "CollectionReceipts",
                column: "PaymentTypeID",
                principalTable: "PaymentTypes",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CollectionReceipts_Suppliers",
                table: "CollectionReceipts",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddresses_Customers",
                table: "CustomerAddresses",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerDeliveryAddresses_Users",
                table: "CustomerAddresses",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerDeliveryAddresses_Users1",
                table: "CustomerAddresses",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerBillingAddresses_Customers",
                table: "CustomerBillingAddresses",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerContacts_Customers",
                table: "CustomerContacts",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerContacts_Users",
                table: "CustomerContacts",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerContacts_Users1",
                table: "CustomerContacts",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerDetails_Customers",
                table: "CustomerDetails",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRepresentetiveUsers_Customers",
                table: "CustomerRepresentetiveUsers",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRepresentetiveUsers_Users",
                table: "CustomerRepresentetiveUsers",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Segments",
                table: "Customers",
                column: "SegmentID",
                principalTable: "Segments",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Users",
                table: "Customers",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Users1",
                table: "Customers",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Users",
                table: "Departments",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Users1",
                table: "Departments",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentsOfUsers_Users",
                table: "DepartmentsOfUsers",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DepositRelations_Users",
                table: "DepositRelations",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DepositRelations_Users1",
                table: "DepositRelations",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Deposits_DepositTypes",
                table: "Deposits",
                column: "DepositTypeID",
                principalTable: "DepositTypes",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Deposits_Users",
                table: "Deposits",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Deposits_Users1",
                table: "Deposits",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DepositTypes_Users",
                table: "DepositTypes",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DepositTypes_Users1",
                table: "DepositTypes",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DiscountCupons_Users",
                table: "DiscountCupons",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DiscountCupons_Users1",
                table: "DiscountCupons",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DiscountCuponsOfCustomers_Users",
                table: "DiscountCuponsOfCustomers",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DiscountCuponsOfCustomers_Users1",
                table: "DiscountCuponsOfCustomers",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Users",
                table: "Documents",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Users1",
                table: "Documents",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_EmailTemplates_Users2",
                table: "EmailTemplates",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_EmailTemplates_Users3",
                table: "EmailTemplates",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Acilimlar_Users",
                table: "Expansions",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Acilimlar_Users1",
                table: "Expansions",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceBills_MaintenencePeriods",
                table: "MaintenanceBills",
                column: "MaintenencePeriodID",
                principalTable: "MaintenencePeriods",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceBills_ProductCategories",
                table: "MaintenanceBills",
                column: "ProductGroupID",
                principalTable: "ProductGroups",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceBills_Users",
                table: "MaintenanceBills",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceBills_Users1",
                table: "MaintenanceBills",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceBills_Users2",
                table: "MaintenanceBills",
                column: "SellingRepresentetiveUserID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceBills_Users3",
                table: "MaintenanceBills",
                column: "CustomerRepresentetiveUserID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenencePeriods_Users",
                table: "MaintenencePeriods",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenencePeriods_Users1",
                table: "MaintenencePeriods",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MarketPlaces_Users",
                table: "MarketPlaces",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MarketPlaces_Users1",
                table: "MarketPlaces",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MarketPlacesOfSuppliers_Suppliers",
                table: "MarketPlacesOfSuppliers",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderStates_Users",
                table: "OrderAndProductStates",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderStates_Users1",
                table: "OrderAndProductStates",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users",
                table: "Orders",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users1",
                table: "Orders",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersProducts_Products",
                table: "OrdersProducts",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersProducts_Suppliers",
                table: "OrdersProducts",
                column: "KesinSupplierID",
                principalTable: "Suppliers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersProducts_Suppliers1",
                table: "OrdersProducts",
                column: "ReferansSupplierID",
                principalTable: "Suppliers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersProducts_Users",
                table: "OrdersProducts",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersProducts_Users1",
                table: "OrdersProducts",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentTypes_Users",
                table: "PaymentTypes",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentTypes_Users1",
                table: "PaymentTypes",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSubCategories_ProductCategories",
                table: "ProductCategories",
                column: "ProductGroupID",
                principalTable: "ProductGroups",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSubCategories_Users",
                table: "ProductCategories",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSubCategories_Users1",
                table: "ProductCategories",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Users",
                table: "ProductGroups",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Users1",
                table: "ProductGroups",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategoriesFAQs_Users",
                table: "ProductGroupsFAQs",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategoriesFAQs_Users1",
                table: "ProductGroupsFAQs",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategoriesSuppliers_Suppliers",
                table: "ProductGroupsOfSuppliers",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_OurServices_Users",
                table: "Products",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_OurServices_Users1",
                table: "Products",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsOfSuppliers_Suppliers",
                table: "ProductsOfSuppliers",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnAndFaults_ReturnAndFaultStates",
                table: "ReturnAndFaults",
                column: "CurrentStateID",
                principalTable: "ReturnAndFaultStates",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnAndFaults_Users",
                table: "ReturnAndFaults",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnAndFaults_Users1",
                table: "ReturnAndFaults",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnAndFaults_Users2",
                table: "ReturnAndFaults",
                column: "RepresentitveUser",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnAndFaultStates_Users",
                table: "ReturnAndFaultStates",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnAndFaultStates_Users1",
                table: "ReturnAndFaultStates",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rules_Users",
                table: "Rules",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rules_Users1",
                table: "Rules",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SegmentOrans_Segments",
                table: "SegmentOrans",
                column: "SegmentID",
                principalTable: "Segments",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SegmentOrans_Users",
                table: "SegmentOrans",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SegmentOrans_Users1",
                table: "SegmentOrans",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Segments_Users",
                table: "Segments",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Segments_Users1",
                table: "Segments",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SellsAndBuysAssets_SellsAndBuysCategories",
                table: "SellsAndBuysAssets",
                column: "SABCategoryID",
                principalTable: "SellsAndBuysCategories",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SellsAndBuysAssets_SellsAndBuysGuideSteps",
                table: "SellsAndBuysAssets",
                column: "CurrentStepID",
                principalTable: "SellsAndBuysGuideSteps",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SellsAndBuysAssets_Users",
                table: "SellsAndBuysAssets",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SellsAndBuysAssets_Users1",
                table: "SellsAndBuysAssets",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SellsAndBuysCategories_Users",
                table: "SellsAndBuysCategories",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SellsAndBuysCategories_Users1",
                table: "SellsAndBuysCategories",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SellsAndBuysGuideSteps_Users",
                table: "SellsAndBuysGuideSteps",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SellsAndBuysGuideSteps_Users1",
                table: "SellsAndBuysGuideSteps",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ServicePlaces_Users",
                table: "ServicePlaces",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ServicePlaces_Users1",
                table: "ServicePlaces",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceReasons_Users",
                table: "ServiceReasons",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceReasons_Users1",
                table: "ServiceReasons",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRecords_ServiceTypes",
                table: "ServiceRecords",
                column: "ServiceTypeID",
                principalTable: "ServiceTypes",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRecords_Users",
                table: "ServiceRecords",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRecords_Users1",
                table: "ServiceRecords",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRecords_Users2",
                table: "ServiceRecords",
                column: "ServicePersonalUser",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceTypes_Users",
                table: "ServiceTypes",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceTypes_Users1",
                table: "ServiceTypes",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ShippingDeals_UserCompanies",
                table: "ShippingDeals",
                column: "CompanyID",
                principalTable: "UserCompanies",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierDetails_Suppliers1",
                table: "SupplierDetails",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierPaymentStates_Users",
                table: "SupplierPaymentStates",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierPaymentStates_Users1",
                table: "SupplierPaymentStates",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Users",
                table: "Suppliers",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Users1",
                table: "Suppliers",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SuppliersPayments_Users",
                table: "SuppliersPayments",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SuppliersPayments_Users1",
                table: "SuppliersPayments",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCompanies_Users",
                table: "UserCompanies",
                column: "AddedBy",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCompanies_Users1",
                table: "UserCompanies",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCompanies_Users",
                table: "UserCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCompanies_Users1",
                table: "UserCompanies");

            migrationBuilder.DropTable(
                name: "BankInformations");

            migrationBuilder.DropTable(
                name: "CollectionReceipts");

            migrationBuilder.DropTable(
                name: "CustomerAddresses");

            migrationBuilder.DropTable(
                name: "CustomerBillingAddresses");

            migrationBuilder.DropTable(
                name: "CustomerContacts");

            migrationBuilder.DropTable(
                name: "CustomerDetails");

            migrationBuilder.DropTable(
                name: "CustomerRepresentetiveUsers");

            migrationBuilder.DropTable(
                name: "DepartmentsOfUsers");

            migrationBuilder.DropTable(
                name: "Deposits");

            migrationBuilder.DropTable(
                name: "DiscountCuponsOfCustomers");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "EmailTemplates");

            migrationBuilder.DropTable(
                name: "Expansions");

            migrationBuilder.DropTable(
                name: "MaintenanceBills");

            migrationBuilder.DropTable(
                name: "MarketPlacesOfSuppliers");

            migrationBuilder.DropTable(
                name: "OrdersCurrencies");

            migrationBuilder.DropTable(
                name: "OrdersProducts");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ProductGroupsFAQs");

            migrationBuilder.DropTable(
                name: "ProductGroupsOfSuppliers");

            migrationBuilder.DropTable(
                name: "ProductsOfSuppliers");

            migrationBuilder.DropTable(
                name: "ReturnAndFaults");

            migrationBuilder.DropTable(
                name: "Rules");

            migrationBuilder.DropTable(
                name: "SegmentOrans");

            migrationBuilder.DropTable(
                name: "SellsAndBuysAssets");

            migrationBuilder.DropTable(
                name: "ServiceRecords");

            migrationBuilder.DropTable(
                name: "ShippingDeals");

            migrationBuilder.DropTable(
                name: "SupplierDetails");

            migrationBuilder.DropTable(
                name: "SuppliersBrands");

            migrationBuilder.DropTable(
                name: "SuppliersPayments");

            migrationBuilder.DropTable(
                name: "UsersAuthorizationRoles");

            migrationBuilder.DropTable(
                name: "VehicleInformations");

            migrationBuilder.DropTable(
                name: "WarrantyTrackings");

            migrationBuilder.DropTable(
                name: "WorkStandarts");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "DepositRelations");

            migrationBuilder.DropTable(
                name: "DepositTypes");

            migrationBuilder.DropTable(
                name: "DiscountCupons");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "MaintenencePeriods");

            migrationBuilder.DropTable(
                name: "MarketPlaces");

            migrationBuilder.DropTable(
                name: "Birims");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ReturnAndFaultStates");

            migrationBuilder.DropTable(
                name: "SellsAndBuysGuideSteps");

            migrationBuilder.DropTable(
                name: "ServicePlaces");

            migrationBuilder.DropTable(
                name: "ServiceReasons");

            migrationBuilder.DropTable(
                name: "ServiceTypes");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "SupplierPaymentStates");

            migrationBuilder.DropTable(
                name: "AuthorizationsRoles");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OrderAndProductStates");

            migrationBuilder.DropTable(
                name: "ProductGroups");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "SellsAndBuysCategories");

            migrationBuilder.DropTable(
                name: "CustomerTypes");

            migrationBuilder.DropTable(
                name: "Sectors");

            migrationBuilder.DropTable(
                name: "Segments");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserCompanies");
        }
    }
}
