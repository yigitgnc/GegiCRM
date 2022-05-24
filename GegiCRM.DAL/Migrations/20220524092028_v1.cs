using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GegiCRM.DAL.Migrations
{
    public partial class v1 : Migration
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
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
                    AddedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
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
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Users_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Banks_Users",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Banks_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birims", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Birims_Users",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Birims_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Brands_Users",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Brands_Users1",
                        column: x => x.ModifiedBy,
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CollectionReceipts_AddedBy",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CollectionReceipts_ModifiedBy",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTypes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CustomerType_AddedBy",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomerType_ModifiedBy",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Departments_Users",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Departments_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositRelations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DepositRelations_Users",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DepositRelations_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositTypes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DepositTypes_Users",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DepositTypes_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    AddedByNavigationId = table.Column<int>(type: "int", nullable: false),
                    ModifiedByNavigationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DocumentTypes_AspNetUsers_AddedByNavigationId",
                        column: x => x.AddedByNavigationId,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentTypes_AspNetUsers_ModifiedByNavigationId",
                        column: x => x.ModifiedByNavigationId,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expansions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Acilimlar_Users",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Acilimlar_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenencePeriods", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MaintenencePeriods_Users",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_MaintenencePeriods_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketPlaces", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MarketPlaces_Users",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_MarketPlaces_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderStates_Users",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrderStates_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PaymentTypes_Users",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PaymentTypes_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroups", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Users",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductCategories_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnAndFaultStates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReturnAndFaultStates_Users",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ReturnAndFaultStates_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rules", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rules_Users",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Rules_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sector_AddedBy",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Sector_ModidfiedBy",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Segments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Segments_Users",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Segments_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellsAndBuysCategories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SellsAndBuysCategories_Users",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SellsAndBuysCategories_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicePlaces", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ServicePlaces_Users",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ServicePlaces_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceReasons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ServiceReasons_Users",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ServiceReasons_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ServiceTypes_Users",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ServiceTypes_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierPaymentStates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SupplierPaymentStates_Users",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SupplierPaymentStates_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Suppliers_Users",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Suppliers_Users1",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "UserCompanies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_UserCompanies_Users",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserCompanies_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
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
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_WarrantyTrackings_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
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
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DiscountCupons_Users1",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DepartmentsOfUsers",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    IsResponsible = table.Column<bool>(type: "bit", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentsOfUsers", x => new { x.UserID, x.DepartmentID });
                    table.ForeignKey(
                        name: "FK_DepartmentsOfUsers_AddedBy",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DepartmentsOfUsers_Departments",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DepartmentsOfUsers_ModifiedBy",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
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
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_EmailTemplates_Users3",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
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
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_WorkStandarts_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
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
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Deposits_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
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
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Documents_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
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
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductSubCategories_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
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
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductCategoriesFAQs_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
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
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OurServices_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
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
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ReturnAndFaults_Users1",
                        column: x => x.ModifiedBy,
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TicariUnvan = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SectorID = table.Column<int>(type: "int", nullable: true),
                    CariKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SegmentID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    TypeID = table.Column<int>(type: "int", nullable: false),
                    LastContactDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    SideSuppliers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreferredCurrencyId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
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
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Customers_Users1",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SegmentOrans",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EndPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Oran = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyID = table.Column<int>(type: "int", nullable: false),
                    SegmentID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SegmentOrans", x => x.ID);
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
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SegmentOrans_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
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
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SellsAndBuysGuideSteps_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
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
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SuppliersPayments_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    AddedByNavigationId = table.Column<int>(type: "int", nullable: false),
                    ModifiedByNavigationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SupplierDetails_AspNetUsers_AddedByNavigationId",
                        column: x => x.AddedByNavigationId,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierDetails_AspNetUsers_ModifiedByNavigationId",
                        column: x => x.ModifiedByNavigationId,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
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
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_BankInformations_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    AddedByNavigationId = table.Column<int>(type: "int", nullable: false),
                    ModifiedByNavigationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingDeals", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShippingDeals_AspNetUsers_AddedByNavigationId",
                        column: x => x.AddedByNavigationId,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShippingDeals_AspNetUsers_ModifiedByNavigationId",
                        column: x => x.ModifiedByNavigationId,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
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
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_VehicleInformations_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
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
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CollectionReceipts_Users1",
                        column: x => x.ModifiedBy,
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
                    IsDeliveryAddress = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
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
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomerDeliveryAddresses_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBillingAddresses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CustomerBillingAddresses_AddedBy",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomerBillingAddresses_Customers",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomerBillingAddresses_ModifiedBy",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
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
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomerContacts_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerRepresentetiveUsers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CustomerRepresentetiveUsers_AddedBy",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomerRepresentetiveUsers_Customers",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CustomerRepresentetiveUsers_ModifiedBy",
                        column: x => x.ModifiedBy,
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
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    DiscountCuponID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeginDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ExpryDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_DiscountCuponsOfCustomers_Users",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DiscountCuponsOfCustomers_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
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
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_MaintenanceBills_Users1",
                        column: x => x.ModifiedBy,
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
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                        principalTable: "OrderStates",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Orders_Users",
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Orders_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
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
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ServiceRecords_Users1",
                        column: x => x.ModifiedBy,
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
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
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
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SellsAndBuysAssets_Users1",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "OrdersCurrencies",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    CurrencyID = table.Column<int>(type: "int", nullable: false),
                    ExchangeRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    AddedByNavigationId = table.Column<int>(type: "int", nullable: false),
                    ModifiedByNavigationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersCurrencies", x => new { x.OrderID, x.CurrencyID });
                    table.ForeignKey(
                        name: "FK_OrdersCurrencies_AspNetUsers_AddedByNavigationId",
                        column: x => x.AddedByNavigationId,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdersCurrencies_AspNetUsers_ModifiedByNavigationId",
                        column: x => x.ModifiedByNavigationId,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
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
                    KesinSevkTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    OrderStateId = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    AddedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                        column: x => x.AddedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrdersProducts_Users1",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "UserCompanies",
                columns: new[] { "ID", "AddedBy", "CompanyDescription", "CompanyName", "FaliyetKodu", "Fatura", "IsDeleted", "KepAdresi", "MersisNo", "ModifiedBy", "Tel", "TicaretSicilNo" },
                values: new object[] { 1, null, null, "AdminCompany", null, null, false, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "ID", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "IsDeleted", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedDate", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserCompanyID", "UserName" },
                values: new object[] { 1, 0, 1, "5a29b979-6125-4a92-8bae-3e6ee1171f88", new DateTime(2022, 5, 24, 12, 20, 27, 730, DateTimeKind.Local).AddTicks(6862), "yigit.genc@gegi.com.tr", true, false, false, null, null, new DateTime(2022, 5, 24, 12, 20, 27, 730, DateTimeKind.Local).AddTicks(6876), "Yiğit", "YIGIT.GENC@GEGI.COM.TR", "ADMINYGT", "AQAAAAEAACcQAAAAEN0GpBHDb6obtrA2HTneRYiYZFD5uaVCko4ihAzDYvi4as3jhO3D6bPOChhNpibGog==", "+905382630008", false, null, "ef7b1e4d-d442-4b4c-990f-49ab27b389d0", "Genç", false, 1, "AdminYigit" });

            migrationBuilder.InsertData(
                table: "AppAuthorizationsRoleGroups",
                columns: new[] { "ID", "AddedBy", "Description", "IsDeleted", "ModifiedBy", "Name", "Priority" },
                values: new object[] { 1, 1, "Admin Rollerinin Bulunduğu Grup", false, null, "Admin Role Grubu", 0 });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "ID", "AddedBy", "Code", "CreatedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, 1, "TRY", new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2549), false, null, null, "Türk Lirası" },
                    { 2, 1, "USD", new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2577), false, null, null, "Amerikan Doları" },
                    { 3, 1, "EUR", new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2579), false, null, null, "EURO" }
                });

            migrationBuilder.InsertData(
                table: "CustomerTypes",
                columns: new[] { "ID", "AddedBy", "CreatedDate", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[] { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bu Müşteri Tipi Tesat Amaçlı Eklenmiştir", false, null, null, "Test Müşteri Tipi" });

            migrationBuilder.InsertData(
                table: "OrderStates",
                columns: new[] { "ID", "AddedBy", "Description", "IsDeleted", "ModifiedBy", "Name" },
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
                columns: new[] { "ID", "AddedBy", "Description", "IsDeleted", "ModifiedBy", "Name" },
                values: new object[] { 1, 1, "Test Sektör Açıklaması", false, null, "Test Sektörü" });

            migrationBuilder.InsertData(
                table: "Segments",
                columns: new[] { "ID", "AddedBy", "CreatedDate", "Description", "IsDeleted", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2626), "Segment 1 Açıklaması", false, null, "Segment 1" },
                    { 2, 1, new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2640), "Segment 2 Açıklaması", false, null, "Segment 2" },
                    { 3, 1, new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2659), "Segment 3 Açıklaması", false, null, "Segment 3" },
                    { 4, 1, new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2683), "Segment 4 Açıklaması", false, null, "Segment 4" },
                    { 5, 1, new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2696), "Segment 5 Açıklaması", false, null, "Segment 5" },
                    { 6, 1, new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2703), "Segment 6 Açıklaması", false, null, "Segment 6" },
                    { 7, 1, new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2706), "Segment 7 Açıklaması", false, null, "Segment 7" },
                    { 8, 1, new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2709), "Segment 8 Açıklaması", false, null, "Segment 8" },
                    { 9, 1, new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2712), "Segment 9 Açıklaması", false, null, "Segment 9" },
                    { 10, 1, new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2720), "Segment 10 Açıklaması", false, null, "Segment 10" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID", "AddedBy", "DealerCode", "IsDeleted", "LastContactDate", "ModifiedBy", "OncelikSirasi", "SupplierName", "URL" },
                values: new object[] { 1, 1, "123", false, null, null, null, "Test Tedarikçisi", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "ID", "AddedBy", "ConcurrencyStamp", "CreatedDate", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "NormalizedName", "RoleGroupId" },
                values: new object[] { 1, 1, "881b1bdb-e039-4444-965f-270285db481b", new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2453), "Sistem Admini Full Yetki", false, 1, new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2453), "SysAdmin", "Sistem Admini", 1 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "AddedBy", "CariKodu", "CurrencyId", "IsActive", "IsDeleted", "LastContactDate", "ModifiedBy", "Name", "Notes", "PreferredCurrencyId", "SectorID", "SegmentID", "SideSuppliers", "Surname", "Tel", "TicariUnvan", "TypeID" },
                values: new object[] { 1, 1, "123", 0, true, false, null, null, "Test Müşterisi", null, null, 1, 1, null, "Soyad", null, "Test Ticari Ünvanı", 1 });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "ID", "AddedBy", "CurrencyID", "EndPrice", "IsDeleted", "ModifiedBy", "Oran", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 1, 1, 1, 49.99m, false, null, 22.5m, 1, 0.00m },
                    { 2, 1, 1, 199.99m, false, null, 13.5m, 1, 50.00m },
                    { 3, 1, 1, 499.99m, false, null, 11m, 1, 200.00m },
                    { 4, 1, 1, 999.99m, false, null, 7.5m, 1, 500.00m },
                    { 5, 1, 1, 2499.99m, false, null, 6m, 1, 1000.00m },
                    { 6, 1, 1, 4999.99m, false, null, 5.25m, 1, 2500.00m },
                    { 7, 1, 1, 9999.99m, false, null, 5m, 1, 5000.00m },
                    { 8, 1, 1, 19999.99m, false, null, 4.5m, 1, 10000.00m },
                    { 9, 1, 1, 39999.99m, false, null, 4m, 1, 20000.00m },
                    { 10, 1, 1, 74999.99m, false, null, 3.38m, 1, 40000.00m },
                    { 11, 1, 1, 99999.99m, false, null, 3m, 1, 75000.00m },
                    { 12, 1, 1, 149999.99m, false, null, 3m, 1, 100000.00m },
                    { 13, 1, 1, 249999.99m, false, null, 2m, 1, 150000.00m },
                    { 14, 1, 1, 499999.99m, false, null, 1.88m, 1, 250000.00m },
                    { 15, 1, 1, 999999.99m, false, null, 2m, 1, 500000.00m },
                    { 16, 1, 1, 99999999.99m, false, null, 1.5m, 1, 1000000.00m },
                    { 17, 1, 1, 49.99m, false, null, 27m, 2, 0.00m },
                    { 18, 1, 1, 199.99m, false, null, 16.2m, 2, 50.00m },
                    { 19, 1, 1, 499.99m, false, null, 126.6m, 2, 200.00m },
                    { 20, 1, 1, 999.99m, false, null, 9m, 2, 500.00m },
                    { 21, 1, 1, 2499.99m, false, null, 7.2m, 2, 1000.00m },
                    { 22, 1, 1, 4999.99m, false, null, 6.3m, 2, 2500.00m },
                    { 23, 1, 1, 9999.99m, false, null, 5.85m, 2, 5000.00m },
                    { 24, 1, 1, 19999.99m, false, null, 5.4m, 2, 10000.00m },
                    { 25, 1, 1, 39999.99m, false, null, 4.5m, 2, 20000.00m },
                    { 26, 1, 1, 74999.99m, false, null, 4.05m, 2, 40000.00m },
                    { 27, 1, 1, 99999.99m, false, null, 3.78m, 2, 75000.00m },
                    { 28, 1, 1, 149999.99m, false, null, 3.6m, 2, 100000.00m },
                    { 29, 1, 1, 249999.99m, false, null, 2.7m, 2, 150000.00m },
                    { 30, 1, 1, 499999.99m, false, null, 2.25m, 2, 250000.00m },
                    { 31, 1, 1, 999999.99m, false, null, 1.98m, 2, 500000.00m },
                    { 32, 1, 1, 99999999.99m, false, null, 1.8m, 2, 1000000.00m },
                    { 33, 1, 1, 49.99m, false, null, 32.4m, 3, 0.00m },
                    { 34, 1, 1, 199.99m, false, null, 19.44m, 3, 50.00m },
                    { 35, 1, 1, 499.99m, false, null, 15.12m, 3, 200.00m },
                    { 36, 1, 1, 999.99m, false, null, 10.8m, 3, 500.00m },
                    { 37, 1, 1, 2499.99m, false, null, 8.64m, 3, 1000.00m },
                    { 38, 1, 1, 4999.99m, false, null, 7.56m, 3, 2500.00m },
                    { 39, 1, 1, 9999.99m, false, null, 7.02m, 3, 5000.00m },
                    { 40, 1, 1, 19999.99m, false, null, 6.48m, 3, 10000.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "ID", "AddedBy", "CurrencyID", "EndPrice", "IsDeleted", "ModifiedBy", "Oran", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 41, 1, 1, 39999.99m, false, null, 5.4m, 3, 20000.00m },
                    { 42, 1, 1, 74999.99m, false, null, 4.86m, 3, 40000.00m },
                    { 43, 1, 1, 99999.99m, false, null, 4.54m, 3, 75000.00m },
                    { 44, 1, 1, 149999.99m, false, null, 4.32m, 3, 100000.00m },
                    { 45, 1, 1, 249999.99m, false, null, 3.24m, 3, 150000.00m },
                    { 46, 1, 1, 499999.99m, false, null, 2.7m, 3, 250000.00m },
                    { 47, 1, 1, 999999.99m, false, null, 2.38m, 3, 500000.00m },
                    { 48, 1, 1, 99999999.99m, false, null, 2.16m, 3, 1000000.00m },
                    { 49, 1, 1, 49.99m, false, null, 38.88m, 4, 0.00m },
                    { 50, 1, 1, 199.99m, false, null, 23.33m, 4, 50.00m },
                    { 51, 1, 1, 499.99m, false, null, 18.14m, 4, 200.00m },
                    { 52, 1, 1, 999.99m, false, null, 12.96m, 4, 500.00m },
                    { 53, 1, 1, 2499.99m, false, null, 10.37m, 4, 1000.00m },
                    { 54, 1, 1, 4999.99m, false, null, 9.07m, 4, 2500.00m },
                    { 55, 1, 1, 9999.99m, false, null, 8.42m, 4, 5000.00m },
                    { 56, 1, 1, 19999.99m, false, null, 7.78m, 4, 10000.00m },
                    { 57, 1, 1, 39999.99m, false, null, 6.48m, 4, 20000.00m },
                    { 58, 1, 1, 74999.99m, false, null, 5.83m, 4, 40000.00m },
                    { 59, 1, 1, 99999.99m, false, null, 5.44m, 4, 75000.00m },
                    { 60, 1, 1, 149999.99m, false, null, 5.18m, 4, 100000.00m },
                    { 61, 1, 1, 249999.99m, false, null, 3.89m, 4, 150000.00m },
                    { 62, 1, 1, 499999.99m, false, null, 3.24m, 4, 250000.00m },
                    { 63, 1, 1, 999999.99m, false, null, 2.85m, 4, 500000.00m },
                    { 64, 1, 1, 99999999.99m, false, null, 2.59m, 4, 1000000.00m },
                    { 65, 1, 1, 49.99m, false, null, 46.66m, 5, 0.00m },
                    { 66, 1, 1, 199.99m, false, null, 27.99m, 5, 50.00m },
                    { 67, 1, 1, 499.99m, false, null, 21.77m, 5, 200.00m },
                    { 68, 1, 1, 999.99m, false, null, 15.55m, 5, 500.00m },
                    { 69, 1, 1, 2499.99m, false, null, 12.44m, 5, 1000.00m },
                    { 70, 1, 1, 4999.99m, false, null, 10.89m, 5, 2500.00m },
                    { 71, 1, 1, 9999.99m, false, null, 10.11m, 5, 5000.00m },
                    { 72, 1, 1, 19999.99m, false, null, 9.33m, 5, 10000.00m },
                    { 73, 1, 1, 39999.99m, false, null, 7.78m, 5, 20000.00m },
                    { 74, 1, 1, 74999.99m, false, null, 7m, 5, 40000.00m },
                    { 75, 1, 1, 99999.99m, false, null, 6.53m, 5, 75000.00m },
                    { 76, 1, 1, 149999.99m, false, null, 6.22m, 5, 100000.00m },
                    { 77, 1, 1, 249999.99m, false, null, 4.67m, 5, 150000.00m },
                    { 78, 1, 1, 499999.99m, false, null, 3.89m, 5, 250000.00m },
                    { 79, 1, 1, 999999.99m, false, null, 3.42m, 5, 500000.00m },
                    { 80, 1, 1, 99999999.99m, false, null, 3.11m, 5, 1000000.00m },
                    { 81, 1, 1, 49.99m, false, null, 55.99m, 6, 0.00m },
                    { 82, 1, 1, 199.99m, false, null, 33.59m, 6, 50.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "ID", "AddedBy", "CurrencyID", "EndPrice", "IsDeleted", "ModifiedBy", "Oran", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 83, 1, 1, 499.99m, false, null, 26.13m, 6, 200.00m },
                    { 84, 1, 1, 999.99m, false, null, 18.66m, 6, 500.00m },
                    { 85, 1, 1, 2499.99m, false, null, 14.93m, 6, 1000.00m },
                    { 86, 1, 1, 4999.99m, false, null, 13.06m, 6, 2500.00m },
                    { 87, 1, 1, 9999.99m, false, null, 12.13m, 6, 5000.00m },
                    { 88, 1, 1, 19999.99m, false, null, 11.2m, 6, 10000.00m },
                    { 89, 1, 1, 39999.99m, false, null, 9.33m, 6, 20000.00m },
                    { 90, 1, 1, 74999.99m, false, null, 8.4m, 6, 40000.00m },
                    { 91, 1, 1, 99999.99m, false, null, 7.84m, 6, 75000.00m },
                    { 92, 1, 1, 149999.99m, false, null, 7.46m, 6, 100000.00m },
                    { 93, 1, 1, 249999.99m, false, null, 5.6m, 6, 150000.00m },
                    { 94, 1, 1, 499999.99m, false, null, 4.67m, 6, 250000.00m },
                    { 95, 1, 1, 999999.99m, false, null, 4.11m, 6, 500000.00m },
                    { 96, 1, 1, 99999999.99m, false, null, 3.73m, 6, 1000000.00m },
                    { 97, 1, 1, 49.99m, false, null, 67.18m, 7, 0.00m },
                    { 98, 1, 1, 199.99m, false, null, 40.31m, 7, 50.00m },
                    { 99, 1, 1, 499.99m, false, null, 31.35m, 7, 200.00m },
                    { 100, 1, 1, 999.99m, false, null, 22.39m, 7, 500.00m },
                    { 101, 1, 1, 2499.99m, false, null, 17.92m, 7, 1000.00m },
                    { 102, 1, 1, 4999.99m, false, null, 15.68m, 7, 2500.00m },
                    { 103, 1, 1, 9999.99m, false, null, 14.56m, 7, 5000.00m },
                    { 104, 1, 1, 19999.99m, false, null, 13.44m, 7, 10000.00m },
                    { 105, 1, 1, 39999.99m, false, null, 11.2m, 7, 20000.00m },
                    { 106, 1, 1, 74999.99m, false, null, 10.08m, 7, 40000.00m },
                    { 107, 1, 1, 99999.99m, false, null, 9.41m, 7, 75000.00m },
                    { 108, 1, 1, 149999.99m, false, null, 8.96m, 7, 100000.00m },
                    { 109, 1, 1, 249999.99m, false, null, 6.72m, 7, 150000.00m },
                    { 110, 1, 1, 499999.99m, false, null, 5.6m, 7, 250000.00m },
                    { 111, 1, 1, 999999.99m, false, null, 4.93m, 7, 500000.00m },
                    { 112, 1, 1, 99999999.99m, false, null, 4.48m, 7, 1000000.00m },
                    { 113, 1, 1, 49.99m, false, null, 80.62m, 8, 0.00m },
                    { 114, 1, 1, 199.99m, false, null, 48.37m, 8, 50.00m },
                    { 115, 1, 1, 499.99m, false, null, 37.62m, 8, 200.00m },
                    { 116, 1, 1, 999.99m, false, null, 26.87m, 8, 500.00m },
                    { 117, 1, 1, 2499.99m, false, null, 21.5m, 8, 1000.00m },
                    { 118, 1, 1, 4999.99m, false, null, 18.81m, 8, 2500.00m },
                    { 119, 1, 1, 9999.99m, false, null, 17.47m, 8, 5000.00m },
                    { 120, 1, 1, 19999.99m, false, null, 16.12m, 8, 10000.00m },
                    { 121, 1, 1, 39999.99m, false, null, 13.44m, 8, 20000.00m },
                    { 122, 1, 1, 74999.99m, false, null, 12.09m, 8, 40000.00m },
                    { 123, 1, 1, 99999.99m, false, null, 11.29m, 8, 75000.00m },
                    { 124, 1, 1, 149999.99m, false, null, 10.75m, 8, 100000.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "ID", "AddedBy", "CurrencyID", "EndPrice", "IsDeleted", "ModifiedBy", "Oran", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 125, 1, 1, 249999.99m, false, null, 8.06m, 8, 150000.00m },
                    { 126, 1, 1, 499999.99m, false, null, 6.72m, 8, 250000.00m },
                    { 127, 1, 1, 999999.99m, false, null, 5.91m, 8, 500000.00m },
                    { 128, 1, 1, 99999999.99m, false, null, 5.37m, 8, 1000000.00m },
                    { 129, 1, 1, 49.99m, false, null, 96.75m, 9, 0.00m },
                    { 130, 1, 1, 199.99m, false, null, 58.05m, 9, 50.00m },
                    { 131, 1, 1, 499.99m, false, null, 45.15m, 9, 200.00m },
                    { 132, 1, 1, 999.99m, false, null, 32.25m, 9, 500.00m },
                    { 133, 1, 1, 2499.99m, false, null, 25.8m, 9, 1000.00m },
                    { 134, 1, 1, 4999.99m, false, null, 22.57m, 9, 2500.00m },
                    { 135, 1, 1, 9999.99m, false, null, 20.96m, 9, 5000.00m },
                    { 136, 1, 1, 19999.99m, false, null, 19.35m, 9, 10000.00m },
                    { 137, 1, 1, 39999.99m, false, null, 16.12m, 9, 20000.00m },
                    { 138, 1, 1, 74999.99m, false, null, 14.51m, 9, 40000.00m },
                    { 139, 1, 1, 99999.99m, false, null, 13.54m, 9, 75000.00m },
                    { 140, 1, 1, 149999.99m, false, null, 12.9m, 9, 100000.00m },
                    { 141, 1, 1, 249999.99m, false, null, 9.67m, 9, 150000.00m },
                    { 142, 1, 1, 499999.99m, false, null, 8.06m, 9, 250000.00m },
                    { 143, 1, 1, 999999.99m, false, null, 7m, 9, 500000.00m },
                    { 144, 1, 1, 99999999.99m, false, null, 6.45m, 9, 1000000.00m },
                    { 145, 1, 1, 49.99m, false, null, 116.1m, 10, 0.00m },
                    { 146, 1, 1, 199.99m, false, null, 72.56m, 10, 50.00m },
                    { 147, 1, 1, 499.99m, false, null, 58.69m, 10, 200.00m },
                    { 148, 1, 1, 999.99m, false, null, 43.54m, 10, 500.00m },
                    { 149, 1, 1, 2499.99m, false, null, 36.12m, 10, 1000.00m },
                    { 150, 1, 1, 4999.99m, false, null, 32.73m, 10, 2500.00m },
                    { 151, 1, 1, 9999.99m, false, null, 31.44m, 10, 5000.00m },
                    { 152, 1, 1, 19999.99m, false, null, 29.99m, 10, 10000.00m },
                    { 153, 1, 1, 39999.99m, false, null, 25.8m, 10, 20000.00m },
                    { 154, 1, 1, 74999.99m, false, null, 23.94m, 10, 40000.00m },
                    { 155, 1, 1, 99999.99m, false, null, 23.03m, 10, 75000.00m },
                    { 156, 1, 1, 149999.99m, false, null, 22.57m, 10, 100000.00m },
                    { 157, 1, 1, 249999.99m, false, null, 17.41m, 10, 150000.00m },
                    { 158, 1, 1, 499999.99m, false, null, 14.91m, 10, 250000.00m },
                    { 159, 1, 1, 999999.99m, false, null, 13.48m, 10, 500000.00m },
                    { 160, 1, 1, 99999999.99m, false, null, 12.58m, 10, 1000000.00m },
                    { 161, 1, 2, 49.99m, false, null, 15m, 1, 0.00m },
                    { 162, 1, 2, 199.99m, false, null, 9m, 1, 50.00m },
                    { 163, 1, 2, 499.99m, false, null, 7m, 1, 200.00m },
                    { 164, 1, 2, 999.99m, false, null, 5m, 1, 500.00m },
                    { 165, 1, 2, 2499.99m, false, null, 4m, 1, 1000.00m },
                    { 166, 1, 2, 4999.99m, false, null, 3.5m, 1, 2500.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "ID", "AddedBy", "CurrencyID", "EndPrice", "IsDeleted", "ModifiedBy", "Oran", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 167, 1, 2, 9999.99m, false, null, 3.25m, 1, 5000.00m },
                    { 168, 1, 2, 19999.99m, false, null, 3m, 1, 10000.00m },
                    { 169, 1, 2, 39999.99m, false, null, 2.5m, 1, 20000.00m },
                    { 170, 1, 2, 74999.99m, false, null, 2.25m, 1, 40000.00m },
                    { 171, 1, 2, 99999.99m, false, null, 2.1m, 1, 75000.00m },
                    { 172, 1, 2, 149999.99m, false, null, 2m, 1, 100000.00m },
                    { 173, 1, 2, 249999.99m, false, null, 1.5m, 1, 150000.00m },
                    { 174, 1, 2, 499999.99m, false, null, 1.25m, 1, 250000.00m },
                    { 175, 1, 2, 999999.99m, false, null, 1.1m, 1, 500000.00m },
                    { 176, 1, 2, 99999999.99m, false, null, 1m, 1, 1000000.00m },
                    { 177, 1, 2, 49.99m, false, null, 18m, 2, 0.00m },
                    { 178, 1, 2, 199.99m, false, null, 10.8m, 2, 50.00m },
                    { 179, 1, 2, 499.99m, false, null, 8.4m, 2, 200.00m },
                    { 180, 1, 2, 999.99m, false, null, 6m, 2, 500.00m },
                    { 181, 1, 2, 2499.99m, false, null, 4.8m, 2, 1000.00m },
                    { 182, 1, 2, 4999.99m, false, null, 4.2m, 2, 2500.00m },
                    { 183, 1, 2, 9999.99m, false, null, 3.9m, 2, 5000.00m },
                    { 184, 1, 2, 19999.99m, false, null, 3.6m, 2, 10000.00m },
                    { 185, 1, 2, 39999.99m, false, null, 3m, 2, 20000.00m },
                    { 186, 1, 2, 74999.99m, false, null, 2.7m, 2, 40000.00m },
                    { 187, 1, 2, 99999.99m, false, null, 2.52m, 2, 75000.00m },
                    { 188, 1, 2, 149999.99m, false, null, 2.4m, 2, 100000.00m },
                    { 189, 1, 2, 249999.99m, false, null, 1.8m, 2, 150000.00m },
                    { 190, 1, 2, 499999.99m, false, null, 1.5m, 2, 250000.00m },
                    { 191, 1, 2, 999999.99m, false, null, 1.32m, 2, 500000.00m },
                    { 192, 1, 2, 99999999.99m, false, null, 1.2m, 2, 1000000.00m },
                    { 193, 1, 2, 49.99m, false, null, 21.6m, 3, 0.00m },
                    { 194, 1, 2, 199.99m, false, null, 12.96m, 3, 50.00m },
                    { 195, 1, 2, 499.99m, false, null, 10.08m, 3, 200.00m },
                    { 196, 1, 2, 999.99m, false, null, 7.2m, 3, 500.00m },
                    { 197, 1, 2, 2499.99m, false, null, 5.76m, 3, 1000.00m },
                    { 198, 1, 2, 4999.99m, false, null, 5.04m, 3, 2500.00m },
                    { 199, 1, 2, 9999.99m, false, null, 4.68m, 3, 5000.00m },
                    { 200, 1, 2, 19999.99m, false, null, 4.32m, 3, 10000.00m },
                    { 201, 1, 2, 39999.99m, false, null, 3.6m, 3, 20000.00m },
                    { 202, 1, 2, 74999.99m, false, null, 3.24m, 3, 40000.00m },
                    { 203, 1, 2, 99999.99m, false, null, 3.02m, 3, 75000.00m },
                    { 204, 1, 2, 149999.99m, false, null, 2.88m, 3, 100000.00m },
                    { 205, 1, 2, 249999.99m, false, null, 2.16m, 3, 150000.00m },
                    { 206, 1, 2, 499999.99m, false, null, 1.8m, 3, 250000.00m },
                    { 207, 1, 2, 999999.99m, false, null, 1.58m, 3, 500000.00m },
                    { 208, 1, 2, 99999999.99m, false, null, 1.44m, 3, 1000000.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "ID", "AddedBy", "CurrencyID", "EndPrice", "IsDeleted", "ModifiedBy", "Oran", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 209, 1, 2, 49.99m, false, null, 25.92m, 4, 0.00m },
                    { 210, 1, 2, 199.99m, false, null, 15.55m, 4, 50.00m },
                    { 211, 1, 2, 499.99m, false, null, 12.1m, 4, 200.00m },
                    { 212, 1, 2, 999.99m, false, null, 8.64m, 4, 500.00m },
                    { 213, 1, 2, 2499.99m, false, null, 6.91m, 4, 1000.00m },
                    { 214, 1, 2, 4999.99m, false, null, 6.05m, 4, 2500.00m },
                    { 215, 1, 2, 9999.99m, false, null, 5.62m, 4, 5000.00m },
                    { 216, 1, 2, 19999.99m, false, null, 5.18m, 4, 10000.00m },
                    { 217, 1, 2, 39999.99m, false, null, 4.32m, 4, 20000.00m },
                    { 218, 1, 2, 74999.99m, false, null, 3.89m, 4, 40000.00m },
                    { 219, 1, 2, 99999.99m, false, null, 3.63m, 4, 75000.00m },
                    { 220, 1, 2, 149999.99m, false, null, 3.46m, 4, 100000.00m },
                    { 221, 1, 2, 249999.99m, false, null, 2.59m, 4, 150000.00m },
                    { 222, 1, 2, 499999.99m, false, null, 2.16m, 4, 250000.00m },
                    { 223, 1, 2, 999999.99m, false, null, 1.9m, 4, 500000.00m },
                    { 224, 1, 2, 99999999.99m, false, null, 1.73m, 4, 1000000.00m },
                    { 225, 1, 2, 49.99m, false, null, 31.1m, 5, 0.00m },
                    { 226, 1, 2, 199.99m, false, null, 18.66m, 5, 50.00m },
                    { 227, 1, 2, 499.99m, false, null, 14.52m, 5, 200.00m },
                    { 228, 1, 2, 999.99m, false, null, 10.37m, 5, 500.00m },
                    { 229, 1, 2, 2499.99m, false, null, 8.29m, 5, 1000.00m },
                    { 230, 1, 2, 4999.99m, false, null, 7.26m, 5, 2500.00m },
                    { 231, 1, 2, 9999.99m, false, null, 6.74m, 5, 5000.00m },
                    { 232, 1, 2, 19999.99m, false, null, 6.22m, 5, 10000.00m },
                    { 233, 1, 2, 39999.99m, false, null, 5.18m, 5, 20000.00m },
                    { 234, 1, 2, 74999.99m, false, null, 4.67m, 5, 40000.00m },
                    { 235, 1, 2, 99999.99m, false, null, 4.35m, 5, 75000.00m },
                    { 236, 1, 2, 149999.99m, false, null, 4.15m, 5, 100000.00m },
                    { 237, 1, 2, 249999.99m, false, null, 3.11m, 5, 150000.00m },
                    { 238, 1, 2, 499999.99m, false, null, 2.59m, 5, 250000.00m },
                    { 239, 1, 2, 999999.99m, false, null, 2.28m, 5, 500000.00m },
                    { 240, 1, 2, 99999999.99m, false, null, 2.07m, 5, 1000000.00m },
                    { 241, 1, 2, 49.99m, false, null, 37.32m, 6, 0.00m },
                    { 242, 1, 2, 199.99m, false, null, 22.39m, 6, 50.00m },
                    { 243, 1, 2, 499.99m, false, null, 17.42m, 6, 200.00m },
                    { 244, 1, 2, 999.99m, false, null, 12.44m, 6, 500.00m },
                    { 245, 1, 2, 2499.99m, false, null, 9.95m, 6, 1000.00m },
                    { 246, 1, 2, 4999.99m, false, null, 8.71m, 6, 2500.00m },
                    { 247, 1, 2, 9999.99m, false, null, 8.09m, 6, 5000.00m },
                    { 248, 1, 2, 19999.99m, false, null, 7.46m, 6, 10000.00m },
                    { 249, 1, 2, 39999.99m, false, null, 6.22m, 6, 20000.00m },
                    { 250, 1, 2, 74999.99m, false, null, 5.6m, 6, 40000.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "ID", "AddedBy", "CurrencyID", "EndPrice", "IsDeleted", "ModifiedBy", "Oran", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 251, 1, 2, 99999.99m, false, null, 5.23m, 6, 75000.00m },
                    { 252, 1, 2, 149999.99m, false, null, 4.98m, 6, 100000.00m },
                    { 253, 1, 2, 249999.99m, false, null, 3.73m, 6, 150000.00m },
                    { 254, 1, 2, 499999.99m, false, null, 3.11m, 6, 250000.00m },
                    { 255, 1, 2, 999999.99m, false, null, 2.74m, 6, 500000.00m },
                    { 256, 1, 2, 99999999.99m, false, null, 2.49m, 6, 1000000.00m },
                    { 257, 1, 2, 49.99m, false, null, 44.79m, 7, 0.00m },
                    { 258, 1, 2, 199.99m, false, null, 26.87m, 7, 50.00m },
                    { 259, 1, 2, 499.99m, false, null, 20.9m, 7, 200.00m },
                    { 260, 1, 2, 999.99m, false, null, 14.93m, 7, 500.00m },
                    { 261, 1, 2, 2499.99m, false, null, 11.94m, 7, 1000.00m },
                    { 262, 1, 2, 4999.99m, false, null, 10.45m, 7, 2500.00m },
                    { 263, 1, 2, 9999.99m, false, null, 9.7m, 7, 5000.00m },
                    { 264, 1, 2, 19999.99m, false, null, 8.96m, 7, 10000.00m },
                    { 265, 1, 2, 39999.99m, false, null, 7.46m, 7, 20000.00m },
                    { 266, 1, 2, 74999.99m, false, null, 6.72m, 7, 40000.00m },
                    { 267, 1, 2, 99999.99m, false, null, 6.27m, 7, 75000.00m },
                    { 268, 1, 2, 149999.99m, false, null, 5.97m, 7, 100000.00m },
                    { 269, 1, 2, 249999.99m, false, null, 4.48m, 7, 150000.00m },
                    { 270, 1, 2, 499999.99m, false, null, 3.73m, 7, 250000.00m },
                    { 271, 1, 2, 999999.99m, false, null, 3.28m, 7, 500000.00m },
                    { 272, 1, 2, 99999999.99m, false, null, 2.99m, 7, 1000000.00m },
                    { 273, 1, 2, 49.99m, false, null, 53.75m, 8, 0.00m },
                    { 274, 1, 2, 199.99m, false, null, 32.25m, 8, 50.00m },
                    { 275, 1, 2, 499.99m, false, null, 25.08m, 8, 200.00m },
                    { 276, 1, 2, 999.99m, false, null, 17.92m, 8, 500.00m },
                    { 277, 1, 2, 2499.99m, false, null, 14.33m, 8, 1000.00m },
                    { 278, 1, 2, 4999.99m, false, null, 12.54m, 8, 2500.00m },
                    { 279, 1, 2, 9999.99m, false, null, 11.65m, 8, 5000.00m },
                    { 280, 1, 2, 19999.99m, false, null, 10.75m, 8, 10000.00m },
                    { 281, 1, 2, 39999.99m, false, null, 8.96m, 8, 20000.00m },
                    { 282, 1, 2, 74999.99m, false, null, 8.06m, 8, 40000.00m },
                    { 283, 1, 2, 99999.99m, false, null, 7.52m, 8, 75000.00m },
                    { 284, 1, 2, 149999.99m, false, null, 7.17m, 8, 100000.00m },
                    { 285, 1, 2, 249999.99m, false, null, 5.37m, 8, 150000.00m },
                    { 286, 1, 2, 499999.99m, false, null, 4.48m, 8, 250000.00m },
                    { 287, 1, 2, 999999.99m, false, null, 3.94m, 8, 500000.00m },
                    { 288, 1, 2, 99999999.99m, false, null, 3.58m, 8, 1000000.00m },
                    { 289, 1, 2, 49.99m, false, null, 64.5m, 9, 0.00m },
                    { 290, 1, 2, 199.99m, false, null, 38.7m, 9, 50.00m },
                    { 291, 1, 2, 499.99m, false, null, 30.1m, 9, 200.00m },
                    { 292, 1, 2, 999.99m, false, null, 21.5m, 9, 500.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "ID", "AddedBy", "CurrencyID", "EndPrice", "IsDeleted", "ModifiedBy", "Oran", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 293, 1, 2, 2499.99m, false, null, 17.2m, 9, 1000.00m },
                    { 294, 1, 2, 4999.99m, false, null, 15.05m, 9, 2500.00m },
                    { 295, 1, 2, 9999.99m, false, null, 13.97m, 9, 5000.00m },
                    { 296, 1, 2, 19999.99m, false, null, 12.9m, 9, 10000.00m },
                    { 297, 1, 2, 39999.99m, false, null, 10.75m, 9, 20000.00m },
                    { 298, 1, 2, 74999.99m, false, null, 9.67m, 9, 40000.00m },
                    { 299, 1, 2, 99999.99m, false, null, 9.03m, 9, 75000.00m },
                    { 300, 1, 2, 149999.99m, false, null, 8.6m, 9, 100000.00m },
                    { 301, 1, 2, 249999.99m, false, null, 6.45m, 9, 150000.00m },
                    { 302, 1, 2, 499999.99m, false, null, 5.37m, 9, 250000.00m },
                    { 303, 1, 2, 999999.99m, false, null, 4.73m, 9, 500000.00m },
                    { 304, 1, 2, 99999999.99m, false, null, 4.3m, 9, 1000000.00m },
                    { 305, 1, 2, 49.99m, false, null, 77.4m, 10, 0.00m },
                    { 306, 1, 2, 199.99m, false, null, 48.37m, 10, 50.00m },
                    { 307, 1, 2, 499.99m, false, null, 39.13m, 10, 200.00m },
                    { 308, 1, 2, 999.99m, false, null, 29.02m, 10, 500.00m },
                    { 309, 1, 2, 2499.99m, false, null, 24.08m, 10, 1000.00m },
                    { 310, 1, 2, 4999.99m, false, null, 21.82m, 10, 2500.00m },
                    { 311, 1, 2, 9999.99m, false, null, 20.96m, 10, 5000.00m },
                    { 312, 1, 2, 19999.99m, false, null, 19.99m, 10, 10000.00m },
                    { 313, 1, 2, 39999.99m, false, null, 17.2m, 10, 20000.00m },
                    { 314, 1, 2, 74999.99m, false, null, 15.96m, 10, 40000.00m },
                    { 315, 1, 2, 99999.99m, false, null, 15.35m, 10, 75000.00m },
                    { 316, 1, 2, 149999.99m, false, null, 15.05m, 10, 100000.00m },
                    { 317, 1, 2, 249999.99m, false, null, 11.61m, 10, 150000.00m },
                    { 318, 1, 2, 499999.99m, false, null, 9.94m, 10, 250000.00m },
                    { 319, 1, 2, 999999.99m, false, null, 8.99m, 10, 500000.00m },
                    { 320, 1, 2, 99999999.99m, false, null, 5.96m, 10, 1000000.00m },
                    { 321, 1, 3, 49.99m, false, null, 13.5m, 1, 0.00m },
                    { 322, 1, 3, 199.99m, false, null, 8.1m, 1, 50.00m },
                    { 323, 1, 3, 499.99m, false, null, 6.3m, 1, 200.00m },
                    { 324, 1, 3, 999.99m, false, null, 4.5m, 1, 500.00m },
                    { 325, 1, 3, 2499.99m, false, null, 3.6m, 1, 1000.00m },
                    { 326, 1, 3, 4999.99m, false, null, 3.15m, 1, 2500.00m },
                    { 327, 1, 3, 9999.99m, false, null, 2.93m, 1, 5000.00m },
                    { 328, 1, 3, 19999.99m, false, null, 2.7m, 1, 10000.00m },
                    { 329, 1, 3, 39999.99m, false, null, 2.25m, 1, 20000.00m },
                    { 330, 1, 3, 74999.99m, false, null, 2.03m, 1, 40000.00m },
                    { 331, 1, 3, 99999.99m, false, null, 1.89m, 1, 75000.00m },
                    { 332, 1, 3, 149999.99m, false, null, 1.8m, 1, 100000.00m },
                    { 333, 1, 3, 249999.99m, false, null, 1.35m, 1, 150000.00m },
                    { 334, 1, 3, 499999.99m, false, null, 1.13m, 1, 250000.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "ID", "AddedBy", "CurrencyID", "EndPrice", "IsDeleted", "ModifiedBy", "Oran", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 335, 1, 3, 999999.99m, false, null, 0.99m, 1, 500000.00m },
                    { 336, 1, 3, 99999999.99m, false, null, 0.9m, 1, 1000000.00m },
                    { 337, 1, 3, 49.99m, false, null, 16.2m, 2, 0.00m },
                    { 338, 1, 3, 199.99m, false, null, 9.72m, 2, 50.00m },
                    { 339, 1, 3, 499.99m, false, null, 7.56m, 2, 200.00m },
                    { 340, 1, 3, 999.99m, false, null, 5.4m, 2, 500.00m },
                    { 341, 1, 3, 2499.99m, false, null, 4.32m, 2, 1000.00m },
                    { 342, 1, 3, 4999.99m, false, null, 3.78m, 2, 2500.00m },
                    { 343, 1, 3, 9999.99m, false, null, 3.51m, 2, 5000.00m },
                    { 344, 1, 3, 19999.99m, false, null, 3.24m, 2, 10000.00m },
                    { 345, 1, 3, 39999.99m, false, null, 2.7m, 2, 20000.00m },
                    { 346, 1, 3, 74999.99m, false, null, 2.43m, 2, 40000.00m },
                    { 347, 1, 3, 99999.99m, false, null, 2.27m, 2, 75000.00m },
                    { 348, 1, 3, 149999.99m, false, null, 2.16m, 2, 100000.00m },
                    { 349, 1, 3, 249999.99m, false, null, 1.62m, 2, 150000.00m },
                    { 350, 1, 3, 499999.99m, false, null, 1.35m, 2, 250000.00m },
                    { 351, 1, 3, 999999.99m, false, null, 1.19m, 2, 500000.00m },
                    { 352, 1, 3, 99999999.99m, false, null, 1.08m, 2, 1000000.00m },
                    { 353, 1, 3, 49.99m, false, null, 19.44m, 3, 0.00m },
                    { 354, 1, 3, 199.99m, false, null, 11.66m, 3, 50.00m },
                    { 355, 1, 3, 499.99m, false, null, 9.07m, 3, 200.00m },
                    { 356, 1, 3, 999.99m, false, null, 6.48m, 3, 500.00m },
                    { 357, 1, 3, 2499.99m, false, null, 5.18m, 3, 1000.00m },
                    { 358, 1, 3, 4999.99m, false, null, 4.54m, 3, 2500.00m },
                    { 359, 1, 3, 9999.99m, false, null, 4.21m, 3, 5000.00m },
                    { 360, 1, 3, 19999.99m, false, null, 3.89m, 3, 10000.00m },
                    { 361, 1, 3, 39999.99m, false, null, 3.24m, 3, 20000.00m },
                    { 362, 1, 3, 74999.99m, false, null, 2.92m, 3, 40000.00m },
                    { 363, 1, 3, 99999.99m, false, null, 2.72m, 3, 75000.00m },
                    { 364, 1, 3, 149999.99m, false, null, 2.59m, 3, 100000.00m },
                    { 365, 1, 3, 249999.99m, false, null, 1.94m, 3, 150000.00m },
                    { 366, 1, 3, 499999.99m, false, null, 1.62m, 3, 250000.00m },
                    { 367, 1, 3, 999999.99m, false, null, 1.43m, 3, 500000.00m },
                    { 368, 1, 3, 99999999.99m, false, null, 1.3m, 3, 1000000.00m },
                    { 369, 1, 3, 49.99m, false, null, 23.33m, 4, 0.00m },
                    { 370, 1, 3, 199.99m, false, null, 14m, 4, 50.00m },
                    { 371, 1, 3, 499.99m, false, null, 10.89m, 4, 200.00m },
                    { 372, 1, 3, 999.99m, false, null, 7.78m, 4, 500.00m },
                    { 373, 1, 3, 2499.99m, false, null, 6.22m, 4, 1000.00m },
                    { 374, 1, 3, 4999.99m, false, null, 5.44m, 4, 2500.00m },
                    { 375, 1, 3, 9999.99m, false, null, 5.05m, 4, 5000.00m },
                    { 376, 1, 3, 19999.99m, false, null, 4.67m, 4, 10000.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "ID", "AddedBy", "CurrencyID", "EndPrice", "IsDeleted", "ModifiedBy", "Oran", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 377, 1, 3, 39999.99m, false, null, 3.89m, 4, 20000.00m },
                    { 378, 1, 3, 74999.99m, false, null, 3.5m, 4, 40000.00m },
                    { 379, 1, 3, 99999.99m, false, null, 3.27m, 4, 75000.00m },
                    { 380, 1, 3, 149999.99m, false, null, 3.11m, 4, 100000.00m },
                    { 381, 1, 3, 249999.99m, false, null, 2.33m, 4, 150000.00m },
                    { 382, 1, 3, 499999.99m, false, null, 1.9m, 4, 250000.00m },
                    { 383, 1, 3, 999999.99m, false, null, 1.71m, 4, 500000.00m },
                    { 384, 1, 3, 99999999.99m, false, null, 1.56m, 4, 1000000.00m },
                    { 385, 1, 3, 49.99m, false, null, 27.99m, 5, 0.00m },
                    { 386, 1, 3, 199.99m, false, null, 16.8m, 5, 50.00m },
                    { 387, 1, 3, 499.99m, false, null, 13.06m, 5, 200.00m },
                    { 388, 1, 3, 999.99m, false, null, 9.33m, 5, 500.00m },
                    { 389, 1, 3, 2499.99m, false, null, 7.46m, 5, 1000.00m },
                    { 390, 1, 3, 4999.99m, false, null, 6.53m, 5, 2500.00m },
                    { 391, 1, 3, 9999.99m, false, null, 6.07m, 5, 5000.00m },
                    { 392, 1, 3, 19999.99m, false, null, 5.6m, 5, 10000.00m },
                    { 393, 1, 3, 39999.99m, false, null, 4.67m, 5, 20000.00m },
                    { 394, 1, 3, 74999.99m, false, null, 4.2m, 5, 40000.00m },
                    { 395, 1, 3, 99999.99m, false, null, 3.92m, 5, 75000.00m },
                    { 396, 1, 3, 149999.99m, false, null, 3.73m, 5, 100000.00m },
                    { 397, 1, 3, 249999.99m, false, null, 2.8m, 5, 150000.00m },
                    { 398, 1, 3, 499999.99m, false, null, 2.33m, 5, 250000.00m },
                    { 399, 1, 3, 999999.99m, false, null, 2.05m, 5, 500000.00m },
                    { 400, 1, 3, 99999999.99m, false, null, 1.87m, 5, 1000000.00m },
                    { 401, 1, 3, 49.99m, false, null, 33.59m, 6, 0.00m },
                    { 402, 1, 3, 199.99m, false, null, 20.16m, 6, 50.00m },
                    { 403, 1, 3, 499.99m, false, null, 15.68m, 6, 200.00m },
                    { 404, 1, 3, 999.99m, false, null, 11.2m, 6, 500.00m },
                    { 405, 1, 3, 2499.99m, false, null, 8.96m, 6, 1000.00m },
                    { 406, 1, 3, 4999.99m, false, null, 7.84m, 6, 2500.00m },
                    { 407, 1, 3, 9999.99m, false, null, 7.28m, 6, 5000.00m },
                    { 408, 1, 3, 19999.99m, false, null, 6.72m, 6, 10000.00m },
                    { 409, 1, 3, 39999.99m, false, null, 5.6m, 6, 20000.00m },
                    { 410, 1, 3, 74999.99m, false, null, 5.04m, 6, 40000.00m },
                    { 411, 1, 3, 99999.99m, false, null, 4.7m, 6, 75000.00m },
                    { 412, 1, 3, 149999.99m, false, null, 4.48m, 6, 100000.00m },
                    { 413, 1, 3, 249999.99m, false, null, 3.36m, 6, 150000.00m },
                    { 414, 1, 3, 499999.99m, false, null, 2.8m, 6, 250000.00m },
                    { 415, 1, 3, 999999.99m, false, null, 2.46m, 6, 500000.00m },
                    { 416, 1, 3, 99999999.99m, false, null, 2.24m, 6, 1000000.00m },
                    { 417, 1, 3, 49.99m, false, null, 40.31m, 7, 0.00m },
                    { 418, 1, 3, 199.99m, false, null, 24.19m, 7, 50.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "ID", "AddedBy", "CurrencyID", "EndPrice", "IsDeleted", "ModifiedBy", "Oran", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 419, 1, 3, 499.99m, false, null, 18.81m, 7, 200.00m },
                    { 420, 1, 3, 999.99m, false, null, 13.44m, 7, 500.00m },
                    { 421, 1, 3, 2499.99m, false, null, 10.75m, 7, 1000.00m },
                    { 422, 1, 3, 4999.99m, false, null, 9.41m, 7, 2500.00m },
                    { 423, 1, 3, 9999.99m, false, null, 8.73m, 7, 5000.00m },
                    { 424, 1, 3, 19999.99m, false, null, 8.06m, 7, 10000.00m },
                    { 425, 1, 3, 39999.99m, false, null, 6.72m, 7, 20000.00m },
                    { 426, 1, 3, 74999.99m, false, null, 6.05m, 7, 40000.00m },
                    { 427, 1, 3, 99999.99m, false, null, 5.64m, 7, 75000.00m },
                    { 428, 1, 3, 149999.99m, false, null, 5.37m, 7, 100000.00m },
                    { 429, 1, 3, 249999.99m, false, null, 4.03m, 7, 150000.00m },
                    { 430, 1, 3, 499999.99m, false, null, 3.36m, 7, 250000.00m },
                    { 431, 1, 3, 999999.99m, false, null, 2.96m, 7, 500000.00m },
                    { 432, 1, 3, 99999999.99m, false, null, 2.69m, 7, 1000000.00m },
                    { 433, 1, 3, 49.99m, false, null, 48.37m, 8, 0.00m },
                    { 434, 1, 3, 199.99m, false, null, 29.02m, 8, 50.00m },
                    { 435, 1, 3, 499.99m, false, null, 22.57m, 8, 200.00m },
                    { 436, 1, 3, 999.99m, false, null, 16.12m, 8, 500.00m },
                    { 437, 1, 3, 2499.99m, false, null, 12.9m, 8, 1000.00m },
                    { 438, 1, 3, 4999.99m, false, null, 11.29m, 8, 2500.00m },
                    { 439, 1, 3, 9999.99m, false, null, 10.48m, 8, 5000.00m },
                    { 440, 1, 3, 19999.99m, false, null, 9.67m, 8, 10000.00m },
                    { 441, 1, 3, 39999.99m, false, null, 8.06m, 8, 20000.00m },
                    { 442, 1, 3, 74999.99m, false, null, 7.26m, 8, 40000.00m },
                    { 443, 1, 3, 99999.99m, false, null, 6.77m, 8, 75000.00m },
                    { 444, 1, 3, 149999.99m, false, null, 6.45m, 8, 100000.00m },
                    { 445, 1, 3, 249999.99m, false, null, 4.84m, 8, 150000.00m },
                    { 446, 1, 3, 499999.99m, false, null, 4.03m, 8, 250000.00m },
                    { 447, 1, 3, 999999.99m, false, null, 3.55m, 8, 500000.00m },
                    { 448, 1, 3, 99999999.99m, false, null, 3.22m, 8, 1000000.00m },
                    { 449, 1, 3, 49.99m, false, null, 58.05m, 9, 0.00m },
                    { 450, 1, 3, 199.99m, false, null, 34.83m, 9, 50.00m },
                    { 451, 1, 3, 499.99m, false, null, 27.09m, 9, 200.00m },
                    { 452, 1, 3, 999.99m, false, null, 19.35m, 9, 500.00m },
                    { 453, 1, 3, 2499.99m, false, null, 15.48m, 9, 1000.00m },
                    { 454, 1, 3, 4999.99m, false, null, 13.54m, 9, 2500.00m },
                    { 455, 1, 3, 9999.99m, false, null, 12.58m, 9, 5000.00m },
                    { 456, 1, 3, 19999.99m, false, null, 11.61m, 9, 10000.00m },
                    { 457, 1, 3, 39999.99m, false, null, 9.67m, 9, 20000.00m },
                    { 458, 1, 3, 74999.99m, false, null, 8.71m, 9, 40000.00m },
                    { 459, 1, 3, 99999.99m, false, null, 8.13m, 9, 75000.00m },
                    { 460, 1, 3, 149999.99m, false, null, 7.74m, 9, 100000.00m }
                });

            migrationBuilder.InsertData(
                table: "SegmentOrans",
                columns: new[] { "ID", "AddedBy", "CurrencyID", "EndPrice", "IsDeleted", "ModifiedBy", "Oran", "SegmentID", "StartPrice" },
                values: new object[,]
                {
                    { 461, 1, 3, 249999.99m, false, null, 5.8m, 9, 150000.00m },
                    { 462, 1, 3, 499999.99m, false, null, 4.84m, 9, 250000.00m },
                    { 463, 1, 3, 999999.99m, false, null, 4.26m, 9, 500000.00m },
                    { 464, 1, 3, 99999999.99m, false, null, 3.87m, 9, 1000000.00m },
                    { 465, 1, 3, 49.99m, false, null, 69.66m, 10, 0.00m },
                    { 466, 1, 3, 199.99m, false, null, 43.54m, 10, 50.00m },
                    { 467, 1, 3, 499.99m, false, null, 35.22m, 10, 200.00m },
                    { 468, 1, 3, 999.99m, false, null, 26.12m, 10, 500.00m },
                    { 469, 1, 3, 2499.99m, false, null, 21.67m, 10, 1000.00m },
                    { 470, 1, 3, 4999.99m, false, null, 19.64m, 10, 2500.00m },
                    { 471, 1, 3, 9999.99m, false, null, 18.87m, 10, 5000.00m },
                    { 472, 1, 3, 19999.99m, false, null, 17.99m, 10, 10000.00m },
                    { 473, 1, 3, 39999.99m, false, null, 15.48m, 10, 20000.00m },
                    { 474, 1, 3, 74999.99m, false, null, 14.37m, 10, 40000.00m },
                    { 475, 1, 3, 99999.99m, false, null, 13.82m, 10, 75000.00m },
                    { 476, 1, 3, 149999.99m, false, null, 13.54m, 10, 100000.00m },
                    { 477, 1, 3, 249999.99m, false, null, 10.45m, 10, 150000.00m },
                    { 478, 1, 3, 499999.99m, false, null, 8.05m, 10, 250000.00m },
                    { 479, 1, 3, 999999.99m, false, null, 8.09m, 10, 500000.00m },
                    { 480, 1, 3, 99999999.99m, false, null, 7.55m, 10, 1000000.00m }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "AddedBy", "Discriminator", "EndDate", "Id", "IsDeleted", "ModifiedBy", "StartDate" },
                values: new object[] { 1, 1, 1, "AppRolesOfUsers", new DateTime(2032, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2468), 0, false, null, new DateTime(2022, 5, 24, 12, 20, 27, 732, DateTimeKind.Local).AddTicks(2466) });

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_AddedBy",
                table: "Announcements",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_ModifiedBy",
                table: "Announcements",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AppAuthorizationsRoleGroups_AddedBy",
                table: "AppAuthorizationsRoleGroups",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AppAuthorizationsRoleGroups_ModifiedBy",
                table: "AppAuthorizationsRoleGroups",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_AddedBy",
                table: "AspNetRoles",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_ModifiedBy",
                table: "AspNetRoles",
                column: "ModifiedBy");

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
                name: "IX_AspNetUserRoles_AddedBy",
                table: "AspNetUserRoles",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_ModifiedBy",
                table: "AspNetUserRoles",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AddedBy",
                table: "AspNetUsers",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ModifiedBy",
                table: "AspNetUsers",
                column: "ModifiedBy");

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
                name: "IX_BankInformations_AddedBy",
                table: "BankInformations",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BankInformations_BankID",
                table: "BankInformations",
                column: "BankID");

            migrationBuilder.CreateIndex(
                name: "IX_BankInformations_CompanyID",
                table: "BankInformations",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_BankInformations_ModifiedBy",
                table: "BankInformations",
                column: "ModifiedBy");

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
                name: "IX_CollectionReceipts_AddedBy",
                table: "CollectionReceipts",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionReceipts_CurrencyID",
                table: "CollectionReceipts",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionReceipts_CustomerID",
                table: "CollectionReceipts",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionReceipts_ModifiedBy",
                table: "CollectionReceipts",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionReceipts_PaymentTypeID",
                table: "CollectionReceipts",
                column: "PaymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionReceipts_SupplierID",
                table: "CollectionReceipts",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Currencies_AddedBy",
                table: "Currencies",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Currencies_ModifiedBy",
                table: "Currencies",
                column: "ModifiedBy");

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
                name: "IX_CustomerBillingAddresses_AddedBy",
                table: "CustomerBillingAddresses",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBillingAddresses_CustomerID",
                table: "CustomerBillingAddresses",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBillingAddresses_ModifiedBy",
                table: "CustomerBillingAddresses",
                column: "ModifiedBy");

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
                name: "IX_CustomerRepresentetiveUsers_AddedBy",
                table: "CustomerRepresentetiveUsers",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRepresentetiveUsers_CustomerID",
                table: "CustomerRepresentetiveUsers",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRepresentetiveUsers_ModifiedBy",
                table: "CustomerRepresentetiveUsers",
                column: "ModifiedBy");

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
                name: "IX_CustomerTypes_AddedBy",
                table: "CustomerTypes",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTypes_ModifiedBy",
                table: "CustomerTypes",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_AddedBy",
                table: "Departments",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ModifiedBy",
                table: "Departments",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentsOfUsers_AddedBy",
                table: "DepartmentsOfUsers",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentsOfUsers_DepartmentID",
                table: "DepartmentsOfUsers",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentsOfUsers_ModifiedBy",
                table: "DepartmentsOfUsers",
                column: "ModifiedBy");

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
                name: "IX_DocumentTypes_AddedByNavigationId",
                table: "DocumentTypes",
                column: "AddedByNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentTypes_ModifiedByNavigationId",
                table: "DocumentTypes",
                column: "ModifiedByNavigationId");

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
                name: "IX_OrdersCurrencies_AddedByNavigationId",
                table: "OrdersCurrencies",
                column: "AddedByNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersCurrencies_CurrencyID",
                table: "OrdersCurrencies",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersCurrencies_ModifiedByNavigationId",
                table: "OrdersCurrencies",
                column: "ModifiedByNavigationId");

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
                name: "IX_OrderStates_AddedBy",
                table: "OrderStates",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrderStates_ModifiedBy",
                table: "OrderStates",
                column: "ModifiedBy");

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
                name: "IX_Sectors_AddedBy",
                table: "Sectors",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Sectors_ModifiedBy",
                table: "Sectors",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SegmentOrans_AddedBy",
                table: "SegmentOrans",
                column: "AddedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SegmentOrans_CurrencyID",
                table: "SegmentOrans",
                column: "CurrencyID");

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
                name: "IX_ShippingDeals_AddedByNavigationId",
                table: "ShippingDeals",
                column: "AddedByNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingDeals_CompanyID",
                table: "ShippingDeals",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingDeals_ModifiedByNavigationId",
                table: "ShippingDeals",
                column: "ModifiedByNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierDetails_AddedByNavigationId",
                table: "SupplierDetails",
                column: "AddedByNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierDetails_CurrencyID",
                table: "SupplierDetails",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierDetails_ModifiedByNavigationId",
                table: "SupplierDetails",
                column: "ModifiedByNavigationId");

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
                name: "FK_Announcements_Users",
                table: "Announcements",
                column: "AddedBy",
                principalTable: "AspNetUsers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Announcements_Users1",
                table: "Announcements",
                column: "ModifiedBy",
                principalTable: "AspNetUsers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorizationRoleGroup_ModifiedBy",
                table: "AppAuthorizationsRoleGroups",
                column: "ModifiedBy",
                principalTable: "AspNetUsers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorizationRoleGroups_AddedBy",
                table: "AppAuthorizationsRoleGroups",
                column: "AddedBy",
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
                column: "AddedBy",
                principalTable: "AspNetUsers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Authorizations_Users1",
                table: "AspNetRoles",
                column: "ModifiedBy",
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
                column: "AddedBy",
                principalTable: "AspNetUsers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersAuthorizations_ModifiedBy",
                table: "AspNetUserRoles",
                column: "ModifiedBy",
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
                name: "FK_UserCompanies_Users",
                table: "UserCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCompanies_Users1",
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
                name: "CustomerAddresses");

            migrationBuilder.DropTable(
                name: "CustomerBillingAddresses");

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
                name: "Departments");

            migrationBuilder.DropTable(
                name: "AppAuthorizationsRoleGroups");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OrderStates");

            migrationBuilder.DropTable(
                name: "ProductGroups");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "SellsAndBuysCategories");

            migrationBuilder.DropTable(
                name: "Currencies");

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
