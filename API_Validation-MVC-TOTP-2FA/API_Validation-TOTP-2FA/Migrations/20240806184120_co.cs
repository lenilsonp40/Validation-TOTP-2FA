using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Validation_TOTP_2FA.Migrations
{
    /// <inheritdoc />
    public partial class co : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClienteID",
                table: "Validation_TB001_Clientes",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Validation_TB001_Clientes_ClienteID",
                table: "Validation_TB001_Clientes",
                newName: "IX_Validation_TB001_Clientes_ClienteId");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Validation_TB001_Clientes",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Validation_TB001_Clientes");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Validation_TB001_Clientes",
                newName: "ClienteID");

            migrationBuilder.RenameIndex(
                name: "IX_Validation_TB001_Clientes_ClienteId",
                table: "Validation_TB001_Clientes",
                newName: "IX_Validation_TB001_Clientes_ClienteID");
        }
    }
}
