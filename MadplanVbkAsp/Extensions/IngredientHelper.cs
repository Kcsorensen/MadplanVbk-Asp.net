//using System.ComponentModel;

//public enum IngredientHelper
//{
//    //[Description("Frisk æggehvide")]
//    //Friskæggehvide,
//    [Description("1159")]
//    Friskæggehvide,
//    [Description("281")]
//    Havregryn,
//    [Description("711")]
//    Peberfrugt,
//    [Description("1186")]
//    RevetOst,
//    [Description("685")]
//    Olivenolie,
//    [Description("Rapsolie")]
//    Rapsolie,
//    [Description("1143")]
//    Æg,
//    [Description("905")]
//    SkinkePålæg,
//    [Description("1036")]
//    Tomat,
//    [Description("1178")]
//    Pitabrød,
//    [Description("882")]
//    Sennep,
//    [Description("259")]
//    Gulerod,
//    [Description("362")]
//    Hytteost,
//    [Description("Rugflager")]
//    Rugflager,
//    [Description("Æblemost")]
//    Æblemost,
//    [Description("Æble")]
//    Æble,
//    [Description("Hasselnødder")]
//    Hasselnødder,
//    [Description("Honning")]
//    Honning,
//    [Description("921")]
//    Skyr,
//    [Description("1177")]
//    Granola,
//    [Description("801")]
//    Rugbrød,
//    [Description("Nøddepread")]
//    Nøddepread,
//    [Description("Fuldkornsknækbrød")]
//    Fuldkornsknækbrød,
//    [Description("Agurk")]
//    Agurk,
//    [Description("Koncentreret solbærsaft")]
//    Solbærsaft,
//    [Description("Rosiner")]
//    Rosiner,
//    [Description("588")]
//    Mandler,
//    [Description("Chiafrø")]
//    Chiafrø,
//    [Description("Kanel")]
//    Kanel,
//    [Description("Fintrevet citronskal")]
//    Citronskal,
//    [Description("Mælk")]
//    Mælk,
//    [Description("Friske Bær")]
//    Bær,
//    [Description("Hummus")]
//    Hummus,
//    [Description("Tørrende grønne ærter")]
//    TørrendeGrønneÆrter,
//    [Description("Fed hvidløg")]
//    Hvidløg,
//    [Description("Spidskommen")]
//    Spidskommen,
//    [Description("Græskarkerner")]
//    Græskarkerner,
//    [Description("Citron")]
//    Citron,
//    [Description("AC-spread")]
//    ACspread,
//    [Description("Fennikel")]
//    Fennikel,
//    [Description("Parmaskinke")]
//    Parmaskinke,
//    [Description("Frisk dild")]
//    Dild,
//    [Description("Rugkerner")]
//    Rugkerner,
//    [Description("Fishsauce")]
//    Fishsauce,
//    [Description("Frisk basilikum")]
//    Basilikum,
//    [Description("Skæreost")]
//    Skæreost,
//    [Description("Æbleeddike")]
//    Æbleeddike,
//    [Description("Fuldkornswrap")]
//    Fuldkornswrap,
//    [Description("Spidskål")]
//    Spidskål,
//    [Description("Kyllingbryst")]
//    Kyllingbryst,
//    [Description("Karry")]
//    Karry,
//    [Description("Tabasco")]
//    Tabasco,
//    [Description("Kyllingelår")]
//    Kyllingelår,
//    [Description("Lakridspulver")]
//    Lakridspulver,
//    [Description("Grønne linser")]
//    GrønneLinser,
//    [Description("Lime")]
//    Lime,
//    [Description("Frisk Timian")]
//    Timian,
//    [Description("Persillerod")]
//    Persillerod,
//    [Description("Solsikkekerner")]
//    Solsikkekerner,
//    [Description("Frisk persille")]
//    Persille,
//    [Description("Sesamfrø")]
//    Sesamfrø,
//    //[Description("Fuldkornspitabrød")]
//    //Fuldkornspitabrød,
//    [Description("Kakaonibs")]
//    Kakaonibs,
//    [Description("Pære")]
//    Pære,
//    [Description("Mozzarella")]
//    Mozzarella,
//    [Description("Kiwi")]
//    Kiwi,
//    [Description("Mango")]
//    Mango,
//    [Description("Frisk mynte")]
//    Mynte,
//    [Description("Emmentaler")]
//    Emmentaler,
//    [Description("Tun i vand")]
//    Tun,
//    [Description("Radicchio")]
//    Radicchio,
//    [Description("Kartofler")]
//    Kartofler,
//    [Description("Drueagurker")]
//    Drueagurker,
//    [Description("Makrel i tomat")]
//    Makrel,
//    [Description("Oliven")]
//    Oliven,
//    [Description("Cornichoner")]
//    Cornichoner,
//    [Description("Majs")]
//    Majs,
//    [Description("Hakkede tomater")]
//    HakkedeTomater,
//    [Description("Frisk chili")]
//    Chili,
//    [Description("Wontondej (el. folidej)")]
//    Wontondej,
//    [Description("Torskerogn")]
//    Torskerogn,
//    [Description("Radiser")]
//    Radiser,
//    [Description("Karse")]
//    Karse,
//    [Description("Fuldkornsbrød")]
//    Fuldkornsbrød,
//    [Description("Blomkålsbuketter")]
//    Blomkålsbuketter,
//    [Description("Rødløg")]
//    Rødløg,
//    [Description("Hel dansk kylling")]
//    HelKylling,
//    [Description("Nelliker")]
//    Nelliker,
//    [Description("Aubergine")]
//    Aubergine,
//    [Description("Pecorinoost")]
//    Pecorinoost,
//    [Description("Bruse ris")]
//    BruneRis,
//    [Description("Blå druer")]
//    BlåDruer,
//    [Description("Laurbærblade")]
//    Laurbærblade,
//    [Description("Hvidkål")]
//    Hvidkål,
//    [Description("Laksefilet")]
//    Laksefilet,
//    [Description("Avokado")]
//    Avokado,
//    [Description("Frosne ærter")]
//    FrosneÆrter,
//    [Description("Frisk ingegær")]
//    Ingegær,
//    [Description("Kikærter")]
//    Kikærter,
//    [Description("Wasabi")]
//    Wasabi,
//    [Description("Sojasovs")]
//    Sojasovs,
//    [Description("Syltede asier")]
//    SyltedeAsier,
//    [Description("Rødkål")]
//    Rødkål,
//    [Description("Rejer")]
//    Rejer,
//    [Description("Grapefrugt")]
//    Grapefrugt,
//    [Description("Torsk")]
//    Torsk,
//    [Description("Knoldselleri")]
//    Knoldselleri,
//    [Description("Jordskok")]
//    Jordskok,
//    [Description("Vindruekerneolie")]
//    Vindruekerneolie,
//    [Description("Vineddike")]
//    Vineddike,
//    [Description("Purløg")]
//    Purløg,
//    [Description("Hakket oksekød")]
//    HakketOksekød,
//    [Description("Flåede tomater")]
//    FlåedeTomater,
//    [Description("Grov paste")]
//    GrovPasta,
//    [Description("Parmesanost")]
//    Parmesanost,
//    [Description("Bønner i tomat")]
//    Bønner,
//    [Description("Mørk øl")]
//    Øl,
//    [Description("Mørk chokolade")]
//    Chokolade,
//    [Description("Selleri")]
//    Selleri,
//    [Description("Rødbeder")]
//    Rødbeder,
//    [Description("Forårsløg")]
//    Forårsløg,
//    [Description("Rispapir")]
//    Rispapir,
//    [Description("Saltede peanuts")]
//    SaltedePeanuts,
//    [Description("Jordnøddeolie")]
//    Jordnøddeolie,
//    [Description("Hakket kalv og okse")]
//    HakketKalvOgOkse,
//    [Description("Frosne edamamebønner")]
//    Edamamebønner,
//    [Description("Frossen tomatpizza")]
//    Pizza,
//    [Description("Forårsrulledej")]
//    Forårsrulledej,
//    [Description("Små chorizopølser")]
//    Chorizopølser,
//    [Description("Broccoli")]
//    Broccoli,
//    [Description("Kalvekotelet med ben")]
//    Kalvekotelet,
//    [Description("Hjertesalat")]
//    Hjertesalat,
//    [Description("Rød appelsin")]
//    RødAppelsin,
//    [Description("Svinekotelet")]
//    Svinekotelet,
//    [Description("Oksebøf")]
//    Oksebøf,
//    [Description("Eddike")]
//    Eddike,
//    [Description("Rosmarin")]
//    Rosmarin,
//    [Description("Fiskefilet")]
//    Fiskefilet,
//    [Description("Mysli")]
//    Mysli,
//}
