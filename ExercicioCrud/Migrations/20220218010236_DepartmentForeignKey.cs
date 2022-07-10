using Microsoft.EntityFrameworkCore.Migrations;

namespace ExercicioCrud.Migrations
{
    public partial class DepartmentForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Seller",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Seller",
                newName: "DataNascimento");

            migrationBuilder.RenameColumn(
                name: "BaseSalary",
                table: "Seller",
                newName: "SalarioBase");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Department",
                newName: "Nome");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Seller",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller");

            migrationBuilder.RenameColumn(
                name: "SalarioBase",
                table: "Seller",
                newName: "BaseSalary");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Seller",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "DataNascimento",
                table: "Seller",
                newName: "BirthDate");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Department",
                newName: "Name");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Seller",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
