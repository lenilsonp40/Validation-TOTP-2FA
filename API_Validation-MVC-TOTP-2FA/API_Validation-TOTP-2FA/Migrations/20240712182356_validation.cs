using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Validation_TOTP_2FA.Migrations
{
    /// <inheritdoc />
    public partial class validation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Validation_TB001_Clientes",
                columns: table => new
                {
                    ClienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Validation_TB001_Clientes", x => x.ClienteID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Validation_TB001_Clientes_ClienteID",
                table: "Validation_TB001_Clientes",
                column: "ClienteID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Validation_TB001_Clientes");
        }
    }
}
