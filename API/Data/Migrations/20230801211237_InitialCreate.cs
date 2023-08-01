using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        // This "up" method is what to do when we want to apply
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // All this is doing is creating a table with 2 cols
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    // Note that the names Id and UserName is comeing from AppUser class
                    // Because id = int, the property nullable = false means only ints allowed
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                        
                    //userName is allowed to have empty strings because nuillable = True
                    UserName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        // This down method is  what to do when we want to un-apply or remove migration
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
