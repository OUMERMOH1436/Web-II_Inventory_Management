using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiTenant_Inventory_Management.Migrations
{
    public partial class AllUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TenantAndUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateOfIntegration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvitedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    DateOfInvite = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AcceptInvite = table.Column<bool>(type: "bit", nullable: false),
                    IsIntegrationActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TenantAndUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TenantAndUsers_AspNetUsers_InvitedBy",
                        column: x => x.InvitedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TenantAndUsers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TenantAndUsers_InvitedBy",
                table: "TenantAndUsers",
                column: "InvitedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TenantAndUsers_UserId",
                table: "TenantAndUsers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TenantAndUsers");
        }
    }
}
