using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NC_24.Migrations
{
    /// <inheritdoc />
    public partial class AddPresentToAttendance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Present",
                table: "Attendances",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Present",
                table: "Attendances");
        }
    }
}
