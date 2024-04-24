﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DanielaMora_Examen.Migrations
{
    /// <inheritdoc />
    public partial class DanielaMora_DB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DM_tabla1",
                columns: table => new
                {
                    IdDm = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CuentaAhorro = table.Column<bool>(type: "bit", nullable: false),
                    CuentaCorriente = table.Column<bool>(type: "bit", nullable: false),
                    CitaConsulta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DineroDisponible = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_tabla1", x => x.IdDm);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DM_tabla1");
        }
    }
}
