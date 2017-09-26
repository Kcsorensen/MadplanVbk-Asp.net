using MadplanVbkAsp.Models;
using SharedLib.Models;
using System.ComponentModel.DataAnnotations;

namespace MadplanVbkAsp.Dtos
{
    public class FoodDto
    {
        [Required(ErrorMessage = ErrorMessage.Required)]
        [Display(Name =  "navn")]
        public string Name { get; set; }

        public bool IsProtected { get; set; }
        public string DefaultQuantityType { get; set; }

        public QuantityConverter QuantityConverter { get; set; }

        public string EnergiKj { get; set; }
        public string EnergiKcal { get; set; }
        public string ProteinTotal { get; set; }
        public string KulhydratDifferens { get; set; }
        public string KulhydratTilgaengelig { get; set; }
        public string TilsatSukker { get; set; }
        public string Kostfiber { get; set; }
        public string FedtTotal { get; set; }

        public string Avitamin { get; set; }
        public string Dvitamin { get; set; }
        public string Evitamin { get; set; }
        public string K1vitamin { get; set; }
        public string B12vitamin { get; set; }
        public string Cvitamin { get; set; }
        public string Calcium { get; set; }
        public string Magnesium { get; set; }
        public string Jern { get; set; }
        public string Zink { get; set; }
        public string Selen { get; set; }
        public string Cadmium { get; set; }
        public string SumMaettedeFedtsyrer { get; set; }
        public string SumMonoumaettedeFedtsyrer { get; set; }
        public string SumPolymaettedeFedtsyrer { get; set; }
        public string TransFedtsyrerTotal { get; set; }
        public string Cholesterol { get; set; }

