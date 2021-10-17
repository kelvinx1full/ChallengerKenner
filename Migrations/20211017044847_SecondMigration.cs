using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChallengerKenner1._0.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LogAuditoriaProdutos",
                columns: table => new
                {
                    IdLogProdutos = table.Column<Guid>(nullable: false),
                    DetalhesAuditoriaProdutos = table.Column<string>(nullable: true),
                    EmailUsuarioProdutos = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogAuditoriaProdutos", x => x.IdLogProdutos);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogAuditoriaProdutos");
        }
    }
}
