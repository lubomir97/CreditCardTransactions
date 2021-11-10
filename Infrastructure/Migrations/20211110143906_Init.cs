using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardAccountStatusTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SystemName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardAccountStatusTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardAccountTransactionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SystemName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardAccountTransactionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientStatusTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SystemName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientStatusTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    IssuedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardAccounts_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardAccountTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardId = table.Column<int>(type: "int", nullable: false),
                    CorrespondedCardId = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OperationType = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardAccountTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardAccountTransactions_CardAccounts_CorrespondedCardId",
                        column: x => x.CorrespondedCardId,
                        principalTable: "CardAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardAccountTransactions_CardAccountTransactionTypes_OperationType",
                        column: x => x.OperationType,
                        principalTable: "CardAccountTransactionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardAccounts_ClientId",
                table: "CardAccounts",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_CardAccountStatusTypes_Name",
                table: "CardAccountStatusTypes",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CardAccountStatusTypes_SystemName",
                table: "CardAccountStatusTypes",
                column: "SystemName",
                unique: true,
                filter: "[SystemName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CardAccountTransactions_CorrespondedCardId",
                table: "CardAccountTransactions",
                column: "CorrespondedCardId");

            migrationBuilder.CreateIndex(
                name: "IX_CardAccountTransactions_OperationType",
                table: "CardAccountTransactions",
                column: "OperationType");

            migrationBuilder.CreateIndex(
                name: "IX_CardAccountTransactionTypes_Name",
                table: "CardAccountTransactionTypes",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CardAccountTransactionTypes_SystemName",
                table: "CardAccountTransactionTypes",
                column: "SystemName",
                unique: true,
                filter: "[SystemName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ClientStatusTypes_Name",
                table: "ClientStatusTypes",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ClientStatusTypes_SystemName",
                table: "ClientStatusTypes",
                column: "SystemName",
                unique: true,
                filter: "[SystemName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardAccountStatusTypes");

            migrationBuilder.DropTable(
                name: "CardAccountTransactions");

            migrationBuilder.DropTable(
                name: "ClientStatusTypes");

            migrationBuilder.DropTable(
                name: "CardAccounts");

            migrationBuilder.DropTable(
                name: "CardAccountTransactionTypes");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
