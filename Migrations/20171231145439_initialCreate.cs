using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Chorch.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChurchStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChurchStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChurchSuperGroup1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChurchSuperGroup1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChurchSuperGroup2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChurchSuperGroup2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Attendance = table.Column<int>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventRegistration",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventRegistration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    GroupAgeEnd = table.Column<int>(nullable: false),
                    GroupAgeStart = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(maxLength: 30, nullable: false),
                    Mobile = table.Column<string>(nullable: true),
                    WeddingAnniversary = table.Column<DateTime>(nullable: true),
                    TimeAvailable = table.Column<string>(nullable: true),
                    VisitDate = table.Column<DateTime>(nullable: true),
                    VisitYou = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    MaritalStatus_Description = table.Column<string>(nullable: true),
                    MaritalStatus_Name = table.Column<string>(nullable: true),
                    OtherStatus_Description = table.Column<string>(nullable: true),
                    OtherStatus_Name = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Church",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FoundedDate = table.Column<DateTime>(nullable: false),
                    LaunchDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    StatusId = table.Column<int>(nullable: true),
                    Telephone1 = table.Column<string>(nullable: true),
                    Telephone2 = table.Column<string>(nullable: true),
                    Telephone3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Church", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Church_ChurchStatus_StatusId",
                        column: x => x.StatusId,
                        principalTable: "ChurchStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FoundedDate = table.Column<DateTime>(nullable: false),
                    FounderId = table.Column<int>(nullable: true),
                    LogoUrl = table.Column<string>(nullable: true),
                    Motto = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 40, nullable: false),
                    OpenDate = table.Column<DateTime>(nullable: false),
                    Telephone1 = table.Column<string>(nullable: true),
                    Telephone2 = table.Column<string>(nullable: true),
                    Telephone3 = table.Column<string>(nullable: true),
                    WebUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organization_Persons_FounderId",
                        column: x => x.FounderId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Church_StatusId",
                table: "Church",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_FounderId",
                table: "Organization",
                column: "FounderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Church");

            migrationBuilder.DropTable(
                name: "ChurchSuperGroup1");

            migrationBuilder.DropTable(
                name: "ChurchSuperGroup2");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "EventRegistration");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Organization");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "ChurchStatus");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
