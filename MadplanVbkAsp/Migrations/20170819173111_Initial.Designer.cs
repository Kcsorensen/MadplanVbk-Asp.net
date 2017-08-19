using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MadplanVbkAsp.Data;

namespace MadplanVbkAsp.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    [Migration("20170819173111_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MadplanVbkAsp.Models.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Aeblesyre");

                    b.Property<string>("Alanin");

                    b.Property<string>("AlfaTokoferol");

                    b.Property<string>("AlfaTokotrienol");

                    b.Property<string>("Alkohol");

                    b.Property<string>("AndreFedtsyrer");

                    b.Property<string>("AndreMaettedeFedtsyrer");

                    b.Property<string>("AndreMonoumaettedeFedtsyrer");

                    b.Property<string>("AndrePolymaettedeFedtsyrer");

                    b.Property<string>("AndreSukkerarter");

                    b.Property<string>("Arginin");

                    b.Property<string>("Arsen");

                    b.Property<string>("Aske");

                    b.Property<string>("Asparaginsyre");

                    b.Property<string>("Avitamin");

                    b.Property<string>("B12vitamin");

                    b.Property<string>("B1vitamin");

                    b.Property<string>("B2vitaminRiboflavin");

                    b.Property<string>("B6vitamin");

                    b.Property<string>("Bcaroten");

                    b.Property<string>("Benzoesyre");

                    b.Property<string>("Biotin");

                    b.Property<string>("Bly");

                    b.Property<string>("C100");

                    b.Property<string>("C120");

                    b.Property<string>("C140");

                    b.Property<string>("C141n5");

                    b.Property<string>("C150");

                    b.Property<string>("C151");

                    b.Property<string>("C160");

                    b.Property<string>("C161n7");

                    b.Property<string>("C161trans");

                    b.Property<string>("C170");

                    b.Property<string>("C171n7");

                    b.Property<string>("C180");

                    b.Property<string>("C181n7");

                    b.Property<string>("C181n9");

                    b.Property<string>("C181trans");

                    b.Property<string>("C182conjA");

                    b.Property<string>("C182n6");

                    b.Property<string>("C182trans");

                    b.Property<string>("C183n3");

                    b.Property<string>("C183n6");

                    b.Property<string>("C184n3");

                    b.Property<string>("C200");

                    b.Property<string>("C201n11");

                    b.Property<string>("C201n9");

                    b.Property<string>("C201trans");

                    b.Property<string>("C202n6");

                    b.Property<string>("C203n3");

                    b.Property<string>("C203n6");

                    b.Property<string>("C204n3");

                    b.Property<string>("C204n6");

                    b.Property<string>("C205n3");

                    b.Property<string>("C220");

                    b.Property<string>("C221n11");

                    b.Property<string>("C221n9");

                    b.Property<string>("C221trans");

                    b.Property<string>("C225n3");

                    b.Property<string>("C226n3");

                    b.Property<string>("C240");

                    b.Property<string>("C241n9");

                    b.Property<string>("C40");

                    b.Property<string>("C60");

                    b.Property<string>("C80");

                    b.Property<string>("Cadaverin");

                    b.Property<string>("Cadmium");

                    b.Property<string>("Calcium");

                    b.Property<string>("Cellulose");

                    b.Property<string>("Chlorid");

                    b.Property<string>("Cholesterol");

                    b.Property<string>("Chrom");

                    b.Property<string>("Citronsyre");

                    b.Property<string>("Cobolt");

                    b.Property<string>("CrudeFibre");

                    b.Property<string>("Cvitamin");

                    b.Property<string>("Cystin");

                    b.Property<string>("D3cholecalciferol");

                    b.Property<string>("DeltaTokoferol");

                    b.Property<string>("DisacchariderTotal");

                    b.Property<string>("Dmaelkesyre");

                    b.Property<string>("Dvitamin");

                    b.Property<string>("Eddikesyre");

                    b.Property<string>("EnergiKcal");

                    b.Property<string>("EnergiKj");

                    b.Property<string>("Evitamin");

                    b.Property<string>("FCF");

                    b.Property<string>("FedtTotal");

                    b.Property<string>("FedtsyrerTotal");

                    b.Property<string>("Folat");

                    b.Property<int>("FoodId");

                    b.Property<string>("FritFolat");

                    b.Property<string>("Fructose");

                    b.Property<string>("Galaktose");

                    b.Property<string>("GammaTokoferol");

                    b.Property<string>("Glutaminsyre");

                    b.Property<string>("Glycin");

                    b.Property<string>("Glycose");

                    b.Property<string>("HET");

                    b.Property<string>("Hexoses");

                    b.Property<string>("Histamin");

                    b.Property<string>("Histidin");

                    b.Property<string>("Hydroxycholecalciferol");

                    b.Property<string>("Inositol");

                    b.Property<string>("Isoleucin");

                    b.Property<string>("Jern");

                    b.Property<string>("Jod");

                    b.Property<string>("K1vitamin");

                    b.Property<string>("Kalium");

                    b.Property<string>("Kobber");

                    b.Property<string>("Kostfiber");

                    b.Property<string>("KulhydratDeklaration");

                    b.Property<string>("KulhydratDifferens");

                    b.Property<string>("KulhydratTilgaengelig");

                    b.Property<string>("Lactose");

                    b.Property<string>("Lascorbinsyre");

                    b.Property<string>("Ldehydroascorbinsyre");

                    b.Property<string>("Leucin");

                    b.Property<string>("Lignin");

                    b.Property<string>("Lmaelkesyre");

                    b.Property<string>("Lysin");

                    b.Property<string>("MaelkesyreTotal");

                    b.Property<string>("Magnesium");

                    b.Property<string>("Maltitol");

                    b.Property<string>("Maltose");

                    b.Property<string>("Mangan");

                    b.Property<string>("Mannitol");

                    b.Property<string>("Methionin");

                    b.Property<string>("Molybdbaen");

                    b.Property<string>("MonosacchariderTotal");

                    b.Property<string>("NDF");

                    b.Property<string>("Name");

                    b.Property<string>("Natrium");

                    b.Property<string>("Ncf");

                    b.Property<string>("Niacin");

                    b.Property<string>("Niacin2");

                    b.Property<string>("Nikkel");

                    b.Property<string>("OrganiskeSyrerTotal");

                    b.Property<string>("Oxalsyre");

                    b.Property<string>("Pantothensyre");

                    b.Property<string>("Pentoses");

                    b.Property<string>("Phenylalanin");

                    b.Property<string>("Phenylethylamin");

                    b.Property<string>("Phosphor");

                    b.Property<string>("Prolin");

                    b.Property<string>("ProteinDeklaration");

                    b.Property<string>("ProteinTotal");

                    b.Property<string>("Putrescin");

                    b.Property<int>("QuantityConververId");

                    b.Property<string>("Raffinose");

                    b.Property<string>("Retinol");

                    b.Property<string>("Saccharose");

                    b.Property<string>("Selen");

                    b.Property<string>("Serin");

                    b.Property<string>("Serotonin");

                    b.Property<string>("Sorbitol");

                    b.Property<string>("Spermidin");

                    b.Property<string>("Spermin");

                    b.Property<string>("Stivelse");

                    b.Property<string>("SukkerAlkoholerTotal");

                    b.Property<string>("SukkerarterIalt");

                    b.Property<string>("SumMaettedeFedtsyrer");

                    b.Property<string>("SumMonoumaettedeFedtsyrer");

                    b.Property<string>("SumPolymaettedeFedtsyrer");

                    b.Property<string>("Sumn3Fedtsyrer");

                    b.Property<string>("Sumn6Fedtsyrer");

                    b.Property<string>("Svind");

                    b.Property<string>("Thiamin");

                    b.Property<string>("Threonin");

                    b.Property<string>("TilsatSukker");

                    b.Property<string>("Tin");

                    b.Property<string>("Torstof");

                    b.Property<string>("TotalN");

                    b.Property<string>("TransFedtsyrerTotal");

                    b.Property<string>("Tryptofan");

                    b.Property<string>("Tyramin");

                    b.Property<string>("Tyrosin");

                    b.Property<string>("UronicAcids");

                    b.Property<string>("Valin");

                    b.Property<string>("Vand");

                    b.Property<string>("Zink");

                    b.Property<string>("kviksolv");

                    b.HasKey("Id");

                    b.ToTable("Foods");
                });
        }
    }
}
