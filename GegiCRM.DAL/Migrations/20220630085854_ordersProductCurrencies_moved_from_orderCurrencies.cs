using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class ordersProductCurrencies_moved_from_orderCurrencies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AutoHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TableName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Changed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kind = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descirption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AppAuthorizationsRoleGroups",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAuthorizationsRoleGroups", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    RoleGroupId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AspNetRoles_AppAuthorizationsRoleGroups_RoleGroupId",
                        column: x => x.RoleGroupId,
                        principalTable: "AppAuthorizationsRoleGroups",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserCompanyID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ProfilePictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Users_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    BankDescirption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Banks_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Banks_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Birims",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Short = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birims", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Birims_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Birims_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
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
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Brands_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Brands_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CurrentValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AlisKuru = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SatisKuru = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SerbestPiyasaKuru = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CollectionReceipts_AddedBy",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CollectionReceipts_ModifiedBy",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CustomerMainCompanies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerMainCompanies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CustomerMainCompany_AddedBy",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomerMainCompany_ModifiedBy",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CustomerTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTypes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CustomerType_AddedBy",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomerType_ModifiedBy",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DepartmentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Departments_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Departments_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DepositRelations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositRelations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DepositRelations_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DepositRelations_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DepositTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositTypes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DepositTypes_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DepositTypes_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DocumentTypes_AspNetUsers_AddedById",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentTypes_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Expansions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expansions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Acilimlar_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Acilimlar_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "MaintenencePeriods",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenencePeriods", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MaintenencePeriods_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_MaintenencePeriods_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "MarketPlaces",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarketPlaceName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    MarketPlaceDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketPlaces", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MarketPlaces_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_MarketPlaces_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "OrderStates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderStates_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrderStates_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PaymentTypes_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PaymentTypes_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ProductGroups",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    GroupDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroups", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductCategories_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ReturnAndFaultStates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StatDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnAndFaultStates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReturnAndFaultStates_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ReturnAndFaultStates_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Rules",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RuleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RuleDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rules", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rules_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Rules_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Sectors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sector_AddedBy",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Sector_ModidfiedBy",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Segments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Segments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Segments_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Segments_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SellsAndBuysCategories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellsAndBuysCategories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SellsAndBuysCategories_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SellsAndBuysCategories_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ServicePlaces",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicePlaces", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ServicePlaces_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ServicePlaces_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ServiceReasons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceReasons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ServiceReasons_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ServiceReasons_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ServiceTypes_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ServiceTypes_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SupplierPaymentStates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierPaymentStates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SupplierPaymentStates_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SupplierPaymentStates_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OncelikSirasi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DealerCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastContactDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Suppliers_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Suppliers_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "UserCompanies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedById = table.Column<int>(type: "int", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CompanyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Fatura = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TicaretSicilNo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MersisNo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    FaliyetKodu = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    KepAdresi = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCompanies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserCompanies_AddedBy",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserCompanies_ModifiedBy",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "WarrantyTrackings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCategoryID = table.Column<int>(type: "int", nullable: false),
                    BrandID = table.Column<int>(type: "int", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_WarrantyTrackings_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DiscountCupons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CuponCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CuponCurrencyID = table.Column<int>(type: "int", nullable: false),
                    DiscountAmountMoney = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CuponName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CuponDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountCupons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DiscountCupons_Currencies",
                        column: x => x.CuponCurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DiscountCupons_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DiscountCupons_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DepartmentsOfUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    IsResponsible = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentsOfUsers", x => new { x.Id, x.UserID, x.DepartmentID });
                    table.ForeignKey(
                        name: "FK_DepartmentsOfUsers_AddedBy",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DepartmentsOfUsers_Departments",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DepartmentsOfUsers_ModifiedBy",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DepartmentsOfUsers_Users",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "EmailTemplates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTemplates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EmailTemplates_Departments",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_EmailTemplates_Users2",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_EmailTemplates_Users3",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "WorkStandarts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Period = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ApplicationCalendar = table.Column<DateTime>(type: "datetime", nullable: true),
                    AvalibleHours = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    WorkTime = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    WorkDefinition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_WorkStandarts_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Deposits",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepositRelationID = table.Column<int>(type: "int", nullable: false),
                    DepositTypeID = table.Column<int>(type: "int", nullable: false),
                    KurumAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IlgiliKisi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VerilisTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    CurrencyID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BitisSuresi = table.Column<DateTime>(type: "datetime", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_Deposits_DepositTypes",
                        column: x => x.DepositTypeID,
                        principalTable: "DepositTypes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Deposits_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Deposits_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DocumentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentDownloadPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Documents_DocumentTypes",
                        column: x => x.TypeID,
                        principalTable: "DocumentTypes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Documents_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Documents_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductGroupID = table.Column<int>(type: "int", nullable: false),
                    ProductCategoryName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ProductCategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductSubCategories_ProductCategories",
                        column: x => x.ProductGroupID,
                        principalTable: "ProductGroups",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductSubCategories_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductSubCategories_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ProductGroupsFAQs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductGroupID = table.Column<int>(type: "int", nullable: true),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroupsFAQs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductCategoriesFAQs_ProductCategories",
                        column: x => x.ProductGroupID,
                        principalTable: "ProductGroups",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductCategoriesFAQs_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductCategoriesFAQs_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductGroupID = table.Column<int>(type: "int", nullable: true),
                    StockCount = table.Column<int>(type: "int", nullable: false),
                    PorductBrandID = table.Column<int>(type: "int", nullable: false),
                    KdvOrani = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((18))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                        name: "FK_OurServices_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OurServices_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Products_Brands",
                        column: x => x.PorductBrandID,
                        principalTable: "Brands",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ReturnAndFaults",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    OrderIdIfExist = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    RepresentitveUser = table.Column<int>(type: "int", nullable: false),
                    PlannedDeadline = table.Column<DateTime>(type: "datetime", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentStateID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnAndFaults", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReturnAndFaults_ReturnAndFaultStates",
                        column: x => x.CurrentStateID,
                        principalTable: "ReturnAndFaultStates",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ReturnAndFaults_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ReturnAndFaults_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ReturnAndFaults_Users2",
                        column: x => x.RepresentitveUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TercihEdilenKur = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    TicariUnvan = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SectorID = table.Column<int>(type: "int", nullable: true),
                    CariKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SegmentID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    TypeID = table.Column<int>(type: "int", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    SideSuppliers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreferredCurrencyId = table.Column<int>(type: "int", nullable: true),
                    CustomerMainCompanyId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Customers_Currencies_PreferredCurrencyId",
                        column: x => x.PreferredCurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Customers_CustomerMainCompanies_CustomerMainCompanyId",
                        column: x => x.CustomerMainCompanyId,
                        principalTable: "CustomerMainCompanies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_Customers_Segments",
                        column: x => x.SegmentID,
                        principalTable: "Segments",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Customers_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Customers_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SegmentOrans",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Oran = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyID = table.Column<int>(type: "int", nullable: false),
                    StartPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EndPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SegmentID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SegmentOrans", x => new { x.ID, x.Oran, x.CurrencyID });
                    table.ForeignKey(
                        name: "FK_SegmentOrans_Currencies_CurrencyID",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SegmentOrans_Segments",
                        column: x => x.SegmentID,
                        principalTable: "Segments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SegmentOrans_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SegmentOrans_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SellsAndBuysGuideSteps",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StepCount = table.Column<int>(type: "int", nullable: true),
                    StepName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StepDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SABCategoryID = table.Column<int>(type: "int", nullable: false),
                    IsSell = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellsAndBuysGuideSteps", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SellsAndBuysGuideSteps_SellsAndBuysCategories",
                        column: x => x.SABCategoryID,
                        principalTable: "SellsAndBuysCategories",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SellsAndBuysGuideSteps_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SellsAndBuysGuideSteps_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SuppliersPayments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    TaksitSayisi = table.Column<int>(type: "int", nullable: true),
                    OdemeTutari = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyID = table.Column<int>(type: "int", nullable: false),
                    CurrencyAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentOfficerUserID = table.Column<int>(type: "int", nullable: false),
                    StateID = table.Column<int>(type: "int", nullable: false),
                    Descripiton = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuppliersPayments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SuppliersPayments_SupplierPaymentStatuses",
                        column: x => x.StateID,
                        principalTable: "SupplierPaymentStates",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SuppliersPayments_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SuppliersPayments_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
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
                    table.ForeignKey(
                        name: "FK_MarketPlacesOfSuppliers_Suppliers",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
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
                    table.ForeignKey(
                        name: "FK_ProductCategoriesSuppliers_Suppliers",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "ID");
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
                    OdemeSekli = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SupplierDetails_AspNetUsers_AddedById",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierDetails_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SupplierDetails_Currencies",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SupplierDetails_Suppliers1",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "ID");
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
                    IBAN = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankInformations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BankInformations_Banks",
                        column: x => x.BankID,
                        principalTable: "Banks",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_BankInformations_UserCompanies",
                        column: x => x.CompanyID,
                        principalTable: "UserCompanies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_BankInformations_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_BankInformations_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ShippingDeals",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingDeals", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShippingDeals_AspNetUsers_AddedById",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShippingDeals_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ShippingDeals_UserCompanies",
                        column: x => x.CompanyID,
                        principalTable: "UserCompanies",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "VehicleInformations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_VehicleInformations_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
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
                    table.ForeignKey(
                        name: "FK_ProductsOfSuppliers_Suppliers",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CollectionReceipts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    CurrencyID = table.Column<int>(type: "int", nullable: false),
                    CurrencyExchange = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentTypeID = table.Column<int>(type: "int", nullable: false),
                    Taksit = table.Column<short>(type: "smallint", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KartinUstundekiIsım = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    NameSurname = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectionReceipts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CollectionReceipts_Currencies",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CollectionReceipts_Customers",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CollectionReceipts_PaymentTypes",
                        column: x => x.PaymentTypeID,
                        principalTable: "PaymentTypes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CollectionReceipts_Suppliers",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CollectionReceipts_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CollectionReceipts_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CustomerActivityLogs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerActivityLogs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CustomerActivityLogs_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomersActivityLog_AddedBy",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomersActivityLog_ModifiedBy",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
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
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddresses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CustomerAddresses_Customers",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomerDeliveryAddresses_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomerDeliveryAddresses_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
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
                    BillingAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBillingAddresses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CustomerBillingAddresses_AddedBy",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomerBillingAddresses_Customers",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomerBillingAddresses_ModifiedBy",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CustomerContacts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    ContactName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactSurname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GSM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerContacts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CustomerContacts_Customers",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomerContacts_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomerContacts_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CustomerRepresentetiveUsers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerRepresentetiveUsers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CustomerRepresentetiveUsers_AddedBy",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomerRepresentetiveUsers_Customers",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomerRepresentetiveUsers_ModifiedBy",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomerRepresentetiveUsers_Users",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DiscountCuponsOfCustomers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    DiscountCuponID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeginDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ExpryDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountCuponsOfCustomers", x => new { x.Id, x.CustomerID, x.DiscountCuponID });
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
                    table.ForeignKey(
                        name: "FK_DiscountCuponsOfCustomers_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DiscountCuponsOfCustomers_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceBills",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    SellingRepresentetiveUserID = table.Column<int>(type: "int", nullable: true),
                    CustomerRepresentetiveUserID = table.Column<int>(type: "int", nullable: true),
                    ProductGroupID = table.Column<int>(type: "int", nullable: false),
                    MaintenencePeriodID = table.Column<int>(type: "int", nullable: false),
                    MainteneceTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    SozlesmeBedeli = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyID = table.Column<int>(type: "int", nullable: false),
                    SozlesmeBaslangicTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    SozlesmeBitisTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_MaintenanceBills_MaintenencePeriods",
                        column: x => x.MaintenencePeriodID,
                        principalTable: "MaintenencePeriods",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_MaintenanceBills_ProductCategories",
                        column: x => x.ProductGroupID,
                        principalTable: "ProductGroups",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_MaintenanceBills_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_MaintenanceBills_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_MaintenanceBills_Users2",
                        column: x => x.SellingRepresentetiveUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_MaintenanceBills_Users3",
                        column: x => x.CustomerRepresentetiveUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ServiceRecords",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    ArizaTanimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServicePersonalUser = table.Column<int>(type: "int", nullable: false),
                    ServiceBeginDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ServiceEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    YapilacakIslem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceReasonID = table.Column<int>(type: "int", nullable: false),
                    ServiceTypeID = table.Column<int>(type: "int", nullable: false),
                    ServicePlaceID = table.Column<int>(type: "int", nullable: false),
                    MudahaleEdilenCihaz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MudahaleEdilenModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_ServiceRecords_ServiceTypes",
                        column: x => x.ServiceTypeID,
                        principalTable: "ServiceTypes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ServiceRecords_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ServiceRecords_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ServiceRecords_Users2",
                        column: x => x.ServicePersonalUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SellsAndBuysAssets",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SABCategoryID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSell = table.Column<bool>(type: "bit", nullable: false),
                    CurrentStepID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellsAndBuysAssets", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SellsAndBuysAssets_SellsAndBuysCategories",
                        column: x => x.SABCategoryID,
                        principalTable: "SellsAndBuysCategories",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SellsAndBuysAssets_SellsAndBuysGuideSteps",
                        column: x => x.CurrentStepID,
                        principalTable: "SellsAndBuysGuideSteps",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SellsAndBuysAssets_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SellsAndBuysAssets_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    OrderStateID = table.Column<int>(type: "int", nullable: false),
                    IsFrequentlyUsed = table.Column<bool>(type: "bit", nullable: false),
                    IsOfferApproved = table.Column<bool>(type: "bit", nullable: false),
                    OfferApprovedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsOrderApproved = table.Column<bool>(type: "bit", nullable: false),
                    OrderApprovedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsCancelled = table.Column<bool>(type: "bit", nullable: false),
                    CancelledDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeneied = table.Column<bool>(type: "bit", nullable: false),
                    DeniedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SelectedCustomerAddressId = table.Column<int>(type: "int", nullable: true),
                    SelectedCustomerBillingAddressId = table.Column<int>(type: "int", nullable: true),
                    RepresentetiveUserId = table.Column<int>(type: "int", nullable: false),
                    OfferNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_CustomerAddresses_SelectedCustomerAddressId",
                        column: x => x.SelectedCustomerAddressId,
                        principalTable: "CustomerAddresses",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Orders_CustomerBillingAddresses_SelectedCustomerBillingAddressId",
                        column: x => x.SelectedCustomerBillingAddressId,
                        principalTable: "CustomerBillingAddresses",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Orders_Customers",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Orders_OrderStates",
                        column: x => x.OrderStateID,
                        principalTable: "OrderStates",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Orders_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Orders_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrdersRepresentetiveUsers",
                        column: x => x.RepresentetiveUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "OrdersProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    ReferanceCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KesinCurrencyID = table.Column<int>(type: "int", nullable: true),
                    CurrencyId = table.Column<int>(type: "int", nullable: true),
                    ReferansCurrencyID = table.Column<int>(type: "int", nullable: true),
                    KesinCurrencyValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ReferansCurrencyValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CurrencyValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Adet = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    KesinFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BirimFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BirimID = table.Column<int>(type: "int", nullable: false),
                    ReferansBirimFiyat = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KesinSupplierID = table.Column<int>(type: "int", nullable: true),
                    ReferansSupplierID = table.Column<int>(type: "int", nullable: false),
                    AbonelikBaslangic = table.Column<DateTime>(type: "datetime", nullable: true),
                    AbonelikBitis = table.Column<DateTime>(type: "datetime", nullable: true),
                    KesinSevkDurumu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KesinSevkTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsCancelled = table.Column<bool>(type: "bit", nullable: false),
                    CancelledDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeneied = table.Column<bool>(type: "bit", nullable: false),
                    DeniedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsFrequentlyUsed = table.Column<bool>(type: "bit", nullable: false),
                    OrderStateId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersProducts", x => new { x.Id, x.OrderID, x.ProductID });
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
                        name: "FK_OrdersProducts_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrdersProducts_Currencies1",
                        column: x => x.ReferansCurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrdersProducts_Orders",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrdersProducts_OrderStates_OrderStateId",
                        column: x => x.OrderStateId,
                        principalTable: "OrderStates",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrdersProducts_Products",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrdersProducts_Suppliers",
                        column: x => x.KesinSupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrdersProducts_Suppliers1",
                        column: x => x.ReferansSupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrdersProducts_Users",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrdersProducts_Users1",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "OrdersProductCurrencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrdersProductId = table.Column<int>(type: "int", nullable: false),
                    CurrencyID = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OrdersProductId1 = table.Column<int>(type: "int", nullable: false),
                    OrdersProductOrderId = table.Column<int>(type: "int", nullable: false),
                    OrdersProductProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersProductCurrencies", x => new { x.Id, x.OrdersProductId, x.CurrencyID });
                    table.ForeignKey(
                        name: "FK_OrdersProductCurrencies_AspNetUsers_AddedById",
                        column: x => x.AddedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdersProductCurrencies_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrdersProductCurrencies_Currencies",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrdersProductCurrencies_OrdersProducts_OrdersProductId1_OrdersProductOrderId_OrdersProductProductId",
                        columns: x => new { x.OrdersProductId1, x.OrdersProductOrderId, x.OrdersProductProductId },
                        principalTable: "OrdersProducts",
                        principalColumns: new[] { "Id", "OrderID", "ProductID" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "UserCompanies",
                columns: new[] { "ID", "AddedById", "CompanyDescription", "CompanyName", "FaliyetKodu", "Fatura", "IsDeleted", "KepAdresi", "MersisNo", "ModifiedById", "Tel", "TicaretSicilNo" },
                values: new object[] { 1, null, null, "AdminCompany", null, null, false, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "ID", "AccessFailedCount", "AddedById", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "IsDeleted", "LockoutEnabled", "LockoutEnd", "ModifiedById", "ModifiedDate", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserCompanyID", "UserName" },
                values: new object[] { 1, 0, 1, "42d2b119-9146-459a-9cec-87d21c1ece91", new DateTime(2022, 6, 30, 11, 58, 53, 427, DateTimeKind.Local).AddTicks(7909), "yigit.genc@gegi.com.tr", true, false, false, null, null, new DateTime(2022, 6, 30, 11, 58, 53, 427, DateTimeKind.Local).AddTicks(7929), "Yiğit", "YIGIT.GENC@GEGI.COM.TR", "YG", "AQAAAAEAACcQAAAAEKzNRpyZG1OJufJl0g4uX5HhkPeeG1JX8ImtD8TV7CK9+lrUh2bCpucuKSCZO8QXwQ==", "+905382630008", false, null, "a7f864b4-d6fa-479c-bac2-6cf1e99b8a72", "Genç", false, 1, "YG" });

            migrationBuilder.InsertData(
                table: "AppAuthorizationsRoleGroups",
                columns: new[] { "ID", "AddedById", "Description", "IsDeleted", "ModifiedById", "Name", "Priority" },
                values: new object[] { 1, 1, "Admin Rollerinin Bulunduğu Grup", false, null, "Admin Role Grubu", 0 });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "ID", "AddedById", "AlisKuru", "Code", "CreatedDate", "CurrentValue", "IsDeleted", "ModifiedById", "ModifiedDate", "Name", "SatisKuru", "SerbestPiyasaKuru" },
                values: new object[,]
                {
                    { 1, 1, null, "TRY", new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7928), 1m, false, null, null, "Türk Lirası", null, null },
                    { 2, 1, null, "USD", new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7940), 16m, false, null, null, "Amerikan Doları", null, null },
                    { 3, 1, null, "EUR", new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7943), 17m, false, null, null, "EURO", null, null }
                });

            migrationBuilder.InsertData(
                table: "CustomerMainCompanies",
                columns: new[] { "ID", "AddedById", "Description", "IsDeleted", "ModifiedById", "Name" },
                values: new object[] { 1, 1, "Test Müşterisinin Ana Müşterisi (çatı firma)", false, null, "Test Ana Müşterisi" });

            migrationBuilder.InsertData(
                table: "CustomerTypes",
                columns: new[] { "ID", "AddedById", "CreatedDate", "Description", "IsDeleted", "ModifiedById", "ModifiedDate", "Name" },
                values: new object[] { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bu Müşteri Tipi Tesat Amaçlı Eklenmiştir", false, null, null, "Test Müşteri Tipi" });

            migrationBuilder.InsertData(
                table: "OrderStates",
                columns: new[] { "ID", "AddedById", "Description", "IsDeleted", "ModifiedById", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Test Açıklama", false, null, "Dönüş Bekleniyor ( Satın Alma )" },
                    { 2, 1, "Test Açıklama", false, null, "Olumsuz ( Satış )" },
                    { 3, 1, "Test Açıklama", false, null, "İptal / İade" },
                    { 4, 1, "Test Açıklama", false, null, "Onaylandı ( Teknik )" },
                    { 5, 1, "Test Açıklama", false, null, "Teklif Verildi ( Satışçı )" },
                    { 6, 1, "Test Açıklama", false, null, "Sipariş Verildi ( Satın Alma )" },
                    { 7, 1, "Test Açıklama", false, null, "Fatura Düzenlendi ( Muhasebe )" },
                    { 8, 1, "Test Açıklama", false, null, "Kargo / Sevkiyatta ( Depo )" },
                    { 9, 1, "Test Açıklama", false, null, "Onaylandı ( Satış )" },
                    { 10, 1, "Test Açıklama", false, null, "Fiyat Araştırılıyor ( Satın Alma )" }
                });

            migrationBuilder.InsertData(
                table: "Sectors",
                columns: new[] { "ID", "AddedById", "Description", "IsDeleted", "ModifiedById", "Name" },
                values: new object[] { 1, 1, "Test Sektör Açıklaması", false, null, "Test Sektörü" });

            migrationBuilder.InsertData(
                table: "Segments",
                columns: new[] { "ID", "AddedById", "CreatedDate", "Description", "IsDeleted", "ModifiedById", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7975), "Segment 1 Açıklaması", false, null, "Segment 1" },
                    { 2, 1, new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7984), "Segment 2 Açıklaması", false, null, "Segment 2" },
                    { 3, 1, new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7986), "Segment 3 Açıklaması", false, null, "Segment 3" },
                    { 4, 1, new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7988), "Segment 4 Açıklaması", false, null, "Segment 4" },
                    { 5, 1, new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7990), "Segment 5 Açıklaması", false, null, "Segment 5" },
                    { 6, 1, new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7993), "Segment 6 Açıklaması", false, null, "Segment 6" },
                    { 7, 1, new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7994), "Segment 7 Açıklaması", false, null, "Segment 7" },
                    { 8, 1, new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7996), "Segment 8 Açıklaması", false, null, "Segment 8" },
                    { 9, 1, new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7998), "Segment 9 Açıklaması", false, null, "Segment 9" },
                    { 10, 1, new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(8000), "Segment 10 Açıklaması", false, null, "Segment 10" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID", "AddedById", "DealerCode", "IsDeleted", "LastContactDate", "ModifiedById", "OncelikSirasi", "SupplierName", "URL" },
                values: new object[] { 1, 1, "123", false, null, null, null, "Test Tedarikçisi", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "ID", "AddedById", "ConcurrencyStamp", "CreatedDate", "Description", "IsDeleted", "ModifiedById", "ModifiedDate", "Name", "NormalizedName", "RoleGroupId" },
                values: new object[] { 1, 1, "021008c1-c01a-4a64-8425-90f93fb5dc0e", new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7895), "Sistem Admini Full Yetki", false, 1, new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7896), "SysAdmin", "Sistem Admini", 1 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "AddedById", "CariKodu", "CurrencyId", "CustomerMainCompanyId", "IsActive", "IsDeleted", "ModifiedById", "Name", "Notes", "PreferredCurrencyId", "SectorID", "SegmentID", "SideSuppliers", "Surname", "Tel", "TercihEdilenKur", "TicariUnvan", "TypeID" },
                values: new object[] { 1, 1, "123", 0, 1, true, false, null, "Test Müşterisi", null, null, 1, 1, null, "Soyad", null, " ", "Test Ticari Ünvanı", 1 });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "CurrencyID", "ID", "Oran", "AddedById", "EndPrice", "IsDeleted", "ModifiedById", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 1, 1, 22.5m, 1, 49.99m, false, null, 1, 0.00m },
                    { 1, 2, 13.5m, 1, 199.99m, false, null, 1, 50.00m },
                    { 1, 3, 11m, 1, 499.99m, false, null, 1, 200.00m },
                    { 1, 4, 7.5m, 1, 999.99m, false, null, 1, 500.00m },
                    { 1, 5, 6m, 1, 2499.99m, false, null, 1, 1000.00m },
                    { 1, 6, 5.25m, 1, 4999.99m, false, null, 1, 2500.00m },
                    { 1, 7, 5m, 1, 9999.99m, false, null, 1, 5000.00m },
                    { 1, 8, 4.5m, 1, 19999.99m, false, null, 1, 10000.00m },
                    { 1, 9, 4m, 1, 39999.99m, false, null, 1, 20000.00m },
                    { 1, 10, 3.38m, 1, 74999.99m, false, null, 1, 40000.00m },
                    { 1, 11, 3m, 1, 99999.99m, false, null, 1, 75000.00m },
                    { 1, 12, 3m, 1, 149999.99m, false, null, 1, 100000.00m },
                    { 1, 13, 2m, 1, 249999.99m, false, null, 1, 150000.00m },
                    { 1, 14, 1.88m, 1, 499999.99m, false, null, 1, 250000.00m },
                    { 1, 15, 2m, 1, 999999.99m, false, null, 1, 500000.00m },
                    { 1, 16, 1.5m, 1, 99999999.99m, false, null, 1, 1000000.00m },
                    { 1, 17, 27m, 1, 49.99m, false, null, 2, 0.00m },
                    { 1, 18, 16.2m, 1, 199.99m, false, null, 2, 50.00m },
                    { 1, 19, 126.6m, 1, 499.99m, false, null, 2, 200.00m },
                    { 1, 20, 9m, 1, 999.99m, false, null, 2, 500.00m },
                    { 1, 21, 7.2m, 1, 2499.99m, false, null, 2, 1000.00m },
                    { 1, 22, 6.3m, 1, 4999.99m, false, null, 2, 2500.00m },
                    { 1, 23, 5.85m, 1, 9999.99m, false, null, 2, 5000.00m },
                    { 1, 24, 5.4m, 1, 19999.99m, false, null, 2, 10000.00m },
                    { 1, 25, 4.5m, 1, 39999.99m, false, null, 2, 20000.00m },
                    { 1, 26, 4.05m, 1, 74999.99m, false, null, 2, 40000.00m },
                    { 1, 27, 3.78m, 1, 99999.99m, false, null, 2, 75000.00m },
                    { 1, 28, 3.6m, 1, 149999.99m, false, null, 2, 100000.00m },
                    { 1, 29, 2.7m, 1, 249999.99m, false, null, 2, 150000.00m },
                    { 1, 30, 2.25m, 1, 499999.99m, false, null, 2, 250000.00m },
                    { 1, 31, 1.98m, 1, 999999.99m, false, null, 2, 500000.00m },
                    { 1, 32, 1.8m, 1, 99999999.99m, false, null, 2, 1000000.00m },
                    { 1, 33, 32.4m, 1, 49.99m, false, null, 3, 0.00m },
                    { 1, 34, 19.44m, 1, 199.99m, false, null, 3, 50.00m },
                    { 1, 35, 15.12m, 1, 499.99m, false, null, 3, 200.00m },
                    { 1, 36, 10.8m, 1, 999.99m, false, null, 3, 500.00m },
                    { 1, 37, 8.64m, 1, 2499.99m, false, null, 3, 1000.00m },
                    { 1, 38, 7.56m, 1, 4999.99m, false, null, 3, 2500.00m },
                    { 1, 39, 7.02m, 1, 9999.99m, false, null, 3, 5000.00m },
                    { 1, 40, 6.48m, 1, 19999.99m, false, null, 3, 10000.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "CurrencyID", "ID", "Oran", "AddedById", "EndPrice", "IsDeleted", "ModifiedById", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 1, 41, 5.4m, 1, 39999.99m, false, null, 3, 20000.00m },
                    { 1, 42, 4.86m, 1, 74999.99m, false, null, 3, 40000.00m },
                    { 1, 43, 4.54m, 1, 99999.99m, false, null, 3, 75000.00m },
                    { 1, 44, 4.32m, 1, 149999.99m, false, null, 3, 100000.00m },
                    { 1, 45, 3.24m, 1, 249999.99m, false, null, 3, 150000.00m },
                    { 1, 46, 2.7m, 1, 499999.99m, false, null, 3, 250000.00m },
                    { 1, 47, 2.38m, 1, 999999.99m, false, null, 3, 500000.00m },
                    { 1, 48, 2.16m, 1, 99999999.99m, false, null, 3, 1000000.00m },
                    { 1, 49, 38.88m, 1, 49.99m, false, null, 4, 0.00m },
                    { 1, 50, 23.33m, 1, 199.99m, false, null, 4, 50.00m },
                    { 1, 51, 18.14m, 1, 499.99m, false, null, 4, 200.00m },
                    { 1, 52, 12.96m, 1, 999.99m, false, null, 4, 500.00m },
                    { 1, 53, 10.37m, 1, 2499.99m, false, null, 4, 1000.00m },
                    { 1, 54, 9.07m, 1, 4999.99m, false, null, 4, 2500.00m },
                    { 1, 55, 8.42m, 1, 9999.99m, false, null, 4, 5000.00m },
                    { 1, 56, 7.78m, 1, 19999.99m, false, null, 4, 10000.00m },
                    { 1, 57, 6.48m, 1, 39999.99m, false, null, 4, 20000.00m },
                    { 1, 58, 5.83m, 1, 74999.99m, false, null, 4, 40000.00m },
                    { 1, 59, 5.44m, 1, 99999.99m, false, null, 4, 75000.00m },
                    { 1, 60, 5.18m, 1, 149999.99m, false, null, 4, 100000.00m },
                    { 1, 61, 3.89m, 1, 249999.99m, false, null, 4, 150000.00m },
                    { 1, 62, 3.24m, 1, 499999.99m, false, null, 4, 250000.00m },
                    { 1, 63, 2.85m, 1, 999999.99m, false, null, 4, 500000.00m },
                    { 1, 64, 2.59m, 1, 99999999.99m, false, null, 4, 1000000.00m },
                    { 1, 65, 46.66m, 1, 49.99m, false, null, 5, 0.00m },
                    { 1, 66, 27.99m, 1, 199.99m, false, null, 5, 50.00m },
                    { 1, 67, 21.77m, 1, 499.99m, false, null, 5, 200.00m },
                    { 1, 68, 15.55m, 1, 999.99m, false, null, 5, 500.00m },
                    { 1, 69, 12.44m, 1, 2499.99m, false, null, 5, 1000.00m },
                    { 1, 70, 10.89m, 1, 4999.99m, false, null, 5, 2500.00m },
                    { 1, 71, 10.11m, 1, 9999.99m, false, null, 5, 5000.00m },
                    { 1, 72, 9.33m, 1, 19999.99m, false, null, 5, 10000.00m },
                    { 1, 73, 7.78m, 1, 39999.99m, false, null, 5, 20000.00m },
                    { 1, 74, 7m, 1, 74999.99m, false, null, 5, 40000.00m },
                    { 1, 75, 6.53m, 1, 99999.99m, false, null, 5, 75000.00m },
                    { 1, 76, 6.22m, 1, 149999.99m, false, null, 5, 100000.00m },
                    { 1, 77, 4.67m, 1, 249999.99m, false, null, 5, 150000.00m },
                    { 1, 78, 3.89m, 1, 499999.99m, false, null, 5, 250000.00m },
                    { 1, 79, 3.42m, 1, 999999.99m, false, null, 5, 500000.00m },
                    { 1, 80, 3.11m, 1, 99999999.99m, false, null, 5, 1000000.00m },
                    { 1, 81, 55.99m, 1, 49.99m, false, null, 6, 0.00m },
                    { 1, 82, 33.59m, 1, 199.99m, false, null, 6, 50.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "CurrencyID", "ID", "Oran", "AddedById", "EndPrice", "IsDeleted", "ModifiedById", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 1, 83, 26.13m, 1, 499.99m, false, null, 6, 200.00m },
                    { 1, 84, 18.66m, 1, 999.99m, false, null, 6, 500.00m },
                    { 1, 85, 14.93m, 1, 2499.99m, false, null, 6, 1000.00m },
                    { 1, 86, 13.06m, 1, 4999.99m, false, null, 6, 2500.00m },
                    { 1, 87, 12.13m, 1, 9999.99m, false, null, 6, 5000.00m },
                    { 1, 88, 11.2m, 1, 19999.99m, false, null, 6, 10000.00m },
                    { 1, 89, 9.33m, 1, 39999.99m, false, null, 6, 20000.00m },
                    { 1, 90, 8.4m, 1, 74999.99m, false, null, 6, 40000.00m },
                    { 1, 91, 7.84m, 1, 99999.99m, false, null, 6, 75000.00m },
                    { 1, 92, 7.46m, 1, 149999.99m, false, null, 6, 100000.00m },
                    { 1, 93, 5.6m, 1, 249999.99m, false, null, 6, 150000.00m },
                    { 1, 94, 4.67m, 1, 499999.99m, false, null, 6, 250000.00m },
                    { 1, 95, 4.11m, 1, 999999.99m, false, null, 6, 500000.00m },
                    { 1, 96, 3.73m, 1, 99999999.99m, false, null, 6, 1000000.00m },
                    { 1, 97, 67.18m, 1, 49.99m, false, null, 7, 0.00m },
                    { 1, 98, 40.31m, 1, 199.99m, false, null, 7, 50.00m },
                    { 1, 99, 31.35m, 1, 499.99m, false, null, 7, 200.00m },
                    { 1, 100, 22.39m, 1, 999.99m, false, null, 7, 500.00m },
                    { 1, 101, 17.92m, 1, 2499.99m, false, null, 7, 1000.00m },
                    { 1, 102, 15.68m, 1, 4999.99m, false, null, 7, 2500.00m },
                    { 1, 103, 14.56m, 1, 9999.99m, false, null, 7, 5000.00m },
                    { 1, 104, 13.44m, 1, 19999.99m, false, null, 7, 10000.00m },
                    { 1, 105, 11.2m, 1, 39999.99m, false, null, 7, 20000.00m },
                    { 1, 106, 10.08m, 1, 74999.99m, false, null, 7, 40000.00m },
                    { 1, 107, 9.41m, 1, 99999.99m, false, null, 7, 75000.00m },
                    { 1, 108, 8.96m, 1, 149999.99m, false, null, 7, 100000.00m },
                    { 1, 109, 6.72m, 1, 249999.99m, false, null, 7, 150000.00m },
                    { 1, 110, 5.6m, 1, 499999.99m, false, null, 7, 250000.00m },
                    { 1, 111, 4.93m, 1, 999999.99m, false, null, 7, 500000.00m },
                    { 1, 112, 4.48m, 1, 99999999.99m, false, null, 7, 1000000.00m },
                    { 1, 113, 80.62m, 1, 49.99m, false, null, 8, 0.00m },
                    { 1, 114, 48.37m, 1, 199.99m, false, null, 8, 50.00m },
                    { 1, 115, 37.62m, 1, 499.99m, false, null, 8, 200.00m },
                    { 1, 116, 26.87m, 1, 999.99m, false, null, 8, 500.00m },
                    { 1, 117, 21.5m, 1, 2499.99m, false, null, 8, 1000.00m },
                    { 1, 118, 18.81m, 1, 4999.99m, false, null, 8, 2500.00m },
                    { 1, 119, 17.47m, 1, 9999.99m, false, null, 8, 5000.00m },
                    { 1, 120, 16.12m, 1, 19999.99m, false, null, 8, 10000.00m },
                    { 1, 121, 13.44m, 1, 39999.99m, false, null, 8, 20000.00m },
                    { 1, 122, 12.09m, 1, 74999.99m, false, null, 8, 40000.00m },
                    { 1, 123, 11.29m, 1, 99999.99m, false, null, 8, 75000.00m },
                    { 1, 124, 10.75m, 1, 149999.99m, false, null, 8, 100000.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "CurrencyID", "ID", "Oran", "AddedById", "EndPrice", "IsDeleted", "ModifiedById", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 1, 125, 8.06m, 1, 249999.99m, false, null, 8, 150000.00m },
                    { 1, 126, 6.72m, 1, 499999.99m, false, null, 8, 250000.00m },
                    { 1, 127, 5.91m, 1, 999999.99m, false, null, 8, 500000.00m },
                    { 1, 128, 5.37m, 1, 99999999.99m, false, null, 8, 1000000.00m },
                    { 1, 129, 96.75m, 1, 49.99m, false, null, 9, 0.00m },
                    { 1, 130, 58.05m, 1, 199.99m, false, null, 9, 50.00m },
                    { 1, 131, 45.15m, 1, 499.99m, false, null, 9, 200.00m },
                    { 1, 132, 32.25m, 1, 999.99m, false, null, 9, 500.00m },
                    { 1, 133, 25.8m, 1, 2499.99m, false, null, 9, 1000.00m },
                    { 1, 134, 22.57m, 1, 4999.99m, false, null, 9, 2500.00m },
                    { 1, 135, 20.96m, 1, 9999.99m, false, null, 9, 5000.00m },
                    { 1, 136, 19.35m, 1, 19999.99m, false, null, 9, 10000.00m },
                    { 1, 137, 16.12m, 1, 39999.99m, false, null, 9, 20000.00m },
                    { 1, 138, 14.51m, 1, 74999.99m, false, null, 9, 40000.00m },
                    { 1, 139, 13.54m, 1, 99999.99m, false, null, 9, 75000.00m },
                    { 1, 140, 12.9m, 1, 149999.99m, false, null, 9, 100000.00m },
                    { 1, 141, 9.67m, 1, 249999.99m, false, null, 9, 150000.00m },
                    { 1, 142, 8.06m, 1, 499999.99m, false, null, 9, 250000.00m },
                    { 1, 143, 7m, 1, 999999.99m, false, null, 9, 500000.00m },
                    { 1, 144, 6.45m, 1, 99999999.99m, false, null, 9, 1000000.00m },
                    { 1, 145, 116.1m, 1, 49.99m, false, null, 10, 0.00m },
                    { 1, 146, 72.56m, 1, 199.99m, false, null, 10, 50.00m },
                    { 1, 147, 58.69m, 1, 499.99m, false, null, 10, 200.00m },
                    { 1, 148, 43.54m, 1, 999.99m, false, null, 10, 500.00m },
                    { 1, 149, 36.12m, 1, 2499.99m, false, null, 10, 1000.00m },
                    { 1, 150, 32.73m, 1, 4999.99m, false, null, 10, 2500.00m },
                    { 1, 151, 31.44m, 1, 9999.99m, false, null, 10, 5000.00m },
                    { 1, 152, 29.99m, 1, 19999.99m, false, null, 10, 10000.00m },
                    { 1, 153, 25.8m, 1, 39999.99m, false, null, 10, 20000.00m },
                    { 1, 154, 23.94m, 1, 74999.99m, false, null, 10, 40000.00m },
                    { 1, 155, 23.03m, 1, 99999.99m, false, null, 10, 75000.00m },
                    { 1, 156, 22.57m, 1, 149999.99m, false, null, 10, 100000.00m },
                    { 1, 157, 17.41m, 1, 249999.99m, false, null, 10, 150000.00m },
                    { 1, 158, 14.91m, 1, 499999.99m, false, null, 10, 250000.00m },
                    { 1, 159, 13.48m, 1, 999999.99m, false, null, 10, 500000.00m },
                    { 1, 160, 12.58m, 1, 99999999.99m, false, null, 10, 1000000.00m },
                    { 2, 161, 15m, 1, 49.99m, false, null, 1, 0.00m },
                    { 2, 162, 9m, 1, 199.99m, false, null, 1, 50.00m },
                    { 2, 163, 7m, 1, 499.99m, false, null, 1, 200.00m },
                    { 2, 164, 5m, 1, 999.99m, false, null, 1, 500.00m },
                    { 2, 165, 4m, 1, 2499.99m, false, null, 1, 1000.00m },
                    { 2, 166, 3.5m, 1, 4999.99m, false, null, 1, 2500.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "CurrencyID", "ID", "Oran", "AddedById", "EndPrice", "IsDeleted", "ModifiedById", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 2, 167, 3.25m, 1, 9999.99m, false, null, 1, 5000.00m },
                    { 2, 168, 3m, 1, 19999.99m, false, null, 1, 10000.00m },
                    { 2, 169, 2.5m, 1, 39999.99m, false, null, 1, 20000.00m },
                    { 2, 170, 2.25m, 1, 74999.99m, false, null, 1, 40000.00m },
                    { 2, 171, 2.1m, 1, 99999.99m, false, null, 1, 75000.00m },
                    { 2, 172, 2m, 1, 149999.99m, false, null, 1, 100000.00m },
                    { 2, 173, 1.5m, 1, 249999.99m, false, null, 1, 150000.00m },
                    { 2, 174, 1.25m, 1, 499999.99m, false, null, 1, 250000.00m },
                    { 2, 175, 1.1m, 1, 999999.99m, false, null, 1, 500000.00m },
                    { 2, 176, 1m, 1, 99999999.99m, false, null, 1, 1000000.00m },
                    { 2, 177, 18m, 1, 49.99m, false, null, 2, 0.00m },
                    { 2, 178, 10.8m, 1, 199.99m, false, null, 2, 50.00m },
                    { 2, 179, 8.4m, 1, 499.99m, false, null, 2, 200.00m },
                    { 2, 180, 6m, 1, 999.99m, false, null, 2, 500.00m },
                    { 2, 181, 4.8m, 1, 2499.99m, false, null, 2, 1000.00m },
                    { 2, 182, 4.2m, 1, 4999.99m, false, null, 2, 2500.00m },
                    { 2, 183, 3.9m, 1, 9999.99m, false, null, 2, 5000.00m },
                    { 2, 184, 3.6m, 1, 19999.99m, false, null, 2, 10000.00m },
                    { 2, 185, 3m, 1, 39999.99m, false, null, 2, 20000.00m },
                    { 2, 186, 2.7m, 1, 74999.99m, false, null, 2, 40000.00m },
                    { 2, 187, 2.52m, 1, 99999.99m, false, null, 2, 75000.00m },
                    { 2, 188, 2.4m, 1, 149999.99m, false, null, 2, 100000.00m },
                    { 2, 189, 1.8m, 1, 249999.99m, false, null, 2, 150000.00m },
                    { 2, 190, 1.5m, 1, 499999.99m, false, null, 2, 250000.00m },
                    { 2, 191, 1.32m, 1, 999999.99m, false, null, 2, 500000.00m },
                    { 2, 192, 1.2m, 1, 99999999.99m, false, null, 2, 1000000.00m },
                    { 2, 193, 21.6m, 1, 49.99m, false, null, 3, 0.00m },
                    { 2, 194, 12.96m, 1, 199.99m, false, null, 3, 50.00m },
                    { 2, 195, 10.08m, 1, 499.99m, false, null, 3, 200.00m },
                    { 2, 196, 7.2m, 1, 999.99m, false, null, 3, 500.00m },
                    { 2, 197, 5.76m, 1, 2499.99m, false, null, 3, 1000.00m },
                    { 2, 198, 5.04m, 1, 4999.99m, false, null, 3, 2500.00m },
                    { 2, 199, 4.68m, 1, 9999.99m, false, null, 3, 5000.00m },
                    { 2, 200, 4.32m, 1, 19999.99m, false, null, 3, 10000.00m },
                    { 2, 201, 3.6m, 1, 39999.99m, false, null, 3, 20000.00m },
                    { 2, 202, 3.24m, 1, 74999.99m, false, null, 3, 40000.00m },
                    { 2, 203, 3.02m, 1, 99999.99m, false, null, 3, 75000.00m },
                    { 2, 204, 2.88m, 1, 149999.99m, false, null, 3, 100000.00m },
                    { 2, 205, 2.16m, 1, 249999.99m, false, null, 3, 150000.00m },
                    { 2, 206, 1.8m, 1, 499999.99m, false, null, 3, 250000.00m },
                    { 2, 207, 1.58m, 1, 999999.99m, false, null, 3, 500000.00m },
                    { 2, 208, 1.44m, 1, 99999999.99m, false, null, 3, 1000000.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "CurrencyID", "ID", "Oran", "AddedById", "EndPrice", "IsDeleted", "ModifiedById", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 2, 209, 25.92m, 1, 49.99m, false, null, 4, 0.00m },
                    { 2, 210, 15.55m, 1, 199.99m, false, null, 4, 50.00m },
                    { 2, 211, 12.1m, 1, 499.99m, false, null, 4, 200.00m },
                    { 2, 212, 8.64m, 1, 999.99m, false, null, 4, 500.00m },
                    { 2, 213, 6.91m, 1, 2499.99m, false, null, 4, 1000.00m },
                    { 2, 214, 6.05m, 1, 4999.99m, false, null, 4, 2500.00m },
                    { 2, 215, 5.62m, 1, 9999.99m, false, null, 4, 5000.00m },
                    { 2, 216, 5.18m, 1, 19999.99m, false, null, 4, 10000.00m },
                    { 2, 217, 4.32m, 1, 39999.99m, false, null, 4, 20000.00m },
                    { 2, 218, 3.89m, 1, 74999.99m, false, null, 4, 40000.00m },
                    { 2, 219, 3.63m, 1, 99999.99m, false, null, 4, 75000.00m },
                    { 2, 220, 3.46m, 1, 149999.99m, false, null, 4, 100000.00m },
                    { 2, 221, 2.59m, 1, 249999.99m, false, null, 4, 150000.00m },
                    { 2, 222, 2.16m, 1, 499999.99m, false, null, 4, 250000.00m },
                    { 2, 223, 1.9m, 1, 999999.99m, false, null, 4, 500000.00m },
                    { 2, 224, 1.73m, 1, 99999999.99m, false, null, 4, 1000000.00m },
                    { 2, 225, 31.1m, 1, 49.99m, false, null, 5, 0.00m },
                    { 2, 226, 18.66m, 1, 199.99m, false, null, 5, 50.00m },
                    { 2, 227, 14.52m, 1, 499.99m, false, null, 5, 200.00m },
                    { 2, 228, 10.37m, 1, 999.99m, false, null, 5, 500.00m },
                    { 2, 229, 8.29m, 1, 2499.99m, false, null, 5, 1000.00m },
                    { 2, 230, 7.26m, 1, 4999.99m, false, null, 5, 2500.00m },
                    { 2, 231, 6.74m, 1, 9999.99m, false, null, 5, 5000.00m },
                    { 2, 232, 6.22m, 1, 19999.99m, false, null, 5, 10000.00m },
                    { 2, 233, 5.18m, 1, 39999.99m, false, null, 5, 20000.00m },
                    { 2, 234, 4.67m, 1, 74999.99m, false, null, 5, 40000.00m },
                    { 2, 235, 4.35m, 1, 99999.99m, false, null, 5, 75000.00m },
                    { 2, 236, 4.15m, 1, 149999.99m, false, null, 5, 100000.00m },
                    { 2, 237, 3.11m, 1, 249999.99m, false, null, 5, 150000.00m },
                    { 2, 238, 2.59m, 1, 499999.99m, false, null, 5, 250000.00m },
                    { 2, 239, 2.28m, 1, 999999.99m, false, null, 5, 500000.00m },
                    { 2, 240, 2.07m, 1, 99999999.99m, false, null, 5, 1000000.00m },
                    { 2, 241, 37.32m, 1, 49.99m, false, null, 6, 0.00m },
                    { 2, 242, 22.39m, 1, 199.99m, false, null, 6, 50.00m },
                    { 2, 243, 17.42m, 1, 499.99m, false, null, 6, 200.00m },
                    { 2, 244, 12.44m, 1, 999.99m, false, null, 6, 500.00m },
                    { 2, 245, 9.95m, 1, 2499.99m, false, null, 6, 1000.00m },
                    { 2, 246, 8.71m, 1, 4999.99m, false, null, 6, 2500.00m },
                    { 2, 247, 8.09m, 1, 9999.99m, false, null, 6, 5000.00m },
                    { 2, 248, 7.46m, 1, 19999.99m, false, null, 6, 10000.00m },
                    { 2, 249, 6.22m, 1, 39999.99m, false, null, 6, 20000.00m },
                    { 2, 250, 5.6m, 1, 74999.99m, false, null, 6, 40000.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "CurrencyID", "ID", "Oran", "AddedById", "EndPrice", "IsDeleted", "ModifiedById", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 2, 251, 5.23m, 1, 99999.99m, false, null, 6, 75000.00m },
                    { 2, 252, 4.98m, 1, 149999.99m, false, null, 6, 100000.00m },
                    { 2, 253, 3.73m, 1, 249999.99m, false, null, 6, 150000.00m },
                    { 2, 254, 3.11m, 1, 499999.99m, false, null, 6, 250000.00m },
                    { 2, 255, 2.74m, 1, 999999.99m, false, null, 6, 500000.00m },
                    { 2, 256, 2.49m, 1, 99999999.99m, false, null, 6, 1000000.00m },
                    { 2, 257, 44.79m, 1, 49.99m, false, null, 7, 0.00m },
                    { 2, 258, 26.87m, 1, 199.99m, false, null, 7, 50.00m },
                    { 2, 259, 20.9m, 1, 499.99m, false, null, 7, 200.00m },
                    { 2, 260, 14.93m, 1, 999.99m, false, null, 7, 500.00m },
                    { 2, 261, 11.94m, 1, 2499.99m, false, null, 7, 1000.00m },
                    { 2, 262, 10.45m, 1, 4999.99m, false, null, 7, 2500.00m },
                    { 2, 263, 9.7m, 1, 9999.99m, false, null, 7, 5000.00m },
                    { 2, 264, 8.96m, 1, 19999.99m, false, null, 7, 10000.00m },
                    { 2, 265, 7.46m, 1, 39999.99m, false, null, 7, 20000.00m },
                    { 2, 266, 6.72m, 1, 74999.99m, false, null, 7, 40000.00m },
                    { 2, 267, 6.27m, 1, 99999.99m, false, null, 7, 75000.00m },
                    { 2, 268, 5.97m, 1, 149999.99m, false, null, 7, 100000.00m },
                    { 2, 269, 4.48m, 1, 249999.99m, false, null, 7, 150000.00m },
                    { 2, 270, 3.73m, 1, 499999.99m, false, null, 7, 250000.00m },
                    { 2, 271, 3.28m, 1, 999999.99m, false, null, 7, 500000.00m },
                    { 2, 272, 2.99m, 1, 99999999.99m, false, null, 7, 1000000.00m },
                    { 2, 273, 53.75m, 1, 49.99m, false, null, 8, 0.00m },
                    { 2, 274, 32.25m, 1, 199.99m, false, null, 8, 50.00m },
                    { 2, 275, 25.08m, 1, 499.99m, false, null, 8, 200.00m },
                    { 2, 276, 17.92m, 1, 999.99m, false, null, 8, 500.00m },
                    { 2, 277, 14.33m, 1, 2499.99m, false, null, 8, 1000.00m },
                    { 2, 278, 12.54m, 1, 4999.99m, false, null, 8, 2500.00m },
                    { 2, 279, 11.65m, 1, 9999.99m, false, null, 8, 5000.00m },
                    { 2, 280, 10.75m, 1, 19999.99m, false, null, 8, 10000.00m },
                    { 2, 281, 8.96m, 1, 39999.99m, false, null, 8, 20000.00m },
                    { 2, 282, 8.06m, 1, 74999.99m, false, null, 8, 40000.00m },
                    { 2, 283, 7.52m, 1, 99999.99m, false, null, 8, 75000.00m },
                    { 2, 284, 7.17m, 1, 149999.99m, false, null, 8, 100000.00m },
                    { 2, 285, 5.37m, 1, 249999.99m, false, null, 8, 150000.00m },
                    { 2, 286, 4.48m, 1, 499999.99m, false, null, 8, 250000.00m },
                    { 2, 287, 3.94m, 1, 999999.99m, false, null, 8, 500000.00m },
                    { 2, 288, 3.58m, 1, 99999999.99m, false, null, 8, 1000000.00m },
                    { 2, 289, 64.5m, 1, 49.99m, false, null, 9, 0.00m },
                    { 2, 290, 38.7m, 1, 199.99m, false, null, 9, 50.00m },
                    { 2, 291, 30.1m, 1, 499.99m, false, null, 9, 200.00m },
                    { 2, 292, 21.5m, 1, 999.99m, false, null, 9, 500.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "CurrencyID", "ID", "Oran", "AddedById", "EndPrice", "IsDeleted", "ModifiedById", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 2, 293, 17.2m, 1, 2499.99m, false, null, 9, 1000.00m },
                    { 2, 294, 15.05m, 1, 4999.99m, false, null, 9, 2500.00m },
                    { 2, 295, 13.97m, 1, 9999.99m, false, null, 9, 5000.00m },
                    { 2, 296, 12.9m, 1, 19999.99m, false, null, 9, 10000.00m },
                    { 2, 297, 10.75m, 1, 39999.99m, false, null, 9, 20000.00m },
                    { 2, 298, 9.67m, 1, 74999.99m, false, null, 9, 40000.00m },
                    { 2, 299, 9.03m, 1, 99999.99m, false, null, 9, 75000.00m },
                    { 2, 300, 8.6m, 1, 149999.99m, false, null, 9, 100000.00m },
                    { 2, 301, 6.45m, 1, 249999.99m, false, null, 9, 150000.00m },
                    { 2, 302, 5.37m, 1, 499999.99m, false, null, 9, 250000.00m },
                    { 2, 303, 4.73m, 1, 999999.99m, false, null, 9, 500000.00m },
                    { 2, 304, 4.3m, 1, 99999999.99m, false, null, 9, 1000000.00m },
                    { 2, 305, 77.4m, 1, 49.99m, false, null, 10, 0.00m },
                    { 2, 306, 48.37m, 1, 199.99m, false, null, 10, 50.00m },
                    { 2, 307, 39.13m, 1, 499.99m, false, null, 10, 200.00m },
                    { 2, 308, 29.02m, 1, 999.99m, false, null, 10, 500.00m },
                    { 2, 309, 24.08m, 1, 2499.99m, false, null, 10, 1000.00m },
                    { 2, 310, 21.82m, 1, 4999.99m, false, null, 10, 2500.00m },
                    { 2, 311, 20.96m, 1, 9999.99m, false, null, 10, 5000.00m },
                    { 2, 312, 19.99m, 1, 19999.99m, false, null, 10, 10000.00m },
                    { 2, 313, 17.2m, 1, 39999.99m, false, null, 10, 20000.00m },
                    { 2, 314, 15.96m, 1, 74999.99m, false, null, 10, 40000.00m },
                    { 2, 315, 15.35m, 1, 99999.99m, false, null, 10, 75000.00m },
                    { 2, 316, 15.05m, 1, 149999.99m, false, null, 10, 100000.00m },
                    { 2, 317, 11.61m, 1, 249999.99m, false, null, 10, 150000.00m },
                    { 2, 318, 9.94m, 1, 499999.99m, false, null, 10, 250000.00m },
                    { 2, 319, 8.99m, 1, 999999.99m, false, null, 10, 500000.00m },
                    { 2, 320, 5.96m, 1, 99999999.99m, false, null, 10, 1000000.00m },
                    { 3, 321, 13.5m, 1, 49.99m, false, null, 1, 0.00m },
                    { 3, 322, 8.1m, 1, 199.99m, false, null, 1, 50.00m },
                    { 3, 323, 6.3m, 1, 499.99m, false, null, 1, 200.00m },
                    { 3, 324, 4.5m, 1, 999.99m, false, null, 1, 500.00m },
                    { 3, 325, 3.6m, 1, 2499.99m, false, null, 1, 1000.00m },
                    { 3, 326, 3.15m, 1, 4999.99m, false, null, 1, 2500.00m },
                    { 3, 327, 2.93m, 1, 9999.99m, false, null, 1, 5000.00m },
                    { 3, 328, 2.7m, 1, 19999.99m, false, null, 1, 10000.00m },
                    { 3, 329, 2.25m, 1, 39999.99m, false, null, 1, 20000.00m },
                    { 3, 330, 2.03m, 1, 74999.99m, false, null, 1, 40000.00m },
                    { 3, 331, 1.89m, 1, 99999.99m, false, null, 1, 75000.00m },
                    { 3, 332, 1.8m, 1, 149999.99m, false, null, 1, 100000.00m },
                    { 3, 333, 1.35m, 1, 249999.99m, false, null, 1, 150000.00m },
                    { 3, 334, 1.13m, 1, 499999.99m, false, null, 1, 250000.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "CurrencyID", "ID", "Oran", "AddedById", "EndPrice", "IsDeleted", "ModifiedById", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 3, 335, 0.99m, 1, 999999.99m, false, null, 1, 500000.00m },
                    { 3, 336, 0.9m, 1, 99999999.99m, false, null, 1, 1000000.00m },
                    { 3, 337, 16.2m, 1, 49.99m, false, null, 2, 0.00m },
                    { 3, 338, 9.72m, 1, 199.99m, false, null, 2, 50.00m },
                    { 3, 339, 7.56m, 1, 499.99m, false, null, 2, 200.00m },
                    { 3, 340, 5.4m, 1, 999.99m, false, null, 2, 500.00m },
                    { 3, 341, 4.32m, 1, 2499.99m, false, null, 2, 1000.00m },
                    { 3, 342, 3.78m, 1, 4999.99m, false, null, 2, 2500.00m },
                    { 3, 343, 3.51m, 1, 9999.99m, false, null, 2, 5000.00m },
                    { 3, 344, 3.24m, 1, 19999.99m, false, null, 2, 10000.00m },
                    { 3, 345, 2.7m, 1, 39999.99m, false, null, 2, 20000.00m },
                    { 3, 346, 2.43m, 1, 74999.99m, false, null, 2, 40000.00m },
                    { 3, 347, 2.27m, 1, 99999.99m, false, null, 2, 75000.00m },
                    { 3, 348, 2.16m, 1, 149999.99m, false, null, 2, 100000.00m },
                    { 3, 349, 1.62m, 1, 249999.99m, false, null, 2, 150000.00m },
                    { 3, 350, 1.35m, 1, 499999.99m, false, null, 2, 250000.00m },
                    { 3, 351, 1.19m, 1, 999999.99m, false, null, 2, 500000.00m },
                    { 3, 352, 1.08m, 1, 99999999.99m, false, null, 2, 1000000.00m },
                    { 3, 353, 19.44m, 1, 49.99m, false, null, 3, 0.00m },
                    { 3, 354, 11.66m, 1, 199.99m, false, null, 3, 50.00m },
                    { 3, 355, 9.07m, 1, 499.99m, false, null, 3, 200.00m },
                    { 3, 356, 6.48m, 1, 999.99m, false, null, 3, 500.00m },
                    { 3, 357, 5.18m, 1, 2499.99m, false, null, 3, 1000.00m },
                    { 3, 358, 4.54m, 1, 4999.99m, false, null, 3, 2500.00m },
                    { 3, 359, 4.21m, 1, 9999.99m, false, null, 3, 5000.00m },
                    { 3, 360, 3.89m, 1, 19999.99m, false, null, 3, 10000.00m },
                    { 3, 361, 3.24m, 1, 39999.99m, false, null, 3, 20000.00m },
                    { 3, 362, 2.92m, 1, 74999.99m, false, null, 3, 40000.00m },
                    { 3, 363, 2.72m, 1, 99999.99m, false, null, 3, 75000.00m },
                    { 3, 364, 2.59m, 1, 149999.99m, false, null, 3, 100000.00m },
                    { 3, 365, 1.94m, 1, 249999.99m, false, null, 3, 150000.00m },
                    { 3, 366, 1.62m, 1, 499999.99m, false, null, 3, 250000.00m },
                    { 3, 367, 1.43m, 1, 999999.99m, false, null, 3, 500000.00m },
                    { 3, 368, 1.3m, 1, 99999999.99m, false, null, 3, 1000000.00m },
                    { 3, 369, 23.33m, 1, 49.99m, false, null, 4, 0.00m },
                    { 3, 370, 14m, 1, 199.99m, false, null, 4, 50.00m },
                    { 3, 371, 10.89m, 1, 499.99m, false, null, 4, 200.00m },
                    { 3, 372, 7.78m, 1, 999.99m, false, null, 4, 500.00m },
                    { 3, 373, 6.22m, 1, 2499.99m, false, null, 4, 1000.00m },
                    { 3, 374, 5.44m, 1, 4999.99m, false, null, 4, 2500.00m },
                    { 3, 375, 5.05m, 1, 9999.99m, false, null, 4, 5000.00m },
                    { 3, 376, 4.67m, 1, 19999.99m, false, null, 4, 10000.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "CurrencyID", "ID", "Oran", "AddedById", "EndPrice", "IsDeleted", "ModifiedById", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 3, 377, 3.89m, 1, 39999.99m, false, null, 4, 20000.00m },
                    { 3, 378, 3.5m, 1, 74999.99m, false, null, 4, 40000.00m },
                    { 3, 379, 3.27m, 1, 99999.99m, false, null, 4, 75000.00m },
                    { 3, 380, 3.11m, 1, 149999.99m, false, null, 4, 100000.00m },
                    { 3, 381, 2.33m, 1, 249999.99m, false, null, 4, 150000.00m },
                    { 3, 382, 1.9m, 1, 499999.99m, false, null, 4, 250000.00m },
                    { 3, 383, 1.71m, 1, 999999.99m, false, null, 4, 500000.00m },
                    { 3, 384, 1.56m, 1, 99999999.99m, false, null, 4, 1000000.00m },
                    { 3, 385, 27.99m, 1, 49.99m, false, null, 5, 0.00m },
                    { 3, 386, 16.8m, 1, 199.99m, false, null, 5, 50.00m },
                    { 3, 387, 13.06m, 1, 499.99m, false, null, 5, 200.00m },
                    { 3, 388, 9.33m, 1, 999.99m, false, null, 5, 500.00m },
                    { 3, 389, 7.46m, 1, 2499.99m, false, null, 5, 1000.00m },
                    { 3, 390, 6.53m, 1, 4999.99m, false, null, 5, 2500.00m },
                    { 3, 391, 6.07m, 1, 9999.99m, false, null, 5, 5000.00m },
                    { 3, 392, 5.6m, 1, 19999.99m, false, null, 5, 10000.00m },
                    { 3, 393, 4.67m, 1, 39999.99m, false, null, 5, 20000.00m },
                    { 3, 394, 4.2m, 1, 74999.99m, false, null, 5, 40000.00m },
                    { 3, 395, 3.92m, 1, 99999.99m, false, null, 5, 75000.00m },
                    { 3, 396, 3.73m, 1, 149999.99m, false, null, 5, 100000.00m },
                    { 3, 397, 2.8m, 1, 249999.99m, false, null, 5, 150000.00m },
                    { 3, 398, 2.33m, 1, 499999.99m, false, null, 5, 250000.00m },
                    { 3, 399, 2.05m, 1, 999999.99m, false, null, 5, 500000.00m },
                    { 3, 400, 1.87m, 1, 99999999.99m, false, null, 5, 1000000.00m },
                    { 3, 401, 33.59m, 1, 49.99m, false, null, 6, 0.00m },
                    { 3, 402, 20.16m, 1, 199.99m, false, null, 6, 50.00m },
                    { 3, 403, 15.68m, 1, 499.99m, false, null, 6, 200.00m },
                    { 3, 404, 11.2m, 1, 999.99m, false, null, 6, 500.00m },
                    { 3, 405, 8.96m, 1, 2499.99m, false, null, 6, 1000.00m },
                    { 3, 406, 7.84m, 1, 4999.99m, false, null, 6, 2500.00m },
                    { 3, 407, 7.28m, 1, 9999.99m, false, null, 6, 5000.00m },
                    { 3, 408, 6.72m, 1, 19999.99m, false, null, 6, 10000.00m },
                    { 3, 409, 5.6m, 1, 39999.99m, false, null, 6, 20000.00m },
                    { 3, 410, 5.04m, 1, 74999.99m, false, null, 6, 40000.00m },
                    { 3, 411, 4.7m, 1, 99999.99m, false, null, 6, 75000.00m },
                    { 3, 412, 4.48m, 1, 149999.99m, false, null, 6, 100000.00m },
                    { 3, 413, 3.36m, 1, 249999.99m, false, null, 6, 150000.00m },
                    { 3, 414, 2.8m, 1, 499999.99m, false, null, 6, 250000.00m },
                    { 3, 415, 2.46m, 1, 999999.99m, false, null, 6, 500000.00m },
                    { 3, 416, 2.24m, 1, 99999999.99m, false, null, 6, 1000000.00m },
                    { 3, 417, 40.31m, 1, 49.99m, false, null, 7, 0.00m },
                    { 3, 418, 24.19m, 1, 199.99m, false, null, 7, 50.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "CurrencyID", "ID", "Oran", "AddedById", "EndPrice", "IsDeleted", "ModifiedById", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 3, 419, 18.81m, 1, 499.99m, false, null, 7, 200.00m },
                    { 3, 420, 13.44m, 1, 999.99m, false, null, 7, 500.00m },
                    { 3, 421, 10.75m, 1, 2499.99m, false, null, 7, 1000.00m },
                    { 3, 422, 9.41m, 1, 4999.99m, false, null, 7, 2500.00m },
                    { 3, 423, 8.73m, 1, 9999.99m, false, null, 7, 5000.00m },
                    { 3, 424, 8.06m, 1, 19999.99m, false, null, 7, 10000.00m },
                    { 3, 425, 6.72m, 1, 39999.99m, false, null, 7, 20000.00m },
                    { 3, 426, 6.05m, 1, 74999.99m, false, null, 7, 40000.00m },
                    { 3, 427, 5.64m, 1, 99999.99m, false, null, 7, 75000.00m },
                    { 3, 428, 5.37m, 1, 149999.99m, false, null, 7, 100000.00m },
                    { 3, 429, 4.03m, 1, 249999.99m, false, null, 7, 150000.00m },
                    { 3, 430, 3.36m, 1, 499999.99m, false, null, 7, 250000.00m },
                    { 3, 431, 2.96m, 1, 999999.99m, false, null, 7, 500000.00m },
                    { 3, 432, 2.69m, 1, 99999999.99m, false, null, 7, 1000000.00m },
                    { 3, 433, 48.37m, 1, 49.99m, false, null, 8, 0.00m },
                    { 3, 434, 29.02m, 1, 199.99m, false, null, 8, 50.00m },
                    { 3, 435, 22.57m, 1, 499.99m, false, null, 8, 200.00m },
                    { 3, 436, 16.12m, 1, 999.99m, false, null, 8, 500.00m },
                    { 3, 437, 12.9m, 1, 2499.99m, false, null, 8, 1000.00m },
                    { 3, 438, 11.29m, 1, 4999.99m, false, null, 8, 2500.00m },
                    { 3, 439, 10.48m, 1, 9999.99m, false, null, 8, 5000.00m },
                    { 3, 440, 9.67m, 1, 19999.99m, false, null, 8, 10000.00m },
                    { 3, 441, 8.06m, 1, 39999.99m, false, null, 8, 20000.00m },
                    { 3, 442, 7.26m, 1, 74999.99m, false, null, 8, 40000.00m },
                    { 3, 443, 6.77m, 1, 99999.99m, false, null, 8, 75000.00m },
                    { 3, 444, 6.45m, 1, 149999.99m, false, null, 8, 100000.00m },
                    { 3, 445, 4.84m, 1, 249999.99m, false, null, 8, 150000.00m },
                    { 3, 446, 4.03m, 1, 499999.99m, false, null, 8, 250000.00m },
                    { 3, 447, 3.55m, 1, 999999.99m, false, null, 8, 500000.00m },
                    { 3, 448, 3.22m, 1, 99999999.99m, false, null, 8, 1000000.00m },
                    { 3, 449, 58.05m, 1, 49.99m, false, null, 9, 0.00m },
                    { 3, 450, 34.83m, 1, 199.99m, false, null, 9, 50.00m },
                    { 3, 451, 27.09m, 1, 499.99m, false, null, 9, 200.00m },
                    { 3, 452, 19.35m, 1, 999.99m, false, null, 9, 500.00m },
                    { 3, 453, 15.48m, 1, 2499.99m, false, null, 9, 1000.00m },
                    { 3, 454, 13.54m, 1, 4999.99m, false, null, 9, 2500.00m },
                    { 3, 455, 12.58m, 1, 9999.99m, false, null, 9, 5000.00m },
                    { 3, 456, 11.61m, 1, 19999.99m, false, null, 9, 10000.00m },
                    { 3, 457, 9.67m, 1, 39999.99m, false, null, 9, 20000.00m },
                    { 3, 458, 8.71m, 1, 74999.99m, false, null, 9, 40000.00m },
                    { 3, 459, 8.13m, 1, 99999.99m, false, null, 9, 75000.00m },
                    { 3, 460, 7.74m, 1, 149999.99m, false, null, 9, 100000.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "CurrencyID", "ID", "Oran", "AddedById", "EndPrice", "IsDeleted", "ModifiedById", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 3, 461, 5.8m, 1, 249999.99m, false, null, 9, 150000.00m },
                    { 3, 462, 4.84m, 1, 499999.99m, false, null, 9, 250000.00m },
                    { 3, 463, 4.26m, 1, 999999.99m, false, null, 9, 500000.00m },
                    { 3, 464, 3.87m, 1, 99999999.99m, false, null, 9, 1000000.00m },
                    { 3, 465, 69.66m, 1, 49.99m, false, null, 10, 0.00m },
                    { 3, 466, 43.54m, 1, 199.99m, false, null, 10, 50.00m },
                    { 3, 467, 35.22m, 1, 499.99m, false, null, 10, 200.00m },
                    { 3, 468, 26.12m, 1, 999.99m, false, null, 10, 500.00m },
                    { 3, 469, 21.67m, 1, 2499.99m, false, null, 10, 1000.00m },
                    { 3, 470, 19.64m, 1, 4999.99m, false, null, 10, 2500.00m },
                    { 3, 471, 18.87m, 1, 9999.99m, false, null, 10, 5000.00m },
                    { 3, 472, 17.99m, 1, 19999.99m, false, null, 10, 10000.00m },
                    { 3, 473, 15.48m, 1, 39999.99m, false, null, 10, 20000.00m },
                    { 3, 474, 14.37m, 1, 74999.99m, false, null, 10, 40000.00m },
                    { 3, 475, 13.82m, 1, 99999.99m, false, null, 10, 75000.00m },
                    { 3, 476, 13.54m, 1, 149999.99m, false, null, 10, 100000.00m },
                    { 3, 477, 10.45m, 1, 249999.99m, false, null, 10, 150000.00m },
                    { 3, 478, 8.05m, 1, 499999.99m, false, null, 10, 250000.00m },
                    { 3, 479, 8.09m, 1, 999999.99m, false, null, 10, 500000.00m },
                    { 3, 480, 7.55m, 1, 99999999.99m, false, null, 10, 1000000.00m }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "AddedById", "Discriminator", "EndDate", "Id", "IsDeleted", "ModifiedById", "StartDate" },
                values: new object[] { 1, 1, 1, "AppRolesOfUsers", new DateTime(2032, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7906), 0, false, null, new DateTime(2022, 6, 30, 11, 58, 53, 428, DateTimeKind.Local).AddTicks(7905) });

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_AddedById",
                table: "Announcements",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_ModifiedById",
                table: "Announcements",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_AppAuthorizationsRoleGroups_AddedById",
                table: "AppAuthorizationsRoleGroups",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_AppAuthorizationsRoleGroups_ModifiedById",
                table: "AppAuthorizationsRoleGroups",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_AddedById",
                table: "AspNetRoles",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_ModifiedById",
                table: "AspNetRoles",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_RoleGroupId",
                table: "AspNetRoles",
                column: "RoleGroupId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_AddedById",
                table: "AspNetUserRoles",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_ModifiedById",
                table: "AspNetUserRoles",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AddedById",
                table: "AspNetUsers",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ModifiedById",
                table: "AspNetUsers",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserCompanyID",
                table: "AspNetUsers",
                column: "UserCompanyID");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BankInformations_AddedById",
                table: "BankInformations",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_BankInformations_BankID",
                table: "BankInformations",
                column: "BankID");

            migrationBuilder.CreateIndex(
                name: "IX_BankInformations_CompanyID",
                table: "BankInformations",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_BankInformations_ModifiedById",
                table: "BankInformations",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Banks_AddedById",
                table: "Banks",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_Banks_ModifiedById",
                table: "Banks",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Birims_AddedById",
                table: "Birims",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_Birims_ModifiedById",
                table: "Birims",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_AddedById",
                table: "Brands",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_ModifiedById",
                table: "Brands",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionReceipts_AddedById",
                table: "CollectionReceipts",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionReceipts_CurrencyID",
                table: "CollectionReceipts",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionReceipts_CustomerID",
                table: "CollectionReceipts",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionReceipts_ModifiedById",
                table: "CollectionReceipts",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionReceipts_PaymentTypeID",
                table: "CollectionReceipts",
                column: "PaymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionReceipts_SupplierID",
                table: "CollectionReceipts",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Currencies_AddedById",
                table: "Currencies",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_Currencies_ModifiedById",
                table: "Currencies",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerActivityLogs_AddedById",
                table: "CustomerActivityLogs",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerActivityLogs_CustomerId",
                table: "CustomerActivityLogs",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerActivityLogs_ModifiedById",
                table: "CustomerActivityLogs",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddresses_AddedById",
                table: "CustomerAddresses",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddresses_CustomerID",
                table: "CustomerAddresses",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddresses_ModifiedById",
                table: "CustomerAddresses",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBillingAddresses_AddedById",
                table: "CustomerBillingAddresses",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBillingAddresses_CustomerID",
                table: "CustomerBillingAddresses",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBillingAddresses_ModifiedById",
                table: "CustomerBillingAddresses",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerContacts_AddedById",
                table: "CustomerContacts",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerContacts_CustomerID",
                table: "CustomerContacts",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerContacts_ModifiedById",
                table: "CustomerContacts",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerMainCompanies_AddedById",
                table: "CustomerMainCompanies",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerMainCompanies_ModifiedById",
                table: "CustomerMainCompanies",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRepresentetiveUsers_AddedById",
                table: "CustomerRepresentetiveUsers",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRepresentetiveUsers_CustomerID",
                table: "CustomerRepresentetiveUsers",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRepresentetiveUsers_ModifiedById",
                table: "CustomerRepresentetiveUsers",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRepresentetiveUsers_UserID",
                table: "CustomerRepresentetiveUsers",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AddedById",
                table: "Customers",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerMainCompanyId",
                table: "Customers",
                column: "CustomerMainCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ModifiedById",
                table: "Customers",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PreferredCurrencyId",
                table: "Customers",
                column: "PreferredCurrencyId");

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
                name: "IX_CustomerTypes_AddedById",
                table: "CustomerTypes",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTypes_ModifiedById",
                table: "CustomerTypes",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_AddedById",
                table: "Departments",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ModifiedById",
                table: "Departments",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentsOfUsers_AddedById",
                table: "DepartmentsOfUsers",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentsOfUsers_DepartmentID",
                table: "DepartmentsOfUsers",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentsOfUsers_ModifiedById",
                table: "DepartmentsOfUsers",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentsOfUsers_UserID",
                table: "DepartmentsOfUsers",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_DepositRelations_AddedById",
                table: "DepositRelations",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_DepositRelations_ModifiedById",
                table: "DepositRelations",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Deposits_AddedById",
                table: "Deposits",
                column: "AddedById");

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
                name: "IX_Deposits_ModifiedById",
                table: "Deposits",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_DepositTypes_AddedById",
                table: "DepositTypes",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_DepositTypes_ModifiedById",
                table: "DepositTypes",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountCupons_AddedById",
                table: "DiscountCupons",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountCupons_CuponCurrencyID",
                table: "DiscountCupons",
                column: "CuponCurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountCupons_ModifiedById",
                table: "DiscountCupons",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountCuponsOfCustomers_AddedById",
                table: "DiscountCuponsOfCustomers",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountCuponsOfCustomers_CustomerID",
                table: "DiscountCuponsOfCustomers",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountCuponsOfCustomers_DiscountCuponID",
                table: "DiscountCuponsOfCustomers",
                column: "DiscountCuponID");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountCuponsOfCustomers_ModifiedById",
                table: "DiscountCuponsOfCustomers",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_AddedById",
                table: "Documents",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_ModifiedById",
                table: "Documents",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_TypeID",
                table: "Documents",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentTypes_AddedById",
                table: "DocumentTypes",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentTypes_ModifiedById",
                table: "DocumentTypes",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplates_AddedById",
                table: "EmailTemplates",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplates_DepartmentID",
                table: "EmailTemplates",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplates_ModifiedById",
                table: "EmailTemplates",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Expansions_AddedById",
                table: "Expansions",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_Expansions_ModifiedById",
                table: "Expansions",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceBills_AddedById",
                table: "MaintenanceBills",
                column: "AddedById");

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
                name: "IX_MaintenanceBills_ModifiedById",
                table: "MaintenanceBills",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceBills_ProductGroupID",
                table: "MaintenanceBills",
                column: "ProductGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceBills_SellingRepresentetiveUserID",
                table: "MaintenanceBills",
                column: "SellingRepresentetiveUserID");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenencePeriods_AddedById",
                table: "MaintenencePeriods",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenencePeriods_ModifiedById",
                table: "MaintenencePeriods",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_MarketPlaces_AddedById",
                table: "MarketPlaces",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_MarketPlaces_ModifiedById",
                table: "MarketPlaces",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_MarketPlacesOfSuppliers_MarketPlaceID",
                table: "MarketPlacesOfSuppliers",
                column: "MarketPlaceID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AddedById",
                table: "Orders",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ModifiedById",
                table: "Orders",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderStateID",
                table: "Orders",
                column: "OrderStateID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_RepresentetiveUserId",
                table: "Orders",
                column: "RepresentetiveUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SelectedCustomerAddressId",
                table: "Orders",
                column: "SelectedCustomerAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SelectedCustomerBillingAddressId",
                table: "Orders",
                column: "SelectedCustomerBillingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProductCurrencies_AddedById",
                table: "OrdersProductCurrencies",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProductCurrencies_CurrencyID",
                table: "OrdersProductCurrencies",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProductCurrencies_ModifiedById",
                table: "OrdersProductCurrencies",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProductCurrencies_OrdersProductId1_OrdersProductOrderId_OrdersProductProductId",
                table: "OrdersProductCurrencies",
                columns: new[] { "OrdersProductId1", "OrdersProductOrderId", "OrdersProductProductId" });

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProducts_AddedById",
                table: "OrdersProducts",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProducts_BirimID",
                table: "OrdersProducts",
                column: "BirimID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProducts_CurrencyId",
                table: "OrdersProducts",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProducts_KesinCurrencyID",
                table: "OrdersProducts",
                column: "KesinCurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProducts_KesinSupplierID",
                table: "OrdersProducts",
                column: "KesinSupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProducts_ModifiedById",
                table: "OrdersProducts",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProducts_OrderID",
                table: "OrdersProducts",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProducts_OrderStateId",
                table: "OrdersProducts",
                column: "OrderStateId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProducts_ProductID",
                table: "OrdersProducts",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProducts_ReferansCurrencyID",
                table: "OrdersProducts",
                column: "ReferansCurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProducts_ReferansSupplierID",
                table: "OrdersProducts",
                column: "ReferansSupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderStates_AddedById",
                table: "OrderStates",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_OrderStates_ModifiedById",
                table: "OrderStates",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTypes_AddedById",
                table: "PaymentTypes",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTypes_ModifiedById",
                table: "PaymentTypes",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_AddedById",
                table: "ProductCategories",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_ModifiedById",
                table: "ProductCategories",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_ProductGroupID",
                table: "ProductCategories",
                column: "ProductGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroups_AddedById",
                table: "ProductGroups",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroups_ModifiedById",
                table: "ProductGroups",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroupsFAQs_AddedById",
                table: "ProductGroupsFAQs",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroupsFAQs_ModifiedById",
                table: "ProductGroupsFAQs",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroupsFAQs_ProductGroupID",
                table: "ProductGroupsFAQs",
                column: "ProductGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroupsOfSuppliers_ProductGroupID",
                table: "ProductGroupsOfSuppliers",
                column: "ProductGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_AddedById",
                table: "Products",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ModifiedById",
                table: "Products",
                column: "ModifiedById");

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
                name: "IX_ReturnAndFaults_AddedById",
                table: "ReturnAndFaults",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnAndFaults_CurrentStateID",
                table: "ReturnAndFaults",
                column: "CurrentStateID");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnAndFaults_ModifiedById",
                table: "ReturnAndFaults",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnAndFaults_RepresentitveUser",
                table: "ReturnAndFaults",
                column: "RepresentitveUser");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnAndFaultStates_AddedById",
                table: "ReturnAndFaultStates",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnAndFaultStates_ModifiedById",
                table: "ReturnAndFaultStates",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Rules_AddedById",
                table: "Rules",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_Rules_ModifiedById",
                table: "Rules",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Sectors_AddedById",
                table: "Sectors",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_Sectors_ModifiedById",
                table: "Sectors",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_SegmentOrans_AddedById",
                table: "SegmentOrans",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_SegmentOrans_CurrencyID",
                table: "SegmentOrans",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_SegmentOrans_ModifiedById",
                table: "SegmentOrans",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_SegmentOrans_SegmentID",
                table: "SegmentOrans",
                column: "SegmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Segments_AddedById",
                table: "Segments",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_Segments_ModifiedById",
                table: "Segments",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_SellsAndBuysAssets_AddedById",
                table: "SellsAndBuysAssets",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_SellsAndBuysAssets_CurrentStepID",
                table: "SellsAndBuysAssets",
                column: "CurrentStepID");

            migrationBuilder.CreateIndex(
                name: "IX_SellsAndBuysAssets_ModifiedById",
                table: "SellsAndBuysAssets",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_SellsAndBuysAssets_SABCategoryID",
                table: "SellsAndBuysAssets",
                column: "SABCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_SellsAndBuysCategories_AddedById",
                table: "SellsAndBuysCategories",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_SellsAndBuysCategories_ModifiedById",
                table: "SellsAndBuysCategories",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_SellsAndBuysGuideSteps_AddedById",
                table: "SellsAndBuysGuideSteps",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_SellsAndBuysGuideSteps_ModifiedById",
                table: "SellsAndBuysGuideSteps",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_SellsAndBuysGuideSteps_SABCategoryID",
                table: "SellsAndBuysGuideSteps",
                column: "SABCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ServicePlaces_AddedById",
                table: "ServicePlaces",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_ServicePlaces_ModifiedById",
                table: "ServicePlaces",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceReasons_AddedById",
                table: "ServiceReasons",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceReasons_ModifiedById",
                table: "ServiceReasons",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRecords_AddedById",
                table: "ServiceRecords",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRecords_CustomerID",
                table: "ServiceRecords",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRecords_ModifiedById",
                table: "ServiceRecords",
                column: "ModifiedById");

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
                name: "IX_ServiceTypes_AddedById",
                table: "ServiceTypes",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceTypes_ModifiedById",
                table: "ServiceTypes",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingDeals_AddedById",
                table: "ShippingDeals",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingDeals_CompanyID",
                table: "ShippingDeals",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingDeals_ModifiedById",
                table: "ShippingDeals",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierDetails_AddedById",
                table: "SupplierDetails",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierDetails_CurrencyID",
                table: "SupplierDetails",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierDetails_ModifiedById",
                table: "SupplierDetails",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierDetails_SupplierID",
                table: "SupplierDetails",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPaymentStates_AddedById",
                table: "SupplierPaymentStates",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPaymentStates_ModifiedById",
                table: "SupplierPaymentStates",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_AddedById",
                table: "Suppliers",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_ModifiedById",
                table: "Suppliers",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliersBrands_SupplierID",
                table: "SuppliersBrands",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliersPayments_AddedById",
                table: "SuppliersPayments",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliersPayments_ModifiedById",
                table: "SuppliersPayments",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliersPayments_StateID",
                table: "SuppliersPayments",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_UserCompanies_AddedById",
                table: "UserCompanies",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_UserCompanies_ModifiedById",
                table: "UserCompanies",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleInformations_AddedById",
                table: "VehicleInformations",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleInformations_ModifiedById",
                table: "VehicleInformations",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleInformations_UserCompanyID",
                table: "VehicleInformations",
                column: "UserCompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_WarrantyTrackings_AddedById",
                table: "WarrantyTrackings",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_WarrantyTrackings_BrandID",
                table: "WarrantyTrackings",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_WarrantyTrackings_ModifiedById",
                table: "WarrantyTrackings",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_WorkStandarts_AddedById",
                table: "WorkStandarts",
                column: "AddedById");

            migrationBuilder.CreateIndex(
                name: "IX_WorkStandarts_DepartmentID",
                table: "WorkStandarts",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkStandarts_ModifiedById",
                table: "WorkStandarts",
                column: "ModifiedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Announcements_Users",
                table: "Announcements",
                column: "AddedById",
                principalTable: "AspNetUsers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Announcements_Users1",
                table: "Announcements",
                column: "ModifiedById",
                principalTable: "AspNetUsers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorizationRoleGroup_ModifiedBy",
                table: "AppAuthorizationsRoleGroups",
                column: "ModifiedById",
                principalTable: "AspNetUsers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorizationRoleGroups_AddedBy",
                table: "AppAuthorizationsRoleGroups",
                column: "AddedById",
                principalTable: "AspNetUsers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Authorizations_Users",
                table: "AspNetRoles",
                column: "AddedById",
                principalTable: "AspNetUsers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Authorizations_Users1",
                table: "AspNetRoles",
                column: "ModifiedById",
                principalTable: "AspNetUsers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersAuthorizations_AddedBy",
                table: "AspNetUserRoles",
                column: "AddedById",
                principalTable: "AspNetUsers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersAuthorizations_ModifiedBy",
                table: "AspNetUserRoles",
                column: "ModifiedById",
                principalTable: "AspNetUsers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserCompanies",
                table: "AspNetUsers",
                column: "UserCompanyID",
                principalTable: "UserCompanies",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCompanies_AddedBy",
                table: "UserCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCompanies_ModifiedBy",
                table: "UserCompanies");

            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AutoHistory");

            migrationBuilder.DropTable(
                name: "BankInformations");

            migrationBuilder.DropTable(
                name: "CollectionReceipts");

            migrationBuilder.DropTable(
                name: "CustomerActivityLogs");

            migrationBuilder.DropTable(
                name: "CustomerContacts");

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
                name: "OrdersProductCurrencies");

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
                name: "VehicleInformations");

            migrationBuilder.DropTable(
                name: "WarrantyTrackings");

            migrationBuilder.DropTable(
                name: "WorkStandarts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

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
                name: "OrdersProducts");

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
                name: "SupplierPaymentStates");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "AppAuthorizationsRoleGroups");

            migrationBuilder.DropTable(
                name: "Birims");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "SellsAndBuysCategories");

            migrationBuilder.DropTable(
                name: "CustomerAddresses");

            migrationBuilder.DropTable(
                name: "CustomerBillingAddresses");

            migrationBuilder.DropTable(
                name: "OrderStates");

            migrationBuilder.DropTable(
                name: "ProductGroups");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "CustomerMainCompanies");

            migrationBuilder.DropTable(
                name: "CustomerTypes");

            migrationBuilder.DropTable(
                name: "Sectors");

            migrationBuilder.DropTable(
                name: "Segments");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "UserCompanies");
        }
    }
}
