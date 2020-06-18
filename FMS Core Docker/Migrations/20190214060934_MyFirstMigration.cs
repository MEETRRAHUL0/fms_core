using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FMS_Core.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_GST",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GST = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SGST = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CGST = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    IGST = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Comment = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_GST", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ItemType",
                columns: table => new
                {
                    ItemTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemType = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ItemType", x => x.ItemTypeId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ItemUnits",
                columns: table => new
                {
                    MeasurintUnitID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MeasuringUnits = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ItemUnits", x => x.MeasurintUnitID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_PaymentMode",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Mode = table.Column<string>(maxLength: 50, nullable: true),
                    Type = table.Column<string>(maxLength: 50, nullable: true),
                    IsVisible = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PaymentMode", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Sequence",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TableName = table.Column<string>(maxLength: 100, nullable: false),
                    PreFix = table.Column<string>(maxLength: 50, nullable: false),
                    RecordCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Sequence", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_vendorType",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 50, nullable: false),
                    AutoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_vendorType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tblMenu",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DisplayName = table.Column<string>(maxLength: 50, nullable: false),
                    icon = table.Column<string>(maxLength: 50, nullable: false),
                    type = table.Column<string>(maxLength: 50, nullable: true),
                    ordinal = table.Column<int>(nullable: false),
                    path = table.Column<string>(maxLength: 500, nullable: true),
                    ParentID = table.Column<int>(nullable: false),
                    IsEnable = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMenu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "vw_StockAvailable",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    StockIn = table.Column<int>(nullable: false),
                    StockOut = table.Column<int>(nullable: false),
                    StockAvailable = table.Column<int>(nullable: true),
                    ItemsID = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    HSN_SAC_NO = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vw_StockAvailable", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "vw_StockDetails",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    StockType = table.Column<string>(nullable: true),
                    ItemsID = table.Column<string>(nullable: true),
                    Qty = table.Column<int>(nullable: true),
                    PricePerUnit = table.Column<decimal>(nullable: true),
                    ItemwiseDiscount = table.Column<decimal>(nullable: true),
                    PricePerUnitAfterDiscount = table.Column<decimal>(nullable: true),
                    TotalPriceBeforeTax = table.Column<decimal>(nullable: true),
                    SGST = table.Column<decimal>(nullable: true),
                    CGST = table.Column<decimal>(nullable: true),
                    IGST = table.Column<decimal>(nullable: true),
                    GST = table.Column<decimal>(nullable: true),
                    TotalPriceAfterTax = table.Column<decimal>(nullable: true),
                    MRP = table.Column<decimal>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    HSN_SAC_NO = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: true),
                    MeasuringUnit = table.Column<int>(nullable: true),
                    Manufacture = table.Column<string>(nullable: true),
                    BarCode = table.Column<string>(nullable: true),
                    ItemUniqueDescription = table.Column<string>(nullable: true),
                    InvoiceNo = table.Column<string>(nullable: true),
                    PurchaseID = table.Column<string>(nullable: true),
                    SaleID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vw_StockDetails", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "vw_StockExpirydetails",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    ID = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    HSN_SAC_NO = table.Column<string>(nullable: true),
                    ItemType = table.Column<string>(nullable: true),
                    MeasuringUnits = table.Column<string>(nullable: true),
                    Supplier = table.Column<string>(nullable: true),
                    MeasuringUnit = table.Column<int>(nullable: true),
                    Expirydate = table.Column<DateTime>(nullable: true),
                    BatchNo = table.Column<string>(nullable: true),
                    StockType = table.Column<string>(nullable: true),
                    PurchaseID = table.Column<string>(nullable: true),
                    SaleID = table.Column<string>(nullable: true),
                    InvoiceNo = table.Column<string>(nullable: true),
                    Qty = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vw_StockExpirydetails", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_vendor",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    ContactPerson = table.Column<string>(maxLength: 50, nullable: true),
                    ContactNo = table.Column<string>(maxLength: 50, nullable: true),
                    PhoneNo = table.Column<string>(maxLength: 50, nullable: true),
                    VendorType = table.Column<string>(maxLength: 50, nullable: true),
                    Type = table.Column<string>(maxLength: 50, nullable: true),
                    Place = table.Column<string>(maxLength: 50, nullable: true),
                    DOB = table.Column<string>(maxLength: 50, nullable: true),
                    GSTNo = table.Column<string>(maxLength: 50, nullable: true),
                    TINNo = table.Column<string>(maxLength: 50, nullable: true),
                    PANNo = table.Column<string>(maxLength: 50, nullable: true),
                    CINNo = table.Column<string>(maxLength: 50, nullable: true),
                    AdhaarNo = table.Column<string>(maxLength: 50, nullable: true),
                    OpeningBalance = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OpeningBalanceType = table.Column<string>(maxLength: 50, nullable: true),
                    OpeningBalanceDate = table.Column<string>(maxLength: 50, nullable: true),
                    CreditLimit = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CreditPeriod = table.Column<int>(nullable: true),
                    CreditInterestRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    DebitInterestRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CreatedDatetime = table.Column<string>(maxLength: 50, nullable: true),
                    Photo = table.Column<string>(maxLength: 100, nullable: true),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    SuretyPerson = table.Column<string>(maxLength: 50, nullable: true),
                    SuretyPersonContactNo = table.Column<string>(maxLength: 50, nullable: true),
                    SuretyPersonAddress = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_vendor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_vendor_tbl_vendorType",
                        column: x => x.Type,
                        principalTable: "tbl_vendorType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Items",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    HSN_SAC_NO = table.Column<string>(maxLength: 50, nullable: true),
                    Type = table.Column<int>(nullable: true),
                    MeasuringUnit = table.Column<int>(nullable: true),
                    Manufacture = table.Column<string>(maxLength: 100, nullable: true),
                    BarCode = table.Column<string>(maxLength: 100, nullable: true),
                    ItemUniqueDescription = table.Column<string>(maxLength: 100, nullable: true),
                    Supplier = table.Column<string>(maxLength: 50, nullable: true),
                    Photo = table.Column<string>(maxLength: 50, nullable: true),
                    UseBatchNo = table.Column<bool>(nullable: true),
                    UseMfgDate = table.Column<bool>(nullable: true),
                    UseExpiryDate = table.Column<bool>(nullable: true),
                    CreatedDatetime = table.Column<DateTime>(type: "date", nullable: true),
                    GST = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Items", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tbl_Items_tbl_GST",
                        column: x => x.GST,
                        principalTable: "tbl_GST",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_Items_tbl_ItemUnits",
                        column: x => x.MeasuringUnit,
                        principalTable: "tbl_ItemUnits",
                        principalColumn: "MeasurintUnitID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_Items_tbl_vendor",
                        column: x => x.Supplier,
                        principalTable: "tbl_vendor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_Items_tbl_ItemType",
                        column: x => x.Type,
                        principalTable: "tbl_ItemType",
                        principalColumn: "ItemTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Payment",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 50, nullable: false),
                    AutoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PaymentDate = table.Column<string>(maxLength: 50, nullable: true),
                    PartyName = table.Column<string>(maxLength: 50, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PaymentMode = table.Column<string>(maxLength: 50, nullable: true),
                    Remark = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedDatetime = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Payment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tbl_Payment_tbl_Payment",
                        column: x => x.PartyName,
                        principalTable: "tbl_vendor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Purchase",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 50, nullable: false),
                    AutoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PartyInvoiceDate = table.Column<DateTime>(type: "date", nullable: true),
                    PurchaseDate = table.Column<DateTime>(type: "date", nullable: true),
                    PartyInvoiceNo = table.Column<string>(maxLength: 50, nullable: true),
                    PartyName = table.Column<string>(maxLength: 50, nullable: true),
                    PaymentDueAfter = table.Column<string>(maxLength: 50, nullable: true),
                    ReverseCharge = table.Column<bool>(nullable: true),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OtherCharge = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TotalAmountBeforeTax = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TaxAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TotalAmountAfterTax = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    RoundOff = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    GrandTotal = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PurchaseBook = table.Column<int>(nullable: true),
                    PaymentMode = table.Column<int>(nullable: true),
                    ScanCopy = table.Column<string>(maxLength: 100, nullable: true),
                    CreatedDatetime = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Purchase", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tbl_Purchase_tbl_vendor",
                        column: x => x.PartyName,
                        principalTable: "tbl_vendor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_Purchase_tbl_PaymentMode",
                        column: x => x.PaymentMode,
                        principalTable: "tbl_PaymentMode",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Sale",
                columns: table => new
                {
                    SaleID = table.Column<string>(maxLength: 50, nullable: false),
                    AutoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InvoiceID = table.Column<string>(maxLength: 50, nullable: true),
                    InvoiceDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CustomerID = table.Column<string>(maxLength: 50, nullable: true),
                    DiscountAfterTax = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    OtherChargeAfterTax = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SubTotal = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Tax = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TotalValueafterTax = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    RoundOff = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    GrandTotal = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CreatedDatetime = table.Column<string>(maxLength: 50, nullable: false),
                    ReverseCharge = table.Column<bool>(nullable: true),
                    Remark = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Sale", x => x.SaleID);
                    table.ForeignKey(
                        name: "FK_tbl_Sale_tbl_vendor",
                        column: x => x.CustomerID,
                        principalTable: "tbl_vendor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_VendorAddress",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 50, nullable: false),
                    AutoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    vendorID = table.Column<string>(maxLength: 50, nullable: true),
                    AddressType = table.Column<string>(maxLength: 50, nullable: true),
                    AddLine1 = table.Column<string>(maxLength: 100, nullable: true),
                    AddLine2 = table.Column<string>(maxLength: 100, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    State = table.Column<string>(maxLength: 50, nullable: true),
                    PinCode = table.Column<string>(maxLength: 50, nullable: true),
                    ContactNo = table.Column<int>(nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_VendorAddress", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tbl_VendorAddress_tbl_vendor",
                        column: x => x.vendorID,
                        principalTable: "tbl_vendor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ItemStock",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 50, nullable: false),
                    AutoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StockType = table.Column<string>(maxLength: 50, nullable: true),
                    PurchaseID = table.Column<string>(maxLength: 50, nullable: true),
                    SaleID = table.Column<string>(maxLength: 50, nullable: true),
                    InvoiceNo = table.Column<string>(maxLength: 50, nullable: true),
                    ItemID = table.Column<string>(maxLength: 50, nullable: true),
                    Qty = table.Column<int>(nullable: true),
                    PricePerUnit = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ItemwiseDiscount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PricePerUnitAfterDiscount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TotalPriceBeforeTax = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    SGST = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CGST = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    IGST = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    GST = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    TotalPriceAfterTax = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    MRP = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ManufactureDate = table.Column<DateTime>(type: "date", nullable: true),
                    Expirydate = table.Column<DateTime>(type: "date", nullable: true),
                    BatchNo = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedDatetime = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ItemStock", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tbl_ItemStock_tbl_Items",
                        column: x => x.ItemID,
                        principalTable: "tbl_Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_ItemStock_tbl_Purchase",
                        column: x => x.PurchaseID,
                        principalTable: "tbl_Purchase",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_ItemStock_tbl_Sale",
                        column: x => x.SaleID,
                        principalTable: "tbl_Sale",
                        principalColumn: "SaleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Transaction",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 50, nullable: false),
                    AutoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VendorID = table.Column<string>(maxLength: 50, nullable: true),
                    PurchaseID = table.Column<string>(maxLength: 50, nullable: true),
                    SalesID = table.Column<string>(maxLength: 50, nullable: true),
                    EntryID = table.Column<string>(maxLength: 50, nullable: false),
                    EntryDate = table.Column<string>(maxLength: 50, nullable: true),
                    EntryType = table.Column<string>(maxLength: 50, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Status = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedDatetime = table.Column<string>(maxLength: 50, nullable: true),
                    TransactionType = table.Column<string>(maxLength: 50, nullable: true),
                    TransactionRef = table.Column<string>(maxLength: 50, nullable: true),
                    PaymentID = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Transaction", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tbl_Transaction_tbl_Payment",
                        column: x => x.PaymentID,
                        principalTable: "tbl_Payment",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_Transaction_tbl_Purchase",
                        column: x => x.PurchaseID,
                        principalTable: "tbl_Purchase",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_Transaction_tbl_Sale",
                        column: x => x.SalesID,
                        principalTable: "tbl_Sale",
                        principalColumn: "SaleID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_Transaction_tbl_vendor",
                        column: x => x.VendorID,
                        principalTable: "tbl_vendor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "([NormalizedName] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "([NormalizedUserName] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Items_GST",
                table: "tbl_Items",
                column: "GST");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Items_MeasuringUnit",
                table: "tbl_Items",
                column: "MeasuringUnit");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Items_Supplier",
                table: "tbl_Items",
                column: "Supplier");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Items_Type",
                table: "tbl_Items",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ItemStock_ItemID",
                table: "tbl_ItemStock",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ItemStock_PurchaseID",
                table: "tbl_ItemStock",
                column: "PurchaseID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ItemStock_SaleID",
                table: "tbl_ItemStock",
                column: "SaleID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Payment_PartyName",
                table: "tbl_Payment",
                column: "PartyName");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Purchase_PartyName",
                table: "tbl_Purchase",
                column: "PartyName");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Purchase_PaymentMode",
                table: "tbl_Purchase",
                column: "PaymentMode");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Sale_CustomerID",
                table: "tbl_Sale",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Transaction_PaymentID",
                table: "tbl_Transaction",
                column: "PaymentID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Transaction_PurchaseID",
                table: "tbl_Transaction",
                column: "PurchaseID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Transaction_SalesID",
                table: "tbl_Transaction",
                column: "SalesID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Transaction_VendorID",
                table: "tbl_Transaction",
                column: "VendorID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_vendor_Type",
                table: "tbl_vendor",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_VendorAddress_vendorID",
                table: "tbl_VendorAddress",
                column: "vendorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "tbl_ItemStock");

            migrationBuilder.DropTable(
                name: "tbl_Sequence");

            migrationBuilder.DropTable(
                name: "tbl_Transaction");

            migrationBuilder.DropTable(
                name: "tbl_VendorAddress");

            migrationBuilder.DropTable(
                name: "tblMenu");

            migrationBuilder.DropTable(
                name: "vw_StockAvailable");

            migrationBuilder.DropTable(
                name: "vw_StockDetails");

            migrationBuilder.DropTable(
                name: "vw_StockExpirydetails");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "tbl_Items");

            migrationBuilder.DropTable(
                name: "tbl_Payment");

            migrationBuilder.DropTable(
                name: "tbl_Purchase");

            migrationBuilder.DropTable(
                name: "tbl_Sale");

            migrationBuilder.DropTable(
                name: "tbl_GST");

            migrationBuilder.DropTable(
                name: "tbl_ItemUnits");

            migrationBuilder.DropTable(
                name: "tbl_ItemType");

            migrationBuilder.DropTable(
                name: "tbl_PaymentMode");

            migrationBuilder.DropTable(
                name: "tbl_vendor");

            migrationBuilder.DropTable(
                name: "tbl_vendorType");
        }
    }
}
