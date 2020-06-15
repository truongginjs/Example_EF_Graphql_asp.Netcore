using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Example_EF_graphql_asp.NET.Migrations
{
    public partial class initializedwithdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Deleted", "Detail", "Name" },
                values: new object[] { new Guid("678ab5c1-6623-4771-be40-206fc537998e"), false, "Quan de mat", "Quan" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Deleted", "Detail", "Name" },
                values: new object[] { new Guid("1ab113f3-944a-4705-b592-1c5d3bbfbf97"), false, "Ao cung de mac", "Ao" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Deleted", "Detail", "Name" },
                values: new object[] { new Guid("2e87ef0b-33f5-4c1e-9116-72c21a30bfc1"), false, "Khan de choan co", "Khan" });
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Deleted", "Detail", "Name","Cost","CategoryID" },
                values: new object[] { new Guid("ca11a8c6-1438-438d-aa67-c1f432280006"), false, "OMG", "Quan dai den",1000000, new Guid("678ab5c1-6623-4771-be40-206fc537998e") });
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Deleted", "Detail", "Name", "Cost", "CategoryID" },
                values: new object[] { new Guid("5df26f8d-9574-4a24-a1de-f913e2e481ca"), false, "OMG", "Quan ngan caro", 1000000, new Guid("678ab5c1-6623-4771-be40-206fc537998e") });
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Deleted", "Detail", "Name", "Cost", "CategoryID" },
                values: new object[] { new Guid("2a0953df-922e-4607-9622-459b541f3337"), false, "OMG", "Ao somi trang", 1001000, new Guid("1ab113f3-944a-4705-b592-1c5d3bbfbf97") });
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Deleted", "Detail", "Name", "Cost", "CategoryID" },
                values: new object[] { new Guid("b43c857f-c48a-47b7-91d4-df6ae5926ddb"), false, "OMG", "Ao thun den", 1000000, new Guid("1ab113f3-944a-4705-b592-1c5d3bbfbf97") });
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Deleted", "Detail", "Name", "Cost", "CategoryID" },
                values: new object[] { new Guid("27a5871e-9c68-4a23-bb28-d83ab3415a73"), false, "OMG", "Chiec khan phien", 1000000, new Guid("2e87ef0b-33f5-4c1e-9116-72c21a30bfc1") });

            migrationBuilder.Sql(@"CREATE PROCEDURE MyCustomProcedure
                                   AS
                                   SELECT * FROM Category");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ca11a8c6-1438-438d-aa67-c1f432280006"));
            
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5df26f8d-9574-4a24-a1de-f913e2e481ca"));
            
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2a0953df-922e-4607-9622-459b541f3337"));
            
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b43c857f-c48a-47b7-91d4-df6ae5926ddb"));
            
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("27a5871e-9c68-4a23-bb28-d83ab3415a73"));
            
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1ab113f3-944a-4705-b592-1c5d3bbfbf97"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2e87ef0b-33f5-4c1e-9116-72c21a30bfc1"));
            
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("678ab5c1-6623-4771-be40-206fc537998e"));

            migrationBuilder.Sql(@"DROP PROCEDURE MyCustomProcedure");
        }
    }
}
