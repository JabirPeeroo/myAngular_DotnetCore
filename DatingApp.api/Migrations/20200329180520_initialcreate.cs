﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.api.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder) => migrationBuilder.CreateTable(
                name: "Values",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Values", x => x.id);
                });

        protected override void Down(MigrationBuilder migrationBuilder) => migrationBuilder.DropTable(
                name: "Values");
    }
}
