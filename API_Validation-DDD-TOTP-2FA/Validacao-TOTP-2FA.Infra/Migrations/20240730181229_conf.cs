﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Validacao_TOTP_2FA.Infra.Migrations
{
    /// <inheritdoc />
    public partial class conf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Validation_TB001_Customers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: false),
                    email = table.Column<string>(type: "VARCHAR(180)", maxLength: 180, nullable: false),
                    password = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Validation_TB001_Customers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Validation_TB001_Customers");
        }
    }
}
