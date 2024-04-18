using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonsterCounter2.Data.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Assault",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BlueHamilton",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Green",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JapanStrawberry",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Java",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Khaotic",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mixxd",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Molet",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NoSugarGreen",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NoSugarMango",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NormalBlue",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NormalGreen",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NormalMango",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Orange",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PacificPunch",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Pinapple",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Pink",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RedHamilton",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TheDoctor",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Watermelon",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "White",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Assault",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BlueHamilton",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Green",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "JapanStrawberry",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Java",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Khaotic",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Mixxd",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Molet",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NoSugarGreen",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NoSugarMango",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NormalBlue",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NormalGreen",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NormalMango",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Orange",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PacificPunch",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Pinapple",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Pink",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RedHamilton",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TheDoctor",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Watermelon",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "White",
                table: "AspNetUsers");
        }
    }
}
