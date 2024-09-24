using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DemoAPI.Migrations
{
    /// <inheritdoc />
    public partial class UserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Bunnies",
                table: "Bunnies");

            migrationBuilder.RenameTable(
                name: "Bunnies",
                newName: "bunny");

            migrationBuilder.RenameColumn(
                name: "Sex",
                table: "bunny",
                newName: "sex");

            migrationBuilder.RenameColumn(
                name: "Breed",
                table: "bunny",
                newName: "breed");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "bunny",
                newName: "age");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "bunny",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "bunny",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "bunny",
                newName: "created_at");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bunny",
                table: "bunny",
                column: "id");

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    username = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bunny",
                table: "bunny");

            migrationBuilder.RenameTable(
                name: "bunny",
                newName: "Bunnies");

            migrationBuilder.RenameColumn(
                name: "sex",
                table: "Bunnies",
                newName: "Sex");

            migrationBuilder.RenameColumn(
                name: "breed",
                table: "Bunnies",
                newName: "Breed");

            migrationBuilder.RenameColumn(
                name: "age",
                table: "Bunnies",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Bunnies",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Bunnies",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Bunnies",
                newName: "CreatedAt");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bunnies",
                table: "Bunnies",
                column: "Id");
        }
    }
}
