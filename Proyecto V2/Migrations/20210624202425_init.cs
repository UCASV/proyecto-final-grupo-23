using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Proyecto_V2.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cabin",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    adress = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    phone = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    mandated = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cabin", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "disease",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    disease = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_disease", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "group_priority",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    groupp = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_group_priority", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "side_effects",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    side_effects = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_side_effects", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "type_employee",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    typee = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_type_employee", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "type_institution",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    typee = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_type_institution", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "vaccination",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    date_vaccine = table.Column<DateTime>(type: "date", nullable: true),
                    id_cabin = table.Column<int>(type: "int", nullable: true),
                    id_Side_effects = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vaccination", x => x.id);
                    table.ForeignKey(
                        name: "vaccination_ibfk_1",
                        column: x => x.id_cabin,
                        principalTable: "cabin",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "vaccination_ibfk_2",
                        column: x => x.id_Side_effects,
                        principalTable: "side_effects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "employee",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name_employee = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    adress = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    user_employee = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    password_employee = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    id_type_employee = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.id);
                    table.ForeignKey(
                        name: "employee_ibfk_1",
                        column: x => x.id_type_employee,
                        principalTable: "type_employee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "pacient",
                columns: table => new
                {
                    DUI = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    name_pacient = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    adress_pacient = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    phone = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    id_Disease = table.Column<int>(type: "int", nullable: true),
                    id_type_institution = table.Column<int>(type: "int", nullable: true),
                    id_group_priority = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.DUI);
                    table.ForeignKey(
                        name: "pacient_ibfk_1",
                        column: x => x.id_Disease,
                        principalTable: "disease",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "pacient_ibfk_2",
                        column: x => x.id_type_institution,
                        principalTable: "type_institution",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "pacient_ibfk_3",
                        column: x => x.id_group_priority,
                        principalTable: "group_priority",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cabinxemployee",
                columns: table => new
                {
                    id_cabin = table.Column<int>(type: "int", nullable: false),
                    id_employee = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.id_cabin, x.id_employee });
                    table.ForeignKey(
                        name: "FK_cabinxemployee_cabin",
                        column: x => x.id_cabin,
                        principalTable: "cabin",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_cabinXemployee_employee",
                        column: x => x.id_employee,
                        principalTable: "employee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "record",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    date_record = table.Column<DateTime>(type: "date", nullable: true),
                    id_cabin = table.Column<int>(type: "int", nullable: true),
                    id_employee = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_record", x => x.id);
                    table.ForeignKey(
                        name: "record_ibfk_1",
                        column: x => x.id_cabin,
                        principalTable: "cabin",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "record_ibfk_2",
                        column: x => x.id_employee,
                        principalTable: "employee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "quotee",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    date_vaccine = table.Column<DateTime>(type: "date", nullable: true),
                    place_vaccination = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    id_cabin = table.Column<int>(type: "int", nullable: true),
                    DUI_pacient = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quotee", x => x.id);
                    table.ForeignKey(
                        name: "quotee_ibfk_1",
                        column: x => x.id_cabin,
                        principalTable: "cabin",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "quotee_ibfk_2",
                        column: x => x.DUI_pacient,
                        principalTable: "pacient",
                        principalColumn: "DUI",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "fk_cabinXemployee_employee",
                table: "cabinxemployee",
                column: "id_employee");

            migrationBuilder.CreateIndex(
                name: "id_type_employee",
                table: "employee",
                column: "id_type_employee");

            migrationBuilder.CreateIndex(
                name: "id_Disease",
                table: "pacient",
                column: "id_Disease");

            migrationBuilder.CreateIndex(
                name: "id_group_priority",
                table: "pacient",
                column: "id_group_priority");

            migrationBuilder.CreateIndex(
                name: "id_type_institution",
                table: "pacient",
                column: "id_type_institution");

            migrationBuilder.CreateIndex(
                name: "DUI_pacient",
                table: "quotee",
                column: "DUI_pacient");

            migrationBuilder.CreateIndex(
                name: "id_cabin",
                table: "quotee",
                column: "id_cabin");

            migrationBuilder.CreateIndex(
                name: "id_cabin1",
                table: "record",
                column: "id_cabin");

            migrationBuilder.CreateIndex(
                name: "id_employee",
                table: "record",
                column: "id_employee");

            migrationBuilder.CreateIndex(
                name: "id_cabin2",
                table: "vaccination",
                column: "id_cabin");

            migrationBuilder.CreateIndex(
                name: "id_Side_effects",
                table: "vaccination",
                column: "id_Side_effects");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cabinxemployee");

            migrationBuilder.DropTable(
                name: "quotee");

            migrationBuilder.DropTable(
                name: "record");

            migrationBuilder.DropTable(
                name: "vaccination");

            migrationBuilder.DropTable(
                name: "pacient");

            migrationBuilder.DropTable(
                name: "employee");

            migrationBuilder.DropTable(
                name: "cabin");

            migrationBuilder.DropTable(
                name: "side_effects");

            migrationBuilder.DropTable(
                name: "disease");

            migrationBuilder.DropTable(
                name: "type_institution");

            migrationBuilder.DropTable(
                name: "group_priority");

            migrationBuilder.DropTable(
                name: "type_employee");
        }
    }
}
