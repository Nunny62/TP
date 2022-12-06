using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab4vr2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(name: "Full_name", type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    DeliveryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Typeofdelivery = table.Column<string>(name: "Type_of_delivery", type: "nvarchar(max)", nullable: false),
                    Deliverytime = table.Column<string>(name: "Delivery_time", type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.DeliveryID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(name: "Full_name", type: "nvarchar(max)", nullable: false),
                    Dateofbirth = table.Column<DateTime>(name: "Date_of_birth", type: "datetime2", nullable: true),
                    Тelephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Post = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "Making_an_orders",
                columns: table => new
                {
                    MakinganorderID = table.Column<int>(name: "Making_an_orderID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Making_an_orders", x => x.MakinganorderID);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    DeliveryID = table.Column<int>(type: "int", nullable: false),
                    MakinganorderID = table.Column<int>(name: "Making_an_orderID", type: "int", nullable: false),
                    Paymenttype = table.Column<string>(name: "Payment_type", type: "nvarchar(max)", nullable: false),
                    Ordercost = table.Column<decimal>(name: "Order_cost", type: "decimal(18,2)", nullable: true),
                    Orderstatus = table.Column<string>(name: "Order_status", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Productname = table.Column<string>(name: "Product_name", type: "nvarchar(max)", nullable: false),
                    Productdescription = table.Column<string>(name: "Product_description", type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Assessment = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TestID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    TestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Productname = table.Column<string>(name: "Product_name", type: "nvarchar(max)", nullable: false),
                    Assessment = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Power = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Qualityofmaterials = table.Column<decimal>(name: "Quality_of_materials", type: "decimal(18,2)", nullable: true),
                    Pricequality = table.Column<decimal>(name: "Price_quality", type: "decimal(18,2)", nullable: true),
                    Appearance = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.TestID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Deliveries");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Making_an_orders");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Tests");
        }
    }
}
