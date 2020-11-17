using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Sobrenome = table.Column<string>(type: "TEXT", nullable: true),
                    Telefone = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 1, "Marta", "Kent", "33225555" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 2, "Paula", "Isabela", "3354288" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 3, "Laura", "Antonia", "55668899" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 4, "Luiza", "Maria", "6565659" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 5, "Lucas", "Machado", "565685415" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 6, "Pedro", "Alvares", "456454545" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 7, "Paulo", "José", "9874512" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");
        }
    }
}
