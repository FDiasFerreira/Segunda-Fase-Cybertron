using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SegundaFase.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Categorias",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Fornecedores",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    FantasyName = table.Column<string>(type: "varchar(200)", nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    CompanyName = table.Column<string>(type: "varchar(200)", nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(14)", nullable: true),
                    OpenDate = table.Column<DateTime>(nullable: true),
                    FullName = table.Column<string>(type: "varchar(200)", nullable: true),
                    CPF = table.Column<string>(type: "varchar(14)", nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Fornecedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_E-mails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    SupplierId = table.Column<Guid>(nullable: false),
                    EmailAddress = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_E-mails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_E-mails_Tb_Fornecedores_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Tb_Fornecedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Endereços",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    SupplierId = table.Column<Guid>(nullable: false),
                    ZipCode = table.Column<string>(type: "varchar(8)", nullable: false),
                    Street = table.Column<string>(type: "varchar(200)", nullable: false),
                    Number = table.Column<string>(type: "varchar(10)", nullable: false),
                    Complement = table.Column<string>(type: "varchar(200)", nullable: true),
                    Reference = table.Column<string>(type: "varchar(200)", nullable: true),
                    Neighborhood = table.Column<string>(type: "varchar(50)", nullable: false),
                    City = table.Column<string>(type: "varchar(50)", nullable: false),
                    State = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Endereços", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_Endereços_Tb_Fornecedores_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Tb_Fornecedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Produtos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    SupplierId = table.Column<Guid>(nullable: false),
                    CategoryId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: false),
                    BarCode = table.Column<string>(type: "varchar(13)", nullable: false),
                    QuantityStock = table.Column<string>(type: "varchar(200)", nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    PriceSales = table.Column<decimal>(nullable: false),
                    PricePurchase = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_Produtos_Tb_Categorias_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Tb_Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_Produtos_Tb_Fornecedores_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Tb_Fornecedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Telefones",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    SupplierId = table.Column<Guid>(nullable: false),
                    Ddd = table.Column<string>(type: "varchar(2)", nullable: false),
                    Number = table.Column<string>(type: "varchar(9)", nullable: false),
                    PhoneType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Telefones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_Telefones_Tb_Fornecedores_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Tb_Fornecedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    ProductId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Tb_Produtos_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Tb_Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_E-mails_SupplierId",
                table: "Tb_E-mails",
                column: "SupplierId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Endereços_SupplierId",
                table: "Tb_Endereços",
                column: "SupplierId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Produtos_CategoryId",
                table: "Tb_Produtos",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Produtos_SupplierId",
                table: "Tb_Produtos",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Telefones_SupplierId",
                table: "Tb_Telefones",
                column: "SupplierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Tb_E-mails");

            migrationBuilder.DropTable(
                name: "Tb_Endereços");

            migrationBuilder.DropTable(
                name: "Tb_Telefones");

            migrationBuilder.DropTable(
                name: "Tb_Produtos");

            migrationBuilder.DropTable(
                name: "Tb_Categorias");

            migrationBuilder.DropTable(
                name: "Tb_Fornecedores");
        }
    }
}
