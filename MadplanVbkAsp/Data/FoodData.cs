using CsvHelper;
using MadplanVbkAsp.Interface;
using MongoDB.Driver;
using SharedLib.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace MadplanVbkAsp.Data
{
    public class FoodData : IFoodData
    {
        public FoodData()
        {
            
        }

        public void Add(Food newFood)
        {
            throw new NotImplementedException();
        }

        public Food Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Food> GetAll()
        {
            MongoDbContext dbContext = new MongoDbContext();

            //if (dbContext.Foods.Find(a => true).Count() == 0)
            //{
            //    var assembly = typeof(FoodData).GetTypeInfo().Assembly;

            //    Stream stream = assembly.GetManifestResourceStream("MadplanVbkAsp.Resources.FoodDatabase.csv");

            //    string text;

            //    // Der bruges Encoding.GetEncoding("iso-8859-1") for at den læser ÆØÅ korrekt
            //    using (var reader = new System.IO.StreamReader(stream, Encoding.GetEncoding("iso-8859-1")))
            //    {
            //        text = reader.ReadToEnd();
            //    }

            //    TextReader sr = new StringReader(text);

            //    var csv = new CsvReader(sr);
            //    csv.Configuration.Delimiter = ",";

            //    int counter = 0;

            //    while (csv.Read())
            //    {
            //        if (counter == 1)
            //        {
            //            dbContext.Foods.InsertOne(new Food
            //            {
            //                Name = csv.GetField<string>(0),
            //                Svind = csv.GetField<string>(2),
            //                EnergiKj = csv.GetField<string>(3),
            //                EnergiKcal = csv.GetField<string>(4),
            //                Ncf = csv.GetField<string>(5),
            //                TotalN = csv.GetField<string>(6),
            //                ProteinTotal = csv.GetField<string>(7),
            //                ProteinDeklaration = csv.GetField<string>(8),
            //                KulhydratDifferens = csv.GetField<string>(9),
            //                KulhydratTilgaengelig = csv.GetField<string>(10),
            //                KulhydratDeklaration = csv.GetField<string>(11),
            //                TilsatSukker = csv.GetField<string>(12),
            //                Kostfiber = csv.GetField<string>(13),
            //                FedtTotal = csv.GetField<string>(14),
            //                FCF = csv.GetField<string>(15),
            //                Alkohol = csv.GetField<string>(16),
            //                Aske = csv.GetField<string>(17),
            //                Torstof = csv.GetField<string>(18),
            //                Vand = csv.GetField<string>(19),
            //                Avitamin = csv.GetField<string>(20),
            //                Retinol = csv.GetField<string>(21),
            //                Bcaroten = csv.GetField<string>(22),
            //                Dvitamin = csv.GetField<string>(23),
            //                D3cholecalciferol = csv.GetField<string>(24),
            //                Hydroxycholecalciferol = csv.GetField<string>(25),
            //                Evitamin = csv.GetField<string>(26),
            //                AlfaTokoferol = csv.GetField<string>(27),
            //                GammaTokoferol = csv.GetField<string>(28),
            //                DeltaTokoferol = csv.GetField<string>(29),
            //                AlfaTokotrienol = csv.GetField<string>(30),
            //                K1vitamin = csv.GetField<string>(31),
            //                B1vitamin = csv.GetField<string>(32),
            //                Thiamin = csv.GetField<string>(33),
            //                HET = csv.GetField<string>(34),
            //                B2vitaminRiboflavin = csv.GetField<string>(35),
            //                Niacin = csv.GetField<string>(36),
            //                Niacin2 = csv.GetField<string>(37),
            //                B6vitamin = csv.GetField<string>(38),
            //                Pantothensyre = csv.GetField<string>(39),
            //                Biotin = csv.GetField<string>(40),
            //                Folat = csv.GetField<string>(41),
            //                FritFolat = csv.GetField<string>(42),
            //                B12vitamin = csv.GetField<string>(43),
            //                Cvitamin = csv.GetField<string>(44),
            //                Lascorbinsyre = csv.GetField<string>(45),
            //                Ldehydroascorbinsyre = csv.GetField<string>(46),
            //                Chlorid = csv.GetField<string>(47),
            //                Natrium = csv.GetField<string>(48),
            //                Kalium = csv.GetField<string>(49),
            //                Calcium = csv.GetField<string>(50),
            //                Magnesium = csv.GetField<string>(51),
            //                Phosphor = csv.GetField<string>(52),
            //                Jern = csv.GetField<string>(53),
            //                Kobber = csv.GetField<string>(54),
            //                Zink = csv.GetField<string>(55),
            //                Jod = csv.GetField<string>(56),
            //                Mangan = csv.GetField<string>(57),
            //                Chrom = csv.GetField<string>(58),
            //                Selen = csv.GetField<string>(59),
            //                Molybdbaen = csv.GetField<string>(60),
            //                Cobolt = csv.GetField<string>(61),
            //                Nikkel = csv.GetField<string>(62),
            //                Kviksolv = csv.GetField<string>(63),
            //                Arsen = csv.GetField<string>(64),
            //                Cadmium = csv.GetField<string>(65),
            //                Bly = csv.GetField<string>(66),
            //                Tin = csv.GetField<string>(67),
            //                Lmaelkesyre = csv.GetField<string>(68),
            //                Dmaelkesyre = csv.GetField<string>(69),
            //                MaelkesyreTotal = csv.GetField<string>(70),
            //                Citronsyre = csv.GetField<string>(71),
            //                Oxalsyre = csv.GetField<string>(72),
            //                Aeblesyre = csv.GetField<string>(73),
            //                Eddikesyre = csv.GetField<string>(74),
            //                Benzoesyre = csv.GetField<string>(75),
            //                OrganiskeSyrerTotal = csv.GetField<string>(76),
            //                Histamin = csv.GetField<string>(77),
            //                Tyramin = csv.GetField<string>(78),
            //                Phenylethylamin = csv.GetField<string>(79),
            //                Putrescin = csv.GetField<string>(80),
            //                Cadaverin = csv.GetField<string>(81),
            //                Spermin = csv.GetField<string>(82),
            //                Spermidin = csv.GetField<string>(83),
            //                Serotonin = csv.GetField<string>(84),
            //                Fructose = csv.GetField<string>(85),
            //                Galaktose = csv.GetField<string>(86),
            //                Glycose = csv.GetField<string>(87),
            //                MonosacchariderTotal = csv.GetField<string>(88),
            //                Lactose = csv.GetField<string>(89),
            //                Maltose = csv.GetField<string>(90),
            //                Saccharose = csv.GetField<string>(91),
            //                DisacchariderTotal = csv.GetField<string>(92),
            //                Raffinose = csv.GetField<string>(93),
            //                AndreSukkerarter = csv.GetField<string>(94),
            //                SukkerarterIalt = csv.GetField<string>(95),
            //                Sorbitol = csv.GetField<string>(96),
            //                Mannitol = csv.GetField<string>(97),
            //                Inositol = csv.GetField<string>(98),
            //                Maltitol = csv.GetField<string>(99),
            //                SukkerAlkoholerTotal = csv.GetField<string>(100),
            //                Stivelse = csv.GetField<string>(101),
            //                Hexoses = csv.GetField<string>(102),
            //                Pentoses = csv.GetField<string>(103),
            //                UronicAcids = csv.GetField<string>(104),
            //                Cellulose = csv.GetField<string>(105),
            //                Lignin = csv.GetField<string>(106),
            //                CrudeFibre = csv.GetField<string>(107),
            //                NDF = csv.GetField<string>(108),
            //                C40 = csv.GetField<string>(109),
            //                C60 = csv.GetField<string>(110),
            //                C80 = csv.GetField<string>(111),
            //                C100 = csv.GetField<string>(112),
            //                C120 = csv.GetField<string>(113),
            //                C140 = csv.GetField<string>(114),
            //                C150 = csv.GetField<string>(115),
            //                C160 = csv.GetField<string>(116),
            //                C170 = csv.GetField<string>(117),
            //                C180 = csv.GetField<string>(118),
            //                C200 = csv.GetField<string>(119),
            //                C220 = csv.GetField<string>(120),
            //                C240 = csv.GetField<string>(121),
            //                AndreMaettedeFedtsyrer = csv.GetField<string>(122),
            //                C141n5 = csv.GetField<string>(123),
            //                C151 = csv.GetField<string>(124),
            //                C161n7 = csv.GetField<string>(125),
            //                C161trans = csv.GetField<string>(126),
            //                C171n7 = csv.GetField<string>(127),
            //                C181n9 = csv.GetField<string>(128),
            //                C181n7 = csv.GetField<string>(129),
            //                C181trans = csv.GetField<string>(130),
            //                C201n9 = csv.GetField<string>(131),
            //                C201n11 = csv.GetField<string>(132),
            //                C201trans = csv.GetField<string>(133),
            //                C221n9 = csv.GetField<string>(134),
            //                C221n11 = csv.GetField<string>(135),
            //                C221trans = csv.GetField<string>(136),
            //                C241n9 = csv.GetField<string>(137),
            //                AndreMonoumaettedeFedtsyrer = csv.GetField<string>(138),
            //                C182n6 = csv.GetField<string>(139),
            //                C182conjA = csv.GetField<string>(130),
            //                C182trans = csv.GetField<string>(141),
            //                C183n3 = csv.GetField<string>(142),
            //                C183n6 = csv.GetField<string>(143),
            //                C184n3 = csv.GetField<string>(144),
            //                C202n6 = csv.GetField<string>(145),
            //                C204n3 = csv.GetField<string>(146),
            //                C203n3 = csv.GetField<string>(147),
            //                C203n6 = csv.GetField<string>(148),
            //                C204n6 = csv.GetField<string>(149),
            //                C205n3 = csv.GetField<string>(150),
            //                C225n3 = csv.GetField<string>(151),
            //                C226n3 = csv.GetField<string>(152),
            //                AndrePolymaettedeFedtsyrer = csv.GetField<string>(153),
            //                AndreFedtsyrer = csv.GetField<string>(154),
            //                SumMaettedeFedtsyrer = csv.GetField<string>(155),
            //                SumMonoumaettedeFedtsyrer = csv.GetField<string>(156),
            //                SumPolymaettedeFedtsyrer = csv.GetField<string>(157),
            //                FedtsyrerTotal = csv.GetField<string>(158),
            //                Sumn3Fedtsyrer = csv.GetField<string>(159),
            //                Sumn6Fedtsyrer = csv.GetField<string>(160),
            //                TransFedtsyrerTotal = csv.GetField<string>(161),
            //                Cholesterol = csv.GetField<string>(162),
            //                Isoleucin = csv.GetField<string>(163),
            //                Leucin = csv.GetField<string>(164),
            //                Lysin = csv.GetField<string>(165),
            //                Methionin = csv.GetField<string>(166),
            //                Cystin = csv.GetField<string>(167),
            //                Phenylalanin = csv.GetField<string>(168),
            //                Tyrosin = csv.GetField<string>(169),
            //                Threonin = csv.GetField<string>(170),
            //                Tryptofan = csv.GetField<string>(171),
            //                Valin = csv.GetField<string>(172),
            //                Arginin = csv.GetField<string>(173),
            //                Histidin = csv.GetField<string>(174),
            //                Alanin = csv.GetField<string>(175),
            //                Asparaginsyre = csv.GetField<string>(176),
            //                Glutaminsyre = csv.GetField<string>(177),
            //                Glycin = csv.GetField<string>(178),
            //                Prolin = csv.GetField<string>(179),
            //                Serin = csv.GetField<string>(180),
            //            });
            //        }

            //        counter++;
            //    }

            //}

            var list = dbContext.Foods.Find(a => true).ToList();

            return list;
        }
    }
}
