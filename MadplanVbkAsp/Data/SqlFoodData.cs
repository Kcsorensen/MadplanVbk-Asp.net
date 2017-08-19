using CsvHelper;
using MadplanVbkAsp.Extensions;
using MadplanVbkAsp.Interface;
using MadplanVbkAsp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MadplanVbkAsp.Data
{
    public class SqlFoodData : IFoodData
    {
        private SqlDbContext _db;

        public SqlFoodData(SqlDbContext db)
        {
            _db = db;
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
            if (!_db.Foods.Any())
            {
                var assembly = typeof(SqlFoodData).GetTypeInfo().Assembly;

                Stream stream = assembly.GetManifestResourceStream("MadplanVbkAsp.Resources.FoodDatabase.csv");

                string text;

                // Der bruges Encoding.GetEncoding("iso-8859-1") for at den læser ÆØÅ korrekt
                using (var reader = new System.IO.StreamReader(stream, Encoding.GetEncoding("iso-8859-1")))
                {
                    text = reader.ReadToEnd();
                }

                TextReader sr = new StringReader(text);

                var csv = new CsvReader(sr);
                csv.Configuration.Delimiter = ";";

                int counter = 0;

                while (csv.Read())
                {
                    if (counter > 0)
                    {
                        _db.Foods.Add(new Food
                        {
                            Name = csv.GetField<string>(0),
                            FoodId = csv.GetField<int>(1),
                            Svind = csv.GetField<string>(2).ConvertToDouble(),
                            EnergiKj = csv.GetField<string>(3).ConvertToDouble(),
                            EnergiKcal = csv.GetField<string>(4).ConvertToDouble(),
                            Ncf = csv.GetField<string>(5).ConvertToDouble(),
                            TotalN = csv.GetField<string>(6).ConvertToDouble(),
                            ProteinTotal = csv.GetField<string>(7).ConvertToDouble(),
                            ProteinDeklaration = csv.GetField<string>(8).ConvertToDouble(),
                            KulhydratDifferens = csv.GetField<string>(9).ConvertToDouble(),
                            KulhydratTilgaengelig = csv.GetField<string>(10).ConvertToDouble(),
                            KulhydratDeklaration = csv.GetField<string>(11).ConvertToDouble(),
                            TilsatSukker = csv.GetField<string>(12).ConvertToDouble(),
                            Kostfiber = csv.GetField<string>(13).ConvertToDouble(),
                            FedtTotal = csv.GetField<string>(14).ConvertToDouble(),
                            FCF = csv.GetField<string>(15).ConvertToDouble(),
                            Alkohol = csv.GetField<string>(16).ConvertToDouble(),
                            Aske = csv.GetField<string>(17).ConvertToDouble(),
                            Torstof = csv.GetField<string>(18).ConvertToDouble(),
                            Vand = csv.GetField<string>(19).ConvertToDouble(),
                            Avitamin = csv.GetField<string>(20).ConvertToDouble(),
                            Retinol = csv.GetField<string>(21).ConvertToDouble(),
                            Bcaroten = csv.GetField<string>(22).ConvertToDouble(),
                            Dvitamin = csv.GetField<string>(23).ConvertToDouble(),
                            D3cholecalciferol = csv.GetField<string>(24).ConvertToDouble(),
                            Hydroxycholecalciferol = csv.GetField<string>(25).ConvertToDouble(),
                            Evitamin = csv.GetField<string>(26).ConvertToDouble(),
                            AlfaTokoferol = csv.GetField<string>(27).ConvertToDouble(),
                            GammaTokoferol = csv.GetField<string>(28).ConvertToDouble(),
                            DeltaTokoferol = csv.GetField<string>(29).ConvertToDouble(),
                            AlfaTokotrienol = csv.GetField<string>(30).ConvertToDouble(),
                            K1vitamin = csv.GetField<string>(31).ConvertToDouble(),
                            B1vitamin = csv.GetField<string>(32).ConvertToDouble(),
                            Thiamin = csv.GetField<string>(33).ConvertToDouble(),
                            HET = csv.GetField<string>(34).ConvertToDouble(),
                            B2vitaminRiboflavin = csv.GetField<string>(35).ConvertToDouble(),
                            Niacin = csv.GetField<string>(36).ConvertToDouble(),
                            Niacin2 = csv.GetField<string>(37).ConvertToDouble(),
                            B6vitamin = csv.GetField<string>(38).ConvertToDouble(),
                            Pantothensyre = csv.GetField<string>(39).ConvertToDouble(),
                            Biotin = csv.GetField<string>(40).ConvertToDouble(),
                            Folat = csv.GetField<string>(41).ConvertToDouble(),
                            FritFolat = csv.GetField<string>(42).ConvertToDouble(),
                            B12vitamin = csv.GetField<string>(43).ConvertToDouble(),
                            Cvitamin = csv.GetField<string>(44).ConvertToDouble(),
                            Lascorbinsyre = csv.GetField<string>(45).ConvertToDouble(),
                            Ldehydroascorbinsyre = csv.GetField<string>(46).ConvertToDouble(),
                            Chlorid = csv.GetField<string>(47).ConvertToDouble(),
                            Natrium = csv.GetField<string>(48).ConvertToDouble(),
                            Kalium = csv.GetField<string>(49).ConvertToDouble(),
                            Calcium = csv.GetField<string>(50).ConvertToDouble(),
                            Magnesium = csv.GetField<string>(51).ConvertToDouble(),
                            Phosphor = csv.GetField<string>(52).ConvertToDouble(),
                            Jern = csv.GetField<string>(53).ConvertToDouble(),
                            Kobber = csv.GetField<string>(54).ConvertToDouble(),
                            Zink = csv.GetField<string>(55).ConvertToDouble(),
                            Jod = csv.GetField<string>(56).ConvertToDouble(),
                            Mangan = csv.GetField<string>(57).ConvertToDouble(),
                            Chrom = csv.GetField<string>(58).ConvertToDouble(),
                            Selen = csv.GetField<string>(59).ConvertToDouble(),
                            Molybdbaen = csv.GetField<string>(60).ConvertToDouble(),
                            Cobolt = csv.GetField<string>(61).ConvertToDouble(),
                            Nikkel = csv.GetField<string>(62).ConvertToDouble(),
                            kviksolv = csv.GetField<string>(63).ConvertToDouble(),
                            Arsen = csv.GetField<string>(64).ConvertToDouble(),
                            Cadmium = csv.GetField<string>(65).ConvertToDouble(),
                            Bly = csv.GetField<string>(66).ConvertToDouble(),
                            Tin = csv.GetField<string>(67).ConvertToDouble(),
                            Lmaelkesyre = csv.GetField<string>(68).ConvertToDouble(),
                            Dmaelkesyre = csv.GetField<string>(69).ConvertToDouble(),
                            MaelkesyreTotal = csv.GetField<string>(70).ConvertToDouble(),
                            Citronsyre = csv.GetField<string>(71).ConvertToDouble(),
                            Oxalsyre = csv.GetField<string>(72).ConvertToDouble(),
                            Aeblesyre = csv.GetField<string>(73).ConvertToDouble(),
                            Eddikesyre = csv.GetField<string>(74).ConvertToDouble(),
                            Benzoesyre = csv.GetField<string>(75).ConvertToDouble(),
                            OrganiskeSyrerTotal = csv.GetField<string>(76).ConvertToDouble(),
                            Histamin = csv.GetField<string>(77).ConvertToDouble(),
                            Tyramin = csv.GetField<string>(78).ConvertToDouble(),
                            Phenylethylamin = csv.GetField<string>(79).ConvertToDouble(),
                            Putrescin = csv.GetField<string>(80).ConvertToDouble(),
                            Cadaverin = csv.GetField<string>(81).ConvertToDouble(),
                            Spermin = csv.GetField<string>(82).ConvertToDouble(),
                            Spermidin = csv.GetField<string>(83).ConvertToDouble(),
                            Serotonin = csv.GetField<string>(84).ConvertToDouble(),
                            Fructose = csv.GetField<string>(85).ConvertToDouble(),
                            Galaktose = csv.GetField<string>(86).ConvertToDouble(),
                            Glycose = csv.GetField<string>(87).ConvertToDouble(),
                            MonosacchariderTotal = csv.GetField<string>(88).ConvertToDouble(),
                            Lactose = csv.GetField<string>(89).ConvertToDouble(),
                            Maltose = csv.GetField<string>(90).ConvertToDouble(),
                            Saccharose = csv.GetField<string>(91).ConvertToDouble(),
                            DisacchariderTotal = csv.GetField<string>(92).ConvertToDouble(),
                            Raffinose = csv.GetField<string>(93).ConvertToDouble(),
                            AndreSukkerarter = csv.GetField<string>(94).ConvertToDouble(),
                            SukkerarterIalt = csv.GetField<string>(95).ConvertToDouble(),
                            Sorbitol = csv.GetField<string>(96).ConvertToDouble(),
                            Mannitol = csv.GetField<string>(97).ConvertToDouble(),
                            Inositol = csv.GetField<string>(98).ConvertToDouble(),
                            Maltitol = csv.GetField<string>(99).ConvertToDouble(),
                            SukkerAlkoholerTotal = csv.GetField<string>(100).ConvertToDouble(),
                            Stivelse = csv.GetField<string>(101).ConvertToDouble(),
                            Hexoses = csv.GetField<string>(102).ConvertToDouble(),
                            Pentoses = csv.GetField<string>(103).ConvertToDouble(),
                            UronicAcids = csv.GetField<string>(104).ConvertToDouble(),
                            Cellulose = csv.GetField<string>(105).ConvertToDouble(),
                            Lignin = csv.GetField<string>(106).ConvertToDouble(),
                            CrudeFibre = csv.GetField<string>(107).ConvertToDouble(),
                            NDF = csv.GetField<string>(108).ConvertToDouble(),
                            C40 = csv.GetField<string>(109).ConvertToDouble(),
                            C60 = csv.GetField<string>(110).ConvertToDouble(),
                            C80 = csv.GetField<string>(111).ConvertToDouble(),
                            C100 = csv.GetField<string>(112).ConvertToDouble(),
                            C120 = csv.GetField<string>(113).ConvertToDouble(),
                            C140 = csv.GetField<string>(114).ConvertToDouble(),
                            C150 = csv.GetField<string>(115).ConvertToDouble(),
                            C160 = csv.GetField<string>(116).ConvertToDouble(),
                            C170 = csv.GetField<string>(117).ConvertToDouble(),
                            C180 = csv.GetField<string>(118).ConvertToDouble(),
                            C200 = csv.GetField<string>(119).ConvertToDouble(),
                            C220 = csv.GetField<string>(120).ConvertToDouble(),
                            C240 = csv.GetField<string>(121).ConvertToDouble(),
                            AndreMaettedeFedtsyrer = csv.GetField<string>(122).ConvertToDouble(),
                            C141n5 = csv.GetField<string>(123).ConvertToDouble(),
                            C151 = csv.GetField<string>(124).ConvertToDouble(),
                            C161n7 = csv.GetField<string>(125).ConvertToDouble(),
                            C161trans = csv.GetField<string>(126).ConvertToDouble(),
                            C171n7 = csv.GetField<string>(127).ConvertToDouble(),
                            C181n9 = csv.GetField<string>(128).ConvertToDouble(),
                            C181n7 = csv.GetField<string>(129).ConvertToDouble(),
                            C181trans = csv.GetField<string>(130).ConvertToDouble(),
                            C201n9 = csv.GetField<string>(131).ConvertToDouble(),
                            C201n11 = csv.GetField<string>(132).ConvertToDouble(),
                            C201trans = csv.GetField<string>(133).ConvertToDouble(),
                            C221n9 = csv.GetField<string>(134).ConvertToDouble(),
                            C221n11 = csv.GetField<string>(135).ConvertToDouble(),
                            C221trans = csv.GetField<string>(136).ConvertToDouble(),
                            C241n9 = csv.GetField<string>(137).ConvertToDouble(),
                            AndreMonoumaettedeFedtsyrer = csv.GetField<string>(138).ConvertToDouble(),
                            C182n6 = csv.GetField<string>(139).ConvertToDouble(),
                            C182conjA = csv.GetField<string>(130).ConvertToDouble(),
                            C182trans = csv.GetField<string>(141).ConvertToDouble(),
                            C183n3 = csv.GetField<string>(142).ConvertToDouble(),
                            C183n6 = csv.GetField<string>(143).ConvertToDouble(),
                            C184n3 = csv.GetField<string>(144).ConvertToDouble(),
                            C202n6 = csv.GetField<string>(145).ConvertToDouble(),
                            C204n3 = csv.GetField<string>(146).ConvertToDouble(),
                            C203n3 = csv.GetField<string>(147).ConvertToDouble(),
                            C203n6 = csv.GetField<string>(148).ConvertToDouble(),
                            C204n6 = csv.GetField<string>(149).ConvertToDouble(),
                            C205n3 = csv.GetField<string>(150).ConvertToDouble(),
                            C225n3 = csv.GetField<string>(151).ConvertToDouble(),
                            C226n3 = csv.GetField<string>(152).ConvertToDouble(),
                            AndrePolymaettedeFedtsyrer = csv.GetField<string>(153).ConvertToDouble(),
                            AndreFedtsyrer = csv.GetField<string>(154).ConvertToDouble(),
                            SumMaettedeFedtsyrer = csv.GetField<string>(155).ConvertToDouble(),
                            SumMonoumaettedeFedtsyrer = csv.GetField<string>(156).ConvertToDouble(),
                            SumPolymaettedeFedtsyrer = csv.GetField<string>(157).ConvertToDouble(),
                            FedtsyrerTotal = csv.GetField<string>(158).ConvertToDouble(),
                            Sumn3Fedtsyrer = csv.GetField<string>(159).ConvertToDouble(),
                            Sumn6Fedtsyrer = csv.GetField<string>(160).ConvertToDouble(),
                            TransFedtsyrerTotal = csv.GetField<string>(161).ConvertToDouble(),
                            Cholesterol = csv.GetField<string>(162).ConvertToDouble(),
                            Isoleucin = csv.GetField<string>(163).ConvertToDouble(),
                            Leucin = csv.GetField<string>(164).ConvertToDouble(),
                            Lysin = csv.GetField<string>(165).ConvertToDouble(),
                            Methionin = csv.GetField<string>(166).ConvertToDouble(),
                            Cystin = csv.GetField<string>(167).ConvertToDouble(),
                            Phenylalanin = csv.GetField<string>(168).ConvertToDouble(),
                            Tyrosin = csv.GetField<string>(169).ConvertToDouble(),
                            Threonin = csv.GetField<string>(170).ConvertToDouble(),
                            Tryptofan = csv.GetField<string>(171).ConvertToDouble(),
                            Valin = csv.GetField<string>(172).ConvertToDouble(),
                            Arginin = csv.GetField<string>(173).ConvertToDouble(),
                            Histidin = csv.GetField<string>(174).ConvertToDouble(),
                            Alanin = csv.GetField<string>(175).ConvertToDouble(),
                            Asparaginsyre = csv.GetField<string>(176).ConvertToDouble(),
                            Glutaminsyre = csv.GetField<string>(177).ConvertToDouble(),
                            Glycin = csv.GetField<string>(178).ConvertToDouble(),
                            Prolin = csv.GetField<string>(179).ConvertToDouble(),
                            Serin = csv.GetField<string>(180).ConvertToDouble(),
                        });
                    }

                    counter++;
                }

                _db.SaveChanges();
            }

            var list = _db.Foods;

            return list;
        }
    }
}
