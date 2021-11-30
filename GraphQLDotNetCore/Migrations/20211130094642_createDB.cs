using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GraphQLDotNetCore.Migrations
{
    public partial class createDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("9769d8ae-8177-4ebd-becd-d1ce1e2fbcb6"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("ad5ea9b0-00ed-442d-b6cc-cc54020cb93c"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("baab1c53-0c94-42c7-898e-9ca324bd8ca3"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("2c22c84d-563b-49a4-b36d-1b40c47735d8"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("482d51db-5e3f-46b9-bd9f-7303bcb4b4b9"));

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { new Guid("9379ac5b-c7d9-4124-85bc-9b8bbe9eabae"), "John Doe's address", "John Doe" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { new Guid("557d715a-e3e2-4797-818a-e268e02ea7d5"), "Jane Doe's address", "Jane Doe" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Description", "OwnerId", "Type" },
                values: new object[] { new Guid("447199b8-decc-44ae-a587-6fec724a076c"), "Cash account for our users", new Guid("9379ac5b-c7d9-4124-85bc-9b8bbe9eabae"), 0 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Description", "OwnerId", "Type" },
                values: new object[] { new Guid("51cfa1aa-49e2-460b-83da-3475bf6f200f"), "Savings account for our users", new Guid("557d715a-e3e2-4797-818a-e268e02ea7d5"), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Description", "OwnerId", "Type" },
                values: new object[] { new Guid("d64acaa7-7602-4f30-91b5-79e0a6268c0b"), "Income account for our users", new Guid("557d715a-e3e2-4797-818a-e268e02ea7d5"), 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("447199b8-decc-44ae-a587-6fec724a076c"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("51cfa1aa-49e2-460b-83da-3475bf6f200f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d64acaa7-7602-4f30-91b5-79e0a6268c0b"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("557d715a-e3e2-4797-818a-e268e02ea7d5"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("9379ac5b-c7d9-4124-85bc-9b8bbe9eabae"));

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { new Guid("2c22c84d-563b-49a4-b36d-1b40c47735d8"), "John Doe's address", "John Doe" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { new Guid("482d51db-5e3f-46b9-bd9f-7303bcb4b4b9"), "Jane Doe's address", "Jane Doe" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Description", "OwnerId", "Type" },
                values: new object[] { new Guid("baab1c53-0c94-42c7-898e-9ca324bd8ca3"), "Cash account for our users", new Guid("2c22c84d-563b-49a4-b36d-1b40c47735d8"), 0 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Description", "OwnerId", "Type" },
                values: new object[] { new Guid("ad5ea9b0-00ed-442d-b6cc-cc54020cb93c"), "Savings account for our users", new Guid("482d51db-5e3f-46b9-bd9f-7303bcb4b4b9"), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Description", "OwnerId", "Type" },
                values: new object[] { new Guid("9769d8ae-8177-4ebd-becd-d1ce1e2fbcb6"), "Income account for our users", new Guid("482d51db-5e3f-46b9-bd9f-7303bcb4b4b9"), 3 });
        }
    }
}
