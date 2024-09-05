using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS.Data.Migrations
{
    /// <inheritdoc />
    public partial class IntialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "deliveries",
                columns: table => new
                {
                    delivery_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    delivery_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    emp_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    qnty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deliveries", x => x.delivery_id);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    emp_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    emp_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.emp_id);
                });

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    item_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    item_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    item_status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.item_id);
                });

            migrationBuilder.CreateTable(
                name: "services",
                columns: table => new
                {
                    service_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    service_Po_no = table.Column<int>(type: "int", nullable: false),
                    service_item = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    service_qnty = table.Column<int>(type: "int", nullable: false),
                    service_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    costing_price = table.Column<int>(type: "int", nullable: false),
                    vendor_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_services", x => x.service_id);
                });

            migrationBuilder.CreateTable(
                name: "vendors",
                columns: table => new
                {
                    vendor_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vendor_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vendors", x => x.vendor_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "deliveries");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "services");

            migrationBuilder.DropTable(
                name: "vendors");
        }
    }
}