        public string Svind { get; set; }
        public string Ncf { get; set; } // Proteinomregningsfaktor(NCF)
        public string TotalN { get; set; }
        public string ProteinDeklaration { get; set; }
        public string KulhydratDeklaration { get; set; }
        public string FCF { get; set; } // Fedtsyrekonverteringsfaktor (FCF)
        public string Alkohol { get; set; }
        public string Aske { get; set; }
        public string Torstof { get; set; } // Tørstof
        public string Vand { get; set; }
        public string Retinol { get; set; }
        public string Bcaroten { get; set; }
        public string D3cholecalciferol { get; set; }
        public string Hydroxycholecalciferol { get; set; } // 25-hydroxycholecalciferol
        public string AlfaTokoferol { get; set; }
        public string GammaTokoferol { get; set; }
        public string DeltaTokoferol { get; set; }
        public string AlfaTokotrienol { get; set; }
        public string B1vitamin { get; set; }
        public string Thiamin { get; set; }
        public string HET { get; set; } // HET, hydroxyethylthiazole
        public string B2vitaminRiboflavin { get; set; }
        public string Niacin { get; set; }
        public string Niacin2 { get; set; }
        public string B6vitamin { get; set; }
        public string Pantothensyre { get; set; }
        public string Biotin { get; set; }
        public string Folat { get; set; }
        public string FritFolat { get; set; }
        public string Lascorbinsyre { get; set; } // L-ascorbinsyre
        public string Ldehydroascorbinsyre { get; set; } // L-dehydroascorbinsyre
        public string Chlorid { get; set; }
        public string Natrium { get; set; }
        public string Kalium { get; set; }
        public string Phosphor { get; set; }
        public string Kobber { get; set; }
        public string Jod { get; set; }
        public string Mangan { get; set; }
        public string Chrom { get; set; }
        public string Molybdbaen { get; set; } // Molybdæm
        public string Cobolt { get; set; }
        public string Nikkel { get; set; }
        public string Kviksolv { get; set; } // Kviksølv
        public string Arsen { get; set; }
        public string Bly { get; set; }
        public string Tin { get; set; }
        public string Lmaelkesyre { get; set; } // L-mælkesyre
        public string Dmaelkesyre { get; set; } // D-mælkesyre
        public string MaelkesyreTotal { get; set; } // Mælkesyre, Total
        public string Citronsyre { get; set; }
        public string Oxalsyre { get; set; }
        public string Aeblesyre { get; set; } // Æblesyre
        public string Eddikesyre { get; set; }
        public string Benzoesyre { get; set; }
        public string OrganiskeSyrerTotal { get; set; }
        public string Histamin { get; set; }
        public string Tyramin { get; set; }
        public string Phenylethylamin { get; set; }
        public string Putrescin { get; set; }
        public string Cadaverin { get; set; }
        public string Spermin { get; set; }
        public string Spermidin { get; set; }
        public string Serotonin { get; set; }
        public string Fructose { get; set; }
        public string Galaktose { get; set; }
        public string Glycose { get; set; }
        public string MonosacchariderTotal { get; set; }
        public string Lactose { get; set; }
        public string Maltose { get; set; }
        public string Saccharose { get; set; }
        public string DisacchariderTotal { get; set; }
        public string Raffinose { get; set; }
        public string AndreSukkerarter { get; set; }
        public string SukkerarterIalt { get; set; }
        public string Sorbitol { get; set; }
        public string Mannitol { get; set; }
        public string Inositol { get; set; }
        public string Maltitol { get; set; }
        public string SukkerAlkoholerTotal { get; set; }
        public string Stivelse { get; set; }
        public string Hexoses { get; set; }
        public string Pentoses { get; set; }
        public string UronicAcids { get; set; }
        public string Cellulose { get; set; }
        public string Lignin { get; set; }
        public string CrudeFibre { get; set; }
        public string NDF { get; set; } // Neutr.Det.Fibre (NDF)
        public string C40 { get; set; } // C4:0 Smørsyre; Butansyre; Butanoic acid
        public string C60 { get; set; } // C6:0 Capronsyre; Hexansyre; Hexanoic acid
        public string C80 { get; set; } // C8:0 Caprylsyre; Octansyre; Octanoic acid
        public string C100 { get; set; } // C10:0 Caprinsyre; Decansyre; Decanoic acid
        public string C120 { get; set; } // C12:0 Laurinsyre; Dodecansyre; Dodecanoic acid
        public string C140 { get; set; } // C14:0 Myristinsyre; Tetradecansyre; Tetradecanoic acid
        public string C150 { get; set; } // C15:0 Pentadecansyre; Pentadecanoic acid
        public string C160 { get; set; } // C16:0 Palmitinsyre; Hexadecansyre; Hexadecanoic acid
        public string C170 { get; set; } // C17:0 Margarinsyre; Heptadecansyre; Heptadecanoic acid
        public string C180 { get; set; } // C18:0 Stearinsyre; Octadecansyre; Octadecanoic acid
        public string C200 { get; set; } // C20:0 Arachinsyre; Eicosansyre; Eicosanoic acid
        public string C220 { get; set; } // C22:0 Behensyre; Docosansyre; Docosanoic acid
        public string C240 { get; set; } // C24:0 Lignocerinsyre; Tetracosansyre; Tetracosanoic acid
        public string AndreMaettedeFedtsyrer { get; set; } // Andre mættede fedtsyrer
        public string C141n5 { get; set; } // C14:1,n-5 Myristoleinsyre; cis-9-Tetradecensyre; (Z)-Tetradec-9-enoic acid
        public string C151 { get; set; } // C15:1 Pentadecensyre; (Z)-Pentadec-10-enoic acid
        public string C161n7 { get; set; } // C16:1,n-7 Palmitoleinsyre; cis-9-Hexadecensyre; (Z)-Hexadec-9-enoic acid
        public string C161trans { get; set; } // C16:1,trans Palmitelaidinsyre; trans-Hexadecensyre; (E)-Hexadec-9-enoic acid
        public string C171n7 { get; set; } // C17:1,n-7 cis-10-Heptadecensyre; (Z)-Heptadec-10-enoic acid
        public string C181n9 { get; set; } // C18:1,n-9 Oliesyre; cis-9-Octadecensyre; (Z)-Octadec-9-enoic acid
        public string C181n7 { get; set; } // C18:1,n-7 cis-Vaccensyre; cis-11-Octacecansyre; (Z)-Octadec-11-enoic acid
        public string C181trans { get; set; } // C18:1,t n-9 Elaidinsyre; trans 9-Octadecensyre; (E)-octadec-9-enoic acid
        public string C201n9 { get; set; } // C20:1,n-9 Gondoinsyre; cis-11-Eicosensyre; (11Z)-Eicosenoic acid; 
        public string C201n11 { get; set; } // C20:1,n-11 Gadoleinsyre; cis-9-Eicosensyre; cis-9-Eicosenoic acid; (9Z)-9-Eicosenoic acid
        public string C201trans { get; set; } // C20:1,trans trans-11-Eicosensyre; trans-11-Eicosenoic acid
        public string C221n9 { get; set; } // C22:1,n-9 Erukasyre; cis-13-docosensyre, (Z)-docos-13-enoic acid
        public string C221n11 { get; set; } // C22:1,n-11 Cetoleinsyre; cis-11-docosensyre; (11Z)-11-Docosenoic acid
        public string C221trans { get; set; } // C22:1,n-9,trans Brassidic; acid trans-13-docosensyre; (E)-13-Docosenoic acid
        public string C241n9 { get; set; } // C24:1,n-9 Nervonsyre; cis-15-tetracosensyre; (Z)-Tetracos-15-enoic acid
        public string AndreMonoumaettedeFedtsyrer { get; set; } // Andre monoumættede fedtsyrer
        public string C182n6 { get; set; } // C18:2,n-6 Linolsyre; cis-9,12-octadecadiensyre; (9Z,12Z)-9,12-octadecadienoic acid; 
        public string C182conjA { get; set; } // C18:2,conj-A Conjugeret Linolsyre (CLA), udifferentieret; Conjugated linoleic acids (CLA); 9,t11-CLA (1)
        public string C182trans { get; set; } // C18:2,trans trans-Linolsyre udifferentieret; 
        public string C183n3 { get; set; } // C18:3,n-3 α-Linolensyre; cis 9,12,15-octadecatriensyre; (9Z,12Z,15Z)-9,12,15-octadecatrienoic acid
        public string C183n6 { get; set; } // C18:3,n-6 γ-Linolensyre; cis 6,9,12-octadecatriensyre; 6Z,9Z,12Z-octadecatrienoic acid
        public string C184n3 { get; set; } // C18:4,n-3 Steridonsyre; cis-6,9,12,15-octadecatetraensyre; (6Z,9Z,12Z,15Z)-6,9,12,15-octadecatetraenoic acid
        public string C202n6 { get; set; } // C20:2,n-6 cis-11,14-eicosadiensyre; 11Z,14Z-eicosadienoic acid
        public string C204n3 { get; set; } // C20:4,n-3 n-3 Arachidonic acid 8Z,11Z,14Z,17Z-Eicosatetraenoic Acid
        public string C203n3 { get; set; } // C20:3,n-3 Eicosatrienoic acid ETE; all-cis-11,14,17-eicosatrienoic acid; 11Z,14Z,17Z-eicosatrienoic acid
        public string C203n6 { get; set; } // C20:3,n-6 Dihomo-γ-linolensyre DGLA; cis-8,11,14-eicosatrienoic acid; 8Z,11Z,14Z-eicosatrienoic acid
        public string C204n6 { get; set; } // C20:4,n-6 arachidonsyre; cis 5,8,11,14-eicosatetraensyre; (5Z,8Z,11Z,14Z)-5,8,11,14-Eicosatetraenoic acid
        public string C205n3 { get; set; } // C20:5,n-3 timnodonsyre, EPA cis 5,8,11,14,17-eicosapentaensyre; (5Z,8Z,11Z,14Z,17Z)-Eicosapentaenoic acid
        public string C225n3 { get; set; } // C22:5,n-3 clupanodonsyre DPA cis 7,10,13,16,19-docosapentaensyre; (7Z,10Z,13Z,16Z,19Z)-7,10,13,16,19-Docosapentaenoic acid
        public string C226n3 { get; set; } // C22:6,n-3 cervonic acid DHA cis 4,7,10,13,16,19-docosahexaensyre
        public string AndrePolymaettedeFedtsyrer { get; set; } // Andre Polymættede Fedtsyrer
        public string AndreFedtsyrer { get; set; }
        public string FedtsyrerTotal { get; set; }
        public string Sumn3Fedtsyrer { get; set; } // Sum n-3 fedtsyrer
        public string Sumn6Fedtsyrer { get; set; }
        public string Isoleucin { get; set; }
        public string Leucin { get; set; }
        public string Lysin { get; set; }
        public string Methionin { get; set; }
        public string Cystin { get; set; }
        public string Phenylalanin { get; set; }
        public string Tyrosin { get; set; }
        public string Threonin { get; set; }
        public string Tryptofan { get; set; }
        public string Valin { get; set; }
        public string Arginin { get; set; }
        public string Histidin { get; set; }
        public string Alanin { get; set; }
        public string Asparaginsyre { get; set; }
        public string Glutaminsyre { get; set; }
        public string Glycin { get; set; }
        public string Prolin { get; set; }
        public string Serin { get; set; }

