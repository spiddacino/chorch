using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Chorch.Migrations
{
    public partial class ModelModification1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Church_ChurchStatus_StatusId",
                table: "Church");

            migrationBuilder.DropTable(
                name: "ChurchStatus");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Status",
                newName: "Gender_Name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Status",
                newName: "Gender_Description");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Status",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Status",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChurchId1",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "MemberSince",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChurchId",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaritalStatusId",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Persons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Persons",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "AttendeeId",
                table: "EventRegistration",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "EventRegistration",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DistrictId",
                table: "Church",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecretaryId",
                table: "Church",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeniorPastorId",
                table: "Church",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ChurchSuperGroup2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "RegionHQId",
                table: "ChurchSuperGroup2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ChurchSuperGroup1",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DistrictHQId",
                table: "ChurchSuperGroup1",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RegionId",
                table: "ChurchSuperGroup1",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_ChurchId1",
                table: "Persons",
                column: "ChurchId1");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_ChurchId",
                table: "Persons",
                column: "ChurchId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_GenderId",
                table: "Persons",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_MaritalStatusId",
                table: "Persons",
                column: "MaritalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_StatusId",
                table: "Persons",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_EventRegistration_AttendeeId",
                table: "EventRegistration",
                column: "AttendeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EventRegistration_EventId",
                table: "EventRegistration",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_StatusId",
                table: "Event",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Church_DistrictId",
                table: "Church",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Church_SecretaryId",
                table: "Church",
                column: "SecretaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Church_SeniorPastorId",
                table: "Church",
                column: "SeniorPastorId");

            migrationBuilder.CreateIndex(
                name: "IX_ChurchSuperGroup2_RegionHQId",
                table: "ChurchSuperGroup2",
                column: "RegionHQId");

            migrationBuilder.CreateIndex(
                name: "IX_ChurchSuperGroup1_DistrictHQId",
                table: "ChurchSuperGroup1",
                column: "DistrictHQId");

            migrationBuilder.CreateIndex(
                name: "IX_ChurchSuperGroup1_RegionId",
                table: "ChurchSuperGroup1",
                column: "RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Church_ChurchSuperGroup1_DistrictId",
                table: "Church",
                column: "DistrictId",
                principalTable: "ChurchSuperGroup1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Church_Persons_SecretaryId",
                table: "Church",
                column: "SecretaryId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Church_Persons_SeniorPastorId",
                table: "Church",
                column: "SeniorPastorId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Church_Status_StatusId",
                table: "Church",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChurchSuperGroup1_Church_DistrictHQId",
                table: "ChurchSuperGroup1",
                column: "DistrictHQId",
                principalTable: "Church",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChurchSuperGroup1_ChurchSuperGroup2_RegionId",
                table: "ChurchSuperGroup1",
                column: "RegionId",
                principalTable: "ChurchSuperGroup2",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChurchSuperGroup2_Church_RegionHQId",
                table: "ChurchSuperGroup2",
                column: "RegionHQId",
                principalTable: "Church",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Status_StatusId",
                table: "Event",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventRegistration_Persons_AttendeeId",
                table: "EventRegistration",
                column: "AttendeeId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventRegistration_Event_EventId",
                table: "EventRegistration",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Church_ChurchId1",
                table: "Persons",
                column: "ChurchId1",
                principalTable: "Church",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Church_ChurchId",
                table: "Persons",
                column: "ChurchId",
                principalTable: "Church",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Status_GenderId",
                table: "Persons",
                column: "GenderId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Status_MaritalStatusId",
                table: "Persons",
                column: "MaritalStatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Status_StatusId",
                table: "Persons",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Church_ChurchSuperGroup1_DistrictId",
                table: "Church");

            migrationBuilder.DropForeignKey(
                name: "FK_Church_Persons_SecretaryId",
                table: "Church");

            migrationBuilder.DropForeignKey(
                name: "FK_Church_Persons_SeniorPastorId",
                table: "Church");

            migrationBuilder.DropForeignKey(
                name: "FK_Church_Status_StatusId",
                table: "Church");

            migrationBuilder.DropForeignKey(
                name: "FK_ChurchSuperGroup1_Church_DistrictHQId",
                table: "ChurchSuperGroup1");

            migrationBuilder.DropForeignKey(
                name: "FK_ChurchSuperGroup1_ChurchSuperGroup2_RegionId",
                table: "ChurchSuperGroup1");

            migrationBuilder.DropForeignKey(
                name: "FK_ChurchSuperGroup2_Church_RegionHQId",
                table: "ChurchSuperGroup2");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_Status_StatusId",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_EventRegistration_Persons_AttendeeId",
                table: "EventRegistration");

            migrationBuilder.DropForeignKey(
                name: "FK_EventRegistration_Event_EventId",
                table: "EventRegistration");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Church_ChurchId1",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Church_ChurchId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Status_GenderId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Status_MaritalStatusId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Status_StatusId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_ChurchId1",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_ChurchId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_GenderId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_MaritalStatusId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_StatusId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_EventRegistration_AttendeeId",
                table: "EventRegistration");

            migrationBuilder.DropIndex(
                name: "IX_EventRegistration_EventId",
                table: "EventRegistration");

            migrationBuilder.DropIndex(
                name: "IX_Event_StatusId",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Church_DistrictId",
                table: "Church");

            migrationBuilder.DropIndex(
                name: "IX_Church_SecretaryId",
                table: "Church");

            migrationBuilder.DropIndex(
                name: "IX_Church_SeniorPastorId",
                table: "Church");

            migrationBuilder.DropIndex(
                name: "IX_ChurchSuperGroup2_RegionHQId",
                table: "ChurchSuperGroup2");

            migrationBuilder.DropIndex(
                name: "IX_ChurchSuperGroup1_DistrictHQId",
                table: "ChurchSuperGroup1");

            migrationBuilder.DropIndex(
                name: "IX_ChurchSuperGroup1_RegionId",
                table: "ChurchSuperGroup1");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "ChurchId1",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "MemberSince",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "ChurchId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "MaritalStatusId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "AttendeeId",
                table: "EventRegistration");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "EventRegistration");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "Church");

            migrationBuilder.DropColumn(
                name: "SecretaryId",
                table: "Church");

            migrationBuilder.DropColumn(
                name: "SeniorPastorId",
                table: "Church");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ChurchSuperGroup2");

            migrationBuilder.DropColumn(
                name: "RegionHQId",
                table: "ChurchSuperGroup2");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ChurchSuperGroup1");

            migrationBuilder.DropColumn(
                name: "DistrictHQId",
                table: "ChurchSuperGroup1");

            migrationBuilder.DropColumn(
                name: "RegionId",
                table: "ChurchSuperGroup1");

            migrationBuilder.RenameColumn(
                name: "Gender_Name",
                table: "Status",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Gender_Description",
                table: "Status",
                newName: "Description");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Church_ChurchStatus_StatusId",
                table: "Church",
                column: "StatusId",
                principalTable: "ChurchStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
