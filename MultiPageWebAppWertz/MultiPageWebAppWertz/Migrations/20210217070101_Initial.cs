using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiPageWebAppWertz.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    PhoneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PNumber = table.Column<long>(type: "bigint", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.PhoneId);
                });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "PhoneId", "Address", "Name", "Note", "PNumber" },
                values: new object[] { 1, "708 26th St SE", "Isaiah Wertz", "It's me", 5157770852L });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "PhoneId", "Address", "Name", "Note", "PNumber" },
                values: new object[] { 2, "708 26th St SE", "Shannon Hodges", "It's my mom", 5158224692L });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "PhoneId", "Address", "Name", "Note", "PNumber" },
                values: new object[] { 3, "Null", "John Doe", "It's a fake", 5155555555L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phones");
        }
    }
}
