using Microsoft.EntityFrameworkCore.Migrations;

namespace LanchesMac.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnaiUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) Values(1,'Pão, Hamburgue,Ovo,Presunto, queijo e batata','Magnifico x salada mas sem a salada famoso xeesburgue',1,'https://br.depositphotos.com/283498404/free-stock-photo-home-made-burger-composition-recipe.html','https://br.depositphotos.com/283498404/free-stock-photo-home-made-burger-composition-recipe.html',0,'Cheese Salad',12.87)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnaiUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) Values(1,'Pão, Hamburgue,Ovo,Presunto, queijo e batata','Magnifico x salada mas sem a salada famoso xeesburgue egg',1,'https://br.depositphotos.com/283498404/free-stock-photo-home-made-burger-composition-recipe.html','https://br.depositphotos.com/283498404/free-stock-photo-home-made-burger-composition-recipe.html',1,'Cheese eg Salad',12.57)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE from Laches");

        }
    }
}
