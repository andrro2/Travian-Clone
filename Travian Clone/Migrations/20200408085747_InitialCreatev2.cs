using Microsoft.EntityFrameworkCore.Migrations;

namespace Travian_Clone.Migrations
{
    public partial class InitialCreatev2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_World_WorldId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Settlement_AspNetUsers_UserId",
                table: "Settlement");

            migrationBuilder.DropForeignKey(
                name: "FK_Settlement_World_WorldId",
                table: "Settlement");

            migrationBuilder.DropForeignKey(
                name: "FK_Tile_Settlement_SettlementId",
                table: "Tile");

            migrationBuilder.DropForeignKey(
                name: "FK_Tile_WorldLayout_WorldLayoutId",
                table: "Tile");

            migrationBuilder.DropForeignKey(
                name: "FK_WorldLayout_World_WorldId",
                table: "WorldLayout");

            migrationBuilder.DropPrimaryKey(
                name: "PK_World",
                table: "World");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tile",
                table: "Tile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Settlement",
                table: "Settlement");

            migrationBuilder.RenameTable(
                name: "World",
                newName: "Worlds");

            migrationBuilder.RenameTable(
                name: "Tile",
                newName: "Tiles");

            migrationBuilder.RenameTable(
                name: "Settlement",
                newName: "Settlements");

            migrationBuilder.RenameIndex(
                name: "IX_Tile_WorldLayoutId",
                table: "Tiles",
                newName: "IX_Tiles_WorldLayoutId");

            migrationBuilder.RenameIndex(
                name: "IX_Tile_SettlementId",
                table: "Tiles",
                newName: "IX_Tiles_SettlementId");

            migrationBuilder.RenameIndex(
                name: "IX_Settlement_WorldId",
                table: "Settlements",
                newName: "IX_Settlements_WorldId");

            migrationBuilder.RenameIndex(
                name: "IX_Settlement_UserId",
                table: "Settlements",
                newName: "IX_Settlements_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Worlds",
                table: "Worlds",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tiles",
                table: "Tiles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Settlements",
                table: "Settlements",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Worlds_WorldId",
                table: "AspNetUsers",
                column: "WorldId",
                principalTable: "Worlds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Settlements_AspNetUsers_UserId",
                table: "Settlements",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Settlements_Worlds_WorldId",
                table: "Settlements",
                column: "WorldId",
                principalTable: "Worlds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tiles_Settlements_SettlementId",
                table: "Tiles",
                column: "SettlementId",
                principalTable: "Settlements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tiles_WorldLayout_WorldLayoutId",
                table: "Tiles",
                column: "WorldLayoutId",
                principalTable: "WorldLayout",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorldLayout_Worlds_WorldId",
                table: "WorldLayout",
                column: "WorldId",
                principalTable: "Worlds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Worlds_WorldId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Settlements_AspNetUsers_UserId",
                table: "Settlements");

            migrationBuilder.DropForeignKey(
                name: "FK_Settlements_Worlds_WorldId",
                table: "Settlements");

            migrationBuilder.DropForeignKey(
                name: "FK_Tiles_Settlements_SettlementId",
                table: "Tiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Tiles_WorldLayout_WorldLayoutId",
                table: "Tiles");

            migrationBuilder.DropForeignKey(
                name: "FK_WorldLayout_Worlds_WorldId",
                table: "WorldLayout");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Worlds",
                table: "Worlds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tiles",
                table: "Tiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Settlements",
                table: "Settlements");

            migrationBuilder.RenameTable(
                name: "Worlds",
                newName: "World");

            migrationBuilder.RenameTable(
                name: "Tiles",
                newName: "Tile");

            migrationBuilder.RenameTable(
                name: "Settlements",
                newName: "Settlement");

            migrationBuilder.RenameIndex(
                name: "IX_Tiles_WorldLayoutId",
                table: "Tile",
                newName: "IX_Tile_WorldLayoutId");

            migrationBuilder.RenameIndex(
                name: "IX_Tiles_SettlementId",
                table: "Tile",
                newName: "IX_Tile_SettlementId");

            migrationBuilder.RenameIndex(
                name: "IX_Settlements_WorldId",
                table: "Settlement",
                newName: "IX_Settlement_WorldId");

            migrationBuilder.RenameIndex(
                name: "IX_Settlements_UserId",
                table: "Settlement",
                newName: "IX_Settlement_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_World",
                table: "World",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tile",
                table: "Tile",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Settlement",
                table: "Settlement",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_World_WorldId",
                table: "AspNetUsers",
                column: "WorldId",
                principalTable: "World",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Settlement_AspNetUsers_UserId",
                table: "Settlement",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Settlement_World_WorldId",
                table: "Settlement",
                column: "WorldId",
                principalTable: "World",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tile_Settlement_SettlementId",
                table: "Tile",
                column: "SettlementId",
                principalTable: "Settlement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tile_WorldLayout_WorldLayoutId",
                table: "Tile",
                column: "WorldLayoutId",
                principalTable: "WorldLayout",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorldLayout_World_WorldId",
                table: "WorldLayout",
                column: "WorldId",
                principalTable: "World",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
