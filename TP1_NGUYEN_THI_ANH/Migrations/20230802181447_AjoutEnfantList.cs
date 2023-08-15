using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP2.Migrations
{
    public partial class AjoutEnfantList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enfant_Parents_ParentId",
                table: "Enfant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enfant",
                table: "Enfant");

            migrationBuilder.DropIndex(
                name: "IX_Enfant_ParentId",
                table: "Enfant");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Enfant");

            migrationBuilder.RenameTable(
                name: "Enfant",
                newName: "Enfants");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enfants",
                table: "Enfants",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Description", "ImageURL", "Nom" },
                values: new object[] { 1, "Le loremuite de mots sans  utilisée à titre provisoire pour calibrer une mise en page le texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page.", "/Image/parent top.jpeg", "NOUVEAUX" });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Description", "ImageURL", "Nom" },
                values: new object[] { 2, "Le loremuite de mots sans  utilisée à titre provisoire pour calibrer une mise en page le texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page.", "/Image/parent-is comming.jpeg", "À VENIR" });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Description", "ImageURL", "Nom" },
                values: new object[] { 3, "Le loremuite de mots sans  utilisée à titre provisoire pour calibrer une mise en page le texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page.", "/Image/parent plus vus.jpeg", "LES PLUS VUS" });

            migrationBuilder.InsertData(
                table: "Enfants",
                columns: new[] { "Id", "Date", "Description", "GenreDeFilm", "IdParent", "ImageURL", "Nom", "Vus" },
                values: new object[,]
                {
                    { 1, 2023, "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum.", "Action", 1, "/Image/MOVIES_nouveau1.png", "Spider Man", 1000 },
                    { 2, 2023, "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum.", "Action", 1, "/Image/MOVIES_nouveau2.png", "About my father", 2000 },
                    { 3, 2023, "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum.", "Action", 1, "/Image/MOVIES_nouveau3.png", "Blue Reette", 3000 },
                    { 4, 2023, "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum.", "Action", 1, "/Image/MOVIES_nouveau4.png", "Annihilation", 4000 },
                    { 5, 2022, "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum.", "Action", 2, "/Image/MOVIES_avenir1.png", "World Collide", 5000 },
                    { 6, 2022, "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum.", "Action", 2, "/Image/MOVIES_avenir2.png", "World Collide 2", 6000 },
                    { 7, 2022, "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum.", "Action", 2, "/Image/MOVIES_avenir3.png", "Mutant Mayhem", 7000 },
                    { 8, 2022, "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum.", "Action", 2, "/Image/MOVIES_avenir4.png", "Titanic", 8000 },
                    { 9, 2021, "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum.", "Action", 3, "/Image/MOVIES_lesplusvus1.png", "Inception", 9000 },
                    { 10, 2021, "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum.", "Action", 3, "/Image/MOVIES_lesplusvus2.png", "Batman Begins", 10000 },
                    { 11, 2021, "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum.", "Action", 3, "/Image/MOVIES_lesplusvus3.png", "Die hard", 11000 },
                    { 12, 2021, "Le lorem ipsum est, en imprimerie, une suite de mots sans signification utilisée à titre provisoire pour calibrer une mise en pagele texte définitif venant remplacer le faux-texte dès qu'il est prêt ou que la mise en page est achevée. Généralement, on utilise un texte en faux latin, le Lorem ipsum ou Lipsum.", "Action", 3, "/Image/MOVIES_lesplusvus4.png", "Cold Souls", 12000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enfants_IdParent",
                table: "Enfants",
                column: "IdParent");

            migrationBuilder.AddForeignKey(
                name: "FK_Enfants_Parents_IdParent",
                table: "Enfants",
                column: "IdParent",
                principalTable: "Parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enfants_Parents_IdParent",
                table: "Enfants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enfants",
                table: "Enfants");

            migrationBuilder.DropIndex(
                name: "IX_Enfants_IdParent",
                table: "Enfants");

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "Enfants",
                newName: "Enfant");

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Enfant",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enfant",
                table: "Enfant",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Enfant_ParentId",
                table: "Enfant",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enfant_Parents_ParentId",
                table: "Enfant",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id");
        }
    }
}
