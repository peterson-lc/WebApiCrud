﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiCrud.Data.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Clientes",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("Sqlite:Autoincrement", true),
            //        RazaoSocial = table.Column<string>(nullable: true),
            //        NomeFantasia = table.Column<string>(nullable: true),
            //        Email = table.Column<string>(nullable: true),
            //        Cnpj = table.Column<string>(nullable: true),
            //        Telefone = table.Column<string>(nullable: true),
            //        Endereco = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Clientes", x => x.Id);
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
