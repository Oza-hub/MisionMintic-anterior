using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoCiclo3.App.Persistencia.Migrations
{
    public partial class Migratres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Marca",
                table: "Aviones");

            migrationBuilder.AddColumn<int>(
                name: "Capa_Max_Peso",
                table: "Aviones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Numero_asientos",
                table: "Aviones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Numero_baños",
                table: "Aviones",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capa_Max_Peso",
                table: "Aviones");

            migrationBuilder.DropColumn(
                name: "Numero_asientos",
                table: "Aviones");

            migrationBuilder.DropColumn(
                name: "Numero_baños",
                table: "Aviones");

            migrationBuilder.AddColumn<string>(
                name: "Marca",
                table: "Aviones",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
