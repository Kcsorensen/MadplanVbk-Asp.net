using MadplanVbkAsp.Extensions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MadplanVbkAsp.Models
{
    public class Food : BaseModel
    {
        #region Private fields

        private string _name;
        private string _energiKj;
        private string _energiKcal;
        private string _proteinTotal;
        private string _kulhydratDifferens;
        private string _kulhydratTilgaengelig;
        private string _tilsatSukker;
        private string _kostfiber;
        private string _fedtTotal;
        private string _avitamin;
        private string _dvitamin;
        private string _evitamin;
        private string _k1vitamin;
        private string _b12vitamin;
        private string _cvitamin;
        private string _calcium;
        private string _magnesium;
        private string _jern;
        private string _zink;
        private string _selen;
        private string _sumMaettedeFedtsyrer;
        private string _cadmium;
        private string _sumMonoumaettedeFedtsyrer;
        private string _sumPolymaettedeFedtsyrer;
        private string _transFedtsyrer;
        private string _cholesterol;

        #endregion

        #region Public properties

        [Key]
        public int Id { get; set; }

        //public int FoodId { get; set; }

        [ForeignKey("QuantityConverterId")]
        public QuantityConverter QuantityConverter { get; set; }

        [MaxLength(255)]
        [Required]
        public string Name
        {
            get { return _name; }
            set { SetValue(ref _name, value); }
        }

        [MaxLength(50)]
        public string EnergiKj
        {
            get { return _energiKj; }
            set { SetValue(ref _energiKj, value); }
        }

        [MaxLength(50)]
        public string EnergiKcal
        {
            get { return _energiKcal; }
            set { SetValue(ref _energiKcal, value); }
        }

        [MaxLength(50)]
        public string ProteinTotal
        {
            get { return _proteinTotal; }
            set { SetValue(ref _proteinTotal, value); }
        }

        [MaxLength(50)]
        public string KulhydratDifferens
        {
            get { return _kulhydratDifferens; }
            set { SetValue(ref _kulhydratDifferens, value); }
        }

        [MaxLength(50)]
        public string KulhydratTilgaengelig
        {
            get { return _kulhydratTilgaengelig; }
            set { SetValue(ref _kulhydratTilgaengelig, value); }
        }

        [MaxLength(50)]
        public string TilsatSukker
        {
            get { return _tilsatSukker; }
            set { SetValue(ref _tilsatSukker, value); }
        }

        [MaxLength(50)]
        public string Kostfiber
        {
            get { return _kostfiber; }
            set { SetValue(ref _kostfiber, value); }
        }

        //[MaxLength(50)]
        //public string FedtTotal
        //{
        //    get { return _fedtTotal; }
        //    set { SetValue(ref _fedtTotal, value); }
        //}

        //[MaxLength(50)]
        //public string Avitamin
        //{
        //    get { return _avitamin; }
        //    set { SetValue(ref _avitamin, value); }
        //}

        //[MaxLength(50)]
        //public string Dvitamin
        //{
        //    get { return _dvitamin; }
        //    set { SetValue(ref _dvitamin, value); }
        //}

        //[MaxLength(50)]
        //public string Evitamin
        //{
        //    get { return _evitamin; }
        //    set { SetValue(ref _evitamin, value); }
        //}

        //[MaxLength(50)]
        //public string K1vitamin
        //{
        //    get { return _k1vitamin; }
        //    set { SetValue(ref _k1vitamin, value); }
        //}

        //[MaxLength(50)]
        //public string B12vitamin
        //{
        //    get { return _b12vitamin; }
        //    set { SetValue(ref _b12vitamin, value); }
        //}

        //[MaxLength(50)]
        //public string Cvitamin
        //{
        //    get { return _cvitamin; }
        //    set { SetValue(ref _cvitamin, value); }
        //}

        //[MaxLength(50)]
        //public string Calcium
        //{
        //    get { return _calcium; }
        //    set { SetValue(ref _calcium, value); }
        //}

        //[MaxLength(50)]
        //public string Magnesium
        //{
        //    get { return _magnesium; }
        //    set { SetValue(ref _magnesium, value); }
        //}

        //[MaxLength(50)]
        //public string Jern
        //{
        //    get { return _jern; }
        //    set { SetValue(ref _jern, value); }
        //}

        //[MaxLength(50)]
        //public string Zink
        //{
        //    get { return _zink; }
        //    set { SetValue(ref _zink, value); }
        //}

        //[MaxLength(50)]
        //public string Selen
        //{
        //    get { return _selen; }
        //    set { SetValue(ref _selen, value); }
        //}

        //[MaxLength(50)]
        //public string Cadmium
        //{
        //    get { return _cadmium; }
        //    set { SetValue(ref _cadmium, value); }
        //}

        //[MaxLength(50)]
        //public string SumMaettedeFedtsyrer
        //{
        //    get { return _sumMaettedeFedtsyrer; }
        //    set { SetValue(ref _sumMaettedeFedtsyrer, value); }
        //}

        //[MaxLength(50)]
        //public string SumMonoumaettedeFedtsyrer
        //{
        //    get { return _sumMonoumaettedeFedtsyrer; }
        //    set { SetValue(ref _sumMonoumaettedeFedtsyrer, value); }
        //}

        //[MaxLength(50)]
        //public string SumPolymaettedeFedtsyrer
        //{
        //    get { return _sumPolymaettedeFedtsyrer; }
        //    set { SetValue(ref _sumPolymaettedeFedtsyrer, value); }
        //}

        //[MaxLength(50)]
        //public string TransFedtsyrer
        //{
        //    get { return _transFedtsyrer; }
        //    set { SetValue(ref _transFedtsyrer, value); }
        //}

        //[MaxLength(50)]
        //public string Cholesterol
        //{
        //    get { return _cholesterol; }
        //    set { SetValue(ref _cholesterol, value); }
        //}

        //[MaxLength(50)]
        //public string TransFedtsyrerTotal { get; set; }

        //[MaxLength(50)]
        //public string Svind { get; set; }

        //[MaxLength(50)]
        //public string Ncf { get; set; } // Proteinomregningsfaktor(NCF)

        //[MaxLength(50)]
        //public string TotalN { get; set; }

        //[MaxLength(50)]
        //public string ProteinDeklaration { get; set; }

        //[MaxLength(50)]
        //public string KulhydratDeklaration { get; set; }

        //[MaxLength(50)]
        //public string FCF { get; set; } // Fedtsyrekonverteringsfaktor (FCF)

        //[MaxLength(50)]
        //public string Alkohol { get; set; }

        //[MaxLength(50)]
        //public string Aske { get; set; }

        //[MaxLength(50)]
        //public string Torstof { get; set; } // Tørstof

        //[MaxLength(50)]
        //public string Vand { get; set; }

        //[MaxLength(50)]
        //public string Retinol { get; set; }

        //[MaxLength(50)]
        //public string Bcaroten { get; set; }

        //[MaxLength(50)]
        //public string D3cholecalciferol { get; set; }

        //[MaxLength(50)]
        //public string Hydroxycholecalciferol { get; set; } // 25-hydroxycholecalciferol

        //[MaxLength(50)]
        //public string AlfaTokoferol { get; set; }

        //[MaxLength(50)]
        //public string GammaTokoferol { get; set; }

        //[MaxLength(50)]
        //public string DeltaTokoferol { get; set; }

        //[MaxLength(50)]
        //public string AlfaTokotrienol { get; set; }

        //[MaxLength(50)]
        //public string B1vitamin { get; set; }

        //[MaxLength(50)]
        //public string Thiamin { get; set; }

        //[MaxLength(50)]
        //public string HET { get; set; } // HET, hydroxyethylthiazole

        //[MaxLength(50)]
        //public string B2vitaminRiboflavin { get; set; }

        //[MaxLength(50)]
        //public string Niacin { get; set; }

        //[MaxLength(50)]
        //public string Niacin2 { get; set; }

        //[MaxLength(50)]
        //public string B6vitamin { get; set; }

        //[MaxLength(50)]
        //public string Pantothensyre { get; set; }

        //[MaxLength(50)]
        //public string Biotin { get; set; }

        //[MaxLength(50)]
        //public string Folat { get; set; }

        //[MaxLength(50)]
        //public string FritFolat { get; set; }

        //[MaxLength(50)]
        //public string Lascorbinsyre { get; set; } // L-ascorbinsyre

        //[MaxLength(50)]
        //public string Ldehydroascorbinsyre { get; set; } // L-dehydroascorbinsyre

        //[MaxLength(50)]
        //public string Chlorid { get; set; }

        //[MaxLength(50)]
        //public string Natrium { get; set; }

        //[MaxLength(50)]
        //public string Kalium { get; set; }

        //[MaxLength(50)]
        //public string Phosphor { get; set; }

        //[MaxLength(50)]
        //public string Kobber { get; set; }

        //[MaxLength(50)]
        //public string Jod { get; set; }

        //[MaxLength(50)]
        //public string Mangan { get; set; }

        //[MaxLength(50)]
        //public string Chrom { get; set; }

        //[MaxLength(50)]
        //public string Molybdbaen { get; set; } // Molybdæm

        //[MaxLength(50)]
        //public string Cobolt { get; set; }

        //[MaxLength(50)]
        //public string Nikkel { get; set; }

        //[MaxLength(50)]
        //public string Kviksolv { get; set; } // Kviksølv

        //[MaxLength(50)]
        //public string Arsen { get; set; }

        //[MaxLength(50)]
        //public string Bly { get; set; }

        //[MaxLength(50)]
        //public string Tin { get; set; }

        //[MaxLength(50)]
        //public string Lmaelkesyre { get; set; } // L-mælkesyre

        //[MaxLength(50)]
        //public string Dmaelkesyre { get; set; } // D-mælkesyre

        //[MaxLength(50)]
        //public string MaelkesyreTotal { get; set; } // Mælkesyre, Total

        //[MaxLength(50)]
        //public string Citronsyre { get; set; }

        //[MaxLength(50)]
        //public string Oxalsyre { get; set; }

        //[MaxLength(50)]
        //public string Aeblesyre { get; set; } // Æblesyre

        //[MaxLength(50)]
        //public string Eddikesyre { get; set; }

        //[MaxLength(50)]
        //public string Benzoesyre { get; set; }

        //[MaxLength(50)]
        //public string OrganiskeSyrerTotal { get; set; }

        //[MaxLength(50)]
        //public string Histamin { get; set; }

        //[MaxLength(50)]
        //public string Tyramin { get; set; }

        //[MaxLength(50)]
        //public string Phenylethylamin { get; set; }

        //[MaxLength(50)]
        //public string Putrescin { get; set; }

        //[MaxLength(50)]
        //public string Cadaverin { get; set; }

        //[MaxLength(50)]
        //public string Spermin { get; set; }

        //[MaxLength(50)]
        //public string Spermidin { get; set; }

        //[MaxLength(50)]
        //public string Serotonin { get; set; }

        //[MaxLength(50)]
        //public string Fructose { get; set; }

        //[MaxLength(50)]
        //public string Galaktose { get; set; }

        //[MaxLength(50)]
        //public string Glycose { get; set; }

        //[MaxLength(50)]
        //public string MonosacchariderTotal { get; set; }

        //[MaxLength(50)]
        //public string Lactose { get; set; }

        //[MaxLength(50)]
        //public string Maltose { get; set; }

        //[MaxLength(50)]
        //public string Saccharose { get; set; }

        //[MaxLength(50)]
        //public string DisacchariderTotal { get; set; }

        //[MaxLength(50)]
        //public string Raffinose { get; set; }

        //[MaxLength(50)]
        //public string AndreSukkerarter { get; set; }

        //[MaxLength(50)]
        //public string SukkerarterIalt { get; set; }

        //[MaxLength(50)]
        //public string Sorbitol { get; set; }

        //[MaxLength(50)]
        //public string Mannitol { get; set; }

        //[MaxLength(50)]
        //public string Inositol { get; set; }

        //[MaxLength(50)]
        //public string Maltitol { get; set; }

        //[MaxLength(50)]
        //public string SukkerAlkoholerTotal { get; set; }

        //[MaxLength(50)]
        //public string Stivelse { get; set; }

        //[MaxLength(50)]
        //public string Hexoses { get; set; }

        //[MaxLength(50)]
        //public string Pentoses { get; set; }

        //[MaxLength(50)]
        //public string UronicAcids { get; set; }

        //[MaxLength(50)]
        //public string Cellulose { get; set; }

        //[MaxLength(50)]
        //public string Lignin { get; set; }

        //[MaxLength(50)]
        //public string CrudeFibre { get; set; }

        //[MaxLength(50)]
        //public string NDF { get; set; } // Neutr.Det.Fibre (NDF)

        //[MaxLength(50)]
        //public string C40 { get; set; } // C4:0 Smørsyre; Butansyre; Butanoic acid

        //[MaxLength(50)]
        //public string C60 { get; set; } // C6:0 Capronsyre; Hexansyre; Hexanoic acid

        //[MaxLength(50)]
        //public string C80 { get; set; } // C8:0 Caprylsyre; Octansyre; Octanoic acid

        //[MaxLength(50)]
        //public string C100 { get; set; } // C10:0 Caprinsyre; Decansyre; Decanoic acid

        //[MaxLength(50)]
        //public string C120 { get; set; } // C12:0 Laurinsyre; Dodecansyre; Dodecanoic acid

        //[MaxLength(50)]
        //public string C140 { get; set; } // C14:0 Myristinsyre; Tetradecansyre; Tetradecanoic acid

        //[MaxLength(50)]
        //public string C150 { get; set; } // C15:0 Pentadecansyre; Pentadecanoic acid

        //[MaxLength(50)]
        //public string C160 { get; set; } // C16:0 Palmitinsyre; Hexadecansyre; Hexadecanoic acid

        //[MaxLength(50)]
        //public string C170 { get; set; } // C17:0 Margarinsyre; Heptadecansyre; Heptadecanoic acid

        //[MaxLength(50)]
        //public string C180 { get; set; } // C18:0 Stearinsyre; Octadecansyre; Octadecanoic acid

        //[MaxLength(50)]
        //public string C200 { get; set; } // C20:0 Arachinsyre; Eicosansyre; Eicosanoic acid

        //[MaxLength(50)]
        //public string C220 { get; set; } // C22:0 Behensyre; Docosansyre; Docosanoic acid

        //[MaxLength(50)]
        //public string C240 { get; set; } // C24:0 Lignocerinsyre; Tetracosansyre; Tetracosanoic acid

        //[MaxLength(50)]
        //public string AndreMaettedeFedtsyrer { get; set; } // Andre mættede fedtsyrer

        //[MaxLength(50)]
        //public string C141n5 { get; set; } // C14:1,n-5 Myristoleinsyre; cis-9-Tetradecensyre; (Z)-Tetradec-9-enoic acid

        //[MaxLength(50)]
        //public string C151 { get; set; } // C15:1 Pentadecensyre; (Z)-Pentadec-10-enoic acid

        //[MaxLength(50)]
        //public string C161n7 { get; set; } // C16:1,n-7 Palmitoleinsyre; cis-9-Hexadecensyre; (Z)-Hexadec-9-enoic acid

        //[MaxLength(50)]
        //public string C161trans { get; set; } // C16:1,trans Palmitelaidinsyre; trans-Hexadecensyre; (E)-Hexadec-9-enoic acid

        //[MaxLength(50)]
        //public string C171n7 { get; set; } // C17:1,n-7 cis-10-Heptadecensyre; (Z)-Heptadec-10-enoic acid

        //[MaxLength(50)]
        //public string C181n9 { get; set; } // C18:1,n-9 Oliesyre; cis-9-Octadecensyre; (Z)-Octadec-9-enoic acid

        //[MaxLength(50)]
        //public string C181n7 { get; set; } // C18:1,n-7 cis-Vaccensyre; cis-11-Octacecansyre; (Z)-Octadec-11-enoic acid

        //[MaxLength(50)]
        //public string C181trans { get; set; } // C18:1,t n-9 Elaidinsyre; trans 9-Octadecensyre; (E)-octadec-9-enoic acid

        //[MaxLength(50)]
        //public string C201n9 { get; set; } // C20:1,n-9 Gondoinsyre; cis-11-Eicosensyre; (11Z)-Eicosenoic acid; 

        //[MaxLength(50)]
        //public string C201n11 { get; set; } // C20:1,n-11 Gadoleinsyre; cis-9-Eicosensyre; cis-9-Eicosenoic acid; (9Z)-9-Eicosenoic acid

        //[MaxLength(50)]
        //public string C201trans { get; set; } // C20:1,trans trans-11-Eicosensyre; trans-11-Eicosenoic acid

        //[MaxLength(50)]
        //public string C221n9 { get; set; } // C22:1,n-9 Erukasyre; cis-13-docosensyre, (Z)-docos-13-enoic acid

        //[MaxLength(50)]
        //public string C221n11 { get; set; } // C22:1,n-11 Cetoleinsyre; cis-11-docosensyre; (11Z)-11-Docosenoic acid

        //[MaxLength(50)]
        //public string C221trans { get; set; } // C22:1,n-9,trans Brassidic; acid trans-13-docosensyre; (E)-13-Docosenoic acid

        //[MaxLength(50)]
        //public string C241n9 { get; set; } // C24:1,n-9 Nervonsyre; cis-15-tetracosensyre; (Z)-Tetracos-15-enoic acid

        //[MaxLength(50)]
        //public string AndreMonoumaettedeFedtsyrer { get; set; } // Andre monoumættede fedtsyrer

        //[MaxLength(50)]
        //public string C182n6 { get; set; } // C18:2,n-6 Linolsyre; cis-9,12-octadecadiensyre; (9Z,12Z)-9,12-octadecadienoic acid; 

        //[MaxLength(50)]
        //public string C182conjA { get; set; } // C18:2,conj-A Conjugeret Linolsyre (CLA), udifferentieret; Conjugated linoleic acids (CLA); 9,t11-CLA (1)

        //[MaxLength(50)]
        //public string C182trans { get; set; } // C18:2,trans trans-Linolsyre udifferentieret; 

        //[MaxLength(50)]
        //public string C183n3 { get; set; } // C18:3,n-3 α-Linolensyre; cis 9,12,15-octadecatriensyre; (9Z,12Z,15Z)-9,12,15-octadecatrienoic acid

        //[MaxLength(50)]
        //public string C183n6 { get; set; } // C18:3,n-6 γ-Linolensyre; cis 6,9,12-octadecatriensyre; 6Z,9Z,12Z-octadecatrienoic acid

        //[MaxLength(50)]
        //public string C184n3 { get; set; } // C18:4,n-3 Steridonsyre; cis-6,9,12,15-octadecatetraensyre; (6Z,9Z,12Z,15Z)-6,9,12,15-octadecatetraenoic acid

        //[MaxLength(50)]
        //public string C202n6 { get; set; } // C20:2,n-6 cis-11,14-eicosadiensyre; 11Z,14Z-eicosadienoic acid

        //[MaxLength(50)]
        //public string C204n3 { get; set; } // C20:4,n-3 n-3 Arachidonic acid 8Z,11Z,14Z,17Z-Eicosatetraenoic Acid

        //[MaxLength(50)]
        //public string C203n3 { get; set; } // C20:3,n-3 Eicosatrienoic acid ETE; all-cis-11,14,17-eicosatrienoic acid; 11Z,14Z,17Z-eicosatrienoic acid

        //[MaxLength(50)]
        //public string C203n6 { get; set; } // C20:3,n-6 Dihomo-γ-linolensyre DGLA; cis-8,11,14-eicosatrienoic acid; 8Z,11Z,14Z-eicosatrienoic acid

        //[MaxLength(50)]
        //public string C204n6 { get; set; } // C20:4,n-6 arachidonsyre; cis 5,8,11,14-eicosatetraensyre; (5Z,8Z,11Z,14Z)-5,8,11,14-Eicosatetraenoic acid

        //[MaxLength(50)]
        //public string C205n3 { get; set; } // C20:5,n-3 timnodonsyre, EPA cis 5,8,11,14,17-eicosapentaensyre; (5Z,8Z,11Z,14Z,17Z)-Eicosapentaenoic acid

        //[MaxLength(50)]
        //public string C225n3 { get; set; } // C22:5,n-3 clupanodonsyre DPA cis 7,10,13,16,19-docosapentaensyre; (7Z,10Z,13Z,16Z,19Z)-7,10,13,16,19-Docosapentaenoic acid

        //[MaxLength(50)]
        //public string C226n3 { get; set; } // C22:6,n-3 cervonic acid DHA cis 4,7,10,13,16,19-docosahexaensyre

        //[MaxLength(50)]
        //public string AndrePolymaettedeFedtsyrer { get; set; } // Andre Polymættede Fedtsyrer

        //[MaxLength(50)]
        //public string AndreFedtsyrer { get; set; }

        //[MaxLength(50)]
        //public string FedtsyrerTotal { get; set; }

        //[MaxLength(50)]
        //public string Sumn3Fedtsyrer { get; set; } // Sum n-3 fedtsyrer

        //[MaxLength(50)]
        //public string Sumn6Fedtsyrer { get; set; }

        //[MaxLength(50)]
        //public string Isoleucin { get; set; }

        //[MaxLength(50)]
        //public string Leucin { get; set; }

        //[MaxLength(50)]
        //public string Lysin { get; set; }

        //[MaxLength(50)]
        //public string Methionin { get; set; }

        //[MaxLength(50)]
        //public string Cystin { get; set; }

        //[MaxLength(50)]
        //public string Phenylalanin { get; set; }

        //[MaxLength(50)]
        //public string Tyrosin { get; set; }

        //[MaxLength(50)]
        //public string Threonin { get; set; }

        //[MaxLength(50)]
        //public string Tryptofan { get; set; }

        //[MaxLength(50)]
        //public string Valin { get; set; }

        //[MaxLength(50)]
        //public string Arginin { get; set; }

        //[MaxLength(50)]
        //public string Histidin { get; set; }

        //[MaxLength(50)]
        //public string Alanin { get; set; }

        //[MaxLength(50)]
        //public string Asparaginsyre { get; set; }

        //[MaxLength(50)]
        //public string Glutaminsyre { get; set; }

        //[MaxLength(50)]
        //public string Glycin { get; set; }

        //[MaxLength(50)]
        //public string Prolin { get; set; }

        //[MaxLength(50)]
        //public string Serin { get; set; }

        #endregion

        public Food()
        {
            //QuantityConverter = new QuantityConverter();
        }
    }
}
