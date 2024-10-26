﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Desafio_Marlin.Migrations
{
    /// <inheritdoc />
    public partial class IdMatricula : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Matriculas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Matriculas");
        }
    }
}