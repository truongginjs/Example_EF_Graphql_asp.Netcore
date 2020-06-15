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
                values: new object[] { new Guid("678ab5c1-6623-4771-be40-206fc537998e"), false, "something just like this", "John Doe" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Deleted", "Detail", "Name" },
                values: new object[] { new Guid("1ab113f3-944a-4705-b592-1c5d3bbfbf97"), false, "something just like this", "Jane Doe" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Deleted", "Detail", "Name" },
                values: new object[] { new Guid("2e87ef0b-33f5-4c1e-9116-72c21a30bfc1"), false, "OMG", "Mike Miles" });
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Deleted", "Detail", "Name","Cost","CategoryID" },
                values: new object[] { new Guid("ca11a8c6-1438-438d-aa67-c1f432280006"), false, "OMG", "Quan",1000000, new Guid("2e87ef0b-33f5-4c1e-9116-72c21a30bfc1") });

            migrationBuilder.Sql(@"CREATE PROCEDURE MyCustomProcedure
                                   AS
                                   SELECT * FROM Category");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1ab113f3-944a-4705-b592-1c5d3bbfbf97"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2e87ef0b-33f5-4c1e-9116-72c21a30bfc1"));
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ca11a8c6-1438-438d-aa67-c1f432280006"));
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("678ab5c1-6623-4771-be40-206fc537998e"));

            migrationBuilder.Sql(@"DROP PROCEDURE MyCustomProcedure");
        }
    }
}
