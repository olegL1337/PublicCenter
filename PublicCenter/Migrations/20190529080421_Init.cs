using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace PublicCenter.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    City = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Addr = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Status_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DepartmentID = table.Column<int>(nullable: true),
                    First_name = table.Column<string>(nullable: true),
                    Last_name = table.Column<string>(nullable: true),
                    Father_name = table.Column<string>(nullable: true),
                    AddressID = table.Column<int>(nullable: true),
                    Phone_stat = table.Column<string>(nullable: true),
                    Mobile_phone = table.Column<string>(nullable: true),
                    Passport = table.Column<string>(nullable: true),
                    Identify_number = table.Column<string>(nullable: true),
                    Date_birth = table.Column<DateTime>(nullable: true),
                    Age = table.Column<int>(nullable: true),
                    Sex = table.Column<bool>(nullable: true),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Workers_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    ServiceTypeID = table.Column<int>(nullable: true),
                    GroupOfMotorActivity = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Services_ServiceTypes_ServiceTypeID",
                        column: x => x.ServiceTypeID,
                        principalTable: "ServiceTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    WorkerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Departments_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DepartmentID = table.Column<int>(nullable: true),
                    First_name = table.Column<string>(nullable: true),
                    Last_name = table.Column<string>(nullable: true),
                    Father_name = table.Column<string>(nullable: true),
                    Formal_addressId = table.Column<int>(nullable: true),
                    Real_addressId = table.Column<int>(nullable: true),
                    Phone_stat = table.Column<string>(nullable: true),
                    Mobile_phone = table.Column<string>(nullable: true),
                    Personal_file_number = table.Column<string>(nullable: true),
                    Date_birth = table.Column<DateTime>(nullable: true),
                    Age = table.Column<int>(nullable: true),
                    Sex = table.Column<bool>(nullable: true),
                    Passport = table.Column<string>(nullable: true),
                    Identify_number = table.Column<string>(nullable: false),
                    Group = table.Column<string>(nullable: true),
                    Period = table.Column<string>(nullable: true),
                    Degree_Indiv_Need = table.Column<string>(nullable: true),
                    Group_Motor_Activity = table.Column<string>(nullable: true),
                    Ability_Self_Service = table.Column<string>(nullable: true),
                    Condition_Giving_Service = table.Column<string>(nullable: true),
                    Number_Of_Visit = table.Column<string>(nullable: true),
                    WorkerID = table.Column<int>(nullable: true),
                    Organization_Service_House = table.Column<string>(nullable: true),
                    Is_active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ID);
                    table.UniqueConstraint("AK_Clients_Identify_number", x => x.Identify_number);
                    table.ForeignKey(
                        name: "FK_Clients_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clients_Addresses_Formal_addressId",
                        column: x => x.Formal_addressId,
                        principalTable: "Addresses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clients_Addresses_Real_addressId",
                        column: x => x.Real_addressId,
                        principalTable: "Addresses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clients_Workers_WorkerID",
                        column: x => x.WorkerID,
                        principalTable: "Workers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClientStatuses",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientStatuses", x => new { x.ClientID, x.StatusId });
                    table.ForeignKey(
                        name: "FK_ClientStatuses_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientStatuses_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientTypeOfServices",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false),
                    ServiceTypeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTypeOfServices", x => new { x.ClientID, x.ServiceTypeID });
                    table.ForeignKey(
                        name: "FK_ClientTypeOfServices_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientTypeOfServices_Services_ServiceTypeID",
                        column: x => x.ServiceTypeID,
                        principalTable: "Services",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoneWorks",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    WorkerID = table.Column<int>(nullable: true),
                    ClientID = table.Column<int>(nullable: true),
                    ServiceID = table.Column<int>(nullable: true),
                    Date_of_service = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoneWorks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DoneWorks_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DoneWorks_Services_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "Services",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DoneWorks_Workers_WorkerID",
                        column: x => x.WorkerID,
                        principalTable: "Workers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false),
                    Day = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => new { x.ClientID, x.Day });
                    table.ForeignKey(
                        name: "FK_Schedules_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_DepartmentID",
                table: "Clients",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_Formal_addressId",
                table: "Clients",
                column: "Formal_addressId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_Real_addressId",
                table: "Clients",
                column: "Real_addressId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_WorkerID",
                table: "Clients",
                column: "WorkerID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientStatuses_StatusId",
                table: "ClientStatuses",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientTypeOfServices_ServiceTypeID",
                table: "ClientTypeOfServices",
                column: "ServiceTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_WorkerId",
                table: "Departments",
                column: "WorkerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DoneWorks_ClientID",
                table: "DoneWorks",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_DoneWorks_ServiceID",
                table: "DoneWorks",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_DoneWorks_WorkerID",
                table: "DoneWorks",
                column: "WorkerID");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ServiceTypeID",
                table: "Services",
                column: "ServiceTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Workers_AddressID",
                table: "Workers",
                column: "AddressID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientStatuses");

            migrationBuilder.DropTable(
                name: "ClientTypeOfServices");

            migrationBuilder.DropTable(
                name: "DoneWorks");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "ServiceTypes");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Workers");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
