﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoiceManagementSystem.DataAccess.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CardId",
                table: "Payments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 252, 31, 104, 140, 247, 32, 245, 233, 255, 106, 99, 111, 76, 28, 196, 162, 17, 75, 216, 55, 200, 3, 30, 29, 168, 34, 19, 44, 246, 54, 14, 232, 122, 172, 19, 216, 4, 250, 211, 156, 108, 181, 99, 236, 102, 20, 126, 31, 196, 221, 23, 159, 78, 15, 228, 218, 37, 237, 198, 140, 99, 71, 3 }, new byte[] { 107, 69, 50, 150, 108, 70, 51, 41, 176, 153, 208, 7, 195, 16, 246, 63, 22, 58, 23, 149, 247, 192, 64, 195, 210, 43, 181, 46, 62, 84, 207, 211, 79, 88, 173, 67, 164, 140, 60, 119, 218, 234, 103, 254, 67, 137, 181, 54, 75, 97, 156, 111, 203, 228, 163, 79, 57, 209, 177, 106, 125, 228, 90, 149, 69, 67, 172, 149, 65, 150, 185, 168, 118, 247, 254, 208, 187, 171, 161, 116, 49, 127, 17, 66, 212, 251, 27, 227, 83, 102, 122, 13, 126, 231, 187, 8, 45, 194, 244, 11, 11, 203, 255, 189, 126, 240, 190, 99, 206, 94, 254, 153, 77, 10, 186, 105, 143, 126, 105, 128, 241, 170, 244, 159, 253, 31, 150, 162 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 252, 31, 104, 140, 247, 32, 245, 233, 255, 106, 99, 111, 76, 28, 196, 162, 17, 75, 216, 55, 200, 3, 30, 29, 168, 34, 19, 44, 246, 54, 14, 232, 122, 172, 19, 216, 4, 250, 211, 156, 108, 181, 99, 236, 102, 20, 126, 31, 196, 221, 23, 159, 78, 15, 228, 218, 37, 237, 198, 140, 99, 71, 3 }, new byte[] { 107, 69, 50, 150, 108, 70, 51, 41, 176, 153, 208, 7, 195, 16, 246, 63, 22, 58, 23, 149, 247, 192, 64, 195, 210, 43, 181, 46, 62, 84, 207, 211, 79, 88, 173, 67, 164, 140, 60, 119, 218, 234, 103, 254, 67, 137, 181, 54, 75, 97, 156, 111, 203, 228, 163, 79, 57, 209, 177, 106, 125, 228, 90, 149, 69, 67, 172, 149, 65, 150, 185, 168, 118, 247, 254, 208, 187, 171, 161, 116, 49, 127, 17, 66, 212, 251, 27, 227, 83, 102, 122, 13, 126, 231, 187, 8, 45, 194, 244, 11, 11, 203, 255, 189, 126, 240, 190, 99, 206, 94, 254, 153, 77, 10, 186, 105, 143, 126, 105, 128, 241, 170, 244, 159, 253, 31, 150, 162 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 252, 31, 104, 140, 247, 32, 245, 233, 255, 106, 99, 111, 76, 28, 196, 162, 17, 75, 216, 55, 200, 3, 30, 29, 168, 34, 19, 44, 246, 54, 14, 232, 122, 172, 19, 216, 4, 250, 211, 156, 108, 181, 99, 236, 102, 20, 126, 31, 196, 221, 23, 159, 78, 15, 228, 218, 37, 237, 198, 140, 99, 71, 3 }, new byte[] { 107, 69, 50, 150, 108, 70, 51, 41, 176, 153, 208, 7, 195, 16, 246, 63, 22, 58, 23, 149, 247, 192, 64, 195, 210, 43, 181, 46, 62, 84, 207, 211, 79, 88, 173, 67, 164, 140, 60, 119, 218, 234, 103, 254, 67, 137, 181, 54, 75, 97, 156, 111, 203, 228, 163, 79, 57, 209, 177, 106, 125, 228, 90, 149, 69, 67, 172, 149, 65, 150, 185, 168, 118, 247, 254, 208, 187, 171, 161, 116, 49, 127, 17, 66, 212, 251, 27, 227, 83, 102, 122, 13, 126, 231, 187, 8, 45, 194, 244, 11, 11, 203, 255, 189, 126, 240, 190, 99, 206, 94, 254, 153, 77, 10, 186, 105, 143, 126, 105, 128, 241, 170, 244, 159, 253, 31, 150, 162 } });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CardId",
                table: "Payments",
                column: "CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Cards_CardId",
                table: "Payments",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Cards_CardId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_CardId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "Payments");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 10, 139, 94, 235, 41, 218, 90, 36, 55, 160, 143, 160, 251, 124, 87, 79, 196, 202, 246, 18, 176, 251, 192, 73, 178, 199, 21, 174, 233, 92, 94, 33, 155, 46, 172, 127, 19, 78, 164, 34, 5, 173, 179, 85, 223, 23, 93, 47, 144, 26, 246, 198, 113, 228, 83, 129, 52, 72, 57, 244, 133, 154, 249, 200 }, new byte[] { 116, 6, 139, 142, 251, 55, 38, 132, 97, 132, 218, 194, 152, 110, 33, 71, 101, 137, 55, 33, 235, 220, 249, 113, 126, 73, 175, 92, 148, 49, 17, 203, 220, 121, 94, 36, 187, 210, 238, 228, 129, 163, 252, 55, 219, 189, 1, 154, 113, 60, 10, 32, 218, 173, 43, 111, 196, 250, 197, 147, 49, 8, 159, 129, 205, 78, 167, 0, 111, 193, 165, 113, 16, 47, 143, 73, 207, 214, 163, 29, 12, 149, 14, 27, 121, 25, 207, 250, 194, 52, 110, 193, 108, 80, 157, 186, 129, 57, 156, 96, 174, 113, 189, 190, 83, 215, 120, 247, 69, 241, 175, 142, 52, 243, 151, 69, 125, 75, 215, 68, 160, 26, 140, 16, 184, 45, 171, 87 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 10, 139, 94, 235, 41, 218, 90, 36, 55, 160, 143, 160, 251, 124, 87, 79, 196, 202, 246, 18, 176, 251, 192, 73, 178, 199, 21, 174, 233, 92, 94, 33, 155, 46, 172, 127, 19, 78, 164, 34, 5, 173, 179, 85, 223, 23, 93, 47, 144, 26, 246, 198, 113, 228, 83, 129, 52, 72, 57, 244, 133, 154, 249, 200 }, new byte[] { 116, 6, 139, 142, 251, 55, 38, 132, 97, 132, 218, 194, 152, 110, 33, 71, 101, 137, 55, 33, 235, 220, 249, 113, 126, 73, 175, 92, 148, 49, 17, 203, 220, 121, 94, 36, 187, 210, 238, 228, 129, 163, 252, 55, 219, 189, 1, 154, 113, 60, 10, 32, 218, 173, 43, 111, 196, 250, 197, 147, 49, 8, 159, 129, 205, 78, 167, 0, 111, 193, 165, 113, 16, 47, 143, 73, 207, 214, 163, 29, 12, 149, 14, 27, 121, 25, 207, 250, 194, 52, 110, 193, 108, 80, 157, 186, 129, 57, 156, 96, 174, 113, 189, 190, 83, 215, 120, 247, 69, 241, 175, 142, 52, 243, 151, 69, 125, 75, 215, 68, 160, 26, 140, 16, 184, 45, 171, 87 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 10, 139, 94, 235, 41, 218, 90, 36, 55, 160, 143, 160, 251, 124, 87, 79, 196, 202, 246, 18, 176, 251, 192, 73, 178, 199, 21, 174, 233, 92, 94, 33, 155, 46, 172, 127, 19, 78, 164, 34, 5, 173, 179, 85, 223, 23, 93, 47, 144, 26, 246, 198, 113, 228, 83, 129, 52, 72, 57, 244, 133, 154, 249, 200 }, new byte[] { 116, 6, 139, 142, 251, 55, 38, 132, 97, 132, 218, 194, 152, 110, 33, 71, 101, 137, 55, 33, 235, 220, 249, 113, 126, 73, 175, 92, 148, 49, 17, 203, 220, 121, 94, 36, 187, 210, 238, 228, 129, 163, 252, 55, 219, 189, 1, 154, 113, 60, 10, 32, 218, 173, 43, 111, 196, 250, 197, 147, 49, 8, 159, 129, 205, 78, 167, 0, 111, 193, 165, 113, 16, 47, 143, 73, 207, 214, 163, 29, 12, 149, 14, 27, 121, 25, 207, 250, 194, 52, 110, 193, 108, 80, 157, 186, 129, 57, 156, 96, 174, 113, 189, 190, 83, 215, 120, 247, 69, 241, 175, 142, 52, 243, 151, 69, 125, 75, 215, 68, 160, 26, 140, 16, 184, 45, 171, 87 } });
        }
    }
}
