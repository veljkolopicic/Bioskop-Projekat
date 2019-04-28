using Microsoft.EntityFrameworkCore.Migrations;

namespace BioskopApp.Migrations
{
    public partial class foregnkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProgramOfEvents_Movies_MovieID",
                table: "ProgramOfEvents");

            migrationBuilder.RenameColumn(
                name: "MovieID",
                table: "ProgramOfEvents",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_ProgramOfEvents_MovieID",
                table: "ProgramOfEvents",
                newName: "IX_ProgramOfEvents_MovieId");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "ProgramOfEvents",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramOfEvents_Movies_MovieId",
                table: "ProgramOfEvents",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProgramOfEvents_Movies_MovieId",
                table: "ProgramOfEvents");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "ProgramOfEvents",
                newName: "MovieID");

            migrationBuilder.RenameIndex(
                name: "IX_ProgramOfEvents_MovieId",
                table: "ProgramOfEvents",
                newName: "IX_ProgramOfEvents_MovieID");

            migrationBuilder.AlterColumn<int>(
                name: "MovieID",
                table: "ProgramOfEvents",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramOfEvents_Movies_MovieID",
                table: "ProgramOfEvents",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