        public FoodDto()
        {
            IsProtected = false;

            QuantityConverter = new QuantityConverter();
            //QuantityConverver.Quantities = new List<Quantity>();

            //foreach (var quantityType in QuantityType.Current.ListForQuantityConverter)
            //{
            //    QuantityConverver.Quantities.Add(new Quantity() { Name = quantityType, Value = 0.0 });
            //}

            DefaultQuantityType = QuantityType.gram;

            // Sæt alle properties til 0
            Clear();
        }


        public void Clear()
        {
            // Sæt alle værdier i QuantityConverter til nul
            QuantityConverter.Clear();

            // Sæt alle værdier i FoodDto til nul
            EnergiKj = "0";
            EnergiKcal = "0";
            ProteinTotal = "0";
            KulhydratTilgaengelig = "0";
            TilsatSukker = "0";
            Kostfiber = "0";
            FedtTotal = "0";
            Alkohol = "0";
            Torstof = "0";
            Vand = "0";

            Avitamin = "0";
            Retinol = "0";
            Bcaroten = "0";
            Dvitamin = "0";
            D3cholecalciferol = "0";
            Evitamin = "0";
            AlfaTokoferol = "0";
            K1vitamin = "0";
            B1vitamin = "0";
            B2vitaminRiboflavin = "0";
            Niacin = "0";
            Niacin2 = "0";
            B6vitamin = "0";
            Pantothensyre = "0";
            Biotin = "0";
            Folat = "0";
            B12vitamin = "0";
            Cvitamin = "0";
            Lascorbinsyre = "0";

            Chlorid = "0";
            Natrium = "0";
            Kalium = "0";
            Calcium = "0";
            Magnesium = "0";
            Phosphor = "0";
            Jern = "0";
            Kobber = "0";
            Zink = "0";
            Jod = "0";
            Mangan = "0";
            Chrom = "0";
            Selen = "0";
            Molybdbaen = "0";
            Nikkel = "0";
            Cadmium = "0";
            Bly = "0";

        }

    }
}
