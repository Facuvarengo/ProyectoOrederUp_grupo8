using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class BaseDeDatosFuncional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ingredientesOpciones_ingredientes_IdIngrediente",
                table: "ingredientesOpciones");

            migrationBuilder.DropForeignKey(
                name: "FK_ingredientesOpciones_opciones_IdOpcion",
                table: "ingredientesOpciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pedidos",
                table: "pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_opciones",
                table: "opciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ingredientesOpciones",
                table: "ingredientesOpciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ingredientes",
                table: "ingredientes");

            migrationBuilder.RenameTable(
                name: "usuarios",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "pedidos",
                newName: "Pedidos");

            migrationBuilder.RenameTable(
                name: "opciones",
                newName: "Opciones");

            migrationBuilder.RenameTable(
                name: "ingredientesOpciones",
                newName: "IngredientesOpciones");

            migrationBuilder.RenameTable(
                name: "ingredientes",
                newName: "Ingredientes");

            migrationBuilder.RenameIndex(
                name: "IX_ingredientesOpciones_IdOpcion",
                table: "IngredientesOpciones",
                newName: "IX_IngredientesOpciones_IdOpcion");

            migrationBuilder.RenameIndex(
                name: "IX_ingredientesOpciones_IdIngrediente",
                table: "IngredientesOpciones",
                newName: "IX_IngredientesOpciones_IdIngrediente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pedidos",
                table: "Pedidos",
                column: "IdPedido");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Opciones",
                table: "Opciones",
                column: "IdOpcion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngredientesOpciones",
                table: "IngredientesOpciones",
                column: "IdIngredienteopcion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ingredientes",
                table: "Ingredientes",
                column: "IdIngredientes");

            migrationBuilder.CreateTable(
                name: "OpcionPedido",
                columns: table => new
                {
                    IdOpcionPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPedido = table.Column<int>(type: "int", nullable: false),
                    IdOpcion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpcionPedido", x => x.IdOpcionPedido);
                    table.ForeignKey(
                        name: "FK_OpcionPedido_Opciones_IdOpcion",
                        column: x => x.IdOpcion,
                        principalTable: "Opciones",
                        principalColumn: "IdOpcion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OpcionPedido_Pedidos_IdPedido",
                        column: x => x.IdPedido,
                        principalTable: "Pedidos",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OpcionPedido_IdOpcion",
                table: "OpcionPedido",
                column: "IdOpcion");

            migrationBuilder.CreateIndex(
                name: "IX_OpcionPedido_IdPedido",
                table: "OpcionPedido",
                column: "IdPedido");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientesOpciones_Ingredientes_IdIngrediente",
                table: "IngredientesOpciones",
                column: "IdIngrediente",
                principalTable: "Ingredientes",
                principalColumn: "IdIngredientes",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientesOpciones_Opciones_IdOpcion",
                table: "IngredientesOpciones",
                column: "IdOpcion",
                principalTable: "Opciones",
                principalColumn: "IdOpcion",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientesOpciones_Ingredientes_IdIngrediente",
                table: "IngredientesOpciones");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientesOpciones_Opciones_IdOpcion",
                table: "IngredientesOpciones");

            migrationBuilder.DropTable(
                name: "OpcionPedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pedidos",
                table: "Pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Opciones",
                table: "Opciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IngredientesOpciones",
                table: "IngredientesOpciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ingredientes",
                table: "Ingredientes");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "usuarios");

            migrationBuilder.RenameTable(
                name: "Pedidos",
                newName: "pedidos");

            migrationBuilder.RenameTable(
                name: "Opciones",
                newName: "opciones");

            migrationBuilder.RenameTable(
                name: "IngredientesOpciones",
                newName: "ingredientesOpciones");

            migrationBuilder.RenameTable(
                name: "Ingredientes",
                newName: "ingredientes");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientesOpciones_IdOpcion",
                table: "ingredientesOpciones",
                newName: "IX_ingredientesOpciones_IdOpcion");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientesOpciones_IdIngrediente",
                table: "ingredientesOpciones",
                newName: "IX_ingredientesOpciones_IdIngrediente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pedidos",
                table: "pedidos",
                column: "IdPedido");

            migrationBuilder.AddPrimaryKey(
                name: "PK_opciones",
                table: "opciones",
                column: "IdOpcion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ingredientesOpciones",
                table: "ingredientesOpciones",
                column: "IdIngredienteopcion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ingredientes",
                table: "ingredientes",
                column: "IdIngredientes");

            migrationBuilder.AddForeignKey(
                name: "FK_ingredientesOpciones_ingredientes_IdIngrediente",
                table: "ingredientesOpciones",
                column: "IdIngrediente",
                principalTable: "ingredientes",
                principalColumn: "IdIngredientes",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ingredientesOpciones_opciones_IdOpcion",
                table: "ingredientesOpciones",
                column: "IdOpcion",
                principalTable: "opciones",
                principalColumn: "IdOpcion",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
