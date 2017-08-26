using SharedLib.Extensions;
using System;

namespace SharedLib.Models
{
    public class Food : BaseModel
    {
        #region private fields

        private string _name;
        private string _defaultQuantityType;
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
        private string _transFedtsyrerTotal;
        private string _cholesterol;
        #endregion

        #region public properties

        public Guid Id { get; set; }

        public int FoodId { get; set; }

        public string Name
        {
            get { return _name; }
            set { SetValue(ref _name, value); }
        }

        public QuantityConverter QuantityConverver { get; set; }

        public string DefaultQuantityType
        {
            get { return _defaultQuantityType; }
            set { SetValue(ref _defaultQuantityType, value); }
        }

        public string EnergiKj
        {
            get { return _energiKj; }
            set { SetValue(ref _energiKj, value); }
        }
        public string EnergiKcal
        {
            get { return _energiKcal; }
            set { SetValue(ref _energiKcal, value); }
        }
        public string ProteinTotal
        {
            get { return _proteinTotal; }
            set { SetValue(ref _proteinTotal, value); }
        }
        public string KulhydratDifferens
        {
            get { return _kulhydratDifferens; }
            set { SetValue(ref _kulhydratDifferens, value); }
        }
        public string KulhydratTilgaengelig
        {
            get { return _kulhydratTilgaengelig; }
            set { SetValue(ref _kulhydratTilgaengelig, value); }
        }
        public string TilsatSukker
        {
            get { return _tilsatSukker; }
            set { SetValue(ref _tilsatSukker, value); }
        }
        public string Kostfiber
        {
            get { return _kostfiber; }
            set { SetValue(ref _kostfiber, value); }
        }
        public string FedtTotal
        {
            get { return _fedtTotal; }
            set { SetValue(ref _fedtTotal, value); }
        }

        public string Avitamin
        {
            get { return _avitamin; }
            set { SetValue(ref _avitamin, value); }
        }
        public string Dvitamin
        {
            get { return _dvitamin; }
            set { SetValue(ref _dvitamin, value); }
        }
        public string Evitamin
        {
            get { return _evitamin; }
            set { SetValue(ref _evitamin, value); }
        }
        public string K1vitamin
        {
            get { return _k1vitamin; }
            set { SetValue(ref _k1vitamin, value); }
        }
        public string B12vitamin
        {
            get { return _b12vitamin; }
            set { SetValue(ref _b12vitamin, value); }
        }
        public string Cvitamin
        {
            get { return _cvitamin; }
            set { SetValue(ref _cvitamin, value); }
        }
        public string Calcium
        {
            get { return _calcium; }
            set { SetValue(ref _calcium, value); }
        }
        public string Magnesium
        {
            get { return _magnesium; }
            set { SetValue(ref _magnesium, value); }
        }
        public string Jern
        {
            get { return _jern; }
            set { SetValue(ref _jern, value); }
        }
        public string Zink
        {
            get { return _zink; }
            set { SetValue(ref _zink, value); }
        }
        public string Selen
        {
            get { return _selen; }
            set { SetValue(ref _selen, value); }
        }
        public string Cadmium
        {
            get { return _cadmium; }
            set { SetValue(ref _cadmium, value); }
        }
        public string SumMaettedeFedtsyrer
        {
            get { return _sumMaettedeFedtsyrer; }
            set { SetValue(ref _sumMaettedeFedtsyrer, value); }
        }
        public string SumMonoumaettedeFedtsyrer
        {
            get { return _sumMonoumaettedeFedtsyrer; }
            set { SetValue(ref _sumMonoumaettedeFedtsyrer, value); }
        }
        public string SumPolymaettedeFedtsyrer
        {
            get { return _sumPolymaettedeFedtsyrer; }
            set { SetValue(ref _sumPolymaettedeFedtsyrer, value); }
        }
        public string TransFedtsyrerTotal
        {
            get { return _transFedtsyrerTotal; }
            set { SetValue(ref _transFedtsyrerTotal, value); }
        }
        public string Cholesterol
        {
            get { return _cholesterol; }
            set { SetValue(ref _cholesterol, value); }
        }

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
        #endregion

        public Food()
        {
            //Id = new Guid();
            QuantityConverver = new QuantityConverter();
            DefaultQuantityType = QuantityType.gram;
        }
    }
}
